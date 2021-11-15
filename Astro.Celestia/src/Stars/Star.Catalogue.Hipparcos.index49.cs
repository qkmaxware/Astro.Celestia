using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_49() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80842",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10083 A"},
        {"Henry Draper", "HD 148700"},
        {"Hipparcos Number", "HIP 80842"},
        {"Geneva Identification System", "GEN# +1.00148700"},
        {"Smithsonian Astrophysical Observation", "SAO 159956"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.63357215),
        dec: Angle.Degrees(-14.54600310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116971",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16944 A"},
        {"Henry Draper", "HD 222661"},
        {"Hipparcos Number", "HIP 116971"},
        {"Celescope Catalog", "CEL 5654"},
        {"Fundamental Katalog 5th Edition", "FK5 894"},
        {"Geneva Identification System", "GEN# +1.00222661"},
        {"Smithsonian Astrophysical Observation", "SAO 165842"},
        {"Wilson Evans Batten Catalogue", "WEB 20632"},
    },
    visualMagnitude: 4.49,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.68035357),
        dec: Angle.Degrees(-14.54474243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141439"},
        {"Hipparcos Number", "HIP 77510"},
        {"Geneva Identification System", "GEN# +1.00141439"},
        {"Smithsonian Astrophysical Observation", "SAO 159514"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.39516033),
        dec: Angle.Degrees(-14.54075037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219388"},
        {"Hipparcos Number", "HIP 114819"},
        {"Smithsonian Astrophysical Observation", "SAO 165590"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.87409043),
        dec: Angle.Degrees(-14.53913849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99331"},
        {"Hipparcos Number", "HIP 55777"},
        {"Smithsonian Astrophysical Observation", "SAO 156670"},
        {"Wilson Evans Batten Catalogue", "WEB 10023"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.42666403),
        dec: Angle.Degrees(-14.53732282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215542"},
        {"Hipparcos Number", "HIP 112409"},
        {"Smithsonian Astrophysical Observation", "SAO 165280"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.52174818),
        dec: Angle.Degrees(-14.53631191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104946"},
        {"Hipparcos Number", "HIP 58934"},
        {"Smithsonian Astrophysical Observation", "SAO 157079"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.25852352),
        dec: Angle.Degrees(-14.53075905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139327"},
        {"Hipparcos Number", "HIP 76545"},
        {"Geneva Identification System", "GEN# +1.00139327"},
        {"Smithsonian Astrophysical Observation", "SAO 159398"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.49963701),
        dec: Angle.Degrees(-14.53034420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47961"},
        {"Cincinnati Publication", "Ci 18 1161"},
        {"Geneva Identification System", "GEN# -0.01302948"},
        {"Smithsonian Astrophysical Observation", "SAO 155468"},
        {"Wilson Evans Batten Catalogue", "WEB 8971"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.60891805),
        dec: Angle.Degrees(-14.52972028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -257.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 173.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125324"},
        {"Hipparcos Number", "HIP 69970"},
        {"Geneva Identification System", "GEN# +1.00125324"},
        {"Smithsonian Astrophysical Observation", "SAO 158487"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.77072124),
        dec: Angle.Degrees(-14.52886472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77106"},
        {"Hipparcos Number", "HIP 44182"},
        {"Geneva Identification System", "GEN# +1.00077106"},
        {"Smithsonian Astrophysical Observation", "SAO 154818"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.00585288),
        dec: Angle.Degrees(-14.52863477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76743",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9738 AB"},
        {"Henry Draper", "HD 139728"},
        {"Hipparcos Number", "HIP 76743"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.07225569),
        dec: Angle.Degrees(-14.52784241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182500"},
        {"Hipparcos Number", "HIP 95488"},
        {"Smithsonian Astrophysical Observation", "SAO 162597"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.34730858),
        dec: Angle.Degrees(-14.52587932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60414"},
        {"Henry Draper 2", "HD 60415"},
        {"Hipparcos Number", "HIP 36773"},
        {"Celescope Catalog", "CEL 1927"},
        {"Geneva Identification System", "GEN# +2.24220009"},
        {"Smithsonian Astrophysical Observation", "SAO 153072"},
        {"Wilson Evans Batten Catalogue", "WEB 7308"},
        {"New General Catalogue", "NGC 2422 9"},
    },
    visualMagnitude: 4.82,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.44986614),
        dec: Angle.Degrees(-14.52390109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49148"},
        {"Hipparcos Number", "HIP 32466"},
        {"Smithsonian Astrophysical Observation", "SAO 151909"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.63755207),
        dec: Angle.Degrees(-14.52375613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102447"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.39392939),
        dec: Angle.Degrees(-14.52082523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65226"},
        {"Hipparcos Number", "HIP 38866"},
        {"Smithsonian Astrophysical Observation", "SAO 153626"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.31165494),
        dec: Angle.Degrees(-14.51847859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139408"},
        {"Hipparcos Number", "HIP 76586"},
        {"Smithsonian Astrophysical Observation", "SAO 159406"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.62131083),
        dec: Angle.Degrees(-14.51666183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207138"},
        {"Hipparcos Number", "HIP 107567"},
        {"Geneva Identification System", "GEN# +1.00207138"},
        {"Smithsonian Astrophysical Observation", "SAO 164647"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.79289545),
        dec: Angle.Degrees(-14.51384663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38278"},
        {"Hipparcos Number", "HIP 27044"},
        {"Geneva Identification System", "GEN# +1.00038278"},
        {"Smithsonian Astrophysical Observation", "SAO 150747"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.02742265),
        dec: Angle.Degrees(-14.51180702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102061",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14145 AB"},
        {"Henry Draper", "HD 196946"},
        {"Hipparcos Number", "HIP 102061"},
        {"Smithsonian Astrophysical Observation", "SAO 163793"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.25079256),
        dec: Angle.Degrees(-14.51141609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218639"},
        {"Hipparcos Number", "HIP 114371"},
        {"Fundamental Katalog 5th Edition", "FK5 3856"},
        {"Geneva Identification System", "GEN# +1.00218639"},
        {"Smithsonian Astrophysical Observation", "SAO 165522"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.45638262),
        dec: Angle.Degrees(-14.51053630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56367"},
        {"Hipparcos Number", "HIP 35164"},
        {"Celescope Catalog", "CEL 1726"},
        {"Geneva Identification System", "GEN# +1.00056367"},
        {"Smithsonian Astrophysical Observation", "SAO 152636"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.02489851),
        dec: Angle.Degrees(-14.51000584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208803"},
        {"Hipparcos Number", "HIP 108529"},
        {"Smithsonian Astrophysical Observation", "SAO 164789"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.79360439),
        dec: Angle.Degrees(-14.50962983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98090"},
        {"Hipparcos Number", "HIP 55095"},
        {"Smithsonian Astrophysical Observation", "SAO 156579"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.20219096),
        dec: Angle.Degrees(-14.50830990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6267"},
        {"Hipparcos Number", "HIP 4951"},
        {"Smithsonian Astrophysical Observation", "SAO 147585"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.87360704),
        dec: Angle.Degrees(-14.50735646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34309"},
        {"Hipparcos Number", "HIP 24553"},
        {"Smithsonian Astrophysical Observation", "SAO 150282"},
        {"Wilson Evans Batten Catalogue", "WEB 4754"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.00330087),
        dec: Angle.Degrees(-14.50556967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45110"},
        {"Hipparcos Number", "HIP 30530"},
        {"Smithsonian Astrophysical Observation", "SAO 151473"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.25682863),
        dec: Angle.Degrees(-14.50368970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34302"},
    },
    visualMagnitude: 12.65,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.67204180),
        dec: Angle.Degrees(-14.50174590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180538"},
        {"Hipparcos Number", "HIP 94807"},
        {"Fundamental Katalog 5th Edition", "FK5 5697"},
        {"Smithsonian Astrophysical Observation", "SAO 162411"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.36724996),
        dec: Angle.Degrees(-14.50136494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41125"},
        {"Hipparcos Number", "HIP 28622"},
        {"Geneva Identification System", "GEN# +1.00041125"},
        {"Smithsonian Astrophysical Observation", "SAO 151052"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.64085530),
        dec: Angle.Degrees(-14.49718594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36981",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6208 A"},
        {"Henry Draper", "HD 60855"},
        {"Hipparcos Number", "HIP 36981"},
        {"Celescope Catalog", "CEL 1942"},
        {"Geneva Identification System", "GEN# +2.24220045"},
        {"Smithsonian Astrophysical Observation", "SAO 153118"},
        {"Wilson Evans Batten Catalogue", "WEB 7338"},
        {"New General Catalogue", "NGC 2422 45"},
    },
    visualMagnitude: 5.66,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.01623979),
        dec: Angle.Degrees(-14.49277322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9399"},
        {"Hipparcos Number", "HIP 7152"},
        {"Geneva Identification System", "GEN# +1.00009399"},
        {"Smithsonian Astrophysical Observation", "SAO 147868"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.05295011),
        dec: Angle.Degrees(-14.49237540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55493"},
        {"Hipparcos Number", "HIP 34832"},
        {"Geneva Identification System", "GEN# +1.00055493"},
        {"Smithsonian Astrophysical Observation", "SAO 152556"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.13563782),
        dec: Angle.Degrees(-14.49182983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10584"},
        {"Hipparcos Number", "HIP 8022"},
        {"Smithsonian Astrophysical Observation", "SAO 147974"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.75363531),
        dec: Angle.Degrees(-14.49150393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77332"},
        {"Hipparcos Number", "HIP 44320"},
        {"Smithsonian Astrophysical Observation", "SAO 154846"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.38980795),
        dec: Angle.Degrees(-14.49111048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210000"},
        {"Hipparcos Number", "HIP 109220"},
        {"Smithsonian Astrophysical Observation", "SAO 164868"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.89691304),
        dec: Angle.Degrees(-14.49069019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219528"},
        {"Hipparcos Number", "HIP 114912"},
        {"Smithsonian Astrophysical Observation", "SAO 165598"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.13469423),
        dec: Angle.Degrees(-14.49063747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224745"},
        {"Hipparcos Number", "HIP 35"},
        {"Smithsonian Astrophysical Observation", "SAO 165994"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.10256052),
        dec: Angle.Degrees(-14.49048072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81659"},
        {"Hipparcos Number", "HIP 46324"},
        {"Geneva Identification System", "GEN# +1.00081659"},
        {"Smithsonian Astrophysical Observation", "SAO 155191"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.67837838),
        dec: Angle.Degrees(-14.49042864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91430"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.68616017),
        dec: Angle.Degrees(-14.48917969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -569.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46127"},
        {"Hipparcos Number", "HIP 31055"},
        {"Smithsonian Astrophysical Observation", "SAO 151595"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.74925739),
        dec: Angle.Degrees(-14.48897723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15245"},
        {"Hipparcos Number", "HIP 11404"},
        {"Smithsonian Astrophysical Observation", "SAO 148394"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.73926957),
        dec: Angle.Degrees(-14.48509782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27517",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4432 AB"},
        {"Henry Draper", "HD 39070"},
        {"Hipparcos Number", "HIP 27517"},
        {"Geneva Identification System", "GEN# +1.00039070"},
        {"Smithsonian Astrophysical Observation", "SAO 150845"},
        {"Wilson Evans Batten Catalogue", "WEB 5404"},
    },
    visualMagnitude: 5.49,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.40231190),
        dec: Angle.Degrees(-14.48354987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199603"},
        {"Hipparcos Number", "HIP 103545"},
        {"Geneva Identification System", "GEN# +1.00199603"},
        {"Renson", "Renson 55606"},
        {"Smithsonian Astrophysical Observation", "SAO 164027"},
        {"Wilson Evans Batten Catalogue", "WEB 18838"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.67447074),
        dec: Angle.Degrees(-14.48308081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106753"},
        {"Hipparcos Number", "HIP 59862"},
        {"Geneva Identification System", "GEN# +1.00106753"},
        {"Smithsonian Astrophysical Observation", "SAO 157182"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.15020447),
        dec: Angle.Degrees(-14.48127596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104455"},
        {"Hipparcos Number", "HIP 58668"},
        {"Smithsonian Astrophysical Observation", "SAO 157049"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.44202389),
        dec: Angle.Degrees(-14.47928527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23737"},
        {"Hipparcos Number", "HIP 17659"},
        {"Smithsonian Astrophysical Observation", "SAO 149166"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.73392046),
        dec: Angle.Degrees(-14.47828899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48238"},
        {"Hipparcos Number", "HIP 32052"},
        {"Smithsonian Astrophysical Observation", "SAO 151800"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.45180230),
        dec: Angle.Degrees(-14.47439686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38698"},
        {"Hipparcos Number", "HIP 27299"},
        {"Geneva Identification System", "GEN# +1.00038698"},
        {"Renson", "Renson 10400"},
        {"Smithsonian Astrophysical Observation", "SAO 150805"},
    },
    visualMagnitude: 9.11,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.76202198),
        dec: Angle.Degrees(-14.47410743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201707"},
        {"Hipparcos Number", "HIP 104634"},
        {"Fundamental Katalog 5th Edition", "FK5 5868"},
        {"Geneva Identification System", "GEN# +1.00201707"},
        {"Renson", "Renson 56250"},
        {"Smithsonian Astrophysical Observation", "SAO 164204"},
        {"Wilson Evans Batten Catalogue", "WEB 19037"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.92214429),
        dec: Angle.Degrees(-14.47237788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56901",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8259 A"},
        {"Henry Draper", "HD 101369"},
        {"Hipparcos Number", "HIP 56901"},
        {"Fundamental Katalog 5th Edition", "FK5 2934"},
        {"Geneva Identification System", "GEN# +1.00101369J"},
        {"Smithsonian Astrophysical Observation", "SAO 156820"},
    },
    visualMagnitude: 6.21,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.96309750),
        dec: Angle.Degrees(-14.46851213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205002"},
        {"Hipparcos Number", "HIP 106374"},
        {"Geneva Identification System", "GEN# +1.00205002"},
        {"Smithsonian Astrophysical Observation", "SAO 164466"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.16782315),
        dec: Angle.Degrees(-14.46769708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149216"},
        {"Hipparcos Number", "HIP 81098"},
        {"Smithsonian Astrophysical Observation", "SAO 159978"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.46302520),
        dec: Angle.Degrees(-14.46657422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90792"},
        {"Hipparcos Number", "HIP 51305"},
        {"Smithsonian Astrophysical Observation", "SAO 156006"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.19306083),
        dec: Angle.Degrees(-14.46563225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173614"},
        {"Hipparcos Number", "HIP 92140"},
        {"Cincinnati Publication", "Ci 18 2454"},
        {"Smithsonian Astrophysical Observation", "SAO 161816"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.69324494),
        dec: Angle.Degrees(-14.46473137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -267.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12966"},
        {"Hipparcos Number", "HIP 9837"},
        {"Smithsonian Astrophysical Observation", "SAO 148206"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.64402278),
        dec: Angle.Degrees(-14.46381613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112575"},
        {"Henry Draper 2", "HD 112575A"},
        {"Hipparcos Number", "HIP 63257"},
        {"Geneva Identification System", "GEN# +1.00112575"},
        {"Smithsonian Astrophysical Observation", "SAO 157623"},
        {"Wilson Evans Batten Catalogue", "WEB 11213"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.43402980),
        dec: Angle.Degrees(-14.46356844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -348.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12684"},
        {"Hipparcos Number", "HIP 9637"},
        {"Smithsonian Astrophysical Observation", "SAO 148177"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.96390520),
        dec: Angle.Degrees(-14.46236138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62976"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.56339216),
        dec: Angle.Degrees(-14.46171182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9567"},
        {"Smithsonian Astrophysical Observation", "SAO 148167"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.73129593),
        dec: Angle.Degrees(-14.46022549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142963"},
        {"Hipparcos Number", "HIP 78204"},
        {"Geneva Identification System", "GEN# +1.00142963"},
        {"Smithsonian Astrophysical Observation", "SAO 159606"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.53368703),
        dec: Angle.Degrees(-14.45980882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101330",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101330"},
        {"Smithsonian Astrophysical Observation", "SAO 163662"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.06571422),
        dec: Angle.Degrees(-14.45831479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212009"},
        {"Hipparcos Number", "HIP 110388"},
        {"Smithsonian Astrophysical Observation", "SAO 165019"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.38932374),
        dec: Angle.Degrees(-14.45689359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72892"},
        {"Hipparcos Number", "HIP 42098"},
        {"Smithsonian Astrophysical Observation", "SAO 154423"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.71891279),
        dec: Angle.Degrees(-14.45628376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42745"},
        {"Hipparcos Number", "HIP 29419"},
        {"Geneva Identification System", "GEN# +1.00042745"},
        {"Smithsonian Astrophysical Observation", "SAO 151210"},
        {"Wilson Evans Batten Catalogue", "WEB 5779"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.96831123),
        dec: Angle.Degrees(-14.45443283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167837"},
        {"Hipparcos Number", "HIP 89634"},
        {"Smithsonian Astrophysical Observation", "SAO 161272"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.37967707),
        dec: Angle.Degrees(-14.45247455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 604"},
        {"Hipparcos Number", "HIP 851"},
        {"Geneva Identification System", "GEN# +1.00000604"},
        {"Smithsonian Astrophysical Observation", "SAO 147125"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.60951431),
        dec: Angle.Degrees(-14.45220836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108522"},
        {"Hipparcos Number", "HIP 60821"},
        {"Smithsonian Astrophysical Observation", "SAO 157303"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.00753543),
        dec: Angle.Degrees(-14.45085524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50876"},
        {"Hipparcos Number", "HIP 33186"},
        {"Smithsonian Astrophysical Observation", "SAO 152078"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.60720754),
        dec: Angle.Degrees(-14.45080522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30092"},
        {"Hipparcos Number", "HIP 22014"},
        {"Smithsonian Astrophysical Observation", "SAO 149851"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.98330048),
        dec: Angle.Degrees(-14.44951794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16723"},
        {"Hipparcos Number", "HIP 12460"},
        {"Geneva Identification System", "GEN# +1.00016723"},
        {"Renson", "Renson 4200"},
        {"Smithsonian Astrophysical Observation", "SAO 148538"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.11059490),
        dec: Angle.Degrees(-14.44916077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217022"},
        {"Hipparcos Number", "HIP 113378"},
        {"Smithsonian Astrophysical Observation", "SAO 165404"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.43056669),
        dec: Angle.Degrees(-14.44844461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209532"},
        {"Hipparcos Number", "HIP 108958"},
        {"Smithsonian Astrophysical Observation", "SAO 164844"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.11622245),
        dec: Angle.Degrees(-14.44695301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94454",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12168 AB"},
        {"Henry Draper", "HD 179518"},
        {"Hipparcos Number", "HIP 94454"},
        {"Geneva Identification System", "GEN# +1.00179518J"},
        {"Smithsonian Astrophysical Observation", "SAO 162329"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.35760062),
        dec: Angle.Degrees(-14.44691405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219280"},
        {"Hipparcos Number", "HIP 114754"},
        {"Smithsonian Astrophysical Observation", "SAO 165579"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.67721950),
        dec: Angle.Degrees(-14.44631310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218175"},
        {"Hipparcos Number", "HIP 114058"},
        {"Geneva Identification System", "GEN# +1.00218175"},
        {"Smithsonian Astrophysical Observation", "SAO 165490"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.48527858),
        dec: Angle.Degrees(-14.44471222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33010"},
        {"Hipparcos Number", "HIP 23791"},
        {"Smithsonian Astrophysical Observation", "SAO 150152"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.68357715),
        dec: Angle.Degrees(-14.44456650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61017"},
        {"Hipparcos Number", "HIP 37037"},
        {"Geneva Identification System", "GEN# +2.24220083"},
        {"Smithsonian Astrophysical Observation", "SAO 153145"},
        {"New General Catalogue", "NGC 2422 83"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.17190034),
        dec: Angle.Degrees(-14.44361943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20239"},
        {"Hipparcos Number", "HIP 15104"},
        {"Smithsonian Astrophysical Observation", "SAO 148855"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.70776648),
        dec: Angle.Degrees(-14.44323082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61224"},
        {"Hipparcos Number", "HIP 37119"},
        {"Geneva Identification System", "GEN# +2.24220125"},
        {"Smithsonian Astrophysical Observation", "SAO 153172"},
        {"Wilson Evans Batten Catalogue", "WEB 7360"},
        {"New General Catalogue", "NGC 2422 125"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.41168716),
        dec: Angle.Degrees(-14.44076528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68360"},
        {"Hipparcos Number", "HIP 40100"},
        {"Smithsonian Astrophysical Observation", "SAO 153946"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.87568516),
        dec: Angle.Degrees(-14.43814057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77677"},
        {"Hipparcos Number", "HIP 44468"},
        {"Fundamental Katalog 5th Edition", "FK5 4806"},
        {"Smithsonian Astrophysical Observation", "SAO 154870"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.90143937),
        dec: Angle.Degrees(-14.43741430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211234"},
        {"Hipparcos Number", "HIP 109943"},
        {"Geneva Identification System", "GEN# +1.00211234"},
        {"Smithsonian Astrophysical Observation", "SAO 164962"},
        {"Wilson Evans Batten Catalogue", "WEB 19736"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.00287584),
        dec: Angle.Degrees(-14.43595951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166897"},
        {"Hipparcos Number", "HIP 89292"},
        {"Smithsonian Astrophysical Observation", "SAO 161194"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.30902741),
        dec: Angle.Degrees(-14.43530947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34673"},
        {"Cincinnati Publication", "Ci 20 413"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.70776512),
        dec: Angle.Degrees(-14.43377333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -471.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 303.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43487"},
        {"Hipparcos Number", "HIP 29754"},
        {"Smithsonian Astrophysical Observation", "SAO 151289"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.98576865),
        dec: Angle.Degrees(-14.43351392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 492"},
        {"Smithsonian Astrophysical Observation", "SAO 147080"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.47853237),
        dec: Angle.Degrees(-14.43272890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216310"},
        {"Hipparcos Number", "HIP 112920"},
        {"Smithsonian Astrophysical Observation", "SAO 165343"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.02379012),
        dec: Angle.Degrees(-14.43207703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1015"},
        {"Hipparcos Number", "HIP 1161"},
        {"Geneva Identification System", "GEN# +1.00001015"},
        {"Smithsonian Astrophysical Observation", "SAO 147167"},
        {"Wilson Evans Batten Catalogue", "WEB 206"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.61695916),
        dec: Angle.Degrees(-14.43147791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184918"},
        {"Hipparcos Number", "HIP 96506"},
        {"Smithsonian Astrophysical Observation", "SAO 162822"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.29604682),
        dec: Angle.Degrees(-14.43128113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21718"},
        {"Hipparcos Number", "HIP 16270"},
        {"Smithsonian Astrophysical Observation", "SAO 148988"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.44020387),
        dec: Angle.Degrees(-14.42837496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49229"},
        {"Hipparcos Number", "HIP 32492"},
        {"Celescope Catalog", "CEL 1385"},
        {"Geneva Identification System", "GEN# +1.00049229"},
        {"Smithsonian Astrophysical Observation", "SAO 151919"},
        {"Wilson Evans Batten Catalogue", "WEB 6553"},
    },
    visualMagnitude: 5.28,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.71289080),
        dec: Angle.Degrees(-14.42599569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171184"},
        {"Hipparcos Number", "HIP 91001"},
        {"Renson", "Renson 47930"},
        {"Smithsonian Astrophysical Observation", "SAO 161606"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.46167109),
        dec: Angle.Degrees(-14.42576974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77358"},
        {"Hipparcos Number", "HIP 44328"},
        {"Smithsonian Astrophysical Observation", "SAO 154848"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.41517207),
        dec: Angle.Degrees(-14.42546997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102602",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102602"},
        {"Wilson Evans Batten Catalogue", "WEB 18593"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.89407908),
        dec: Angle.Degrees(-14.42533883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -300.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -277.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2649"},
        {"Hipparcos Number", "HIP 2351"},
        {"Smithsonian Astrophysical Observation", "SAO 147309"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.50011907),
        dec: Angle.Degrees(-14.42364581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143470"},
        {"Hipparcos Number", "HIP 78458"},
        {"Geneva Identification System", "GEN# +1.00143470"},
        {"Smithsonian Astrophysical Observation", "SAO 159634"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.25981636),
        dec: Angle.Degrees(-14.42335221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16712"},
        {"Hipparcos Number", "HIP 12455"},
        {"Smithsonian Astrophysical Observation", "SAO 148537"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.09360731),
        dec: Angle.Degrees(-14.42283931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48"},
        {"Hipparcos Number", "HIP 454"},
        {"Smithsonian Astrophysical Observation", "SAO 147073"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.36004465),
        dec: Angle.Degrees(-14.42209198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6978"},
        {"Hipparcos Number", "HIP 5475"},
        {"Geneva Identification System", "GEN# +1.00006978"},
        {"Smithsonian Astrophysical Observation", "SAO 147648"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.52870276),
        dec: Angle.Degrees(-14.42043560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198837"},
        {"Hipparcos Number", "HIP 103117"},
        {"Geneva Identification System", "GEN# +1.00198837"},
        {"Smithsonian Astrophysical Observation", "SAO 163957"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.39196167),
        dec: Angle.Degrees(-14.42042440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222870"},
        {"Hipparcos Number", "HIP 117106"},
        {"Geneva Identification System", "GEN# +1.00222870"},
        {"Smithsonian Astrophysical Observation", "SAO 165857"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.11952254),
        dec: Angle.Degrees(-14.41994640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116177"},
        {"Hipparcos Number", "HIP 65235"},
        {"Smithsonian Astrophysical Observation", "SAO 157885"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.52666259),
        dec: Angle.Degrees(-14.41976449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14505"},
        {"Hipparcos Number", "HIP 10889"},
        {"Smithsonian Astrophysical Observation", "SAO 148338"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.03194616),
        dec: Angle.Degrees(-14.41864774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72474"},
        {"Hipparcos Number", "HIP 41899"},
        {"Smithsonian Astrophysical Observation", "SAO 154374"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.15673174),
        dec: Angle.Degrees(-14.41797464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111311"},
        {"Hipparcos Number", "HIP 62508"},
        {"Smithsonian Astrophysical Observation", "SAO 157521"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.15408452),
        dec: Angle.Degrees(-14.41708927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66834"},
        {"Smithsonian Astrophysical Observation", "SAO 158097"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.46424654),
        dec: Angle.Degrees(-14.41597274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30538",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5049 AB"},
        {"Henry Draper", "HD 45142"},
        {"Hipparcos Number", "HIP 30538"},
        {"Smithsonian Astrophysical Observation", "SAO 151479"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.29550254),
        dec: Angle.Degrees(-14.41516191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19792"},
        {"Hipparcos Number", "HIP 14762"},
        {"Smithsonian Astrophysical Observation", "SAO 148808"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.66005360),
        dec: Angle.Degrees(-14.41357443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15016"},
        {"Hipparcos Number", "HIP 11246"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.19958020),
        dec: Angle.Degrees(-14.41328961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7792"},
        {"Hipparcos Number", "HIP 6028"},
        {"Smithsonian Astrophysical Observation", "SAO 147719"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.36075584),
        dec: Angle.Degrees(-14.40792300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125357"},
        {"Hipparcos Number", "HIP 69987"},
        {"Smithsonian Astrophysical Observation", "SAO 158493"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.81201431),
        dec: Angle.Degrees(-14.40785397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107040"},
        {"Hipparcos Number", "HIP 60022"},
        {"Geneva Identification System", "GEN# +1.00107040"},
        {"Smithsonian Astrophysical Observation", "SAO 157202"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.64765724),
        dec: Angle.Degrees(-14.40718012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76390"},
        {"Hipparcos Number", "HIP 43821"},
        {"Smithsonian Astrophysical Observation", "SAO 154752"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.86563177),
        dec: Angle.Degrees(-14.40589630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26939"},
        {"Hipparcos Number", "HIP 19817"},
        {"Smithsonian Astrophysical Observation", "SAO 149486"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.74557413),
        dec: Angle.Degrees(-14.40545861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7379"},
        {"Smithsonian Astrophysical Observation", "SAO 147890"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.77412852),
        dec: Angle.Degrees(-14.40485991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202333"},
        {"Hipparcos Number", "HIP 104944"},
        {"Smithsonian Astrophysical Observation", "SAO 164259"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.87196187),
        dec: Angle.Degrees(-14.40167116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223559"},
        {"Hipparcos Number", "HIP 117567"},
        {"Geneva Identification System", "GEN# +1.00223559"},
        {"Smithsonian Astrophysical Observation", "SAO 165915"},
        {"Wilson Evans Batten Catalogue", "WEB 20701"},
    },
    visualMagnitude: 5.70,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.63859626),
        dec: Angle.Degrees(-14.40143843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206561"},
        {"Hipparcos Number", "HIP 107232"},
        {"Geneva Identification System", "GEN# +1.00206561"},
        {"Renson", "Renson 57490"},
        {"Smithsonian Astrophysical Observation", "SAO 164600"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.76833446),
        dec: Angle.Degrees(-14.39975885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190032"},
        {"Hipparcos Number", "HIP 98759"},
        {"Smithsonian Astrophysical Observation", "SAO 163214"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.88507540),
        dec: Angle.Degrees(-14.39922872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142640"},
        {"Hipparcos Number", "HIP 78059"},
        {"Geneva Identification System", "GEN# +1.00142640"},
        {"Smithsonian Astrophysical Observation", "SAO 159584"},
        {"Wilson Evans Batten Catalogue", "WEB 13200"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.06002430),
        dec: Angle.Degrees(-14.39921453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19223"},
        {"Hipparcos Number", "HIP 14351"},
        {"Geneva Identification System", "GEN# +1.00019223"},
        {"Smithsonian Astrophysical Observation", "SAO 148753"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.26884356),
        dec: Angle.Degrees(-14.39874931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218120"},
        {"Hipparcos Number", "HIP 114035"},
        {"Smithsonian Astrophysical Observation", "SAO 165485"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.39786556),
        dec: Angle.Degrees(-14.39812907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35179"},
        {"Hipparcos Number", "HIP 25096"},
        {"Geneva Identification System", "GEN# +1.00035179"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.58754975),
        dec: Angle.Degrees(-14.39719277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8735"},
        {"Smithsonian Astrophysical Observation", "SAO 148074"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.09612125),
        dec: Angle.Degrees(-14.39663241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18986"},
        {"Hipparcos Number", "HIP 14177"},
        {"Smithsonian Astrophysical Observation", "SAO 148733"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.70685313),
        dec: Angle.Degrees(-14.39642677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219984"},
        {"Hipparcos Number", "HIP 115225"},
        {"Smithsonian Astrophysical Observation", "SAO 165635"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.08068091),
        dec: Angle.Degrees(-14.39555082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174088"},
        {"Hipparcos Number", "HIP 92355"},
        {"Geneva Identification System", "GEN# +1.00174088"},
        {"Smithsonian Astrophysical Observation", "SAO 161868"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.34077704),
        dec: Angle.Degrees(-14.39460802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87017"},
        {"Hipparcos Number", "HIP 49159"},
        {"Smithsonian Astrophysical Observation", "SAO 155670"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.49177681),
        dec: Angle.Degrees(-14.39283658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78969"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.81378668),
        dec: Angle.Degrees(-14.39279512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121926"},
        {"Hipparcos Number", "HIP 68291"},
        {"Smithsonian Astrophysical Observation", "SAO 158271"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.69056168),
        dec: Angle.Degrees(-14.39198015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86224"},
        {"Hipparcos Number", "HIP 48767"},
        {"Smithsonian Astrophysical Observation", "SAO 155609"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.20205506),
        dec: Angle.Degrees(-14.39070049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91319"},
        {"Hipparcos Number", "HIP 51600"},
        {"Smithsonian Astrophysical Observation", "SAO 156046"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.10960564),
        dec: Angle.Degrees(-14.39064105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49647"},
        {"Hipparcos Number", "HIP 32672"},
        {"Smithsonian Astrophysical Observation", "SAO 151958"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.21515679),
        dec: Angle.Degrees(-14.38922747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168814"},
        {"Hipparcos Number", "HIP 90034"},
        {"Geneva Identification System", "GEN# +1.00168814"},
        {"Renson", "Renson 47320"},
        {"Smithsonian Astrophysical Observation", "SAO 161391"},
        {"Wilson Evans Batten Catalogue", "WEB 15386"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.56655684),
        dec: Angle.Degrees(-14.38869446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52892"},
        {"Hipparcos Number", "HIP 33918"},
        {"Celescope Catalog", "CEL 1520"},
        {"Geneva Identification System", "GEN# +1.00052892"},
        {"Smithsonian Astrophysical Observation", "SAO 152273"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.57664805),
        dec: Angle.Degrees(-14.38686336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9930"},
        {"Hipparcos Number", "HIP 7519"},
        {"Geneva Identification System", "GEN# +1.00009930"},
        {"Smithsonian Astrophysical Observation", "SAO 147906"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.20478561),
        dec: Angle.Degrees(-14.38530588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202956"},
        {"Hipparcos Number", "HIP 105287"},
        {"Smithsonian Astrophysical Observation", "SAO 164305"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.88980080),
        dec: Angle.Degrees(-14.38402117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145331"},
        {"Hipparcos Number", "HIP 79296"},
        {"Geneva Identification System", "GEN# +1.00145331"},
        {"Smithsonian Astrophysical Observation", "SAO 159755"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.74445429),
        dec: Angle.Degrees(-14.38389413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126779"},
        {"Hipparcos Number", "HIP 70739"},
        {"Smithsonian Astrophysical Observation", "SAO 158581"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.99685655),
        dec: Angle.Degrees(-14.38228403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27880"},
        {"Cincinnati Publication", "Ci 20 357"},
        {"Geneva Identification System", "GEN# +6.10220797"},
        {"Wilson Evans Batten Catalogue", "WEB 5458"},
    },
    visualMagnitude: 11.46,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.49485735),
        dec: Angle.Degrees(-14.38041405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -434.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26784"},
        {"Smithsonian Astrophysical Observation", "SAO 150697"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.34040765),
        dec: Angle.Degrees(-14.37988886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94374"},
        {"Hipparcos Number", "HIP 53236"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.34483321),
        dec: Angle.Degrees(-14.37374001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -427.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -313.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76849"},
        {"Hipparcos Number", "HIP 44059"},
        {"Smithsonian Astrophysical Observation", "SAO 154800"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.59366649),
        dec: Angle.Degrees(-14.37348138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153135"},
        {"Hipparcos Number", "HIP 83045"},
        {"Smithsonian Astrophysical Observation", "SAO 160195"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.53963438),
        dec: Angle.Degrees(-14.37246423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152145"},
        {"Hipparcos Number", "HIP 82535"},
        {"Smithsonian Astrophysical Observation", "SAO 160137"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.06226813),
        dec: Angle.Degrees(-14.37043428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32612"},
        {"Hipparcos Number", "HIP 23551"},
        {"Geneva Identification System", "GEN# +1.00032612"},
        {"Smithsonian Astrophysical Observation", "SAO 150109"},
        {"Wilson Evans Batten Catalogue", "WEB 4589"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.96718238),
        dec: Angle.Degrees(-14.37023813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82323"},
    },
    visualMagnitude: 11.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.31378369),
        dec: Angle.Degrees(-14.36900913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43038",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6989 AB"},
        {"Henry Draper", "HD 74861"},
        {"Hipparcos Number", "HIP 43038"},
        {"Smithsonian Astrophysical Observation", "SAO 154618"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.53764108),
        dec: Angle.Degrees(-14.36781602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16124",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2551 AB"},
        {"Henry Draper", "HD 21513"},
        {"Hipparcos Number", "HIP 16124"},
        {"Fundamental Katalog 5th Edition", "FK5 4314"},
        {"Smithsonian Astrophysical Observation", "SAO 148969"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.92238527),
        dec: Angle.Degrees(-14.36655478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168917"},
        {"Hipparcos Number", "HIP 90062"},
        {"Geneva Identification System", "GEN# +1.00168917"},
        {"Smithsonian Astrophysical Observation", "SAO 161401"},
        {"Wilson Evans Batten Catalogue", "WEB 15391"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.68630620),
        dec: Angle.Degrees(-14.36348750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23095"},
        {"Hipparcos Number", "HIP 17268"},
        {"Geneva Identification System", "GEN# +1.00023095"},
        {"Smithsonian Astrophysical Observation", "SAO 149120"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.47631332),
        dec: Angle.Degrees(-14.36317974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70300"},
        {"Hipparcos Number", "HIP 40896"},
        {"Geneva Identification System", "GEN# +1.00070300"},
        {"Smithsonian Astrophysical Observation", "SAO 154134"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.18978270),
        dec: Angle.Degrees(-14.36316218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26504"},
        {"Hipparcos Number", "HIP 19523"},
        {"Smithsonian Astrophysical Observation", "SAO 149436"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.74005299),
        dec: Angle.Degrees(-14.36301801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15928"},
        {"Hipparcos Number", "HIP 11881"},
        {"Geneva Identification System", "GEN# +1.00015928"},
        {"Smithsonian Astrophysical Observation", "SAO 148460"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.31427288),
        dec: Angle.Degrees(-14.36282939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52872"},
        {"Hipparcos Number", "HIP 33904"},
        {"Smithsonian Astrophysical Observation", "SAO 152271"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.55151827),
        dec: Angle.Degrees(-14.36223009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45939"},
        {"Hipparcos Number", "HIP 30952"},
        {"Smithsonian Astrophysical Observation", "SAO 151562"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.44474246),
        dec: Angle.Degrees(-14.36202598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89892"},
    },
    visualMagnitude: 10.72,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.13000818),
        dec: Angle.Degrees(-14.36112443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57478"},
        {"Hipparcos Number", "HIP 35615"},
        {"Geneva Identification System", "GEN# +1.00057478"},
        {"Smithsonian Astrophysical Observation", "SAO 152749"},
        {"Wilson Evans Batten Catalogue", "WEB 7098"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.24288294),
        dec: Angle.Degrees(-14.36048847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43971"},
        {"Hipparcos Number", "HIP 29973"},
        {"Smithsonian Astrophysical Observation", "SAO 151338"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.64909991),
        dec: Angle.Degrees(-14.35982826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129786"},
        {"Hipparcos Number", "HIP 72090"},
        {"Geneva Identification System", "GEN# +1.00129786"},
        {"Smithsonian Astrophysical Observation", "SAO 158771"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.21451819),
        dec: Angle.Degrees(-14.35960808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29613"},
        {"Hipparcos Number", "HIP 21685"},
        {"Geneva Identification System", "GEN# +1.00029613"},
        {"Smithsonian Astrophysical Observation", "SAO 149797"},
        {"Wilson Evans Batten Catalogue", "WEB 4168"},
    },
    visualMagnitude: 5.46,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.83182532),
        dec: Angle.Degrees(-14.35888729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10072"},
    },
    visualMagnitude: 11.78,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.39926138),
        dec: Angle.Degrees(-14.35821908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 518.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -353.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59544"},
        {"Hipparcos Number", "HIP 36435"},
        {"Geneva Identification System", "GEN# +1.00059544"},
        {"Smithsonian Astrophysical Observation", "SAO 152962"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.47341151),
        dec: Angle.Degrees(-14.35820308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92577"},
        {"Hipparcos Number", "HIP 52292"},
        {"Geneva Identification System", "GEN# +1.00092577"},
        {"Smithsonian Astrophysical Observation", "SAO 156160"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.27544254),
        dec: Angle.Degrees(-14.35813500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122486"},
        {"Hipparcos Number", "HIP 68604"},
        {"Smithsonian Astrophysical Observation", "SAO 158302"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.64260256),
        dec: Angle.Degrees(-14.35716771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173251"},
        {"Hipparcos Number", "HIP 91982"},
        {"Geneva Identification System", "GEN# +1.00173251"},
        {"Smithsonian Astrophysical Observation", "SAO 161786"},
        {"Wilson Evans Batten Catalogue", "WEB 15845"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.21925697),
        dec: Angle.Degrees(-14.35311633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136890"},
        {"Hipparcos Number", "HIP 75331"},
        {"Smithsonian Astrophysical Observation", "SAO 159219"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.88047819),
        dec: Angle.Degrees(-14.35176813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152499"},
        {"Hipparcos Number", "HIP 82701"},
        {"Smithsonian Astrophysical Observation", "SAO 160156"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.57487941),
        dec: Angle.Degrees(-14.35156796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33756"},
        {"Wilson Evans Batten Catalogue", "WEB 6780"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.16729733),
        dec: Angle.Degrees(-14.34963504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1979"},
        {"Hipparcos Number", "HIP 1893"},
        {"Smithsonian Astrophysical Observation", "SAO 147250"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.98508050),
        dec: Angle.Degrees(-14.34641535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102604"},
        {"Hipparcos Number", "HIP 57611"},
        {"Smithsonian Astrophysical Observation", "SAO 156901"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.17342562),
        dec: Angle.Degrees(-14.34443132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59664"},
    },
    visualMagnitude: 11.33,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.53323946),
        dec: Angle.Degrees(-14.34350141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37471"},
        {"Hipparcos Number", "HIP 26511"},
        {"Fundamental Katalog 5th Edition", "FK5 4513"},
        {"Geneva Identification System", "GEN# +1.00037471"},
        {"Smithsonian Astrophysical Observation", "SAO 150638"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.56720239),
        dec: Angle.Degrees(-14.34124116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60325"},
        {"Hipparcos Number", "HIP 36736"},
        {"Celescope Catalog", "CEL 1924"},
        {"Geneva Identification System", "GEN# +2.24220001"},
        {"Renson", "Renson 16485"},
        {"Smithsonian Astrophysical Observation", "SAO 153061"},
        {"Wilson Evans Batten Catalogue", "WEB 7303"},
        {"New General Catalogue", "NGC 2422 1"},
    },
    visualMagnitude: 6.21,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.34244701),
        dec: Angle.Degrees(-14.33830668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37833"},
        {"Smithsonian Astrophysical Observation", "SAO 153355"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.34190184),
        dec: Angle.Degrees(-14.33811340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155567"},
        {"Hipparcos Number", "HIP 84224"},
        {"Smithsonian Astrophysical Observation", "SAO 160369"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.23672814),
        dec: Angle.Degrees(-14.33680092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223489"},
        {"Hipparcos Number", "HIP 117518"},
        {"Geneva Identification System", "GEN# +1.00223489"},
        {"Smithsonian Astrophysical Observation", "SAO 165908"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.48711795),
        dec: Angle.Degrees(-14.33610865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177210"},
        {"Hipparcos Number", "HIP 93651"},
        {"Smithsonian Astrophysical Observation", "SAO 162157"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.06033931),
        dec: Angle.Degrees(-14.33352386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83754"},
        {"Hipparcos Number", "HIP 47452"},
        {"Fundamental Katalog 5th Edition", "FK5 364"},
        {"Geneva Identification System", "GEN# +1.00083754"},
        {"Smithsonian Astrophysical Observation", "SAO 155388"},
        {"Wilson Evans Batten Catalogue", "WEB 8904"},
    },
    visualMagnitude: 5.07,
    bvColour: -0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.07657975),
        dec: Angle.Degrees(-14.33224542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47059"},
        {"Hipparcos Number", "HIP 31530"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.01676085),
        dec: Angle.Degrees(-14.32833119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209131"},
        {"Hipparcos Number", "HIP 108722"},
        {"Smithsonian Astrophysical Observation", "SAO 164817"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.36298354),
        dec: Angle.Degrees(-14.32684819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26724"},
        {"Hipparcos Number", "HIP 19692"},
        {"Geneva Identification System", "GEN# +1.00026724"},
        {"Smithsonian Astrophysical Observation", "SAO 149461"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.27500663),
        dec: Angle.Degrees(-14.32282275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201162"},
        {"Hipparcos Number", "HIP 104340"},
        {"Geneva Identification System", "GEN# +1.00201162"},
        {"Smithsonian Astrophysical Observation", "SAO 164162"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.04979462),
        dec: Angle.Degrees(-14.32201125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35708"},
        {"Geneva Identification System", "GEN# -0.01401863"},
        {"Wilson Evans Batten Catalogue", "WEB 7114"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.50991940),
        dec: Angle.Degrees(-14.31820241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138281"},
        {"Hipparcos Number", "HIP 76015"},
        {"Smithsonian Astrophysical Observation", "SAO 159314"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.88950670),
        dec: Angle.Degrees(-14.31669053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38931"},
        {"Hipparcos Number", "HIP 27444"},
        {"Geneva Identification System", "GEN# +1.00038931"},
        {"Smithsonian Astrophysical Observation", "SAO 150830"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.16534727),
        dec: Angle.Degrees(-14.31434981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50627"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.11617136),
        dec: Angle.Degrees(-14.31375506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -297.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144450"},
        {"Hipparcos Number", "HIP 78917"},
        {"Geneva Identification System", "GEN# +1.00144450"},
        {"Smithsonian Astrophysical Observation", "SAO 159696"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.63133990),
        dec: Angle.Degrees(-14.31195474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136981"},
        {"Hipparcos Number", "HIP 75368"},
        {"Smithsonian Astrophysical Observation", "SAO 159230"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.02075123),
        dec: Angle.Degrees(-14.31015494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59437"},
        {"Hipparcos Number", "HIP 36391"},
        {"Renson", "Renson 16250"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.33117218),
        dec: Angle.Degrees(-14.30837765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77105"},
        {"Hipparcos Number", "HIP 44185"},
        {"Renson", "Renson 21730"},
        {"Smithsonian Astrophysical Observation", "SAO 154821"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.01758251),
        dec: Angle.Degrees(-14.30747682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50756"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.46079895),
        dec: Angle.Degrees(-14.30632277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -337.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97040"},
        {"Hipparcos Number", "HIP 54585"},
        {"Renson", "Renson 28000"},
        {"Smithsonian Astrophysical Observation", "SAO 156507"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.56375098),
        dec: Angle.Degrees(-14.30600572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167497"},
        {"Hipparcos Number", "HIP 89519"},
        {"Geneva Identification System", "GEN# +1.00167497"},
        {"Smithsonian Astrophysical Observation", "SAO 161238"},
        {"Wilson Evans Batten Catalogue", "WEB 15241"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.00955156),
        dec: Angle.Degrees(-14.30589185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44423"},
        {"Hipparcos Number", "HIP 30204"},
        {"Geneva Identification System", "GEN# +1.00044423"},
        {"Smithsonian Astrophysical Observation", "SAO 151396"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.31268200),
        dec: Angle.Degrees(-14.30486636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49577"},
        {"Geneva Identification System", "GEN# -0.01303031"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.80758216),
        dec: Angle.Degrees(-14.30470762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21594",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sceptrum"},
        {"Henry Draper", "HD 29503"},
        {"Hipparcos Number", "HIP 21594"},
        {"Fundamental Katalog 5th Edition", "FK5 172"},
        {"Geneva Identification System", "GEN# +1.00029503J"},
        {"Smithsonian Astrophysical Observation", "SAO 149781"},
        {"Wilson Evans Batten Catalogue", "WEB 4147"},
    },
    visualMagnitude: 3.86,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.54529558),
        dec: Angle.Degrees(-14.30358700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184985"},
        {"Hipparcos Number", "HIP 96536"},
        {"Geneva Identification System", "GEN# +1.00184985"},
        {"Smithsonian Astrophysical Observation", "SAO 162827"},
        {"Wilson Evans Batten Catalogue", "WEB 16942"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.39365282),
        dec: Angle.Degrees(-14.30144432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23067"},
        {"Hipparcos Number", "HIP 17243"},
        {"Smithsonian Astrophysical Observation", "SAO 149116"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.39301656),
        dec: Angle.Degrees(-14.29923793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3715"},
        {"Hipparcos Number", "HIP 3134"},
        {"Geneva Identification System", "GEN# +1.00003715"},
        {"Smithsonian Astrophysical Observation", "SAO 147389"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.95978877),
        dec: Angle.Degrees(-14.29915265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16515"},
        {"Hipparcos Number", "HIP 12311"},
        {"Smithsonian Astrophysical Observation", "SAO 148519"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.63828793),
        dec: Angle.Degrees(-14.29909553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79397"},
        {"Hipparcos Number", "HIP 45263"},
        {"Smithsonian Astrophysical Observation", "SAO 155013"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.37952310),
        dec: Angle.Degrees(-14.29649473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6569"},
        {"Hipparcos Number", "HIP 5191"},
        {"Geneva Identification System", "GEN# +1.00006569"},
        {"Smithsonian Astrophysical Observation", "SAO 147611"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.60872175),
        dec: Angle.Degrees(-14.29618780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74018"},
        {"Hipparcos Number", "HIP 42607"},
        {"Geneva Identification System", "GEN# +1.00074018"},
        {"Smithsonian Astrophysical Observation", "SAO 154542"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.25868773),
        dec: Angle.Degrees(-14.29314621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217040"},
        {"Hipparcos Number", "HIP 113395"},
        {"Smithsonian Astrophysical Observation", "SAO 165405"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.47753361),
        dec: Angle.Degrees(-14.29142482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204692"},
        {"Hipparcos Number", "HIP 106199"},
        {"Geneva Identification System", "GEN# +1.00204692"},
        {"Smithsonian Astrophysical Observation", "SAO 164444"},
        {"Wilson Evans Batten Catalogue", "WEB 19243"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.66822231),
        dec: Angle.Degrees(-14.29112697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193102"},
        {"Hipparcos Number", "HIP 100164"},
        {"Smithsonian Astrophysical Observation", "SAO 163440"},
        {"Wilson Evans Batten Catalogue", "WEB 18040"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.75960438),
        dec: Angle.Degrees(-14.29099946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16609"},
        {"Hipparcos Number", "HIP 12381"},
        {"Fundamental Katalog 5th Edition", "FK5 4245"},
        {"Geneva Identification System", "GEN# +1.00016609"},
        {"Smithsonian Astrophysical Observation", "SAO 148526"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.84888652),
        dec: Angle.Degrees(-14.28881445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191285"},
        {"Hipparcos Number", "HIP 99322"},
        {"Geneva Identification System", "GEN# +1.00191285"},
        {"Smithsonian Astrophysical Observation", "SAO 163300"},
        {"Wilson Evans Batten Catalogue", "WEB 17718"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.40175168),
        dec: Angle.Degrees(-14.28668893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140631"},
        {"Hipparcos Number", "HIP 77154"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.29596647),
        dec: Angle.Degrees(-14.28644067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66987"},
        {"Hipparcos Number", "HIP 39588"},
        {"Smithsonian Astrophysical Observation", "SAO 153810"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.34841082),
        dec: Angle.Degrees(-14.28459834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14692"},
        {"Hipparcos Number", "HIP 11013"},
        {"Geneva Identification System", "GEN# +1.00014692"},
        {"Smithsonian Astrophysical Observation", "SAO 148353"},
        {"Wilson Evans Batten Catalogue", "WEB 2312"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.45719672),
        dec: Angle.Degrees(-14.28443702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154067"},
        {"Hipparcos Number", "HIP 83492"},
        {"Smithsonian Astrophysical Observation", "SAO 160250"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.96676865),
        dec: Angle.Degrees(-14.28334908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114962"},
        {"Hipparcos Number", "HIP 64574"},
        {"Geneva Identification System", "GEN# +1.00114962"},
        {"Smithsonian Astrophysical Observation", "SAO 157807"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.53903239),
        dec: Angle.Degrees(-14.28212491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142983"},
        {"Hipparcos Number", "HIP 78207"},
        {"Fundamental Katalog 5th Edition", "FK5 1417"},
        {"Geneva Identification System", "GEN# +1.00142983"},
        {"Smithsonian Astrophysical Observation", "SAO 159607"},
        {"Wilson Evans Batten Catalogue", "WEB 13226"},
    },
    visualMagnitude: 4.95,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.54740116),
        dec: Angle.Degrees(-14.27931773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203893"},
        {"Hipparcos Number", "HIP 105782"},
        {"Smithsonian Astrophysical Observation", "SAO 164378"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.35376301),
        dec: Angle.Degrees(-14.27733920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88426"},
        {"Hipparcos Number", "HIP 49923"},
        {"Smithsonian Astrophysical Observation", "SAO 155803"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.89434858),
        dec: Angle.Degrees(-14.27410767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7466"},
        {"Hipparcos Number", "HIP 5808"},
        {"Smithsonian Astrophysical Observation", "SAO 147690"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.63071370),
        dec: Angle.Degrees(-14.27349779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27676"},
        {"Hipparcos Number", "HIP 20345"},
        {"Smithsonian Astrophysical Observation", "SAO 149575"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.37835431),
        dec: Angle.Degrees(-14.27317968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217533"},
        {"Hipparcos Number", "HIP 113675"},
        {"Smithsonian Astrophysical Observation", "SAO 165440"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.35346875),
        dec: Angle.Degrees(-14.27178164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158120"},
        {"Hipparcos Number", "HIP 85471"},
        {"Fundamental Katalog 5th Edition", "FK5 5536"},
        {"Smithsonian Astrophysical Observation", "SAO 160563"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.99182408),
        dec: Angle.Degrees(-14.26946944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201461"},
        {"Hipparcos Number", "HIP 104494"},
        {"Smithsonian Astrophysical Observation", "SAO 164186"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.51583992),
        dec: Angle.Degrees(-14.26892067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142314"},
        {"Hipparcos Number", "HIP 77894"},
        {"Geneva Identification System", "GEN# +1.00142314"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.60730127),
        dec: Angle.Degrees(-14.26703274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50068"},
        {"Hipparcos Number", "HIP 32859"},
        {"Smithsonian Astrophysical Observation", "SAO 152005"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.73041801),
        dec: Angle.Degrees(-14.26393918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25724"},
        {"Hipparcos Number", "HIP 19005"},
        {"Smithsonian Astrophysical Observation", "SAO 149349"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.08037985),
        dec: Angle.Degrees(-14.26256482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113020",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 59"},
        {"Hipparcos Number", "HIP 113020"},
        {"Cincinnati Publication", "Ci 20 1387"},
        {"Geneva Identification System", "GEN# -0.01506290"},
        {"Wilson Evans Batten Catalogue", "WEB 20121"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.31731628),
        dec: Angle.Degrees(-14.26205842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 960.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -675.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18033"},
        {"Hipparcos Number", "HIP 13470"},
        {"Smithsonian Astrophysical Observation", "SAO 148654"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.37060770),
        dec: Angle.Degrees(-14.26051914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181943"},
        {"Hipparcos Number", "HIP 95266"},
        {"Smithsonian Astrophysical Observation", "SAO 162546"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.73846424),
        dec: Angle.Degrees(-14.25887767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160523"},
        {"Hipparcos Number", "HIP 86524"},
        {"Smithsonian Astrophysical Observation", "SAO 160740"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.22345314),
        dec: Angle.Degrees(-14.25834849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217429"},
        {"Hipparcos Number", "HIP 113631"},
        {"Geneva Identification System", "GEN# +1.00217429"},
        {"Smithsonian Astrophysical Observation", "SAO 165433"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.19940326),
        dec: Angle.Degrees(-14.25832755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73880"},
        {"Smithsonian Astrophysical Observation", "SAO 159018"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.50710871),
        dec: Angle.Degrees(-14.25649194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193933"},
        {"Hipparcos Number", "HIP 100556"},
        {"Smithsonian Astrophysical Observation", "SAO 163519"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.85937642),
        dec: Angle.Degrees(-14.25643318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20622"},
        {"Hipparcos Number", "HIP 15413"},
        {"Geneva Identification System", "GEN# +1.00020622"},
        {"Smithsonian Astrophysical Observation", "SAO 148896"},
        {"Wilson Evans Batten Catalogue", "WEB 2965"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.67176618),
        dec: Angle.Degrees(-14.25400689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191068"},
        {"Hipparcos Number", "HIP 99228"},
        {"Fundamental Katalog 5th Edition", "FK5 5774"},
        {"Geneva Identification System", "GEN# +1.00191068"},
        {"Smithsonian Astrophysical Observation", "SAO 163289"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.14877144),
        dec: Angle.Degrees(-14.25397413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217721"},
        {"Hipparcos Number", "HIP 113798"},
        {"Smithsonian Astrophysical Observation", "SAO 165458"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.68350450),
        dec: Angle.Degrees(-14.25352735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6969"},
        {"Hipparcos Number", "HIP 5464"},
        {"Geneva Identification System", "GEN# +1.00006969"},
        {"Smithsonian Astrophysical Observation", "SAO 147645"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.48638598),
        dec: Angle.Degrees(-14.25337956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223774"},
        {"Hipparcos Number", "HIP 117722"},
        {"Geneva Identification System", "GEN# +1.00223774"},
        {"Smithsonian Astrophysical Observation", "SAO 165933"},
        {"Wilson Evans Batten Catalogue", "WEB 20717"},
    },
    visualMagnitude: 5.85,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.12520105),
        dec: Angle.Degrees(-14.25120700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13114"},
        {"Hipparcos Number", "HIP 9940"},
        {"Smithsonian Astrophysical Observation", "SAO 148224"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.99327799),
        dec: Angle.Degrees(-14.25114515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2345"},
        {"Hipparcos Number", "HIP 2150"},
        {"Smithsonian Astrophysical Observation", "SAO 147283"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.79960719),
        dec: Angle.Degrees(-14.24849184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34193"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.35663932),
        dec: Angle.Degrees(-14.24630005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119449"},
        {"Hipparcos Number", "HIP 66973"},
        {"Smithsonian Astrophysical Observation", "SAO 158117"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.89683538),
        dec: Angle.Degrees(-14.24477277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33177",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5569 AB"},
        {"Henry Draper", "HD 50849"},
        {"Hipparcos Number", "HIP 33177"},
        {"Smithsonian Astrophysical Observation", "SAO 152077"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.58444044),
        dec: Angle.Degrees(-14.24282454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114523"},
        {"Hipparcos Number", "HIP 64335"},
        {"Smithsonian Astrophysical Observation", "SAO 157775"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.81000906),
        dec: Angle.Degrees(-14.24231778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19965"},
        {"Hipparcos Number", "HIP 14883"},
        {"Smithsonian Astrophysical Observation", "SAO 148829"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.02445252),
        dec: Angle.Degrees(-14.23975897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31808"},
        {"Hipparcos Number", "HIP 23095"},
        {"Smithsonian Astrophysical Observation", "SAO 150037"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.54784189),
        dec: Angle.Degrees(-14.23654861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149653"},
        {"Hipparcos Number", "HIP 81330"},
        {"Smithsonian Astrophysical Observation", "SAO 160002"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.16101818),
        dec: Angle.Degrees(-14.23494233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4197"},
        {"Hipparcos Number", "HIP 3463"},
        {"Smithsonian Astrophysical Observation", "SAO 147424"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.07654994),
        dec: Angle.Degrees(-14.23483620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3579"},
        {"Hipparcos Number", "HIP 3039"},
        {"Smithsonian Astrophysical Observation", "SAO 147378"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.66183948),
        dec: Angle.Degrees(-14.23317724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8504",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1451 AB"},
        {"Henry Draper", "HD 11182"},
        {"Hipparcos Number", "HIP 8504"},
        {"Smithsonian Astrophysical Observation", "SAO 148038"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.41764972),
        dec: Angle.Degrees(-14.23246077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186107"},
        {"Hipparcos Number", "HIP 97013"},
        {"Smithsonian Astrophysical Observation", "SAO 162923"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.76090177),
        dec: Angle.Degrees(-14.23200165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31726"},
        {"Hipparcos Number", "HIP 23060"},
        {"Geneva Identification System", "GEN# +1.00031726"},
        {"Smithsonian Astrophysical Observation", "SAO 150029"},
        {"Wilson Evans Batten Catalogue", "WEB 4474"},
    },
    visualMagnitude: 6.15,
    bvColour: -0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.43618811),
        dec: Angle.Degrees(-14.23189027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162165"},
        {"Hipparcos Number", "HIP 87288"},
        {"Smithsonian Astrophysical Observation", "SAO 160846"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.53640962),
        dec: Angle.Degrees(-14.23167676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138686"},
        {"Hipparcos Number", "HIP 76209"},
        {"Geneva Identification System", "GEN# +1.00138686"},
        {"Smithsonian Astrophysical Observation", "SAO 159351"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.51444047),
        dec: Angle.Degrees(-14.22948923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221665"},
        {"Hipparcos Number", "HIP 116319"},
        {"Smithsonian Astrophysical Observation", "SAO 165770"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.52817639),
        dec: Angle.Degrees(-14.22935400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13077"},
        {"Smithsonian Astrophysical Observation", "SAO 148614"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.01759337),
        dec: Angle.Degrees(-14.22744895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40672"},
        {"Smithsonian Astrophysical Observation", "SAO 154089"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.54951704),
        dec: Angle.Degrees(-14.22677333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336"},
        {"Hipparcos Number", "HIP 645"},
        {"Smithsonian Astrophysical Observation", "SAO 147096"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.99660033),
        dec: Angle.Degrees(-14.22671354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210663"},
        {"Hipparcos Number", "HIP 109607"},
        {"Smithsonian Astrophysical Observation", "SAO 164919"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.04954083),
        dec: Angle.Degrees(-14.22525356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119638"},
        {"Hipparcos Number", "HIP 67069"},
        {"Geneva Identification System", "GEN# +1.00119638"},
        {"Smithsonian Astrophysical Observation", "SAO 158135"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.18584081),
        dec: Angle.Degrees(-14.22476017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118581"},
        {"Hipparcos Number", "HIP 66510"},
        {"Smithsonian Astrophysical Observation", "SAO 158052"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.50145368),
        dec: Angle.Degrees(-14.22438427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204588"},
        {"Hipparcos Number", "HIP 106137"},
        {"Smithsonian Astrophysical Observation", "SAO 164432"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.47514551),
        dec: Angle.Degrees(-14.22412656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222345"},
        {"Hipparcos Number", "HIP 116758"},
        {"Geneva Identification System", "GEN# +1.00222345"},
        {"Smithsonian Astrophysical Observation", "SAO 165818"},
        {"Wilson Evans Batten Catalogue", "WEB 20601"},
    },
    visualMagnitude: 4.97,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.94598676),
        dec: Angle.Degrees(-14.22204281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123849"},
        {"Hipparcos Number", "HIP 69222"},
        {"Geneva Identification System", "GEN# +1.00123849"},
        {"Smithsonian Astrophysical Observation", "SAO 158393"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.58252755),
        dec: Angle.Degrees(-14.22089686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21063"},
        {"Hipparcos Number", "HIP 15786"},
        {"Smithsonian Astrophysical Observation", "SAO 148936"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.86511430),
        dec: Angle.Degrees(-14.22082129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45858"},
        {"Hipparcos Number", "HIP 30910"},
        {"Smithsonian Astrophysical Observation", "SAO 151557"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.31660697),
        dec: Angle.Degrees(-14.21567569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14156"},
        {"Hipparcos Number", "HIP 10646"},
        {"Smithsonian Astrophysical Observation", "SAO 148309"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.26337638),
        dec: Angle.Degrees(-14.21424947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212242"},
        {"Hipparcos Number", "HIP 110507"},
        {"Smithsonian Astrophysical Observation", "SAO 165031"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.78460780),
        dec: Angle.Degrees(-14.21146266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28227"},
        {"Smithsonian Astrophysical Observation", "SAO 150976"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.45777437),
        dec: Angle.Degrees(-14.21053219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135207"},
        {"Hipparcos Number", "HIP 74581"},
        {"Smithsonian Astrophysical Observation", "SAO 159117"},
        {"Wilson Evans Batten Catalogue", "WEB 12729"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.57837833),
        dec: Angle.Degrees(-14.20942626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28222",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4549 A"},
        {"Henry Draper", "HD 40376"},
        {"Hipparcos Number", "HIP 28222"},
        {"Smithsonian Astrophysical Observation", "SAO 150974"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.44561245),
        dec: Angle.Degrees(-14.20922916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164144"},
        {"Hipparcos Number", "HIP 88160"},
        {"Geneva Identification System", "GEN# +1.00164144"},
        {"Smithsonian Astrophysical Observation", "SAO 160981"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.08538993),
        dec: Angle.Degrees(-14.20800972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15401"},
        {"Hipparcos Number", "HIP 11501"},
        {"Smithsonian Astrophysical Observation", "SAO 148404"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.07530581),
        dec: Angle.Degrees(-14.20726800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8446"},
        {"Hipparcos Number", "HIP 6497"},
        {"Geneva Identification System", "GEN# +1.00008446"},
        {"Smithsonian Astrophysical Observation", "SAO 147774"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.85806172),
        dec: Angle.Degrees(-14.20695675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123214"},
        {"Hipparcos Number", "HIP 68937"},
        {"Smithsonian Astrophysical Observation", "SAO 158357"},
        {"Wilson Evans Batten Catalogue", "WEB 12045"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.67353711),
        dec: Angle.Degrees(-14.20484549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198444"},
        {"Hipparcos Number", "HIP 102903"},
        {"Geneva Identification System", "GEN# +1.00198444"},
        {"Smithsonian Astrophysical Observation", "SAO 163926"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.70339078),
        dec: Angle.Degrees(-14.20037796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165319"},
        {"Hipparcos Number", "HIP 88652"},
        {"Geneva Identification System", "GEN# +1.00165319"},
        {"Smithsonian Astrophysical Observation", "SAO 161061"},
        {"Wilson Evans Batten Catalogue", "WEB 15017"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.49515510),
        dec: Angle.Degrees(-14.19805188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44290"},
        {"Hipparcos Number", "HIP 30133"},
        {"Geneva Identification System", "GEN# +1.00044290"},
        {"Renson", "Renson 11750"},
        {"Smithsonian Astrophysical Observation", "SAO 151373"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.11731957),
        dec: Angle.Degrees(-14.19674842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192109"},
        {"Hipparcos Number", "HIP 99690"},
        {"Smithsonian Astrophysical Observation", "SAO 163360"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.43711475),
        dec: Angle.Degrees(-14.19637353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210705"},
        {"Hipparcos Number", "HIP 109624"},
        {"Geneva Identification System", "GEN# +1.00210705"},
        {"Smithsonian Astrophysical Observation", "SAO 164923"},
        {"Wilson Evans Batten Catalogue", "WEB 19697"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.10725718),
        dec: Angle.Degrees(-14.19384149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56218"},
    },
    visualMagnitude: 12.51,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.91638725),
        dec: Angle.Degrees(-14.19281533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211410"},
        {"Hipparcos Number", "HIP 110030"},
        {"Smithsonian Astrophysical Observation", "SAO 164980"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.28768716),
        dec: Angle.Degrees(-14.19238732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207969"},
        {"Hipparcos Number", "HIP 108044"},
        {"Renson", "Renson 57820"},
        {"Smithsonian Astrophysical Observation", "SAO 164714"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.34017442),
        dec: Angle.Degrees(-14.18963710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170202"},
        {"Hipparcos Number", "HIP 90560"},
        {"Smithsonian Astrophysical Observation", "SAO 161511"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.18823736),
        dec: Angle.Degrees(-14.18932638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112876"},
        {"Hipparcos Number", "HIP 63436"},
        {"Smithsonian Astrophysical Observation", "SAO 157642"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.98526479),
        dec: Angle.Degrees(-14.18927932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114001"},
        {"Hipparcos Number", "HIP 64056"},
        {"Geneva Identification System", "GEN# +1.00114001"},
        {"Smithsonian Astrophysical Observation", "SAO 157735"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.91345607),
        dec: Angle.Degrees(-14.18806076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197497"},
        {"Hipparcos Number", "HIP 102371"},
        {"Fundamental Katalog 5th Edition", "FK5 5824"},
        {"Smithsonian Astrophysical Observation", "SAO 163841"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.13859127),
        dec: Angle.Degrees(-14.18576259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109941"},
        {"Geneva Identification System", "GEN# -0.01406241"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.00252335),
        dec: Angle.Degrees(-14.18406856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110996"},
        {"Hipparcos Number", "HIP 62315"},
        {"Geneva Identification System", "GEN# +1.00110996"},
        {"Smithsonian Astrophysical Observation", "SAO 157496"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.55662972),
        dec: Angle.Degrees(-14.18387336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105762"},
        {"Hipparcos Number", "HIP 59343"},
        {"Smithsonian Astrophysical Observation", "SAO 157124"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.60334907),
        dec: Angle.Degrees(-14.17914343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58647"},
        {"Hipparcos Number", "HIP 36068"},
        {"Celescope Catalog", "CEL 1843"},
        {"Geneva Identification System", "GEN# +1.00058647"},
        {"Smithsonian Astrophysical Observation", "SAO 152860"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.48375662),
        dec: Angle.Degrees(-14.17875570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1051"},
        {"Henry Draper 2", "HD 1051A"},
        {"Hipparcos Number", "HIP 1185"},
        {"Smithsonian Astrophysical Observation", "SAO 147175"},
        {"Wilson Evans Batten Catalogue", "WEB 211"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.70105117),
        dec: Angle.Degrees(-14.17758298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9056"},
        {"Geneva Identification System", "GEN# -0.01400363"},
        {"Smithsonian Astrophysical Observation", "SAO 148119"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.15758409),
        dec: Angle.Degrees(-14.17584496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 221.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95193"},
        {"Hipparcos Number", "HIP 53717"},
        {"Smithsonian Astrophysical Observation", "SAO 156370"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.86158460),
        dec: Angle.Degrees(-14.17159078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6707"},
        {"Hipparcos Number", "HIP 5289"},
        {"Geneva Identification System", "GEN# +1.00006707"},
        {"Smithsonian Astrophysical Observation", "SAO 147620"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.91686269),
        dec: Angle.Degrees(-14.16955100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16007"},
        {"Hipparcos Number", "HIP 11935"},
        {"Geneva Identification System", "GEN# +1.00016007"},
        {"Smithsonian Astrophysical Observation", "SAO 148471"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.50579587),
        dec: Angle.Degrees(-14.16926264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40136"},
        {"Hipparcos Number", "HIP 28103"},
        {"Fundamental Katalog 5th Edition", "FK5 226"},
        {"Geneva Identification System", "GEN# +1.00040136"},
        {"Smithsonian Astrophysical Observation", "SAO 150957"},
        {"Wilson Evans Batten Catalogue", "WEB 5500"},
    },
    visualMagnitude: 3.71,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.10132627),
        dec: Angle.Degrees(-14.16803805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207340"},
        {"Hipparcos Number", "HIP 107667"},
        {"Smithsonian Astrophysical Observation", "SAO 164667"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.13809058),
        dec: Angle.Degrees(-14.16570220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149147"},
        {"Hipparcos Number", "HIP 81067"},
        {"Smithsonian Astrophysical Observation", "SAO 159974"},
    },
    visualMagnitude: 8.74,
    bvColour: 2.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.37316802),
        dec: Angle.Degrees(-14.16569832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209029"},
        {"Hipparcos Number", "HIP 108649"},
        {"Geneva Identification System", "GEN# +1.00209029"},
        {"Smithsonian Astrophysical Observation", "SAO 164808"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.16174057),
        dec: Angle.Degrees(-14.16429992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156915"},
        {"Hipparcos Number", "HIP 84868"},
        {"Smithsonian Astrophysical Observation", "SAO 160478"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.18373411),
        dec: Angle.Degrees(-14.16204744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145962"},
        {"Hipparcos Number", "HIP 79584"},
        {"Smithsonian Astrophysical Observation", "SAO 159801"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.56611728),
        dec: Angle.Degrees(-14.16072968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183132"},
        {"Hipparcos Number", "HIP 95758"},
        {"Geneva Identification System", "GEN# +1.00183132"},
        {"Smithsonian Astrophysical Observation", "SAO 162652"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.15268058),
        dec: Angle.Degrees(-14.16045396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181058"},
        {"Hipparcos Number", "HIP 94970"},
        {"Geneva Identification System", "GEN# +1.00181058"},
        {"Smithsonian Astrophysical Observation", "SAO 162472"},
        {"Wilson Evans Batten Catalogue", "WEB 16583"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.88671412),
        dec: Angle.Degrees(-14.15350465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35041"},
        {"Hipparcos Number", "HIP 25002"},
        {"Geneva Identification System", "GEN# +1.00035041"},
        {"Smithsonian Astrophysical Observation", "SAO 150367"},
        {"Wilson Evans Batten Catalogue", "WEB 4842"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.30406472),
        dec: Angle.Degrees(-14.15252018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72489",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9396 AB"},
        {"Henry Draper", "HD 130559"},
        {"Hipparcos Number", "HIP 72489"},
        {"Geneva Identification System", "GEN# +1.00130559J"},
        {"Smithsonian Astrophysical Observation", "SAO 158821"},
        {"Wilson Evans Batten Catalogue", "WEB 12458"},
    },
    visualMagnitude: 5.32,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.32954567),
        dec: Angle.Degrees(-14.14898587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202170"},
        {"Hipparcos Number", "HIP 104859"},
        {"Smithsonian Astrophysical Observation", "SAO 164242"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.62514054),
        dec: Angle.Degrees(-14.14660586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47667"},
        {"Hipparcos Number", "HIP 31827"},
        {"Fundamental Katalog 5th Edition", "FK5 2515"},
        {"Geneva Identification System", "GEN# +1.00047667"},
        {"Smithsonian Astrophysical Observation", "SAO 151751"},
        {"Wilson Evans Batten Catalogue", "WEB 6398"},
    },
    visualMagnitude: 4.82,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.81965168),
        dec: Angle.Degrees(-14.14574673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86538"},
        {"Hipparcos Number", "HIP 48925"},
        {"Smithsonian Astrophysical Observation", "SAO 155633"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.71370636),
        dec: Angle.Degrees(-14.14307553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78539"},
        {"Hipparcos Number", "HIP 44859"},
        {"Smithsonian Astrophysical Observation", "SAO 154938"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.10552565),
        dec: Angle.Degrees(-14.14290433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21369"},
        {"Hipparcos Number", "HIP 16031"},
        {"Smithsonian Astrophysical Observation", "SAO 148958"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.60333237),
        dec: Angle.Degrees(-14.14285530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135842"},
        {"Hipparcos Number", "HIP 74851"},
        {"Smithsonian Astrophysical Observation", "SAO 159158"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.44010489),
        dec: Angle.Degrees(-14.14084574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65994"},
        {"Hipparcos Number", "HIP 39197"},
        {"Smithsonian Astrophysical Observation", "SAO 153718"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.25917430),
        dec: Angle.Degrees(-14.13811215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199705"},
        {"Hipparcos Number", "HIP 103589"},
        {"Smithsonian Astrophysical Observation", "SAO 164038"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.82832466),
        dec: Angle.Degrees(-14.13503252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12863"},
        {"Hipparcos Number", "HIP 9778"},
        {"Smithsonian Astrophysical Observation", "SAO 148195"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.43628133),
        dec: Angle.Degrees(-14.13385286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14284"},
        {"Hipparcos Number", "HIP 10733"},
        {"Smithsonian Astrophysical Observation", "SAO 148319"},
        {"Wilson Evans Batten Catalogue", "WEB 2264"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.53570548),
        dec: Angle.Degrees(-14.13369295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141853"},
        {"Hipparcos Number", "HIP 77689"},
        {"Geneva Identification System", "GEN# +1.00141853"},
        {"Smithsonian Astrophysical Observation", "SAO 159544"},
        {"Wilson Evans Batten Catalogue", "WEB 13146"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.91003658),
        dec: Angle.Degrees(-14.13356721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6078"},
        {"Hipparcos Number", "HIP 4821"},
        {"Smithsonian Astrophysical Observation", "SAO 147575"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.47351360),
        dec: Angle.Degrees(-14.13105117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103130"},
        {"Hipparcos Number", "HIP 57894"},
        {"Geneva Identification System", "GEN# +1.00103130"},
        {"Smithsonian Astrophysical Observation", "SAO 156952"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.11324793),
        dec: Angle.Degrees(-14.12755375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39761"},
        {"Hipparcos Number", "HIP 27879"},
        {"Smithsonian Astrophysical Observation", "SAO 150924"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.49460947),
        dec: Angle.Degrees(-14.12722192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84145"},
        {"Hipparcos Number", "HIP 47634"},
        {"Smithsonian Astrophysical Observation", "SAO 155425"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.68020227),
        dec: Angle.Degrees(-14.12695449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45226"},
        {"Hipparcos Number", "HIP 30576"},
        {"Smithsonian Astrophysical Observation", "SAO 151487"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.39719235),
        dec: Angle.Degrees(-14.12651370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60155",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8512 A"},
        {"Henry Draper", "HD 107293"},
        {"Hipparcos Number", "HIP 60155"},
        {"Geneva Identification System", "GEN# +1.00107293"},
        {"Smithsonian Astrophysical Observation", "SAO 157216"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.04145450),
        dec: Angle.Degrees(-14.12530931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35628"},
        {"Hipparcos Number", "HIP 25364"},
        {"Geneva Identification System", "GEN# +1.00035628"},
        {"Smithsonian Astrophysical Observation", "SAO 150429"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.37808185),
        dec: Angle.Degrees(-14.12523625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75004"},
        {"Hipparcos Number", "HIP 43122"},
        {"Smithsonian Astrophysical Observation", "SAO 154629"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.74142277),
        dec: Angle.Degrees(-14.12515982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224512"},
        {"Hipparcos Number", "HIP 118205"},
        {"Smithsonian Astrophysical Observation", "SAO 165975"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.64333639),
        dec: Angle.Degrees(-14.12509440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159930"},
        {"Hipparcos Number", "HIP 86279"},
        {"Renson", "Renson 45020"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.44632546),
        dec: Angle.Degrees(-14.12334446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58389"},
        {"Hipparcos Number", "HIP 35973"},
        {"Smithsonian Astrophysical Observation", "SAO 152836"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.20962023),
        dec: Angle.Degrees(-14.12286359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97325"},
        {"Hipparcos Number", "HIP 54710"},
        {"Smithsonian Astrophysical Observation", "SAO 156523"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.02003165),
        dec: Angle.Degrees(-14.12283319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148054"},
        {"Hipparcos Number", "HIP 80505"},
        {"Geneva Identification System", "GEN# +1.00148054J"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.50959753),
        dec: Angle.Degrees(-14.12282199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121883"},
        {"Hipparcos Number", "HIP 68267"},
        {"Geneva Identification System", "GEN# +1.00121883"},
        {"Smithsonian Astrophysical Observation", "SAO 158269"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.62433122),
        dec: Angle.Degrees(-14.12206119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41487"},
        {"Hipparcos Number", "HIP 28805"},
        {"Smithsonian Astrophysical Observation", "SAO 151088"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.22364591),
        dec: Angle.Degrees(-14.12016619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3766"},
        {"Geneva Identification System", "GEN# -0.01400142"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.09349908),
        dec: Angle.Degrees(-14.11981227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29394"},
        {"Hipparcos Number", "HIP 21508"},
        {"Geneva Identification System", "GEN# +1.00029394"},
        {"Smithsonian Astrophysical Observation", "SAO 149766"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.28466477),
        dec: Angle.Degrees(-14.11761774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201382"},
        {"Hipparcos Number", "HIP 104456"},
        {"Smithsonian Astrophysical Observation", "SAO 164180"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.39608879),
        dec: Angle.Degrees(-14.11675482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21218"},
        {"Hipparcos Number", "HIP 15920"},
        {"Geneva Identification System", "GEN# +1.00021218"},
        {"Smithsonian Astrophysical Observation", "SAO 148951"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.25244923),
        dec: Angle.Degrees(-14.11611554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212682"},
        {"Hipparcos Number", "HIP 110767"},
        {"Smithsonian Astrophysical Observation", "SAO 165074"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.60647991),
        dec: Angle.Degrees(-14.11511070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56335"},
        {"Hipparcos Number", "HIP 35165"},
        {"Smithsonian Astrophysical Observation", "SAO 152635"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.02511298),
        dec: Angle.Degrees(-14.11506458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170700"},
        {"Hipparcos Number", "HIP 90784"},
        {"Geneva Identification System", "GEN# +1.00170700"},
        {"Smithsonian Astrophysical Observation", "SAO 161561"},
        {"Wilson Evans Batten Catalogue", "WEB 15557"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.82359671),
        dec: Angle.Degrees(-14.11397031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194121"},
        {"Hipparcos Number", "HIP 100623"},
        {"Smithsonian Astrophysical Observation", "SAO 163532"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.05798287),
        dec: Angle.Degrees(-14.11390545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49977"},
        {"Hipparcos Number", "HIP 32815"},
        {"Geneva Identification System", "GEN# +1.00049977"},
        {"Smithsonian Astrophysical Observation", "SAO 151996"},
        {"Wilson Evans Batten Catalogue", "WEB 6607"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.61030550),
        dec: Angle.Degrees(-14.11337288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8413"},
        {"Hipparcos Number", "HIP 6466"},
        {"Smithsonian Astrophysical Observation", "SAO 147772"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.79946958),
        dec: Angle.Degrees(-14.11309777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113733"},
        {"Hipparcos Number", "HIP 63915"},
        {"Fundamental Katalog 5th Edition", "FK5 3043"},
        {"Smithsonian Astrophysical Observation", "SAO 157715"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.46531724),
        dec: Angle.Degrees(-14.11188573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103916"},
        {"Hipparcos Number", "HIP 58354"},
        {"Smithsonian Astrophysical Observation", "SAO 157016"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.49969170),
        dec: Angle.Degrees(-14.11124360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1302"},
        {"Hipparcos Number", "HIP 1378"},
        {"Geneva Identification System", "GEN# +1.00001302"},
        {"Renson", "Renson 273"},
    },
    visualMagnitude: 9.51,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.30484839),
        dec: Angle.Degrees(-14.10914351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14879"},
        {"Hipparcos Number", "HIP 11162"},
        {"Smithsonian Astrophysical Observation", "SAO 148369"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.90896463),
        dec: Angle.Degrees(-14.10870446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196250"},
        {"Hipparcos Number", "HIP 101680"},
        {"Smithsonian Astrophysical Observation", "SAO 163724"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.15254363),
        dec: Angle.Degrees(-14.10737276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92186"},
        {"Hipparcos Number", "HIP 52073"},
        {"Smithsonian Astrophysical Observation", "SAO 156119"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.61249585),
        dec: Angle.Degrees(-14.10670836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11784"},
        {"Hipparcos Number", "HIP 8954"},
        {"Smithsonian Astrophysical Observation", "SAO 148106"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.82907166),
        dec: Angle.Degrees(-14.10520927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139361"},
        {"Hipparcos Number", "HIP 76562"},
        {"Geneva Identification System", "GEN# +1.00139361"},
        {"Smithsonian Astrophysical Observation", "SAO 159399"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.54993131),
        dec: Angle.Degrees(-14.10112960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58127"},
        {"Hipparcos Number", "HIP 35864"},
        {"Celescope Catalog", "CEL 1819"},
        {"Geneva Identification System", "GEN# +1.00058127"},
        {"Smithsonian Astrophysical Observation", "SAO 152810"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.90728122),
        dec: Angle.Degrees(-14.10018417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110198"},
        {"Hipparcos Number", "HIP 61853"},
        {"Smithsonian Astrophysical Observation", "SAO 157440"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.15024188),
        dec: Angle.Degrees(-14.09979968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22512"},
        {"Hipparcos Number", "HIP 16847"},
        {"Geneva Identification System", "GEN# +1.00022512"},
        {"Smithsonian Astrophysical Observation", "SAO 149067"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.19890816),
        dec: Angle.Degrees(-14.09904074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46499"},
        {"Hipparcos Number", "HIP 31244"},
        {"Smithsonian Astrophysical Observation", "SAO 151633"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.30190811),
        dec: Angle.Degrees(-14.09613527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123239"},
        {"Hipparcos Number", "HIP 68943"},
        {"Smithsonian Astrophysical Observation", "SAO 158359"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.68779136),
        dec: Angle.Degrees(-14.09532707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176185"},
        {"Hipparcos Number", "HIP 93235"},
        {"Smithsonian Astrophysical Observation", "SAO 162054"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.86795877),
        dec: Angle.Degrees(-14.09061444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209820"},
        {"Hipparcos Number", "HIP 109140"},
        {"Smithsonian Astrophysical Observation", "SAO 164862"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.61832541),
        dec: Angle.Degrees(-14.08758577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1865"},
        {"Smithsonian Astrophysical Observation", "SAO 147246"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.90613263),
        dec: Angle.Degrees(-14.08741763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63696"},
        {"Hipparcos Number", "HIP 38206"},
        {"Smithsonian Astrophysical Observation", "SAO 153453"},
        {"Wilson Evans Batten Catalogue", "WEB 7528"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.41657954),
        dec: Angle.Degrees(-14.08535729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126365"},
        {"Hipparcos Number", "HIP 70510"},
        {"Geneva Identification System", "GEN# +1.00126365"},
        {"Renson", "Renson 36018"},
        {"Smithsonian Astrophysical Observation", "SAO 158557"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.34875923),
        dec: Angle.Degrees(-14.08513725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223808"},
        {"Hipparcos Number", "HIP 117753"},
        {"Smithsonian Astrophysical Observation", "SAO 165937"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.20813293),
        dec: Angle.Degrees(-14.08494153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41366"},
        {"Hipparcos Number", "HIP 28743"},
        {"Geneva Identification System", "GEN# +1.00041366"},
        {"Smithsonian Astrophysical Observation", "SAO 151075"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.05437117),
        dec: Angle.Degrees(-14.08441680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95314"},
        {"Hipparcos Number", "HIP 53778"},
        {"Geneva Identification System", "GEN# +1.00095314"},
        {"Smithsonian Astrophysical Observation", "SAO 156382"},
        {"Wilson Evans Batten Catalogue", "WEB 9743"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.04874547),
        dec: Angle.Degrees(-14.08329867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161485"},
        {"Hipparcos Number", "HIP 86966"},
        {"Smithsonian Astrophysical Observation", "SAO 160808"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.58215167),
        dec: Angle.Degrees(-14.08158817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126213"},
        {"Hipparcos Number", "HIP 70440"},
        {"Geneva Identification System", "GEN# +1.00126213"},
        {"Smithsonian Astrophysical Observation", "SAO 158546"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.14955042),
        dec: Angle.Degrees(-14.08142637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98687"},
        {"Hipparcos Number", "HIP 55437"},
        {"Geneva Identification System", "GEN# +1.00098687"},
        {"Smithsonian Astrophysical Observation", "SAO 156624"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.28677573),
        dec: Angle.Degrees(-14.08139503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158302"},
        {"Hipparcos Number", "HIP 85562"},
        {"Geneva Identification System", "GEN# +1.00158302"},
        {"Smithsonian Astrophysical Observation", "SAO 160572"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.28043884),
        dec: Angle.Degrees(-14.08061846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150922"},
        {"Hipparcos Number", "HIP 81970"},
        {"Smithsonian Astrophysical Observation", "SAO 160076"},
    },
    visualMagnitude: 7.99,
    bvColour: 2.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.17580970),
        dec: Angle.Degrees(-14.08015040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85489"},
        {"Hipparcos Number", "HIP 48385"},
        {"Smithsonian Astrophysical Observation", "SAO 155548"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.95516102),
        dec: Angle.Degrees(-14.07865125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127767"},
        {"Hipparcos Number", "HIP 71189"},
        {"Smithsonian Astrophysical Observation", "SAO 158637"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.39237433),
        dec: Angle.Degrees(-14.07654616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56870"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.89356745),
        dec: Angle.Degrees(-14.07616082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9215"},
        {"Hipparcos Number", "HIP 7023"},
        {"Smithsonian Astrophysical Observation", "SAO 147846"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.62711972),
        dec: Angle.Degrees(-14.07340561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106581"},
        {"Hipparcos Number", "HIP 59784"},
        {"Smithsonian Astrophysical Observation", "SAO 157172"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.87791133),
        dec: Angle.Degrees(-14.07204076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115541"},
        {"Hipparcos Number", "HIP 64878"},
        {"Smithsonian Astrophysical Observation", "SAO 157839"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.48482998),
        dec: Angle.Degrees(-14.07184476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144585"},
        {"Hipparcos Number", "HIP 78955"},
        {"Geneva Identification System", "GEN# +1.00144585"},
        {"Smithsonian Astrophysical Observation", "SAO 159706"},
        {"Wilson Evans Batten Catalogue", "WEB 13345"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.76469512),
        dec: Angle.Degrees(-14.07132020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -261.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165630"},
        {"Hipparcos Number", "HIP 88781"},
        {"Smithsonian Astrophysical Observation", "SAO 161090"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.85886057),
        dec: Angle.Degrees(-14.06703825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214460"},
        {"Hipparcos Number", "HIP 111790"},
        {"Smithsonian Astrophysical Observation", "SAO 165211"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.64434547),
        dec: Angle.Degrees(-14.06702948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219908"},
        {"Hipparcos Number", "HIP 115158"},
        {"Smithsonian Astrophysical Observation", "SAO 165631"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.89982449),
        dec: Angle.Degrees(-14.06654077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171554"},
        {"Hipparcos Number", "HIP 91174"},
        {"Renson", "Renson 48074"},
        {"Smithsonian Astrophysical Observation", "SAO 161645"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.00057591),
        dec: Angle.Degrees(-14.06556159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29170",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4755 AB"},
        {"Henry Draper", "HD 42283"},
        {"Hipparcos Number", "HIP 29170"},
        {"Smithsonian Astrophysical Observation", "SAO 151167"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.29149445),
        dec: Angle.Degrees(-14.06539777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10280"},
        {"Hipparcos Number", "HIP 7796"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.08153233),
        dec: Angle.Degrees(-14.06477967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109877"},
        {"Hipparcos Number", "HIP 61651"},
        {"Smithsonian Astrophysical Observation", "SAO 157409"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.57355623),
        dec: Angle.Degrees(-14.05963436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216128"},
        {"Hipparcos Number", "HIP 112782"},
        {"Geneva Identification System", "GEN# +1.00216128"},
        {"Smithsonian Astrophysical Observation", "SAO 165327"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.60063553),
        dec: Angle.Degrees(-14.05930074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214459"},
        {"Hipparcos Number", "HIP 111777"},
        {"Geneva Identification System", "GEN# +1.00214459"},
        {"Smithsonian Astrophysical Observation", "SAO 165210"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.62223673),
        dec: Angle.Degrees(-14.05912862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71395"},
        {"Hipparcos Number", "HIP 41403"},
        {"Smithsonian Astrophysical Observation", "SAO 154259"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.69384185),
        dec: Angle.Degrees(-14.05813153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38493",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6433 A"},
        {"Henry Draper", "HD 64356"},
        {"Hipparcos Number", "HIP 38493"},
        {"Smithsonian Astrophysical Observation", "SAO 153534"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.25026570),
        dec: Angle.Degrees(-14.05794986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112542",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16268 A"},
        {"Henry Draper", "HD 215766"},
        {"Hipparcos Number", "HIP 112542"},
        {"Geneva Identification System", "GEN# +1.00215766J"},
        {"Renson", "Renson 59600"},
        {"Smithsonian Astrophysical Observation", "SAO 165298"},
        {"Wilson Evans Batten Catalogue", "WEB 20067"},
    },
    visualMagnitude: 5.68,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.92812904),
        dec: Angle.Degrees(-14.05640541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139646"},
        {"Hipparcos Number", "HIP 76708"},
        {"Smithsonian Astrophysical Observation", "SAO 159422"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.95522641),
        dec: Angle.Degrees(-14.05572030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1181"},
        {"Hipparcos Number", "HIP 1285"},
        {"Smithsonian Astrophysical Observation", "SAO 147188"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.01951474),
        dec: Angle.Degrees(-14.05359154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28532"},
        {"Hipparcos Number", "HIP 20939"},
        {"Geneva Identification System", "GEN# +1.00028532"},
        {"Smithsonian Astrophysical Observation", "SAO 149677"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.34416133),
        dec: Angle.Degrees(-14.05355873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54197"},
        {"Hipparcos Number", "HIP 34364"},
        {"Celescope Catalog", "CEL 1597"},
        {"Geneva Identification System", "GEN# +1.00054197"},
        {"Smithsonian Astrophysical Observation", "SAO 152414"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.84839169),
        dec: Angle.Degrees(-14.05187141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141514"},
        {"Hipparcos Number", "HIP 77547"},
        {"Geneva Identification System", "GEN# +1.00141514"},
        {"Smithsonian Astrophysical Observation", "SAO 159522"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.50288854),
        dec: Angle.Degrees(-14.05105557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35763"},
        {"Hipparcos Number", "HIP 25440"},
        {"Geneva Identification System", "GEN# +1.00035763"},
        {"Smithsonian Astrophysical Observation", "SAO 150451"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.60917384),
        dec: Angle.Degrees(-14.04912319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51979"},
        {"Hipparcos Number", "HIP 33612"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.75891766),
        dec: Angle.Degrees(-14.04883720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206301"},
        {"Hipparcos Number", "HIP 107095"},
        {"Geneva Identification System", "GEN# +1.00206301"},
        {"Smithsonian Astrophysical Observation", "SAO 164580"},
        {"Wilson Evans Batten Catalogue", "WEB 19345"},
    },
    visualMagnitude: 5.16,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.38722004),
        dec: Angle.Degrees(-14.04686040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -308.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128986"},
        {"Hipparcos Number", "HIP 71745"},
        {"Geneva Identification System", "GEN# +1.00128986"},
        {"Smithsonian Astrophysical Observation", "SAO 158722"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.13396816),
        dec: Angle.Degrees(-14.04674117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178977"},
        {"Hipparcos Number", "HIP 94265"},
        {"Geneva Identification System", "GEN# +1.00178977"},
        {"Smithsonian Astrophysical Observation", "SAO 162286"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.80561244),
        dec: Angle.Degrees(-14.04505383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65362"},
        {"Cincinnati Publication", "Ci 20 776"},
    },
    visualMagnitude: 11.78,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.93596493),
        dec: Angle.Degrees(-14.04501726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -705.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -411.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211289"},
        {"Hipparcos Number", "HIP 109970"},
        {"Geneva Identification System", "GEN# +1.00211289"},
        {"Smithsonian Astrophysical Observation", "SAO 164968"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.10509812),
        dec: Angle.Degrees(-14.04498896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185533"},
        {"Hipparcos Number", "HIP 96753"},
        {"Smithsonian Astrophysical Observation", "SAO 162870"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.02112528),
        dec: Angle.Degrees(-14.04460478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33345",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5605 A"},
        {"Henry Draper", "HD 51250"},
        {"Hipparcos Number", "HIP 33345"},
        {"Geneva Identification System", "GEN# +1.00051250"},
        {"Smithsonian Astrophysical Observation", "SAO 152123"},
        {"Wilson Evans Batten Catalogue", "WEB 6699"},
    },
    visualMagnitude: 5.00,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.02769490),
        dec: Angle.Degrees(-14.04344644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74409"},
        {"Hipparcos Number", "HIP 42822"},
        {"Smithsonian Astrophysical Observation", "SAO 154576"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.88583532),
        dec: Angle.Degrees(-14.04184469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150785"},
        {"Hipparcos Number", "HIP 81905"},
        {"Geneva Identification System", "GEN# +1.00150785"},
        {"Smithsonian Astrophysical Observation", "SAO 160064"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.94805014),
        dec: Angle.Degrees(-14.04115614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179688"},
        {"Hipparcos Number", "HIP 94500"},
        {"Smithsonian Astrophysical Observation", "SAO 162344"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.50017463),
        dec: Angle.Degrees(-14.03909189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120366"},
        {"Hipparcos Number", "HIP 67440"},
        {"Smithsonian Astrophysical Observation", "SAO 158180"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.32328336),
        dec: Angle.Degrees(-14.03587180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221027"},
        {"Hipparcos Number", "HIP 115886"},
        {"Smithsonian Astrophysical Observation", "SAO 165712"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.18502506),
        dec: Angle.Degrees(-14.03554383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208369"},
        {"Hipparcos Number", "HIP 108274"},
        {"Smithsonian Astrophysical Observation", "SAO 164750"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.03169913),
        dec: Angle.Degrees(-14.03552724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150697"},
        {"Hipparcos Number", "HIP 81870"},
        {"Geneva Identification System", "GEN# +1.00150697"},
        {"Smithsonian Astrophysical Observation", "SAO 160060"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.82799012),
        dec: Angle.Degrees(-14.03482961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181612"},
        {"Hipparcos Number", "HIP 95179"},
        {"Geneva Identification System", "GEN# +1.00181612"},
        {"Smithsonian Astrophysical Observation", "SAO 162520"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.43680904),
        dec: Angle.Degrees(-14.03333253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9050"},
        {"Hipparcos Number", "HIP 6907"},
        {"Geneva Identification System", "GEN# +1.00009050"},
        {"Renson", "Renson 2194"},
        {"Smithsonian Astrophysical Observation", "SAO 147830"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.23270943),
        dec: Angle.Degrees(-14.03265424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41448"},
        {"Hipparcos Number", "HIP 28778"},
        {"Smithsonian Astrophysical Observation", "SAO 151081"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.14617053),
        dec: Angle.Degrees(-14.03258417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220153"},
        {"Hipparcos Number", "HIP 115327"},
        {"Smithsonian Astrophysical Observation", "SAO 165648"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.38903773),
        dec: Angle.Degrees(-14.03253233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75436"},
        {"Hipparcos Number", "HIP 43328"},
        {"Smithsonian Astrophysical Observation", "SAO 154666"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.41641595),
        dec: Angle.Degrees(-14.03170748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35661"},
        {"Hipparcos Number", "HIP 25377"},
        {"Geneva Identification System", "GEN# +1.00035661"},
        {"Smithsonian Astrophysical Observation", "SAO 150434"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.43587991),
        dec: Angle.Degrees(-14.03157654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9195"},
        {"Smithsonian Astrophysical Observation", "SAO 148135"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.59473920),
        dec: Angle.Degrees(-14.03062395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2286"},
        {"Hipparcos Number", "HIP 2099"},
        {"Geneva Identification System", "GEN# +1.00002286"},
        {"Smithsonian Astrophysical Observation", "SAO 147279"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.65375960),
        dec: Angle.Degrees(-14.02979312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119891"},
        {"Hipparcos Number", "HIP 67193"},
        {"Geneva Identification System", "GEN# +1.00119891"},
        {"Smithsonian Astrophysical Observation", "SAO 158154"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.55552726),
        dec: Angle.Degrees(-14.02824881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175644"},
        {"Hipparcos Number", "HIP 93004"},
        {"Geneva Identification System", "GEN# +1.00175644"},
        {"Smithsonian Astrophysical Observation", "SAO 162014"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.19665512),
        dec: Angle.Degrees(-14.02796204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128257"},
        {"Hipparcos Number", "HIP 71420"},
        {"Smithsonian Astrophysical Observation", "SAO 158668"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.08054715),
        dec: Angle.Degrees(-14.02787669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204548"},
        {"Hipparcos Number", "HIP 106115"},
        {"Smithsonian Astrophysical Observation", "SAO 164430"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.41727966),
        dec: Angle.Degrees(-14.02677604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6977"},
        {"Hipparcos Number", "HIP 5471"},
        {"Smithsonian Astrophysical Observation", "SAO 147647"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.51321585),
        dec: Angle.Degrees(-14.02559160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18183"},
        {"Hipparcos Number", "HIP 13578"},
        {"Fundamental Katalog 5th Edition", "FK5 2203"},
        {"Geneva Identification System", "GEN# +1.00018183"},
        {"Smithsonian Astrophysical Observation", "SAO 148663"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.72577032),
        dec: Angle.Degrees(-14.02484866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148022"},
        {"Hipparcos Number", "HIP 80495"},
        {"Smithsonian Astrophysical Observation", "SAO 159911"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.46767973),
        dec: Angle.Degrees(-14.02432996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58084"},
        {"Geneva Identification System", "GEN# -0.01303470"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.68532795),
        dec: Angle.Degrees(-14.02383956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135107"},
        {"Hipparcos Number", "HIP 74531"},
        {"Geneva Identification System", "GEN# +1.00135107"},
        {"Smithsonian Astrophysical Observation", "SAO 159111"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.44626193),
        dec: Angle.Degrees(-14.02290838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78065"},
        {"Smithsonian Astrophysical Observation", "SAO 159586"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.08918006),
        dec: Angle.Degrees(-14.02207777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93865"},
        {"Hipparcos Number", "HIP 52961"},
        {"Smithsonian Astrophysical Observation", "SAO 156258"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.48213104),
        dec: Angle.Degrees(-14.02184339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157183"},
        {"Hipparcos Number", "HIP 85002"},
        {"Smithsonian Astrophysical Observation", "SAO 160503"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.61108088),
        dec: Angle.Degrees(-14.02004420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101896"},
        {"Hipparcos Number", "HIP 57181"},
        {"Smithsonian Astrophysical Observation", "SAO 156854"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.89227452),
        dec: Angle.Degrees(-14.01999190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34688"},
        {"Hipparcos Number", "HIP 24777"},
        {"Smithsonian Astrophysical Observation", "SAO 150324"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.67773371),
        dec: Angle.Degrees(-14.01835309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 228.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202990"},
        {"Hipparcos Number", "HIP 105315"},
        {"Smithsonian Astrophysical Observation", "SAO 164310"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.95260646),
        dec: Angle.Degrees(-14.01751500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125001"},
        {"Hipparcos Number", "HIP 69801"},
        {"Smithsonian Astrophysical Observation", "SAO 158463"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.28075384),
        dec: Angle.Degrees(-14.01669428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220629"},
        {"Hipparcos Number", "HIP 115626"},
        {"Smithsonian Astrophysical Observation", "SAO 165682"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.35432308),
        dec: Angle.Degrees(-14.01581058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219364"},
        {"Hipparcos Number", "HIP 114805"},
        {"Geneva Identification System", "GEN# +1.00219364"},
        {"Smithsonian Astrophysical Observation", "SAO 165585"},
        {"Wilson Evans Batten Catalogue", "WEB 20349"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.83713444),
        dec: Angle.Degrees(-14.01534888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27925"},
        {"Hipparcos Number", "HIP 20521"},
        {"Geneva Identification System", "GEN# +1.00027925"},
        {"Smithsonian Astrophysical Observation", "SAO 149606"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.96380888),
        dec: Angle.Degrees(-14.01520973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9475"},
        {"Smithsonian Astrophysical Observation", "SAO 148160"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.47577532),
        dec: Angle.Degrees(-14.01470019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196799"},
        {"Hipparcos Number", "HIP 101988"},
        {"Smithsonian Astrophysical Observation", "SAO 163780"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.02613559),
        dec: Angle.Degrees(-14.01306542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57459"},
    },
    visualMagnitude: 11.68,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.67702350),
        dec: Angle.Degrees(-14.01247378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 713.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -786.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72191"},
        {"Hipparcos Number", "HIP 41769"},
        {"Smithsonian Astrophysical Observation", "SAO 154342"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.76583127),
        dec: Angle.Degrees(-14.01207752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189002"},
        {"Hipparcos Number", "HIP 98304"},
        {"Smithsonian Astrophysical Observation", "SAO 163149"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.60659159),
        dec: Angle.Degrees(-14.01167465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166644"},
        {"Hipparcos Number", "HIP 89194"},
        {"Smithsonian Astrophysical Observation", "SAO 161173"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.03750424),
        dec: Angle.Degrees(-14.00788358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91369",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11512 AB"},
        {"Henry Draper", "HD 171957"},
        {"Hipparcos Number", "HIP 91369"},
        {"Geneva Identification System", "GEN# +1.00171957J"},
        {"Smithsonian Astrophysical Observation", "SAO 161687"},
        {"Wilson Evans Batten Catalogue", "WEB 15700"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.51866979),
        dec: Angle.Degrees(-14.00476208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77590"},
        {"Hipparcos Number", "HIP 44427"},
        {"Smithsonian Astrophysical Observation", "SAO 154862"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.78250324),
        dec: Angle.Degrees(-14.00364591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37625"},
        {"Smithsonian Astrophysical Observation", "SAO 153305"},
    },
    visualMagnitude: 9.25,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.81208487),
        dec: Angle.Degrees(-14.00241875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117364"},
        {"Hipparcos Number", "HIP 65856"},
        {"Smithsonian Astrophysical Observation", "SAO 157967"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.49339081),
        dec: Angle.Degrees(-14.00151327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159800"},
        {"Hipparcos Number", "HIP 86222"},
        {"Geneva Identification System", "GEN# +1.00159800"},
        {"Smithsonian Astrophysical Observation", "SAO 160696"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.30499902),
        dec: Angle.Degrees(-14.00106641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46855",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7427 AB"},
        {"Henry Draper", "HD 82661"},
        {"Hipparcos Number", "HIP 46855"},
        {"Smithsonian Astrophysical Observation", "SAO 155280"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.22871999),
        dec: Angle.Degrees(-14.00065699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73253"},
        {"Hipparcos Number", "HIP 42254"},
        {"Geneva Identification System", "GEN# +1.00073253"},
        {"Renson", "Renson 20345"},
        {"Smithsonian Astrophysical Observation", "SAO 154455"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.23903094),
        dec: Angle.Degrees(-14.00054579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134214"},
        {"Hipparcos Number", "HIP 74145"},
        {"Geneva Identification System", "GEN# +1.00134214"},
        {"Renson", "Renson 38100"},
        {"Smithsonian Astrophysical Observation", "SAO 159050"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.26013662),
        dec: Angle.Degrees(-13.99966528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140896"},
        {"Hipparcos Number", "HIP 77270"},
        {"Geneva Identification System", "GEN# +1.00140896"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.64119200),
        dec: Angle.Degrees(-13.99956646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212521"},
        {"Hipparcos Number", "HIP 110663"},
        {"Smithsonian Astrophysical Observation", "SAO 165057"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.26734817),
        dec: Angle.Degrees(-13.99820984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57324"},
        {"Hipparcos Number", "HIP 35552"},
        {"Smithsonian Astrophysical Observation", "SAO 152735"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.04033391),
        dec: Angle.Degrees(-13.99773473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16469"},
        {"Hipparcos Number", "HIP 12283"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.55308864),
        dec: Angle.Degrees(-13.99771382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194798"},
        {"Hipparcos Number", "HIP 100948"},
        {"Smithsonian Astrophysical Observation", "SAO 163599"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.01272096),
        dec: Angle.Degrees(-13.99711151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24562"},
        {"Hipparcos Number", "HIP 18233"},
        {"Smithsonian Astrophysical Observation", "SAO 149235"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.48843317),
        dec: Angle.Degrees(-13.99471712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44200"},
        {"Hipparcos Number", "HIP 30088"},
        {"Geneva Identification System", "GEN# +1.00044200"},
        {"Smithsonian Astrophysical Observation", "SAO 151365"},
    },
    visualMagnitude: 6.67,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.98905418),
        dec: Angle.Degrees(-13.99302762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15869",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2523 AB"},
        {"Henry Draper", "HD 21160"},
        {"Hipparcos Number", "HIP 15869"},
        {"Smithsonian Astrophysical Observation", "SAO 148943"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.10253263),
        dec: Angle.Degrees(-13.99295812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145350"},
        {"Hipparcos Number", "HIP 79303"},
        {"Smithsonian Astrophysical Observation", "SAO 159756"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.76533631),
        dec: Angle.Degrees(-13.99210574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168183"},
        {"Hipparcos Number", "HIP 89753"},
        {"Geneva Identification System", "GEN# +2.66110412"},
        {"Smithsonian Astrophysical Observation", "SAO 161318"},
        {"Wilson Evans Batten Catalogue", "WEB 15304"},
        {"New General Catalogue", "NGC 6611 412"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.74454580),
        dec: Angle.Degrees(-13.99123310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35263",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5957 A"},
        {"Henry Draper", "HD 56597"},
        {"Hipparcos Number", "HIP 35263"},
        {"Celescope Catalog", "CEL 1737"},
        {"Geneva Identification System", "GEN# +1.00056597"},
        {"Smithsonian Astrophysical Observation", "SAO 152665"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.28063818),
        dec: Angle.Degrees(-13.98981403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59543"},
        {"Hipparcos Number", "HIP 36437"},
        {"Celescope Catalog", "CEL 1890"},
        {"Geneva Identification System", "GEN# +1.00059543"},
        {"Smithsonian Astrophysical Observation", "SAO 152963"},
        {"Wilson Evans Batten Catalogue", "WEB 7252"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.47626093),
        dec: Angle.Degrees(-13.98940441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33142"},
        {"Hipparcos Number", "HIP 23844"},
        {"Geneva Identification System", "GEN# +1.00033142"},
        {"Smithsonian Astrophysical Observation", "SAO 150161"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.89810823),
        dec: Angle.Degrees(-13.98656419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112119"},
        {"Hipparcos Number", "HIP 62973"},
        {"Geneva Identification System", "GEN# +1.00112119"},
        {"Smithsonian Astrophysical Observation", "SAO 157583"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.55565278),
        dec: Angle.Degrees(-13.98646332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223675"},
        {"Hipparcos Number", "HIP 117652"},
        {"Geneva Identification System", "GEN# +1.00223675"},
        {"Smithsonian Astrophysical Observation", "SAO 165921"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.90876452),
        dec: Angle.Degrees(-13.98513654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 603"},
        {"Hipparcos Number", "HIP 846"},
        {"Smithsonian Astrophysical Observation", "SAO 147123"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.59569702),
        dec: Angle.Degrees(-13.98412856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128869"},
        {"Hipparcos Number", "HIP 71684"},
        {"Smithsonian Astrophysical Observation", "SAO 158707"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.92364344),
        dec: Angle.Degrees(-13.98116386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93489"},
        {"Hipparcos Number", "HIP 52780"},
        {"Geneva Identification System", "GEN# +1.00093489"},
        {"Smithsonian Astrophysical Observation", "SAO 156232"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.86897890),
        dec: Angle.Degrees(-13.97905047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4643"},
        {"Geneva Identification System", "GEN# -0.01400181"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.90286230),
        dec: Angle.Degrees(-13.97896439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84129"},
        {"Hipparcos Number", "HIP 47616"},
        {"Smithsonian Astrophysical Observation", "SAO 155423"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.64078062),
        dec: Angle.Degrees(-13.97891316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211909"},
        {"Hipparcos Number", "HIP 110333"},
        {"Smithsonian Astrophysical Observation", "SAO 165014"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.20460958),
        dec: Angle.Degrees(-13.97844365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169454"},
        {"Hipparcos Number", "HIP 90281"},
        {"Fundamental Katalog 5th Edition", "FK5 5619"},
        {"Geneva Identification System", "GEN# +1.00169454"},
        {"Smithsonian Astrophysical Observation", "SAO 161457"},
        {"Wilson Evans Batten Catalogue", "WEB 15447"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.31330209),
        dec: Angle.Degrees(-13.97840802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183711"},
        {"Hipparcos Number", "HIP 96022"},
        {"Smithsonian Astrophysical Observation", "SAO 162719"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.85457931),
        dec: Angle.Degrees(-13.97810181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147590"},
        {"Hipparcos Number", "HIP 80282"},
        {"Smithsonian Astrophysical Observation", "SAO 159890"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.82679999),
        dec: Angle.Degrees(-13.97762381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221223"},
        {"Hipparcos Number", "HIP 116007"},
        {"Smithsonian Astrophysical Observation", "SAO 165725"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.56269534),
        dec: Angle.Degrees(-13.97746599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92770"},
        {"Hipparcos Number", "HIP 52391"},
        {"Geneva Identification System", "GEN# +1.00092770"},
        {"Smithsonian Astrophysical Observation", "SAO 156170"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.63075751),
        dec: Angle.Degrees(-13.97454499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17340"},
        {"Hipparcos Number", "HIP 12956"},
        {"Geneva Identification System", "GEN# +1.00017340"},
        {"Smithsonian Astrophysical Observation", "SAO 148594"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.64715100),
        dec: Angle.Degrees(-13.97348019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15575"},
        {"Hipparcos Number", "HIP 11624"},
        {"Smithsonian Astrophysical Observation", "SAO 148424"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.48636993),
        dec: Angle.Degrees(-13.97336179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141402"},
        {"Hipparcos Number", "HIP 77494"},
        {"Smithsonian Astrophysical Observation", "SAO 159513"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.34605219),
        dec: Angle.Degrees(-13.97130226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139909"},
        {"Hipparcos Number", "HIP 76836"},
        {"Geneva Identification System", "GEN# +1.00139909"},
        {"Smithsonian Astrophysical Observation", "SAO 159438"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.31655105),
        dec: Angle.Degrees(-13.97030297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224173"},
        {"Hipparcos Number", "HIP 117980"},
        {"Geneva Identification System", "GEN# +1.00224173"},
        {"Smithsonian Astrophysical Observation", "SAO 165957"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.95298801),
        dec: Angle.Degrees(-13.96662601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47824"},
        {"Hipparcos Number", "HIP 31892"},
        {"Smithsonian Astrophysical Observation", "SAO 151767"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.99772142),
        dec: Angle.Degrees(-13.96417297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12983",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2125 AB"},
        {"Henry Draper", "HD 17388"},
        {"Hipparcos Number", "HIP 12983"},
        {"Smithsonian Astrophysical Observation", "SAO 148601"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.75000025),
        dec: Angle.Degrees(-13.96256791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114545"},
        {"Hipparcos Number", "HIP 64346"},
        {"Smithsonian Astrophysical Observation", "SAO 157778"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.84046046),
        dec: Angle.Degrees(-13.96226819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22618"},
        {"Hipparcos Number", "HIP 16928"},
        {"Smithsonian Astrophysical Observation", "SAO 149072"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.46255106),
        dec: Angle.Degrees(-13.96157706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192840"},
        {"Hipparcos Number", "HIP 100015"},
        {"Renson", "Renson 53816"},
        {"Smithsonian Astrophysical Observation", "SAO 163419"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.37064529),
        dec: Angle.Degrees(-13.96070424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91789"},
        {"Hipparcos Number", "HIP 51860"},
        {"Geneva Identification System", "GEN# +1.00091789"},
        {"Smithsonian Astrophysical Observation", "SAO 156088"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.93129573),
        dec: Angle.Degrees(-13.95654697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185044"},
        {"Hipparcos Number", "HIP 96558"},
        {"Smithsonian Astrophysical Observation", "SAO 162831"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.45242414),
        dec: Angle.Degrees(-13.95633792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48164"},
        {"Hipparcos Number", "HIP 32033"},
        {"Smithsonian Astrophysical Observation", "SAO 151796"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.37156828),
        dec: Angle.Degrees(-13.94596996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86481"},
        {"Hipparcos Number", "HIP 48901"},
        {"Smithsonian Astrophysical Observation", "SAO 155630"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.62743143),
        dec: Angle.Degrees(-13.94152900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189559"},
        {"Hipparcos Number", "HIP 98544"},
        {"Smithsonian Astrophysical Observation", "SAO 163182"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.27652884),
        dec: Angle.Degrees(-13.94108376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29812"},
        {"Hipparcos Number", "HIP 21815"},
        {"Smithsonian Astrophysical Observation", "SAO 149825"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.31446916),
        dec: Angle.Degrees(-13.94027139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35752"},
        {"Hipparcos Number", "HIP 25431"},
        {"Geneva Identification System", "GEN# +1.00035752"},
        {"Smithsonian Astrophysical Observation", "SAO 150448"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.59002757),
        dec: Angle.Degrees(-13.93924620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37978"},
        {"Cincinnati Publication", "Ci 20 440"},
    },
    visualMagnitude: 11.50,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.76257064),
        dec: Angle.Degrees(-13.93744280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -499.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206272"},
        {"Hipparcos Number", "HIP 107082"},
        {"Geneva Identification System", "GEN# +1.00206272"},
        {"Smithsonian Astrophysical Observation", "SAO 164578"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.33394738),
        dec: Angle.Degrees(-13.93538787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83710",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10331"},
        {"Aitken 2", "ADS 10331 AB"},
        {"Henry Draper", "HD 154520"},
        {"Hipparcos Number", "HIP 83710"},
        {"Smithsonian Astrophysical Observation", "SAO 160280"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.62268691),
        dec: Angle.Degrees(-13.93474425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166103"},
        {"Hipparcos Number", "HIP 88981"},
        {"Fundamental Katalog 5th Edition", "FK5 1472"},
        {"Geneva Identification System", "GEN# +1.00166103"},
        {"Smithsonian Astrophysical Observation", "SAO 161125"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.43071298),
        dec: Angle.Degrees(-13.93442721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69232"},
        {"Cincinnati Publication", "Ci 20 835"},
        {"Geneva Identification System", "GEN# -0.01303834"},
        {"Wilson Evans Batten Catalogue", "WEB 12083"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.61366983),
        dec: Angle.Degrees(-13.93341156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -337.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -458.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97461"},
        {"Hipparcos Number", "HIP 54776"},
        {"Geneva Identification System", "GEN# +1.00097461"},
        {"Smithsonian Astrophysical Observation", "SAO 156536"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.21007504),
        dec: Angle.Degrees(-13.93334428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129157"},
        {"Hipparcos Number", "HIP 71807"},
        {"Geneva Identification System", "GEN# +1.00129157"},
        {"Smithsonian Astrophysical Observation", "SAO 158730"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.32903812),
        dec: Angle.Degrees(-13.92853144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35337"},
        {"Hipparcos Number", "HIP 25202"},
        {"Geneva Identification System", "GEN# +1.00035337"},
        {"Smithsonian Astrophysical Observation", "SAO 150396"},
        {"Wilson Evans Batten Catalogue", "WEB 4887"},
    },
    visualMagnitude: 5.25,
    bvColour: -0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.87564930),
        dec: Angle.Degrees(-13.92734983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34138"},
        {"Hipparcos Number", "HIP 24438"},
        {"Geneva Identification System", "GEN# +1.00034138"},
        {"Smithsonian Astrophysical Observation", "SAO 150266"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.64344133),
        dec: Angle.Degrees(-13.92443261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198528"},
        {"Hipparcos Number", "HIP 102935"},
        {"Geneva Identification System", "GEN# +1.00198528"},
        {"Smithsonian Astrophysical Observation", "SAO 163934"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.82930979),
        dec: Angle.Degrees(-13.92427847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8445"},
        {"Hipparcos Number", "HIP 6501"},
        {"Smithsonian Astrophysical Observation", "SAO 147777"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.87582072),
        dec: Angle.Degrees(-13.92418768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187439"},
        {"Hipparcos Number", "HIP 97618"},
        {"Smithsonian Astrophysical Observation", "SAO 163030"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.61097462),
        dec: Angle.Degrees(-13.92387402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3446"},
    },
    visualMagnitude: 12.10,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.01491158),
        dec: Angle.Degrees(-13.92323744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -296.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200968"},
        {"Hipparcos Number", "HIP 104239"},
        {"Geneva Identification System", "GEN# +1.00200968"},
        {"Smithsonian Astrophysical Observation", "SAO 164147"},
        {"Wilson Evans Batten Catalogue", "WEB 18989"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.79229538),
        dec: Angle.Degrees(-13.92281646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 382.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5033"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.11361929),
        dec: Angle.Degrees(-13.92256794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10160"},
        {"Hipparcos Number", "HIP 7694"},
        {"Smithsonian Astrophysical Observation", "SAO 147929"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.75895326),
        dec: Angle.Degrees(-13.92169274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5202"},
        {"Hipparcos Number", "HIP 4209"},
        {"Geneva Identification System", "GEN# +1.00005202"},
        {"Smithsonian Astrophysical Observation", "SAO 147503"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.42566866),
        dec: Angle.Degrees(-13.92028251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2776"},
        {"Smithsonian Astrophysical Observation", "SAO 147351"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.85908736),
        dec: Angle.Degrees(-13.91783001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223253"},
        {"Hipparcos Number", "HIP 117373"},
        {"Smithsonian Astrophysical Observation", "SAO 165889"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.98446174),
        dec: Angle.Degrees(-13.91665004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40239",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6664 AB"},
        {"Hipparcos Number", "HIP 40239"},
        {"Geneva Identification System", "GEN# -0.01302439J"},
        {"Wilson Evans Batten Catalogue", "WEB 7848"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.28587560),
        dec: Angle.Degrees(-13.91579701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -511.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37062"},
        {"New General Catalogue", "NGC 2423 15"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.24582501),
        dec: Angle.Degrees(-13.91553968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11711"},
        {"Hipparcos Number", "HIP 8900"},
        {"Smithsonian Astrophysical Observation", "SAO 148100"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.65728834),
        dec: Angle.Degrees(-13.91393354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23716",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3686 AB"},
        {"Henry Draper", "HD 32915"},
        {"Hipparcos Number", "HIP 23716"},
        {"Smithsonian Astrophysical Observation", "SAO 150137"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.47992642),
        dec: Angle.Degrees(-13.91387490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7776"},
    },
    visualMagnitude: 11.90,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.01999120),
        dec: Angle.Degrees(-13.91083122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139591"},
        {"Hipparcos Number", "HIP 76676"},
        {"Smithsonian Astrophysical Observation", "SAO 159415"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.86014772),
        dec: Angle.Degrees(-13.91078157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5056"},
        {"Hipparcos Number", "HIP 4077"},
        {"Geneva Identification System", "GEN# +1.00005056"},
        {"Smithsonian Astrophysical Observation", "SAO 147490"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.07141307),
        dec: Angle.Degrees(-13.90589084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12957"},
        {"Hipparcos Number", "HIP 9830"},
        {"Smithsonian Astrophysical Observation", "SAO 148205"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.62661037),
        dec: Angle.Degrees(-13.90504355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174029"},
        {"Hipparcos Number", "HIP 92323"},
        {"Geneva Identification System", "GEN# +1.00174029"},
        {"Smithsonian Astrophysical Observation", "SAO 161856"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.24743792),
        dec: Angle.Degrees(-13.90498474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76510"},
        {"Hipparcos Number", "HIP 43868"},
        {"Geneva Identification System", "GEN# +1.00076510"},
        {"Smithsonian Astrophysical Observation", "SAO 154766"},
        {"Wilson Evans Batten Catalogue", "WEB 8437"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.05055529),
        dec: Angle.Degrees(-13.90455685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 666"},
        {"Hipparcos Number", "HIP 887"},
        {"Smithsonian Astrophysical Observation", "SAO 147129"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.72283989),
        dec: Angle.Degrees(-13.90281571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81766"},
        {"Hipparcos Number", "HIP 46362"},
        {"Smithsonian Astrophysical Observation", "SAO 155205"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.79795632),
        dec: Angle.Degrees(-13.90122919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36589"},
        {"Smithsonian Astrophysical Observation", "SAO 153005"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.87734653),
        dec: Angle.Degrees(-13.90094855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131789"},
        {"Hipparcos Number", "HIP 73064"},
        {"Geneva Identification System", "GEN# +1.00131789"},
        {"Smithsonian Astrophysical Observation", "SAO 158901"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.97163768),
        dec: Angle.Degrees(-13.90067257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182477"},
        {"Hipparcos Number", "HIP 95485"},
        {"Fundamental Katalog 5th Edition", "FK5 3552"},
        {"Geneva Identification System", "GEN# +1.00182477"},
        {"Smithsonian Astrophysical Observation", "SAO 162595"},
        {"Wilson Evans Batten Catalogue", "WEB 16693"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.33984203),
        dec: Angle.Degrees(-13.89726417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38382",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6420 AB"},
        {"Henry Draper", "HD 64096"},
        {"Hipparcos Number", "HIP 38382"},
        {"Geneva Identification System", "GEN# +1.00064096"},
        {"Smithsonian Astrophysical Observation", "SAO 153500"},
        {"Wilson Evans Batten Catalogue", "WEB 7550"},
    },
    visualMagnitude: 5.16,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.94309895),
        dec: Angle.Degrees(-13.89719057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -344.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205972"},
        {"Hipparcos Number", "HIP 106922"},
        {"Smithsonian Astrophysical Observation", "SAO 164548"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.81327350),
        dec: Angle.Degrees(-13.89471839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8766"},
        {"Hipparcos Number", "HIP 6707"},
        {"Smithsonian Astrophysical Observation", "SAO 147808"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.56879994),
        dec: Angle.Degrees(-13.89364006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112945"},
        {"Hipparcos Number", "HIP 63477"},
        {"Geneva Identification System", "GEN# +1.00112945"},
        {"Smithsonian Astrophysical Observation", "SAO 157650"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.10519029),
        dec: Angle.Degrees(-13.89241578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210296"},
        {"Hipparcos Number", "HIP 109395"},
        {"Smithsonian Astrophysical Observation", "SAO 164897"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.43723300),
        dec: Angle.Degrees(-13.89158139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220277"},
        {"Hipparcos Number", "HIP 115401"},
        {"Smithsonian Astrophysical Observation", "SAO 165657"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.65710495),
        dec: Angle.Degrees(-13.89115270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144377"},
        {"Hipparcos Number", "HIP 78880"},
        {"Smithsonian Astrophysical Observation", "SAO 159689"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.53151899),
        dec: Angle.Degrees(-13.89080987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8142"},
        {"Hipparcos Number", "HIP 6288"},
        {"Fundamental Katalog 5th Edition", "FK5 4122"},
        {"Geneva Identification System", "GEN# +1.00008142"},
        {"Smithsonian Astrophysical Observation", "SAO 147750"},
        {"Wilson Evans Batten Catalogue", "WEB 1404"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.16927146),
        dec: Angle.Degrees(-13.88999394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10920"},
        {"Hipparcos Number", "HIP 8296"},
        {"Fundamental Katalog 5th Edition", "FK5 4162"},
        {"Geneva Identification System", "GEN# +1.00010920"},
        {"Smithsonian Astrophysical Observation", "SAO 148008"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.74308789),
        dec: Angle.Degrees(-13.88873674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56803"},
        {"Hipparcos Number", "HIP 35337"},
        {"Geneva Identification System", "GEN# +1.00056803"},
        {"Smithsonian Astrophysical Observation", "SAO 152681"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.49027591),
        dec: Angle.Degrees(-13.88768200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223325"},
        {"Hipparcos Number", "HIP 117432"},
        {"Geneva Identification System", "GEN# +1.00223325"},
        {"Smithsonian Astrophysical Observation", "SAO 165896"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.16394676),
        dec: Angle.Degrees(-13.88672984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24091"},
        {"Hipparcos Number", "HIP 17903"},
        {"Smithsonian Astrophysical Observation", "SAO 149192"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.43267263),
        dec: Angle.Degrees(-13.88642827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61609"},
        {"Hipparcos Number", "HIP 37310"},
        {"Smithsonian Astrophysical Observation", "SAO 153206"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.89789716),
        dec: Angle.Degrees(-13.88555097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3749"},
        {"Hipparcos Number", "HIP 3151"},
        {"Smithsonian Astrophysical Observation", "SAO 147392"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.01631804),
        dec: Angle.Degrees(-13.88478789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98551"},
        {"Hipparcos Number", "HIP 55365"},
        {"Smithsonian Astrophysical Observation", "SAO 156615"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.05352389),
        dec: Angle.Degrees(-13.88459181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27700"},
        {"Hipparcos Number", "HIP 20379"},
        {"Smithsonian Astrophysical Observation", "SAO 149579"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.45952613),
        dec: Angle.Degrees(-13.88189839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15189"},
        {"Hipparcos Number", "HIP 11367"},
        {"Smithsonian Astrophysical Observation", "SAO 148387"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.60975205),
        dec: Angle.Degrees(-13.87976596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35124"},
        {"Hipparcos Number", "HIP 25055"},
        {"Smithsonian Astrophysical Observation", "SAO 150376"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.47291701),
        dec: Angle.Degrees(-13.87843952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33592"},
        {"Hipparcos Number", "HIP 24115"},
        {"Smithsonian Astrophysical Observation", "SAO 150200"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.68731552),
        dec: Angle.Degrees(-13.87778710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197297"},
        {"Hipparcos Number", "HIP 102257"},
        {"Smithsonian Astrophysical Observation", "SAO 163821"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.80522628),
        dec: Angle.Degrees(-13.87630276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37083"},
        {"New General Catalogue", "NGC 2423 6"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.30639134),
        dec: Angle.Degrees(-13.87539305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92958"},
        {"Hipparcos Number", "HIP 52490"},
        {"Smithsonian Astrophysical Observation", "SAO 156186"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.97047152),
        dec: Angle.Degrees(-13.87312634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12204"},
        {"Hipparcos Number", "HIP 9300"},
        {"Smithsonian Astrophysical Observation", "SAO 148144"},
        {"Wilson Evans Batten Catalogue", "WEB 1952"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.87925803),
        dec: Angle.Degrees(-13.87248328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210791"},
        {"Hipparcos Number", "HIP 109683"},
        {"Smithsonian Astrophysical Observation", "SAO 164931"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.27592640),
        dec: Angle.Degrees(-13.87105771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36836",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6189 A"},
        {"Henry Draper", "HD 60552"},
        {"Hipparcos Number", "HIP 36836"},
        {"Geneva Identification System", "GEN# +1.00060552"},
        {"Smithsonian Astrophysical Observation", "SAO 153083"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.62049049),
        dec: Angle.Degrees(-13.87040541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171344"},
        {"Hipparcos Number", "HIP 91100"},
        {"Geneva Identification System", "GEN# +1.00171344"},
        {"Wilson Evans Batten Catalogue", "WEB 15634"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.73987834),
        dec: Angle.Degrees(-13.87010468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37701"},
        {"Hipparcos Number", "HIP 26654"},
        {"Smithsonian Astrophysical Observation", "SAO 150661"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.97353588),
        dec: Angle.Degrees(-13.86985119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29958"},
        {"Geneva Identification System", "GEN# -0.01301434"},
        {"Wilson Evans Batten Catalogue", "WEB 5941"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.59201416),
        dec: Angle.Degrees(-13.86965600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 341.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209819"},
        {"Hipparcos Number", "HIP 109139"},
        {"Fundamental Katalog 5th Edition", "FK5 828"},
        {"Geneva Identification System", "GEN# +1.00209819"},
        {"Smithsonian Astrophysical Observation", "SAO 164861"},
        {"Wilson Evans Batten Catalogue", "WEB 19620"},
    },
    visualMagnitude: 4.29,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.60918894),
        dec: Angle.Degrees(-13.86954013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73874"},
        {"Hipparcos Number", "HIP 42522"},
        {"Smithsonian Astrophysical Observation", "SAO 154519"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.04398483),
        dec: Angle.Degrees(-13.86926231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205526"},
        {"Hipparcos Number", "HIP 106653"},
        {"Smithsonian Astrophysical Observation", "SAO 164507"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.04340372),
        dec: Angle.Degrees(-13.86839233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82889"},
        {"Hipparcos Number", "HIP 46973"},
        {"Smithsonian Astrophysical Observation", "SAO 155306"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.60866506),
        dec: Angle.Degrees(-13.86682319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194487"},
        {"Hipparcos Number", "HIP 100800"},
        {"Geneva Identification System", "GEN# +1.00194487"},
        {"Smithsonian Astrophysical Observation", "SAO 163571"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.57182436),
        dec: Angle.Degrees(-13.86306760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38436",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6426 A"},
        {"Henry Draper", "HD 64259"},
        {"Hipparcos Number", "HIP 38436"},
        {"Geneva Identification System", "GEN# +1.00064259"},
        {"Smithsonian Astrophysical Observation", "SAO 153522"},
        {"Wilson Evans Batten Catalogue", "WEB 7558"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.11811343),
        dec: Angle.Degrees(-13.86258320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48517"},
        {"Hipparcos Number", "HIP 32197"},
        {"Smithsonian Astrophysical Observation", "SAO 151839"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.81642240),
        dec: Angle.Degrees(-13.86181605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155106"},
        {"Hipparcos Number", "HIP 83997"},
        {"Smithsonian Astrophysical Observation", "SAO 160329"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.55577722),
        dec: Angle.Degrees(-13.86077922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124304"},
        {"Hipparcos Number", "HIP 69449"},
        {"Smithsonian Astrophysical Observation", "SAO 158431"},
        {"Wilson Evans Batten Catalogue", "WEB 12105"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.29082892),
        dec: Angle.Degrees(-13.85987685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35794"},
        {"Hipparcos Number", "HIP 25454"},
        {"Smithsonian Astrophysical Observation", "SAO 150452"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.66335982),
        dec: Angle.Degrees(-13.85952613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110616"},
        {"Hipparcos Number", "HIP 62096"},
        {"Smithsonian Astrophysical Observation", "SAO 157470"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.88764192),
        dec: Angle.Degrees(-13.85949886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109141"},
        {"Hipparcos Number", "HIP 61212"},
        {"Geneva Identification System", "GEN# +1.00109141"},
        {"Smithsonian Astrophysical Observation", "SAO 157350"},
        {"Wilson Evans Batten Catalogue", "WEB 10895"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.15036083),
        dec: Angle.Degrees(-13.85897407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17081"},
        {"Hipparcos Number", "HIP 12770"},
        {"Fundamental Katalog 5th Edition", "FK5 97"},
        {"Geneva Identification System", "GEN# +1.00017081"},
        {"Smithsonian Astrophysical Observation", "SAO 148575"},
        {"Wilson Evans Batten Catalogue", "WEB 2595"},
    },
    visualMagnitude: 4.24,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.03064356),
        dec: Angle.Degrees(-13.85867594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78780"},
        {"Hipparcos Number", "HIP 44974"},
        {"Smithsonian Astrophysical Observation", "SAO 154961"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.42088100),
        dec: Angle.Degrees(-13.85736525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214811"},
        {"Hipparcos Number", "HIP 111979"},
        {"Smithsonian Astrophysical Observation", "SAO 165231"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.23483090),
        dec: Angle.Degrees(-13.85628368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68672"},
        {"Hipparcos Number", "HIP 40228"},
        {"Smithsonian Astrophysical Observation", "SAO 153982"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.23725510),
        dec: Angle.Degrees(-13.85568774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129271"},
        {"Hipparcos Number", "HIP 71875"},
        {"Geneva Identification System", "GEN# +1.00129271"},
        {"Smithsonian Astrophysical Observation", "SAO 158741"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.51210182),
        dec: Angle.Degrees(-13.85404248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76789"},
        {"Smithsonian Astrophysical Observation", "SAO 159431"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.18235794),
        dec: Angle.Degrees(-13.85359644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61347"},
        {"Hipparcos Number", "HIP 37169"},
        {"Geneva Identification System", "GEN# +1.00061347"},
        {"Smithsonian Astrophysical Observation", "SAO 153183"},
        {"Wilson Evans Batten Catalogue", "WEB 7366"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.56715225),
        dec: Angle.Degrees(-13.85034870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39089",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6509 AB"},
        {"Henry Draper", "HD 65783"},
        {"Hipparcos Number", "HIP 39089"},
        {"Smithsonian Astrophysical Observation", "SAO 153684"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.95038741),
        dec: Angle.Degrees(-13.85002320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148183"},
        {"Hipparcos Number", "HIP 80560"},
        {"Smithsonian Astrophysical Observation", "SAO 159917"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.71098928),
        dec: Angle.Degrees(-13.84851797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62217"},
        {"Hipparcos Number", "HIP 37552"},
        {"Smithsonian Astrophysical Observation", "SAO 153278"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.60392674),
        dec: Angle.Degrees(-13.84847682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114962",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16644 AB"},
        {"Henry Draper", "HD 219617"},
        {"Hipparcos Number", "HIP 114962"},
        {"Cincinnati Publication", "Ci 18 3048"},
        {"Cincinnati Publication 2", "Ci 20 1413"},
        {"Geneva Identification System", "GEN# +1.00219617J"},
        {"Smithsonian Astrophysical Observation", "SAO 165604"},
        {"Wilson Evans Batten Catalogue", "WEB 20368"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.27226912),
        dec: Angle.Degrees(-13.84810055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -502.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1190.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91477"},
        {"Geneva Identification System", "GEN# -0.01305061"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.85877062),
        dec: Angle.Degrees(-13.84641781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17691"},
        {"Hipparcos Number", "HIP 13207"},
        {"Smithsonian Astrophysical Observation", "SAO 148630"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.49182257),
        dec: Angle.Degrees(-13.84626358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177338"},
        {"Hipparcos Number", "HIP 93697"},
        {"Renson", "Renson 49460"},
        {"Smithsonian Astrophysical Observation", "SAO 162165"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.20074291),
        dec: Angle.Degrees(-13.84560538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25712"},
        {"Hipparcos Number", "HIP 19000"},
        {"Smithsonian Astrophysical Observation", "SAO 149346"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.06199312),
        dec: Angle.Degrees(-13.84516455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91901"},
        {"Hipparcos Number", "HIP 51931"},
        {"Geneva Identification System", "GEN# +1.00091901"},
        {"Smithsonian Astrophysical Observation", "SAO 156096"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.12871007),
        dec: Angle.Degrees(-13.84334034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129757"},
        {"Hipparcos Number", "HIP 72084"},
        {"Smithsonian Astrophysical Observation", "SAO 158769"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.19278918),
        dec: Angle.Degrees(-13.84283499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65845"},
        {"Hipparcos Number", "HIP 39130"},
        {"Smithsonian Astrophysical Observation", "SAO 153692"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.06967143),
        dec: Angle.Degrees(-13.83923886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49067"},
        {"Hipparcos Number", "HIP 32420"},
        {"Geneva Identification System", "GEN# +1.00049067"},
        {"Smithsonian Astrophysical Observation", "SAO 151897"},
        {"Wilson Evans Batten Catalogue", "WEB 6538"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.51611508),
        dec: Angle.Degrees(-13.83820384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215541"},
        {"Hipparcos Number", "HIP 112412"},
        {"Smithsonian Astrophysical Observation", "SAO 165281"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.52750241),
        dec: Angle.Degrees(-13.83603451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99765"},
        {"Geneva Identification System", "GEN# -0.01405679"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.61841017),
        dec: Angle.Degrees(-13.83549255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79914"},
        {"Hipparcos Number", "HIP 45511"},
        {"Geneva Identification System", "GEN# +1.00079914"},
        {"Smithsonian Astrophysical Observation", "SAO 155048"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.11490359),
        dec: Angle.Degrees(-13.83416387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171571"},
        {"Hipparcos Number", "HIP 91194"},
        {"Smithsonian Astrophysical Observation", "SAO 161651"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.05140088),
        dec: Angle.Degrees(-13.83381079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20573"},
        {"Hipparcos Number", "HIP 15373"},
        {"Smithsonian Astrophysical Observation", "SAO 148893"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.55818511),
        dec: Angle.Degrees(-13.82925874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89743"},
        {"Geneva Identification System", "GEN# +2.66110367"},
        {"Wilson Evans Batten Catalogue", "WEB 15301"},
        {"New General Catalogue", "NGC 6611 367"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.71947795),
        dec: Angle.Degrees(-13.82850626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20268"},
        {"Hipparcos Number", "HIP 15127"},
        {"Geneva Identification System", "GEN# +1.00020268"},
        {"Smithsonian Astrophysical Observation", "SAO 148858"},
        {"Wilson Evans Batten Catalogue", "WEB 2914"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.77002630),
        dec: Angle.Degrees(-13.82794262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25392"},
        {"Hipparcos Number", "HIP 18796"},
        {"Smithsonian Astrophysical Observation", "SAO 149321"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.40691297),
        dec: Angle.Degrees(-13.82501988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60760"},
        {"Hipparcos Number", "HIP 36939"},
        {"Smithsonian Astrophysical Observation", "SAO 153109"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.90138230),
        dec: Angle.Degrees(-13.82357009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53777"},
        {"Hipparcos Number", "HIP 34233"},
        {"Geneva Identification System", "GEN# +1.00053777"},
        {"Smithsonian Astrophysical Observation", "SAO 152367"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.45343206),
        dec: Angle.Degrees(-13.82323639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37189"},
        {"Hipparcos Number", "HIP 26308"},
        {"Geneva Identification System", "GEN# +1.00037189"},
        {"Renson", "Renson 9940"},
        {"Smithsonian Astrophysical Observation", "SAO 150600"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.04072266),
        dec: Angle.Degrees(-13.82231118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151345"},
        {"Hipparcos Number", "HIP 82179"},
        {"Smithsonian Astrophysical Observation", "SAO 160095"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.84243071),
        dec: Angle.Degrees(-13.81912183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124333"},
        {"Hipparcos Number", "HIP 69464"},
        {"Smithsonian Astrophysical Observation", "SAO 158435"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.32252890),
        dec: Angle.Degrees(-13.81910013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113173"},
        {"Hipparcos Number", "HIP 63593"},
        {"Smithsonian Astrophysical Observation", "SAO 157665"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.48240951),
        dec: Angle.Degrees(-13.81876805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66076"},
        {"Smithsonian Astrophysical Observation", "SAO 157995"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.17904194),
        dec: Angle.Degrees(-13.81754619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106624"},
        {"Hipparcos Number", "HIP 59807"},
        {"Smithsonian Astrophysical Observation", "SAO 157177"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.95793027),
        dec: Angle.Degrees(-13.81670238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126330"},
        {"Hipparcos Number", "HIP 70496"},
        {"Smithsonian Astrophysical Observation", "SAO 158553"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.29876336),
        dec: Angle.Degrees(-13.81617803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12737"},
        {"Hipparcos Number", "HIP 9681"},
        {"Smithsonian Astrophysical Observation", "SAO 148182"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.12990332),
        dec: Angle.Degrees(-13.81325833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 780"},
        {"Hipparcos Number", "HIP 973"},
        {"Geneva Identification System", "GEN# +1.00000780"},
        {"Smithsonian Astrophysical Observation", "SAO 147142"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.01259645),
        dec: Angle.Degrees(-13.81313737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213449"},
        {"Hipparcos Number", "HIP 111194"},
        {"Smithsonian Astrophysical Observation", "SAO 165145"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.89960538),
        dec: Angle.Degrees(-13.81236822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143783"},
        {"Hipparcos Number", "HIP 78600"},
        {"Geneva Identification System", "GEN# +1.00143783"},
        {"Smithsonian Astrophysical Observation", "SAO 159653"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.71541602),
        dec: Angle.Degrees(-13.81202764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108318",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108318"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.16761806),
        dec: Angle.Degrees(-13.81135793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 229.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168137"},
        {"Hipparcos Number", "HIP 89750"},
        {"Geneva Identification System", "GEN# +2.66110401"},
        {"Geneva Identification System 2", "GEN# +1.00168137"},
        {"Smithsonian Astrophysical Observation", "SAO 161316"},
        {"Wilson Evans Batten Catalogue", "WEB 15300"},
        {"New General Catalogue", "NGC 6611 401"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.73412241),
        dec: Angle.Degrees(-13.80863290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40593"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.31934937),
        dec: Angle.Degrees(-13.80847569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80685"},
        {"Hipparcos Number", "HIP 45841"},
        {"Geneva Identification System", "GEN# +1.00080685"},
        {"Smithsonian Astrophysical Observation", "SAO 155110"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.19408532),
        dec: Angle.Degrees(-13.80763837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100578"},
        {"Hipparcos Number", "HIP 56450"},
        {"Smithsonian Astrophysical Observation", "SAO 156760"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.61653260),
        dec: Angle.Degrees(-13.80725884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39377"},
        {"Hipparcos Number", "HIP 27678"},
        {"Smithsonian Astrophysical Observation", "SAO 150874"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.89777573),
        dec: Angle.Degrees(-13.80494876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97516"},
        {"Hipparcos Number", "HIP 54815"},
        {"Smithsonian Astrophysical Observation", "SAO 156540"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.32364664),
        dec: Angle.Degrees(-13.80322115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58628"},
        {"Hipparcos Number", "HIP 36067"},
        {"Smithsonian Astrophysical Observation", "SAO 152858"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.48247221),
        dec: Angle.Degrees(-13.80180294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16064"},
        {"Hipparcos Number", "HIP 11969"},
        {"Smithsonian Astrophysical Observation", "SAO 148476"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.60270982),
        dec: Angle.Degrees(-13.80073012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213003"},
        {"Hipparcos Number", "HIP 110941"},
        {"Smithsonian Astrophysical Observation", "SAO 165103"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.17207927),
        dec: Angle.Degrees(-13.80069656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42606"},
        {"Hipparcos Number", "HIP 29330"},
        {"Geneva Identification System", "GEN# +1.00042606"},
        {"Smithsonian Astrophysical Observation", "SAO 151196"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.76308887),
        dec: Angle.Degrees(-13.80066379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90845"},
        {"Hipparcos Number", "HIP 51328"},
        {"Smithsonian Astrophysical Observation", "SAO 156009"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.26707607),
        dec: Angle.Degrees(-13.79982984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68146"},
        {"Hipparcos Number", "HIP 40035"},
        {"Fundamental Katalog 5th Edition", "FK5 2637"},
        {"Geneva Identification System", "GEN# +1.00068146"},
        {"Smithsonian Astrophysical Observation", "SAO 153924"},
        {"Wilson Evans Batten Catalogue", "WEB 7809"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.66656902),
        dec: Angle.Degrees(-13.79934746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204464"},
        {"Hipparcos Number", "HIP 106068"},
        {"Smithsonian Astrophysical Observation", "SAO 164424"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.26721563),
        dec: Angle.Degrees(-13.79775270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88899"},
        {"Hipparcos Number", "HIP 50212"},
        {"Smithsonian Astrophysical Observation", "SAO 155846"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.75540186),
        dec: Angle.Degrees(-13.79679072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219702"},
        {"Hipparcos Number", "HIP 115038"},
        {"Geneva Identification System", "GEN# +1.00219702"},
        {"Smithsonian Astrophysical Observation", "SAO 165614"},
        {"Wilson Evans Batten Catalogue", "WEB 20379"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.48575859),
        dec: Angle.Degrees(-13.79514481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108275"},
        {"Hipparcos Number", "HIP 60711"},
        {"Geneva Identification System", "GEN# +1.00108275"},
        {"Smithsonian Astrophysical Observation", "SAO 157287"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.63260855),
        dec: Angle.Degrees(-13.79491742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91669"},
        {"Hipparcos Number", "HIP 51789"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.72648511),
        dec: Angle.Degrees(-13.78752286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92719"},
        {"Hipparcos Number", "HIP 52369"},
        {"Geneva Identification System", "GEN# +1.00092719"},
        {"Smithsonian Astrophysical Observation", "SAO 156167"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.55491694),
        dec: Angle.Degrees(-13.78729520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 235.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89746"},
        {"Hipparcos Number", "HIP 50705"},
        {"Geneva Identification System", "GEN# +1.00089746"},
        {"Smithsonian Astrophysical Observation", "SAO 155922"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.31070586),
        dec: Angle.Degrees(-13.78651564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34527"},
        {"Wilson Evans Batten Catalogue", "WEB 6914"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.31421524),
        dec: Angle.Degrees(-13.78608859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188336"},
        {"Hipparcos Number", "HIP 98014"},
        {"Smithsonian Astrophysical Observation", "SAO 163104"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.77190408),
        dec: Angle.Degrees(-13.78337134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164222"},
        {"Hipparcos Number", "HIP 88201"},
        {"Smithsonian Astrophysical Observation", "SAO 160990"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.18163945),
        dec: Angle.Degrees(-13.78020181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195451"},
        {"Hipparcos Number", "HIP 101293"},
        {"Smithsonian Astrophysical Observation", "SAO 163657"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.96968557),
        dec: Angle.Degrees(-13.77810405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209684"},
        {"Hipparcos Number", "HIP 109051"},
        {"Geneva Identification System", "GEN# +1.00209684"},
        {"Smithsonian Astrophysical Observation", "SAO 164851"},
    },
    visualMagnitude: 9.84,
    bvColour: -0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.37981370),
        dec: Angle.Degrees(-13.77022963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30743"},
        {"Hipparcos Number", "HIP 22439"},
        {"Fundamental Katalog 5th Edition", "FK5 2363"},
        {"Geneva Identification System", "GEN# +1.00030743"},
        {"Smithsonian Astrophysical Observation", "SAO 149916"},
        {"Wilson Evans Batten Catalogue", "WEB 4328"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.42631902),
        dec: Angle.Degrees(-13.76924994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144821"},
        {"Hipparcos Number", "HIP 79059"},
        {"Geneva Identification System", "GEN# +1.00144821"},
        {"Smithsonian Astrophysical Observation", "SAO 159728"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.06939045),
        dec: Angle.Degrees(-13.76883917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70522"},
        {"Hipparcos Number", "HIP 40997"},
        {"Smithsonian Astrophysical Observation", "SAO 154160"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.50085078),
        dec: Angle.Degrees(-13.76837343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126948"},
        {"Hipparcos Number", "HIP 70815"},
        {"Smithsonian Astrophysical Observation", "SAO 158592"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.23410624),
        dec: Angle.Degrees(-13.76571033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130009"},
        {"Hipparcos Number", "HIP 72209"},
        {"Smithsonian Astrophysical Observation", "SAO 158790"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.52613726),
        dec: Angle.Degrees(-13.76520876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24803"},
        {"Hipparcos Number", "HIP 18410"},
        {"Renson", "Renson 6336"},
        {"Smithsonian Astrophysical Observation", "SAO 149264"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.04023439),
        dec: Angle.Degrees(-13.76482471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19467"},
        {"Hipparcos Number", "HIP 14501"},
        {"Fundamental Katalog 5th Edition", "FK5 1087"},
        {"Geneva Identification System", "GEN# +1.00019467"},
        {"Smithsonian Astrophysical Observation", "SAO 148780"},
        {"Wilson Evans Batten Catalogue", "WEB 2820"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.82741621),
        dec: Angle.Degrees(-13.76114966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -260.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3648",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 653 AB"},
        {"Henry Draper", "HD 4468"},
        {"Hipparcos Number", "HIP 3648"},
        {"Smithsonian Astrophysical Observation", "SAO 147441"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.67677760),
        dec: Angle.Degrees(-13.76112563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6426"},
        {"Hipparcos Number", "HIP 5080"},
        {"Fundamental Katalog 5th Edition", "FK5 4099"},
        {"Smithsonian Astrophysical Observation", "SAO 147597"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.26618365),
        dec: Angle.Degrees(-13.75949883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92213"},
        {"Hipparcos Number", "HIP 52089"},
        {"Smithsonian Astrophysical Observation", "SAO 156123"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.65852834),
        dec: Angle.Degrees(-13.75932181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94481"},
        {"Hipparcos Number", "HIP 53316"},
        {"Fundamental Katalog 5th Edition", "FK5 2871"},
        {"Geneva Identification System", "GEN# +1.00094481"},
        {"Smithsonian Astrophysical Observation", "SAO 156310"},
        {"Wilson Evans Batten Catalogue", "WEB 9681"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.57408704),
        dec: Angle.Degrees(-13.75805882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14820"},
        {"Hipparcos Number", "HIP 11107"},
        {"Smithsonian Astrophysical Observation", "SAO 148364"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.73692662),
        dec: Angle.Degrees(-13.75613755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35104"},
        {"Hipparcos Number", "HIP 25053"},
        {"Geneva Identification System", "GEN# +1.00035104"},
        {"Smithsonian Astrophysical Observation", "SAO 150375"},
        {"Wilson Evans Batten Catalogue", "WEB 4857"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.46246281),
        dec: Angle.Degrees(-13.75570183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103753"},
        {"Hipparcos Number", "HIP 58264"},
        {"Geneva Identification System", "GEN# +1.00103753"},
        {"Smithsonian Astrophysical Observation", "SAO 157003"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.23419740),
        dec: Angle.Degrees(-13.75420997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224133"},
        {"Hipparcos Number", "HIP 117950"},
        {"Cincinnati Publication", "Ci 18 3135"},
        {"Smithsonian Astrophysical Observation", "SAO 165954"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.87835156),
        dec: Angle.Degrees(-13.75280764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218238"},
        {"Hipparcos Number", "HIP 114094"},
        {"Smithsonian Astrophysical Observation", "SAO 165496"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.62620965),
        dec: Angle.Degrees(-13.75204362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58461"},
        {"Hipparcos Number", "HIP 35998"},
        {"Fundamental Katalog 5th Edition", "FK5 1192"},
        {"Geneva Identification System", "GEN# +1.00058461"},
        {"Smithsonian Astrophysical Observation", "SAO 152840"},
        {"Wilson Evans Batten Catalogue", "WEB 7168"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.28515547),
        dec: Angle.Degrees(-13.75197556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99363"},
        {"Hipparcos Number", "HIP 55795"},
        {"Geneva Identification System", "GEN# +1.00099363"},
        {"Smithsonian Astrophysical Observation", "SAO 156672"},
        {"Wilson Evans Batten Catalogue", "WEB 10029"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.47506157),
        dec: Angle.Degrees(-13.75131424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198557"},
        {"Hipparcos Number", "HIP 102955"},
        {"Smithsonian Astrophysical Observation", "SAO 163937"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.89211948),
        dec: Angle.Degrees(-13.74999119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 554"},
        {"Smithsonian Astrophysical Observation", "SAO 147087"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.69303391),
        dec: Angle.Degrees(-13.74868727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131116"},
        {"Hipparcos Number", "HIP 72716"},
        {"Smithsonian Astrophysical Observation", "SAO 158863"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.00530462),
        dec: Angle.Degrees(-13.74841336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7494"},
        {"Hipparcos Number", "HIP 5835"},
        {"Geneva Identification System", "GEN# +1.00007494"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.70766885),
        dec: Angle.Degrees(-13.74779379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47009"},
        {"Hipparcos Number", "HIP 31497"},
        {"Renson", "Renson 12587"},
        {"Smithsonian Astrophysical Observation", "SAO 151679"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.95240207),
        dec: Angle.Degrees(-13.74711436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83495"},
        {"Hipparcos Number", "HIP 47318"},
        {"Smithsonian Astrophysical Observation", "SAO 155364"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.62630651),
        dec: Angle.Degrees(-13.74689984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108647",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15534 AB"},
        {"Henry Draper", "HD 209028"},
        {"Hipparcos Number", "HIP 108647"},
        {"Smithsonian Astrophysical Observation", "SAO 164809"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.15914449),
        dec: Angle.Degrees(-13.74586615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67914"},
        {"Hipparcos Number", "HIP 39973"},
        {"Smithsonian Astrophysical Observation", "SAO 153904"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.44470583),
        dec: Angle.Degrees(-13.74507624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51197"},
        {"Hipparcos Number", "HIP 33318"},
        {"Geneva Identification System", "GEN# +1.00051197"},
        {"Smithsonian Astrophysical Observation", "SAO 152115"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.95361121),
        dec: Angle.Degrees(-13.74349385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154963"},
        {"Hipparcos Number", "HIP 83927"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.32108900),
        dec: Angle.Degrees(-13.74303665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154661"},
        {"Hipparcos Number", "HIP 83777"},
        {"Smithsonian Astrophysical Observation", "SAO 160290"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.84132660),
        dec: Angle.Degrees(-13.74101335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216726"},
        {"Hipparcos Number", "HIP 113194"},
        {"Geneva Identification System", "GEN# +1.00216726"},
        {"Smithsonian Astrophysical Observation", "SAO 165381"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.84733822),
        dec: Angle.Degrees(-13.74063749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86624"},
        {"Hipparcos Number", "HIP 48972"},
        {"Renson", "Renson 24780"},
        {"Smithsonian Astrophysical Observation", "SAO 155637"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.84545988),
        dec: Angle.Degrees(-13.74050707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121445"},
        {"Hipparcos Number", "HIP 68016"},
        {"Geneva Identification System", "GEN# +1.00121445"},
        {"Smithsonian Astrophysical Observation", "SAO 158238"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.92317211),
        dec: Angle.Degrees(-13.74022826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145593"},
        {"Hipparcos Number", "HIP 79407"},
        {"Smithsonian Astrophysical Observation", "SAO 159772"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.08542927),
        dec: Angle.Degrees(-13.73855723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82058"},
        {"Hipparcos Number", "HIP 46519"},
        {"Smithsonian Astrophysical Observation", "SAO 155229"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.32171222),
        dec: Angle.Degrees(-13.73681977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25829"},
        {"Smithsonian Astrophysical Observation", "SAO 150519"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.71879236),
        dec: Angle.Degrees(-13.73456825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137272"},
        {"Hipparcos Number", "HIP 75511"},
        {"Smithsonian Astrophysical Observation", "SAO 159249"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.38651002),
        dec: Angle.Degrees(-13.73452629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157378"},
        {"Hipparcos Number", "HIP 85092"},
        {"Smithsonian Astrophysical Observation", "SAO 160514"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.86669012),
        dec: Angle.Degrees(-13.73411380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124934"},
        {"Hipparcos Number", "HIP 69769"},
        {"Smithsonian Astrophysical Observation", "SAO 158460"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.18238753),
        dec: Angle.Degrees(-13.73283903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64920"},
        {"Hipparcos Number", "HIP 38724"},
        {"Geneva Identification System", "GEN# +1.00064920"},
        {"Renson", "Renson 17816"},
        {"Smithsonian Astrophysical Observation", "SAO 153594"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.92183865),
        dec: Angle.Degrees(-13.73246232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75704"},
        {"Hipparcos Number", "HIP 43461"},
        {"Smithsonian Astrophysical Observation", "SAO 154689"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.78483608),
        dec: Angle.Degrees(-13.73186214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84311"},
        {"Hipparcos Number", "HIP 47754"},
        {"Smithsonian Astrophysical Observation", "SAO 155438"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.03143266),
        dec: Angle.Degrees(-13.72353368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195838"},
        {"Hipparcos Number", "HIP 101507"},
        {"Fundamental Katalog 5th Edition", "FK5 3645"},
        {"Geneva Identification System", "GEN# +1.00195838"},
        {"Smithsonian Astrophysical Observation", "SAO 163686"},
        {"Wilson Evans Batten Catalogue", "WEB 18341"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.54856618),
        dec: Angle.Degrees(-13.72126202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149663"},
        {"Hipparcos Number", "HIP 81339"},
        {"Geneva Identification System", "GEN# +1.00149663"},
        {"Smithsonian Astrophysical Observation", "SAO 160003"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.18842627),
        dec: Angle.Degrees(-13.72090528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45359"},
        {"Hipparcos Number", "HIP 30642"},
        {"Smithsonian Astrophysical Observation", "SAO 151505"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.59557699),
        dec: Angle.Degrees(-13.71986290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43445"},
        {"Hipparcos Number", "HIP 29735"},
        {"Geneva Identification System", "GEN# +1.00043445"},
        {"Smithsonian Astrophysical Observation", "SAO 151283"},
        {"Wilson Evans Batten Catalogue", "WEB 5867"},
    },
    visualMagnitude: 5.00,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.93699498),
        dec: Angle.Degrees(-13.71838696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218554"},
        {"Hipparcos Number", "HIP 114311"},
        {"Smithsonian Astrophysical Observation", "SAO 165514"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.25868878),
        dec: Angle.Degrees(-13.71654636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84023"},
        {"Smithsonian Astrophysical Observation", "SAO 160333"},
    },
    visualMagnitude: 9.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.63645151),
        dec: Angle.Degrees(-13.71595161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2705"},
        {"Hipparcos Number", "HIP 2399"},
        {"Smithsonian Astrophysical Observation", "SAO 147314"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.64485277),
        dec: Angle.Degrees(-13.71524351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102085"},
        {"Hipparcos Number", "HIP 57288"},
        {"Smithsonian Astrophysical Observation", "SAO 156870"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.20212316),
        dec: Angle.Degrees(-13.71505965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222192"},
        {"Hipparcos Number", "HIP 116665"},
        {"Geneva Identification System", "GEN# +1.00222192"},
        {"Renson", "Renson 60894"},
        {"Smithsonian Astrophysical Observation", "SAO 165810"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.63923653),
        dec: Angle.Degrees(-13.71226581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70011",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9219 A"},
        {"Henry Draper", "HD 125414"},
        {"Henry Draper 2", "HD 125414A"},
        {"Hipparcos Number", "HIP 70011"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.88214789),
        dec: Angle.Degrees(-13.71083703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32675"},
        {"Hipparcos Number", "HIP 23590"},
        {"Geneva Identification System", "GEN# +1.00032675"},
        {"Smithsonian Astrophysical Observation", "SAO 150116"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.09071059),
        dec: Angle.Degrees(-13.70727795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31743"},
        {"Hipparcos Number", "HIP 23058"},
        {"Smithsonian Astrophysical Observation", "SAO 150028"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.43603195),
        dec: Angle.Degrees(-13.70497592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132073"},
        {"Hipparcos Number", "HIP 73196"},
        {"Smithsonian Astrophysical Observation", "SAO 158925"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.39128734),
        dec: Angle.Degrees(-13.70446404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11228"},
        {"Hipparcos Number", "HIP 8537"},
        {"Geneva Identification System", "GEN# +1.00011228"},
        {"Smithsonian Astrophysical Observation", "SAO 148046"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.51860330),
        dec: Angle.Degrees(-13.70423382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186984"},
        {"Hipparcos Number", "HIP 97423"},
        {"Geneva Identification System", "GEN# +1.00186984"},
        {"Renson", "Renson 51540"},
        {"Smithsonian Astrophysical Observation", "SAO 162998"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.01253704),
        dec: Angle.Degrees(-13.70355495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49459"},
        {"Hipparcos Number", "HIP 32589"},
        {"Smithsonian Astrophysical Observation", "SAO 151938"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.99106370),
        dec: Angle.Degrees(-13.70301141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49746"},
        {"Hipparcos Number", "HIP 32703"},
        {"Smithsonian Astrophysical Observation", "SAO 151966"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.33948695),
        dec: Angle.Degrees(-13.70195083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13213"},
        {"Smithsonian Astrophysical Observation", "SAO 148631"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.51112137),
        dec: Angle.Degrees(-13.70113146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18287"},
        {"Hipparcos Number", "HIP 13660"},
        {"Geneva Identification System", "GEN# +1.00018287"},
        {"Smithsonian Astrophysical Observation", "SAO 148672"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.97601386),
        dec: Angle.Degrees(-13.70047332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213054"},
        {"Hipparcos Number", "HIP 110978"},
        {"Smithsonian Astrophysical Observation", "SAO 165110"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.26754555),
        dec: Angle.Degrees(-13.70045344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48481"},
        {"Hipparcos Number", "HIP 32171"},
        {"Smithsonian Astrophysical Observation", "SAO 151829"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.75945242),
        dec: Angle.Degrees(-13.69806565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52133"},
        {"Hipparcos Number", "HIP 33652"},
        {"Geneva Identification System", "GEN# +1.00052133"},
        {"Smithsonian Astrophysical Observation", "SAO 152208"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.86855666),
        dec: Angle.Degrees(-13.69753022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84242"},
        {"Hipparcos Number", "HIP 47697"},
        {"Geneva Identification System", "GEN# +1.00084242"},
        {"Smithsonian Astrophysical Observation", "SAO 155433"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.87669365),
        dec: Angle.Degrees(-13.69563852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114522"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.93955550),
        dec: Angle.Degrees(-13.69523644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62727"},
        {"Hipparcos Number", "HIP 37787"},
        {"Smithsonian Astrophysical Observation", "SAO 153342"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.23347909),
        dec: Angle.Degrees(-13.69484606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176535"},
        {"Hipparcos Number", "HIP 93398"},
        {"Geneva Identification System", "GEN# +1.00176535"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.33125457),
        dec: Angle.Degrees(-13.69059913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202096"},
        {"Hipparcos Number", "HIP 104806"},
        {"Smithsonian Astrophysical Observation", "SAO 164234"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.50523781),
        dec: Angle.Degrees(-13.69000972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9325"},
        {"Hipparcos Number", "HIP 7109"},
        {"Cincinnati Publication", "Ci 18 203"},
        {"Smithsonian Astrophysical Observation", "SAO 147858"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.89573323),
        dec: Angle.Degrees(-13.68964144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41383"},
        {"Hipparcos Number", "HIP 28739"},
        {"Smithsonian Astrophysical Observation", "SAO 151074"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.04659417),
        dec: Angle.Degrees(-13.68950513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138136"},
        {"Hipparcos Number", "HIP 75931"},
        {"Smithsonian Astrophysical Observation", "SAO 159305"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.63391868),
        dec: Angle.Degrees(-13.68439291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18690"},
        {"Hipparcos Number", "HIP 13970"},
        {"Fundamental Katalog 5th Edition", "FK5 4272"},
        {"Geneva Identification System", "GEN# +1.00018690"},
        {"Smithsonian Astrophysical Observation", "SAO 148706"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.98078668),
        dec: Angle.Degrees(-13.68345717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77904",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9830 AB"},
        {"Henry Draper", "HD 142347"},
        {"Hipparcos Number", "HIP 77904"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.65109046),
        dec: Angle.Degrees(-13.68262872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37829"},
        {"Hipparcos Number", "HIP 26726"},
        {"Smithsonian Astrophysical Observation", "SAO 150682"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.18853315),
        dec: Angle.Degrees(-13.68243023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222950"},
        {"Hipparcos Number", "HIP 117174"},
        {"Geneva Identification System", "GEN# +1.00222950"},
        {"Smithsonian Astrophysical Observation", "SAO 165862"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.34140868),
        dec: Angle.Degrees(-13.68200088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107404"},
    },
    visualMagnitude: 11.92,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.32145617),
        dec: Angle.Degrees(-13.68114088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56525"},
        {"Hipparcos Number", "HIP 35220"},
        {"Celescope Catalog", "CEL 1734"},
        {"Geneva Identification System", "GEN# +1.00056525"},
        {"Smithsonian Astrophysical Observation", "SAO 152654"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.19610133),
        dec: Angle.Degrees(-13.68110559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147101"},
        {"Hipparcos Number", "HIP 80048"},
        {"Geneva Identification System", "GEN# +1.00147101"},
        {"Smithsonian Astrophysical Observation", "SAO 159862"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.08790982),
        dec: Angle.Degrees(-13.68105204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120655"},
        {"Hipparcos Number", "HIP 67600"},
        {"Geneva Identification System", "GEN# +1.00120655"},
        {"Smithsonian Astrophysical Observation", "SAO 158197"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.77457050),
        dec: Angle.Degrees(-13.67915889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100338"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.23055358),
        dec: Angle.Degrees(-13.67848675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206878"},
        {"Hipparcos Number", "HIP 107407"},
        {"Smithsonian Astrophysical Observation", "SAO 164626"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.32660926),
        dec: Angle.Degrees(-13.67594437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206543"},
        {"Hipparcos Number", "HIP 107220"},
        {"Smithsonian Astrophysical Observation", "SAO 164599"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.74530132),
        dec: Angle.Degrees(-13.67283448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92044",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11637 AB"},
        {"Henry Draper", "HD 173404"},
        {"Hipparcos Number", "HIP 92044"},
        {"Smithsonian Astrophysical Observation", "SAO 161799"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.41602972),
        dec: Angle.Degrees(-13.67114904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185315"},
        {"Hipparcos Number", "HIP 96657"},
        {"Fundamental Katalog 5th Edition", "FK5 5728"},
        {"Geneva Identification System", "GEN# +1.00185315"},
        {"Smithsonian Astrophysical Observation", "SAO 162850"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.77524680),
        dec: Angle.Degrees(-13.66970833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15330"},
        {"Hipparcos Number", "HIP 11446"},
        {"Smithsonian Astrophysical Observation", "SAO 148400"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.91863383),
        dec: Angle.Degrees(-13.66802411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214270"},
        {"Hipparcos Number", "HIP 111661"},
        {"Smithsonian Astrophysical Observation", "SAO 165199"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.30292772),
        dec: Angle.Degrees(-13.66631943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24467"},
        {"Hipparcos Number", "HIP 18168"},
        {"Geneva Identification System", "GEN# +1.00024467"},
        {"Smithsonian Astrophysical Observation", "SAO 149228"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.26781408),
        dec: Angle.Degrees(-13.66392665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177907"},
        {"Hipparcos Number", "HIP 93895"},
        {"Smithsonian Astrophysical Observation", "SAO 162209"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.79393602),
        dec: Angle.Degrees(-13.66383481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28492"},
        {"Hipparcos Number", "HIP 20915"},
        {"Smithsonian Astrophysical Observation", "SAO 149672"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.24518259),
        dec: Angle.Degrees(-13.66122940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34011"},
        {"Hipparcos Number", "HIP 24357"},
        {"Smithsonian Astrophysical Observation", "SAO 150252"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.39825422),
        dec: Angle.Degrees(-13.66091588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5732"},
        {"Hipparcos Number", "HIP 4594"},
        {"Smithsonian Astrophysical Observation", "SAO 147552"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.70422569),
        dec: Angle.Degrees(-13.66085663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220137"},
        {"Hipparcos Number", "HIP 115321"},
        {"Geneva Identification System", "GEN# +1.00220137"},
        {"Smithsonian Astrophysical Observation", "SAO 165645"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.36058852),
        dec: Angle.Degrees(-13.65838307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8660"},
        {"Hipparcos Number", "HIP 6646"},
        {"Smithsonian Astrophysical Observation", "SAO 147797"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.32331404),
        dec: Angle.Degrees(-13.65777959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162572"},
        {"Hipparcos Number", "HIP 87468"},
        {"Smithsonian Astrophysical Observation", "SAO 160880"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.07590345),
        dec: Angle.Degrees(-13.65644433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90225",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90225"},
        {"Geneva Identification System", "GEN# -0.01304965"},
        {"Wilson Evans Batten Catalogue", "WEB 15433"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.13957534),
        dec: Angle.Degrees(-13.65354276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163512"},
        {"Hipparcos Number", "HIP 87879"},
        {"Geneva Identification System", "GEN# +1.00163512"},
        {"Renson", "Renson 46227"},
        {"Smithsonian Astrophysical Observation", "SAO 160930"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.27934953),
        dec: Angle.Degrees(-13.65321820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102749"},
        {"Hipparcos Number", "HIP 57680"},
        {"Smithsonian Astrophysical Observation", "SAO 156918"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.44433279),
        dec: Angle.Degrees(-13.65215822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87544",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10856 AB"},
        {"Henry Draper", "HD 162739"},
        {"Hipparcos Number", "HIP 87544"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.27096593),
        dec: Angle.Degrees(-13.65017624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32943"},
        {"Hipparcos Number", "HIP 23735"},
        {"Smithsonian Astrophysical Observation", "SAO 150140"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.53618946),
        dec: Angle.Degrees(-13.64999452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86420",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10685 A"},
        {"Henry Draper", "HD 160254"},
        {"Hipparcos Number", "HIP 86420"},
        {"Geneva Identification System", "GEN# +1.00160254"},
        {"Smithsonian Astrophysical Observation", "SAO 160724"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.87584514),
        dec: Angle.Degrees(-13.64966753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116409"},
        {"Hipparcos Number", "HIP 65354"},
        {"Smithsonian Astrophysical Observation", "SAO 157909"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.91783736),
        dec: Angle.Degrees(-13.64884951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112037"},
        {"Hipparcos Number", "HIP 62921"},
        {"Smithsonian Astrophysical Observation", "SAO 157577"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.42455121),
        dec: Angle.Degrees(-13.64507188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218718"},
        {"Hipparcos Number", "HIP 114418"},
        {"Smithsonian Astrophysical Observation", "SAO 165530"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.58642434),
        dec: Angle.Degrees(-13.64460960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21110",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3284 A"},
        {"Henry Draper", "HD 28763"},
        {"Hipparcos Number", "HIP 21110"},
        {"Geneva Identification System", "GEN# +1.00028763A"},
        {"Smithsonian Astrophysical Observation", "SAO 149702"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.85775563),
        dec: Angle.Degrees(-13.64411979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219646"},
        {"Hipparcos Number", "HIP 115000"},
        {"Geneva Identification System", "GEN# +1.00219646"},
        {"Smithsonian Astrophysical Observation", "SAO 165608"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.37277843),
        dec: Angle.Degrees(-13.64320031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206905"},
        {"Hipparcos Number", "HIP 107422"},
        {"Smithsonian Astrophysical Observation", "SAO 164628"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.36938345),
        dec: Angle.Degrees(-13.64201445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217065"},
        {"Hipparcos Number", "HIP 113409"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.52601113),
        dec: Angle.Degrees(-13.64174657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -329.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147776"},
        {"Hipparcos Number", "HIP 80366"},
        {"Cincinnati Publication", "Ci 18 2191"},
        {"Geneva Identification System", "GEN# +1.00147776J"},
        {"Smithsonian Astrophysical Observation", "SAO 159899"},
        {"Wilson Evans Batten Catalogue", "WEB 13598"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.08309261),
        dec: Angle.Degrees(-13.64115865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -220.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -205.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20118"},
        {"Hipparcos Number", "HIP 15021"},
        {"Renson", "Renson 4980"},
        {"Smithsonian Astrophysical Observation", "SAO 148845"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.40418262),
        dec: Angle.Degrees(-13.63948756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50797"},
        {"Hipparcos Number", "HIP 33158"},
        {"Geneva Identification System", "GEN# +1.00050797"},
        {"Smithsonian Astrophysical Observation", "SAO 152073"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.54653694),
        dec: Angle.Degrees(-13.63926109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159415"},
        {"Hipparcos Number", "HIP 86049"},
        {"Smithsonian Astrophysical Observation", "SAO 160660"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.78115402),
        dec: Angle.Degrees(-13.63778265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189741"},
        {"Hipparcos Number", "HIP 98633"},
        {"Geneva Identification System", "GEN# +1.00189741"},
        {"Smithsonian Astrophysical Observation", "SAO 163195"},
    },
    visualMagnitude: 5.69,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.49407171),
        dec: Angle.Degrees(-13.63724241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26634"},
        {"Hipparcos Number", "HIP 19614"},
        {"Smithsonian Astrophysical Observation", "SAO 149451"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.04649341),
        dec: Angle.Degrees(-13.63713701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22494"},
        {"Smithsonian Astrophysical Observation", "SAO 149926"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.58952170),
        dec: Angle.Degrees(-13.63472305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9025"},
        {"Hipparcos Number", "HIP 6891"},
        {"Smithsonian Astrophysical Observation", "SAO 147828"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.18553715),
        dec: Angle.Degrees(-13.63459118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70256"},
        {"Hipparcos Number", "HIP 40885"},
        {"Smithsonian Astrophysical Observation", "SAO 154132"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.14557995),
        dec: Angle.Degrees(-13.63345234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1654"},
        {"Hipparcos Number", "HIP 1658"},
        {"Smithsonian Astrophysical Observation", "SAO 147226"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.19542208),
        dec: Angle.Degrees(-13.63140220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110527"},
        {"Hipparcos Number", "HIP 62035"},
        {"Smithsonian Astrophysical Observation", "SAO 157462"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.73149939),
        dec: Angle.Degrees(-13.63100598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7195"},
        {"Hipparcos Number", "HIP 5616"},
        {"Smithsonian Astrophysical Observation", "SAO 147668"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.02148546),
        dec: Angle.Degrees(-13.62646029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92763",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11803 AB"},
        {"Henry Draper", "HD 175060"},
        {"Hipparcos Number", "HIP 92763"},
        {"Smithsonian Astrophysical Observation", "SAO 161952"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.54530106),
        dec: Angle.Degrees(-13.62624721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70862"},
        {"Hipparcos Number", "HIP 41161"},
        {"Geneva Identification System", "GEN# +1.00070862"},
        {"Smithsonian Astrophysical Observation", "SAO 154203"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.97548366),
        dec: Angle.Degrees(-13.62580323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68629",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68629"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.71708379),
        dec: Angle.Degrees(-13.62561220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69229"},
        {"Hipparcos Number", "HIP 40453"},
        {"Fundamental Katalog 5th Edition", "FK5 4741"},
        {"Smithsonian Astrophysical Observation", "SAO 154035"},
        {"Wilson Evans Batten Catalogue", "WEB 7879"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.88975927),
        dec: Angle.Degrees(-13.62426115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137633"},
        {"Hipparcos Number", "HIP 75659"},
        {"Smithsonian Astrophysical Observation", "SAO 159270"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.87068608),
        dec: Angle.Degrees(-13.62374859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42849"},
        {"Hipparcos Number", "HIP 29465"},
        {"Smithsonian Astrophysical Observation", "SAO 151220"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.12267863),
        dec: Angle.Degrees(-13.62362603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70577"},
        {"Hipparcos Number", "HIP 41018"},
        {"Smithsonian Astrophysical Observation", "SAO 154166"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.55935803),
        dec: Angle.Degrees(-13.62220662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72567"},
        {"Hipparcos Number", "HIP 41965"},
        {"Smithsonian Astrophysical Observation", "SAO 154385"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.30593079),
        dec: Angle.Degrees(-13.62159818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127388"},
        {"Hipparcos Number", "HIP 71017"},
        {"Smithsonian Astrophysical Observation", "SAO 158615"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.86437715),
        dec: Angle.Degrees(-13.61694673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54859"},
        {"Hipparcos Number", "HIP 34596"},
        {"Smithsonian Astrophysical Observation", "SAO 152487"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.48754924),
        dec: Angle.Degrees(-13.61604826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 822"},
        {"Hipparcos Number", "HIP 1012"},
        {"Geneva Identification System", "GEN# +1.00000822"},
        {"Smithsonian Astrophysical Observation", "SAO 147149"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.15309368),
        dec: Angle.Degrees(-13.61016552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69999"},
        {"Hipparcos Number", "HIP 40760"},
        {"Smithsonian Astrophysical Observation", "SAO 154106"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.80124222),
        dec: Angle.Degrees(-13.60795543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130953"},
        {"Hipparcos Number", "HIP 72650"},
        {"Smithsonian Astrophysical Observation", "SAO 158845"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.81006872),
        dec: Angle.Degrees(-13.60703503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210295"},
        {"Hipparcos Number", "HIP 109390"},
        {"Geneva Identification System", "GEN# +1.00210295"},
        {"Smithsonian Astrophysical Observation", "SAO 164894"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.42279236),
        dec: Angle.Degrees(-13.60520304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46169"},
        {"Hipparcos Number", "HIP 31075"},
        {"Geneva Identification System", "GEN# +1.00046169"},
        {"Smithsonian Astrophysical Observation", "SAO 151599"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.81514011),
        dec: Angle.Degrees(-13.60176564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4699"},
        {"Geneva Identification System", "GEN# -0.01400184"},
        {"Smithsonian Astrophysical Observation", "SAO 147562"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.09416133),
        dec: Angle.Degrees(-13.59920106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54090"},
        {"Smithsonian Astrophysical Observation", "SAO 156432"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.02527383),
        dec: Angle.Degrees(-13.59901574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170329"},
        {"Hipparcos Number", "HIP 90613"},
        {"Smithsonian Astrophysical Observation", "SAO 161523"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.34948627),
        dec: Angle.Degrees(-13.59837977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213510"},
        {"Hipparcos Number", "HIP 111234"},
        {"Smithsonian Astrophysical Observation", "SAO 165149"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.03919960),
        dec: Angle.Degrees(-13.59758856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24834"},
        {"Hipparcos Number", "HIP 18428"},
        {"Geneva Identification System", "GEN# +1.00024834"},
        {"Smithsonian Astrophysical Observation", "SAO 149267"},
        {"Wilson Evans Batten Catalogue", "WEB 3556"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.11523947),
        dec: Angle.Degrees(-13.59754104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151977"},
        {"Hipparcos Number", "HIP 82472"},
        {"Smithsonian Astrophysical Observation", "SAO 160129"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.81734372),
        dec: Angle.Degrees(-13.59737552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169034"},
        {"Hipparcos Number", "HIP 90107"},
        {"Geneva Identification System", "GEN# +1.00169034"},
        {"Smithsonian Astrophysical Observation", "SAO 161418"},
        {"Wilson Evans Batten Catalogue", "WEB 15405"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.82320513),
        dec: Angle.Degrees(-13.59429996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207459"},
        {"Hipparcos Number", "HIP 107735"},
        {"Smithsonian Astrophysical Observation", "SAO 164675"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.36292522),
        dec: Angle.Degrees(-13.59425978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71579"},
        {"Hipparcos Number", "HIP 41497"},
        {"Smithsonian Astrophysical Observation", "SAO 154278"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.94515495),
        dec: Angle.Degrees(-13.59338346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216032"},
        {"Hipparcos Number", "HIP 112716"},
        {"Fundamental Katalog 5th Edition", "FK5 861"},
        {"Geneva Identification System", "GEN# +1.00216032A"},
        {"Smithsonian Astrophysical Observation", "SAO 165321"},
        {"Wilson Evans Batten Catalogue", "WEB 20086"},
    },
    visualMagnitude: 4.05,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.39795761),
        dec: Angle.Degrees(-13.59253756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28625"},
        {"Hipparcos Number", "HIP 20997"},
        {"Geneva Identification System", "GEN# +1.00028625"},
        {"Smithsonian Astrophysical Observation", "SAO 149682"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.54163691),
        dec: Angle.Degrees(-13.59237369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91120"},
        {"Hipparcos Number", "HIP 51491"},
        {"Geneva Identification System", "GEN# +1.00091120"},
        {"Smithsonian Astrophysical Observation", "SAO 156029"},
        {"Wilson Evans Batten Catalogue", "WEB 9397"},
    },
    visualMagnitude: 5.59,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.74940778),
        dec: Angle.Degrees(-13.58846760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204220"},
        {"Hipparcos Number", "HIP 105946"},
        {"Smithsonian Astrophysical Observation", "SAO 164400"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.84676629),
        dec: Angle.Degrees(-13.58759554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114641"},
        {"Hipparcos Number", "HIP 64403"},
        {"Geneva Identification System", "GEN# +1.00114641"},
        {"Smithsonian Astrophysical Observation", "SAO 157787"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.99503249),
        dec: Angle.Degrees(-13.58744702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221677"},
        {"Hipparcos Number", "HIP 116326"},
        {"Smithsonian Astrophysical Observation", "SAO 165772"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.54382537),
        dec: Angle.Degrees(-13.58742387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52330"},
        {"Hipparcos Number", "HIP 33711"},
        {"Smithsonian Astrophysical Observation", "SAO 152224"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.05853814),
        dec: Angle.Degrees(-13.58739614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28856"},
        {"Hipparcos Number", "HIP 21168"},
        {"Fundamental Katalog 5th Edition", "FK5 4410"},
        {"Geneva Identification System", "GEN# +1.00028856"},
        {"Smithsonian Astrophysical Observation", "SAO 149712"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.07396913),
        dec: Angle.Degrees(-13.58652277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18861"},
        {"Hipparcos Number", "HIP 14090"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.42282434),
        dec: Angle.Degrees(-13.58586412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12438"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.02363875),
        dec: Angle.Degrees(-13.58270225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 285.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30405"},
        {"Hipparcos Number", "HIP 22223"},
        {"Smithsonian Astrophysical Observation", "SAO 149878"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.69885707),
        dec: Angle.Degrees(-13.58140754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35930"},
        {"Hipparcos Number", "HIP 25528"},
        {"Geneva Identification System", "GEN# +1.00035930"},
        {"Smithsonian Astrophysical Observation", "SAO 150469"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.88536388),
        dec: Angle.Degrees(-13.57777064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142766"},
        {"Hipparcos Number", "HIP 78096"},
        {"Smithsonian Astrophysical Observation", "SAO 159593"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.18947633),
        dec: Angle.Degrees(-13.57570576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117065"},
        {"Hipparcos Number", "HIP 65680"},
        {"Smithsonian Astrophysical Observation", "SAO 157952"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.00122155),
        dec: Angle.Degrees(-13.57504435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167451"},
        {"Hipparcos Number", "HIP 89508"},
        {"Geneva Identification System", "GEN# +1.00167451"},
        {"Smithsonian Astrophysical Observation", "SAO 161234"},
        {"Wilson Evans Batten Catalogue", "WEB 15238"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.97858569),
        dec: Angle.Degrees(-13.57435477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39598",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6579 A"},
        {"Henry Draper", "HD 67015"},
        {"Hipparcos Number", "HIP 39598"},
        {"Smithsonian Astrophysical Observation", "SAO 153815"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.38209458),
        dec: Angle.Degrees(-13.57253997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174328"},
        {"Hipparcos Number", "HIP 92456"},
        {"Fundamental Katalog 5th Edition", "FK5 3498"},
        {"Smithsonian Astrophysical Observation", "SAO 161893"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.62988811),
        dec: Angle.Degrees(-13.57224271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148560"},
        {"Hipparcos Number", "HIP 80768"},
        {"Smithsonian Astrophysical Observation", "SAO 159942"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.35720977),
        dec: Angle.Degrees(-13.57037684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19812"},
        {"Hipparcos Number", "HIP 14783"},
        {"Smithsonian Astrophysical Observation", "SAO 148812"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.71559656),
        dec: Angle.Degrees(-13.56970258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73873"},
        {"Hipparcos Number", "HIP 42531"},
        {"Smithsonian Astrophysical Observation", "SAO 154522"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.06126088),
        dec: Angle.Degrees(-13.56671299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153631"},
        {"Hipparcos Number", "HIP 83276"},
        {"Fundamental Katalog 5th Edition", "FK5 5499"},
        {"Geneva Identification System", "GEN# +1.00153631"},
        {"Smithsonian Astrophysical Observation", "SAO 160227"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.29486110),
        dec: Angle.Degrees(-13.56634330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -323.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107418"},
        {"Hipparcos Number", "HIP 60221"},
        {"Fundamental Katalog 5th Edition", "FK5 2988"},
        {"Geneva Identification System", "GEN# +1.00107418"},
        {"Smithsonian Astrophysical Observation", "SAO 157226"},
        {"Wilson Evans Batten Catalogue", "WEB 10709"},
    },
    visualMagnitude: 5.14,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.23214915),
        dec: Angle.Degrees(-13.56574902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108989"},
        {"Hipparcos Number", "HIP 61113"},
        {"Smithsonian Astrophysical Observation", "SAO 157337"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.87530411),
        dec: Angle.Degrees(-13.56418904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222010"},
        {"Hipparcos Number", "HIP 116537"},
        {"Geneva Identification System", "GEN# +1.00222010"},
        {"Smithsonian Astrophysical Observation", "SAO 165798"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.26493511),
        dec: Angle.Degrees(-13.56282172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21206"},
        {"Hipparcos Number", "HIP 15915"},
        {"Smithsonian Astrophysical Observation", "SAO 148950"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.23519852),
        dec: Angle.Degrees(-13.56153511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3849",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 680 A"},
        {"Henry Draper", "HD 4730"},
        {"Hipparcos Number", "HIP 3849"},
        {"Fundamental Katalog 5th Edition", "FK5 2054"},
        {"Geneva Identification System", "GEN# +1.00004730"},
        {"Smithsonian Astrophysical Observation", "SAO 147464"},
        {"Wilson Evans Batten Catalogue", "WEB 685"},
    },
    visualMagnitude: 5.59,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.35647376),
        dec: Angle.Degrees(-13.56101709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119264"},
        {"Hipparcos Number", "HIP 66889"},
        {"Fundamental Katalog 5th Edition", "FK5 5211"},
        {"Smithsonian Astrophysical Observation", "SAO 158103"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.61648878),
        dec: Angle.Degrees(-13.56012054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2569"},
        {"Hipparcos Number", "HIP 2291"},
        {"Smithsonian Astrophysical Observation", "SAO 147304"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.31612841),
        dec: Angle.Degrees(-13.56009296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87584"},
        {"Hipparcos Number", "HIP 49439"},
        {"Smithsonian Astrophysical Observation", "SAO 155720"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.40283698),
        dec: Angle.Degrees(-13.55643910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118645"},
        {"Hipparcos Number", "HIP 66544"},
        {"Smithsonian Astrophysical Observation", "SAO 158057"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.61569920),
        dec: Angle.Degrees(-13.55604535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156393"},
        {"Hipparcos Number", "HIP 84617"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.46205270),
        dec: Angle.Degrees(-13.55535623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44143"},
        {"Hipparcos Number", "HIP 30063"},
        {"Smithsonian Astrophysical Observation", "SAO 151355"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.91005141),
        dec: Angle.Degrees(-13.55511439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71713"},
        {"Hipparcos Number", "HIP 41558"},
        {"Geneva Identification System", "GEN# +1.00071713"},
        {"Smithsonian Astrophysical Observation", "SAO 154291"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.09928581),
        dec: Angle.Degrees(-13.55499955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140270"},
        {"Hipparcos Number", "HIP 76983"},
        {"Geneva Identification System", "GEN# +1.00140270"},
        {"Smithsonian Astrophysical Observation", "SAO 159460"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.79002194),
        dec: Angle.Degrees(-13.55450183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207958"},
        {"Hipparcos Number", "HIP 108036"},
        {"Fundamental Katalog 5th Edition", "FK5 1577"},
        {"Geneva Identification System", "GEN# +1.00207958"},
        {"Smithsonian Astrophysical Observation", "SAO 164713"},
        {"Wilson Evans Batten Catalogue", "WEB 19477"},
    },
    visualMagnitude: 5.08,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.32326591),
        dec: Angle.Degrees(-13.55180134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 313.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194486"},
        {"Hipparcos Number", "HIP 100798"},
        {"Smithsonian Astrophysical Observation", "SAO 163570"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.56897876),
        dec: Angle.Degrees(-13.55099979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37568"},
        {"Hipparcos Number", "HIP 26559"},
        {"Smithsonian Astrophysical Observation", "SAO 150647"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.71309211),
        dec: Angle.Degrees(-13.54852766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101378",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13972 AB"},
        {"Henry Draper", "HD 195622"},
        {"Hipparcos Number", "HIP 101378"},
        {"Smithsonian Astrophysical Observation", "SAO 163668"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.20338645),
        dec: Angle.Degrees(-13.54800155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74918"},
        {"Hipparcos Number", "HIP 43067"},
        {"Geneva Identification System", "GEN# +1.00074918"},
        {"Smithsonian Astrophysical Observation", "SAO 154622"},
        {"Wilson Evans Batten Catalogue", "WEB 8313"},
    },
    visualMagnitude: 4.32,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.59386440),
        dec: Angle.Degrees(-13.54770494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12264"},
        {"Hipparcos Number", "HIP 9349"},
        {"Geneva Identification System", "GEN# +1.00012264"},
        {"Smithsonian Astrophysical Observation", "SAO 148147"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.02211788),
        dec: Angle.Degrees(-13.54606215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89013"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.50888575),
        dec: Angle.Degrees(-13.54596404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107102"},
        {"Hipparcos Number", "HIP 60060"},
        {"Renson", "Renson 30980"},
        {"Smithsonian Astrophysical Observation", "SAO 157205"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.75349628),
        dec: Angle.Degrees(-13.54225747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190500"},
        {"Hipparcos Number", "HIP 98988"},
        {"Smithsonian Astrophysical Observation", "SAO 163256"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.43449425),
        dec: Angle.Degrees(-13.54212708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25654"},
        {"Smithsonian Astrophysical Observation", "SAO 150486"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.20112812),
        dec: Angle.Degrees(-13.54196205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168136"},
        {"Hipparcos Number", "HIP 89747"},
        {"Geneva Identification System", "GEN# +1.00168136"},
        {"Smithsonian Astrophysical Observation", "SAO 161315"},
        {"New General Catalogue", "NGC 6611 593"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.72937380),
        dec: Angle.Degrees(-13.54130711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80873"},
        {"Hipparcos Number", "HIP 45927"},
        {"Smithsonian Astrophysical Observation", "SAO 155127"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.46693500),
        dec: Angle.Degrees(-13.53717732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205828"},
        {"Hipparcos Number", "HIP 106831"},
        {"Smithsonian Astrophysical Observation", "SAO 164539"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.56414884),
        dec: Angle.Degrees(-13.53344558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142146"},
        {"Hipparcos Number", "HIP 77812"},
        {"Smithsonian Astrophysical Observation", "SAO 159560"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.33454372),
        dec: Angle.Degrees(-13.53267186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36799"},
        {"Hipparcos Number", "HIP 26074"},
        {"Smithsonian Astrophysical Observation", "SAO 150559"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.41548507),
        dec: Angle.Degrees(-13.53199760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18942"},
        {"Hipparcos Number", "HIP 14153"},
        {"Geneva Identification System", "GEN# +1.00018942"},
        {"Smithsonian Astrophysical Observation", "SAO 148728"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.61582001),
        dec: Angle.Degrees(-13.53166125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200004"},
        {"Hipparcos Number", "HIP 103728"},
        {"Geneva Identification System", "GEN# +1.00200004"},
        {"Smithsonian Astrophysical Observation", "SAO 164064"},
        {"Wilson Evans Batten Catalogue", "WEB 18878"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.28472233),
        dec: Angle.Degrees(-13.53000485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212430"},
        {"Hipparcos Number", "HIP 110602"},
        {"Fundamental Katalog 5th Edition", "FK5 3791"},
        {"Geneva Identification System", "GEN# +1.00212430"},
        {"Smithsonian Astrophysical Observation", "SAO 165044"},
        {"Wilson Evans Batten Catalogue", "WEB 19821"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.11262494),
        dec: Angle.Degrees(-13.52940359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89295"},
        {"Hipparcos Number", "HIP 50434"},
        {"Smithsonian Astrophysical Observation", "SAO 155878"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.46164197),
        dec: Angle.Degrees(-13.52689635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75096"},
        {"Hipparcos Number", "HIP 43169"},
        {"Renson", "Renson 20996"},
        {"Smithsonian Astrophysical Observation", "SAO 154639"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.89701422),
        dec: Angle.Degrees(-13.52669563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81450"},
        {"Smithsonian Astrophysical Observation", "SAO 160014"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.53499925),
        dec: Angle.Degrees(-13.52540715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19897"},
        {"Hipparcos Number", "HIP 14832"},
        {"Geneva Identification System", "GEN# +1.00019897"},
        {"Smithsonian Astrophysical Observation", "SAO 148822"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.87826385),
        dec: Angle.Degrees(-13.52412533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16044"},
        {"Hipparcos Number", "HIP 11955"},
        {"Smithsonian Astrophysical Observation", "SAO 148475"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.55032701),
        dec: Angle.Degrees(-13.52365294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113070"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.50001869),
        dec: Angle.Degrees(-13.52291850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 358059"},
        {"Hipparcos Number", "HIP 103337"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.03811317),
        dec: Angle.Degrees(-13.52137244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34538"},
        {"Hipparcos Number", "HIP 24679"},
        {"Geneva Identification System", "GEN# +1.00034538"},
        {"Smithsonian Astrophysical Observation", "SAO 150304"},
        {"Wilson Evans Batten Catalogue", "WEB 4778"},
    },
    visualMagnitude: 5.48,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.41769273),
        dec: Angle.Degrees(-13.51970778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137743"},
        {"Hipparcos Number", "HIP 75715"},
        {"Smithsonian Astrophysical Observation", "SAO 159279"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.02586902),
        dec: Angle.Degrees(-13.51837541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82660"},
        {"Hipparcos Number", "HIP 46859"},
        {"Fundamental Katalog 5th Edition", "FK5 2761"},
        {"Geneva Identification System", "GEN# +1.00082660"},
        {"Smithsonian Astrophysical Observation", "SAO 155281"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.23241315),
        dec: Angle.Degrees(-13.51680632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21086"},
    },
    visualMagnitude: 11.47,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.78807360),
        dec: Angle.Degrees(-13.51410060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203565"},
        {"Hipparcos Number", "HIP 105603"},
        {"Smithsonian Astrophysical Observation", "SAO 164356"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.83708306),
        dec: Angle.Degrees(-13.51344067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145293"},
        {"Hipparcos Number", "HIP 79271"},
        {"Geneva Identification System", "GEN# +1.00145293"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.68360269),
        dec: Angle.Degrees(-13.51289068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224239"},
        {"Hipparcos Number", "HIP 118011"},
        {"Smithsonian Astrophysical Observation", "SAO 165962"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.06424137),
        dec: Angle.Degrees(-13.51118316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14742"},
        {"Hipparcos Number", "HIP 11056"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.57432350),
        dec: Angle.Degrees(-13.50912653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130708"},
        {"Hipparcos Number", "HIP 72553"},
        {"Geneva Identification System", "GEN# +1.00130708"},
        {"Smithsonian Astrophysical Observation", "SAO 158825"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.49629869),
        dec: Angle.Degrees(-13.50861513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161023"},
        {"Hipparcos Number", "HIP 86769"},
        {"Geneva Identification System", "GEN# +1.00161023"},
        {"Smithsonian Astrophysical Observation", "SAO 160784"},
        {"Wilson Evans Batten Catalogue", "WEB 14629"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.95188377),
        dec: Angle.Degrees(-13.50842917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18543",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Zaurak"},
        {"Aitken", "ADS 2904 A"},
        {"Henry Draper", "HD 25025"},
        {"Hipparcos Number", "HIP 18543"},
        {"Fundamental Katalog 5th Edition", "FK5 149"},
        {"Geneva Identification System", "GEN# +1.00025025"},
        {"Smithsonian Astrophysical Observation", "SAO 149283"},
        {"Wilson Evans Batten Catalogue", "WEB 3576"},
    },
    visualMagnitude: 2.97,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.50720862),
        dec: Angle.Degrees(-13.50824471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67551"},
        {"Hipparcos Number", "HIP 39804"},
        {"Geneva Identification System", "GEN# +1.00067551"},
        {"Smithsonian Astrophysical Observation", "SAO 153869"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.00839585),
        dec: Angle.Degrees(-13.50803296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200093"},
        {"Hipparcos Number", "HIP 103771"},
        {"Smithsonian Astrophysical Observation", "SAO 164071"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.42382422),
        dec: Angle.Degrees(-13.50802314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124957"},
        {"Hipparcos Number", "HIP 69774"},
        {"Smithsonian Astrophysical Observation", "SAO 158461"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.20537651),
        dec: Angle.Degrees(-13.50606036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131160"},
        {"Hipparcos Number", "HIP 72731"},
        {"Geneva Identification System", "GEN# +1.00131160"},
        {"Smithsonian Astrophysical Observation", "SAO 158865"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.05187186),
        dec: Angle.Degrees(-13.50517782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159189"},
        {"Hipparcos Number", "HIP 85939"},
        {"Smithsonian Astrophysical Observation", "SAO 160641"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.46249090),
        dec: Angle.Degrees(-13.50474286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200898"},
        {"Hipparcos Number", "HIP 104198"},
        {"Smithsonian Astrophysical Observation", "SAO 164138"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.65722168),
        dec: Angle.Degrees(-13.50411751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32179"},
        {"Hipparcos Number", "HIP 23298"},
        {"Smithsonian Astrophysical Observation", "SAO 150076"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.16901496),
        dec: Angle.Degrees(-13.50369547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7122"},
        {"Hipparcos Number", "HIP 5559"},
        {"Smithsonian Astrophysical Observation", "SAO 147656"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.82204800),
        dec: Angle.Degrees(-13.50328311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203054"},
        {"Hipparcos Number", "HIP 105333"},
        {"Smithsonian Astrophysical Observation", "SAO 164315"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.03818470),
        dec: Angle.Degrees(-13.50232221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133568"},
        {"Hipparcos Number", "HIP 73847"},
        {"Smithsonian Astrophysical Observation", "SAO 159017"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.38319373),
        dec: Angle.Degrees(-13.50154212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10879"},
        {"Hipparcos Number", "HIP 8264"},
        {"Geneva Identification System", "GEN# +1.00010879"},
        {"Smithsonian Astrophysical Observation", "SAO 148005"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.61505441),
        dec: Angle.Degrees(-13.50122217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196995"},
        {"Hipparcos Number", "HIP 102078"},
        {"Smithsonian Astrophysical Observation", "SAO 163795"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.30380978),
        dec: Angle.Degrees(-13.50028959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141221"},
        {"Hipparcos Number", "HIP 77433"},
        {"Smithsonian Astrophysical Observation", "SAO 159506"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.10412534),
        dec: Angle.Degrees(-13.49928149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36326"},
        {"Hipparcos Number", "HIP 25788"},
        {"Smithsonian Astrophysical Observation", "SAO 150507"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.60142205),
        dec: Angle.Degrees(-13.49889673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21875"},
        {"Hipparcos Number", "HIP 16400"},
        {"Smithsonian Astrophysical Observation", "SAO 149008"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.79555692),
        dec: Angle.Degrees(-13.49884372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199882"},
        {"Hipparcos Number", "HIP 103665"},
        {"Smithsonian Astrophysical Observation", "SAO 164052"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.06064608),
        dec: Angle.Degrees(-13.49858824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207748"},
        {"Hipparcos Number", "HIP 107889"},
        {"Geneva Identification System", "GEN# +1.00207748"},
        {"Smithsonian Astrophysical Observation", "SAO 164696"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.89335401),
        dec: Angle.Degrees(-13.49564391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156057"},
        {"Hipparcos Number", "HIP 84451"},
        {"Smithsonian Astrophysical Observation", "SAO 160409"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.98453988),
        dec: Angle.Degrees(-13.49417098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203876"},
        {"Hipparcos Number", "HIP 105759"},
        {"Smithsonian Astrophysical Observation", "SAO 164377"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.30333736),
        dec: Angle.Degrees(-13.49353799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111721"},
        {"Hipparcos Number", "HIP 62747"},
        {"Cincinnati Publication", "Ci 20 745"},
        {"Geneva Identification System", "GEN# +1.00111721"},
        {"Smithsonian Astrophysical Observation", "SAO 157552"},
        {"Wilson Evans Batten Catalogue", "WEB 11126"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.85566208),
        dec: Angle.Degrees(-13.49037656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -273.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -321.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192209"},
        {"Hipparcos Number", "HIP 99733"},
        {"Smithsonian Astrophysical Observation", "SAO 163368"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.54712960),
        dec: Angle.Degrees(-13.48933976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46706"},
        {"Cincinnati Publication", "Ci 20 533"},
        {"Geneva Identification System", "GEN# -0.01202918"},
        {"Wilson Evans Batten Catalogue", "WEB 8811"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.82916031),
        dec: Angle.Degrees(-13.48883369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 722.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198078"},
        {"Hipparcos Number", "HIP 102671"},
        {"Smithsonian Astrophysical Observation", "SAO 163893"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.07689709),
        dec: Angle.Degrees(-13.48866632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2957"},
        {"Hipparcos Number", "HIP 2579"},
        {"Geneva Identification System", "GEN# +1.00002957"},
        {"Renson", "Renson 760"},
        {"Smithsonian Astrophysical Observation", "SAO 147330"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.18366858),
        dec: Angle.Degrees(-13.48708365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205249"},
        {"Hipparcos Number", "HIP 106497"},
        {"Geneva Identification System", "GEN# +1.00205249"},
        {"Smithsonian Astrophysical Observation", "SAO 164484"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.56900261),
        dec: Angle.Degrees(-13.48375445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159008"},
        {"Hipparcos Number", "HIP 85871"},
        {"Smithsonian Astrophysical Observation", "SAO 160627"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.21132896),
        dec: Angle.Degrees(-13.48206386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68587"},
        {"Hipparcos Number", "HIP 40205"},
        {"Smithsonian Astrophysical Observation", "SAO 153974"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.17639779),
        dec: Angle.Degrees(-13.47966741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27217"},
        {"Hipparcos Number", "HIP 20010"},
        {"Geneva Identification System", "GEN# +1.00027217"},
        {"Renson", "Renson 6974"},
        {"Smithsonian Astrophysical Observation", "SAO 149513"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.35808501),
        dec: Angle.Degrees(-13.47931173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127872"},
        {"Hipparcos Number", "HIP 71240"},
        {"Smithsonian Astrophysical Observation", "SAO 158645"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.53484995),
        dec: Angle.Degrees(-13.47879993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118249"},
        {"Hipparcos Number", "HIP 66343"},
        {"Geneva Identification System", "GEN# +1.00118249"},
        {"Smithsonian Astrophysical Observation", "SAO 158031"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.94776192),
        dec: Angle.Degrees(-13.47852939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44863"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.11194750),
        dec: Angle.Degrees(-13.47844280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7398"},
        {"Hipparcos Number", "HIP 5764"},
        {"Geneva Identification System", "GEN# +1.00007398"},
        {"Smithsonian Astrophysical Observation", "SAO 147682"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.50485624),
        dec: Angle.Degrees(-13.47532545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59458"},
        {"Hipparcos Number", "HIP 36413"},
        {"Smithsonian Astrophysical Observation", "SAO 152948"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.38088858),
        dec: Angle.Degrees(-13.47525620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222505"},
        {"Hipparcos Number", "HIP 116867"},
        {"Geneva Identification System", "GEN# +1.00222505"},
        {"Smithsonian Astrophysical Observation", "SAO 165829"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.32682091),
        dec: Angle.Degrees(-13.47457952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171920"},
        {"Hipparcos Number", "HIP 91349"},
        {"Geneva Identification System", "GEN# +1.00171920"},
        {"Smithsonian Astrophysical Observation", "SAO 161686"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.48073643),
        dec: Angle.Degrees(-13.47293975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114845"},
        {"Hipparcos Number", "HIP 64511"},
        {"Geneva Identification System", "GEN# +1.00114845"},
        {"Smithsonian Astrophysical Observation", "SAO 157797"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.33789439),
        dec: Angle.Degrees(-13.47110904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72060"},
        {"Hipparcos Number", "HIP 41719"},
        {"Smithsonian Astrophysical Observation", "SAO 154326"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.60519260),
        dec: Angle.Degrees(-13.46847030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23445"},
        {"Hipparcos Number", "HIP 17484"},
        {"Geneva Identification System", "GEN# +1.00023445"},
        {"Smithsonian Astrophysical Observation", "SAO 149143"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.18951502),
        dec: Angle.Degrees(-13.46785669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122125"},
        {"Hipparcos Number", "HIP 68400"},
        {"Smithsonian Astrophysical Observation", "SAO 158284"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.03145281),
        dec: Angle.Degrees(-13.46679505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43050"},
        {"Hipparcos Number", "HIP 29549"},
        {"Smithsonian Astrophysical Observation", "SAO 151245"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.39600456),
        dec: Angle.Degrees(-13.46665811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1789"},
        {"Hipparcos Number", "HIP 1752"},
        {"Smithsonian Astrophysical Observation", "SAO 147232"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.55086752),
        dec: Angle.Degrees(-13.46561094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28365"},
        {"Hipparcos Number", "HIP 20837"},
        {"Geneva Identification System", "GEN# +1.00028365"},
        {"Renson", "Renson 7280"},
        {"Smithsonian Astrophysical Observation", "SAO 149655"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.98496972),
        dec: Angle.Degrees(-13.46451580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86173"},
        {"Hipparcos Number", "HIP 48741"},
        {"Smithsonian Astrophysical Observation", "SAO 155605"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.12898196),
        dec: Angle.Degrees(-13.46383951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49547"},
        {"Hipparcos Number", "HIP 32629"},
        {"Smithsonian Astrophysical Observation", "SAO 151947"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.09530042),
        dec: Angle.Degrees(-13.46367357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93331"},
        {"Hipparcos Number", "HIP 52688"},
        {"Smithsonian Astrophysical Observation", "SAO 156211"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.60352859),
        dec: Angle.Degrees(-13.45986105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205607"},
        {"Hipparcos Number", "HIP 106698"},
        {"Renson", "Renson 57284"},
        {"Smithsonian Astrophysical Observation", "SAO 164514"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.18060143),
        dec: Angle.Degrees(-13.45926172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205031"},
        {"Hipparcos Number", "HIP 106380"},
        {"Smithsonian Astrophysical Observation", "SAO 164468"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.19644935),
        dec: Angle.Degrees(-13.45913565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115126",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16672 A"},
        {"Henry Draper", "HD 219834A"},
        {"Henry Draper 2", "HD 219834"},
        {"Hipparcos Number", "HIP 115126"},
        {"Geneva Identification System", "GEN# +1.00219834A"},
        {"Smithsonian Astrophysical Observation", "SAO 165625"},
        {"Wilson Evans Batten Catalogue", "WEB 20394"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.77712113),
        dec: Angle.Degrees(-13.45844256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 265.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178492"},
        {"Hipparcos Number", "HIP 94107"},
        {"Smithsonian Astrophysical Observation", "SAO 162255"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.35117310),
        dec: Angle.Degrees(-13.45657441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1388"},
        {"Hipparcos Number", "HIP 1444"},
        {"Cincinnati Publication", "Ci 20 20"},
        {"Cincinnati Publication 2", "Ci 18 27"},
        {"Geneva Identification System", "GEN# +1.00001388"},
        {"Smithsonian Astrophysical Observation", "SAO 147208"},
        {"Wilson Evans Batten Catalogue", "WEB 264"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.49430346),
        dec: Angle.Degrees(-13.45563887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 396.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221855"},
        {"Hipparcos Number", "HIP 116446"},
        {"Smithsonian Astrophysical Observation", "SAO 165788"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.93716913),
        dec: Angle.Degrees(-13.45520262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115125",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16672 B"},
        {"Henry Draper", "HD 219834B"},
        {"Hipparcos Number", "HIP 115125"},
        {"Geneva Identification System", "GEN# +1.00219834B"},
        {"Smithsonian Astrophysical Observation", "SAO 165624"},
        {"Wilson Evans Batten Catalogue", "WEB 20395"},
    },
    visualMagnitude: 5.19,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)19, 06.3700),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)27, 17.000)
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
    primaryId: "HIP 35217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56501"},
        {"Hipparcos Number", "HIP 35217"},
        {"Celescope Catalog", "CEL 1733"},
        {"Geneva Identification System", "GEN# +1.00056501"},
        {"Smithsonian Astrophysical Observation", "SAO 152651"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.17675004),
        dec: Angle.Degrees(-13.45465740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223022"},
        {"Hipparcos Number", "HIP 117209"},
        {"Smithsonian Astrophysical Observation", "SAO 165865"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.49699164),
        dec: Angle.Degrees(-13.45423712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112223"},
        {"Hipparcos Number", "HIP 63046"},
        {"Smithsonian Astrophysical Observation", "SAO 157591"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.77931161),
        dec: Angle.Degrees(-13.45274131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193254"},
        {"Hipparcos Number", "HIP 100234"},
        {"Smithsonian Astrophysical Observation", "SAO 163452"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.93891651),
        dec: Angle.Degrees(-13.45241616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187021"},
        {"Hipparcos Number", "HIP 97437"},
        {"Smithsonian Astrophysical Observation", "SAO 163001"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.06277025),
        dec: Angle.Degrees(-13.45045542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205131"},
        {"Hipparcos Number", "HIP 106441"},
        {"Geneva Identification System", "GEN# +1.00205131"},
        {"Smithsonian Astrophysical Observation", "SAO 164475"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.39298386),
        dec: Angle.Degrees(-13.45006684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117544"},
        {"Hipparcos Number", "HIP 65949"},
        {"Geneva Identification System", "GEN# +1.00117544"},
        {"Smithsonian Astrophysical Observation", "SAO 157978"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.80506385),
        dec: Angle.Degrees(-13.44878270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98908"},
        {"Geneva Identification System", "GEN# +6.10212259"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.27181783),
        dec: Angle.Degrees(-13.44843027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54196"},
        {"Hipparcos Number", "HIP 34368"},
        {"Smithsonian Astrophysical Observation", "SAO 152415"},
    },
    visualMagnitude: 8.91,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.85572866),
        dec: Angle.Degrees(-13.44788423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174439"},
        {"Hipparcos Number", "HIP 92498"},
        {"Smithsonian Astrophysical Observation", "SAO 161902"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.76308311),
        dec: Angle.Degrees(-13.44712992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146677"},
        {"Hipparcos Number", "HIP 79852"},
        {"Geneva Identification System", "GEN# +1.00146677"},
        {"Smithsonian Astrophysical Observation", "SAO 159836"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.49896434),
        dec: Angle.Degrees(-13.44464728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143033"},
        {"Hipparcos Number", "HIP 78228"},
        {"Smithsonian Astrophysical Observation", "SAO 159612"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.61116305),
        dec: Angle.Degrees(-13.44267095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114161"},
        {"Hipparcos Number", "HIP 64156"},
        {"Smithsonian Astrophysical Observation", "SAO 157749"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.24024106),
        dec: Angle.Degrees(-13.44117045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52987"},
        {"Smithsonian Astrophysical Observation", "SAO 156262"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.59397940),
        dec: Angle.Degrees(-13.43564793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -220.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105665"},
        {"Hipparcos Number", "HIP 59299"},
        {"Geneva Identification System", "GEN# +1.00105665"},
        {"Smithsonian Astrophysical Observation", "SAO 157118"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.49209090),
        dec: Angle.Degrees(-13.43553063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95870"},
        {"Hipparcos Number", "HIP 54048"},
        {"Geneva Identification System", "GEN# +1.00095870"},
        {"Smithsonian Astrophysical Observation", "SAO 156427"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.90222249),
        dec: Angle.Degrees(-13.43491086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14413",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2347 AB"},
        {"Henry Draper", "HD 19313"},
        {"Hipparcos Number", "HIP 14413"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.51658210),
        dec: Angle.Degrees(-13.43490054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48178"},
        {"Smithsonian Astrophysical Observation", "SAO 155512"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.30485288),
        dec: Angle.Degrees(-13.43483405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171317"},
        {"Hipparcos Number", "HIP 91089"},
        {"Geneva Identification System", "GEN# +1.00171317"},
        {"Smithsonian Astrophysical Observation", "SAO 161627"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.69660163),
        dec: Angle.Degrees(-13.43475039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94654"},
        {"Hipparcos Number", "HIP 53409"},
        {"Smithsonian Astrophysical Observation", "SAO 156328"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.86201235),
        dec: Angle.Degrees(-13.43323759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125356"},
        {"Hipparcos Number", "HIP 69981"},
        {"Smithsonian Astrophysical Observation", "SAO 158492"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.79882075),
        dec: Angle.Degrees(-13.43148106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41797"},
        {"Hipparcos Number", "HIP 28953"},
        {"Smithsonian Astrophysical Observation", "SAO 151120"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.66554347),
        dec: Angle.Degrees(-13.42569083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60261"},
        {"Hipparcos Number", "HIP 36719"},
        {"Smithsonian Astrophysical Observation", "SAO 153051"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.28678280),
        dec: Angle.Degrees(-13.42011839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54296",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8059 A"},
        {"Henry Draper", "HD 96377"},
        {"Hipparcos Number", "HIP 54296"},
        {"Fundamental Katalog 5th Edition", "FK5 4981"},
        {"Smithsonian Astrophysical Observation", "SAO 156461"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.62598452),
        dec: Angle.Degrees(-13.41744277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4219"},
        {"Hipparcos Number", "HIP 3483"},
        {"Geneva Identification System", "GEN# +1.00004219"},
        {"Smithsonian Astrophysical Observation", "SAO 147425"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.11516413),
        dec: Angle.Degrees(-13.41574666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56836"},
        {"Smithsonian Astrophysical Observation", "SAO 156809"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.77499049),
        dec: Angle.Degrees(-13.41473538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89897"},
        {"Hipparcos Number", "HIP 50787"},
        {"Geneva Identification System", "GEN# +1.00089897"},
        {"Renson", "Renson 25844"},
        {"Smithsonian Astrophysical Observation", "SAO 155934"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.54495615),
        dec: Angle.Degrees(-13.40970051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54297",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8059 B"},
        {"Hipparcos Number", "HIP 54297"},
        {"Smithsonian Astrophysical Observation", "SAO 156462"},
    },
    visualMagnitude: 9.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.62859596),
        dec: Angle.Degrees(-13.40864545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224974"},
        {"Hipparcos Number", "HIP 179"},
        {"Fundamental Katalog 5th Edition", "FK5 4002"},
        {"Geneva Identification System", "GEN# +1.00224974"},
        {"Smithsonian Astrophysical Observation", "SAO 166007"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.56886229),
        dec: Angle.Degrees(-13.40751554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 261.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91434"},
        {"Hipparcos Number", "HIP 51656"},
        {"Smithsonian Astrophysical Observation", "SAO 156057"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.30242432),
        dec: Angle.Degrees(-13.40422993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1231"},
        {"Hipparcos Number", "HIP 1318"},
        {"Smithsonian Astrophysical Observation", "SAO 147195"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.14166916),
        dec: Angle.Degrees(-13.40383397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80687",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Timir"},
        {"Henry Draper", "HD 148427"},
        {"Hipparcos Number", "HIP 80687"},
        {"Geneva Identification System", "GEN# +1.00148427"},
        {"Smithsonian Astrophysical Observation", "SAO 159932"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.11738999),
        dec: Angle.Degrees(-13.39964364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194080"},
        {"Hipparcos Number", "HIP 100613"},
        {"Geneva Identification System", "GEN# +1.00194080"},
        {"Smithsonian Astrophysical Observation", "SAO 163530"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.02781716),
        dec: Angle.Degrees(-13.39842140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7920"},
        {"Hipparcos Number", "HIP 6135"},
        {"Geneva Identification System", "GEN# +1.00007920"},
        {"Smithsonian Astrophysical Observation", "SAO 147731"},
        {"Wilson Evans Batten Catalogue", "WEB 1378"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.67781263),
        dec: Angle.Degrees(-13.39686286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141660"},
        {"Hipparcos Number", "HIP 77609"},
        {"Geneva Identification System", "GEN# +1.00141660"},
        {"Smithsonian Astrophysical Observation", "SAO 159531"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.66482855),
        dec: Angle.Degrees(-13.39522311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150395"},
        {"Hipparcos Number", "HIP 81705"},
        {"Smithsonian Astrophysical Observation", "SAO 160045"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.34258818),
        dec: Angle.Degrees(-13.39515554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16159"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.05553593),
        dec: Angle.Degrees(-13.39480867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114669",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16608 AB"},
        {"Henry Draper", "HD 219151"},
        {"Hipparcos Number", "HIP 114669"},
        {"Smithsonian Astrophysical Observation", "SAO 165571"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.45098183),
        dec: Angle.Degrees(-13.39454673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37497"},
        {"Smithsonian Astrophysical Observation", "SAO 153259"},
        {"Wilson Evans Batten Catalogue", "WEB 7418"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.44215146),
        dec: Angle.Degrees(-13.39383800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224744"},
        {"Hipparcos Number", "HIP 26"},
        {"Smithsonian Astrophysical Observation", "SAO 165992"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.08434579),
        dec: Angle.Degrees(-13.39329686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60994",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8573 AB"},
        {"Henry Draper", "HD 108799"},
        {"Hipparcos Number", "HIP 60994"},
        {"Geneva Identification System", "GEN# +1.00108799J"},
        {"Smithsonian Astrophysical Observation", "SAO 157326"},
        {"Wilson Evans Batten Catalogue", "WEB 10857"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.52054829),
        dec: Angle.Degrees(-13.39305238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -261.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8704"},
        {"Hipparcos Number", "HIP 6673"},
        {"Smithsonian Astrophysical Observation", "SAO 147804"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.40794573),
        dec: Angle.Degrees(-13.38892010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34950"},
        {"Hipparcos Number", "HIP 24937"},
        {"Geneva Identification System", "GEN# +1.00034950"},
        {"Smithsonian Astrophysical Observation", "SAO 150355"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.13732534),
        dec: Angle.Degrees(-13.38610405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92055"},
        {"Hipparcos Number", "HIP 52009"},
        {"Geneva Identification System", "GEN# +1.00092055"},
        {"Smithsonian Astrophysical Observation", "SAO 156110"},
        {"Wilson Evans Batten Catalogue", "WEB 9488"},
    },
    visualMagnitude: 4.89,
    bvColour: 2.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.38853109),
        dec: Angle.Degrees(-13.38445095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192389"},
        {"Hipparcos Number", "HIP 99811"},
        {"Smithsonian Astrophysical Observation", "SAO 163383"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.77880924),
        dec: Angle.Degrees(-13.38385217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183620"},
        {"Hipparcos Number", "HIP 95969"},
        {"Geneva Identification System", "GEN# +1.00183620"},
        {"Smithsonian Astrophysical Observation", "SAO 162711"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.73805299),
        dec: Angle.Degrees(-13.38158178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9782"},
        {"Hipparcos Number", "HIP 7404"},
        {"Cincinnati Publication", "Ci 18 215"},
        {"Geneva Identification System", "GEN# +1.00009782"},
        {"Smithsonian Astrophysical Observation", "SAO 147893"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.85901886),
        dec: Angle.Degrees(-13.38112035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91608"},
        {"Cincinnati Publication", "Ci 20 1101"},
        {"Geneva Identification System", "GEN# -0.01305069"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.23901878),
        dec: Angle.Degrees(-13.37797768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -669.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50874",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7749 A"},
        {"Henry Draper", "HD 90045"},
        {"Hipparcos Number", "HIP 50874"},
        {"Smithsonian Astrophysical Observation", "SAO 155947"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.82347964),
        dec: Angle.Degrees(-13.37704890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24965"},
        {"Hipparcos Number", "HIP 18514"},
        {"Smithsonian Astrophysical Observation", "SAO 149278"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.38005567),
        dec: Angle.Degrees(-13.37500723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139200"},
        {"Hipparcos Number", "HIP 76484"},
        {"Geneva Identification System", "GEN# +1.00139200"},
        {"Smithsonian Astrophysical Observation", "SAO 159388"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.31516431),
        dec: Angle.Degrees(-13.37365602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146662"},
        {"Hipparcos Number", "HIP 79843"},
        {"Fundamental Katalog 5th Edition", "FK5 5436"},
        {"Smithsonian Astrophysical Observation", "SAO 159834"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.45829960),
        dec: Angle.Degrees(-13.37241501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153760"},
        {"Hipparcos Number", "HIP 83335"},
        {"Geneva Identification System", "GEN# +1.00153760"},
        {"Smithsonian Astrophysical Observation", "SAO 160232"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.46772946),
        dec: Angle.Degrees(-13.37224407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123454"},
        {"Hipparcos Number", "HIP 69060"},
        {"Smithsonian Astrophysical Observation", "SAO 158373"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.03526827),
        dec: Angle.Degrees(-13.37176522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69974",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Khambalia"},
        {"Henry Draper", "HD 125337"},
        {"Hipparcos Number", "HIP 69974"},
        {"Fundamental Katalog 5th Edition", "FK5 1371"},
        {"Geneva Identification System", "GEN# +1.00125337"},
        {"Renson", "Renson 35800"},
        {"Smithsonian Astrophysical Observation", "SAO 158489"},
        {"Wilson Evans Batten Catalogue", "WEB 12170"},
    },
    visualMagnitude: 4.52,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.77750771),
        dec: Angle.Degrees(-13.37116634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75416"},
        {"Geneva Identification System", "GEN# +6.00277842"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.12903890),
        dec: Angle.Degrees(-13.37085535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214378"},
        {"Hipparcos Number", "HIP 111726"},
        {"Smithsonian Astrophysical Observation", "SAO 165205"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.47174877),
        dec: Angle.Degrees(-13.37078265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20446"},
        {"Hipparcos Number", "HIP 15275"},
        {"Geneva Identification System", "GEN# +1.00020446"},
        {"Smithsonian Astrophysical Observation", "SAO 148874"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.26529430),
        dec: Angle.Degrees(-13.37004805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223050"},
        {"Hipparcos Number", "HIP 117237"},
        {"Smithsonian Astrophysical Observation", "SAO 165872"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.57806051),
        dec: Angle.Degrees(-13.36432955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150467"},
        {"Hipparcos Number", "HIP 81735"},
        {"Geneva Identification System", "GEN# +1.00150467"},
        {"Smithsonian Astrophysical Observation", "SAO 160051"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.42797810),
        dec: Angle.Degrees(-13.36268946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88108"},
        {"Hipparcos Number", "HIP 49755"},
        {"Geneva Identification System", "GEN# +1.00088108"},
        {"Smithsonian Astrophysical Observation", "SAO 155772"},
        {"Wilson Evans Batten Catalogue", "WEB 9172"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.34557888),
        dec: Angle.Degrees(-13.36229891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16502"},
        {"Hipparcos Number", "HIP 12303"},
        {"Geneva Identification System", "GEN# +1.00016502"},
        {"Smithsonian Astrophysical Observation", "SAO 148518"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.60611594),
        dec: Angle.Degrees(-13.36196621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126766"},
        {"Hipparcos Number", "HIP 70714"},
        {"Geneva Identification System", "GEN# +1.00126766"},
        {"Smithsonian Astrophysical Observation", "SAO 158577"},
        {"Wilson Evans Batten Catalogue", "WEB 12253"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.93882698),
        dec: Angle.Degrees(-13.35929187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27426",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4410 A"},
        {"Henry Draper", "HD 38904"},
        {"Hipparcos Number", "HIP 27426"},
        {"Smithsonian Astrophysical Observation", "SAO 150823"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.11439377),
        dec: Angle.Degrees(-13.35828272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43099"},
        {"Geneva Identification System", "GEN# -0.01202669"},
        {"Wilson Evans Batten Catalogue", "WEB 8322"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.66573001),
        dec: Angle.Degrees(-13.35665977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -331.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13506"},
        {"Smithsonian Astrophysical Observation", "SAO 148659"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.48943275),
        dec: Angle.Degrees(-13.35553441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126363"},
        {"Hipparcos Number", "HIP 70501"},
        {"Smithsonian Astrophysical Observation", "SAO 158554"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.32345098),
        dec: Angle.Degrees(-13.35317029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63655"},
        {"Hipparcos Number", "HIP 38184"},
        {"Geneva Identification System", "GEN# +1.00063655"},
        {"Renson", "Renson 17530"},
        {"Smithsonian Astrophysical Observation", "SAO 153449"},
        {"Wilson Evans Batten Catalogue", "WEB 7526"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.37003744),
        dec: Angle.Degrees(-13.35292144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37962"},
        {"Smithsonian Astrophysical Observation", "SAO 153392"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.72615586),
        dec: Angle.Degrees(-13.35162830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58056"},
        {"Hipparcos Number", "HIP 35837"},
        {"Smithsonian Astrophysical Observation", "SAO 152802"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.85050080),
        dec: Angle.Degrees(-13.35019046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208506"},
        {"Hipparcos Number", "HIP 108334"},
        {"Geneva Identification System", "GEN# +1.00208506"},
        {"Smithsonian Astrophysical Observation", "SAO 164758"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.22797354),
        dec: Angle.Degrees(-13.34929606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98109",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13134 B"},
        {"Henry Draper", "HD 188576"},
        {"Hipparcos Number", "HIP 98109"},
        {"Smithsonian Astrophysical Observation", "SAO 163118"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.07047345),
        dec: Angle.Degrees(-13.34808313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19650"},
        {"Hipparcos Number", "HIP 14663"},
        {"Smithsonian Astrophysical Observation", "SAO 148796"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.36145299),
        dec: Angle.Degrees(-13.34770169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158578"},
        {"Hipparcos Number", "HIP 85691"},
        {"Smithsonian Astrophysical Observation", "SAO 160600"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.68056312),
        dec: Angle.Degrees(-13.34718698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118026"},
        {"Hipparcos Number", "HIP 66235"},
        {"Smithsonian Astrophysical Observation", "SAO 158014"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.61739416),
        dec: Angle.Degrees(-13.34696980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29574"},
        {"Hipparcos Number", "HIP 21648"},
        {"Geneva Identification System", "GEN# +1.00029574"},
        {"Smithsonian Astrophysical Observation", "SAO 149791"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.73225514),
        dec: Angle.Degrees(-13.34657125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75867"},
        {"Hipparcos Number", "HIP 43559"},
        {"Smithsonian Astrophysical Observation", "SAO 154700"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.06965480),
        dec: Angle.Degrees(-13.34569190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98107",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13134 A"},
        {"Henry Draper", "HD 188576B"},
        {"Hipparcos Number", "HIP 98107"},
        {"Smithsonian Astrophysical Observation", "SAO 163117"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.06859204),
        dec: Angle.Degrees(-13.34521578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111606"},
    },
    visualMagnitude: 10.83,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)36, 37.3400),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)20, 32.100)
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
    primaryId: "HIP 12981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17387"},
        {"Hipparcos Number", "HIP 12981"},
        {"Smithsonian Astrophysical Observation", "SAO 148600"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.74227059),
        dec: Angle.Degrees(-13.34126324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124410"},
        {"Hipparcos Number", "HIP 69512"},
        {"Smithsonian Astrophysical Observation", "SAO 158440"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.44792601),
        dec: Angle.Degrees(-13.34107637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151238"},
        {"Hipparcos Number", "HIP 82134"},
        {"Smithsonian Astrophysical Observation", "SAO 160091"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.69640732),
        dec: Angle.Degrees(-13.33876272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217735"},
        {"Hipparcos Number", "HIP 113810"},
        {"Smithsonian Astrophysical Observation", "SAO 165461"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.71689692),
        dec: Angle.Degrees(-13.33865445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222039"},
        {"Hipparcos Number", "HIP 116566"},
        {"Smithsonian Astrophysical Observation", "SAO 165800"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.33794427),
        dec: Angle.Degrees(-13.33813098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108139"},
        {"Hipparcos Number", "HIP 60620"},
        {"Smithsonian Astrophysical Observation", "SAO 157274"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.36218205),
        dec: Angle.Degrees(-13.33742197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16621"},
        {"Hipparcos Number", "HIP 12386"},
        {"Geneva Identification System", "GEN# +1.00016621"},
        {"Smithsonian Astrophysical Observation", "SAO 148527"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.86522330),
        dec: Angle.Degrees(-13.33491609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103672"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.08902009),
        dec: Angle.Degrees(-13.33418309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172436"},
        {"Hipparcos Number", "HIP 91597"},
        {"Smithsonian Astrophysical Observation", "SAO 161715"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.19704913),
        dec: Angle.Degrees(-13.33388928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132834"},
        {"Hipparcos Number", "HIP 73516"},
        {"Renson", "Renson 37686"},
        {"Smithsonian Astrophysical Observation", "SAO 158977"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.38892665),
        dec: Angle.Degrees(-13.33230099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27423"},
        {"Hipparcos Number", "HIP 20147"},
        {"Smithsonian Astrophysical Observation", "SAO 149536"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.78391964),
        dec: Angle.Degrees(-13.32920893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95297"},
        {"Hipparcos Number", "HIP 53770"},
        {"Smithsonian Astrophysical Observation", "SAO 156380"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.03292668),
        dec: Angle.Degrees(-13.32880297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157985"},
        {"Hipparcos Number", "HIP 85410"},
        {"Smithsonian Astrophysical Observation", "SAO 160556"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.80272460),
        dec: Angle.Degrees(-13.32686906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102948"},
        {"Hipparcos Number", "HIP 57792"},
        {"Smithsonian Astrophysical Observation", "SAO 156935"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.76142183),
        dec: Angle.Degrees(-13.32326053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186004"},
        {"Hipparcos Number", "HIP 96942"},
        {"Smithsonian Astrophysical Observation", "SAO 162914"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.60824131),
        dec: Angle.Degrees(-13.32182645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176534"},
        {"Hipparcos Number", "HIP 93387"},
        {"Smithsonian Astrophysical Observation", "SAO 162091"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.30765861),
        dec: Angle.Degrees(-13.32165991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90128"},
        {"Hipparcos Number", "HIP 50923"},
        {"Smithsonian Astrophysical Observation", "SAO 155954"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.99463725),
        dec: Angle.Degrees(-13.32121842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47182"},
        {"Hipparcos Number", "HIP 31599"},
        {"Geneva Identification System", "GEN# +1.00047182"},
        {"Smithsonian Astrophysical Observation", "SAO 151700"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.19416835),
        dec: Angle.Degrees(-13.32097688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138904"},
        {"Hipparcos Number", "HIP 76323"},
        {"Smithsonian Astrophysical Observation", "SAO 159365"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.84968944),
        dec: Angle.Degrees(-13.31988376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14464",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2356 A"},
        {"Henry Draper", "HD 19383"},
        {"Hipparcos Number", "HIP 14464"},
        {"Geneva Identification System", "GEN# +1.00019383A"},
        {"Smithsonian Astrophysical Observation", "SAO 148772"},
        {"Wilson Evans Batten Catalogue", "WEB 2817"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.67388983),
        dec: Angle.Degrees(-13.31893063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22493"},
        {"Hipparcos Number", "HIP 16834"},
        {"Smithsonian Astrophysical Observation", "SAO 149065"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.16168208),
        dec: Angle.Degrees(-13.31859039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105091"},
        {"Hipparcos Number", "HIP 59013"},
        {"Smithsonian Astrophysical Observation", "SAO 157082"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.50306296),
        dec: Angle.Degrees(-13.31676847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115954"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.39070185),
        dec: Angle.Degrees(-13.31577640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79432"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.17493751),
        dec: Angle.Degrees(-13.31546410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
