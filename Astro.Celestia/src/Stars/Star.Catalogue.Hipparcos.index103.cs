using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_103() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56885"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.92119445),
        dec: Angle.Degrees(+48.79271429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220274"},
        {"Hipparcos Number", "HIP 115363"},
        {"Smithsonian Astrophysical Observation", "SAO 52942"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.51259028),
        dec: Angle.Degrees(+48.79513940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31740"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.60235987),
        dec: Angle.Degrees(+48.79923521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -259.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19286"},
        {"Smithsonian Astrophysical Observation", "SAO 39324"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.00637788),
        dec: Angle.Degrees(+48.79973795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223136"},
        {"Hipparcos Number", "HIP 117286"},
        {"Smithsonian Astrophysical Observation", "SAO 53366"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.72709037),
        dec: Angle.Degrees(+48.80166068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23359"},
        {"Hipparcos Number", "HIP 17634"},
        {"Geneva Identification System", "GEN# +1.00023359"},
        {"Smithsonian Astrophysical Observation", "SAO 39091"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.67383265),
        dec: Angle.Degrees(+48.80200117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17479"},
        {"Henry Draper 2", "HD 17480"},
        {"Hipparcos Number", "HIP 13206"},
        {"Geneva Identification System", "GEN# +1.00017479"},
        {"Smithsonian Astrophysical Observation", "SAO 38374"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.49040263),
        dec: Angle.Degrees(+48.80212345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154732"},
        {"Hipparcos Number", "HIP 83575"},
        {"Fundamental Katalog 5th Edition", "FK5 3359"},
        {"Geneva Identification System", "GEN# +1.00154732"},
        {"Smithsonian Astrophysical Observation", "SAO 46476"},
        {"Wilson Evans Batten Catalogue", "WEB 14130"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.20727778),
        dec: Angle.Degrees(+48.80413179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24387"},
        {"Hipparcos Number", "HIP 18319"},
        {"Smithsonian Astrophysical Observation", "SAO 39189"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.74455721),
        dec: Angle.Degrees(+48.80567743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23604"},
        {"Hipparcos Number", "HIP 17811"},
        {"Smithsonian Astrophysical Observation", "SAO 39115"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.17225708),
        dec: Angle.Degrees(+48.80673944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56477"},
    },
    visualMagnitude: 11.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.68374983),
        dec: Angle.Degrees(+48.80760643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101980",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101980"},
        {"Smithsonian Astrophysical Observation", "SAO 49914"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.99954279),
        dec: Angle.Degrees(+48.80801832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45620"},
        {"Hipparcos Number", "HIP 31063"},
        {"Smithsonian Astrophysical Observation", "SAO 41140"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.78014912),
        dec: Angle.Degrees(+48.80830574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194355"},
        {"Hipparcos Number", "HIP 100534"},
        {"Geneva Identification System", "GEN# +1.00194355"},
        {"Smithsonian Astrophysical Observation", "SAO 49567"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.78324832),
        dec: Angle.Degrees(+48.81259595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95675"},
        {"Hipparcos Number", "HIP 54032"},
        {"Geneva Identification System", "GEN# +1.00095675"},
        {"Smithsonian Astrophysical Observation", "SAO 43593"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.82229619),
        dec: Angle.Degrees(+48.81351633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31733"},
        {"Hipparcos Number", "HIP 23307"},
        {"Smithsonian Astrophysical Observation", "SAO 39931"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.18752533),
        dec: Angle.Degrees(+48.81464868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76387",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9718 AB"},
        {"Henry Draper", "HD 139439"},
        {"Hipparcos Number", "HIP 76387"},
        {"Smithsonian Astrophysical Observation", "SAO 45631"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.02589279),
        dec: Angle.Degrees(+48.81596727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17744"},
        {"Hipparcos Number", "HIP 13409"},
        {"Geneva Identification System", "GEN# +1.00017744"},
        {"Smithsonian Astrophysical Observation", "SAO 38409"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.16628368),
        dec: Angle.Degrees(+48.81661390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221650"},
        {"Hipparcos Number", "HIP 116287"},
        {"Geneva Identification System", "GEN# +1.00221650"},
        {"Smithsonian Astrophysical Observation", "SAO 53146"},
        {"Wilson Evans Batten Catalogue", "WEB 20551"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.41648545),
        dec: Angle.Degrees(+48.81833360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204023"},
        {"Hipparcos Number", "HIP 105666"},
        {"Geneva Identification System", "GEN# +1.00204023"},
        {"Smithsonian Astrophysical Observation", "SAO 50802"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.04193139),
        dec: Angle.Degrees(+48.81928065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211228"},
        {"Hipparcos Number", "HIP 109818"},
        {"Smithsonian Astrophysical Observation", "SAO 51796"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.64784961),
        dec: Angle.Degrees(+48.82067583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68500"},
        {"Hipparcos Number", "HIP 40395"},
        {"Geneva Identification System", "GEN# +1.00068500"},
        {"Smithsonian Astrophysical Observation", "SAO 42241"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.70963257),
        dec: Angle.Degrees(+48.82122414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56268",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56268"},
        {"Smithsonian Astrophysical Observation", "SAO 43798"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.01897463),
        dec: Angle.Degrees(+48.82180672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212556"},
        {"Hipparcos Number", "HIP 110584"},
        {"Smithsonian Astrophysical Observation", "SAO 51967"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.05310092),
        dec: Angle.Degrees(+48.82188358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96455"},
        {"Hipparcos Number", "HIP 54387"},
        {"Smithsonian Astrophysical Observation", "SAO 43618"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.91518563),
        dec: Angle.Degrees(+48.82273419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2894"},
        {"Smithsonian Astrophysical Observation", "SAO 36507"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.18049134),
        dec: Angle.Degrees(+48.82833163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26443"},
    },
    visualMagnitude: 10.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.40383805),
        dec: Angle.Degrees(+48.82865143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61798"},
        {"Geneva Identification System", "GEN# +0.04902153"},
        {"Renson", "Renson 32020"},
        {"Smithsonian Astrophysical Observation", "SAO 44273"},
        {"Wilson Evans Batten Catalogue", "WEB 10994"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.98499958),
        dec: Angle.Degrees(+48.82887665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73762"},
        {"Smithsonian Astrophysical Observation", "SAO 45360"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.16725925),
        dec: Angle.Degrees(+48.83001118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64714"},
        {"Smithsonian Astrophysical Observation", "SAO 44532"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.95139813),
        dec: Angle.Degrees(+48.83382388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42782"},
        {"Hipparcos Number", "HIP 29681"},
        {"Celescope Catalog", "CEL 1131"},
        {"Geneva Identification System", "GEN# +1.00042782"},
        {"Smithsonian Astrophysical Observation", "SAO 40969"},
        {"Wilson Evans Batten Catalogue", "WEB 5847"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.79298884),
        dec: Angle.Degrees(+48.83397627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204411"},
        {"Hipparcos Number", "HIP 105898"},
        {"Celescope Catalog", "CEL 5313"},
        {"Geneva Identification System", "GEN# +1.00204411"},
        {"Renson", "Renson 56920"},
        {"Smithsonian Astrophysical Observation", "SAO 50867"},
        {"Wilson Evans Batten Catalogue", "WEB 19204"},
    },
    visualMagnitude: 5.29,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.71487481),
        dec: Angle.Degrees(+48.83510521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162500"},
        {"Hipparcos Number", "HIP 87188"},
        {"Smithsonian Astrophysical Observation", "SAO 46977"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.19278794),
        dec: Angle.Degrees(+48.83571021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110595"},
    },
    visualMagnitude: 11.34,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.07649131),
        dec: Angle.Degrees(+48.83727814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110448"},
        {"Smithsonian Astrophysical Observation", "SAO 51929"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.57477063),
        dec: Angle.Degrees(+48.84022423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25293"},
        {"Hipparcos Number", "HIP 18923"},
        {"Geneva Identification System", "GEN# +1.00025293"},
        {"Smithsonian Astrophysical Observation", "SAO 39272"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.84216900),
        dec: Angle.Degrees(+48.84089664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53191"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.19748089),
        dec: Angle.Degrees(+48.84217999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24078"},
        {"Geneva Identification System", "GEN# +9.80096021"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)10, 21.9500),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)50, 35.500)
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
    primaryId: "HIP 75997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75997"},
        {"Smithsonian Astrophysical Observation", "SAO 45588"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.81134990),
        dec: Angle.Degrees(+48.84426162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69662"},
        {"Smithsonian Astrophysical Observation", "SAO 44958"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.86221805),
        dec: Angle.Degrees(+48.84600643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166044"},
        {"Hipparcos Number", "HIP 88688"},
        {"Smithsonian Astrophysical Observation", "SAO 47222"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.57519718),
        dec: Angle.Degrees(+48.84820939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97905"},
        {"Hipparcos Number", "HIP 55050"},
        {"Smithsonian Astrophysical Observation", "SAO 43670"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.04081844),
        dec: Angle.Degrees(+48.84893170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209569"},
        {"Hipparcos Number", "HIP 108867"},
        {"Smithsonian Astrophysical Observation", "SAO 51600"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.81428587),
        dec: Angle.Degrees(+48.84906007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212268"},
        {"Hipparcos Number", "HIP 110422"},
        {"Geneva Identification System", "GEN# +1.00212268"},
        {"Smithsonian Astrophysical Observation", "SAO 51924"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.49595806),
        dec: Angle.Degrees(+48.84953701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107809"},
        {"Hipparcos Number", "HIP 60401"},
        {"Smithsonian Astrophysical Observation", "SAO 44149"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.76886106),
        dec: Angle.Degrees(+48.85489763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172227"},
        {"Hipparcos Number", "HIP 91227"},
        {"Smithsonian Astrophysical Observation", "SAO 47646"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.14043544),
        dec: Angle.Degrees(+48.85522866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104290",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14673 A"},
        {"Henry Draper", "HD 201416"},
        {"Hipparcos Number", "HIP 104290"},
        {"Geneva Identification System", "GEN# +1.00201416"},
        {"Smithsonian Astrophysical Observation", "SAO 50479"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.91708093),
        dec: Angle.Degrees(+48.85527770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98251"},
        {"Smithsonian Astrophysical Observation", "SAO 49039"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.48242077),
        dec: Angle.Degrees(+48.85652543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43728"},
        {"Smithsonian Astrophysical Observation", "SAO 42591"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.58128473),
        dec: Angle.Degrees(+48.85704878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62332"},
        {"Smithsonian Astrophysical Observation", "SAO 44323"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.60503797),
        dec: Angle.Degrees(+48.85933926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92822",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11846 A"},
        {"Henry Draper", "HD 175824"},
        {"Hipparcos Number", "HIP 92822"},
        {"Geneva Identification System", "GEN# +1.00175824"},
        {"Smithsonian Astrophysical Observation", "SAO 47913"},
        {"Wilson Evans Batten Catalogue", "WEB 16067"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.69653895),
        dec: Angle.Degrees(+48.85972353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97671"},
        {"Smithsonian Astrophysical Observation", "SAO 48903"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.74796181),
        dec: Angle.Degrees(+48.86012389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6225"},
        {"Hipparcos Number", "HIP 4989"},
        {"Geneva Identification System", "GEN# +1.00006225"},
        {"Smithsonian Astrophysical Observation", "SAO 36893"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.98891830),
        dec: Angle.Degrees(+48.86145056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42812",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6945 A"},
        {"Henry Draper", "HD 74010"},
        {"Hipparcos Number", "HIP 42812"},
        {"Geneva Identification System", "GEN# +1.00074010A"},
        {"Smithsonian Astrophysical Observation", "SAO 42512"},
        {"Wilson Evans Batten Catalogue", "WEB 8269"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.85613552),
        dec: Angle.Degrees(+48.86176008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150409"},
        {"Hipparcos Number", "HIP 81483"},
        {"Smithsonian Astrophysical Observation", "SAO 46209"},
        {"Wilson Evans Batten Catalogue", "WEB 13767"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.63557865),
        dec: Angle.Degrees(+48.86234253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1561"},
        {"Hipparcos Number", "HIP 1603"},
        {"Geneva Identification System", "GEN# +1.00001561"},
        {"Smithsonian Astrophysical Observation", "SAO 36272"},
        {"Wilson Evans Batten Catalogue", "WEB 292"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.02153822),
        dec: Angle.Degrees(+48.86548463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177876"},
        {"Hipparcos Number", "HIP 93636"},
        {"Smithsonian Astrophysical Observation", "SAO 48055"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.01914279),
        dec: Angle.Degrees(+48.86665254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9894"},
        {"Smithsonian Astrophysical Observation", "SAO 37781"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.83228714),
        dec: Angle.Degrees(+48.86684333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34498"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.22213211),
        dec: Angle.Degrees(+48.86943656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64591"},
        {"Smithsonian Astrophysical Observation", "SAO 44523"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.58469240),
        dec: Angle.Degrees(+48.86978901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183257"},
        {"Hipparcos Number", "HIP 95580"},
        {"Smithsonian Astrophysical Observation", "SAO 48450"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.61825447),
        dec: Angle.Degrees(+48.87083540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215925"},
        {"Hipparcos Number", "HIP 112568"},
        {"Geneva Identification System", "GEN# +1.00215925"},
        {"Smithsonian Astrophysical Observation", "SAO 52375"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.98562378),
        dec: Angle.Degrees(+48.87397568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70564"},
        {"Hipparcos Number", "HIP 41228"},
        {"Smithsonian Astrophysical Observation", "SAO 42339"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.19978377),
        dec: Angle.Degrees(+48.87475842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13868"},
        {"Hipparcos Number", "HIP 10606"},
        {"Geneva Identification System", "GEN# +1.00013868"},
        {"Smithsonian Astrophysical Observation", "SAO 37913"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.13498008),
        dec: Angle.Degrees(+48.87837245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74389"},
        {"Hipparcos Number", "HIP 42994"},
        {"Geneva Identification System", "GEN# +1.00074389"},
        {"Smithsonian Astrophysical Observation", "SAO 42532"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.44551136),
        dec: Angle.Degrees(+48.87874387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18280"},
        {"Hipparcos Number", "HIP 13820"},
        {"Smithsonian Astrophysical Observation", "SAO 38469"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.47535701),
        dec: Angle.Degrees(+48.87878005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68240"},
        {"Smithsonian Astrophysical Observation", "SAO 44818"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.54548576),
        dec: Angle.Degrees(+48.87919584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59034"},
        {"Hipparcos Number", "HIP 36498"},
        {"Smithsonian Astrophysical Observation", "SAO 41818"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.63949167),
        dec: Angle.Degrees(+48.87948086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123422"},
        {"Hipparcos Number", "HIP 68893"},
        {"Smithsonian Astrophysical Observation", "SAO 44888"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.58541249),
        dec: Angle.Degrees(+48.88083027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40278"},
        {"Hipparcos Number", "HIP 28454"},
        {"Smithsonian Astrophysical Observation", "SAO 40766"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.11541901),
        dec: Angle.Degrees(+48.88086679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81614"},
        {"Hipparcos Number", "HIP 46441"},
        {"Smithsonian Astrophysical Observation", "SAO 42873"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.07913770),
        dec: Angle.Degrees(+48.88149474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80121"},
        {"Smithsonian Astrophysical Observation", "SAO 46047"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.31774116),
        dec: Angle.Degrees(+48.88277587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182531"},
        {"Hipparcos Number", "HIP 95254"},
        {"Smithsonian Astrophysical Observation", "SAO 48385"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.70185161),
        dec: Angle.Degrees(+48.88530299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65407"},
        {"Smithsonian Astrophysical Observation", "SAO 44598"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.08766086),
        dec: Angle.Degrees(+48.88530938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9891"},
        {"Smithsonian Astrophysical Observation", "SAO 37780"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.81849302),
        dec: Angle.Degrees(+48.88609173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52808"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.94229877),
        dec: Angle.Degrees(+48.88748140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18221"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.43912318),
        dec: Angle.Degrees(+48.88826071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112702"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.34621358),
        dec: Angle.Degrees(+48.89124100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127434"},
        {"Hipparcos Number", "HIP 70881"},
        {"Geneva Identification System", "GEN# +1.00127434"},
        {"Smithsonian Astrophysical Observation", "SAO 45077"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.43082655),
        dec: Angle.Degrees(+48.89551712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11497"},
        {"Smithsonian Astrophysical Observation", "SAO 38047"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.07053059),
        dec: Angle.Degrees(+48.90066247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22636"},
        {"Hipparcos Number", "HIP 17166"},
        {"Smithsonian Astrophysical Observation", "SAO 39030"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.14626710),
        dec: Angle.Degrees(+48.90271576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50202"},
        {"Hipparcos Number", "HIP 33217"},
        {"Smithsonian Astrophysical Observation", "SAO 41422"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.69157867),
        dec: Angle.Degrees(+48.90509427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64923"},
        {"Smithsonian Astrophysical Observation", "SAO 44558"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.60255405),
        dec: Angle.Degrees(+48.90558396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45828"},
        {"Smithsonian Astrophysical Observation", "SAO 42813"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.16303536),
        dec: Angle.Degrees(+48.90808897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191635"},
        {"Hipparcos Number", "HIP 99252"},
        {"Geneva Identification System", "GEN# +1.00191635"},
        {"Smithsonian Astrophysical Observation", "SAO 49242"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.21006222),
        dec: Angle.Degrees(+48.91090951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20475"},
        {"Hipparcos Number", "HIP 15499"},
        {"Geneva Identification System", "GEN# +5.20200421"},
        {"Smithsonian Astrophysical Observation", "SAO 38719"},
        {"Wilson Evans Batten Catalogue", "WEB 2977"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.92388868),
        dec: Angle.Degrees(+48.91370715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11173"},
        {"Smithsonian Astrophysical Observation", "SAO 37999"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.96359932),
        dec: Angle.Degrees(+48.91438860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44294"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.32225315),
        dec: Angle.Degrees(+48.91610997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195307"},
        {"Hipparcos Number", "HIP 100988"},
        {"Smithsonian Astrophysical Observation", "SAO 49675"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.12786507),
        dec: Angle.Degrees(+48.91893967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99418"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.67782534),
        dec: Angle.Degrees(+48.91915230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219917"},
        {"Hipparcos Number", "HIP 115128"},
        {"Geneva Identification System", "GEN# +1.00219917"},
        {"Smithsonian Astrophysical Observation", "SAO 52899"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.78187142),
        dec: Angle.Degrees(+48.91941921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108710"},
        {"Hipparcos Number", "HIP 60914"},
        {"Smithsonian Astrophysical Observation", "SAO 44198"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.26012667),
        dec: Angle.Degrees(+48.92005819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34247"},
        {"Hipparcos Number", "HIP 24766"},
        {"Geneva Identification System", "GEN# +1.00034247"},
        {"Smithsonian Astrophysical Observation", "SAO 40215"},
        {"Wilson Evans Batten Catalogue", "WEB 4790"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.63592738),
        dec: Angle.Degrees(+48.92357370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135121"},
        {"Hipparcos Number", "HIP 74340"},
        {"Geneva Identification System", "GEN# +1.00135121"},
        {"Smithsonian Astrophysical Observation", "SAO 45426"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.90215632),
        dec: Angle.Degrees(+48.92384851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192636"},
        {"Hipparcos Number", "HIP 99696"},
        {"Smithsonian Astrophysical Observation", "SAO 49342"},
    },
    visualMagnitude: 8.72,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.46295465),
        dec: Angle.Degrees(+48.92398479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178612"},
        {"Hipparcos Number", "HIP 93853"},
        {"Smithsonian Astrophysical Observation", "SAO 48099"},
        {"Wilson Evans Batten Catalogue", "WEB 16326"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.71464029),
        dec: Angle.Degrees(+48.92554301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25776"},
        {"Hipparcos Number", "HIP 19244"},
        {"Geneva Identification System", "GEN# +1.00025776"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.85881945),
        dec: Angle.Degrees(+48.92802376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81497",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10144 A"},
        {"Henry Draper", "HD 150450"},
        {"Hipparcos Number", "HIP 81497"},
        {"Fundamental Katalog 5th Edition", "FK5 1434"},
        {"Geneva Identification System", "GEN# +1.00150450"},
        {"Smithsonian Astrophysical Observation", "SAO 46210"},
        {"Wilson Evans Batten Catalogue", "WEB 13769"},
    },
    visualMagnitude: 4.86,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.68703338),
        dec: Angle.Degrees(+48.92827739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186700"},
        {"Hipparcos Number", "HIP 97071"},
        {"Geneva Identification System", "GEN# +1.00186700"},
        {"Smithsonian Astrophysical Observation", "SAO 48774"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.91508914),
        dec: Angle.Degrees(+48.92900614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223997"},
        {"Hipparcos Number", "HIP 117864"},
        {"Smithsonian Astrophysical Observation", "SAO 53465"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.59689261),
        dec: Angle.Degrees(+48.92916888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199290"},
        {"Hipparcos Number", "HIP 103196"},
        {"Geneva Identification System", "GEN# +1.00199290"},
        {"Renson", "Renson 55520"},
        {"Smithsonian Astrophysical Observation", "SAO 50214"},
        {"Wilson Evans Batten Catalogue", "WEB 18743"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.60838486),
        dec: Angle.Degrees(+48.92980715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12684"},
        {"Smithsonian Astrophysical Observation", "SAO 38272"},
        {"Wilson Evans Batten Catalogue", "WEB 2581"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.74259572),
        dec: Angle.Degrees(+48.93006496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111126",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16009 AB"},
        {"Hipparcos Number", "HIP 111126"},
        {"Smithsonian Astrophysical Observation", "SAO 52089"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.67806119),
        dec: Angle.Degrees(+48.93091689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97341"},
        {"Smithsonian Astrophysical Observation", "SAO 48835"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.75417838),
        dec: Angle.Degrees(+48.93203041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103430"},
        {"Hipparcos Number", "HIP 58080"},
        {"Geneva Identification System", "GEN# +1.00103430"},
        {"Smithsonian Astrophysical Observation", "SAO 43944"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.66695430),
        dec: Angle.Degrees(+48.93334052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224140"},
        {"Hipparcos Number", "HIP 117952"},
        {"Smithsonian Astrophysical Observation", "SAO 53485"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.88377376),
        dec: Angle.Degrees(+48.93470813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36083"},
        {"Hipparcos Number", "HIP 25910"},
        {"Geneva Identification System", "GEN# +1.00036083"},
        {"Smithsonian Astrophysical Observation", "SAO 40393"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.94802582),
        dec: Angle.Degrees(+48.93486581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99966"},
        {"Hipparcos Number", "HIP 56147"},
        {"Geneva Identification System", "GEN# +1.00099966"},
        {"Smithsonian Astrophysical Observation", "SAO 43785"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.62428180),
        dec: Angle.Degrees(+48.93574004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79888"},
        {"Hipparcos Number", "HIP 45660"},
        {"Smithsonian Astrophysical Observation", "SAO 42795"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.60835550),
        dec: Angle.Degrees(+48.93661736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4591"},
        {"Smithsonian Astrophysical Observation", "SAO 36818"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.68752082),
        dec: Angle.Degrees(+48.93853885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44809"},
        {"Hipparcos Number", "HIP 30653"},
        {"Smithsonian Astrophysical Observation", "SAO 41095"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.61277819),
        dec: Angle.Degrees(+48.94080351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10192"},
        {"Wilson Evans Batten Catalogue", "WEB 2127"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.76065034),
        dec: Angle.Degrees(+48.94585177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101138",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13932 A"},
        {"Henry Draper", "HD 195556"},
        {"Hipparcos Number", "HIP 101138"},
        {"Celescope Catalog", "CEL 5089"},
        {"Fundamental Katalog 5th Edition", "FK5 3641"},
        {"Geneva Identification System", "GEN# +1.00195556"},
        {"Smithsonian Astrophysical Observation", "SAO 49712"},
        {"Wilson Evans Batten Catalogue", "WEB 18269"},
    },
    visualMagnitude: 4.94,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.51471567),
        dec: Angle.Degrees(+48.95155039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3332"},
        {"Hipparcos Number", "HIP 2899"},
        {"Smithsonian Astrophysical Observation", "SAO 36508"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.18931374),
        dec: Angle.Degrees(+48.95217812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79494"},
        {"Hipparcos Number", "HIP 45497"},
        {"Geneva Identification System", "GEN# +1.00079494"},
        {"Smithsonian Astrophysical Observation", "SAO 42778"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.05744237),
        dec: Angle.Degrees(+48.95316801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20202"},
        {"Geneva Identification System", "GEN# +0.04801080"},
        {"Wilson Evans Batten Catalogue", "WEB 3853"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.94524262),
        dec: Angle.Degrees(+48.95327915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11787"},
        {"Smithsonian Astrophysical Observation", "SAO 38094"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.02912321),
        dec: Angle.Degrees(+48.95510049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14221"},
        {"Hipparcos Number", "HIP 10830"},
        {"Geneva Identification System", "GEN# +1.00014221"},
        {"Smithsonian Astrophysical Observation", "SAO 37949"},
        {"Wilson Evans Batten Catalogue", "WEB 2283"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.84485604),
        dec: Angle.Degrees(+48.95528736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23367"},
        {"Smithsonian Astrophysical Observation", "SAO 39942"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.36231525),
        dec: Angle.Degrees(+48.95743753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22583"},
        {"Hipparcos Number", "HIP 17131"},
        {"Smithsonian Astrophysical Observation", "SAO 39025"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.03691270),
        dec: Angle.Degrees(+48.95771596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6185",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1065 AB"},
        {"Henry Draper", "HD 7881"},
        {"Hipparcos Number", "HIP 6185"},
        {"Smithsonian Astrophysical Observation", "SAO 37113"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.83807092),
        dec: Angle.Degrees(+48.95809670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17028"},
        {"Hipparcos Number", "HIP 12892"},
        {"Smithsonian Astrophysical Observation", "SAO 38303"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.42777698),
        dec: Angle.Degrees(+48.95826008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67870"},
        {"Hipparcos Number", "HIP 40165"},
        {"Geneva Identification System", "GEN# +1.00067870"},
        {"Smithsonian Astrophysical Observation", "SAO 42223"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.04842599),
        dec: Angle.Degrees(+48.95928091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40486"},
        {"Hipparcos Number", "HIP 28562"},
        {"Fundamental Katalog 5th Edition", "FK5 2458"},
        {"Geneva Identification System", "GEN# +1.00040486"},
        {"Smithsonian Astrophysical Observation", "SAO 40789"},
        {"Wilson Evans Batten Catalogue", "WEB 5580"},
    },
    visualMagnitude: 5.98,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.42938625),
        dec: Angle.Degrees(+48.95946915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149081"},
        {"Hipparcos Number", "HIP 80809"},
        {"Geneva Identification System", "GEN# +1.00149081"},
        {"Smithsonian Astrophysical Observation", "SAO 46128"},
        {"Wilson Evans Batten Catalogue", "WEB 13665"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.52532738),
        dec: Angle.Degrees(+48.96122756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154114"},
        {"Hipparcos Number", "HIP 83259"},
        {"Geneva Identification System", "GEN# +1.00154114"},
        {"Smithsonian Astrophysical Observation", "SAO 46439"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.25730996),
        dec: Angle.Degrees(+48.96207890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12680"},
        {"Geneva Identification System", "GEN# +0.04800739"},
        {"Wilson Evans Batten Catalogue", "WEB 2577"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.73681882),
        dec: Angle.Degrees(+48.96386067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -385.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90507"},
        {"Hipparcos Number", "HIP 51247"},
        {"Geneva Identification System", "GEN# +1.00090507"},
        {"Smithsonian Astrophysical Observation", "SAO 43350"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.01369352),
        dec: Angle.Degrees(+48.96395653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155638"},
        {"Hipparcos Number", "HIP 84014"},
        {"Geneva Identification System", "GEN# +1.00155638"},
        {"Smithsonian Astrophysical Observation", "SAO 46541"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.60666170),
        dec: Angle.Degrees(+48.96568986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5728"},
        {"Hipparcos Number", "HIP 4637"},
        {"Geneva Identification System", "GEN# +1.00005728"},
        {"Smithsonian Astrophysical Observation", "SAO 36825"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.88446436),
        dec: Angle.Degrees(+48.96641596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105458"},
        {"Hipparcos Number", "HIP 59203"},
        {"Geneva Identification System", "GEN# +1.00105458"},
        {"Smithsonian Astrophysical Observation", "SAO 44048"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.10863756),
        dec: Angle.Degrees(+48.96852741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1601"},
        {"Hipparcos Number", "HIP 1639"},
        {"Geneva Identification System", "GEN# +1.00001601"},
        {"Smithsonian Astrophysical Observation", "SAO 36277"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.12884068),
        dec: Angle.Degrees(+48.96864118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46878"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.29317915),
        dec: Angle.Degrees(+48.97002982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148881"},
        {"Hipparcos Number", "HIP 80730"},
        {"Smithsonian Astrophysical Observation", "SAO 46113"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.23051237),
        dec: Angle.Degrees(+48.97546508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74846"},
        {"Hipparcos Number", "HIP 43230"},
        {"Smithsonian Astrophysical Observation", "SAO 42552"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.09010200),
        dec: Angle.Degrees(+48.97876194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129921"},
        {"Hipparcos Number", "HIP 72006"},
        {"Smithsonian Astrophysical Observation", "SAO 45192"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.90366503),
        dec: Angle.Degrees(+48.98272678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4925"},
        {"Hipparcos Number", "HIP 4042"},
        {"Smithsonian Astrophysical Observation", "SAO 36722"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.95864979),
        dec: Angle.Degrees(+48.98364993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107274"},
        {"Hipparcos Number", "HIP 60122"},
        {"Fundamental Katalog 5th Edition", "FK5 1316"},
        {"Geneva Identification System", "GEN# +1.00107274"},
        {"Smithsonian Astrophysical Observation", "SAO 44127"},
        {"Wilson Evans Batten Catalogue", "WEB 10688"},
    },
    visualMagnitude: 5.28,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.95301297),
        dec: Angle.Degrees(+48.98413192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38059"},
        {"Hipparcos Number", "HIP 27176"},
        {"Smithsonian Astrophysical Observation", "SAO 40579"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.39546995),
        dec: Angle.Degrees(+48.98501697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52287"},
        {"Smithsonian Astrophysical Observation", "SAO 43430"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.26045316),
        dec: Angle.Degrees(+48.98810074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96454"},
        {"Hipparcos Number", "HIP 54384"},
        {"Geneva Identification System", "GEN# +1.00096454"},
        {"Smithsonian Astrophysical Observation", "SAO 43617"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.91014587),
        dec: Angle.Degrees(+48.99541680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222155"},
        {"Hipparcos Number", "HIP 116616"},
        {"Geneva Identification System", "GEN# +1.00222155"},
        {"Smithsonian Astrophysical Observation", "SAO 53211"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.50055727),
        dec: Angle.Degrees(+48.99681011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60253"},
        {"Hipparcos Number", "HIP 36975"},
        {"Geneva Identification System", "GEN# +1.00060253"},
        {"Smithsonian Astrophysical Observation", "SAO 41876"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.00081886),
        dec: Angle.Degrees(+48.99722538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86638",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10736 AB"},
        {"Henry Draper", "HD 161286"},
        {"Hipparcos Number", "HIP 86638"},
        {"Smithsonian Astrophysical Observation", "SAO 46899"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.54607725),
        dec: Angle.Degrees(+49.00255575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83142"},
        {"Hipparcos Number", "HIP 47257"},
        {"Smithsonian Astrophysical Observation", "SAO 42949"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.48349066),
        dec: Angle.Degrees(+49.00316222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39476"},
        {"Hipparcos Number", "HIP 28001"},
        {"Smithsonian Astrophysical Observation", "SAO 40698"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.85082044),
        dec: Angle.Degrees(+49.00545173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6060",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1040 AB"},
        {"Henry Draper", "HD 7710"},
        {"Hipparcos Number", "HIP 6060"},
        {"Geneva Identification System", "GEN# +1.00007710J"},
        {"Smithsonian Astrophysical Observation", "SAO 37087"},
    },
    visualMagnitude: 6.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.44983428),
        dec: Angle.Degrees(+49.00847692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19805"},
        {"Hipparcos Number", "HIP 14980"},
        {"Geneva Identification System", "GEN# +5.20200167"},
        {"Renson", "Renson 4890"},
        {"Smithsonian Astrophysical Observation", "SAO 38647"},
        {"Wilson Evans Batten Catalogue", "WEB 2890"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.27181415),
        dec: Angle.Degrees(+49.00946795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224881"},
        {"Hipparcos Number", "HIP 113"},
        {"Smithsonian Astrophysical Observation", "SAO 53578"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.36562073),
        dec: Angle.Degrees(+49.01041081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 630"},
        {"Hipparcos Number", "HIP 885"},
        {"Smithsonian Astrophysical Observation", "SAO 36132"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.70138861),
        dec: Angle.Degrees(+49.01075823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143189"},
        {"Hipparcos Number", "HIP 78101"},
        {"Smithsonian Astrophysical Observation", "SAO 45798"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.20207934),
        dec: Angle.Degrees(+49.01182811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121780"},
        {"Hipparcos Number", "HIP 68087"},
        {"Geneva Identification System", "GEN# +1.00121780"},
        {"Smithsonian Astrophysical Observation", "SAO 44810"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.10915816),
        dec: Angle.Degrees(+49.01246317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157411"},
        {"Hipparcos Number", "HIP 84852"},
        {"Smithsonian Astrophysical Observation", "SAO 46652"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.13305911),
        dec: Angle.Degrees(+49.01262099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115022",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16656 A"},
        {"Henry Draper", "HD 219734"},
        {"Hipparcos Number", "HIP 115022"},
        {"Geneva Identification System", "GEN# +1.00219734J"},
        {"Smithsonian Astrophysical Observation", "SAO 52871"},
        {"Wilson Evans Batten Catalogue", "WEB 20377"},
    },
    visualMagnitude: 4.82,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.43590129),
        dec: Angle.Degrees(+49.01528336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117383"},
        {"Cincinnati Publication", "Ci 20 1453"},
    },
    visualMagnitude: 12.06,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.01075418),
        dec: Angle.Degrees(+49.01574852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 626.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118232"},
        {"Hipparcos Number", "HIP 66234"},
        {"Fundamental Katalog 5th Edition", "FK5 3083"},
        {"Geneva Identification System", "GEN# +1.00118232"},
        {"Smithsonian Astrophysical Observation", "SAO 44668"},
        {"Wilson Evans Batten Catalogue", "WEB 11704"},
    },
    visualMagnitude: 4.68,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.61405606),
        dec: Angle.Degrees(+49.01590606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114420",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16562 AB"},
        {"Henry Draper", "HD 218790"},
        {"Hipparcos Number", "HIP 114420"},
        {"Smithsonian Astrophysical Observation", "SAO 52759"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.58782335),
        dec: Angle.Degrees(+49.01819608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104484"},
        {"Geneva Identification System", "GEN# +0.04803298"},
        {"Smithsonian Astrophysical Observation", "SAO 50528"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.49633701),
        dec: Angle.Degrees(+49.01902180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67044"},
        {"Hipparcos Number", "HIP 39842"},
        {"Smithsonian Astrophysical Observation", "SAO 42187"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.10269931),
        dec: Angle.Degrees(+49.02112762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2814",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 493 AB"},
        {"Henry Draper", "HD 3211"},
        {"Henry Draper 2", "HD 3210"},
        {"Hipparcos Number", "HIP 2814"},
        {"Smithsonian Astrophysical Observation", "SAO 36497"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.95289342),
        dec: Angle.Degrees(+49.02115007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102557"},
        {"Smithsonian Astrophysical Observation", "SAO 50057"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.75393092),
        dec: Angle.Degrees(+49.02226088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50008"},
        {"Smithsonian Astrophysical Observation", "SAO 43233"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.13773968),
        dec: Angle.Degrees(+49.02305360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141001"},
        {"Hipparcos Number", "HIP 77104"},
        {"Smithsonian Astrophysical Observation", "SAO 45705"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.15871704),
        dec: Angle.Degrees(+49.02795299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 125.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1405"},
    },
    visualMagnitude: 12.12,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.39544498),
        dec: Angle.Degrees(+65.26884985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78597"},
    },
    visualMagnitude: 10.72,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.71208272),
        dec: Angle.Degrees(+49.02860376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104044",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14617 AB"},
        {"Henry Draper", "HD 200927"},
        {"Hipparcos Number", "HIP 104044"},
        {"Celescope Catalog", "CEL 5243"},
        {"Geneva Identification System", "GEN# +1.00200927J"},
        {"Smithsonian Astrophysical Observation", "SAO 50422"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.18091241),
        dec: Angle.Degrees(+49.02890523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233949"},
        {"Hipparcos Number", "HIP 60931"},
        {"Smithsonian Astrophysical Observation", "SAO 44200"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.33008143),
        dec: Angle.Degrees(+49.02916833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39743"},
        {"Hipparcos Number", "HIP 28162"},
        {"Geneva Identification System", "GEN# +1.00039743"},
        {"Smithsonian Astrophysical Observation", "SAO 40720"},
        {"Wilson Evans Batten Catalogue", "WEB 5511"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.26931591),
        dec: Angle.Degrees(+49.02970526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42063"},
        {"Hipparcos Number", "HIP 29351"},
        {"Smithsonian Astrophysical Observation", "SAO 40917"},
    },
    visualMagnitude: 8.50,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.81103472),
        dec: Angle.Degrees(+49.03142115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88079"},
        {"Cincinnati Publication", "Ci 20 1071"},
    },
    visualMagnitude: 11.57,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.82526704),
        dec: Angle.Degrees(+49.03565517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 345.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147352"},
        {"Hipparcos Number", "HIP 79953"},
        {"Fundamental Katalog 5th Edition", "FK5 3292"},
        {"Geneva Identification System", "GEN# +1.00147352"},
        {"Smithsonian Astrophysical Observation", "SAO 46025"},
        {"Wilson Evans Batten Catalogue", "WEB 13533"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.79680216),
        dec: Angle.Degrees(+49.03807805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31378"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.68467238),
        dec: Angle.Degrees(+49.03902093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31015"},
        {"Hipparcos Number", "HIP 22841"},
        {"Smithsonian Astrophysical Observation", "SAO 39848"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.71321481),
        dec: Angle.Degrees(+49.03974544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24432"},
        {"Hipparcos Number", "HIP 18353"},
        {"Geneva Identification System", "GEN# +1.00024432"},
        {"Smithsonian Astrophysical Observation", "SAO 39191"},
        {"Wilson Evans Batten Catalogue", "WEB 3544"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.85354784),
        dec: Angle.Degrees(+49.04059717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217648"},
        {"Hipparcos Number", "HIP 113689"},
        {"Smithsonian Astrophysical Observation", "SAO 52606"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.38999972),
        dec: Angle.Degrees(+49.04208396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193442"},
        {"Hipparcos Number", "HIP 100076"},
        {"Smithsonian Astrophysical Observation", "SAO 49447"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.54637248),
        dec: Angle.Degrees(+49.04332189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210696"},
        {"Hipparcos Number", "HIP 109503"},
        {"Smithsonian Astrophysical Observation", "SAO 51735"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.74775900),
        dec: Angle.Degrees(+49.04768982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84634"},
        {"Hipparcos Number", "HIP 48074"},
        {"Smithsonian Astrophysical Observation", "SAO 43042"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.01032901),
        dec: Angle.Degrees(+49.04883076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2219"},
        {"Hipparcos Number", "HIP 2087"},
        {"Smithsonian Astrophysical Observation", "SAO 36365"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.59089239),
        dec: Angle.Degrees(+49.04900660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115993"},
        {"Geneva Identification System", "GEN# +2.76860005"},
        {"Smithsonian Astrophysical Observation", "SAO 53075"},
        {"New General Catalogue", "NGC 7686 5"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.51646474),
        dec: Angle.Degrees(+49.05119538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172308"},
        {"Hipparcos Number", "HIP 91269"},
        {"Smithsonian Astrophysical Observation", "SAO 47655"},
    },
    visualMagnitude: 8.87,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.25126117),
        dec: Angle.Degrees(+49.05150982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209204"},
        {"Hipparcos Number", "HIP 108627"},
        {"Smithsonian Astrophysical Observation", "SAO 51540"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.10091635),
        dec: Angle.Degrees(+49.05174522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147572"},
        {"Hipparcos Number", "HIP 80038"},
        {"Geneva Identification System", "GEN# +1.00147572"},
        {"Smithsonian Astrophysical Observation", "SAO 46034"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.06922650),
        dec: Angle.Degrees(+49.05184542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112004"},
        {"Smithsonian Astrophysical Observation", "SAO 52263"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.31296019),
        dec: Angle.Degrees(+49.05250838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197603"},
        {"Hipparcos Number", "HIP 102233"},
        {"Geneva Identification System", "GEN# +1.00197603"},
        {"Smithsonian Astrophysical Observation", "SAO 49976"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.73089829),
        dec: Angle.Degrees(+49.05277740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6844"},
        {"Hipparcos Number", "HIP 5457"},
        {"Smithsonian Astrophysical Observation", "SAO 36976"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.46593922),
        dec: Angle.Degrees(+49.05389532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82143"},
        {"Smithsonian Astrophysical Observation", "SAO 46283"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.72072693),
        dec: Angle.Degrees(+49.05752903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77276"},
        {"Hipparcos Number", "HIP 44451"},
        {"Smithsonian Astrophysical Observation", "SAO 42658"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.84175017),
        dec: Angle.Degrees(+49.05798977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21278"},
        {"Hipparcos Number", "HIP 16147"},
        {"Geneva Identification System", "GEN# +5.20200774"},
        {"Smithsonian Astrophysical Observation", "SAO 38849"},
        {"Wilson Evans Batten Catalogue", "WEB 3077"},
    },
    visualMagnitude: 4.99,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.01270885),
        dec: Angle.Degrees(+49.06293148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41764"},
        {"Hipparcos Number", "HIP 29215"},
        {"Smithsonian Astrophysical Observation", "SAO 40892"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.41234561),
        dec: Angle.Degrees(+49.06304958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145872"},
        {"Hipparcos Number", "HIP 79292"},
        {"Geneva Identification System", "GEN# +1.00145872"},
        {"Smithsonian Astrophysical Observation", "SAO 45947"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.73834904),
        dec: Angle.Degrees(+49.06346056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36522"},
        {"Hipparcos Number", "HIP 26184"},
        {"Geneva Identification System", "GEN# +1.00036522"},
        {"Smithsonian Astrophysical Observation", "SAO 40445"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.73152999),
        dec: Angle.Degrees(+49.06349858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24790"},
        {"Smithsonian Astrophysical Observation", "SAO 40220"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.72649759),
        dec: Angle.Degrees(+49.06571903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38775"},
        {"Hipparcos Number", "HIP 27607"},
        {"Geneva Identification System", "GEN# +1.00038775"},
        {"Smithsonian Astrophysical Observation", "SAO 40638"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.68613562),
        dec: Angle.Degrees(+49.06606057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108433"},
        {"Smithsonian Astrophysical Observation", "SAO 51490"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.48064378),
        dec: Angle.Degrees(+49.06787539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115504"},
        {"Smithsonian Astrophysical Observation", "SAO 52975"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.96649628),
        dec: Angle.Degrees(+49.06881880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21375"},
        {"Hipparcos Number", "HIP 16211"},
        {"Geneva Identification System", "GEN# +5.20200817"},
        {"Smithsonian Astrophysical Observation", "SAO 38865"},
        {"Wilson Evans Batten Catalogue", "WEB 3090"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.22346506),
        dec: Angle.Degrees(+49.07039370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4102"},
        {"Hipparcos Number", "HIP 3444"},
        {"Smithsonian Astrophysical Observation", "SAO 36606"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.99738779),
        dec: Angle.Degrees(+49.07044176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20675"},
        {"Hipparcos Number", "HIP 15669"},
        {"Geneva Identification System", "GEN# +5.20200497"},
        {"Smithsonian Astrophysical Observation", "SAO 38753"},
        {"Wilson Evans Batten Catalogue", "WEB 3003"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.46821583),
        dec: Angle.Degrees(+49.07105892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49063"},
        {"Smithsonian Astrophysical Observation", "SAO 43139"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.17715740),
        dec: Angle.Degrees(+49.07390004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17211"},
        {"Hipparcos Number", "HIP 13020"},
        {"Smithsonian Astrophysical Observation", "SAO 38330"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.84843400),
        dec: Angle.Degrees(+49.07412987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174366"},
        {"Hipparcos Number", "HIP 92219"},
        {"Geneva Identification System", "GEN# +1.00174366"},
        {"Smithsonian Astrophysical Observation", "SAO 47815"},
        {"Wilson Evans Batten Catalogue", "WEB 15911"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.91714901),
        dec: Angle.Degrees(+49.07482911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84948"},
        {"Henry Draper 2", "HD 84948B"},
        {"Hipparcos Number", "HIP 48243"},
        {"Geneva Identification System", "GEN# +1.00084948"},
        {"Smithsonian Astrophysical Observation", "SAO 43060"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.52450341),
        dec: Angle.Degrees(+49.07549754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9822"},
        {"Hipparcos Number", "HIP 7536"},
        {"Geneva Identification System", "GEN# +1.00009822"},
        {"Smithsonian Astrophysical Observation", "SAO 37366"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.27578577),
        dec: Angle.Degrees(+49.07589781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98098"},
        {"Hipparcos Number", "HIP 55157"},
        {"Smithsonian Astrophysical Observation", "SAO 43683"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.39137007),
        dec: Angle.Degrees(+49.07682063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74024"},
        {"Smithsonian Astrophysical Observation", "SAO 45393"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.91723005),
        dec: Angle.Degrees(+49.08100918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93977",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12089 AB"},
        {"Henry Draper", "HD 178910"},
        {"Hipparcos Number", "HIP 93977"},
        {"Smithsonian Astrophysical Observation", "SAO 48124"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.02031214),
        dec: Angle.Degrees(+49.08184536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22389"},
        {"Hipparcos Number", "HIP 16962"},
        {"Fundamental Katalog 5th Edition", "FK5 4327"},
        {"Geneva Identification System", "GEN# +5.20201235"},
        {"Smithsonian Astrophysical Observation", "SAO 39000"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.55445241),
        dec: Angle.Degrees(+49.08303653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145145"},
        {"Hipparcos Number", "HIP 78958"},
        {"Smithsonian Astrophysical Observation", "SAO 45900"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.78407471),
        dec: Angle.Degrees(+49.08309729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76079"},
        {"Hipparcos Number", "HIP 43849"},
        {"Geneva Identification System", "GEN# +1.00076079"},
        {"Smithsonian Astrophysical Observation", "SAO 42600"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.97074008),
        dec: Angle.Degrees(+49.08723965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221775"},
        {"Hipparcos Number", "HIP 116366"},
        {"Smithsonian Astrophysical Observation", "SAO 53161"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.69748860),
        dec: Angle.Degrees(+49.08738249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35076"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.80107628),
        dec: Angle.Degrees(+49.08905131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8901",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8901"},
        {"Smithsonian Astrophysical Observation", "SAO 37603"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.65741811),
        dec: Angle.Degrees(+49.09237720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26482"},
        {"Hipparcos Number", "HIP 19727"},
        {"Fundamental Katalog 5th Edition", "FK5 4384"},
        {"Geneva Identification System", "GEN# +1.00026482"},
        {"Smithsonian Astrophysical Observation", "SAO 39392"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.42121523),
        dec: Angle.Degrees(+49.09394070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57491",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57491"},
        {"Smithsonian Astrophysical Observation", "SAO 43888"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.75856496),
        dec: Angle.Degrees(+49.09432051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168382"},
        {"Hipparcos Number", "HIP 89588"},
        {"Smithsonian Astrophysical Observation", "SAO 47360"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.22544704),
        dec: Angle.Degrees(+49.09452938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89944"},
        {"Hipparcos Number", "HIP 50918"},
        {"Smithsonian Astrophysical Observation", "SAO 43318"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.97544425),
        dec: Angle.Degrees(+49.09707050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131409"},
        {"Hipparcos Number", "HIP 72696"},
        {"Geneva Identification System", "GEN# +1.00131409"},
        {"Smithsonian Astrophysical Observation", "SAO 45245"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.94500842),
        dec: Angle.Degrees(+49.09816122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167388"},
        {"Hipparcos Number", "HIP 89229"},
        {"Smithsonian Astrophysical Observation", "SAO 47306"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.13046504),
        dec: Angle.Degrees(+49.09882320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7743"},
        {"Hipparcos Number", "HIP 6083"},
        {"Smithsonian Astrophysical Observation", "SAO 37094"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.52458880),
        dec: Angle.Degrees(+49.09917193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10211"},
        {"Hipparcos Number", "HIP 7855"},
        {"Geneva Identification System", "GEN# +1.00010211"},
        {"Smithsonian Astrophysical Observation", "SAO 37425"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.25265766),
        dec: Angle.Degrees(+49.10395458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14769"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.66811048),
        dec: Angle.Degrees(+49.10505140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221203"},
        {"Hipparcos Number", "HIP 115963"},
        {"Geneva Identification System", "GEN# +2.76860002"},
        {"Smithsonian Astrophysical Observation", "SAO 53077"},
        {"New General Catalogue", "NGC 7686 2"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.41369680),
        dec: Angle.Degrees(+49.10714529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91426"},
        {"Hipparcos Number", "HIP 51750"},
        {"Smithsonian Astrophysical Observation", "SAO 43387"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.58726109),
        dec: Angle.Degrees(+49.10736765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64088",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8793 A"},
        {"Hipparcos Number", "HIP 64088"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.00762546),
        dec: Angle.Degrees(+49.11178424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222728"},
        {"Hipparcos Number", "HIP 116986"},
        {"Smithsonian Astrophysical Observation", "SAO 53309"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.74945707),
        dec: Angle.Degrees(+49.11856602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86872"},
        {"Smithsonian Astrophysical Observation", "SAO 46933"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.23307743),
        dec: Angle.Degrees(+49.11951381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21071"},
        {"Hipparcos Number", "HIP 15988"},
        {"Geneva Identification System", "GEN# +5.20200675"},
        {"Smithsonian Astrophysical Observation", "SAO 38817"},
        {"Wilson Evans Batten Catalogue", "WEB 3054"},
    },
    visualMagnitude: 6.09,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.48900306),
        dec: Angle.Degrees(+49.12082260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112913"},
        {"Hipparcos Number", "HIP 63398"},
        {"Smithsonian Astrophysical Observation", "SAO 44416"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.87713560),
        dec: Angle.Degrees(+49.12146196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169305"},
        {"Hipparcos Number", "HIP 89981"},
        {"Fundamental Katalog 5th Edition", "FK5 3458"},
        {"Geneva Identification System", "GEN# +1.00169305"},
        {"Smithsonian Astrophysical Observation", "SAO 47417"},
        {"Wilson Evans Batten Catalogue", "WEB 15371"},
    },
    visualMagnitude: 5.02,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.38618655),
        dec: Angle.Degrees(+49.12146945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45668"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.63505959),
        dec: Angle.Degrees(+49.12173799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52401"},
        {"Hipparcos Number", "HIP 34029"},
        {"Geneva Identification System", "GEN# +1.00052401"},
        {"Smithsonian Astrophysical Observation", "SAO 41521"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.90037738),
        dec: Angle.Degrees(+49.12182184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23964",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3715 A"},
        {"Henry Draper", "HD 32903"},
        {"Hipparcos Number", "HIP 23964"},
        {"Fundamental Katalog 5th Edition", "FK5 2386"},
        {"Geneva Identification System", "GEN# +1.00032903"},
        {"Smithsonian Astrophysical Observation", "SAO 40052"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.26834490),
        dec: Angle.Degrees(+49.12189299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108577",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15530 AB"},
        {"Henry Draper", "HD 209103"},
        {"Hipparcos Number", "HIP 108577"},
        {"Smithsonian Astrophysical Observation", "SAO 51525"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.92456223),
        dec: Angle.Degrees(+49.12316942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129664"},
        {"Hipparcos Number", "HIP 71882"},
        {"Geneva Identification System", "GEN# +1.00129664"},
        {"Smithsonian Astrophysical Observation", "SAO 45180"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.54043189),
        dec: Angle.Degrees(+49.12428644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38178"},
        {"Hipparcos Number", "HIP 27247"},
        {"Geneva Identification System", "GEN# +1.00038178"},
        {"Smithsonian Astrophysical Observation", "SAO 40592"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.62393722),
        dec: Angle.Degrees(+49.12611660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71878"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.52957804),
        dec: Angle.Degrees(+49.12674034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110055",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15814 A"},
        {"Henry Draper", "HD 211660"},
        {"Hipparcos Number", "HIP 110055"},
        {"Smithsonian Astrophysical Observation", "SAO 51844"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.36795272),
        dec: Angle.Degrees(+49.12693540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43077"},
        {"Smithsonian Astrophysical Observation", "SAO 42539"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.61260045),
        dec: Angle.Degrees(+49.12804044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69408"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.16228879),
        dec: Angle.Degrees(+49.13198880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106974",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15201 A"},
        {"Henry Draper", "HD 206312"},
        {"Hipparcos Number", "HIP 106974"},
        {"Geneva Identification System", "GEN# +1.00206312J"},
        {"Smithsonian Astrophysical Observation", "SAO 51163"},
        {"Wilson Evans Batten Catalogue", "WEB 19329"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.98155138),
        dec: Angle.Degrees(+49.13277994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221246"},
        {"Hipparcos Number", "HIP 115996"},
        {"Fundamental Katalog 5th Edition", "FK5 3882"},
        {"Geneva Identification System", "GEN# +2.76860001"},
        {"Smithsonian Astrophysical Observation", "SAO 53088"},
        {"Wilson Evans Batten Catalogue", "WEB 20512"},
        {"New General Catalogue", "NGC 7686 1"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.53078341),
        dec: Angle.Degrees(+49.13313752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20931"},
        {"Hipparcos Number", "HIP 15878"},
        {"Geneva Identification System", "GEN# +5.20200612"},
        {"Smithsonian Astrophysical Observation", "SAO 38791"},
        {"Wilson Evans Batten Catalogue", "WEB 3031"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.12506425),
        dec: Angle.Degrees(+49.13996474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66090",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8940 AB"},
        {"Henry Draper", "HD 117963"},
        {"Hipparcos Number", "HIP 66090"},
        {"Smithsonian Astrophysical Observation", "SAO 44650"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.21485004),
        dec: Angle.Degrees(+49.14012639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60578"},
        {"Geneva Identification System", "GEN# +0.04902137"},
        {"Renson", "Renson 31400"},
        {"Smithsonian Astrophysical Observation", "SAO 44165"},
        {"Wilson Evans Batten Catalogue", "WEB 10772"},
    },
    visualMagnitude: 10.65,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.25166409),
        dec: Angle.Degrees(+49.14184580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104564"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.72656499),
        dec: Angle.Degrees(+49.14206361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57974"},
        {"Smithsonian Astrophysical Observation", "SAO 43937"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.37363862),
        dec: Angle.Degrees(+49.14543466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222657"},
        {"Hipparcos Number", "HIP 116953"},
        {"Smithsonian Astrophysical Observation", "SAO 53296"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.60414717),
        dec: Angle.Degrees(+49.15146271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151603"},
        {"Hipparcos Number", "HIP 82082"},
        {"Smithsonian Astrophysical Observation", "SAO 46273"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.49814062),
        dec: Angle.Degrees(+49.15419532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111654"},
        {"Smithsonian Astrophysical Observation", "SAO 52189"},
    },
    visualMagnitude: 9.43,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.28309438),
        dec: Angle.Degrees(+49.15479043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12740"},
        {"Hipparcos Number", "HIP 9808"},
        {"Celescope Catalog", "CEL 199"},
        {"Geneva Identification System", "GEN# +1.00012740"},
        {"Smithsonian Astrophysical Observation", "SAO 37764"},
        {"Wilson Evans Batten Catalogue", "WEB 2060"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.54752167),
        dec: Angle.Degrees(+49.15633789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167941"},
        {"Hipparcos Number", "HIP 89420"},
        {"Geneva Identification System", "GEN# +1.00167941"},
        {"Smithsonian Astrophysical Observation", "SAO 47336"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.73421172),
        dec: Angle.Degrees(+49.15812447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105123"},
        {"Hipparcos Number", "HIP 59024"},
        {"Geneva Identification System", "GEN# +1.00105123"},
        {"Smithsonian Astrophysical Observation", "SAO 44031"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.52510738),
        dec: Angle.Degrees(+49.15840736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6945"},
        {"Smithsonian Astrophysical Observation", "SAO 37262"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.36110898),
        dec: Angle.Degrees(+49.16062773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6962"},
        {"Hipparcos Number", "HIP 5533"},
        {"Smithsonian Astrophysical Observation", "SAO 36996"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.71771118),
        dec: Angle.Degrees(+49.16438722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150748"},
        {"Hipparcos Number", "HIP 81633"},
        {"Smithsonian Astrophysical Observation", "SAO 46224"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.14618966),
        dec: Angle.Degrees(+49.16649529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143452"},
        {"Hipparcos Number", "HIP 78208"},
        {"Smithsonian Astrophysical Observation", "SAO 45810"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.55138069),
        dec: Angle.Degrees(+49.16793972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91244"},
        {"Hipparcos Number", "HIP 51649"},
        {"Geneva Identification System", "GEN# +1.00091244"},
        {"Smithsonian Astrophysical Observation", "SAO 43377"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.28454803),
        dec: Angle.Degrees(+49.16887905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58554"},
        {"Smithsonian Astrophysical Observation", "SAO 43992"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.10907630),
        dec: Angle.Degrees(+49.17195160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96453"},
        {"Hipparcos Number", "HIP 54382"},
        {"Smithsonian Astrophysical Observation", "SAO 43616"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.89986663),
        dec: Angle.Degrees(+49.17698943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196330"},
        {"Hipparcos Number", "HIP 101537"},
        {"Smithsonian Astrophysical Observation", "SAO 49827"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.66997561),
        dec: Angle.Degrees(+49.17742189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5637"},
        {"Hipparcos Number", "HIP 4583"},
        {"Smithsonian Astrophysical Observation", "SAO 36815"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.67780817),
        dec: Angle.Degrees(+49.17808657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215908"},
        {"Hipparcos Number", "HIP 112557"},
        {"Smithsonian Astrophysical Observation", "SAO 52372"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.95126398),
        dec: Angle.Degrees(+49.17858515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180866"},
        {"Hipparcos Number", "HIP 94667"},
        {"Geneva Identification System", "GEN# +1.00180866"},
        {"Smithsonian Astrophysical Observation", "SAO 48257"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.95465092),
        dec: Angle.Degrees(+49.18089051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14648"},
        {"Hipparcos Number", "HIP 11147"},
        {"Geneva Identification System", "GEN# +1.00014648"},
        {"Smithsonian Astrophysical Observation", "SAO 37994"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.85544150),
        dec: Angle.Degrees(+49.18202294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22914"},
        {"Hipparcos Number", "HIP 17357"},
        {"Smithsonian Astrophysical Observation", "SAO 39052"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.73030517),
        dec: Angle.Degrees(+49.18256564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109680"},
        {"Hipparcos Number", "HIP 61510"},
        {"Geneva Identification System", "GEN# +1.00109680"},
        {"Smithsonian Astrophysical Observation", "SAO 44242"},
        {"Wilson Evans Batten Catalogue", "WEB 10949"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.03921006),
        dec: Angle.Degrees(+49.18286713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85226"},
        {"Smithsonian Astrophysical Observation", "SAO 46708"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.22333188),
        dec: Angle.Degrees(+49.18301955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13124",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2139 A"},
        {"Henry Draper", "HD 17359"},
        {"Hipparcos Number", "HIP 13124"},
        {"Celescope Catalog", "CEL 295"},
        {"Geneva Identification System", "GEN# +1.00017359"},
        {"Smithsonian Astrophysical Observation", "SAO 38352"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.20902643),
        dec: Angle.Degrees(+49.18391087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71109",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9306 ABC"},
        {"Henry Draper", "HD 127930"},
        {"Hipparcos Number", "HIP 71109"},
        {"Smithsonian Astrophysical Observation", "SAO 45099"},
        {"Wilson Evans Batten Catalogue", "WEB 12298"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.12859486),
        dec: Angle.Degrees(+49.18406932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105525"},
        {"Hipparcos Number", "HIP 59228"},
        {"Geneva Identification System", "GEN# +1.00105525"},
        {"Smithsonian Astrophysical Observation", "SAO 44052"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.22353303),
        dec: Angle.Degrees(+49.18536791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91347"},
        {"Hipparcos Number", "HIP 51700"},
        {"Geneva Identification System", "GEN# +1.00091347"},
        {"Smithsonian Astrophysical Observation", "SAO 43383"},
        {"Wilson Evans Batten Catalogue", "WEB 9428"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.45962271),
        dec: Angle.Degrees(+49.18586313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 276.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43379"},
        {"Hipparcos Number", "HIP 29962"},
        {"Geneva Identification System", "GEN# +1.00043379"},
        {"Smithsonian Astrophysical Observation", "SAO 41011"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.60994010),
        dec: Angle.Degrees(+49.18603129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13123",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2139 B"},
        {"Hipparcos Number", "HIP 13123"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.19863642),
        dec: Angle.Degrees(+49.18627566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30369"},
        {"Smithsonian Astrophysical Observation", "SAO 41055"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.79759480),
        dec: Angle.Degrees(+49.18638940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99625",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13545 A"},
        {"Henry Draper", "HD 192494"},
        {"Hipparcos Number", "HIP 99625"},
        {"Geneva Identification System", "GEN# +1.00192494A"},
        {"Smithsonian Astrophysical Observation", "SAO 49329"},
        {"Wilson Evans Batten Catalogue", "WEB 17850"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.28019663),
        dec: Angle.Degrees(+49.18848744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85301"},
        {"Hipparcos Number", "HIP 48423"},
        {"Geneva Identification System", "GEN# +1.00085301"},
        {"Smithsonian Astrophysical Observation", "SAO 43078"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.07066787),
        dec: Angle.Degrees(+49.19096342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64632"},
        {"Smithsonian Astrophysical Observation", "SAO 44527"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.71656023),
        dec: Angle.Degrees(+49.19478056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133207"},
        {"Hipparcos Number", "HIP 73506"},
        {"Smithsonian Astrophysical Observation", "SAO 45335"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.35960057),
        dec: Angle.Degrees(+49.19481981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98072",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13150 AB"},
        {"Henry Draper", "HD 189065"},
        {"Hipparcos Number", "HIP 98072"},
        {"Celescope Catalog", "CEL 4881"},
        {"Geneva Identification System", "GEN# +1.00189065J"},
        {"Renson", "Renson 52300"},
        {"Smithsonian Astrophysical Observation", "SAO 48994"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.97690148),
        dec: Angle.Degrees(+49.19546385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110053"},
        {"Smithsonian Astrophysical Observation", "SAO 51842"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.36243534),
        dec: Angle.Degrees(+49.19558341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199612"},
        {"Hipparcos Number", "HIP 103360"},
        {"Geneva Identification System", "GEN# +1.00199612"},
        {"Smithsonian Astrophysical Observation", "SAO 50262"},
        {"Wilson Evans Batten Catalogue", "WEB 18791"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.10786528),
        dec: Angle.Degrees(+49.19583069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1940"},
        {"Hipparcos Number", "HIP 1896"},
        {"Smithsonian Astrophysical Observation", "SAO 36325"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.99441021),
        dec: Angle.Degrees(+49.20143312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11949"},
        {"Hipparcos Number", "HIP 9222"},
        {"Geneva Identification System", "GEN# +1.00011949"},
        {"Smithsonian Astrophysical Observation", "SAO 37665"},
        {"Wilson Evans Batten Catalogue", "WEB 1938"},
    },
    visualMagnitude: 5.70,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.63958177),
        dec: Angle.Degrees(+49.20425200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6272"},
        {"Hipparcos Number", "HIP 5028"},
        {"Geneva Identification System", "GEN# +1.00006272"},
        {"Smithsonian Astrophysical Observation", "SAO 36900"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.10208352),
        dec: Angle.Degrees(+49.20488846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86943"},
        {"Hipparcos Number", "HIP 49251"},
        {"Geneva Identification System", "GEN# +1.00086943"},
        {"Smithsonian Astrophysical Observation", "SAO 43157"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.80411466),
        dec: Angle.Degrees(+49.20506766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38293"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.69085790),
        dec: Angle.Degrees(+49.20527784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22417"},
        {"Hipparcos Number", "HIP 16986"},
        {"Geneva Identification System", "GEN# +5.20201245"},
        {"Smithsonian Astrophysical Observation", "SAO 39004"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.61218708),
        dec: Angle.Degrees(+49.20571509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78899"},
        {"Hipparcos Number", "HIP 45187"},
        {"Geneva Identification System", "GEN# +1.00078899"},
        {"Smithsonian Astrophysical Observation", "SAO 42742"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.11779162),
        dec: Angle.Degrees(+49.20691336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92048"},
        {"Hipparcos Number", "HIP 52092"},
        {"Smithsonian Astrophysical Observation", "SAO 43414"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.66015508),
        dec: Angle.Degrees(+49.20816927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21620"},
        {"Hipparcos Number", "HIP 16424"},
        {"Geneva Identification System", "GEN# +5.20200934"},
        {"Smithsonian Astrophysical Observation", "SAO 38906"},
        {"Wilson Evans Batten Catalogue", "WEB 3139"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.87230329),
        dec: Angle.Degrees(+49.20977380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13759"},
        {"Hipparcos Number", "HIP 10519"},
        {"Geneva Identification System", "GEN# +1.00013759"},
        {"Smithsonian Astrophysical Observation", "SAO 37895"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.88506573),
        dec: Angle.Degrees(+49.20981623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58142"},
        {"Hipparcos Number", "HIP 36145"},
        {"Fundamental Katalog 5th Edition", "FK5 2572"},
        {"Geneva Identification System", "GEN# +1.00058142"},
        {"Renson", "Renson 15847"},
        {"Smithsonian Astrophysical Observation", "SAO 41764"},
        {"Wilson Evans Batten Catalogue", "WEB 7196"},
    },
    visualMagnitude: 4.61,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.67858726),
        dec: Angle.Degrees(+49.21164489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195710"},
        {"Hipparcos Number", "HIP 101206"},
        {"Geneva Identification System", "GEN# +1.00195710A"},
        {"Smithsonian Astrophysical Observation", "SAO 49731"},
        {"Wilson Evans Batten Catalogue", "WEB 18282"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.71967205),
        dec: Angle.Degrees(+49.21322898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20809"},
        {"Hipparcos Number", "HIP 15770"},
        {"Geneva Identification System", "GEN# +5.20200557"},
        {"Smithsonian Astrophysical Observation", "SAO 38768"},
        {"Wilson Evans Batten Catalogue", "WEB 3014"},
    },
    visualMagnitude: 5.32,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.80490169),
        dec: Angle.Degrees(+49.21333010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21479"},
        {"Hipparcos Number", "HIP 16277"},
        {"Geneva Identification System", "GEN# +5.20200868"},
        {"Smithsonian Astrophysical Observation", "SAO 38881"},
        {"Wilson Evans Batten Catalogue", "WEB 3105"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.46606446),
        dec: Angle.Degrees(+49.21350992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218999"},
        {"Hipparcos Number", "HIP 114537"},
        {"Smithsonian Astrophysical Observation", "SAO 52784"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.99846815),
        dec: Angle.Degrees(+49.21363444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18613"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.74070786),
        dec: Angle.Degrees(+49.21371089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99142"},
        {"Smithsonian Astrophysical Observation", "SAO 49212"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.91447649),
        dec: Angle.Degrees(+49.21574539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42332"},
        {"Smithsonian Astrophysical Observation", "SAO 42458"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.45873548),
        dec: Angle.Degrees(+49.21977272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195774"},
        {"Hipparcos Number", "HIP 101243"},
        {"Geneva Identification System", "GEN# +1.00195774A"},
        {"Smithsonian Astrophysical Observation", "SAO 49741"},
        {"Wilson Evans Batten Catalogue", "WEB 18290"},
    },
    visualMagnitude: 5.44,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.82836858),
        dec: Angle.Degrees(+49.22037330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210308"},
        {"Hipparcos Number", "HIP 109283"},
        {"Celescope Catalog", "CEL 5440"},
        {"Geneva Identification System", "GEN# +1.00210308J"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.08852852),
        dec: Angle.Degrees(+49.22101090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203284"},
        {"Hipparcos Number", "HIP 105290"},
        {"Geneva Identification System", "GEN# +1.00203284"},
        {"Smithsonian Astrophysical Observation", "SAO 50717"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.90002024),
        dec: Angle.Degrees(+49.22120147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20919"},
        {"Hipparcos Number", "HIP 15862"},
        {"Geneva Identification System", "GEN# +5.20200606"},
        {"Renson", "Renson 5210"},
        {"Smithsonian Astrophysical Observation", "SAO 38788"},
        {"Wilson Evans Batten Catalogue", "WEB 3027"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.07984330),
        dec: Angle.Degrees(+49.22131882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68119"},
        {"Hipparcos Number", "HIP 40253"},
        {"Geneva Identification System", "GEN# +1.00068119"},
        {"Smithsonian Astrophysical Observation", "SAO 42229"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.32275489),
        dec: Angle.Degrees(+49.22161846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -261.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37494"},
        {"Geneva Identification System", "GEN# +0.04901658"},
        {"Wilson Evans Batten Catalogue", "WEB 7415"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.43827628),
        dec: Angle.Degrees(+49.22218217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16149"},
        {"Hipparcos Number", "HIP 12213"},
        {"Smithsonian Astrophysical Observation", "SAO 38171"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.31205234),
        dec: Angle.Degrees(+49.22342102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81135"},
        {"Smithsonian Astrophysical Observation", "SAO 46167"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.54319551),
        dec: Angle.Degrees(+49.22462302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48732"},
    },
    visualMagnitude: 10.22,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.09395911),
        dec: Angle.Degrees(+49.22617227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12777",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2081 A"},
        {"Henry Draper", "HD 16895"},
        {"Hipparcos Number", "HIP 12777"},
        {"Fundamental Katalog 5th Edition", "FK5 93"},
        {"Geneva Identification System", "GEN# +1.00016895"},
        {"Smithsonian Astrophysical Observation", "SAO 38288"},
        {"Wilson Evans Batten Catalogue", "WEB 2597"},
    },
    visualMagnitude: 4.10,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.04869991),
        dec: Angle.Degrees(+49.22866639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 334.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42904",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6954 A"},
        {"Hipparcos Number", "HIP 42904"},
        {"Smithsonian Astrophysical Observation", "SAO 42519"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.15327266),
        dec: Angle.Degrees(+49.22871483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8608"},
        {"Hipparcos Number", "HIP 6689"},
        {"Smithsonian Astrophysical Observation", "SAO 37198"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.47746602),
        dec: Angle.Degrees(+49.23076874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94263"},
        {"Hipparcos Number", "HIP 53258"},
        {"Geneva Identification System", "GEN# +1.00094263"},
        {"Smithsonian Astrophysical Observation", "SAO 43506"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.38098266),
        dec: Angle.Degrees(+49.23124883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28098"},
        {"Hipparcos Number", "HIP 20872"},
        {"Smithsonian Astrophysical Observation", "SAO 39549"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.09560494),
        dec: Angle.Degrees(+49.23164775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161725"},
        {"Hipparcos Number", "HIP 86841"},
        {"Smithsonian Astrophysical Observation", "SAO 46928"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.15836978),
        dec: Angle.Degrees(+49.23182536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233870"},
        {"Hipparcos Number", "HIP 57683"},
        {"Smithsonian Astrophysical Observation", "SAO 43904"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.45506864),
        dec: Angle.Degrees(+49.23214530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -246.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219925"},
        {"Hipparcos Number", "HIP 115130"},
        {"Geneva Identification System", "GEN# +1.00219925"},
        {"Smithsonian Astrophysical Observation", "SAO 52901"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.79449714),
        dec: Angle.Degrees(+49.23332047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115947"},
        {"Geneva Identification System", "GEN# +2.76860003"},
        {"New General Catalogue", "NGC 7686 3"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.36419398),
        dec: Angle.Degrees(+49.23358906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233972"},
        {"Hipparcos Number", "HIP 62040"},
        {"Smithsonian Astrophysical Observation", "SAO 44298"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.75562378),
        dec: Angle.Degrees(+49.23368199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200804"},
        {"Hipparcos Number", "HIP 103971"},
        {"Geneva Identification System", "GEN# +1.00200804"},
        {"Smithsonian Astrophysical Observation", "SAO 50413"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.98568863),
        dec: Angle.Degrees(+49.23946909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97919",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13100 A"},
        {"Henry Draper", "HD 188649"},
        {"Hipparcos Number", "HIP 97919"},
        {"Smithsonian Astrophysical Observation", "SAO 48959"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.50332489),
        dec: Angle.Degrees(+49.24238161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70487"},
    },
    visualMagnitude: 10.75,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.26439930),
        dec: Angle.Degrees(+49.24390471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122150"},
        {"Hipparcos Number", "HIP 68288"},
        {"Smithsonian Astrophysical Observation", "SAO 44825"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.68626315),
        dec: Angle.Degrees(+49.24601092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142107"},
        {"Hipparcos Number", "HIP 77592"},
        {"Smithsonian Astrophysical Observation", "SAO 45754"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.62383248),
        dec: Angle.Degrees(+49.24837744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139479"},
        {"Hipparcos Number", "HIP 76402"},
        {"Smithsonian Astrophysical Observation", "SAO 45633"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.06106522),
        dec: Angle.Degrees(+49.24913068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19101"},
        {"Hipparcos Number", "HIP 14435"},
        {"Geneva Identification System", "GEN# +1.00019101"},
        {"Smithsonian Astrophysical Observation", "SAO 38574"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.57650189),
        dec: Angle.Degrees(+49.25281738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48208"},
        {"Smithsonian Astrophysical Observation", "SAO 43056"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.42567636),
        dec: Angle.Degrees(+49.25334314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215149"},
        {"Hipparcos Number", "HIP 112097"},
        {"Smithsonian Astrophysical Observation", "SAO 52286"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.57614945),
        dec: Angle.Degrees(+49.25543288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183489"},
        {"Hipparcos Number", "HIP 95661"},
        {"Geneva Identification System", "GEN# +1.00183489"},
        {"Renson", "Renson 50670"},
        {"Smithsonian Astrophysical Observation", "SAO 48471"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.88668058),
        dec: Angle.Degrees(+49.25649082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72558"},
        {"Hipparcos Number", "HIP 42153"},
        {"Geneva Identification System", "GEN# +1.00072558"},
        {"Smithsonian Astrophysical Observation", "SAO 42438"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.88676124),
        dec: Angle.Degrees(+49.25808488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35475"},
        {"Hipparcos Number", "HIP 25530"},
        {"Smithsonian Astrophysical Observation", "SAO 40343"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.89379745),
        dec: Angle.Degrees(+49.25878610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39817",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6595 A"},
        {"Henry Draper", "HD 66977"},
        {"Hipparcos Number", "HIP 39817"},
        {"Smithsonian Astrophysical Observation", "SAO 42182"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.03628380),
        dec: Angle.Degrees(+49.25952477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20565"},
    },
    visualMagnitude: 11.47,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.07785282),
        dec: Angle.Degrees(+49.26031863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164502"},
        {"Hipparcos Number", "HIP 88046"},
        {"Smithsonian Astrophysical Observation", "SAO 47108"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.74977298),
        dec: Angle.Degrees(+49.26103634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184786"},
        {"Hipparcos Number", "HIP 96198"},
        {"Geneva Identification System", "GEN# +1.00184786"},
        {"Smithsonian Astrophysical Observation", "SAO 48589"},
        {"Wilson Evans Batten Catalogue", "WEB 16859"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.42335027),
        dec: Angle.Degrees(+49.26234659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72131"},
        {"Hipparcos Number", "HIP 41966"},
        {"Smithsonian Astrophysical Observation", "SAO 42421"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.30979356),
        dec: Angle.Degrees(+49.26404025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50603"},
        {"Smithsonian Astrophysical Observation", "SAO 43288"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.05708734),
        dec: Angle.Degrees(+49.26502613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210119"},
        {"Hipparcos Number", "HIP 109171"},
        {"Smithsonian Astrophysical Observation", "SAO 51666"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.72086720),
        dec: Angle.Degrees(+49.26734776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206954"},
        {"Hipparcos Number", "HIP 107321"},
        {"Celescope Catalog", "CEL 5378"},
        {"Geneva Identification System", "GEN# +1.00206954"},
        {"Smithsonian Astrophysical Observation", "SAO 51243"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.07143649),
        dec: Angle.Degrees(+49.26906155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111811"},
        {"Hipparcos Number", "HIP 62734"},
        {"Smithsonian Astrophysical Observation", "SAO 44357"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.82656782),
        dec: Angle.Degrees(+49.26909544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64349"},
        {"Hipparcos Number", "HIP 38731"},
        {"Smithsonian Astrophysical Observation", "SAO 42073"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.94085373),
        dec: Angle.Degrees(+49.27112985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163092"},
        {"Hipparcos Number", "HIP 87416"},
        {"Smithsonian Astrophysical Observation", "SAO 47021"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.96762231),
        dec: Angle.Degrees(+49.27435101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105866",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14987 A"},
        {"Henry Draper", "HD 204374"},
        {"Hipparcos Number", "HIP 105866"},
        {"Celescope Catalog", "CEL 5312"},
        {"Geneva Identification System", "GEN# +1.00204374J"},
        {"Renson", "Renson 56913"},
        {"Smithsonian Astrophysical Observation", "SAO 50854"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.61821886),
        dec: Angle.Degrees(+49.28023601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7214"},
        {"Hipparcos Number", "HIP 5702"},
        {"Smithsonian Astrophysical Observation", "SAO 37029"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.34252925),
        dec: Angle.Degrees(+49.28053539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10203"},
        {"Hipparcos Number", "HIP 7850"},
        {"Geneva Identification System", "GEN# +1.00010203"},
        {"Smithsonian Astrophysical Observation", "SAO 37424"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.23519530),
        dec: Angle.Degrees(+49.28112622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96569"},
    },
    visualMagnitude: 10.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)37, 54.2200),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)16, 57.400)
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
    primaryId: "HIP 96572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185657"},
        {"Hipparcos Number", "HIP 96572"},
        {"Geneva Identification System", "GEN# +1.00185657"},
        {"Smithsonian Astrophysical Observation", "SAO 48673"},
        {"Wilson Evans Batten Catalogue", "WEB 16946"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.48617077),
        dec: Angle.Degrees(+49.28406240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 145.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16723 A"},
        {"Henry Draper", "HD 220473"},
        {"Hipparcos Number", "HIP 115480"},
        {"Smithsonian Astrophysical Observation", "SAO 52966"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.89685638),
        dec: Angle.Degrees(+49.28469125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44537"},
        {"Hipparcos Number", "HIP 30520"},
        {"Fundamental Katalog 5th Edition", "FK5 242"},
        {"Geneva Identification System", "GEN# +1.00044537"},
        {"Smithsonian Astrophysical Observation", "SAO 41076"},
        {"Wilson Evans Batten Catalogue", "WEB 6077"},
    },
    visualMagnitude: 4.92,
    bvColour: 1.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.22459158),
        dec: Angle.Degrees(+49.28789903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110409"},
        {"Hipparcos Number", "HIP 61927"},
        {"Geneva Identification System", "GEN# +1.00110409"},
        {"Smithsonian Astrophysical Observation", "SAO 44286"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.37017571),
        dec: Angle.Degrees(+49.29046324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117334",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17004 A"},
        {"Henry Draper", "HD 223228"},
        {"Hipparcos Number", "HIP 117334"},
        {"Smithsonian Astrophysical Observation", "SAO 53373"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.87448458),
        dec: Angle.Degrees(+49.29334100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218470"},
        {"Hipparcos Number", "HIP 114210"},
        {"Fundamental Katalog 5th Edition", "FK5 1604"},
        {"Geneva Identification System", "GEN# +1.00218470"},
        {"Smithsonian Astrophysical Observation", "SAO 52713"},
        {"Wilson Evans Batten Catalogue", "WEB 20282"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.93853339),
        dec: Angle.Degrees(+49.29545491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113452"},
        {"Smithsonian Astrophysical Observation", "SAO 52547"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.64864146),
        dec: Angle.Degrees(+49.29577230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42778",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6938 B"},
        {"Hipparcos Number", "HIP 42778"},
    },
    visualMagnitude: 10.64,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.75165018),
        dec: Angle.Degrees(+49.29611979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126530"},
        {"Hipparcos Number", "HIP 70435"},
        {"Geneva Identification System", "GEN# +1.00126530"},
        {"Smithsonian Astrophysical Observation", "SAO 45043"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.13107630),
        dec: Angle.Degrees(+49.29692945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78250"},
        {"Hipparcos Number", "HIP 44912"},
        {"Smithsonian Astrophysical Observation", "SAO 42716"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.24080231),
        dec: Angle.Degrees(+49.29785038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22282"},
        {"Smithsonian Astrophysical Observation", "SAO 39755"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.96124161),
        dec: Angle.Degrees(+49.31489325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125726"},
        {"Hipparcos Number", "HIP 70037"},
        {"Geneva Identification System", "GEN# +1.00125726"},
        {"Smithsonian Astrophysical Observation", "SAO 44997"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.96886855),
        dec: Angle.Degrees(+49.29896380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206601"},
        {"Hipparcos Number", "HIP 107110"},
        {"Geneva Identification System", "GEN# +1.00206601"},
        {"Smithsonian Astrophysical Observation", "SAO 51200"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.44127569),
        dec: Angle.Degrees(+49.29943667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17402"},
        {"Hipparcos Number", "HIP 13164"},
        {"Smithsonian Astrophysical Observation", "SAO 38359"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.32130122),
        dec: Angle.Degrees(+49.30132914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109303"},
        {"Hipparcos Number", "HIP 61264"},
        {"Geneva Identification System", "GEN# +1.00109303"},
        {"Smithsonian Astrophysical Observation", "SAO 44226"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.32965261),
        dec: Angle.Degrees(+49.30201076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42780",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6938 A"},
        {"Henry Draper", "HD 73932"},
        {"Hipparcos Number", "HIP 42780"},
        {"Smithsonian Astrophysical Observation", "SAO 42507"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.75860547),
        dec: Angle.Degrees(+49.30235134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10294"},
        {"Hipparcos Number", "HIP 7919"},
        {"Smithsonian Astrophysical Observation", "SAO 37432"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.44419661),
        dec: Angle.Degrees(+49.30331101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136326"},
        {"Hipparcos Number", "HIP 74882"},
        {"Geneva Identification System", "GEN# +6.20034009"},
        {"Smithsonian Astrophysical Observation", "SAO 45476"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.54885762),
        dec: Angle.Degrees(+49.30551345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83066"},
        {"Hipparcos Number", "HIP 47221"},
        {"Smithsonian Astrophysical Observation", "SAO 42942"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.36101386),
        dec: Angle.Degrees(+49.30606538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15226"},
        {"Hipparcos Number", "HIP 11529"},
        {"Smithsonian Astrophysical Observation", "SAO 38052"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.16588786),
        dec: Angle.Degrees(+49.30655314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15460"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.84304401),
        dec: Angle.Degrees(+49.30735342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207815"},
        {"Hipparcos Number", "HIP 107804"},
        {"Smithsonian Astrophysical Observation", "SAO 51357"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.59596604),
        dec: Angle.Degrees(+49.30841379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90474"},
    },
    visualMagnitude: 12.38,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.91894334),
        dec: Angle.Degrees(+49.30929926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207330"},
        {"Hipparcos Number", "HIP 107533"},
        {"Celescope Catalog", "CEL 5387"},
        {"Fundamental Katalog 5th Edition", "FK5 821"},
        {"Geneva Identification System", "GEN# +1.00207330"},
        {"Smithsonian Astrophysical Observation", "SAO 51293"},
        {"Wilson Evans Batten Catalogue", "WEB 19410"},
    },
    visualMagnitude: 4.23,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.69835794),
        dec: Angle.Degrees(+49.30957480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209856"},
        {"Hipparcos Number", "HIP 109026"},
        {"Smithsonian Astrophysical Observation", "SAO 51631"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.30444907),
        dec: Angle.Degrees(+49.31266591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67301",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alkaid"},
        {"Common Name 2", "Alcaid"},
        {"Henry Draper", "HD 120315"},
        {"Hipparcos Number", "HIP 67301"},
        {"Celescope Catalog", "CEL 4281"},
        {"Fundamental Katalog 5th Edition", "FK5 509"},
        {"Geneva Identification System", "GEN# +1.00120315"},
        {"Smithsonian Astrophysical Observation", "SAO 44752"},
        {"Wilson Evans Batten Catalogue", "WEB 11841"},
    },
    visualMagnitude: 1.85,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.88560880),
        dec: Angle.Degrees(+49.31330288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43748"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.66337077),
        dec: Angle.Degrees(+49.31429365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71761"},
        {"Hipparcos Number", "HIP 41778"},
        {"Geneva Identification System", "GEN# +1.00071761"},
        {"Smithsonian Astrophysical Observation", "SAO 42403"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.78990150),
        dec: Angle.Degrees(+49.31499875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44547"},
        {"Smithsonian Astrophysical Observation", "SAO 42673"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.14563025),
        dec: Angle.Degrees(+49.31651227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176708"},
        {"Hipparcos Number", "HIP 93198"},
        {"Smithsonian Astrophysical Observation", "SAO 47975"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.75382780),
        dec: Angle.Degrees(+49.31941089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220692"},
        {"Hipparcos Number", "HIP 115625"},
        {"Smithsonian Astrophysical Observation", "SAO 52998"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.35156646),
        dec: Angle.Degrees(+49.32160210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14962 A"},
        {"Henry Draper", "HD 204131"},
        {"Hipparcos Number", "HIP 105733"},
        {"Celescope Catalog", "CEL 5309"},
        {"Geneva Identification System", "GEN# +1.00204131"},
        {"Renson", "Renson 56860"},
        {"Smithsonian Astrophysical Observation", "SAO 50817"},
        {"Wilson Evans Batten Catalogue", "WEB 19190"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.23106031),
        dec: Angle.Degrees(+49.32315797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233659"},
        {"Hipparcos Number", "HIP 47264"},
        {"Smithsonian Astrophysical Observation", "SAO 42952"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.50133922),
        dec: Angle.Degrees(+49.32723521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114481"},
        {"Smithsonian Astrophysical Observation", "SAO 52771"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.77599764),
        dec: Angle.Degrees(+49.32744286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202215"},
        {"Hipparcos Number", "HIP 104715"},
        {"Smithsonian Astrophysical Observation", "SAO 50576"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.18469584),
        dec: Angle.Degrees(+49.32961326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218095"},
        {"Hipparcos Number", "HIP 113960"},
        {"Smithsonian Astrophysical Observation", "SAO 52655"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.16949567),
        dec: Angle.Degrees(+49.32986366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1120"},
        {"Hipparcos Number", "HIP 1257"},
        {"Smithsonian Astrophysical Observation", "SAO 36211"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.94216598),
        dec: Angle.Degrees(+49.33017370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11167",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11167"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.93553123),
        dec: Angle.Degrees(+49.33307250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11168"},
        {"Smithsonian Astrophysical Observation", "SAO 37998"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.93817024),
        dec: Angle.Degrees(+49.33871839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44534"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.11201205),
        dec: Angle.Degrees(+49.33894854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38897"},
        {"Hipparcos Number", "HIP 27679"},
        {"Geneva Identification System", "GEN# +1.00038897"},
        {"Smithsonian Astrophysical Observation", "SAO 40651"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.89996252),
        dec: Angle.Degrees(+49.33992858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9137"},
        {"Hipparcos Number", "HIP 7057"},
        {"Smithsonian Astrophysical Observation", "SAO 37285"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.74568301),
        dec: Angle.Degrees(+49.34335825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165845"},
        {"Hipparcos Number", "HIP 88602"},
        {"Smithsonian Astrophysical Observation", "SAO 47209"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.36384492),
        dec: Angle.Degrees(+49.34362037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112316"},
        {"Geneva Identification System", "GEN# +0.04803827A"},
        {"Wilson Evans Batten Catalogue", "WEB 20039"},
    },
    visualMagnitude: 10.30,
    bvColour: 2.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)44, 58.4300),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)28, 53.000)
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
    primaryId: "HIP 32321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48208"},
        {"Hipparcos Number", "HIP 32321"},
        {"Geneva Identification System", "GEN# +1.00048208"},
        {"Smithsonian Astrophysical Observation", "SAO 41307"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.21581818),
        dec: Angle.Degrees(+49.34365045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34076"},
        {"Hipparcos Number", "HIP 24650"},
        {"Smithsonian Astrophysical Observation", "SAO 40193"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.34494828),
        dec: Angle.Degrees(+49.34472160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159607"},
        {"Hipparcos Number", "HIP 85880"},
        {"Smithsonian Astrophysical Observation", "SAO 46793"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.25979873),
        dec: Angle.Degrees(+49.34522588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87530"},
        {"Hipparcos Number", "HIP 49535"},
        {"Smithsonian Astrophysical Observation", "SAO 43192"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.71456546),
        dec: Angle.Degrees(+49.34528004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11170"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.94895217),
        dec: Angle.Degrees(+49.34575224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155696"},
        {"Hipparcos Number", "HIP 84038"},
        {"Smithsonian Astrophysical Observation", "SAO 46545"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.69193313),
        dec: Angle.Degrees(+49.34678836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108048",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15423 A"},
        {"Hipparcos Number", "HIP 108048"},
        {"Smithsonian Astrophysical Observation", "SAO 51403"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.34755129),
        dec: Angle.Degrees(+49.34688062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3140"},
        {"Smithsonian Astrophysical Observation", "SAO 36561"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.98389645),
        dec: Angle.Degrees(+49.34868510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113013"},
        {"Smithsonian Astrophysical Observation", "SAO 52458"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.30339601),
        dec: Angle.Degrees(+49.34894776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106665"},
        {"Geneva Identification System", "GEN# +0.04803437"},
        {"Smithsonian Astrophysical Observation", "SAO 51094"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.06623562),
        dec: Angle.Degrees(+49.34910973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17593"},
        {"Hipparcos Number", "HIP 13300"},
        {"Smithsonian Astrophysical Observation", "SAO 38391"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.79255256),
        dec: Angle.Degrees(+49.35020977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109833",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15778 B"},
        {"Hipparcos Number", "HIP 109833"},
        {"New General Catalogue", "NGC 7243 786"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.68823032),
        dec: Angle.Degrees(+49.35254306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233989"},
        {"Hipparcos Number", "HIP 62826"},
        {"Smithsonian Astrophysical Observation", "SAO 44365"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.11875223),
        dec: Angle.Degrees(+49.35273295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117260"},
        {"Hipparcos Number", "HIP 65703"},
        {"Smithsonian Astrophysical Observation", "SAO 44620"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.06581789),
        dec: Angle.Degrees(+49.35397502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109829",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15778 A"},
        {"Henry Draper", "HD 211264"},
        {"Hipparcos Number", "HIP 109829"},
        {"Geneva Identification System", "GEN# +2.72430785"},
        {"Smithsonian Astrophysical Observation", "SAO 51799"},
        {"New General Catalogue", "NGC 7243 785"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.67986639),
        dec: Angle.Degrees(+49.35428043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3083",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 546 A"},
        {"Henry Draper", "HD 3574"},
        {"Hipparcos Number", "HIP 3083"},
        {"Geneva Identification System", "GEN# +1.00003574"},
        {"Smithsonian Astrophysical Observation", "SAO 36550"},
        {"Wilson Evans Batten Catalogue", "WEB 549"},
    },
    visualMagnitude: 5.45,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.79119583),
        dec: Angle.Degrees(+49.35459528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134608"},
        {"Hipparcos Number", "HIP 74140"},
        {"Smithsonian Astrophysical Observation", "SAO 45400"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.25079038),
        dec: Angle.Degrees(+49.35515604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213389"},
        {"Hipparcos Number", "HIP 111072"},
        {"Geneva Identification System", "GEN# +1.00213389"},
        {"Smithsonian Astrophysical Observation", "SAO 52073"},
        {"Wilson Evans Batten Catalogue", "WEB 19887"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.52719268),
        dec: Angle.Degrees(+49.35648561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83629"},
        {"Hipparcos Number", "HIP 47532"},
        {"Smithsonian Astrophysical Observation", "SAO 42977"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.36165492),
        dec: Angle.Degrees(+49.36115581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233953"},
        {"Hipparcos Number", "HIP 61515"},
        {"Geneva Identification System", "GEN# +1.00233953"},
        {"Smithsonian Astrophysical Observation", "SAO 44245"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.05313146),
        dec: Angle.Degrees(+49.36298793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222104"},
        {"Hipparcos Number", "HIP 116578"},
        {"Geneva Identification System", "GEN# +1.00222104"},
        {"Smithsonian Astrophysical Observation", "SAO 53197"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.36419449),
        dec: Angle.Degrees(+49.36402527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17858"},
        {"Hipparcos Number", "HIP 13500"},
        {"Smithsonian Astrophysical Observation", "SAO 38421"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.46868425),
        dec: Angle.Degrees(+49.36410152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66589"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.75096707),
        dec: Angle.Degrees(+49.36603343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128333"},
        {"Hipparcos Number", "HIP 71280"},
        {"Fundamental Katalog 5th Edition", "FK5 3155"},
        {"Geneva Identification System", "GEN# +1.00128333"},
        {"Smithsonian Astrophysical Observation", "SAO 45121"},
        {"Wilson Evans Batten Catalogue", "WEB 12316"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.66525670),
        dec: Angle.Degrees(+49.36823171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62854"},
        {"Hipparcos Number", "HIP 38084"},
        {"Geneva Identification System", "GEN# +1.00062854"},
        {"Smithsonian Astrophysical Observation", "SAO 42005"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.06932713),
        dec: Angle.Degrees(+49.37028990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48710"},
        {"Hipparcos Number", "HIP 32443"},
        {"Smithsonian Astrophysical Observation", "SAO 41321"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.56737847),
        dec: Angle.Degrees(+49.37457227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211047"},
        {"Hipparcos Number", "HIP 109706"},
        {"Smithsonian Astrophysical Observation", "SAO 51775"},
        {"New General Catalogue", "NGC 7243 689"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.32713751),
        dec: Angle.Degrees(+49.37466797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113320"},
        {"Smithsonian Astrophysical Observation", "SAO 52525"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.24982284),
        dec: Angle.Degrees(+49.37481423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99001"},
        {"Hipparcos Number", "HIP 55652"},
        {"Smithsonian Astrophysical Observation", "SAO 43730"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.02790511),
        dec: Angle.Degrees(+49.37506621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99177"},
        {"Hipparcos Number", "HIP 55744"},
        {"Fundamental Katalog 5th Edition", "FK5 5005"},
        {"Geneva Identification System", "GEN# +1.00099177"},
        {"Smithsonian Astrophysical Observation", "SAO 43734"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.32228625),
        dec: Angle.Degrees(+49.37544615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65388"},
    },
    visualMagnitude: 12.45,
    bvColour: -0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.00311290),
        dec: Angle.Degrees(+49.37562165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72777"},
        {"Hipparcos Number", "HIP 42239"},
        {"Smithsonian Astrophysical Observation", "SAO 42444"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.17011162),
        dec: Angle.Degrees(+49.37629353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 566"},
        {"Smithsonian Astrophysical Observation", "SAO 36069"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.71819731),
        dec: Angle.Degrees(+49.38212406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195069"},
        {"Henry Draper 2", "HD 195068"},
        {"Hipparcos Number", "HIP 100859"},
        {"Geneva Identification System", "GEN# +1.00195068"},
        {"Smithsonian Astrophysical Observation", "SAO 49643"},
        {"Wilson Evans Batten Catalogue", "WEB 18224"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.75919090),
        dec: Angle.Degrees(+49.38322449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173326"},
        {"Hipparcos Number", "HIP 91708"},
        {"Smithsonian Astrophysical Observation", "SAO 47722"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.53512196),
        dec: Angle.Degrees(+49.38532644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111303",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16046 AB"},
        {"Henry Draper", "HD 213776"},
        {"Hipparcos Number", "HIP 111303"},
        {"Geneva Identification System", "GEN# +1.00213776J"},
        {"Smithsonian Astrophysical Observation", "SAO 52127"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.22371859),
        dec: Angle.Degrees(+49.38741271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198286"},
        {"Hipparcos Number", "HIP 102590"},
        {"Fundamental Katalog 5th Edition", "FK5 5832"},
        {"Geneva Identification System", "GEN# +1.00198286"},
        {"Smithsonian Astrophysical Observation", "SAO 50064"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.85804630),
        dec: Angle.Degrees(+49.38833208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203644"},
        {"Hipparcos Number", "HIP 105497"},
        {"Geneva Identification System", "GEN# +1.00203644"},
        {"Smithsonian Astrophysical Observation", "SAO 50761"},
        {"Wilson Evans Batten Catalogue", "WEB 19156"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.50160330),
        dec: Angle.Degrees(+49.38869874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2188"},
        {"Hipparcos Number", "HIP 2075"},
        {"Smithsonian Astrophysical Observation", "SAO 36363"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.55405509),
        dec: Angle.Degrees(+49.38931252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82559"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.13275227),
        dec: Angle.Degrees(+49.38975910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217526"},
        {"Hipparcos Number", "HIP 113606"},
        {"Smithsonian Astrophysical Observation", "SAO 52589"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.15367406),
        dec: Angle.Degrees(+49.39086973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204102"},
        {"Hipparcos Number", "HIP 105722"},
        {"Geneva Identification System", "GEN# +1.00204102"},
        {"Smithsonian Astrophysical Observation", "SAO 50811"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.19670047),
        dec: Angle.Degrees(+49.39182507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18869"},
        {"Hipparcos Number", "HIP 14267"},
        {"Smithsonian Astrophysical Observation", "SAO 38542"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.99183049),
        dec: Angle.Degrees(+49.39276594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36146"},
        {"Hipparcos Number", "HIP 25964"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.08579570),
        dec: Angle.Degrees(+49.39348179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65367"},
        {"Hipparcos Number", "HIP 39167"},
        {"Smithsonian Astrophysical Observation", "SAO 42119"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.16896893),
        dec: Angle.Degrees(+49.39506049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77903"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.64993179),
        dec: Angle.Degrees(+49.39546104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233877"},
        {"Hipparcos Number", "HIP 57935"},
        {"Smithsonian Astrophysical Observation", "SAO 43932"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.22575980),
        dec: Angle.Degrees(+49.39593894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33103"},
        {"Hipparcos Number", "HIP 24097"},
        {"Smithsonian Astrophysical Observation", "SAO 40071"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.64194501),
        dec: Angle.Degrees(+49.39594700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127064"},
        {"Hipparcos Number", "HIP 70710"},
        {"Geneva Identification System", "GEN# +1.00127064"},
        {"Smithsonian Astrophysical Observation", "SAO 45063"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.93213984),
        dec: Angle.Degrees(+49.39645785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219951"},
        {"Hipparcos Number", "HIP 115155"},
        {"Smithsonian Astrophysical Observation", "SAO 52909"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.88632859),
        dec: Angle.Degrees(+49.39695188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114045"},
        {"Smithsonian Astrophysical Observation", "SAO 52673"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.43656454),
        dec: Angle.Degrees(+49.39863503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21661"},
        {"Hipparcos Number", "HIP 16447"},
        {"Geneva Identification System", "GEN# +5.20200954"},
        {"Smithsonian Astrophysical Observation", "SAO 38912"},
        {"Wilson Evans Batten Catalogue", "WEB 3141"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.95433039),
        dec: Angle.Degrees(+49.40109538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47879"},
        {"Hipparcos Number", "HIP 32204"},
        {"Smithsonian Astrophysical Observation", "SAO 41290"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.83074909),
        dec: Angle.Degrees(+49.40373876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126378"},
        {"Hipparcos Number", "HIP 70349"},
        {"Smithsonian Astrophysical Observation", "SAO 45030"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.90227476),
        dec: Angle.Degrees(+49.40514902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4285",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 749 AB"},
        {"Henry Draper", "HD 5259"},
        {"Hipparcos Number", "HIP 4285"},
        {"Smithsonian Astrophysical Observation", "SAO 36760"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.72432498),
        dec: Angle.Degrees(+49.40529384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219080"},
        {"Hipparcos Number", "HIP 114570"},
        {"Geneva Identification System", "GEN# +1.00219080"},
        {"Smithsonian Astrophysical Observation", "SAO 52787"},
        {"Wilson Evans Batten Catalogue", "WEB 20327"},
    },
    visualMagnitude: 4.53,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.13717883),
        dec: Angle.Degrees(+49.40597489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215427"},
        {"Hipparcos Number", "HIP 112261"},
        {"Smithsonian Astrophysical Observation", "SAO 52320"},
        {"Wilson Evans Batten Catalogue", "WEB 20034"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.07219286),
        dec: Angle.Degrees(+49.41209840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80697"},
        {"Fundamental Katalog 5th Edition", "FK5 5458"},
        {"Smithsonian Astrophysical Observation", "SAO 46110"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.14604949),
        dec: Angle.Degrees(+49.41555436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37145"},
        {"Hipparcos Number", "HIP 26569"},
        {"Geneva Identification System", "GEN# +1.00037145"},
        {"Smithsonian Astrophysical Observation", "SAO 40505"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.73644721),
        dec: Angle.Degrees(+49.41621643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12632",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2051 AB"},
        {"Henry Draper", "HD 16692"},
        {"Hipparcos Number", "HIP 12632"},
        {"Smithsonian Astrophysical Observation", "SAO 38249"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.58218202),
        dec: Angle.Degrees(+49.41626117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93089"},
        {"Hipparcos Number", "HIP 52644"},
        {"Geneva Identification System", "GEN# +1.00093089"},
        {"Smithsonian Astrophysical Observation", "SAO 43464"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.47093973),
        dec: Angle.Degrees(+49.41771258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41050"},
        {"Smithsonian Astrophysical Observation", "SAO 42315"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.65074562),
        dec: Angle.Degrees(+49.42184846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110981"},
        {"Smithsonian Astrophysical Observation", "SAO 52051"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.27477161),
        dec: Angle.Degrees(+49.42320702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181020"},
        {"Hipparcos Number", "HIP 94715"},
        {"Smithsonian Astrophysical Observation", "SAO 48270"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.09317558),
        dec: Angle.Degrees(+49.42443987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84105"},
        {"Hipparcos Number", "HIP 47768"},
        {"Geneva Identification System", "GEN# +1.00084105"},
        {"Smithsonian Astrophysical Observation", "SAO 43004"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.08834280),
        dec: Angle.Degrees(+49.42581886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7349"},
        {"Hipparcos Number", "HIP 5813"},
        {"Smithsonian Astrophysical Observation", "SAO 37044"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.64905056),
        dec: Angle.Degrees(+49.42967310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92204",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11698 AB"},
        {"Henry Draper", "HD 174343"},
        {"Henry Draper 2", "HD 174344"},
        {"Hipparcos Number", "HIP 92204"},
        {"Renson", "Renson 48840"},
        {"Smithsonian Astrophysical Observation", "SAO 47811"},
        {"Wilson Evans Batten Catalogue", "WEB 15904"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.87320626),
        dec: Angle.Degrees(+49.43205046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234045"},
        {"Hipparcos Number", "HIP 65792"},
        {"Smithsonian Astrophysical Observation", "SAO 44626"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.30827877),
        dec: Angle.Degrees(+49.43207887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132911"},
        {"Hipparcos Number", "HIP 73392"},
        {"Geneva Identification System", "GEN# +1.00132911"},
        {"Smithsonian Astrophysical Observation", "SAO 45323"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.97346493),
        dec: Angle.Degrees(+49.43357449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114624"},
        {"Smithsonian Astrophysical Observation", "SAO 52803"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.31190791),
        dec: Angle.Degrees(+49.43657796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206110"},
        {"Hipparcos Number", "HIP 106844"},
        {"Geneva Identification System", "GEN# +1.00206110"},
        {"Smithsonian Astrophysical Observation", "SAO 51132"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.61027067),
        dec: Angle.Degrees(+49.43703301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207839"},
        {"Hipparcos Number", "HIP 107822"},
        {"Smithsonian Astrophysical Observation", "SAO 51363"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.65515806),
        dec: Angle.Degrees(+49.43782575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82380"},
        {"Hipparcos Number", "HIP 46873"},
        {"Geneva Identification System", "GEN# +1.00082380"},
        {"Smithsonian Astrophysical Observation", "SAO 42914"},
        {"Wilson Evans Batten Catalogue", "WEB 8836"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.28078152),
        dec: Angle.Degrees(+49.43864160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92917"},
        {"Hipparcos Number", "HIP 52539"},
        {"Smithsonian Astrophysical Observation", "SAO 43455"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.13646994),
        dec: Angle.Degrees(+49.43916867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112312"},
        {"Hipparcos Number", "HIP 63051"},
        {"Smithsonian Astrophysical Observation", "SAO 44387"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.78815993),
        dec: Angle.Degrees(+49.43947074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193762"},
        {"Hipparcos Number", "HIP 100252"},
        {"Smithsonian Astrophysical Observation", "SAO 49483"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.99193114),
        dec: Angle.Degrees(+49.44028231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15160"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.84810414),
        dec: Angle.Degrees(+49.44034862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11418"},
        {"Hipparcos Number", "HIP 8826"},
        {"Geneva Identification System", "GEN# +1.00011418"},
        {"Smithsonian Astrophysical Observation", "SAO 37588"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.37128164),
        dec: Angle.Degrees(+49.44483876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140487"},
        {"Hipparcos Number", "HIP 76867"},
        {"Fundamental Katalog 5th Edition", "FK5 5391"},
        {"Geneva Identification System", "GEN# +1.00140487"},
        {"Smithsonian Astrophysical Observation", "SAO 45686"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.44813200),
        dec: Angle.Degrees(+49.44507075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81458"},
        {"Hipparcos Number", "HIP 46375"},
        {"Smithsonian Astrophysical Observation", "SAO 42866"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.84478711),
        dec: Angle.Degrees(+49.44512004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28023"},
        {"Hipparcos Number", "HIP 20833"},
        {"Smithsonian Astrophysical Observation", "SAO 39544"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.96867307),
        dec: Angle.Degrees(+49.44555519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160229"},
        {"Hipparcos Number", "HIP 86148"},
        {"Smithsonian Astrophysical Observation", "SAO 46831"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.07304177),
        dec: Angle.Degrees(+49.44571906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41520"},
        {"Hipparcos Number", "HIP 29109"},
        {"Smithsonian Astrophysical Observation", "SAO 40874"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.07983273),
        dec: Angle.Degrees(+49.44585180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40744",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6728 A"},
        {"Henry Draper", "HD 69409"},
        {"Hipparcos Number", "HIP 40744"},
        {"Smithsonian Astrophysical Observation", "SAO 42283"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.76249532),
        dec: Angle.Degrees(+49.44618991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111356"},
        {"Smithsonian Astrophysical Observation", "SAO 52144"},
    },
    visualMagnitude: 9.36,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.39611304),
        dec: Angle.Degrees(+49.44672026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115598"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.24633902),
        dec: Angle.Degrees(+49.44776444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114310"},
        {"Hipparcos Number", "HIP 64163"},
        {"Smithsonian Astrophysical Observation", "SAO 44488"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.25486935),
        dec: Angle.Degrees(+49.45256143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234110"},
        {"Hipparcos Number", "HIP 69252"},
        {"Smithsonian Astrophysical Observation", "SAO 44924"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.65094132),
        dec: Angle.Degrees(+49.45424203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43335"},
        {"Smithsonian Astrophysical Observation", "SAO 42560"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.42914689),
        dec: Angle.Degrees(+49.45439066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88230"},
        {"Hipparcos Number", "HIP 49908"},
        {"Cincinnati Publication", "Ci 20 564"},
        {"Cincinnati Publication 2", "Ci 18 1218"},
        {"Geneva Identification System", "GEN# +1.00088230"},
        {"Smithsonian Astrophysical Observation", "SAO 43223"},
        {"Wilson Evans Batten Catalogue", "WEB 9187"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.84734577),
        dec: Angle.Degrees(+49.45546425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1361.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -505.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43302"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.33447336),
        dec: Angle.Degrees(+49.45634445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -268.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56361",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8210 AB"},
        {"Henry Draper", "HD 233841"},
        {"Hipparcos Number", "HIP 56361"},
        {"Smithsonian Astrophysical Observation", "SAO 43803"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.30454591),
        dec: Angle.Degrees(+49.45644485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123782"},
        {"Hipparcos Number", "HIP 69068"},
        {"Fundamental Katalog 5th Edition", "FK5 3124"},
        {"Geneva Identification System", "GEN# +1.00123782"},
        {"Smithsonian Astrophysical Observation", "SAO 44905"},
        {"Wilson Evans Batten Catalogue", "WEB 12061"},
    },
    visualMagnitude: 5.26,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.07231683),
        dec: Angle.Degrees(+49.45802060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182077"},
        {"Hipparcos Number", "HIP 95074"},
        {"Smithsonian Astrophysical Observation", "SAO 48358"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.15358437),
        dec: Angle.Degrees(+49.45987350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1240"},
        {"Hipparcos Number", "HIP 1352"},
        {"Smithsonian Astrophysical Observation", "SAO 36234"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.22488512),
        dec: Angle.Degrees(+49.46192856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183255"},
        {"Hipparcos Number", "HIP 95575"},
        {"Cincinnati Publication", "Ci 20 1153"},
        {"Geneva Identification System", "GEN# +1.00183255"},
        {"Wilson Evans Batten Catalogue", "WEB 16714"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.60655771),
        dec: Angle.Degrees(+49.46357557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 457.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 713.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56169"},
        {"Hipparcos Number", "HIP 35384"},
        {"Geneva Identification System", "GEN# +1.00056169"},
        {"Smithsonian Astrophysical Observation", "SAO 41681"},
        {"Wilson Evans Batten Catalogue", "WEB 7059"},
    },
    visualMagnitude: 5.00,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.63324602),
        dec: Angle.Degrees(+49.46474619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233605"},
        {"Hipparcos Number", "HIP 44954"},
        {"Smithsonian Astrophysical Observation", "SAO 42721"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.37714438),
        dec: Angle.Degrees(+49.46568129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166011"},
        {"Hipparcos Number", "HIP 88669"},
        {"Geneva Identification System", "GEN# +1.00166011"},
        {"Smithsonian Astrophysical Observation", "SAO 47217"},
        {"Wilson Evans Batten Catalogue", "WEB 15023"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.52960164),
        dec: Angle.Degrees(+49.46612641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122483"},
        {"Hipparcos Number", "HIP 68459"},
        {"Geneva Identification System", "GEN# +1.00122483"},
        {"Smithsonian Astrophysical Observation", "SAO 44844"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.22541143),
        dec: Angle.Degrees(+49.46920361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53283"},
        {"Hipparcos Number", "HIP 34333"},
        {"Geneva Identification System", "GEN# +1.00053283"},
        {"Smithsonian Astrophysical Observation", "SAO 41557"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.75362029),
        dec: Angle.Degrees(+49.47119209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211094"},
        {"Hipparcos Number", "HIP 109727"},
        {"Geneva Identification System", "GEN# +2.72430694"},
        {"Smithsonian Astrophysical Observation", "SAO 51780"},
        {"New General Catalogue", "NGC 7243 694"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.40755242),
        dec: Angle.Degrees(+49.47124915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113827"},
        {"Hipparcos Number", "HIP 63894"},
        {"Geneva Identification System", "GEN# +1.00113827"},
        {"Smithsonian Astrophysical Observation", "SAO 44462"},
        {"Wilson Evans Batten Catalogue", "WEB 11294"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.42229676),
        dec: Angle.Degrees(+49.47159535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153989"},
        {"Hipparcos Number", "HIP 83200"},
        {"Smithsonian Astrophysical Observation", "SAO 46433"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.05563671),
        dec: Angle.Degrees(+49.47174104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216783"},
        {"Hipparcos Number", "HIP 113177"},
        {"Geneva Identification System", "GEN# +1.00216783"},
        {"Smithsonian Astrophysical Observation", "SAO 52486"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.76624768),
        dec: Angle.Degrees(+49.47335157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23896"},
        {"Hipparcos Number", "HIP 18004"},
        {"Smithsonian Astrophysical Observation", "SAO 39144"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.73920969),
        dec: Angle.Degrees(+49.47432893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97989"},
        {"Hipparcos Number", "HIP 55086"},
        {"Fundamental Katalog 5th Edition", "FK5 424"},
        {"Geneva Identification System", "GEN# +1.00097989"},
        {"Smithsonian Astrophysical Observation", "SAO 43675"},
        {"Wilson Evans Batten Catalogue", "WEB 9933"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.17469204),
        dec: Angle.Degrees(+49.47627707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212593"},
        {"Hipparcos Number", "HIP 110609"},
        {"Geneva Identification System", "GEN# +1.00212593"},
        {"Smithsonian Astrophysical Observation", "SAO 51970"},
        {"Wilson Evans Batten Catalogue", "WEB 19823"},
    },
    visualMagnitude: 4.55,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.12914880),
        dec: Angle.Degrees(+49.47640074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12073"},
        {"Hipparcos Number", "HIP 9327"},
        {"Geneva Identification System", "GEN# +1.00012073"},
        {"Smithsonian Astrophysical Observation", "SAO 37683"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.94317112),
        dec: Angle.Degrees(+49.47799469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118457"},
        {"Hipparcos Number", "HIP 66359"},
        {"Smithsonian Astrophysical Observation", "SAO 44680"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.03714076),
        dec: Angle.Degrees(+49.47843137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70131"},
        {"Hipparcos Number", "HIP 41029"},
        {"Smithsonian Astrophysical Observation", "SAO 42314"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.60825815),
        dec: Angle.Degrees(+49.47875215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233927"},
        {"Hipparcos Number", "HIP 60328"},
        {"Smithsonian Astrophysical Observation", "SAO 44143"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.54762341),
        dec: Angle.Degrees(+49.47914993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178874"},
        {"Hipparcos Number", "HIP 93951"},
        {"Geneva Identification System", "GEN# +1.00178874"},
        {"Smithsonian Astrophysical Observation", "SAO 48119"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.94521539),
        dec: Angle.Degrees(+49.48526626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43171"},
        {"Hipparcos Number", "HIP 29869"},
        {"Smithsonian Astrophysical Observation", "SAO 40993"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.33736710),
        dec: Angle.Degrees(+49.48563300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118536"},
        {"Hipparcos Number", "HIP 66385"},
        {"Smithsonian Astrophysical Observation", "SAO 44682"},
        {"Wilson Evans Batten Catalogue", "WEB 11722"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.16622825),
        dec: Angle.Degrees(+49.48668434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40421"},
        {"Hipparcos Number", "HIP 28530"},
        {"Geneva Identification System", "GEN# +1.00040421"},
        {"Smithsonian Astrophysical Observation", "SAO 40781"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.33253624),
        dec: Angle.Degrees(+49.48999840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203746"},
        {"Hipparcos Number", "HIP 105540"},
        {"Celescope Catalog", "CEL 5301"},
        {"Geneva Identification System", "GEN# +1.00203746"},
        {"Smithsonian Astrophysical Observation", "SAO 50768"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.62062826),
        dec: Angle.Degrees(+49.49142073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116353"},
        {"Smithsonian Astrophysical Observation", "SAO 53157"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.65512601),
        dec: Angle.Degrees(+49.49221672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223360"},
        {"Hipparcos Number", "HIP 117443"},
        {"Smithsonian Astrophysical Observation", "SAO 53397"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.19885286),
        dec: Angle.Degrees(+49.49596432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100301"},
        {"Hipparcos Number", "HIP 56325"},
        {"Smithsonian Astrophysical Observation", "SAO 43802"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.20995535),
        dec: Angle.Degrees(+49.49605804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193550"},
        {"Hipparcos Number", "HIP 100125"},
        {"Geneva Identification System", "GEN# +1.00193550"},
        {"Smithsonian Astrophysical Observation", "SAO 49459"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.66793158),
        dec: Angle.Degrees(+49.49776670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218406"},
        {"Hipparcos Number", "HIP 114169"},
        {"Smithsonian Astrophysical Observation", "SAO 52708"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.81704510),
        dec: Angle.Degrees(+49.49952176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233908"},
        {"Hipparcos Number", "HIP 59470"},
        {"Smithsonian Astrophysical Observation", "SAO 44073"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.96951932),
        dec: Angle.Degrees(+49.50069964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215384"},
        {"Hipparcos Number", "HIP 112234"},
        {"Smithsonian Astrophysical Observation", "SAO 52316"},
    },
    visualMagnitude: 9.18,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.98406735),
        dec: Angle.Degrees(+49.50390169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17197"},
        {"Wilson Evans Batten Catalogue", "WEB 3255"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.23531716),
        dec: Angle.Degrees(+49.50617324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98395"},
        {"Hipparcos Number", "HIP 55310"},
        {"Smithsonian Astrophysical Observation", "SAO 43695"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.90978532),
        dec: Angle.Degrees(+49.50617566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15777"},
        {"Hipparcos Number", "HIP 11923"},
        {"Cincinnati Publication", "Ci 20 171"},
        {"Cincinnati Publication 2", "Ci 18 327"},
        {"Geneva Identification System", "GEN# +1.00015777"},
        {"Smithsonian Astrophysical Observation", "SAO 38119"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.47224530),
        dec: Angle.Degrees(+49.50623720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 434.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88046"},
        {"Hipparcos Number", "HIP 49825"},
        {"Geneva Identification System", "GEN# +1.00088046"},
        {"Smithsonian Astrophysical Observation", "SAO 43216"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.57062600),
        dec: Angle.Degrees(+49.50742544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221378"},
        {"Hipparcos Number", "HIP 116094"},
        {"Smithsonian Astrophysical Observation", "SAO 53114"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.85635300),
        dec: Angle.Degrees(+49.50789495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95869",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12535 AB"},
        {"Henry Draper", "HD 184007"},
        {"Hipparcos Number", "HIP 95869"},
        {"Smithsonian Astrophysical Observation", "SAO 48517"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.48037156),
        dec: Angle.Degrees(+49.50879249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16244",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2558 A"},
        {"Henry Draper", "HD 21428"},
        {"Hipparcos Number", "HIP 16244"},
        {"Geneva Identification System", "GEN# +5.20200835"},
        {"Smithsonian Astrophysical Observation", "SAO 38872"},
        {"Wilson Evans Batten Catalogue", "WEB 3097"},
    },
    visualMagnitude: 4.67,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.34179296),
        dec: Angle.Degrees(+49.50901919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1478",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 248 A"},
        {"Henry Draper", "HD 1402"},
        {"Hipparcos Number", "HIP 1478"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.58983489),
        dec: Angle.Degrees(+49.50977782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32212"},
        {"Hipparcos Number", "HIP 23568"},
        {"Smithsonian Astrophysical Observation", "SAO 39982"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.00970025),
        dec: Angle.Degrees(+49.50996354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39097"},
        {"Smithsonian Astrophysical Observation", "SAO 42110"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.97456663),
        dec: Angle.Degrees(+49.51003533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203245"},
        {"Hipparcos Number", "HIP 105282"},
        {"Celescope Catalog", "CEL 5295"},
        {"Fundamental Katalog 5th Edition", "FK5 3702"},
        {"Geneva Identification System", "GEN# +1.00203245"},
        {"Smithsonian Astrophysical Observation", "SAO 50713"},
        {"Wilson Evans Batten Catalogue", "WEB 19122"},
    },
    visualMagnitude: 5.75,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.86973952),
        dec: Angle.Degrees(+49.51028920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222570"},
        {"Hipparcos Number", "HIP 116876"},
        {"Geneva Identification System", "GEN# +1.00222570"},
        {"Smithsonian Astrophysical Observation", "SAO 53276"},
        {"Wilson Evans Batten Catalogue", "WEB 20619"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.36165797),
        dec: Angle.Degrees(+49.51246055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207020"},
        {"Hipparcos Number", "HIP 107363"},
        {"Smithsonian Astrophysical Observation", "SAO 51250"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.18793352),
        dec: Angle.Degrees(+49.51289286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220870"},
        {"Hipparcos Number", "HIP 115743"},
        {"Smithsonian Astrophysical Observation", "SAO 53036"},
        {"Wilson Evans Batten Catalogue", "WEB 20481"},
    },
    visualMagnitude: 9.10,
    bvColour: 2.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.73902188),
        dec: Angle.Degrees(+49.51638724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47289"},
        {"Hipparcos Number", "HIP 31933"},
        {"Smithsonian Astrophysical Observation", "SAO 41250"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.10349050),
        dec: Angle.Degrees(+49.51947868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85024"},
        {"Smithsonian Astrophysical Observation", "SAO 46680"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.67517705),
        dec: Angle.Degrees(+49.52038294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107364"},
        {"Smithsonian Astrophysical Observation", "SAO 51251"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.19188655),
        dec: Angle.Degrees(+49.52042092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85175",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10541 A"},
        {"Henry Draper", "HD 158033"},
        {"Hipparcos Number", "HIP 85175"},
        {"Geneva Identification System", "GEN# +1.00158033"},
        {"Smithsonian Astrophysical Observation", "SAO 46697"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.10001482),
        dec: Angle.Degrees(+49.52443672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128643"},
        {"Hipparcos Number", "HIP 71436"},
        {"Smithsonian Astrophysical Observation", "SAO 45132"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.11975706),
        dec: Angle.Degrees(+49.52623585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75202"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.52400244),
        dec: Angle.Degrees(+66.25915241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 175.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205552"},
        {"Hipparcos Number", "HIP 106536"},
        {"Geneva Identification System", "GEN# +1.00205552"},
        {"Smithsonian Astrophysical Observation", "SAO 51053"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.65852950),
        dec: Angle.Degrees(+49.52647156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126452"},
        {"Hipparcos Number", "HIP 70387"},
        {"Geneva Identification System", "GEN# +1.00126452"},
        {"Smithsonian Astrophysical Observation", "SAO 45038"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.02336866),
        dec: Angle.Degrees(+49.53231126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199216"},
        {"Hipparcos Number", "HIP 103143"},
        {"Geneva Identification System", "GEN# +1.00199216"},
        {"Smithsonian Astrophysical Observation", "SAO 50203"},
        {"Wilson Evans Batten Catalogue", "WEB 18734"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.46836002),
        dec: Angle.Degrees(+49.53343519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84639"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.55178190),
        dec: Angle.Degrees(+49.53387497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 240.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49881"},
        {"Hipparcos Number", "HIP 33051"},
        {"Smithsonian Astrophysical Observation", "SAO 41403"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.27407889),
        dec: Angle.Degrees(+49.53416013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8757"},
        {"Hipparcos Number", "HIP 6787"},
        {"Smithsonian Astrophysical Observation", "SAO 37224"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.83970719),
        dec: Angle.Degrees(+49.53755617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171761"},
        {"Hipparcos Number", "HIP 91023"},
        {"Geneva Identification System", "GEN# +1.00171761"},
        {"Smithsonian Astrophysical Observation", "SAO 47608"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.52793729),
        dec: Angle.Degrees(+49.53767875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6471",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6471"},
        {"Smithsonian Astrophysical Observation", "SAO 37164"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.80612755),
        dec: Angle.Degrees(+49.53845650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214607"},
        {"Hipparcos Number", "HIP 111769"},
        {"Smithsonian Astrophysical Observation", "SAO 52216"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.61114738),
        dec: Angle.Degrees(+49.54060315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113265"},
        {"Smithsonian Astrophysical Observation", "SAO 52509"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.04102277),
        dec: Angle.Degrees(+49.54230801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13976 AB"},
        {"Henry Draper", "HD 195853"},
        {"Hipparcos Number", "HIP 101284"},
        {"Smithsonian Astrophysical Observation", "SAO 49754"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.94378353),
        dec: Angle.Degrees(+49.54234728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4786",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 842 AB"},
        {"Henry Draper", "HD 5927"},
        {"Hipparcos Number", "HIP 4786"},
        {"Geneva Identification System", "GEN# +1.00005927"},
        {"Smithsonian Astrophysical Observation", "SAO 36853"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.36266775),
        dec: Angle.Degrees(+49.54422654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38824"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.18640479),
        dec: Angle.Degrees(+49.54431928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80608"},
        {"Hipparcos Number", "HIP 45974"},
        {"Smithsonian Astrophysical Observation", "SAO 42825"},
    },
    visualMagnitude: 6.94,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.63425039),
        dec: Angle.Degrees(+49.54483875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33877"},
        {"Hipparcos Number", "HIP 24549"},
        {"Smithsonian Astrophysical Observation", "SAO 40175"},
        {"Wilson Evans Batten Catalogue", "WEB 4753"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.99115573),
        dec: Angle.Degrees(+49.54647831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 669"},
        {"Hipparcos Number", "HIP 905"},
        {"Geneva Identification System", "GEN# +1.00000669"},
        {"Smithsonian Astrophysical Observation", "SAO 36138"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.78892638),
        dec: Angle.Degrees(+49.54666660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12756"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.98451419),
        dec: Angle.Degrees(+49.54914281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6564"},
        {"Hipparcos Number", "HIP 5262"},
        {"Celescope Catalog", "CEL 118"},
        {"Geneva Identification System", "GEN# +1.00006564"},
        {"Smithsonian Astrophysical Observation", "SAO 36936"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.80778883),
        dec: Angle.Degrees(+49.55546798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16880"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.30813871),
        dec: Angle.Degrees(+49.55759569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56012"},
        {"Geneva Identification System", "GEN# +0.05001822"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.18781451),
        dec: Angle.Degrees(+49.55903785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130666"},
        {"Hipparcos Number", "HIP 72360"},
        {"Geneva Identification System", "GEN# +1.00130666"},
        {"Smithsonian Astrophysical Observation", "SAO 45218"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.94399807),
        dec: Angle.Degrees(+49.55981168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37714"},
        {"Smithsonian Astrophysical Observation", "SAO 41966"},
    },
    visualMagnitude: 9.63,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.04718211),
        dec: Angle.Degrees(+49.55998426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12606"},
        {"Hipparcos Number", "HIP 9702"},
        {"Smithsonian Astrophysical Observation", "SAO 37743"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.20121359),
        dec: Angle.Degrees(+49.56006021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16485"},
        {"Hipparcos Number", "HIP 12453"},
        {"Smithsonian Astrophysical Observation", "SAO 38207"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.08721311),
        dec: Angle.Degrees(+49.56027687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92582"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.98342131),
        dec: Angle.Degrees(+49.56044331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119615"},
        {"Hipparcos Number", "HIP 66943"},
        {"Smithsonian Astrophysical Observation", "SAO 44724"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.80403797),
        dec: Angle.Degrees(+49.56228536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9508"},
        {"Hipparcos Number", "HIP 7335"},
        {"Smithsonian Astrophysical Observation", "SAO 37321"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.61622278),
        dec: Angle.Degrees(+49.56411420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70968"},
        {"Hipparcos Number", "HIP 41427"},
        {"Smithsonian Astrophysical Observation", "SAO 42358"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.74481402),
        dec: Angle.Degrees(+49.56539157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216065"},
        {"Hipparcos Number", "HIP 112674"},
        {"Smithsonian Astrophysical Observation", "SAO 52390"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.26225764),
        dec: Angle.Degrees(+49.56634650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15241"},
        {"Hipparcos Number", "HIP 11550"},
        {"Smithsonian Astrophysical Observation", "SAO 38054"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.20493632),
        dec: Angle.Degrees(+49.56713440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19893"},
        {"Hipparcos Number", "HIP 15040"},
        {"Geneva Identification System", "GEN# +5.20200212"},
        {"Smithsonian Astrophysical Observation", "SAO 38655"},
        {"Wilson Evans Batten Catalogue", "WEB 2896"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.45963094),
        dec: Angle.Degrees(+49.56893880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181597"},
        {"Hipparcos Number", "HIP 94890"},
        {"Geneva Identification System", "GEN# +1.00181597"},
        {"Smithsonian Astrophysical Observation", "SAO 48315"},
        {"Wilson Evans Batten Catalogue", "WEB 16564"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.65771814),
        dec: Angle.Degrees(+49.56934700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3638"},
        {"Hipparcos Number", "HIP 3108"},
        {"Geneva Identification System", "GEN# +1.00003638"},
        {"Smithsonian Astrophysical Observation", "SAO 36555"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.89419538),
        dec: Angle.Degrees(+49.57332761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29934"},
        {"Hipparcos Number", "HIP 22104"},
        {"Smithsonian Astrophysical Observation", "SAO 39723"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.36198209),
        dec: Angle.Degrees(+49.57476627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233951"},
        {"Hipparcos Number", "HIP 61131"},
        {"Smithsonian Astrophysical Observation", "SAO 44215"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.90952655),
        dec: Angle.Degrees(+49.57536159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89110"},
        {"Hipparcos Number", "HIP 50440"},
        {"Geneva Identification System", "GEN# +1.00089110"},
        {"Smithsonian Astrophysical Observation", "SAO 43273"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.47760301),
        dec: Angle.Degrees(+49.57583931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64556"},
        {"Hipparcos Number", "HIP 38830"},
        {"Geneva Identification System", "GEN# +1.00064556"},
        {"Smithsonian Astrophysical Observation", "SAO 42081"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.19666264),
        dec: Angle.Degrees(+49.58157321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215953"},
        {"Hipparcos Number", "HIP 112585"},
        {"Smithsonian Astrophysical Observation", "SAO 52377"},
        {"Wilson Evans Batten Catalogue", "WEB 20072"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.03337704),
        dec: Angle.Degrees(+49.58271936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104259"},
        {"Hipparcos Number", "HIP 58555"},
        {"Fundamental Katalog 5th Edition", "FK5 5055"},
        {"Geneva Identification System", "GEN# +1.00104259"},
        {"Smithsonian Astrophysical Observation", "SAO 43993"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.11067153),
        dec: Angle.Degrees(+49.58486433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127824"},
        {"Hipparcos Number", "HIP 71056"},
        {"Geneva Identification System", "GEN# +1.00127824"},
        {"Smithsonian Astrophysical Observation", "SAO 45094"},
        {"Wilson Evans Batten Catalogue", "WEB 12289"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.96551241),
        dec: Angle.Degrees(+49.58568430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113835"},
        {"Smithsonian Astrophysical Observation", "SAO 52634"},
    },
    visualMagnitude: 9.69,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.78471683),
        dec: Angle.Degrees(+49.58603557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147951"},
        {"Hipparcos Number", "HIP 80215"},
        {"Smithsonian Astrophysical Observation", "SAO 46055"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.62159305),
        dec: Angle.Degrees(+49.58782408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30389"},
        {"Hipparcos Number", "HIP 22433"},
        {"Smithsonian Astrophysical Observation", "SAO 39780"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.42049583),
        dec: Angle.Degrees(+49.58828170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233733"},
        {"Hipparcos Number", "HIP 50909"},
        {"Smithsonian Astrophysical Observation", "SAO 43316"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.94411942),
        dec: Angle.Degrees(+49.59114750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154323"},
        {"Hipparcos Number", "HIP 83360"},
        {"Smithsonian Astrophysical Observation", "SAO 46450"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.56654662),
        dec: Angle.Degrees(+49.59399388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43216"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.06277349),
        dec: Angle.Degrees(+49.59569700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13354"},
        {"Hipparcos Number", "HIP 10257"},
        {"Geneva Identification System", "GEN# +1.00013354"},
        {"Smithsonian Astrophysical Observation", "SAO 37848"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.98091437),
        dec: Angle.Degrees(+49.59664245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17384"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.84814533),
        dec: Angle.Degrees(+49.59857989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21238"},
        {"Hipparcos Number", "HIP 16118"},
        {"Smithsonian Astrophysical Observation", "SAO 38845"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.91229270),
        dec: Angle.Degrees(+49.59998087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206731"},
        {"Hipparcos Number", "HIP 107186"},
        {"Geneva Identification System", "GEN# +1.00206731"},
        {"Smithsonian Astrophysical Observation", "SAO 51217"},
        {"Wilson Evans Batten Catalogue", "WEB 19361"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.66170056),
        dec: Angle.Degrees(+49.60026484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57984"},
    },
    visualMagnitude: 11.24,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.40551229),
        dec: Angle.Degrees(+49.60047876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233620"},
        {"Hipparcos Number", "HIP 45810"},
        {"Smithsonian Astrophysical Observation", "SAO 42810"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.11763458),
        dec: Angle.Degrees(+49.60792945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233799"},
        {"Hipparcos Number", "HIP 53896"},
        {"Geneva Identification System", "GEN# +1.00233799"},
        {"Smithsonian Astrophysical Observation", "SAO 43578"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.42031540),
        dec: Angle.Degrees(+49.60944873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28802"},
        {"Hipparcos Number", "HIP 21345"},
        {"Smithsonian Astrophysical Observation", "SAO 39622"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.70648383),
        dec: Angle.Degrees(+49.61103295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77770"},
        {"Hipparcos Number", "HIP 44685"},
        {"Geneva Identification System", "GEN# +1.00077770"},
        {"Smithsonian Astrophysical Observation", "SAO 42690"},
        {"Wilson Evans Batten Catalogue", "WEB 8547"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.59387557),
        dec: Angle.Degrees(+49.61139476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19373"},
        {"Hipparcos Number", "HIP 14632"},
        {"Cincinnati Publication", "Ci 20 208"},
        {"Fundamental Katalog 5th Edition", "FK5 112"},
        {"Geneva Identification System", "GEN# +5.20200044"},
        {"Smithsonian Astrophysical Observation", "SAO 38597"},
        {"Wilson Evans Batten Catalogue", "WEB 2842"},
    },
    visualMagnitude: 4.05,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.26201363),
        dec: Angle.Degrees(+49.61350009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1262.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105277"},
        {"Geneva Identification System", "GEN# +0.04903501"},
        {"Smithsonian Astrophysical Observation", "SAO 50712"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.85819971),
        dec: Angle.Degrees(+49.61462003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85238"},
        {"Hipparcos Number", "HIP 48391"},
        {"Fundamental Katalog 5th Edition", "FK5 4877"},
        {"Geneva Identification System", "GEN# +1.00085238"},
        {"Smithsonian Astrophysical Observation", "SAO 43073"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.98087679),
        dec: Angle.Degrees(+49.62217052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 497",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 59 AB"},
        {"Henry Draper", "HD 98"},
        {"Hipparcos Number", "HIP 497"},
        {"Smithsonian Astrophysical Observation", "SAO 36054"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.48768965),
        dec: Angle.Degrees(+49.62234797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26210"},
        {"Hipparcos Number", "HIP 19546"},
        {"Geneva Identification System", "GEN# +1.00026210"},
        {"Smithsonian Astrophysical Observation", "SAO 39355"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.79022074),
        dec: Angle.Degrees(+49.62341915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113112"},
        {"Hipparcos Number", "HIP 63504"},
        {"Smithsonian Astrophysical Observation", "SAO 44425"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.18420777),
        dec: Angle.Degrees(+49.62363807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7055"},
        {"Hipparcos Number", "HIP 5587"},
        {"Smithsonian Astrophysical Observation", "SAO 37004"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.91559323),
        dec: Angle.Degrees(+49.62389361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6285"},
        {"Hipparcos Number", "HIP 5035"},
        {"Smithsonian Astrophysical Observation", "SAO 36902"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.12286794),
        dec: Angle.Degrees(+49.62496295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12822"},
        {"Hipparcos Number", "HIP 9876"},
        {"Smithsonian Astrophysical Observation", "SAO 37776"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.76637317),
        dec: Angle.Degrees(+49.62520446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63629"},
        {"Hipparcos Number", "HIP 38419"},
        {"Geneva Identification System", "GEN# +1.00063629"},
        {"Smithsonian Astrophysical Observation", "SAO 42036"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.05898034),
        dec: Angle.Degrees(+49.62690227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101057"},
        {"Hipparcos Number", "HIP 56749"},
        {"Smithsonian Astrophysical Observation", "SAO 43835"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.52172286),
        dec: Angle.Degrees(+49.62748780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132254"},
        {"Hipparcos Number", "HIP 73100"},
        {"Fundamental Katalog 5th Edition", "FK5 3179"},
        {"Geneva Identification System", "GEN# +1.00132254"},
        {"Smithsonian Astrophysical Observation", "SAO 45288"},
        {"Wilson Evans Batten Catalogue", "WEB 12531"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.09558479),
        dec: Angle.Degrees(+49.62899937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200559"},
        {"Hipparcos Number", "HIP 103829"},
        {"Smithsonian Astrophysical Observation", "SAO 50384"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.60137540),
        dec: Angle.Degrees(+49.63287673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177828"},
        {"Hipparcos Number", "HIP 93610"},
        {"Smithsonian Astrophysical Observation", "SAO 48047"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.94474701),
        dec: Angle.Degrees(+49.63292764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108660"},
        {"Hipparcos Number", "HIP 60883"},
        {"Geneva Identification System", "GEN# +1.00108660"},
        {"Smithsonian Astrophysical Observation", "SAO 44196"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.16304112),
        dec: Angle.Degrees(+49.63545848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74161"},
    },
    visualMagnitude: 11.68,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.29111703),
        dec: Angle.Degrees(+49.63993562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103788"},
        {"Smithsonian Astrophysical Observation", "SAO 50374"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.47572803),
        dec: Angle.Degrees(+49.64218350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11883"},
        {"Hipparcos Number", "HIP 9169"},
        {"Smithsonian Astrophysical Observation", "SAO 37650"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.51353034),
        dec: Angle.Degrees(+49.64282638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218674"},
        {"Hipparcos Number", "HIP 114329"},
        {"Geneva Identification System", "GEN# +1.00218674"},
        {"Smithsonian Astrophysical Observation", "SAO 52742"},
        {"Wilson Evans Batten Catalogue", "WEB 20298"},
    },
    visualMagnitude: 6.75,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.31976288),
        dec: Angle.Degrees(+49.65061333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189313"},
        {"Hipparcos Number", "HIP 98177"},
        {"Smithsonian Astrophysical Observation", "SAO 49018"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.27825511),
        dec: Angle.Degrees(+49.65102539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234105"},
        {"Hipparcos Number", "HIP 68874"},
        {"Smithsonian Astrophysical Observation", "SAO 44886"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.54988511),
        dec: Angle.Degrees(+49.65125534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4477"},
        {"Hipparcos Number", "HIP 3700"},
        {"Smithsonian Astrophysical Observation", "SAO 36661"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.86498668),
        dec: Angle.Degrees(+49.65127589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56416"},
        {"Hipparcos Number", "HIP 35490"},
        {"Geneva Identification System", "GEN# +1.00056416"},
        {"Smithsonian Astrophysical Observation", "SAO 41690"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.87121908),
        dec: Angle.Degrees(+49.65429085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198877"},
        {"Hipparcos Number", "HIP 102956"},
        {"Smithsonian Astrophysical Observation", "SAO 50146"},
        {"Wilson Evans Batten Catalogue", "WEB 18685"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.89227579),
        dec: Angle.Degrees(+49.65443742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137268"},
        {"Hipparcos Number", "HIP 75297"},
        {"Smithsonian Astrophysical Observation", "SAO 45515"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.76981144),
        dec: Angle.Degrees(+49.65518594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5083"},
        {"Hipparcos Number", "HIP 4174"},
        {"Smithsonian Astrophysical Observation", "SAO 36745"},
        {"Wilson Evans Batten Catalogue", "WEB 750"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.33071135),
        dec: Angle.Degrees(+49.65565213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10546"},
        {"Hipparcos Number", "HIP 8093"},
        {"Celescope Catalog", "CEL 162"},
        {"Geneva Identification System", "GEN# +1.00010546"},
        {"Smithsonian Astrophysical Observation", "SAO 37466"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.97113141),
        dec: Angle.Degrees(+49.65644871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57789"},
        {"Hipparcos Number", "HIP 36012"},
        {"Smithsonian Astrophysical Observation", "SAO 41751"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.32433603),
        dec: Angle.Degrees(+49.65691140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2137"},
        {"Hipparcos Number", "HIP 2034"},
        {"Smithsonian Astrophysical Observation", "SAO 36358"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.45698847),
        dec: Angle.Degrees(+49.65708123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49179",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7612 AB"},
        {"Hipparcos Number", "HIP 49179"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.56335621),
        dec: Angle.Degrees(+49.65931641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43456"},
        {"Hipparcos Number", "HIP 30005"},
        {"Smithsonian Astrophysical Observation", "SAO 41013"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.73370202),
        dec: Angle.Degrees(+49.66051214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113698"},
        {"Hipparcos Number", "HIP 63815"},
        {"Smithsonian Astrophysical Observation", "SAO 44454"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.19092473),
        dec: Angle.Degrees(+49.66294886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209612"},
        {"Hipparcos Number", "HIP 108891"},
        {"Celescope Catalog", "CEL 5426"},
        {"Geneva Identification System", "GEN# +1.00209612"},
        {"Smithsonian Astrophysical Observation", "SAO 51603"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.86516169),
        dec: Angle.Degrees(+49.66487526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205101"},
        {"Hipparcos Number", "HIP 106275"},
        {"Smithsonian Astrophysical Observation", "SAO 50981"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.88489981),
        dec: Angle.Degrees(+49.67030832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233827"},
        {"Hipparcos Number", "HIP 55493"},
        {"Smithsonian Astrophysical Observation", "SAO 43711"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.46691123),
        dec: Angle.Degrees(+49.67155650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133984"},
        {"Hipparcos Number", "HIP 73839"},
        {"Smithsonian Astrophysical Observation", "SAO 45371"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.35328823),
        dec: Angle.Degrees(+49.67174741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58855"},
        {"Hipparcos Number", "HIP 36439"},
        {"Geneva Identification System", "GEN# +1.00058855"},
        {"Smithsonian Astrophysical Observation", "SAO 41808"},
        {"Wilson Evans Batten Catalogue", "WEB 7251"},
    },
    visualMagnitude: 5.35,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.48273588),
        dec: Angle.Degrees(+49.67266207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63409"},
        {"Hipparcos Number", "HIP 38334"},
        {"Smithsonian Astrophysical Observation", "SAO 42031"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.78356631),
        dec: Angle.Degrees(+49.67378669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207647"},
        {"Hipparcos Number", "HIP 107704"},
        {"Smithsonian Astrophysical Observation", "SAO 51332"},
        {"Wilson Evans Batten Catalogue", "WEB 19426"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.26802929),
        dec: Angle.Degrees(+49.67710885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90929"},
        {"Hipparcos Number", "HIP 51483"},
        {"Smithsonian Astrophysical Observation", "SAO 43366"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.72956698),
        dec: Angle.Degrees(+49.67989397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115735"},
        {"Hipparcos Number", "HIP 64906"},
        {"Fundamental Katalog 5th Edition", "FK5 3063"},
        {"Geneva Identification System", "GEN# +1.00115735"},
        {"Renson", "Renson 33470"},
        {"Smithsonian Astrophysical Observation", "SAO 44556"},
        {"Wilson Evans Batten Catalogue", "WEB 11472"},
    },
    visualMagnitude: 5.14,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.56058516),
        dec: Angle.Degrees(+49.68201519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105058"},
        {"Hipparcos Number", "HIP 58992"},
        {"Geneva Identification System", "GEN# +1.00105058"},
        {"Smithsonian Astrophysical Observation", "SAO 44027"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.43068028),
        dec: Angle.Degrees(+49.68221795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130106"},
        {"Hipparcos Number", "HIP 72077"},
        {"Smithsonian Astrophysical Observation", "SAO 45198"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.15788683),
        dec: Angle.Degrees(+49.68243529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206365"},
        {"Hipparcos Number", "HIP 107000"},
        {"Celescope Catalog", "CEL 5365"},
        {"Geneva Identification System", "GEN# +1.00206365"},
        {"Smithsonian Astrophysical Observation", "SAO 51168"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.04811345),
        dec: Angle.Degrees(+49.68299818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71226"},
        {"Hipparcos Number", "HIP 41549"},
        {"Geneva Identification System", "GEN# +1.00071226"},
        {"Smithsonian Astrophysical Observation", "SAO 42378"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.08636436),
        dec: Angle.Degrees(+49.68742901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24105"},
        {"Geneva Identification System", "GEN# +0.04901316"},
        {"Smithsonian Astrophysical Observation", "SAO 40075"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.66762222),
        dec: Angle.Degrees(+49.68761485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115518"},
        {"Hipparcos Number", "HIP 64805"},
        {"Smithsonian Astrophysical Observation", "SAO 44546"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.22782678),
        dec: Angle.Degrees(+49.68789717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156753"},
        {"Hipparcos Number", "HIP 84530"},
        {"Geneva Identification System", "GEN# +1.00156753"},
        {"Smithsonian Astrophysical Observation", "SAO 46605"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.20219765),
        dec: Angle.Degrees(+49.69120416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81383"},
        {"Hipparcos Number", "HIP 46344"},
        {"Smithsonian Astrophysical Observation", "SAO 42861"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.73202967),
        dec: Angle.Degrees(+49.69248973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186355"},
        {"Hipparcos Number", "HIP 96878"},
        {"Geneva Identification System", "GEN# +1.00186355"},
        {"Smithsonian Astrophysical Observation", "SAO 48736"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.39733012),
        dec: Angle.Degrees(+49.69529552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234092"},
        {"Hipparcos Number", "HIP 68190"},
        {"Smithsonian Astrophysical Observation", "SAO 44816"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.41102005),
        dec: Angle.Degrees(+49.69549078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102971"},
        {"Smithsonian Astrophysical Observation", "SAO 50148"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.93564009),
        dec: Angle.Degrees(+49.69720894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139307"},
        {"Hipparcos Number", "HIP 76306"},
        {"Geneva Identification System", "GEN# +1.00139307"},
        {"Smithsonian Astrophysical Observation", "SAO 45625"},
        {"Wilson Evans Batten Catalogue", "WEB 12956"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.81174586),
        dec: Angle.Degrees(+49.69838295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188057"},
        {"Hipparcos Number", "HIP 97665"},
        {"Geneva Identification System", "GEN# +1.00188057"},
        {"Smithsonian Astrophysical Observation", "SAO 48902"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.73035207),
        dec: Angle.Degrees(+49.70026944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13785"},
        {"Hipparcos Number", "HIP 10544"},
        {"Geneva Identification System", "GEN# +1.00013785"},
        {"Smithsonian Astrophysical Observation", "SAO 37902"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.94903836),
        dec: Angle.Degrees(+49.70106151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111209"},
        {"Cincinnati Publication", "Ci 20 1368"},
        {"Geneva Identification System", "GEN# +0.04803755"},
        {"Wilson Evans Batten Catalogue", "WEB 19900"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.94792915),
        dec: Angle.Degrees(+49.70341481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 358.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21600"},
        {"Hipparcos Number", "HIP 16403"},
        {"Geneva Identification System", "GEN# +5.20200921"},
        {"Smithsonian Astrophysical Observation", "SAO 38900"},
        {"Wilson Evans Batten Catalogue", "WEB 3133"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.81108860),
        dec: Angle.Degrees(+49.70630143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83956"},
        {"Smithsonian Astrophysical Observation", "SAO 46528"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.42784976),
        dec: Angle.Degrees(+49.70888570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88754",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11090 AB"},
        {"Henry Draper", "HD 166228"},
        {"Hipparcos Number", "HIP 88754"},
        {"Smithsonian Astrophysical Observation", "SAO 47233"},
        {"Wilson Evans Batten Catalogue", "WEB 15035"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.77622643),
        dec: Angle.Degrees(+49.71039279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7452"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.00494785),
        dec: Angle.Degrees(+49.71223745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70563"},
        {"Hipparcos Number", "HIP 41235"},
        {"Smithsonian Astrophysical Observation", "SAO 42341"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.21861348),
        dec: Angle.Degrees(+49.71319811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4591"},
        {"Hipparcos Number", "HIP 3771"},
        {"Smithsonian Astrophysical Observation", "SAO 36676"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.10339714),
        dec: Angle.Degrees(+49.71629136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173512"},
        {"Hipparcos Number", "HIP 91815"},
        {"Smithsonian Astrophysical Observation", "SAO 47733"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.80722730),
        dec: Angle.Degrees(+49.71649553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222408"},
        {"Hipparcos Number", "HIP 116779"},
        {"Smithsonian Astrophysical Observation", "SAO 53257"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.00535163),
        dec: Angle.Degrees(+49.71762514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18981"},
        {"Hipparcos Number", "HIP 14349"},
        {"Geneva Identification System", "GEN# +1.00018981"},
        {"Smithsonian Astrophysical Observation", "SAO 38553"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.26337296),
        dec: Angle.Degrees(+49.71870417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67085"},
        {"Hipparcos Number", "HIP 39875"},
        {"Smithsonian Astrophysical Observation", "SAO 42188"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.18095226),
        dec: Angle.Degrees(+49.71928170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220059"},
        {"Hipparcos Number", "HIP 115226"},
        {"Smithsonian Astrophysical Observation", "SAO 52923"},
    },
    visualMagnitude: 9.02,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.08206292),
        dec: Angle.Degrees(+49.71991966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159318"},
        {"Hipparcos Number", "HIP 85769"},
        {"Smithsonian Astrophysical Observation", "SAO 46777"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.88777316),
        dec: Angle.Degrees(+49.72322618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 883"},
        {"Hipparcos Number", "HIP 1075"},
        {"Geneva Identification System", "GEN# +1.00000883"},
        {"Smithsonian Astrophysical Observation", "SAO 36168"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.33541865),
        dec: Angle.Degrees(+49.72339535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233967"},
        {"Hipparcos Number", "HIP 61909"},
        {"Smithsonian Astrophysical Observation", "SAO 44284"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.31418166),
        dec: Angle.Degrees(+49.72403956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169221"},
        {"Hipparcos Number", "HIP 89943"},
        {"Geneva Identification System", "GEN# +1.00169221"},
        {"Smithsonian Astrophysical Observation", "SAO 47411"},
        {"Wilson Evans Batten Catalogue", "WEB 15362"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.27977872),
        dec: Angle.Degrees(+49.72540851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99787"},
        {"Smithsonian Astrophysical Observation", "SAO 49362"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.69440673),
        dec: Angle.Degrees(+49.72557522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30876",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5084 AB"},
        {"Henry Draper", "HD 45232"},
        {"Hipparcos Number", "HIP 30876"},
        {"Smithsonian Astrophysical Observation", "SAO 41120"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.22378900),
        dec: Angle.Degrees(+49.72594070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6224"},
        {"Hipparcos Number", "HIP 4987"},
        {"Smithsonian Astrophysical Observation", "SAO 36892"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.98528183),
        dec: Angle.Degrees(+49.73000346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89299"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.32181299),
        dec: Angle.Degrees(+49.73125930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23609"},
        {"Smithsonian Astrophysical Observation", "SAO 39991"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.15040174),
        dec: Angle.Degrees(+49.73220360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112292"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.17053548),
        dec: Angle.Degrees(+49.73258170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216946"},
        {"Hipparcos Number", "HIP 113288"},
        {"Geneva Identification System", "GEN# +1.00216946"},
        {"Smithsonian Astrophysical Observation", "SAO 52516"},
        {"Wilson Evans Batten Catalogue", "WEB 20156"},
    },
    visualMagnitude: 4.99,
    bvColour: 1.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.10832784),
        dec: Angle.Degrees(+49.73355094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197512"},
        {"Hipparcos Number", "HIP 102171"},
        {"Geneva Identification System", "GEN# +1.00197512"},
        {"Smithsonian Astrophysical Observation", "SAO 49959"},
        {"Wilson Evans Batten Catalogue", "WEB 18487"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.54188271),
        dec: Angle.Degrees(+49.73475076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2808"},
        {"Smithsonian Astrophysical Observation", "SAO 36495"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.93424127),
        dec: Angle.Degrees(+49.73626236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77006"},
        {"Hipparcos Number", "HIP 44324"},
        {"Geneva Identification System", "GEN# +1.00077006"},
        {"Smithsonian Astrophysical Observation", "SAO 42644"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.40464921),
        dec: Angle.Degrees(+49.73713164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233437"},
        {"Hipparcos Number", "HIP 37451"},
        {"Smithsonian Astrophysical Observation", "SAO 41933"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.31767828),
        dec: Angle.Degrees(+49.73944965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36737"},
    },
    visualMagnitude: 11.35,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.34797874),
        dec: Angle.Degrees(+49.73981411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -466.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83563"},
        {"Smithsonian Astrophysical Observation", "SAO 46473"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.16539804),
        dec: Angle.Degrees(+49.74068096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158553"},
        {"Hipparcos Number", "HIP 85430"},
        {"Smithsonian Astrophysical Observation", "SAO 46732"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.86196988),
        dec: Angle.Degrees(+49.74490976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21085"},
        {"Hipparcos Number", "HIP 16001"},
        {"Smithsonian Astrophysical Observation", "SAO 38818"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.51862874),
        dec: Angle.Degrees(+49.74558367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19581"},
        {"Smithsonian Astrophysical Observation", "SAO 39367"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.94379709),
        dec: Angle.Degrees(+49.74604074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -274.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155860"},
        {"Hipparcos Number", "HIP 84108"},
        {"Geneva Identification System", "GEN# +1.00155860"},
        {"Smithsonian Astrophysical Observation", "SAO 46561"},
        {"Wilson Evans Batten Catalogue", "WEB 14203"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.91773133),
        dec: Angle.Degrees(+49.74631151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100102"},
        {"Smithsonian Astrophysical Observation", "SAO 49454"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.61180289),
        dec: Angle.Degrees(+49.74808690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32184"},
        {"Smithsonian Astrophysical Observation", "SAO 41284"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.79091598),
        dec: Angle.Degrees(+49.74819293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135821"},
        {"Hipparcos Number", "HIP 74656"},
        {"Smithsonian Astrophysical Observation", "SAO 45449"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.82659767),
        dec: Angle.Degrees(+49.75088925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24342"},
        {"Hipparcos Number", "HIP 18282"},
        {"Smithsonian Astrophysical Observation", "SAO 39182"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.64960212),
        dec: Angle.Degrees(+49.75206876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6058",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1039 AB"},
        {"Henry Draper", "HD 7695"},
        {"Hipparcos Number", "HIP 6058"},
        {"Smithsonian Astrophysical Observation", "SAO 37085"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.43999871),
        dec: Angle.Degrees(+49.75385804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83885",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10372 AB"},
        {"Hipparcos Number", "HIP 83885"},
        {"Smithsonian Astrophysical Observation", "SAO 46516"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.17438907),
        dec: Angle.Degrees(+49.75553115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62853"},
        {"Hipparcos Number", "HIP 38090"},
        {"Smithsonian Astrophysical Observation", "SAO 42007"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.08535457),
        dec: Angle.Degrees(+49.75689468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115627"},
        {"Hipparcos Number", "HIP 64850"},
        {"Smithsonian Astrophysical Observation", "SAO 28706"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.39791337),
        dec: Angle.Degrees(+49.76009735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85237"},
        {"Hipparcos Number", "HIP 48393"},
        {"Smithsonian Astrophysical Observation", "SAO 43074"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.99043898),
        dec: Angle.Degrees(+49.76222379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30960"},
        {"Smithsonian Astrophysical Observation", "SAO 41129"},
    },
    visualMagnitude: 9.26,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.48223278),
        dec: Angle.Degrees(+49.76376104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1574"},
        {"Hipparcos Number", "HIP 1618"},
        {"Smithsonian Astrophysical Observation", "SAO 36274"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.05779928),
        dec: Angle.Degrees(+49.76639883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92467"},
        {"Smithsonian Astrophysical Observation", "SAO 47852"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.66583562),
        dec: Angle.Degrees(+49.76754036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180475"},
        {"Hipparcos Number", "HIP 94518"},
        {"Smithsonian Astrophysical Observation", "SAO 48229"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.55245183),
        dec: Angle.Degrees(+49.76758039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233903"},
        {"Hipparcos Number", "HIP 59305"},
        {"Smithsonian Astrophysical Observation", "SAO 28267"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.49870006),
        dec: Angle.Degrees(+49.76803083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141304"},
        {"Hipparcos Number", "HIP 77238"},
        {"Smithsonian Astrophysical Observation", "SAO 45721"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.56292987),
        dec: Angle.Degrees(+49.76807596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88629"},
        {"Hipparcos Number", "HIP 50165"},
        {"Smithsonian Astrophysical Observation", "SAO 27574"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.59416937),
        dec: Angle.Degrees(+49.76856175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20391"},
        {"Hipparcos Number", "HIP 15420"},
        {"Geneva Identification System", "GEN# +5.20200386"},
        {"Smithsonian Astrophysical Observation", "SAO 38711"},
        {"Wilson Evans Batten Catalogue", "WEB 2963"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.68645340),
        dec: Angle.Degrees(+49.77001446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224968"},
        {"Hipparcos Number", "HIP 175"},
        {"Geneva Identification System", "GEN# +1.00224968"},
        {"Smithsonian Astrophysical Observation", "SAO 53590"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.55243583),
        dec: Angle.Degrees(+49.77113897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209637"},
        {"Hipparcos Number", "HIP 108914"},
        {"Smithsonian Astrophysical Observation", "SAO 51606"},
        {"Wilson Evans Batten Catalogue", "WEB 19588"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.93007238),
        dec: Angle.Degrees(+49.77160636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68721"},
        {"Hipparcos Number", "HIP 40482"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.99282082),
        dec: Angle.Degrees(+49.77206405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196282"},
        {"Hipparcos Number", "HIP 101514"},
        {"Smithsonian Astrophysical Observation", "SAO 49821"},
        {"Wilson Evans Batten Catalogue", "WEB 18344"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.56880120),
        dec: Angle.Degrees(+49.77314697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135401"},
        {"Hipparcos Number", "HIP 74465"},
        {"Smithsonian Astrophysical Observation", "SAO 45438"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.25149958),
        dec: Angle.Degrees(+49.77521734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145567"},
        {"Hipparcos Number", "HIP 79150"},
        {"Smithsonian Astrophysical Observation", "SAO 45919"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.32141348),
        dec: Angle.Degrees(+49.77798710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160883"},
        {"Hipparcos Number", "HIP 86446"},
        {"Geneva Identification System", "GEN# +1.00160883"},
        {"Smithsonian Astrophysical Observation", "SAO 46879"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.94983861),
        dec: Angle.Degrees(+49.77984276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195608"},
        {"Hipparcos Number", "HIP 101164"},
        {"Smithsonian Astrophysical Observation", "SAO 49722"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.58318816),
        dec: Angle.Degrees(+49.78034066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78291"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.78730446),
        dec: Angle.Degrees(+49.78080558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56962"},
        {"Hipparcos Number", "HIP 35686"},
        {"Smithsonian Astrophysical Observation", "SAO 41710"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.44904948),
        dec: Angle.Degrees(+49.78180292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186743"},
        {"Hipparcos Number", "HIP 97094"},
        {"Smithsonian Astrophysical Observation", "SAO 48778"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.98594901),
        dec: Angle.Degrees(+49.78334392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18061",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2808 A"},
        {"Henry Draper", "HD 23984"},
        {"Hipparcos Number", "HIP 18061"},
        {"Smithsonian Astrophysical Observation", "SAO 39152"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.90636547),
        dec: Angle.Degrees(+49.78484233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64124"},
        {"Hipparcos Number", "HIP 38642"},
        {"Smithsonian Astrophysical Observation", "SAO 42057"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.69135520),
        dec: Angle.Degrees(+49.78492652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25821",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25821"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.70679311),
        dec: Angle.Degrees(+49.78694270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233591"},
        {"Hipparcos Number", "HIP 44327"},
        {"Smithsonian Astrophysical Observation", "SAO 42645"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.41189788),
        dec: Angle.Degrees(+49.78848771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233367"},
        {"Hipparcos Number", "HIP 35122"},
        {"Smithsonian Astrophysical Observation", "SAO 41640"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.91738620),
        dec: Angle.Degrees(+49.78907481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57534"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.87620242),
        dec: Angle.Degrees(+49.78985844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54590"},
        {"Hipparcos Number", "HIP 34777"},
        {"Smithsonian Astrophysical Observation", "SAO 41612"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.98758517),
        dec: Angle.Degrees(+49.78989521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201358"},
        {"Hipparcos Number", "HIP 104258"},
        {"Geneva Identification System", "GEN# +1.00201358"},
        {"Smithsonian Astrophysical Observation", "SAO 50475"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.82632941),
        dec: Angle.Degrees(+49.79041625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223268"},
        {"Hipparcos Number", "HIP 117382"},
        {"Smithsonian Astrophysical Observation", "SAO 53381"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.00113009),
        dec: Angle.Degrees(+49.79053632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147622"},
        {"Hipparcos Number", "HIP 80084"},
        {"Smithsonian Astrophysical Observation", "SAO 46040"},
        {"Wilson Evans Batten Catalogue", "WEB 13558"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.17362974),
        dec: Angle.Degrees(+49.79189524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18125"},
        {"Hipparcos Number", "HIP 13710"},
        {"Geneva Identification System", "GEN# +1.00018125"},
        {"Smithsonian Astrophysical Observation", "SAO 38451"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.12917267),
        dec: Angle.Degrees(+49.79273830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109852"},
        {"Geneva Identification System", "GEN# +2.72430482"},
        {"Smithsonian Astrophysical Observation", "SAO 51805"},
        {"New General Catalogue", "NGC 7243 482"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.73147043),
        dec: Angle.Degrees(+49.79355991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11273"},
        {"Geneva Identification System", "GEN# +6.20030005"},
        {"Wilson Evans Batten Catalogue", "WEB 2358"},
    },
    visualMagnitude: 11.31,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.30026372),
        dec: Angle.Degrees(+49.79405218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163528"},
        {"Hipparcos Number", "HIP 87629"},
        {"Smithsonian Astrophysical Observation", "SAO 47050"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.50302968),
        dec: Angle.Degrees(+49.79506807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204699"},
        {"Hipparcos Number", "HIP 106049"},
        {"Geneva Identification System", "GEN# +1.00204699"},
        {"Smithsonian Astrophysical Observation", "SAO 50922"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.20215740),
        dec: Angle.Degrees(+49.79510516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206121"},
        {"Hipparcos Number", "HIP 106848"},
        {"Geneva Identification System", "GEN# +1.00206121"},
        {"Smithsonian Astrophysical Observation", "SAO 51134"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.61991308),
        dec: Angle.Degrees(+49.79530522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15659 A"},
        {"Henry Draper", "HD 210289"},
        {"Hipparcos Number", "HIP 109272"},
        {"Smithsonian Astrophysical Observation", "SAO 51678"},
        {"Wilson Evans Batten Catalogue", "WEB 19638"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.06785015),
        dec: Angle.Degrees(+49.79700084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36851"},
        {"Hipparcos Number", "HIP 26399"},
        {"Smithsonian Astrophysical Observation", "SAO 40479"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.29562075),
        dec: Angle.Degrees(+49.79854959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233916"},
        {"Hipparcos Number", "HIP 59802"},
        {"Smithsonian Astrophysical Observation", "SAO 28319"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.95094092),
        dec: Angle.Degrees(+49.79882926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11318"},
        {"Hipparcos Number", "HIP 8742"},
        {"Geneva Identification System", "GEN# +1.00011318"},
        {"Smithsonian Astrophysical Observation", "SAO 37574"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.12076554),
        dec: Angle.Degrees(+49.79946941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176070"},
        {"Hipparcos Number", "HIP 92925"},
        {"Smithsonian Astrophysical Observation", "SAO 47932"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.98696878),
        dec: Angle.Degrees(+49.80040564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17833"},
        {"Hipparcos Number", "HIP 13477"},
        {"Smithsonian Astrophysical Observation", "SAO 38419"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.39574860),
        dec: Angle.Degrees(+49.80046622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92811"},
        {"Hipparcos Number", "HIP 52495"},
        {"Fundamental Katalog 5th Edition", "FK5 4954"},
        {"Geneva Identification System", "GEN# +1.00092811"},
        {"Smithsonian Astrophysical Observation", "SAO 27751"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.98521716),
        dec: Angle.Degrees(+49.80089340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87614"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.47143825),
        dec: Angle.Degrees(+49.80295957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 167.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233661"},
        {"Hipparcos Number", "HIP 47366"},
        {"Smithsonian Astrophysical Observation", "SAO 27326"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.76199155),
        dec: Angle.Degrees(+49.80397268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234227"},
        {"Hipparcos Number", "HIP 75531"},
        {"Smithsonian Astrophysical Observation", "SAO 45539"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.45235166),
        dec: Angle.Degrees(+49.80457169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117699"},
        {"Fundamental Katalog 5th Edition", "FK5 6115"},
        {"Smithsonian Astrophysical Observation", "SAO 53436"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.04640574),
        dec: Angle.Degrees(+49.80552351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56730",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8244 AB"},
        {"Henry Draper", "HD 101024"},
        {"Hipparcos Number", "HIP 56730"},
        {"Smithsonian Astrophysical Observation", "SAO 28080"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.46648244),
        dec: Angle.Degrees(+49.80928807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41857"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.01252199),
        dec: Angle.Degrees(+49.81069110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13034"},
        {"Smithsonian Astrophysical Observation", "SAO 38332"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.87430873),
        dec: Angle.Degrees(+49.81101130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18989",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2953 AB"},
        {"Henry Draper", "HD 25363"},
        {"Hipparcos Number", "HIP 18989"},
        {"Geneva Identification System", "GEN# +1.00025363J"},
        {"Smithsonian Astrophysical Observation", "SAO 39284"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.03491176),
        dec: Angle.Degrees(+49.81460500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100199",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100199"},
        {"Smithsonian Astrophysical Observation", "SAO 49474"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.85361662),
        dec: Angle.Degrees(+49.81768854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170541"},
        {"Hipparcos Number", "HIP 90454"},
        {"Smithsonian Astrophysical Observation", "SAO 47510"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.86452307),
        dec: Angle.Degrees(+49.81848638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233373"},
        {"Hipparcos Number", "HIP 35496"},
        {"Smithsonian Astrophysical Observation", "SAO 41691"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.88095210),
        dec: Angle.Degrees(+49.81928071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85795"},
        {"Hipparcos Number", "HIP 48682"},
        {"Fundamental Katalog 5th Edition", "FK5 2793"},
        {"Geneva Identification System", "GEN# +1.00085795"},
        {"Smithsonian Astrophysical Observation", "SAO 27430"},
        {"Wilson Evans Batten Catalogue", "WEB 9056"},
    },
    visualMagnitude: 5.27,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.92919035),
        dec: Angle.Degrees(+49.81979501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13867"},
        {"Hipparcos Number", "HIP 10610"},
        {"Celescope Catalog", "CEL 237"},
        {"Geneva Identification System", "GEN# +1.00013867"},
        {"Smithsonian Astrophysical Observation", "SAO 37915"},
        {"Wilson Evans Batten Catalogue", "WEB 2231"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.14997185),
        dec: Angle.Degrees(+49.81988355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 433"},
        {"Hipparcos Number", "HIP 727"},
        {"Geneva Identification System", "GEN# +1.00000433"},
        {"Smithsonian Astrophysical Observation", "SAO 36103"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.24977114),
        dec: Angle.Degrees(+49.85810859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191974"},
        {"Hipparcos Number", "HIP 99388"},
        {"Smithsonian Astrophysical Observation", "SAO 49271"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.59624932),
        dec: Angle.Degrees(+49.82102528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57556",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8307 AB"},
        {"Henry Draper", "HD 102481"},
        {"Hipparcos Number", "HIP 57556"},
        {"Smithsonian Astrophysical Observation", "SAO 28148"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.95850525),
        dec: Angle.Degrees(+49.82294385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111041"},
        {"Hipparcos Number", "HIP 62303"},
        {"Smithsonian Astrophysical Observation", "SAO 28509"},
        {"Wilson Evans Batten Catalogue", "WEB 11064"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.50347579),
        dec: Angle.Degrees(+49.82306441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38104"},
        {"Hipparcos Number", "HIP 27196"},
        {"Celescope Catalog", "CEL 956"},
        {"Fundamental Katalog 5th Edition", "FK5 216"},
        {"Geneva Identification System", "GEN# +1.00038104"},
        {"Renson", "Renson 10240"},
        {"Smithsonian Astrophysical Observation", "SAO 40583"},
        {"Wilson Evans Batten Catalogue", "WEB 5347"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.47520331),
        dec: Angle.Degrees(+49.82628283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211702"},
        {"Hipparcos Number", "HIP 110081"},
        {"Smithsonian Astrophysical Observation", "SAO 51852"},
        {"New General Catalogue", "NGC 7243 534"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.46375690),
        dec: Angle.Degrees(+49.82999906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233842"},
        {"Hipparcos Number", "HIP 56400"},
        {"Smithsonian Astrophysical Observation", "SAO 28056"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.44006074),
        dec: Angle.Degrees(+49.83035789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42545"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.08865542),
        dec: Angle.Degrees(+49.83170859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78388"},
        {"Hipparcos Number", "HIP 44994"},
        {"Geneva Identification System", "GEN# +1.00078388"},
        {"Renson", "Renson 22200"},
        {"Smithsonian Astrophysical Observation", "SAO 27145"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.46845767),
        dec: Angle.Degrees(+49.83218344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3872"},
        {"Hipparcos Number", "HIP 3273"},
        {"Geneva Identification System", "GEN# +1.00003872"},
        {"Smithsonian Astrophysical Observation", "SAO 36580"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.42642027),
        dec: Angle.Degrees(+49.83314369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88904"},
        {"Smithsonian Astrophysical Observation", "SAO 47262"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.22405070),
        dec: Angle.Degrees(+49.83395103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140251"},
        {"Hipparcos Number", "HIP 76766"},
        {"Smithsonian Astrophysical Observation", "SAO 45676"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.11191467),
        dec: Angle.Degrees(+49.83576343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52000"},
        {"Hipparcos Number", "HIP 33898"},
        {"Smithsonian Astrophysical Observation", "SAO 41508"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.53743190),
        dec: Angle.Degrees(+49.83672699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130986"},
        {"Hipparcos Number", "HIP 72486"},
        {"Smithsonian Astrophysical Observation", "SAO 29294"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.32527095),
        dec: Angle.Degrees(+49.83770197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234276"},
        {"Hipparcos Number", "HIP 78373"},
        {"Smithsonian Astrophysical Observation", "SAO 45830"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.00370379),
        dec: Angle.Degrees(+49.83792969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234129"},
        {"Hipparcos Number", "HIP 70101"},
        {"Smithsonian Astrophysical Observation", "SAO 29109"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.16999153),
        dec: Angle.Degrees(+49.83840489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2149",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 361 B"},
        {"Hipparcos Number", "HIP 2149"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.79721676),
        dec: Angle.Degrees(+49.98833216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204305"},
        {"Hipparcos Number", "HIP 105825"},
        {"Geneva Identification System", "GEN# +1.00204305"},
        {"Smithsonian Astrophysical Observation", "SAO 50844"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.50419927),
        dec: Angle.Degrees(+49.84021771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38648"},
        {"Hipparcos Number", "HIP 27535"},
        {"Smithsonian Astrophysical Observation", "SAO 40627"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.47350907),
        dec: Angle.Degrees(+49.84119129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196088"},
        {"Henry Draper 2", "HD 196089"},
        {"Hipparcos Number", "HIP 101398"},
        {"Smithsonian Astrophysical Observation", "SAO 49782"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.24602470),
        dec: Angle.Degrees(+49.84122753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19892"},
        {"Hipparcos Number", "HIP 15044"},
        {"Smithsonian Astrophysical Observation", "SAO 38658"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.47338402),
        dec: Angle.Degrees(+49.84181345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132891"},
        {"Hipparcos Number", "HIP 73382"},
        {"Geneva Identification System", "GEN# +1.00132891"},
        {"Smithsonian Astrophysical Observation", "SAO 29374"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.93297576),
        dec: Angle.Degrees(+49.84309325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127243"},
        {"Hipparcos Number", "HIP 70791"},
        {"Geneva Identification System", "GEN# +1.00127243"},
        {"Smithsonian Astrophysical Observation", "SAO 29165"},
        {"Wilson Evans Batten Catalogue", "WEB 12266"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.15870008),
        dec: Angle.Degrees(+49.84496418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -304.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56053"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.32067014),
        dec: Angle.Degrees(+49.84514776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234001"},
        {"Hipparcos Number", "HIP 63324"},
        {"Smithsonian Astrophysical Observation", "SAO 28589"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.64862762),
        dec: Angle.Degrees(+49.84763784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21362"},
        {"Hipparcos Number", "HIP 16210"},
        {"Geneva Identification System", "GEN# +5.20200810"},
        {"Smithsonian Astrophysical Observation", "SAO 38862"},
        {"Wilson Evans Batten Catalogue", "WEB 3089"},
    },
    visualMagnitude: 5.58,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.21794573),
        dec: Angle.Degrees(+49.84844583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23147",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23147"},
        {"Geneva Identification System", "GEN# +0.04901280"},
        {"Wilson Evans Batten Catalogue", "WEB 4488"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.71030549),
        dec: Angle.Degrees(+49.84956222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181252"},
        {"Hipparcos Number", "HIP 94798"},
        {"Geneva Identification System", "GEN# +1.00181252"},
        {"Smithsonian Astrophysical Observation", "SAO 48295"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.32696289),
        dec: Angle.Degrees(+49.85037109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46118"},
        {"Hipparcos Number", "HIP 31329"},
        {"Smithsonian Astrophysical Observation", "SAO 41180"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.54061687),
        dec: Angle.Degrees(+49.85080855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152774"},
        {"Hipparcos Number", "HIP 82573"},
        {"Smithsonian Astrophysical Observation", "SAO 46346"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.20082210),
        dec: Angle.Degrees(+49.85154640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94336",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12169 AB"},
        {"Hipparcos Number", "HIP 94336"},
        {"Geneva Identification System", "GEN# +1.00179957J"},
        {"Geneva Identification System 2", "GEN# +1.00179958J"},
    },
    visualMagnitude: 5.85,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.02173147),
        dec: Angle.Degrees(+49.85423807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 624.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40942"},
        {"Hipparcos Number", "HIP 28795"},
        {"Smithsonian Astrophysical Observation", "SAO 40833"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.19540222),
        dec: Angle.Degrees(+49.85465721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97513"},
        {"Hipparcos Number", "HIP 54850"},
        {"Geneva Identification System", "GEN# +1.00097513"},
        {"Smithsonian Astrophysical Observation", "SAO 27960"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.44931385),
        dec: Angle.Degrees(+49.85619708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94922",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12317 A"},
        {"Henry Draper", "HD 181678"},
        {"Henry Draper 2", "HD 181678A"},
        {"Hipparcos Number", "HIP 94922"},
        {"Smithsonian Astrophysical Observation", "SAO 48325"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.73552491),
        dec: Angle.Degrees(+49.85988552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221292"},
        {"Hipparcos Number", "HIP 116027"},
        {"Smithsonian Astrophysical Observation", "SAO 53099"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.64715931),
        dec: Angle.Degrees(+49.86028724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15922"},
        {"Hipparcos Number", "HIP 12039"},
        {"Smithsonian Astrophysical Observation", "SAO 38140"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.79827422),
        dec: Angle.Degrees(+49.86035397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142925"},
        {"Hipparcos Number", "HIP 77938"},
        {"Smithsonian Astrophysical Observation", "SAO 29710"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.74980227),
        dec: Angle.Degrees(+49.86035903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29131"},
        {"Hipparcos Number", "HIP 21552"},
        {"Smithsonian Astrophysical Observation", "SAO 39648"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.41248752),
        dec: Angle.Degrees(+49.86035991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211263"},
        {"Hipparcos Number", "HIP 109830"},
        {"Geneva Identification System", "GEN# +2.72430480"},
        {"Smithsonian Astrophysical Observation", "SAO 51800"},
        {"New General Catalogue", "NGC 7243 480"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.67929857),
        dec: Angle.Degrees(+49.86085072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33501"},
        {"Hipparcos Number", "HIP 24325"},
        {"Geneva Identification System", "GEN# +1.00033501"},
        {"Smithsonian Astrophysical Observation", "SAO 40122"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.30388995),
        dec: Angle.Degrees(+49.86122562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15863",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mirfak"},
        {"Henry Draper", "HD 20902"},
        {"Hipparcos Number", "HIP 15863"},
        {"Fundamental Katalog 5th Edition", "FK5 120"},
        {"Geneva Identification System", "GEN# +5.20200605"},
        {"Smithsonian Astrophysical Observation", "SAO 38787"},
        {"Wilson Evans Batten Catalogue", "WEB 3026"},
    },
    visualMagnitude: 1.79,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.08061889),
        dec: Angle.Degrees(+49.86124281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17541",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2736 AB"},
        {"Henry Draper", "HD 23177"},
        {"Hipparcos Number", "HIP 17541"},
        {"Smithsonian Astrophysical Observation", "SAO 39077"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.34419150),
        dec: Angle.Degrees(+49.86178212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151387"},
        {"Hipparcos Number", "HIP 81959"},
        {"Geneva Identification System", "GEN# +1.00151387"},
        {"Smithsonian Astrophysical Observation", "SAO 46258"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.14391224),
        dec: Angle.Degrees(+49.86308510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233864"},
        {"Hipparcos Number", "HIP 57377"},
        {"Smithsonian Astrophysical Observation", "SAO 28128"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.44740511),
        dec: Angle.Degrees(+49.86421997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170108"},
        {"Hipparcos Number", "HIP 90275"},
        {"Smithsonian Astrophysical Observation", "SAO 47481"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.29937446),
        dec: Angle.Degrees(+49.86467620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20095"},
        {"Smithsonian Astrophysical Observation", "SAO 39449"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.62692694),
        dec: Angle.Degrees(+49.86469403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216534"},
        {"Hipparcos Number", "HIP 112990"},
        {"Geneva Identification System", "GEN# +1.00216534"},
        {"Smithsonian Astrophysical Observation", "SAO 52451"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.24411710),
        dec: Angle.Degrees(+49.86478633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223298"},
        {"Hipparcos Number", "HIP 117402"},
        {"Smithsonian Astrophysical Observation", "SAO 53387"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.07834025),
        dec: Angle.Degrees(+49.86487248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83206"},
        {"Hipparcos Number", "HIP 47305"},
        {"Geneva Identification System", "GEN# +1.00083206"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.59787446),
        dec: Angle.Degrees(+49.86783841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199477"},
        {"Hipparcos Number", "HIP 103296"},
        {"Smithsonian Astrophysical Observation", "SAO 50242"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.90700097),
        dec: Angle.Degrees(+49.86800809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10865"},
        {"Hipparcos Number", "HIP 8363"},
        {"Smithsonian Astrophysical Observation", "SAO 37511"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.94222845),
        dec: Angle.Degrees(+49.86845262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106038",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15030 A"},
        {"Hipparcos Number", "HIP 106038"},
        {"Smithsonian Astrophysical Observation", "SAO 50919"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.17946836),
        dec: Angle.Degrees(+49.86848185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234132"},
        {"Hipparcos Number", "HIP 70377"},
        {"Smithsonian Astrophysical Observation", "SAO 29126"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.98547340),
        dec: Angle.Degrees(+49.86891864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11223"},
        {"Hipparcos Number", "HIP 8656"},
        {"Celescope Catalog", "CEL 172"},
        {"Smithsonian Astrophysical Observation", "SAO 37561"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.88788237),
        dec: Angle.Degrees(+49.86939566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50295"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.03966839),
        dec: Angle.Degrees(+49.87012170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225172"},
        {"Hipparcos Number", "HIP 323"},
        {"Smithsonian Astrophysical Observation", "SAO 36030"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.04272795),
        dec: Angle.Degrees(+49.87020726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16455"},
        {"Smithsonian Astrophysical Observation", "SAO 38915"},
        {"Wilson Evans Batten Catalogue", "WEB 3144"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.99457470),
        dec: Angle.Degrees(+49.87022713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211210"},
        {"Hipparcos Number", "HIP 109809"},
        {"Geneva Identification System", "GEN# +2.72430475"},
        {"Smithsonian Astrophysical Observation", "SAO 51794"},
        {"New General Catalogue", "NGC 7243 475"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.61344334),
        dec: Angle.Degrees(+49.87159439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7841",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1315 ABC"},
        {"Hipparcos Number", "HIP 7841"},
    },
    visualMagnitude: 9.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.21505043),
        dec: Angle.Degrees(+49.87535530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18279"},
        {"Hipparcos Number", "HIP 13829"},
        {"Renson", "Renson 4555"},
        {"Smithsonian Astrophysical Observation", "SAO 38471"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.49660048),
        dec: Angle.Degrees(+49.87806290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86871"},
        {"Hipparcos Number", "HIP 49224"},
        {"Smithsonian Astrophysical Observation", "SAO 27490"},
        {"Wilson Evans Batten Catalogue", "WEB 9113"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.70675932),
        dec: Angle.Degrees(+49.87844971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143584"},
        {"Hipparcos Number", "HIP 78286"},
        {"Fundamental Katalog 5th Edition", "FK5 3260"},
        {"Geneva Identification System", "GEN# +1.00143584"},
        {"Smithsonian Astrophysical Observation", "SAO 29737"},
        {"Wilson Evans Batten Catalogue", "WEB 13239"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.76823455),
        dec: Angle.Degrees(+49.88117823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46397"},
        {"Hipparcos Number", "HIP 31501"},
        {"Fundamental Katalog 5th Edition", "FK5 4600"},
        {"Geneva Identification System", "GEN# +1.00046397"},
        {"Smithsonian Astrophysical Observation", "SAO 41194"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.95929026),
        dec: Angle.Degrees(+49.88255324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141550"},
        {"Hipparcos Number", "HIP 77363"},
        {"Geneva Identification System", "GEN# +1.00141550"},
        {"Smithsonian Astrophysical Observation", "SAO 29665"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.88518809),
        dec: Angle.Degrees(+49.88302450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25890"},
        {"Hipparcos Number", "HIP 19318"},
        {"Geneva Identification System", "GEN# +1.00025890"},
        {"Smithsonian Astrophysical Observation", "SAO 39330"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.11494763),
        dec: Angle.Degrees(+49.88345875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163074"},
        {"Hipparcos Number", "HIP 87408"},
        {"Smithsonian Astrophysical Observation", "SAO 47020"},
        {"Wilson Evans Batten Catalogue", "WEB 14744"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.93900707),
        dec: Angle.Degrees(+49.88371066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106636",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106636"},
        {"Smithsonian Astrophysical Observation", "SAO 51081"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.98542309),
        dec: Angle.Degrees(+49.88762288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108210"},
        {"Hipparcos Number", "HIP 60637"},
        {"Smithsonian Astrophysical Observation", "SAO 28381"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.40515778),
        dec: Angle.Degrees(+49.88775739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111178"},
        {"Smithsonian Astrophysical Observation", "SAO 52103"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.84383686),
        dec: Angle.Degrees(+49.88826371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59972"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.49337812),
        dec: Angle.Degrees(+49.88962626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171341"},
        {"Hipparcos Number", "HIP 90835"},
        {"Geneva Identification System", "GEN# +1.00171341"},
        {"Smithsonian Astrophysical Observation", "SAO 47572"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.96537959),
        dec: Angle.Degrees(+49.89116338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135696"},
        {"Hipparcos Number", "HIP 74597"},
        {"Smithsonian Astrophysical Observation", "SAO 29457"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.62501191),
        dec: Angle.Degrees(+49.89269267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66708"},
        {"Hipparcos Number", "HIP 39712"},
        {"Fundamental Katalog 5th Edition", "FK5 4728"},
        {"Geneva Identification System", "GEN# +1.00066708"},
        {"Smithsonian Astrophysical Observation", "SAO 26671"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.75738972),
        dec: Angle.Degrees(+49.89291940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233645"},
        {"Hipparcos Number", "HIP 46743"},
        {"Smithsonian Astrophysical Observation", "SAO 27281"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.91088449),
        dec: Angle.Degrees(+49.89414031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4057"},
        {"Hipparcos Number", "HIP 3412"},
        {"Geneva Identification System", "GEN# +1.00004057"},
        {"Smithsonian Astrophysical Observation", "SAO 36600"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.86052883),
        dec: Angle.Degrees(+49.89468228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7507"},
        {"Hipparcos Number", "HIP 5912"},
        {"Smithsonian Astrophysical Observation", "SAO 37062"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.01590705),
        dec: Angle.Degrees(+49.89627605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57601"},
        {"Hipparcos Number", "HIP 35945"},
        {"Smithsonian Astrophysical Observation", "SAO 41740"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.14978605),
        dec: Angle.Degrees(+49.89705875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113403"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.49975112),
        dec: Angle.Degrees(+49.89799206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117984"},
        {"Smithsonian Astrophysical Observation", "SAO 53490"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.97469644),
        dec: Angle.Degrees(+49.90002515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143776"},
        {"Hipparcos Number", "HIP 78376"},
        {"Geneva Identification System", "GEN# +1.00143776"},
        {"Smithsonian Astrophysical Observation", "SAO 29745"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.00755278),
        dec: Angle.Degrees(+49.90006290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22796"},
        {"Wilson Evans Batten Catalogue", "WEB 4412"},
    },
    visualMagnitude: 11.47,
    bvColour: 2.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.56247443),
        dec: Angle.Degrees(+49.90009717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97513"},
        {"Smithsonian Astrophysical Observation", "SAO 48871"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.29643182),
        dec: Angle.Degrees(+49.90037057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54368"},
        {"Hipparcos Number", "HIP 34687"},
        {"Geneva Identification System", "GEN# +1.00054368"},
        {"Smithsonian Astrophysical Observation", "SAO 41600"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.76290168),
        dec: Angle.Degrees(+49.90191852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21619"},
        {"Hipparcos Number", "HIP 16426"},
        {"Geneva Identification System", "GEN# +5.20200931"},
        {"Smithsonian Astrophysical Observation", "SAO 38904"},
        {"Wilson Evans Batten Catalogue", "WEB 3138"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.87568490),
        dec: Angle.Degrees(+49.90214136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109113"},
        {"Geneva Identification System", "GEN# +0.04903735"},
        {"Smithsonian Astrophysical Observation", "SAO 51653"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.53481624),
        dec: Angle.Degrees(+49.90245529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135120"},
        {"Hipparcos Number", "HIP 74337"},
        {"Smithsonian Astrophysical Observation", "SAO 29436"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.89579339),
        dec: Angle.Degrees(+49.90303696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68746"},
        {"Hipparcos Number", "HIP 40491"},
        {"Geneva Identification System", "GEN# +1.00068746"},
        {"Smithsonian Astrophysical Observation", "SAO 26745"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.00900563),
        dec: Angle.Degrees(+49.90307315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76880"},
        {"Hipparcos Number", "HIP 44274"},
        {"Smithsonian Astrophysical Observation", "SAO 27083"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.23305305),
        dec: Angle.Degrees(+49.90319338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40626"},
        {"Hipparcos Number", "HIP 28637"},
        {"Celescope Catalog", "CEL 1060"},
        {"Geneva Identification System", "GEN# +1.00040626"},
        {"Renson", "Renson 10870"},
        {"Smithsonian Astrophysical Observation", "SAO 40801"},
        {"Wilson Evans Batten Catalogue", "WEB 5597"},
    },
    visualMagnitude: 6.04,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.70245620),
        dec: Angle.Degrees(+49.90578464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15363"},
        {"Smithsonian Astrophysical Observation", "SAO 38705"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.52184330),
        dec: Angle.Degrees(+49.90612141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51988"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.32942638),
        dec: Angle.Degrees(+49.90754513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196671"},
        {"Hipparcos Number", "HIP 101702"},
        {"Smithsonian Astrophysical Observation", "SAO 49859"},
        {"Wilson Evans Batten Catalogue", "WEB 18369"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.21042329),
        dec: Angle.Degrees(+49.90960475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115918"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.28720041),
        dec: Angle.Degrees(+49.91151582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233885"},
        {"Hipparcos Number", "HIP 58355"},
        {"Smithsonian Astrophysical Observation", "SAO 28206"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.49966767),
        dec: Angle.Degrees(+49.91156721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95495"},
        {"Smithsonian Astrophysical Observation", "SAO 48426"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.36220071),
        dec: Angle.Degrees(+49.91254284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11925"},
        {"Hipparcos Number", "HIP 9204"},
        {"Smithsonian Astrophysical Observation", "SAO 37660"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.60638074),
        dec: Angle.Degrees(+49.91507872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29600"},
        {"Hipparcos Number", "HIP 21876"},
        {"Geneva Identification System", "GEN# +1.00029600"},
        {"Smithsonian Astrophysical Observation", "SAO 39695"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.54379826),
        dec: Angle.Degrees(+49.91989777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233531"},
        {"Hipparcos Number", "HIP 41455"},
        {"Smithsonian Astrophysical Observation", "SAO 26843"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.82832064),
        dec: Angle.Degrees(+49.92222530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31292"},
        {"Hipparcos Number", "HIP 23020"},
        {"Geneva Identification System", "GEN# +1.00031292"},
        {"Smithsonian Astrophysical Observation", "SAO 39884"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.26024466),
        dec: Angle.Degrees(+49.92236063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12034 A"},
        {"Henry Draper", "HD 178208"},
        {"Hipparcos Number", "HIP 93733"},
        {"Smithsonian Astrophysical Observation", "SAO 48071"},
        {"Wilson Evans Batten Catalogue", "WEB 16292"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.29102390),
        dec: Angle.Degrees(+49.92315319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64588"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.57216837),
        dec: Angle.Degrees(+49.92401281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40084"},
        {"Hipparcos Number", "HIP 28343"},
        {"Geneva Identification System", "GEN# +1.00040084"},
        {"Smithsonian Astrophysical Observation", "SAO 40743"},
        {"Wilson Evans Batten Catalogue", "WEB 5539"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.84076564),
        dec: Angle.Degrees(+49.92454610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233981"},
        {"Hipparcos Number", "HIP 62475"},
        {"Smithsonian Astrophysical Observation", "SAO 28520"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.05467577),
        dec: Angle.Degrees(+49.92510236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25133"},
        {"Hipparcos Number", "HIP 18814"},
        {"Geneva Identification System", "GEN# +1.00025133"},
        {"Smithsonian Astrophysical Observation", "SAO 39251"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.47616476),
        dec: Angle.Degrees(+49.92641905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 849"},
        {"Hipparcos Number", "HIP 1043"},
        {"Geneva Identification System", "GEN# +1.00000849"},
        {"Smithsonian Astrophysical Observation", "SAO 36164"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.25751547),
        dec: Angle.Degrees(+49.92651300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50762"},
        {"Hipparcos Number", "HIP 33439"},
        {"Smithsonian Astrophysical Observation", "SAO 41453"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.29417220),
        dec: Angle.Degrees(+49.92666389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4340"},
        {"Smithsonian Astrophysical Observation", "SAO 36773"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.91225024),
        dec: Angle.Degrees(+49.92902838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12659"},
        {"Smithsonian Astrophysical Observation", "SAO 38263"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.66267581),
        dec: Angle.Degrees(+49.93066528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103069"},
        {"Hipparcos Number", "HIP 57876"},
        {"Geneva Identification System", "GEN# +1.00103069"},
        {"Smithsonian Astrophysical Observation", "SAO 28172"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.06003644),
        dec: Angle.Degrees(+49.93162306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105166",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14840 AB"},
        {"Henry Draper", "HD 203063"},
        {"Hipparcos Number", "HIP 105166"},
        {"Smithsonian Astrophysical Observation", "SAO 50687"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.55046302),
        dec: Angle.Degrees(+49.93175381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49730"},
        {"Hipparcos Number", "HIP 33000"},
        {"Smithsonian Astrophysical Observation", "SAO 41398"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.12308120),
        dec: Angle.Degrees(+49.93532947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233783"},
        {"Hipparcos Number", "HIP 53281"},
        {"Smithsonian Astrophysical Observation", "SAO 27818"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.45092554),
        dec: Angle.Degrees(+49.93545445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22554"},
        {"Hipparcos Number", "HIP 17104"},
        {"Smithsonian Astrophysical Observation", "SAO 39023"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.96479995),
        dec: Angle.Degrees(+49.93576750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210800"},
        {"Hipparcos Number", "HIP 109567"},
        {"Geneva Identification System", "GEN# +2.72430306"},
        {"Smithsonian Astrophysical Observation", "SAO 51748"},
        {"New General Catalogue", "NGC 7243 306"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.93380908),
        dec: Angle.Degrees(+49.93663111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151044"},
        {"Hipparcos Number", "HIP 81800"},
        {"Fundamental Katalog 5th Edition", "FK5 3328"},
        {"Geneva Identification System", "GEN# +1.00151044"},
        {"Smithsonian Astrophysical Observation", "SAO 30055"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.61538018),
        dec: Angle.Degrees(+49.93670286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195175"},
        {"Hipparcos Number", "HIP 100919"},
        {"Geneva Identification System", "GEN# +1.00195175"},
        {"Smithsonian Astrophysical Observation", "SAO 49657"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.91962420),
        dec: Angle.Degrees(+49.93868218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59012"},
        {"Hipparcos Number", "HIP 36508"},
        {"Geneva Identification System", "GEN# +1.00059012"},
        {"Smithsonian Astrophysical Observation", "SAO 26380"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.66382596),
        dec: Angle.Degrees(+49.93912548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234243"},
        {"Hipparcos Number", "HIP 76135"},
        {"Smithsonian Astrophysical Observation", "SAO 29567"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.25415074),
        dec: Angle.Degrees(+49.93939767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9041"},
        {"Hipparcos Number", "HIP 7000"},
        {"Smithsonian Astrophysical Observation", "SAO 37273"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.52565082),
        dec: Angle.Degrees(+49.94226396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11451"},
        {"Hipparcos Number", "HIP 8856"},
        {"Smithsonian Astrophysical Observation", "SAO 37593"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.47592974),
        dec: Angle.Degrees(+49.94296869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41560"},
        {"Hipparcos Number", "HIP 29128"},
        {"Smithsonian Astrophysical Observation", "SAO 40878"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.13807462),
        dec: Angle.Degrees(+49.94388136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17529"},
        {"Hipparcos Number", "HIP 13238"},
        {"Smithsonian Astrophysical Observation", "SAO 38380"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.60295916),
        dec: Angle.Degrees(+49.94466132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75554"},
        {"Hipparcos Number", "HIP 43592"},
        {"Geneva Identification System", "GEN# +1.00075554"},
        {"Smithsonian Astrophysical Observation", "SAO 27025"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.16654108),
        dec: Angle.Degrees(+49.94495255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233205"},
        {"Hipparcos Number", "HIP 28911"},
        {"Smithsonian Astrophysical Observation", "SAO 40846"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.54256931),
        dec: Angle.Degrees(+49.94695586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42251"},
        {"Hipparcos Number", "HIP 29453"},
        {"Smithsonian Astrophysical Observation", "SAO 40936"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.09081973),
        dec: Angle.Degrees(+49.94717184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66746"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.20671724),
        dec: Angle.Degrees(+49.94742049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29996"},
        {"Hipparcos Number", "HIP 22174"},
        {"Smithsonian Astrophysical Observation", "SAO 39735"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.56475571),
        dec: Angle.Degrees(+49.94822684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77227"},
        {"Hipparcos Number", "HIP 44421"},
        {"Smithsonian Astrophysical Observation", "SAO 27096"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.76189748),
        dec: Angle.Degrees(+49.94827209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148652"},
        {"Hipparcos Number", "HIP 80585"},
        {"Smithsonian Astrophysical Observation", "SAO 29945"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.80156673),
        dec: Angle.Degrees(+49.95070062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234679"},
        {"Hipparcos Number", "HIP 91055"},
        {"Smithsonian Astrophysical Observation", "SAO 47616"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.61559243),
        dec: Angle.Degrees(+49.95119024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234078"},
        {"Hipparcos Number", "HIP 67691"},
        {"Cincinnati Publication", "Ci 20 818"},
        {"Geneva Identification System", "GEN# +1.00234078"},
        {"Smithsonian Astrophysical Observation", "SAO 28910"},
        {"Wilson Evans Batten Catalogue", "WEB 11907"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.99842411),
        dec: Angle.Degrees(+49.95124696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 422.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109911"},
        {"Geneva Identification System", "GEN# +2.72430370"},
        {"Renson", "Renson 58680"},
        {"New General Catalogue", "NGC 7243 370"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.91201409),
        dec: Angle.Degrees(+49.95451062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217541"},
        {"Hipparcos Number", "HIP 113617"},
        {"Smithsonian Astrophysical Observation", "SAO 52591"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.17228540),
        dec: Angle.Degrees(+49.95606526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101740"},
        {"Hipparcos Number", "HIP 57131"},
        {"Smithsonian Astrophysical Observation", "SAO 28106"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.70301240),
        dec: Angle.Degrees(+49.95907043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99052"},
        {"Smithsonian Astrophysical Observation", "SAO 49193"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.65597788),
        dec: Angle.Degrees(+49.95912460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146009"},
        {"Hipparcos Number", "HIP 79351"},
        {"Smithsonian Astrophysical Observation", "SAO 29839"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.92712734),
        dec: Angle.Degrees(+49.96305574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169667"},
        {"Hipparcos Number", "HIP 90101"},
        {"Smithsonian Astrophysical Observation", "SAO 47457"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.81297589),
        dec: Angle.Degrees(+49.96372483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79280"},
        {"Hipparcos Number", "HIP 45384"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.72560356),
        dec: Angle.Degrees(+49.96657741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3234"},
        {"Smithsonian Astrophysical Observation", "SAO 36572"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.28857033),
        dec: Angle.Degrees(+49.96748694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234613"},
        {"Hipparcos Number", "HIP 89760"},
        {"Smithsonian Astrophysical Observation", "SAO 47386"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.76261040),
        dec: Angle.Degrees(+49.96818107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110322"},
        {"Smithsonian Astrophysical Observation", "SAO 51901"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.17602746),
        dec: Angle.Degrees(+49.97132742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89087"},
        {"Geneva Identification System", "GEN# +0.04902743"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.73448375),
        dec: Angle.Degrees(+49.97165392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112284"},
        {"Smithsonian Astrophysical Observation", "SAO 52326"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.14896642),
        dec: Angle.Degrees(+49.97192196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29721"},
        {"Hipparcos Number", "HIP 21972"},
        {"Fundamental Katalog 5th Edition", "FK5 1128"},
        {"Geneva Identification System", "GEN# +1.00029721"},
        {"Smithsonian Astrophysical Observation", "SAO 39702"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.83999357),
        dec: Angle.Degrees(+49.97382624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98331"},
        {"Hipparcos Number", "HIP 55261"},
        {"Smithsonian Astrophysical Observation", "SAO 27984"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.77759386),
        dec: Angle.Degrees(+49.97383722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18492"},
        {"Hipparcos Number", "HIP 14004"},
        {"Smithsonian Astrophysical Observation", "SAO 38496"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.07358849),
        dec: Angle.Degrees(+49.97414570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32508"},
        {"Hipparcos Number", "HIP 23747"},
        {"Geneva Identification System", "GEN# +1.00032508"},
        {"Smithsonian Astrophysical Observation", "SAO 40017"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.56466593),
        dec: Angle.Degrees(+49.97484698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58718"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.65459415),
        dec: Angle.Degrees(+49.97640260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205314"},
        {"Hipparcos Number", "HIP 106393"},
        {"Celescope Catalog", "CEL 5339"},
        {"Geneva Identification System", "GEN# +1.00205314"},
        {"Smithsonian Astrophysical Observation", "SAO 51019"},
        {"Wilson Evans Batten Catalogue", "WEB 19262"},
    },
    visualMagnitude: 5.77,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.23574046),
        dec: Angle.Degrees(+49.97760064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216795"},
        {"Hipparcos Number", "HIP 113188"},
        {"Smithsonian Astrophysical Observation", "SAO 52492"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.80882609),
        dec: Angle.Degrees(+49.97840075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36470",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6117 AB"},
        {"Henry Draper", "HD 58945"},
        {"Hipparcos Number", "HIP 36470"},
        {"Smithsonian Astrophysical Observation", "SAO 26377"},
        {"Wilson Evans Batten Catalogue", "WEB 7257"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.56887051),
        dec: Angle.Degrees(+49.97854793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40311"},
        {"Hipparcos Number", "HIP 28470"},
        {"Smithsonian Astrophysical Observation", "SAO 40772"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.15901643),
        dec: Angle.Degrees(+49.97880910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233694"},
        {"Hipparcos Number", "HIP 49003"},
        {"Smithsonian Astrophysical Observation", "SAO 27466"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.95910224),
        dec: Angle.Degrees(+49.97959075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9943"},
        {"Hipparcos Number", "HIP 7634"},
        {"Smithsonian Astrophysical Observation", "SAO 37386"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.58708946),
        dec: Angle.Degrees(+49.98047054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212095"},
        {"Hipparcos Number", "HIP 110321"},
        {"Smithsonian Astrophysical Observation", "SAO 51900"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.17426100),
        dec: Angle.Degrees(+49.98154136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224870"},
        {"Hipparcos Number", "HIP 106"},
        {"Fundamental Katalog 5th Edition", "FK5 3929"},
        {"Geneva Identification System", "GEN# +1.00224870"},
        {"Smithsonian Astrophysical Observation", "SAO 53573"},
        {"Wilson Evans Batten Catalogue", "WEB 12"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.33016464),
        dec: Angle.Degrees(+49.98158501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37086"},
        {"Hipparcos Number", "HIP 26529"},
        {"Geneva Identification System", "GEN# +1.00037086"},
        {"Smithsonian Astrophysical Observation", "SAO 40501"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.64001545),
        dec: Angle.Degrees(+49.98290482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106898"},
        {"Smithsonian Astrophysical Observation", "SAO 51145"},
    },
    visualMagnitude: 9.13,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.75555663),
        dec: Angle.Degrees(+49.98319844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234324"},
        {"Hipparcos Number", "HIP 81239"},
        {"Smithsonian Astrophysical Observation", "SAO 30006"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.88236564),
        dec: Angle.Degrees(+49.98549483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2151",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 361 A"},
        {"Henry Draper", "HD 2301"},
        {"Hipparcos Number", "HIP 2151"},
        {"Smithsonian Astrophysical Observation", "SAO 36374"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.80185931),
        dec: Angle.Degrees(+49.98572998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233565"},
        {"Hipparcos Number", "HIP 42786"},
        {"Fundamental Katalog 5th Edition", "FK5 4783"},
        {"Smithsonian Astrophysical Observation", "SAO 26972"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.76728596),
        dec: Angle.Degrees(+49.98768396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186409"},
        {"Hipparcos Number", "HIP 96900"},
        {"Smithsonian Astrophysical Observation", "SAO 48744"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.46577331),
        dec: Angle.Degrees(+49.98879180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234035"},
        {"Hipparcos Number", "HIP 65424"},
        {"Smithsonian Astrophysical Observation", "SAO 28741"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.14822384),
        dec: Angle.Degrees(+49.98884735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234369"},
        {"Hipparcos Number", "HIP 82906"},
        {"Smithsonian Astrophysical Observation", "SAO 30165"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.12737016),
        dec: Angle.Degrees(+49.98917944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218766"},
        {"Hipparcos Number", "HIP 114395"},
        {"Geneva Identification System", "GEN# +1.00218766"},
        {"Smithsonian Astrophysical Observation", "SAO 52756"},
        {"Wilson Evans Batten Catalogue", "WEB 20310"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.52390385),
        dec: Angle.Degrees(+49.99055777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107770"},
        {"Smithsonian Astrophysical Observation", "SAO 51350"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.49631211),
        dec: Angle.Degrees(+49.99210038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24083"},
        {"Smithsonian Astrophysical Observation", "SAO 40068"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.60284402),
        dec: Angle.Degrees(+49.99370922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234164"},
        {"Hipparcos Number", "HIP 71501"},
        {"Smithsonian Astrophysical Observation", "SAO 29220"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.33476297),
        dec: Angle.Degrees(+49.99411882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139283"},
        {"Hipparcos Number", "HIP 76303"},
        {"Smithsonian Astrophysical Observation", "SAO 29579"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.79936975),
        dec: Angle.Degrees(+49.99483017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198400"},
        {"Hipparcos Number", "HIP 102657"},
        {"Smithsonian Astrophysical Observation", "SAO 50081"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.05049259),
        dec: Angle.Degrees(+49.99557656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12172"},
        {"Smithsonian Astrophysical Observation", "SAO 38164"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.21373720),
        dec: Angle.Degrees(+49.99795107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4562"},
        {"Smithsonian Astrophysical Observation", "SAO 36808"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.58579386),
        dec: Angle.Degrees(+49.99798989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51051",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51051"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.45040481),
        dec: Angle.Degrees(+49.99942813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7979",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1341 AB"},
        {"Hipparcos Number", "HIP 7979"},
        {"Smithsonian Astrophysical Observation", "SAO 37447"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.62282109),
        dec: Angle.Degrees(+49.99975881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234705"},
        {"Hipparcos Number", "HIP 92074"},
        {"Smithsonian Astrophysical Observation", "SAO 47782"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.49206692),
        dec: Angle.Degrees(+50.00071751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233650"},
        {"Hipparcos Number", "HIP 47049"},
        {"Smithsonian Astrophysical Observation", "SAO 27302"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.82326021),
        dec: Angle.Degrees(+50.00240585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2528"},
        {"Smithsonian Astrophysical Observation", "SAO 36446"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.02068890),
        dec: Angle.Degrees(+50.00357838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141676"},
        {"Hipparcos Number", "HIP 77401"},
        {"Smithsonian Astrophysical Observation", "SAO 29675"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.02424408),
        dec: Angle.Degrees(+50.00457379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233819"},
        {"Hipparcos Number", "HIP 54748"},
        {"Smithsonian Astrophysical Observation", "SAO 27951"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.14500075),
        dec: Angle.Degrees(+50.00550697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14770"},
        {"Hipparcos Number", "HIP 11220"},
        {"Geneva Identification System", "GEN# +1.00014770"},
        {"Smithsonian Astrophysical Observation", "SAO 38005"},
        {"Wilson Evans Batten Catalogue", "WEB 2349"},
    },
    visualMagnitude: 5.19,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.10372497),
        dec: Angle.Degrees(+50.00663318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67935"},
        {"Hipparcos Number", "HIP 40190"},
        {"Geneva Identification System", "GEN# +1.00067935"},
        {"Smithsonian Astrophysical Observation", "SAO 26724"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.14008740),
        dec: Angle.Degrees(+50.00917255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234295"},
        {"Hipparcos Number", "HIP 79810"},
        {"Smithsonian Astrophysical Observation", "SAO 29866"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.32661383),
        dec: Angle.Degrees(+50.00989447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187217"},
        {"Hipparcos Number", "HIP 97304"},
        {"Smithsonian Astrophysical Observation", "SAO 48828"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.63651285),
        dec: Angle.Degrees(+50.01038425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88713",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11082 AB"},
        {"Henry Draper", "HD 234561"},
        {"Hipparcos Number", "HIP 88713"},
        {"Smithsonian Astrophysical Observation", "SAO 30749"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.65531469),
        dec: Angle.Degrees(+50.01065169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216175"},
        {"Hipparcos Number", "HIP 112745"},
        {"Geneva Identification System", "GEN# +1.00216175"},
        {"Smithsonian Astrophysical Observation", "SAO 52407"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.48733870),
        dec: Angle.Degrees(+50.01657377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61704"},
    },
    visualMagnitude: 11.61,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.71949341),
        dec: Angle.Degrees(+50.01720465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47718"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.92727645),
        dec: Angle.Degrees(+50.01769088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234082"},
        {"Hipparcos Number", "HIP 67732"},
        {"Smithsonian Astrophysical Observation", "SAO 28919"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.12512918),
        dec: Angle.Degrees(+50.01855867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4932"},
        {"Hipparcos Number", "HIP 4059"},
        {"Smithsonian Astrophysical Observation", "SAO 36723"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.99240284),
        dec: Angle.Degrees(+50.01907473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66933"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.75354181),
        dec: Angle.Degrees(+50.02223968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74504"},
        {"Hipparcos Number", "HIP 43062"},
        {"Geneva Identification System", "GEN# +1.00074504"},
        {"Smithsonian Astrophysical Observation", "SAO 26991"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.58625411),
        dec: Angle.Degrees(+50.02299817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151993"},
        {"Hipparcos Number", "HIP 82246"},
        {"Smithsonian Astrophysical Observation", "SAO 30102"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.05746166),
        dec: Angle.Degrees(+50.02382687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128271"},
        {"Hipparcos Number", "HIP 71248"},
        {"Smithsonian Astrophysical Observation", "SAO 29200"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.55908407),
        dec: Angle.Degrees(+50.02561047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104053"},
        {"Smithsonian Astrophysical Observation", "SAO 50427"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.20816953),
        dec: Angle.Degrees(+50.02600898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119583"},
        {"Hipparcos Number", "HIP 66928"},
        {"Geneva Identification System", "GEN# +1.00119583"},
        {"Smithsonian Astrophysical Observation", "SAO 28860"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.74392874),
        dec: Angle.Degrees(+50.02678016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219574"},
        {"Hipparcos Number", "HIP 114890"},
        {"Smithsonian Astrophysical Observation", "SAO 52849"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.07909281),
        dec: Angle.Degrees(+50.02793809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81703"},
        {"Hipparcos Number", "HIP 46496"},
        {"Fundamental Katalog 5th Edition", "FK5 4843"},
        {"Smithsonian Astrophysical Observation", "SAO 27267"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.24668130),
        dec: Angle.Degrees(+50.03114629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18916"},
        {"Hipparcos Number", "HIP 14300"},
        {"Geneva Identification System", "GEN# +1.00018916"},
        {"Smithsonian Astrophysical Observation", "SAO 38548"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.10465975),
        dec: Angle.Degrees(+50.03202064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20370",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3141 AB"},
        {"Henry Draper", "HD 27395"},
        {"Hipparcos Number", "HIP 20370"},
        {"Smithsonian Astrophysical Observation", "SAO 39484"},
        {"New General Catalogue", "NGC 1545 98"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.43946359),
        dec: Angle.Degrees(+50.03518808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220931"},
        {"Hipparcos Number", "HIP 115790"},
        {"Smithsonian Astrophysical Observation", "SAO 53046"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.86456003),
        dec: Angle.Degrees(+50.03529555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234413"},
        {"Hipparcos Number", "HIP 84350"},
        {"Smithsonian Astrophysical Observation", "SAO 30307"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.67622268),
        dec: Angle.Degrees(+50.03783834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233717"},
        {"Hipparcos Number", "HIP 50060"},
        {"Smithsonian Astrophysical Observation", "SAO 27563"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.31771635),
        dec: Angle.Degrees(+50.03817689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153299"},
        {"Hipparcos Number", "HIP 82867"},
        {"Geneva Identification System", "GEN# +1.00153299"},
        {"Smithsonian Astrophysical Observation", "SAO 30161"},
        {"Wilson Evans Batten Catalogue", "WEB 14009"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.02683411),
        dec: Angle.Degrees(+50.03890462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234086"},
        {"Hipparcos Number", "HIP 67989"},
        {"Smithsonian Astrophysical Observation", "SAO 28931"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.84533864),
        dec: Angle.Degrees(+50.04113966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220563"},
        {"Hipparcos Number", "HIP 115540"},
        {"Smithsonian Astrophysical Observation", "SAO 52981"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.06183048),
        dec: Angle.Degrees(+50.04362660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161796"},
        {"Hipparcos Number", "HIP 86869"},
        {"Geneva Identification System", "GEN# +1.00161796"},
        {"Smithsonian Astrophysical Observation", "SAO 30548"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.23112991),
        dec: Angle.Degrees(+50.04433021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50161"},
        {"Hipparcos Number", "HIP 33196"},
        {"Smithsonian Astrophysical Observation", "SAO 26033"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.63593877),
        dec: Angle.Degrees(+50.04495030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233930"},
        {"Hipparcos Number", "HIP 60384"},
        {"Smithsonian Astrophysical Observation", "SAO 28359"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.71286444),
        dec: Angle.Degrees(+50.04600303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32457"},
        {"Hipparcos Number", "HIP 23715"},
        {"Smithsonian Astrophysical Observation", "SAO 40013"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.47843128),
        dec: Angle.Degrees(+50.04605622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59105"},
        {"Hipparcos Number", "HIP 36545"},
        {"Smithsonian Astrophysical Observation", "SAO 26385"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.76450894),
        dec: Angle.Degrees(+50.04854578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22696",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3481 AB"},
        {"Hipparcos Number", "HIP 22696"},
        {"Smithsonian Astrophysical Observation", "SAO 39822"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.19589024),
        dec: Angle.Degrees(+50.04858053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27084"},
        {"Hipparcos Number", "HIP 20156"},
        {"Geneva Identification System", "GEN# +2.15450002"},
        {"Smithsonian Astrophysical Observation", "SAO 39457"},
        {"Wilson Evans Batten Catalogue", "WEB 3844"},
        {"New General Catalogue", "NGC 1545 2"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.80492598),
        dec: Angle.Degrees(+50.04883763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1109"},
        {"Hipparcos Number", "HIP 1247"},
        {"Smithsonian Astrophysical Observation", "SAO 36206"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.89046564),
        dec: Angle.Degrees(+50.05031370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218031"},
        {"Hipparcos Number", "HIP 113919"},
        {"Geneva Identification System", "GEN# +1.00218031"},
        {"Smithsonian Astrophysical Observation", "SAO 52649"},
        {"Wilson Evans Batten Catalogue", "WEB 20234"},
    },
    visualMagnitude: 4.64,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.04513231),
        dec: Angle.Degrees(+50.05168397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 167.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87010"},
        {"Geneva Identification System", "GEN# +6.20030175"},
        {"Wilson Evans Batten Catalogue", "WEB 14675"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.68248021),
        dec: Angle.Degrees(+50.05258885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -350.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134493"},
        {"Hipparcos Number", "HIP 74083"},
        {"Fundamental Katalog 5th Edition", "FK5 3197"},
        {"Geneva Identification System", "GEN# +1.00134493"},
        {"Smithsonian Astrophysical Observation", "SAO 29420"},
        {"Wilson Evans Batten Catalogue", "WEB 12655"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.08142101),
        dec: Angle.Degrees(+50.05500620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8040"},
        {"Smithsonian Astrophysical Observation", "SAO 37459"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.80909283),
        dec: Angle.Degrees(+50.05912766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47810"},
        {"Hipparcos Number", "HIP 32181"},
        {"Smithsonian Astrophysical Observation", "SAO 25904"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.78645368),
        dec: Angle.Degrees(+50.06014738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103639"},
        {"Smithsonian Astrophysical Observation", "SAO 50339"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.97797365),
        dec: Angle.Degrees(+50.06299814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108122"},
        {"Smithsonian Astrophysical Observation", "SAO 51420"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.57897743),
        dec: Angle.Degrees(+50.06446681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165397"},
        {"Hipparcos Number", "HIP 88417"},
        {"Smithsonian Astrophysical Observation", "SAO 30713"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.79222869),
        dec: Angle.Degrees(+50.06543568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15863"},
        {"Hipparcos Number", "HIP 11997"},
        {"Celescope Catalog", "CEL 287"},
        {"Smithsonian Astrophysical Observation", "SAO 38133"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.66787023),
        dec: Angle.Degrees(+50.06577478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54625"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.71269248),
        dec: Angle.Degrees(+50.06629089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29486"},
        {"Hipparcos Number", "HIP 21807"},
        {"Geneva Identification System", "GEN# +1.00029486"},
        {"Smithsonian Astrophysical Observation", "SAO 39687"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.27046055),
        dec: Angle.Degrees(+50.06653650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113621"},
        {"Hipparcos Number", "HIP 63774"},
        {"Geneva Identification System", "GEN# +1.00113621"},
        {"Smithsonian Astrophysical Observation", "SAO 28622"},
        {"Wilson Evans Batten Catalogue", "WEB 11281"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.07924959),
        dec: Angle.Degrees(+50.06825731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203137"},
        {"Hipparcos Number", "HIP 105219"},
        {"Geneva Identification System", "GEN# +1.00203137"},
        {"Smithsonian Astrophysical Observation", "SAO 50701"},
        {"Wilson Evans Batten Catalogue", "WEB 19110"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.68924413),
        dec: Angle.Degrees(+50.06935196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159237"},
        {"Hipparcos Number", "HIP 85717"},
        {"Geneva Identification System", "GEN# +1.00159237"},
        {"Smithsonian Astrophysical Observation", "SAO 30432"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.73799234),
        dec: Angle.Degrees(+50.07024715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214240"},
        {"Hipparcos Number", "HIP 111550"},
        {"Geneva Identification System", "GEN# +1.00214240"},
        {"Smithsonian Astrophysical Observation", "SAO 52171"},
        {"Wilson Evans Batten Catalogue", "WEB 19941"},
    },
    visualMagnitude: 6.29,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.97240330),
        dec: Angle.Degrees(+50.07078796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183123"},
        {"Hipparcos Number", "HIP 95504"},
        {"Geneva Identification System", "GEN# +1.00183123"},
        {"Smithsonian Astrophysical Observation", "SAO 48428"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.37398861),
        dec: Angle.Degrees(+50.07088979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94623",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12240 A"},
        {"Henry Draper", "HD 180756"},
        {"Hipparcos Number", "HIP 94623"},
        {"Smithsonian Astrophysical Observation", "SAO 48247"},
        {"Wilson Evans Batten Catalogue", "WEB 16492"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.82992834),
        dec: Angle.Degrees(+50.07111826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6223"},
        {"Hipparcos Number", "HIP 5001"},
        {"Smithsonian Astrophysical Observation", "SAO 36894"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.01564833),
        dec: Angle.Degrees(+50.07114879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222787"},
        {"Hipparcos Number", "HIP 117021"},
        {"Smithsonian Astrophysical Observation", "SAO 53315"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.84373823),
        dec: Angle.Degrees(+50.07244476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19735"},
        {"Smithsonian Astrophysical Observation", "SAO 39393"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.45543665),
        dec: Angle.Degrees(+50.07312876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102520"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.64057691),
        dec: Angle.Degrees(+50.07494300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146469"},
        {"Hipparcos Number", "HIP 79574"},
        {"Smithsonian Astrophysical Observation", "SAO 29848"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.53807625),
        dec: Angle.Degrees(+50.07578363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13426"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.21884489),
        dec: Angle.Degrees(+50.07587957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52032"},
        {"Hipparcos Number", "HIP 33908"},
        {"Smithsonian Astrophysical Observation", "SAO 26109"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.56448336),
        dec: Angle.Degrees(+50.07699981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157492"},
        {"Hipparcos Number", "HIP 84892"},
        {"Smithsonian Astrophysical Observation", "SAO 30351"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.24761351),
        dec: Angle.Degrees(+50.07758343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101736",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101736"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.31323046),
        dec: Angle.Degrees(+50.08111159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104823"},
        {"Smithsonian Astrophysical Observation", "SAO 50606"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.54432989),
        dec: Angle.Degrees(+50.08157197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24700"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.47506579),
        dec: Angle.Degrees(+50.08250969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139779"},
        {"Hipparcos Number", "HIP 76540"},
        {"Geneva Identification System", "GEN# +1.00139779"},
        {"Smithsonian Astrophysical Observation", "SAO 29598"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.48076663),
        dec: Angle.Degrees(+50.08281849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234743"},
        {"Hipparcos Number", "HIP 92732"},
        {"Smithsonian Astrophysical Observation", "SAO 31248"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.45212161),
        dec: Angle.Degrees(+50.08320867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102517"},
        {"Smithsonian Astrophysical Observation", "SAO 50051"},
    },
    visualMagnitude: 9.05,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.63351580),
        dec: Angle.Degrees(+50.08684839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158869"},
        {"Hipparcos Number", "HIP 85560"},
        {"Smithsonian Astrophysical Observation", "SAO 30415"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.27760559),
        dec: Angle.Degrees(+50.08739299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38286"},
        {"Hipparcos Number", "HIP 27326"},
        {"Smithsonian Astrophysical Observation", "SAO 25376"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.83201638),
        dec: Angle.Degrees(+50.08838420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68521"},
        {"Hipparcos Number", "HIP 40417"},
        {"Smithsonian Astrophysical Observation", "SAO 26740"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.76373582),
        dec: Angle.Degrees(+50.09032165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215025"},
        {"Hipparcos Number", "HIP 112016"},
        {"Smithsonian Astrophysical Observation", "SAO 52266"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.34531543),
        dec: Angle.Degrees(+50.09263278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139456"},
        {"Hipparcos Number", "HIP 76403"},
        {"Smithsonian Astrophysical Observation", "SAO 29591"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.06150906),
        dec: Angle.Degrees(+50.09320220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77234"},
        {"Hipparcos Number", "HIP 44439"},
        {"Geneva Identification System", "GEN# +1.00077234"},
        {"Smithsonian Astrophysical Observation", "SAO 27100"},
        {"Wilson Evans Batten Catalogue", "WEB 8518"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.81357577),
        dec: Angle.Degrees(+50.09428854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20418"},
        {"Hipparcos Number", "HIP 15444"},
        {"Geneva Identification System", "GEN# +5.20200401"},
        {"Smithsonian Astrophysical Observation", "SAO 38714"},
        {"Wilson Evans Batten Catalogue", "WEB 2970"},
    },
    visualMagnitude: 5.05,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.78174379),
        dec: Angle.Degrees(+50.09502752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233622"},
        {"Hipparcos Number", "HIP 45904"},
        {"Geneva Identification System", "GEN# +1.00233622"},
        {"Smithsonian Astrophysical Observation", "SAO 27220"},
        {"Wilson Evans Batten Catalogue", "WEB 8707"},
    },
    visualMagnitude: 9.96,
    bvColour: -0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.38998922),
        dec: Angle.Degrees(+50.09901255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25409"},
        {"Hipparcos Number", "HIP 19031"},
        {"Smithsonian Astrophysical Observation", "SAO 39292"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.15525498),
        dec: Angle.Degrees(+50.10105235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5724"},
        {"Smithsonian Astrophysical Observation", "SAO 37033"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.39831834),
        dec: Angle.Degrees(+50.10324339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132637"},
        {"Hipparcos Number", "HIP 73256"},
        {"Smithsonian Astrophysical Observation", "SAO 29363"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.57661235),
        dec: Angle.Degrees(+50.10429710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98571",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13278 A"},
        {"Henry Draper", "HD 190147"},
        {"Hipparcos Number", "HIP 98571"},
        {"Geneva Identification System", "GEN# +1.00190147"},
        {"Smithsonian Astrophysical Observation", "SAO 49098"},
        {"Wilson Evans Batten Catalogue", "WEB 17425"},
    },
    visualMagnitude: 5.06,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.33978531),
        dec: Angle.Degrees(+50.10467998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233750"},
        {"Hipparcos Number", "HIP 51796"},
        {"Smithsonian Astrophysical Observation", "SAO 27694"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.74423838),
        dec: Angle.Degrees(+50.10885538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86942"},
        {"Hipparcos Number", "HIP 49253"},
        {"Smithsonian Astrophysical Observation", "SAO 27494"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.80711232),
        dec: Angle.Degrees(+50.10924900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1560"},
        {"Hipparcos Number", "HIP 1604"},
        {"Smithsonian Astrophysical Observation", "SAO 36271"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.02251249),
        dec: Angle.Degrees(+50.11180669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
