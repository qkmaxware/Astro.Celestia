using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_5() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160197"},
        {"Hipparcos Number", "HIP 86770"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.95955344),
        dec: Angle.Degrees(-67.40286025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38616"},
        {"Hipparcos Number", "HIP 26823"},
        {"Fundamental Katalog 5th Edition", "FK5 2429"},
        {"Geneva Identification System", "GEN# +1.00038616"},
        {"Smithsonian Astrophysical Observation", "SAO 249336"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.42821206),
        dec: Angle.Degrees(-67.40278192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77246"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.59681631),
        dec: Angle.Degrees(-67.40184938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119078"},
        {"Hipparcos Number", "HIP 66948"},
    },
    visualMagnitude: 9.68,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.81818989),
        dec: Angle.Degrees(-67.40136906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86937"},
        {"Hipparcos Number", "HIP 48948"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.78926713),
        dec: Angle.Degrees(-67.39891255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132290"},
        {"Hipparcos Number", "HIP 73551"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.48038526),
        dec: Angle.Degrees(-67.39870045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216025"},
        {"Hipparcos Number", "HIP 112825"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.72575070),
        dec: Angle.Degrees(-67.39667687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199797"},
        {"Hipparcos Number", "HIP 103909"},
        {"Smithsonian Astrophysical Observation", "SAO 254925"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.80675904),
        dec: Angle.Degrees(-67.39157207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146507"},
        {"Hipparcos Number", "HIP 80127"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.33404031),
        dec: Angle.Degrees(-67.38883668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160949"},
        {"Hipparcos Number", "HIP 87126"},
        {"Smithsonian Astrophysical Observation", "SAO 254032"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.01914640),
        dec: Angle.Degrees(-67.38338318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61834"},
        {"Hipparcos Number", "HIP 37002"},
        {"Smithsonian Astrophysical Observation", "SAO 249893"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.07111074),
        dec: Angle.Degrees(-67.37831725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18853"},
        {"Hipparcos Number", "HIP 13842"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.54242457),
        dec: Angle.Degrees(-67.37520354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131909"},
        {"Hipparcos Number", "HIP 73405"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.01599846),
        dec: Angle.Degrees(-67.37146052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154971"},
        {"Hipparcos Number", "HIP 84286"},
        {"Smithsonian Astrophysical Observation", "SAO 253828"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.46497803),
        dec: Angle.Degrees(-67.36961995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17601"},
        {"Hipparcos Number", "HIP 12902"},
        {"Smithsonian Astrophysical Observation", "SAO 248647"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.46452507),
        dec: Angle.Degrees(-67.36935552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90948"},
        {"Hipparcos Number", "HIP 51216"},
        {"Geneva Identification System", "GEN# +1.00090948"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.92080619),
        dec: Angle.Degrees(-67.36832763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142589"},
        {"Hipparcos Number", "HIP 78351"},
        {"Smithsonian Astrophysical Observation", "SAO 253365"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.96748973),
        dec: Angle.Degrees(-67.36639322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58964"},
        {"Hipparcos Number", "HIP 35786"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.71962428),
        dec: Angle.Degrees(-67.36557247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115583"},
        {"Hipparcos Number", "HIP 65021"},
        {"Geneva Identification System", "GEN# +1.00115583"},
        {"Smithsonian Astrophysical Observation", "SAO 252262"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.93107128),
        dec: Angle.Degrees(-67.36429075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156922"},
        {"Hipparcos Number", "HIP 85272"},
        {"Smithsonian Astrophysical Observation", "SAO 253912"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.35962982),
        dec: Angle.Degrees(-67.35894829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166864"},
        {"Hipparcos Number", "HIP 89663"},
        {"Geneva Identification System", "GEN# +1.00166864"},
        {"Smithsonian Astrophysical Observation", "SAO 254195"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.46515044),
        dec: Angle.Degrees(-67.35703623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69241"},
        {"Hipparcos Number", "HIP 40111"},
        {"Smithsonian Astrophysical Observation", "SAO 250147"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.89196306),
        dec: Angle.Degrees(-67.35510755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82790"},
        {"Hipparcos Number", "HIP 46678"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.74792146),
        dec: Angle.Degrees(-67.35361542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151143"},
        {"Hipparcos Number", "HIP 82417"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.63813159),
        dec: Angle.Degrees(-67.35117761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157084"},
        {"Hipparcos Number", "HIP 85339"},
        {"Geneva Identification System", "GEN# +1.00157084"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.59253471),
        dec: Angle.Degrees(-67.34677464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89770"},
        {"Hipparcos Number", "HIP 50530"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.81155419),
        dec: Angle.Degrees(-67.34615689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111936"},
        {"Hipparcos Number", "HIP 62952"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.49552244),
        dec: Angle.Degrees(-67.34418502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223286"},
        {"Hipparcos Number", "HIP 117424"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.14742003),
        dec: Angle.Degrees(-67.34299108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138035"},
        {"Hipparcos Number", "HIP 76177"},
        {"Smithsonian Astrophysical Observation", "SAO 253205"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.39152545),
        dec: Angle.Degrees(-67.33901268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221637"},
        {"Hipparcos Number", "HIP 116335"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.58849295),
        dec: Angle.Degrees(-67.33687056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71242"},
        {"Hipparcos Number", "HIP 40991"},
        {"Fundamental Katalog 5th Edition", "FK5 4751"},
        {"Geneva Identification System", "GEN# +1.00071242"},
        {"Smithsonian Astrophysical Observation", "SAO 250206"},
        {"Wilson Evans Batten Catalogue", "WEB 7947"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.47953306),
        dec: Angle.Degrees(-67.33490660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205070"},
        {"Hipparcos Number", "HIP 106644"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.02735742),
        dec: Angle.Degrees(-67.33376960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76166"},
        {"Hipparcos Number", "HIP 43408"},
        {"Smithsonian Astrophysical Observation", "SAO 250346"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.62800745),
        dec: Angle.Degrees(-67.33347288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311256"},
        {"Hipparcos Number", "HIP 46778"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.00167007),
        dec: Angle.Degrees(-67.32902908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167188"},
        {"Hipparcos Number", "HIP 89782"},
        {"Smithsonian Astrophysical Observation", "SAO 254202"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.83308928),
        dec: Angle.Degrees(-67.32814097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219862"},
        {"Hipparcos Number", "HIP 115209"},
        {"Renson", "Renson 60380"},
        {"Smithsonian Astrophysical Observation", "SAO 255461"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.02615024),
        dec: Angle.Degrees(-67.32291514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144059"},
        {"Hipparcos Number", "HIP 79076"},
        {"Renson", "Renson 40810"},
    },
    visualMagnitude: 9.03,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.13333743),
        dec: Angle.Degrees(-67.32223164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86164"},
        {"Hipparcos Number", "HIP 48528"},
        {"Smithsonian Astrophysical Observation", "SAO 250741"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.46007669),
        dec: Angle.Degrees(-67.32015520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189567"},
        {"Hipparcos Number", "HIP 98959"},
        {"Cincinnati Publication", "Ci 20 1180"},
        {"Geneva Identification System", "GEN# +1.00189567"},
        {"Smithsonian Astrophysical Observation", "SAO 254721"},
        {"Wilson Evans Batten Catalogue", "WEB 17564"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.38119520),
        dec: Angle.Degrees(-67.31925724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 844.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -674.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29440"},
        {"Hipparcos Number", "HIP 21221"},
        {"Smithsonian Astrophysical Observation", "SAO 249055"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.28755144),
        dec: Angle.Degrees(-67.31698748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116255"},
        {"Hipparcos Number", "HIP 65398"},
        {"Geneva Identification System", "GEN# +1.00116255"},
        {"Smithsonian Astrophysical Observation", "SAO 252294"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.05654294),
        dec: Angle.Degrees(-67.31530818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82968"},
        {"Hipparcos Number", "HIP 46788"},
        {"Geneva Identification System", "GEN# +1.00082968"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.01702017),
        dec: Angle.Degrees(-67.31499354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95860"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.45161601),
        dec: Angle.Degrees(-67.31428330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192865"},
        {"Hipparcos Number", "HIP 100396"},
        {"Geneva Identification System", "GEN# +1.00192865"},
        {"Smithsonian Astrophysical Observation", "SAO 254776"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.39791216),
        dec: Angle.Degrees(-67.31288180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148725"},
        {"Hipparcos Number", "HIP 81183"},
        {"Geneva Identification System", "GEN# +1.00148725"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.72745941),
        dec: Angle.Degrees(-67.31138440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132420"},
        {"Hipparcos Number", "HIP 73603"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.67433670),
        dec: Angle.Degrees(-67.31087164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182485"},
        {"Hipparcos Number", "HIP 95857"},
        {"Smithsonian Astrophysical Observation", "SAO 254584"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.43924231),
        dec: Angle.Degrees(-67.30830762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18278"},
        {"Hipparcos Number", "HIP 13392"},
        {"Smithsonian Astrophysical Observation", "SAO 248675"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.09180863),
        dec: Angle.Degrees(-67.30713946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94729",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94729"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.13201347),
        dec: Angle.Degrees(-67.30672545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310831"},
        {"Hipparcos Number", "HIP 57260"},
        {"Geneva Identification System", "GEN# +1.00310831"},
        {"Wilson Evans Batten Catalogue", "WEB 10297"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.13705614),
        dec: Angle.Degrees(-67.30524342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93913"},
        {"Hipparcos Number", "HIP 52868"},
        {"Celescope Catalog", "CEL 3723"},
        {"Geneva Identification System", "GEN# +1.00093913"},
        {"Smithsonian Astrophysical Observation", "SAO 251137"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.17513427),
        dec: Angle.Degrees(-67.30519578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213046"},
        {"Hipparcos Number", "HIP 111134"},
        {"Geneva Identification System", "GEN# +1.00213046"},
        {"Smithsonian Astrophysical Observation", "SAO 255236"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.70691621),
        dec: Angle.Degrees(-67.30371372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109564"},
        {"Hipparcos Number", "HIP 61538"},
        {"Geneva Identification System", "GEN# +1.00109564"},
        {"Smithsonian Astrophysical Observation", "SAO 251970"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.11137273),
        dec: Angle.Degrees(-67.30267508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269371"},
        {"Hipparcos Number", "HIP 24907"},
        {"Geneva Identification System", "GEN# +1.00269371"},
    },
    visualMagnitude: 11.28,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.07950283),
        dec: Angle.Degrees(-67.30157847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16777"},
        {"Hipparcos Number", "HIP 12269"},
        {"Smithsonian Astrophysical Observation", "SAO 248611"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.49391507),
        dec: Angle.Degrees(-67.30089337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181434"},
        {"Hipparcos Number", "HIP 95493"},
    },
    visualMagnitude: 9.84,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)25, 26.0400),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)18, 01.600)
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
    primaryId: "HIP 7146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7146"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.02992194),
        dec: Angle.Degrees(-67.29909189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -362.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58873"},
        {"Hipparcos Number", "HIP 35753"},
        {"Smithsonian Astrophysical Observation", "SAO 249837"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.61921435),
        dec: Angle.Degrees(-67.29735112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89204"},
        {"Hipparcos Number", "HIP 50204"},
        {"Geneva Identification System", "GEN# +1.00089204"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.73979571),
        dec: Angle.Degrees(-67.29534950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268943"},
        {"Hipparcos Number", "HIP 23600"},
        {"Geneva Identification System", "GEN# +1.00268943"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.11153529),
        dec: Angle.Degrees(-67.29523360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148327"},
        {"Hipparcos Number", "HIP 80970"},
        {"Geneva Identification System", "GEN# +1.00148327"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.01065971),
        dec: Angle.Degrees(-67.29455479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95913"},
        {"Hipparcos Number", "HIP 53983"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.64907985),
        dec: Angle.Degrees(-67.29354136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93099"},
        {"Hipparcos Number", "HIP 52445"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.81863034),
        dec: Angle.Degrees(-67.28970175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173345"},
        {"Hipparcos Number", "HIP 92411"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.48526068),
        dec: Angle.Degrees(-67.28685779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185852"},
        {"Hipparcos Number", "HIP 97258"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.49840913),
        dec: Angle.Degrees(-67.28629465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89205"},
        {"Hipparcos Number", "HIP 50217"},
        {"Smithsonian Astrophysical Observation", "SAO 250894"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.77599415),
        dec: Angle.Degrees(-67.28576007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31907"},
        {"Hipparcos Number", "HIP 22806"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.58681696),
        dec: Angle.Degrees(-67.28546792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94698"},
        {"Hipparcos Number", "HIP 53313"},
        {"Smithsonian Astrophysical Observation", "SAO 251172"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.56930918),
        dec: Angle.Degrees(-67.28506538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42701"},
        {"Hipparcos Number", "HIP 28970"},
        {"Smithsonian Astrophysical Observation", "SAO 249453"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.71065522),
        dec: Angle.Degrees(-67.28335642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17373"},
        {"Hipparcos Number", "HIP 12735"},
        {"Smithsonian Astrophysical Observation", "SAO 248636"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.92810195),
        dec: Angle.Degrees(-67.28309546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77188"},
        {"Hipparcos Number", "HIP 43941"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.25156569),
        dec: Angle.Degrees(-67.28228844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23673"},
        {"Hipparcos Number", "HIP 17322"},
        {"Smithsonian Astrophysical Observation", "SAO 248872"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.62106151),
        dec: Angle.Degrees(-67.28074010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157601"},
        {"Hipparcos Number", "HIP 85586"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.34608558),
        dec: Angle.Degrees(-67.28046716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83530"},
        {"Hipparcos Number", "HIP 47097"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.97799288),
        dec: Angle.Degrees(-67.28030586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198970"},
        {"Hipparcos Number", "HIP 103473"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.45503210),
        dec: Angle.Degrees(-67.27898953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17722"},
        {"Hipparcos Number", "HIP 12988"},
        {"Geneva Identification System", "GEN# +1.00017722"},
        {"Smithsonian Astrophysical Observation", "SAO 248650"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.75972977),
        dec: Angle.Degrees(-67.27769876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107595"},
        {"Hipparcos Number", "HIP 60335"},
        {"Geneva Identification System", "GEN# +1.00107595"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.56980503),
        dec: Angle.Degrees(-67.27060468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143952"},
        {"Hipparcos Number", "HIP 79032"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.96895660),
        dec: Angle.Degrees(-67.26795082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76920"},
        {"Hipparcos Number", "HIP 43803"},
        {"Smithsonian Astrophysical Observation", "SAO 250379"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.81991206),
        dec: Angle.Degrees(-67.26553458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88572"},
        {"Hipparcos Number", "HIP 49828"},
        {"Smithsonian Astrophysical Observation", "SAO 250851"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.58846594),
        dec: Angle.Degrees(-67.26340855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191239"},
        {"Hipparcos Number", "HIP 99652"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.34601995),
        dec: Angle.Degrees(-67.25466111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73906"},
        {"Hipparcos Number", "HIP 42226"},
        {"Smithsonian Astrophysical Observation", "SAO 250285"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.14582580),
        dec: Angle.Degrees(-67.25370808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6004"},
        {"Hipparcos Number", "HIP 4665"},
        {"Fundamental Katalog 5th Edition", "FK5 4092"},
        {"Geneva Identification System", "GEN# +1.00006004"},
        {"Smithsonian Astrophysical Observation", "SAO 248297"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.98530516),
        dec: Angle.Degrees(-67.25203702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162399"},
        {"Hipparcos Number", "HIP 87795"},
        {"Fundamental Katalog 5th Edition", "FK5 5576"},
        {"Smithsonian Astrophysical Observation", "SAO 254077"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.02688763),
        dec: Angle.Degrees(-67.25068604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195350"},
        {"Hipparcos Number", "HIP 101559"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.74003659),
        dec: Angle.Degrees(-67.24837744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18726"},
        {"Hipparcos Number", "HIP 13720"},
        {"Smithsonian Astrophysical Observation", "SAO 248691"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.17045584),
        dec: Angle.Degrees(-67.24635691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130042"},
        {"Hipparcos Number", "HIP 72493"},
        {"Smithsonian Astrophysical Observation", "SAO 252899"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.34949776),
        dec: Angle.Degrees(-67.23519060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -320.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174694"},
        {"Hipparcos Number", "HIP 93015"},
        {"Fundamental Katalog 5th Edition", "FK5 3505"},
        {"Geneva Identification System", "GEN# +1.00174694"},
        {"Smithsonian Astrophysical Observation", "SAO 254413"},
        {"Wilson Evans Batten Catalogue", "WEB 16107"},
    },
    visualMagnitude: 4.40,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.23766942),
        dec: Angle.Degrees(-67.23353511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10533"},
        {"Hipparcos Number", "HIP 7806"},
        {"Smithsonian Astrophysical Observation", "SAO 248418"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.09990254),
        dec: Angle.Degrees(-67.23219270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23334"},
        {"Hipparcos Number", "HIP 17116"},
        {"Smithsonian Astrophysical Observation", "SAO 248862"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.98882913),
        dec: Angle.Degrees(-67.22935992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52626"},
        {"Hipparcos Number", "HIP 33401"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.21027769),
        dec: Angle.Degrees(-67.22746181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47856"},
        {"Hipparcos Number", "HIP 31450"},
        {"Smithsonian Astrophysical Observation", "SAO 249597"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.83792427),
        dec: Angle.Degrees(-67.22621579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71904"},
        {"Hipparcos Number", "HIP 41301"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.40039406),
        dec: Angle.Degrees(-67.22514446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175654"},
        {"Hipparcos Number", "HIP 93414"},
        {"Smithsonian Astrophysical Observation", "SAO 254435"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.37704621),
        dec: Angle.Degrees(-67.22184457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221020"},
        {"Hipparcos Number", "HIP 115935"},
        {"Smithsonian Astrophysical Observation", "SAO 255499"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.34032854),
        dec: Angle.Degrees(-67.21594178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109614"},
        {"Hipparcos Number", "HIP 61549"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.17604030),
        dec: Angle.Degrees(-67.21403906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112367"},
        {"Hipparcos Number", "HIP 63228"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.33928009),
        dec: Angle.Degrees(-67.21268815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67688"},
        {"Hipparcos Number", "HIP 39510"},
        {"Geneva Identification System", "GEN# +1.00067688"},
        {"Smithsonian Astrophysical Observation", "SAO 250104"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.13086702),
        dec: Angle.Degrees(-67.20828816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12635"},
        {"Hipparcos Number", "HIP 9418"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.24992849),
        dec: Angle.Degrees(-67.20266070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63406"},
        {"Hipparcos Number", "HIP 37695"},
        {"Fundamental Katalog 5th Edition", "FK5 4697"},
        {"Smithsonian Astrophysical Observation", "SAO 249941"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.00322922),
        dec: Angle.Degrees(-67.20211263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82684"},
        {"Hipparcos Number", "HIP 46600"},
        {"Smithsonian Astrophysical Observation", "SAO 250604"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.53750288),
        dec: Angle.Degrees(-67.20158014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152652"},
        {"Hipparcos Number", "HIP 83156"},
        {"Geneva Identification System", "GEN# +1.00152652"},
        {"Smithsonian Astrophysical Observation", "SAO 253758"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.90003551),
        dec: Angle.Degrees(-67.19955830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154903"},
        {"Hipparcos Number", "HIP 84248"},
        {"Geneva Identification System", "GEN# +1.00154903"},
        {"Smithsonian Astrophysical Observation", "SAO 253827"},
        {"Wilson Evans Batten Catalogue", "WEB 14228"},
    },
    visualMagnitude: 5.87,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.32546891),
        dec: Angle.Degrees(-67.19637197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183983"},
        {"Hipparcos Number", "HIP 96484"},
        {"Smithsonian Astrophysical Observation", "SAO 254604"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.22305695),
        dec: Angle.Degrees(-67.19485112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163089"},
        {"Hipparcos Number", "HIP 88105"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.90868831),
        dec: Angle.Degrees(-67.19464456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75017"},
    },
    visualMagnitude: 11.25,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.93461940),
        dec: Angle.Degrees(-67.19362116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109867"},
        {"Hipparcos Number", "HIP 61703"},
        {"Geneva Identification System", "GEN# +1.00109867A"},
        {"Smithsonian Astrophysical Observation", "SAO 251980"},
        {"Wilson Evans Batten Catalogue", "WEB 10977"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.71819205),
        dec: Angle.Degrees(-67.19304671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211206"},
        {"Hipparcos Number", "HIP 110083"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.47582086),
        dec: Angle.Degrees(-67.19214739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135570"},
        {"Hipparcos Number", "HIP 75020"},
        {"Geneva Identification System", "GEN# +1.00135570"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.94178180),
        dec: Angle.Degrees(-67.19077001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153987"},
        {"Hipparcos Number", "HIP 83820"},
        {"Geneva Identification System", "GEN# +1.00153987"},
        {"Smithsonian Astrophysical Observation", "SAO 253801"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.95872423),
        dec: Angle.Degrees(-67.18792757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58140"},
        {"Hipparcos Number", "HIP 35464"},
        {"Smithsonian Astrophysical Observation", "SAO 249824"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.81093281),
        dec: Angle.Degrees(-67.18768073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127202"},
        {"Hipparcos Number", "HIP 71159"},
        {"Geneva Identification System", "GEN# +1.00127202"},
        {"Smithsonian Astrophysical Observation", "SAO 252784"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.30945536),
        dec: Angle.Degrees(-67.18752608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34649"},
        {"Hipparcos Number", "HIP 24372"},
        {"Fundamental Katalog 5th Edition", "FK5 196"},
        {"Geneva Identification System", "GEN# +1.00034649"},
        {"Smithsonian Astrophysical Observation", "SAO 249225"},
        {"Wilson Evans Batten Catalogue", "WEB 4728"},
    },
    visualMagnitude: 4.81,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.43927858),
        dec: Angle.Degrees(-67.18534976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197866"},
        {"Hipparcos Number", "HIP 102860"},
        {"Smithsonian Astrophysical Observation", "SAO 254877"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.57852153),
        dec: Angle.Degrees(-67.18433995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122102"},
        {"Hipparcos Number", "HIP 68561"},
        {"Smithsonian Astrophysical Observation", "SAO 252562"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.53449167),
        dec: Angle.Degrees(-67.17974574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105754"},
        {"Hipparcos Number", "HIP 59349"},
        {"Smithsonian Astrophysical Observation", "SAO 251773"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.61728129),
        dec: Angle.Degrees(-67.17681316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219283"},
        {"Hipparcos Number", "HIP 114839"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.92442499),
        dec: Angle.Degrees(-67.17212513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109563"},
        {"Hipparcos Number", "HIP 61537"},
        {"Geneva Identification System", "GEN# +1.00109563"},
        {"Smithsonian Astrophysical Observation", "SAO 251969"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.10940697),
        dec: Angle.Degrees(-67.17101386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26540"},
        {"Hipparcos Number", "HIP 19220"},
        {"Smithsonian Astrophysical Observation", "SAO 248946"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.79460746),
        dec: Angle.Degrees(-67.17091903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89891"},
        {"Hipparcos Number", "HIP 50589"},
        {"Smithsonian Astrophysical Observation", "SAO 250923"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.01480640),
        dec: Angle.Degrees(-67.16793715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179279"},
        {"Hipparcos Number", "HIP 94767"},
        {"Smithsonian Astrophysical Observation", "SAO 254512"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.24213053),
        dec: Angle.Degrees(-67.16666461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91907"},
        {"Hipparcos Number", "HIP 51776"},
        {"Smithsonian Astrophysical Observation", "SAO 251021"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.70202680),
        dec: Angle.Degrees(-67.16548941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92571"},
        {"Hipparcos Number", "HIP 52162"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.85015118),
        dec: Angle.Degrees(-67.16541387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15662"},
        {"Hipparcos Number", "HIP 11466"},
        {"Smithsonian Astrophysical Observation", "SAO 248568"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.97351975),
        dec: Angle.Degrees(-67.16452859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152168"},
        {"Hipparcos Number", "HIP 82923"},
        {"Smithsonian Astrophysical Observation", "SAO 253739"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.19087549),
        dec: Angle.Degrees(-67.16428459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21069"},
        {"Hipparcos Number", "HIP 15507"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.95562651),
        dec: Angle.Degrees(-67.15908356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25809"},
        {"Hipparcos Number", "HIP 18739"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.21125806),
        dec: Angle.Degrees(-67.14847756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89163"},
        {"Hipparcos Number", "HIP 50181"},
        {"Geneva Identification System", "GEN# +1.00089163"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.65444939),
        dec: Angle.Degrees(-67.14263853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72634"},
        {"Hipparcos Number", "HIP 41667"},
        {"Geneva Identification System", "GEN# +1.00072634"},
        {"Renson", "Renson 20130"},
        {"Smithsonian Astrophysical Observation", "SAO 250250"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.42894980),
        dec: Angle.Degrees(-67.13983701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85670"},
        {"Hipparcos Number", "HIP 48279"},
        {"Geneva Identification System", "GEN# +1.00085670"},
        {"Smithsonian Astrophysical Observation", "SAO 250720"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.63152370),
        dec: Angle.Degrees(-67.13960522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38746"},
        {"Hipparcos Number", "HIP 26904"},
        {"Smithsonian Astrophysical Observation", "SAO 249339"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.67353712),
        dec: Angle.Degrees(-67.13876110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9963"},
        {"Hipparcos Number", "HIP 7383"},
        {"Geneva Identification System", "GEN# +1.00009963"},
        {"Smithsonian Astrophysical Observation", "SAO 248406"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.78079022),
        dec: Angle.Degrees(-67.13623043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142222"},
        {"Hipparcos Number", "HIP 78173"},
        {"Smithsonian Astrophysical Observation", "SAO 253356"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.42712929),
        dec: Angle.Degrees(-67.13596525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7311"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.52499772),
        dec: Angle.Degrees(-67.13262298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 262.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62488"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.07917980),
        dec: Angle.Degrees(-67.13168563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111161"},
        {"Hipparcos Number", "HIP 62482"},
        {"Smithsonian Astrophysical Observation", "SAO 252034"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.06967284),
        dec: Angle.Degrees(-67.13117907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80488"},
        {"Hipparcos Number", "HIP 45516"},
        {"Smithsonian Astrophysical Observation", "SAO 250518"},
    },
    visualMagnitude: 8.99,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.14373775),
        dec: Angle.Degrees(-67.13107771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99317"},
        {"Hipparcos Number", "HIP 55702"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.20384770),
        dec: Angle.Degrees(-67.12985935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160418"},
        {"Hipparcos Number", "HIP 86878"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.25375089),
        dec: Angle.Degrees(-67.12981799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217847"},
        {"Hipparcos Number", "HIP 113970"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.21818389),
        dec: Angle.Degrees(-67.12928518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148839"},
        {"Hipparcos Number", "HIP 81254"},
        {"Geneva Identification System", "GEN# +1.00148839"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.94081988),
        dec: Angle.Degrees(-67.12685209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208263"},
        {"Hipparcos Number", "HIP 108418"},
        {"Geneva Identification System", "GEN# +1.00208263"},
        {"Smithsonian Astrophysical Observation", "SAO 255109"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.45584634),
        dec: Angle.Degrees(-67.12313207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34712"},
        {"Cincinnati Publication", "Ci 20 416"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.83157295),
        dec: Angle.Degrees(-67.12114561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -662.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202692"},
        {"Hipparcos Number", "HIP 105401"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.24008913),
        dec: Angle.Degrees(-67.11923193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270754"},
        {"Hipparcos Number", "HIP 22237"},
        {"Geneva Identification System", "GEN# +1.00270754"},
    },
    visualMagnitude: 11.27,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.76854080),
        dec: Angle.Degrees(-67.11475776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146040"},
        {"Hipparcos Number", "HIP 79925"},
        {"Smithsonian Astrophysical Observation", "SAO 253490"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.70300705),
        dec: Angle.Degrees(-67.11200210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8025"},
        {"Hipparcos Number", "HIP 6065"},
        {"Smithsonian Astrophysical Observation", "SAO 248356"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.46161153),
        dec: Angle.Degrees(-67.11053215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187395"},
        {"Hipparcos Number", "HIP 97952"},
        {"Smithsonian Astrophysical Observation", "SAO 254680"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.61149857),
        dec: Angle.Degrees(-67.11034037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150549"},
        {"Hipparcos Number", "HIP 82129"},
        {"Geneva Identification System", "GEN# +1.00150549"},
        {"Renson", "Renson 42610"},
        {"Smithsonian Astrophysical Observation", "SAO 253688"},
        {"Wilson Evans Batten Catalogue", "WEB 13869"},
    },
    visualMagnitude: 5.10,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.66672526),
        dec: Angle.Degrees(-67.10965828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123275"},
        {"Hipparcos Number", "HIP 69156"},
        {"Renson", "Renson 35340"},
        {"Smithsonian Astrophysical Observation", "SAO 252625"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.35124275),
        dec: Angle.Degrees(-67.10721019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206503"},
        {"Hipparcos Number", "HIP 107416"},
        {"Smithsonian Astrophysical Observation", "SAO 255063"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.35428802),
        dec: Angle.Degrees(-67.10354844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111686"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.37588006),
        dec: Angle.Degrees(-67.10293101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5114"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.38418086),
        dec: Angle.Degrees(-66.74306038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 275.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19129"},
        {"Hipparcos Number", "HIP 14044"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.21997590),
        dec: Angle.Degrees(-67.10289172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32546"},
        {"Hipparcos Number", "HIP 23145"},
        {"Geneva Identification System", "GEN# +1.00032546"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.70262598),
        dec: Angle.Degrees(-67.10170364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97617"},
        {"Hipparcos Number", "HIP 54774"},
        {"Celescope Catalog", "CEL 3852"},
        {"Geneva Identification System", "GEN# +1.00097617"},
        {"Smithsonian Astrophysical Observation", "SAO 251321"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.20417209),
        dec: Angle.Degrees(-67.09980291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34461"},
        {"Hipparcos Number", "HIP 24245"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.07517288),
        dec: Angle.Degrees(-67.09491653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179066"},
        {"Hipparcos Number", "HIP 94687"},
        {"Geneva Identification System", "GEN# +1.00179066"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.00539158),
        dec: Angle.Degrees(-67.08969011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211808"},
        {"Hipparcos Number", "HIP 110425"},
        {"Smithsonian Astrophysical Observation", "SAO 255206"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.50512298),
        dec: Angle.Degrees(-67.08455543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133683"},
        {"Hipparcos Number", "HIP 74184"},
        {"Fundamental Katalog 5th Edition", "FK5 3195"},
        {"Geneva Identification System", "GEN# +1.00133683"},
        {"Smithsonian Astrophysical Observation", "SAO 253031"},
        {"Wilson Evans Batten Catalogue", "WEB 12669"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.37466411),
        dec: Angle.Degrees(-67.08412683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150869"},
        {"Hipparcos Number", "HIP 82280"},
        {"Geneva Identification System", "GEN# +1.00150869"},
        {"Wilson Evans Batten Catalogue", "WEB 13889"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.18024261),
        dec: Angle.Degrees(-67.08324432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88423"},
        {"Hipparcos Number", "HIP 49741"},
        {"Smithsonian Astrophysical Observation", "SAO 250841"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.31179287),
        dec: Angle.Degrees(-67.08241132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99589"},
        {"Hipparcos Number", "HIP 55827"},
        {"Geneva Identification System", "GEN# +1.00099589"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.62656742),
        dec: Angle.Degrees(-67.07895702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100027"},
        {"Hipparcos Number", "HIP 56086"},
        {"Smithsonian Astrophysical Observation", "SAO 251425"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.44845728),
        dec: Angle.Degrees(-67.07756457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145142"},
        {"Hipparcos Number", "HIP 79549"},
        {"Smithsonian Astrophysical Observation", "SAO 253463"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.48176152),
        dec: Angle.Degrees(-67.07524599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130496"},
        {"Hipparcos Number", "HIP 72719"},
        {"Smithsonian Astrophysical Observation", "SAO 252919"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.01450675),
        dec: Angle.Degrees(-67.07355920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63747"},
        {"Hipparcos Number", "HIP 37862"},
        {"Smithsonian Astrophysical Observation", "SAO 249955"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.42456756),
        dec: Angle.Degrees(-67.06980885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270278"},
        {"Hipparcos Number", "HIP 27682"},
        {"Geneva Identification System", "GEN# +1.00270278"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.91004269),
        dec: Angle.Degrees(-67.06773736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56194"},
        {"Hipparcos Number", "HIP 34683"},
        {"Geneva Identification System", "GEN# +1.00056194"},
        {"Smithsonian Astrophysical Observation", "SAO 249770"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.73936685),
        dec: Angle.Degrees(-67.06708299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213287"},
        {"Hipparcos Number", "HIP 111255"},
        {"Smithsonian Astrophysical Observation", "SAO 255243"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.09584933),
        dec: Angle.Degrees(-67.06691570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104234"},
        {"Hipparcos Number", "HIP 58535"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.06070083),
        dec: Angle.Degrees(-67.06302261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92046"},
        {"Hipparcos Number", "HIP 51858"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.92863928),
        dec: Angle.Degrees(-67.05689428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100508"},
        {"Hipparcos Number", "HIP 56363"},
        {"Geneva Identification System", "GEN# +1.00100508"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.30631677),
        dec: Angle.Degrees(-67.05455170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -284.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39903"},
        {"Hipparcos Number", "HIP 27570"},
        {"Renson", "Renson 10650"},
        {"Smithsonian Astrophysical Observation", "SAO 249371"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.58229436),
        dec: Angle.Degrees(-67.05106744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80710"},
        {"Hipparcos Number", "HIP 45615"},
        {"Geneva Identification System", "GEN# +1.00080710"},
        {"Smithsonian Astrophysical Observation", "SAO 250529"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.46527559),
        dec: Angle.Degrees(-67.05089926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98659"},
        {"Hipparcos Number", "HIP 55356"},
        {"Celescope Catalog", "CEL 3881"},
        {"Geneva Identification System", "GEN# +1.00098659J"},
        {"Smithsonian Astrophysical Observation", "SAO 251361"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.02661809),
        dec: Angle.Degrees(-67.04939778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196479"},
        {"Hipparcos Number", "HIP 102129"},
        {"Smithsonian Astrophysical Observation", "SAO 254853"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.43840882),
        dec: Angle.Degrees(-67.04924836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222059"},
        {"Hipparcos Number", "HIP 116620"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.50323883),
        dec: Angle.Degrees(-67.04876285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185890"},
        {"Hipparcos Number", "HIP 97264"},
        {"Geneva Identification System", "GEN# +1.00185890"},
        {"Smithsonian Astrophysical Observation", "SAO 254642"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.51610458),
        dec: Angle.Degrees(-67.04793916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113589"},
        {"Hipparcos Number", "HIP 63932"},
        {"Renson", "Renson 32950"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.54215431),
        dec: Angle.Degrees(-67.04560597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152462"},
        {"Hipparcos Number", "HIP 83072"},
        {"Geneva Identification System", "GEN# +1.00152462"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.62390419),
        dec: Angle.Degrees(-67.04492039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38305"},
        {"Hipparcos Number", "HIP 26629"},
        {"Geneva Identification System", "GEN# +1.00038305"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.89839275),
        dec: Angle.Degrees(-67.04168410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109993"},
        {"Hipparcos Number", "HIP 61787"},
        {"Geneva Identification System", "GEN# +1.00109993"},
        {"Smithsonian Astrophysical Observation", "SAO 251986"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.96248335),
        dec: Angle.Degrees(-67.04070930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100357"},
        {"Hipparcos Number", "HIP 56269"},
        {"Geneva Identification System", "GEN# +1.00100357"},
        {"Renson", "Renson 28840"},
        {"Smithsonian Astrophysical Observation", "SAO 251448"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.02533538),
        dec: Angle.Degrees(-67.03833702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151099"},
        {"Hipparcos Number", "HIP 82394"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.53684028),
        dec: Angle.Degrees(-67.02626236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117136"},
        {"Hipparcos Number", "HIP 65878"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.56083314),
        dec: Angle.Degrees(-67.02579316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73276"},
        {"Hipparcos Number", "HIP 41982"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.35385054),
        dec: Angle.Degrees(-67.02401947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84694"},
        {"Hipparcos Number", "HIP 47744"},
        {"Geneva Identification System", "GEN# +1.00084694"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.98740111),
        dec: Angle.Degrees(-67.02387998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269781"},
        {"Hipparcos Number", "HIP 26135"},
        {"Geneva Identification System", "GEN# +1.00269781"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.59360467),
        dec: Angle.Degrees(-67.02321486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116703"},
        {"Hipparcos Number", "HIP 65608"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.78609128),
        dec: Angle.Degrees(-67.02237595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127725"},
        {"Hipparcos Number", "HIP 71408"},
        {"Smithsonian Astrophysical Observation", "SAO 252812"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.03701383),
        dec: Angle.Degrees(-67.01801706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194507"},
        {"Hipparcos Number", "HIP 101144"},
        {"Smithsonian Astrophysical Observation", "SAO 254802"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.53506565),
        dec: Angle.Degrees(-67.01735311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55150"},
        {"Hipparcos Number", "HIP 34308"},
        {"Fundamental Katalog 5th Edition", "FK5 4642"},
        {"Smithsonian Astrophysical Observation", "SAO 249742"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.69760088),
        dec: Angle.Degrees(-67.01616778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68837",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68837"},
    },
    visualMagnitude: 9.54,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.42679534),
        dec: Angle.Degrees(-67.01522314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135435"},
        {"Hipparcos Number", "HIP 74947"},
        {"Smithsonian Astrophysical Observation", "SAO 253099"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.73129431),
        dec: Angle.Degrees(-67.01498051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86810"},
        {"Hipparcos Number", "HIP 48886"},
        {"Smithsonian Astrophysical Observation", "SAO 250768"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.56345351),
        dec: Angle.Degrees(-67.01321096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224423"},
        {"Hipparcos Number", "HIP 118144"},
        {"Geneva Identification System", "GEN# +1.00224423"},
        {"Renson", "Renson 61510"},
        {"Smithsonian Astrophysical Observation", "SAO 255610"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.46996966),
        dec: Angle.Degrees(-67.00603170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45616"},
        {"Hipparcos Number", "HIP 30366"},
        {"Smithsonian Astrophysical Observation", "SAO 249533"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.79450051),
        dec: Angle.Degrees(-67.00547286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148976"},
        {"Hipparcos Number", "HIP 81320"},
        {"Smithsonian Astrophysical Observation", "SAO 253618"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.13353524),
        dec: Angle.Degrees(-67.00485240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198053"},
        {"Hipparcos Number", "HIP 102967"},
        {"Smithsonian Astrophysical Observation", "SAO 254881"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.92974865),
        dec: Angle.Degrees(-66.99749563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136474"},
        {"Hipparcos Number", "HIP 75453"},
        {"Geneva Identification System", "GEN# +1.00136474"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.22038256),
        dec: Angle.Degrees(-66.99673397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140588"},
        {"Hipparcos Number", "HIP 77453"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.20026102),
        dec: Angle.Degrees(-66.98983238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204371"},
        {"Hipparcos Number", "HIP 106257"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.82616441),
        dec: Angle.Degrees(-66.98909600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209652"},
        {"Hipparcos Number", "HIP 109208"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.86458673),
        dec: Angle.Degrees(-66.98693138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310262"},
        {"Hipparcos Number", "HIP 53215"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.26275328),
        dec: Angle.Degrees(-66.98564974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91272"},
        {"Hipparcos Number", "HIP 51425"},
        {"Geneva Identification System", "GEN# +1.00091272"},
        {"Smithsonian Astrophysical Observation", "SAO 250989"},
        {"Wilson Evans Batten Catalogue", "WEB 9387"},
    },
    visualMagnitude: 6.19,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.53671877),
        dec: Angle.Degrees(-66.98466678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101250"},
        {"Hipparcos Number", "HIP 56790"},
        {"Geneva Identification System", "GEN# +1.00101250"},
        {"Smithsonian Astrophysical Observation", "SAO 251513"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.64255177),
        dec: Angle.Degrees(-66.98438932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148992"},
        {"Hipparcos Number", "HIP 81338"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.18527268),
        dec: Angle.Degrees(-66.98436713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76286"},
        {"Hipparcos Number", "HIP 43476"},
        {"Smithsonian Astrophysical Observation", "SAO 250353"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.83775683),
        dec: Angle.Degrees(-66.98298479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269376"},
        {"Hipparcos Number", "HIP 24940"},
        {"Geneva Identification System", "GEN# +1.00269376"},
    },
    visualMagnitude: 11.26,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.14046043),
        dec: Angle.Degrees(-66.98151204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224631"},
        {"Hipparcos Number", "HIP 118279"},
        {"Smithsonian Astrophysical Observation", "SAO 255618"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.86888267),
        dec: Angle.Degrees(-66.98098452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11957"},
        {"Hipparcos Number", "HIP 8917"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.69964927),
        dec: Angle.Degrees(-66.98010687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 271924"},
        {"Hipparcos Number", "HIP 29055"},
    },
    visualMagnitude: 11.94,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.94053224),
        dec: Angle.Degrees(-66.97748640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110246"},
        {"Henry Draper 2", "HD 110245"},
        {"Hipparcos Number", "HIP 61935"},
        {"Geneva Identification System", "GEN# +1.00110245"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.39080552),
        dec: Angle.Degrees(-66.97014163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106848"},
        {"Hipparcos Number", "HIP 59934"},
        {"Smithsonian Astrophysical Observation", "SAO 251831"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.40342136),
        dec: Angle.Degrees(-66.96852247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116954"},
        {"Hipparcos Number", "HIP 65761"},
        {"Smithsonian Astrophysical Observation", "SAO 252325"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.22937933),
        dec: Angle.Degrees(-66.96787798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194399"},
        {"Hipparcos Number", "HIP 101089"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.37890526),
        dec: Angle.Degrees(-66.96244119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100382"},
        {"Hipparcos Number", "HIP 56287"},
        {"Geneva Identification System", "GEN# +1.00100382"},
        {"Smithsonian Astrophysical Observation", "SAO 251451"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.08331854),
        dec: Angle.Degrees(-66.96183490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185391"},
        {"Hipparcos Number", "HIP 97064"},
        {"Geneva Identification System", "GEN# +1.00185391"},
        {"Smithsonian Astrophysical Observation", "SAO 254633"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.89109269),
        dec: Angle.Degrees(-66.96034878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268907"},
        {"Hipparcos Number", "HIP 23500"},
        {"Geneva Identification System", "GEN# +1.00268907"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.78672343),
        dec: Angle.Degrees(-66.95968061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200133"},
        {"Hipparcos Number", "HIP 104083"},
        {"Smithsonian Astrophysical Observation", "SAO 254933"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.30511378),
        dec: Angle.Degrees(-66.95769075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16939"},
        {"Hipparcos Number", "HIP 12391"},
        {"Smithsonian Astrophysical Observation", "SAO 248618"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.89353379),
        dec: Angle.Degrees(-66.95726409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115267"},
        {"Hipparcos Number", "HIP 64853"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.40301860),
        dec: Angle.Degrees(-66.95433663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89703"},
        {"Hipparcos Number", "HIP 50503"},
        {"Smithsonian Astrophysical Observation", "SAO 250915"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.70200940),
        dec: Angle.Degrees(-66.95391481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155555"},
        {"Henry Draper 2", "HD 155555A"},
        {"Henry Draper 3", "HD 155555B"},
        {"Hipparcos Number", "HIP 84586"},
        {"Geneva Identification System", "GEN# +1.00155555"},
        {"Smithsonian Astrophysical Observation", "SAO 253856"},
        {"Wilson Evans Batten Catalogue", "WEB 14282"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.35640625),
        dec: Angle.Degrees(-66.95070300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201542"},
        {"Hipparcos Number", "HIP 104797"},
        {"Smithsonian Astrophysical Observation", "SAO 254957"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.45822475),
        dec: Angle.Degrees(-66.94900357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188584"},
        {"Hipparcos Number", "HIP 98478"},
        {"Geneva Identification System", "GEN# +1.00188584"},
        {"Smithsonian Astrophysical Observation", "SAO 254702"},
        {"Wilson Evans Batten Catalogue", "WEB 17388"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.09627712),
        dec: Angle.Degrees(-66.94888773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108356"},
        {"Hipparcos Number", "HIP 60787"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.88105147),
        dec: Angle.Degrees(-66.94814081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185474"},
        {"Hipparcos Number", "HIP 97095"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.98900361),
        dec: Angle.Degrees(-66.94742839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128573"},
        {"Hipparcos Number", "HIP 71768"},
        {"Smithsonian Astrophysical Observation", "SAO 252840"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.20414195),
        dec: Angle.Degrees(-66.94611746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188887"},
        {"Hipparcos Number", "HIP 98624"},
        {"Geneva Identification System", "GEN# +1.00188887"},
        {"Smithsonian Astrophysical Observation", "SAO 254707"},
        {"Wilson Evans Batten Catalogue", "WEB 17441"},
    },
    visualMagnitude: 5.32,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.46835033),
        dec: Angle.Degrees(-66.94379223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219495"},
        {"Hipparcos Number", "HIP 114980"},
        {"Cincinnati Publication", "Ci 20 1411"},
        {"Geneva Identification System", "GEN# +1.00219495"},
        {"Smithsonian Astrophysical Observation", "SAO 255447"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.32011695),
        dec: Angle.Degrees(-66.93690913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 354.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -407.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172378"},
        {"Hipparcos Number", "HIP 91986"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.23308275),
        dec: Angle.Degrees(-66.93658287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169569"},
        {"Hipparcos Number", "HIP 90704"},
        {"Smithsonian Astrophysical Observation", "SAO 254262"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.59931611),
        dec: Angle.Degrees(-66.93574319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138114"},
        {"Hipparcos Number", "HIP 76210"},
        {"Smithsonian Astrophysical Observation", "SAO 253210"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.51493260),
        dec: Angle.Degrees(-66.93455004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201412"},
        {"Hipparcos Number", "HIP 104730"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.22751968),
        dec: Angle.Degrees(-66.92905359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212091"},
        {"Hipparcos Number", "HIP 110564"},
        {"Geneva Identification System", "GEN# +1.00212091"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.97392065),
        dec: Angle.Degrees(-66.92742337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20888"},
        {"Hipparcos Number", "HIP 15353"},
        {"Fundamental Katalog 5th Edition", "FK5 2235"},
        {"Geneva Identification System", "GEN# +1.00020888"},
        {"Smithsonian Astrophysical Observation", "SAO 248776"},
        {"Wilson Evans Batten Catalogue", "WEB 2953"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.49578856),
        dec: Angle.Degrees(-66.92688494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111566"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.03283121),
        dec: Angle.Degrees(-66.92442188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -211.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1184"},
        {"Hipparcos Number", "HIP 1258"},
        {"Geneva Identification System", "GEN# +1.00001184"},
        {"Smithsonian Astrophysical Observation", "SAO 248143"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.94625462),
        dec: Angle.Degrees(-66.92406885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219509"},
        {"Hipparcos Number", "HIP 114986"},
        {"Cincinnati Publication", "Ci 20 1412"},
        {"Geneva Identification System", "GEN# +1.00219509"},
        {"Smithsonian Astrophysical Observation", "SAO 255448"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.33441322),
        dec: Angle.Degrees(-66.91829285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 364.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -418.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202746"},
        {"Hipparcos Number", "HIP 105441"},
        {"Geneva Identification System", "GEN# +1.00202746"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.35146501),
        dec: Angle.Degrees(-66.91568905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84416"},
        {"Hipparcos Number", "HIP 47591"},
        {"Smithsonian Astrophysical Observation", "SAO 250672"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.55411422),
        dec: Angle.Degrees(-66.91481962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21486"},
        {"Hipparcos Number", "HIP 15820"},
        {"Smithsonian Astrophysical Observation", "SAO 248794"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.95506692),
        dec: Angle.Degrees(-66.91417624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29706"},
        {"Hipparcos Number", "HIP 21412"},
        {"Smithsonian Astrophysical Observation", "SAO 249065"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.93563891),
        dec: Angle.Degrees(-66.90925575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220864"},
        {"Hipparcos Number", "HIP 115842"},
        {"Smithsonian Astrophysical Observation", "SAO 255495"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.02618770),
        dec: Angle.Degrees(-66.90887837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63088"},
        {"Hipparcos Number", "HIP 37541"},
        {"Smithsonian Astrophysical Observation", "SAO 249934"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.57708627),
        dec: Angle.Degrees(-66.90375690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124398"},
        {"Hipparcos Number", "HIP 69716"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.05307467),
        dec: Angle.Degrees(-66.90231845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5243"},
        {"Hipparcos Number", "HIP 4136"},
        {"Smithsonian Astrophysical Observation", "SAO 248274"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.23055514),
        dec: Angle.Degrees(-66.90208429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207868"},
        {"Hipparcos Number", "HIP 108169"},
        {"Smithsonian Astrophysical Observation", "SAO 255099"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.72997447),
        dec: Angle.Degrees(-66.90187341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90264"},
        {"Hipparcos Number", "HIP 50847"},
        {"Fundamental Katalog 5th Edition", "FK5 2834"},
        {"Geneva Identification System", "GEN# +1.00090264"},
        {"Renson", "Renson 25960"},
        {"Smithsonian Astrophysical Observation", "SAO 250940"},
        {"Wilson Evans Batten Catalogue", "WEB 9305"},
    },
    visualMagnitude: 4.97,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.74241361),
        dec: Angle.Degrees(-66.90152522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39844"},
        {"Hipparcos Number", "HIP 27534"},
        {"Geneva Identification System", "GEN# +1.00039844"},
        {"Smithsonian Astrophysical Observation", "SAO 249368"},
        {"Wilson Evans Batten Catalogue", "WEB 5408"},
    },
    visualMagnitude: 5.10,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.47313958),
        dec: Angle.Degrees(-66.90123090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120891"},
        {"Hipparcos Number", "HIP 67916"},
        {"Smithsonian Astrophysical Observation", "SAO 252509"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.65632048),
        dec: Angle.Degrees(-66.90110904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30325"},
        {"Hipparcos Number", "HIP 21834"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.40250798),
        dec: Angle.Degrees(-66.90029632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101087"},
        {"Hipparcos Number", "HIP 56680"},
        {"Geneva Identification System", "GEN# +1.00101087"},
        {"Smithsonian Astrophysical Observation", "SAO 251490"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.33102949),
        dec: Angle.Degrees(-66.89808126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67923"},
        {"Smithsonian Astrophysical Observation", "SAO 252510"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.66896861),
        dec: Angle.Degrees(-66.89668855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 324"},
        {"Hipparcos Number", "HIP 627"},
        {"Smithsonian Astrophysical Observation", "SAO 248122"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.91294578),
        dec: Angle.Degrees(-66.89539355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104348"},
        {"Hipparcos Number", "HIP 58595"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.23720493),
        dec: Angle.Degrees(-66.89358633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134692"},
        {"Hipparcos Number", "HIP 74635"},
        {"Smithsonian Astrophysical Observation", "SAO 253068"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.74959771),
        dec: Angle.Degrees(-66.89346928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54265"},
        {"Hipparcos Number", "HIP 33993"},
        {"Smithsonian Astrophysical Observation", "SAO 249720"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.79848805),
        dec: Angle.Degrees(-66.88932407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170825"},
        {"Hipparcos Number", "HIP 91230"},
        {"Smithsonian Astrophysical Observation", "SAO 254302"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.14855934),
        dec: Angle.Degrees(-66.88856164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219272"},
        {"Hipparcos Number", "HIP 114830"},
        {"Geneva Identification System", "GEN# +1.00219272"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.90659889),
        dec: Angle.Degrees(-66.88756487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146827"},
        {"Hipparcos Number", "HIP 80244"},
        {"Smithsonian Astrophysical Observation", "SAO 253522"},
    },
    visualMagnitude: 6.75,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.72844546),
        dec: Angle.Degrees(-66.88731485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211538"},
        {"Hipparcos Number", "HIP 110260"},
        {"Geneva Identification System", "GEN# +1.00211538"},
        {"Smithsonian Astrophysical Observation", "SAO 255198"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.01069096),
        dec: Angle.Degrees(-66.88593492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168380"},
        {"Hipparcos Number", "HIP 90216"},
        {"Smithsonian Astrophysical Observation", "SAO 254229"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.11898948),
        dec: Angle.Degrees(-66.88377074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100215"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.88833500),
        dec: Angle.Degrees(-66.88279679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37547"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.59173340),
        dec: Angle.Degrees(-66.88176852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7030"},
        {"Hipparcos Number", "HIP 5398"},
        {"Smithsonian Astrophysical Observation", "SAO 248329"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.27233789),
        dec: Angle.Degrees(-66.88033843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217404"},
        {"Hipparcos Number", "HIP 113706"},
        {"Smithsonian Astrophysical Observation", "SAO 255377"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.43663993),
        dec: Angle.Degrees(-66.87796351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133918"},
        {"Hipparcos Number", "HIP 74275"},
        {"Smithsonian Astrophysical Observation", "SAO 253040"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.69620947),
        dec: Angle.Degrees(-66.87476014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131442"},
        {"Hipparcos Number", "HIP 73167"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.30093978),
        dec: Angle.Degrees(-66.87273103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46975"},
        {"Hipparcos Number", "HIP 31057"},
        {"Smithsonian Astrophysical Observation", "SAO 249575"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.75462084),
        dec: Angle.Degrees(-66.87072474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157772"},
        {"Hipparcos Number", "HIP 85668"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.60376782),
        dec: Angle.Degrees(-66.86994767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49779"},
        {"Hipparcos Number", "HIP 32326"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.22270566),
        dec: Angle.Degrees(-66.86566250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72882"},
        {"Hipparcos Number", "HIP 41773"},
        {"Geneva Identification System", "GEN# +1.00072882"},
        {"Smithsonian Astrophysical Observation", "SAO 250255"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.76996036),
        dec: Angle.Degrees(-66.86516894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158752"},
        {"Hipparcos Number", "HIP 86128"},
        {"Smithsonian Astrophysical Observation", "SAO 253969"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.02667141),
        dec: Angle.Degrees(-66.86483154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85286"},
        {"Hipparcos Number", "HIP 48066"},
        {"Fundamental Katalog 5th Edition", "FK5 4868"},
        {"Smithsonian Astrophysical Observation", "SAO 250703"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.97164739),
        dec: Angle.Degrees(-66.86281834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108659"},
        {"Hipparcos Number", "HIP 60944"},
        {"Geneva Identification System", "GEN# +1.00108659"},
        {"Smithsonian Astrophysical Observation", "SAO 251932"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.37964533),
        dec: Angle.Degrees(-66.86048870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83948"},
        {"Hipparcos Number", "HIP 47335"},
        {"Geneva Identification System", "GEN# +1.00083948"},
        {"Smithsonian Astrophysical Observation", "SAO 250651"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.68865365),
        dec: Angle.Degrees(-66.85918627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18798"},
        {"Hipparcos Number", "HIP 13811"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.45127758),
        dec: Angle.Degrees(-66.85889806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218558"},
        {"Hipparcos Number", "HIP 114408"},
        {"Geneva Identification System", "GEN# +1.00218558"},
        {"Smithsonian Astrophysical Observation", "SAO 255420"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.54993996),
        dec: Angle.Degrees(-66.85772967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113402"},
        {"Hipparcos Number", "HIP 63812"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.18563129),
        dec: Angle.Degrees(-66.85359736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222991"},
        {"Hipparcos Number", "HIP 117216"},
        {"Fundamental Katalog 5th Edition", "FK5 6107"},
        {"Geneva Identification System", "GEN# +1.00222991"},
        {"Smithsonian Astrophysical Observation", "SAO 255563"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.50217131),
        dec: Angle.Degrees(-66.85301321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116230"},
        {"Hipparcos Number", "HIP 65384"},
        {"Smithsonian Astrophysical Observation", "SAO 252292"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.99681940),
        dec: Angle.Degrees(-66.85059284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97674"},
        {"Hipparcos Number", "HIP 54813"},
        {"Renson", "Renson 28160"},
        {"Smithsonian Astrophysical Observation", "SAO 251324"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.32080156),
        dec: Angle.Degrees(-66.84980678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36198"},
    },
    visualMagnitude: 10.90,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.82031371),
        dec: Angle.Degrees(-66.84878942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 188.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142894"},
        {"Hipparcos Number", "HIP 78491"},
        {"Smithsonian Astrophysical Observation", "SAO 253376"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.35554251),
        dec: Angle.Degrees(-66.84855342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112766"},
        {"Hipparcos Number", "HIP 63465"},
        {"Geneva Identification System", "GEN# +1.00112766"},
        {"Smithsonian Astrophysical Observation", "SAO 252120"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.07145309),
        dec: Angle.Degrees(-66.84775346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139436"},
        {"Hipparcos Number", "HIP 76919"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.58994489),
        dec: Angle.Degrees(-66.84676500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188710"},
        {"Hipparcos Number", "HIP 98527"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.24639709),
        dec: Angle.Degrees(-66.84525634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10711"},
        {"Hipparcos Number", "HIP 7973"},
        {"Geneva Identification System", "GEN# +1.00010711"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.60735428),
        dec: Angle.Degrees(-66.84266588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195606"},
        {"Hipparcos Number", "HIP 101667"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.11355782),
        dec: Angle.Degrees(-66.83953525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190938"},
        {"Hipparcos Number", "HIP 99509"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.93124883),
        dec: Angle.Degrees(-66.83036077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176840"},
        {"Hipparcos Number", "HIP 93886"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.78457308),
        dec: Angle.Degrees(-66.82641354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51466"},
        {"Hipparcos Number", "HIP 32995"},
        {"Smithsonian Astrophysical Observation", "SAO 249668"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.10934764),
        dec: Angle.Degrees(-66.82629387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18131"},
        {"Smithsonian Astrophysical Observation", "SAO 248900"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.15383397),
        dec: Angle.Degrees(-66.82405633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120197"},
        {"Hipparcos Number", "HIP 67535"},
        {"Geneva Identification System", "GEN# +1.00120197"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.57553445),
        dec: Angle.Degrees(-66.82302690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110926"},
        {"Hipparcos Number", "HIP 62342"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.62098413),
        dec: Angle.Degrees(-66.81733619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128507"},
        {"Hipparcos Number", "HIP 71731"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.10238232),
        dec: Angle.Degrees(-66.81715322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74638"},
        {"Hipparcos Number", "HIP 42613"},
        {"Smithsonian Astrophysical Observation", "SAO 250304"},
    },
    visualMagnitude: 6.71,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.26964429),
        dec: Angle.Degrees(-66.81633235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166226"},
        {"Hipparcos Number", "HIP 89416"},
        {"Smithsonian Astrophysical Observation", "SAO 254183"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.70933718),
        dec: Angle.Degrees(-66.81510318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94290"},
        {"Hipparcos Number", "HIP 53057"},
        {"Celescope Catalog", "CEL 3739"},
        {"Geneva Identification System", "GEN# +1.00094290"},
        {"Smithsonian Astrophysical Observation", "SAO 251153"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.83764288),
        dec: Angle.Degrees(-66.81488770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102584"},
        {"Hipparcos Number", "HIP 57581"},
        {"Geneva Identification System", "GEN# +1.00102584"},
        {"Smithsonian Astrophysical Observation", "SAO 251597"},
        {"Wilson Evans Batten Catalogue", "WEB 10339"},
    },
    visualMagnitude: 4.75,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.06037263),
        dec: Angle.Degrees(-66.81487085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132654"},
        {"Hipparcos Number", "HIP 73702"},
        {"Smithsonian Astrophysical Observation", "SAO 253001"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.95378813),
        dec: Angle.Degrees(-66.81446753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119299"},
        {"Hipparcos Number", "HIP 67063"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.14939005),
        dec: Angle.Degrees(-66.81398729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24211"},
        {"Hipparcos Number", "HIP 17647"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.70921875),
        dec: Angle.Degrees(-66.81350252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186584"},
        {"Hipparcos Number", "HIP 97569"},
        {"Geneva Identification System", "GEN# +1.00186584"},
        {"Smithsonian Astrophysical Observation", "SAO 254658"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.47257971),
        dec: Angle.Degrees(-66.81309300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150613"},
        {"Hipparcos Number", "HIP 82150"},
        {"Geneva Identification System", "GEN# +1.00150613"},
        {"Smithsonian Astrophysical Observation", "SAO 253690"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.74452205),
        dec: Angle.Degrees(-66.81191476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84866"},
        {"Hipparcos Number", "HIP 47857"},
        {"Smithsonian Astrophysical Observation", "SAO 250685"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.31359640),
        dec: Angle.Degrees(-66.80878127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160213"},
        {"Hipparcos Number", "HIP 86766"},
        {"Geneva Identification System", "GEN# +1.00160213"},
        {"Smithsonian Astrophysical Observation", "SAO 254007"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.93897036),
        dec: Angle.Degrees(-66.80772543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57418"},
        {"Hipparcos Number", "HIP 35179"},
        {"Smithsonian Astrophysical Observation", "SAO 249804"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.05802245),
        dec: Angle.Degrees(-66.80584633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206856"},
        {"Hipparcos Number", "HIP 107606"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.92474044),
        dec: Angle.Degrees(-66.80546743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91344"},
        {"Hipparcos Number", "HIP 51465"},
        {"Geneva Identification System", "GEN# +1.00091344"},
        {"Renson", "Renson 26290"},
        {"Smithsonian Astrophysical Observation", "SAO 250993"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.67399728),
        dec: Angle.Degrees(-66.80513944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125016"},
        {"Hipparcos Number", "HIP 70019"},
        {"Smithsonian Astrophysical Observation", "SAO 252701"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.90329061),
        dec: Angle.Degrees(-66.80156183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76700"},
        {"Hipparcos Number", "HIP 43686"},
        {"Geneva Identification System", "GEN# +1.00076700"},
        {"Smithsonian Astrophysical Observation", "SAO 250370"},
        {"Wilson Evans Batten Catalogue", "WEB 8415"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.48306018),
        dec: Angle.Degrees(-66.80128646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -283.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 121.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29564"},
        {"Smithsonian Astrophysical Observation", "SAO 249487"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.42776976),
        dec: Angle.Degrees(-66.79986277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3279"},
        {"Hipparcos Number", "HIP 2748"},
        {"Smithsonian Astrophysical Observation", "SAO 248217"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.76485562),
        dec: Angle.Degrees(-66.79869619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202344"},
        {"Hipparcos Number", "HIP 105196"},
        {"Smithsonian Astrophysical Observation", "SAO 254968"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.64049453),
        dec: Angle.Degrees(-66.79833557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8179"},
        {"Hipparcos Number", "HIP 6196"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.86950770),
        dec: Angle.Degrees(-66.79803285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14101"},
        {"Hipparcos Number", "HIP 10401"},
        {"Smithsonian Astrophysical Observation", "SAO 248514"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.49910942),
        dec: Angle.Degrees(-66.79397813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85853"},
        {"Hipparcos Number", "HIP 48389"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.96883817),
        dec: Angle.Degrees(-66.79385496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203835"},
        {"Hipparcos Number", "HIP 105991"},
        {"Smithsonian Astrophysical Observation", "SAO 255002"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.99940771),
        dec: Angle.Degrees(-66.79367419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76143"},
        {"Hipparcos Number", "HIP 43414"},
        {"Geneva Identification System", "GEN# +1.00076143"},
        {"Smithsonian Astrophysical Observation", "SAO 250347"},
        {"Wilson Evans Batten Catalogue", "WEB 8366"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.64450311),
        dec: Angle.Degrees(-66.79322494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 271791"},
        {"Hipparcos Number", "HIP 28618"},
    },
    visualMagnitude: 12.31,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.61616421),
        dec: Angle.Degrees(-66.79131687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122131"},
        {"Hipparcos Number", "HIP 68584"},
        {"Geneva Identification System", "GEN# +1.00122131"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.59996259),
        dec: Angle.Degrees(-66.78923943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71760"},
        {"Hipparcos Number", "HIP 41237"},
        {"Geneva Identification System", "GEN# +1.00071760"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.22004683),
        dec: Angle.Degrees(-66.78799713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42546"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.09101769),
        dec: Angle.Degrees(-66.78567377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115211"},
        {"Hipparcos Number", "HIP 64820"},
        {"Geneva Identification System", "GEN# +1.00115211"},
        {"Smithsonian Astrophysical Observation", "SAO 252240"},
        {"Wilson Evans Batten Catalogue", "WEB 11455"},
    },
    visualMagnitude: 4.86,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.30431246),
        dec: Angle.Degrees(-66.78342263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210562"},
        {"Hipparcos Number", "HIP 109726"},
        {"Smithsonian Astrophysical Observation", "SAO 255174"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.40639659),
        dec: Angle.Degrees(-66.78217355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128997"},
        {"Hipparcos Number", "HIP 71990"},
        {"Smithsonian Astrophysical Observation", "SAO 252858"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.84603243),
        dec: Angle.Degrees(-66.77859094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163329"},
        {"Hipparcos Number", "HIP 88203"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.18306510),
        dec: Angle.Degrees(-66.77504486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66343"},
        {"Hipparcos Number", "HIP 38976"},
        {"Smithsonian Astrophysical Observation", "SAO 250057"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.63493939),
        dec: Angle.Degrees(-66.77455735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66043"},
        {"Hipparcos Number", "HIP 38864"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.30401301),
        dec: Angle.Degrees(-66.76846851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15775"},
        {"Hipparcos Number", "HIP 11562"},
        {"Smithsonian Astrophysical Observation", "SAO 248576"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.24090350),
        dec: Angle.Degrees(-66.76826975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3095"},
        {"Hipparcos Number", "HIP 2636"},
        {"Smithsonian Astrophysical Observation", "SAO 248211"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.36419123),
        dec: Angle.Degrees(-66.76464952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196519"},
        {"Hipparcos Number", "HIP 102157"},
        {"Geneva Identification System", "GEN# +1.00196519"},
        {"Smithsonian Astrophysical Observation", "SAO 254854"},
        {"Wilson Evans Batten Catalogue", "WEB 18480"},
    },
    visualMagnitude: 5.14,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.48776281),
        dec: Angle.Degrees(-66.76062542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 441"},
        {"Hipparcos Number", "HIP 707"},
        {"Smithsonian Astrophysical Observation", "SAO 248124"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.19477287),
        dec: Angle.Degrees(-66.75946527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119423"},
        {"Hipparcos Number", "HIP 67108"},
        {"Smithsonian Astrophysical Observation", "SAO 252431"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.32672163),
        dec: Angle.Degrees(-66.75464987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46396"},
        {"Hipparcos Number", "HIP 30775"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.99525676),
        dec: Angle.Degrees(-66.75452468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205534"},
        {"Hipparcos Number", "HIP 106899"},
        {"Smithsonian Astrophysical Observation", "SAO 255045"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.76151723),
        dec: Angle.Degrees(-66.75425691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268675"},
        {"Hipparcos Number", "HIP 22849"},
        {"Geneva Identification System", "GEN# +1.00268675"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.73896251),
        dec: Angle.Degrees(-66.75244902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192887"},
        {"Hipparcos Number", "HIP 100379"},
        {"Geneva Identification System", "GEN# +1.00192887"},
        {"Smithsonian Astrophysical Observation", "SAO 254775"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.36858807),
        dec: Angle.Degrees(-66.74969742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116749"},
        {"Hipparcos Number", "HIP 65635"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.85082564),
        dec: Angle.Degrees(-66.74714299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161882"},
        {"Hipparcos Number", "HIP 87547"},
        {"Smithsonian Astrophysical Observation", "SAO 254061"},
    },
    visualMagnitude: 9.09,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.28329624),
        dec: Angle.Degrees(-66.74330134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30543"},
        {"Hipparcos Number", "HIP 21984"},
        {"Smithsonian Astrophysical Observation", "SAO 249092"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.88799149),
        dec: Angle.Degrees(-66.74279504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85629"},
        {"Hipparcos Number", "HIP 48253"},
        {"Smithsonian Astrophysical Observation", "SAO 250717"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.55344314),
        dec: Angle.Degrees(-66.74128300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28398"},
        {"Hipparcos Number", "HIP 20529"},
        {"Fundamental Katalog 5th Edition", "FK5 2328"},
        {"Renson", "Renson 7290"},
        {"Smithsonian Astrophysical Observation", "SAO 249015"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.98258619),
        dec: Angle.Degrees(-66.73726628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268946"},
        {"Hipparcos Number", "HIP 23665"},
        {"Geneva Identification System", "GEN# +1.00268946"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.30090812),
        dec: Angle.Degrees(-66.73682541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84319"},
        {"Hipparcos Number", "HIP 47536"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.36761637),
        dec: Angle.Degrees(-66.73535674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122314"},
        {"Hipparcos Number", "HIP 68692"},
        {"Geneva Identification System", "GEN# +1.00122314"},
        {"Renson", "Renson 35070"},
        {"Smithsonian Astrophysical Observation", "SAO 252577"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.90958087),
        dec: Angle.Degrees(-66.73533407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29057"},
        {"Hipparcos Number", "HIP 20959"},
        {"Smithsonian Astrophysical Observation", "SAO 249043"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.41861185),
        dec: Angle.Degrees(-66.73443443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117652"},
        {"Hipparcos Number", "HIP 66161"},
        {"Smithsonian Astrophysical Observation", "SAO 252363"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.43244779),
        dec: Angle.Degrees(-66.73297654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195290"},
        {"Hipparcos Number", "HIP 101517"},
        {"Smithsonian Astrophysical Observation", "SAO 254816"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.59432076),
        dec: Angle.Degrees(-66.73082134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22488"},
        {"Hipparcos Number", "HIP 16527"},
        {"Renson", "Renson 5720"},
        {"Smithsonian Astrophysical Observation", "SAO 248835"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.19262091),
        dec: Angle.Degrees(-66.72950114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216238"},
        {"Hipparcos Number", "HIP 112976"},
        {"Smithsonian Astrophysical Observation", "SAO 255342"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.20113168),
        dec: Angle.Degrees(-66.72917270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102249"},
        {"Hipparcos Number", "HIP 57363"},
        {"Celescope Catalog", "CEL 3971"},
        {"Fundamental Katalog 5th Edition", "FK5 442"},
        {"Geneva Identification System", "GEN# +1.00102249"},
        {"Smithsonian Astrophysical Observation", "SAO 251575"},
        {"Wilson Evans Batten Catalogue", "WEB 10311"},
    },
    visualMagnitude: 3.63,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.40236386),
        dec: Angle.Degrees(-66.72884344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180474"},
        {"Hipparcos Number", "HIP 95160"},
        {"Smithsonian Astrophysical Observation", "SAO 254540"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.40515024),
        dec: Angle.Degrees(-66.72388801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37255"},
        {"Smithsonian Astrophysical Observation", "SAO 249914"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.76424253),
        dec: Angle.Degrees(-66.72201407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125346"},
        {"Hipparcos Number", "HIP 70196"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.43226175),
        dec: Angle.Degrees(-66.72109704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79574"},
        {"Hipparcos Number", "HIP 45113"},
        {"Geneva Identification System", "GEN# +1.00079574"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.87065510),
        dec: Angle.Degrees(-66.71936646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82858"},
        {"Hipparcos Number", "HIP 46737"},
        {"Geneva Identification System", "GEN# +1.00082858"},
        {"Smithsonian Astrophysical Observation", "SAO 250611"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.88770483),
        dec: Angle.Degrees(-66.71904550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87848"},
        {"Hipparcos Number", "HIP 49417"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.31113990),
        dec: Angle.Degrees(-66.71786230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172065"},
        {"Hipparcos Number", "HIP 91802"},
        {"Smithsonian Astrophysical Observation", "SAO 254347"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.77269294),
        dec: Angle.Degrees(-66.71554119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153717"},
        {"Hipparcos Number", "HIP 83670"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.51663628),
        dec: Angle.Degrees(-66.71461102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17326"},
        {"Hipparcos Number", "HIP 12717"},
        {"Geneva Identification System", "GEN# +1.00017326"},
        {"Smithsonian Astrophysical Observation", "SAO 248632"},
        {"Wilson Evans Batten Catalogue", "WEB 2585"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.86027168),
        dec: Angle.Degrees(-66.71405573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121707"},
        {"Hipparcos Number", "HIP 68350"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.86590436),
        dec: Angle.Degrees(-66.71128978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63902"},
        {"Hipparcos Number", "HIP 37944"},
        {"Geneva Identification System", "GEN# +1.00063902"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.65697197),
        dec: Angle.Degrees(-66.70819656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127659"},
        {"Hipparcos Number", "HIP 71364"},
        {"Geneva Identification System", "GEN# +1.00127659"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.91681813),
        dec: Angle.Degrees(-66.70541332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155815"},
        {"Hipparcos Number", "HIP 84701"},
    },
    visualMagnitude: 9.55,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.71669203),
        dec: Angle.Degrees(-66.70523598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82406"},
        {"Hipparcos Number", "HIP 46460"},
        {"Fundamental Katalog 5th Edition", "FK5 2754"},
        {"Geneva Identification System", "GEN# +1.00082406"},
        {"Smithsonian Astrophysical Observation", "SAO 250591"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.12749104),
        dec: Angle.Degrees(-66.70198874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89398"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.66127321),
        dec: Angle.Degrees(-66.69905370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23891"},
        {"Hipparcos Number", "HIP 17446"},
        {"Smithsonian Astrophysical Observation", "SAO 248879"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.07665460),
        dec: Angle.Degrees(-66.69681069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109856"},
        {"Hipparcos Number", "HIP 61697"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.70429589),
        dec: Angle.Degrees(-66.69664050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91095"},
        {"Hipparcos Number", "HIP 51311"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.20810409),
        dec: Angle.Degrees(-66.69659398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64763"},
        {"Hipparcos Number", "HIP 38302"},
        {"Smithsonian Astrophysical Observation", "SAO 249983"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.71021784),
        dec: Angle.Degrees(-66.69574963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105979"},
        {"Hipparcos Number", "HIP 59473"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.98006522),
        dec: Angle.Degrees(-66.69554657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88846"},
        {"Hipparcos Number", "HIP 49996"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.10776656),
        dec: Angle.Degrees(-66.69146647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80670"},
        {"Hipparcos Number", "HIP 45605"},
        {"Geneva Identification System", "GEN# +1.00080670"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.43828215),
        dec: Angle.Degrees(-66.69091987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147289"},
        {"Hipparcos Number", "HIP 80483"},
        {"Smithsonian Astrophysical Observation", "SAO 253540"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.43514586),
        dec: Angle.Degrees(-66.69085766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1260"},
        {"Hipparcos Number", "HIP 1312"},
        {"Smithsonian Astrophysical Observation", "SAO 248149"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.13084535),
        dec: Angle.Degrees(-66.69013392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34286"},
        {"Hipparcos Number", "HIP 24153"},
        {"Smithsonian Astrophysical Observation", "SAO 249215"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.80526130),
        dec: Angle.Degrees(-66.68800226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36805"},
        {"Hipparcos Number", "HIP 25684"},
        {"Smithsonian Astrophysical Observation", "SAO 249293"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.27700771),
        dec: Angle.Degrees(-66.68703233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184586"},
        {"Hipparcos Number", "HIP 96734"},
        {"Fundamental Katalog 5th Edition", "FK5 3567"},
        {"Geneva Identification System", "GEN# +1.00184586"},
        {"Smithsonian Astrophysical Observation", "SAO 254622"},
        {"Wilson Evans Batten Catalogue", "WEB 16970"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.96721053),
        dec: Angle.Degrees(-66.68540741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224783"},
        {"Hipparcos Number", "HIP 55"},
        {"Smithsonian Astrophysical Observation", "SAO 255620"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.15783323),
        dec: Angle.Degrees(-66.68310336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43921"},
        {"Hipparcos Number", "HIP 29559"},
        {"Geneva Identification System", "GEN# +1.00043921"},
        {"Smithsonian Astrophysical Observation", "SAO 249486"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.42074028),
        dec: Angle.Degrees(-66.68017669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27621"},
        {"Hipparcos Number", "HIP 19956"},
        {"Smithsonian Astrophysical Observation", "SAO 248981"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.19024198),
        dec: Angle.Degrees(-66.68005635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145195"},
        {"Hipparcos Number", "HIP 79577"},
        {"Renson", "Renson 41140"},
        {"Smithsonian Astrophysical Observation", "SAO 253465"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.54776459),
        dec: Angle.Degrees(-66.67944372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83764"},
        {"Hipparcos Number", "HIP 47230"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.40121039),
        dec: Angle.Degrees(-66.67747544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31754"},
        {"Hipparcos Number", "HIP 22737"},
        {"Fundamental Katalog 5th Edition", "FK5 2372"},
        {"Geneva Identification System", "GEN# +1.00031754"},
        {"Smithsonian Astrophysical Observation", "SAO 249138"},
        {"Wilson Evans Batten Catalogue", "WEB 4400"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.37703998),
        dec: Angle.Degrees(-66.67543873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8107"},
        {"Hipparcos Number", "HIP 6124"},
        {"Geneva Identification System", "GEN# +1.00008107"},
        {"Smithsonian Astrophysical Observation", "SAO 248359"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.65722888),
        dec: Angle.Degrees(-66.67543619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10771"},
        {"Hipparcos Number", "HIP 8027"},
        {"Geneva Identification System", "GEN# +1.00010771"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.77320136),
        dec: Angle.Degrees(-66.67538756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93284"},
        {"Hipparcos Number", "HIP 52540"},
        {"Renson", "Renson 26960"},
        {"Smithsonian Astrophysical Observation", "SAO 251102"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.13886707),
        dec: Angle.Degrees(-66.67448972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83947"},
        {"Hipparcos Number", "HIP 47337"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.69420171),
        dec: Angle.Degrees(-66.66778594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77388"},
        {"Hipparcos Number", "HIP 44062"},
        {"Smithsonian Astrophysical Observation", "SAO 250404"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.60189612),
        dec: Angle.Degrees(-66.66712655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202778"},
        {"Hipparcos Number", "HIP 105445"},
        {"Renson", "Renson 56520"},
        {"Smithsonian Astrophysical Observation", "SAO 254982"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.36674390),
        dec: Angle.Degrees(-66.66679723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83244"},
    },
    visualMagnitude: 11.44,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.19457854),
        dec: Angle.Degrees(-66.66384746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83957B"},
        {"Hipparcos Number", "HIP 47338"},
    },
    visualMagnitude: 11.62,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.69701004),
        dec: Angle.Degrees(-66.66338378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179366"},
        {"Hipparcos Number", "HIP 94789"},
        {"Geneva Identification System", "GEN# +1.00179366"},
        {"Smithsonian Astrophysical Observation", "SAO 254515"},
        {"Wilson Evans Batten Catalogue", "WEB 16540"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.30091657),
        dec: Angle.Degrees(-66.66103756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131172"},
        {"Hipparcos Number", "HIP 73020"},
        {"Smithsonian Astrophysical Observation", "SAO 252956"},
    },
    visualMagnitude: 8.13,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.84500618),
        dec: Angle.Degrees(-66.66054410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92556"},
        {"Hipparcos Number", "HIP 52159"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.84096529),
        dec: Angle.Degrees(-66.66021123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107065"},
        {"Hipparcos Number", "HIP 60068"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.76729402),
        dec: Angle.Degrees(-66.65954856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168669"},
        {"Hipparcos Number", "HIP 90346"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.50947411),
        dec: Angle.Degrees(-66.65722698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167325"},
        {"Hipparcos Number", "HIP 89817"},
        {"Smithsonian Astrophysical Observation", "SAO 254206"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.94774142),
        dec: Angle.Degrees(-66.65499286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20533"},
        {"Hipparcos Number", "HIP 15068"},
        {"Geneva Identification System", "GEN# +1.00020533"},
        {"Smithsonian Astrophysical Observation", "SAO 248760"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.54829758),
        dec: Angle.Degrees(-66.65478852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175401"},
        {"Hipparcos Number", "HIP 93287"},
        {"Geneva Identification System", "GEN# +1.00175401"},
        {"Smithsonian Astrophysical Observation", "SAO 254426"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.01477683),
        dec: Angle.Degrees(-66.65351408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218244"},
        {"Hipparcos Number", "HIP 114205"},
        {"Smithsonian Astrophysical Observation", "SAO 255408"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.92633539),
        dec: Angle.Degrees(-66.65219928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190249"},
        {"Hipparcos Number", "HIP 99204"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.09581699),
        dec: Angle.Degrees(-66.65025059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223844"},
        {"Hipparcos Number", "HIP 117783"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.29117040),
        dec: Angle.Degrees(-66.64714799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125630"},
        {"Hipparcos Number", "HIP 70346"},
        {"Geneva Identification System", "GEN# +1.00125630"},
        {"Renson", "Renson 35880"},
        {"Smithsonian Astrophysical Observation", "SAO 252725"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.88369983),
        dec: Angle.Degrees(-66.64496483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61475"},
        {"Hipparcos Number", "HIP 36866"},
        {"Smithsonian Astrophysical Observation", "SAO 249888"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.68518140),
        dec: Angle.Degrees(-66.64406827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 230.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151586"},
        {"Hipparcos Number", "HIP 82591"},
        {"Geneva Identification System", "GEN# +1.00151586"},
        {"Renson", "Renson 42900"},
        {"Smithsonian Astrophysical Observation", "SAO 253722"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.26096896),
        dec: Angle.Degrees(-66.63761356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90644"},
        {"Hipparcos Number", "HIP 51059"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.48804050),
        dec: Angle.Degrees(-66.63699623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39580"},
        {"Hipparcos Number", "HIP 27413"},
        {"Smithsonian Astrophysical Observation", "SAO 249361"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.07793727),
        dec: Angle.Degrees(-66.63184747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125603"},
        {"Hipparcos Number", "HIP 70323"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.83323685),
        dec: Angle.Degrees(-66.63118751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40630"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.42512472),
        dec: Angle.Degrees(-66.62475256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27070"},
        {"Hipparcos Number", "HIP 19605"},
        {"Geneva Identification System", "GEN# +1.00027070"},
        {"Smithsonian Astrophysical Observation", "SAO 248964"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.01590647),
        dec: Angle.Degrees(-66.62357951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143203"},
        {"Hipparcos Number", "HIP 78654"},
        {"Smithsonian Astrophysical Observation", "SAO 253392"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.84582140),
        dec: Angle.Degrees(-66.62054142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165238"},
        {"Hipparcos Number", "HIP 89021"},
        {"Smithsonian Astrophysical Observation", "SAO 254155"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.52385078),
        dec: Angle.Degrees(-66.61649179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78601"},
        {"Hipparcos Number", "HIP 44623"},
        {"Smithsonian Astrophysical Observation", "SAO 250440"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.39374104),
        dec: Angle.Degrees(-66.61294444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154775"},
        {"Hipparcos Number", "HIP 84176"},
        {"Smithsonian Astrophysical Observation", "SAO 253824"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.10535427),
        dec: Angle.Degrees(-66.60958126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123467"},
        {"Hipparcos Number", "HIP 69243"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.63320569),
        dec: Angle.Degrees(-66.60280923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136061"},
        {"Hipparcos Number", "HIP 75235"},
        {"Geneva Identification System", "GEN# +1.00136061"},
        {"Smithsonian Astrophysical Observation", "SAO 253125"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.60719504),
        dec: Angle.Degrees(-66.59936134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108671"},
        {"Hipparcos Number", "HIP 60950"},
        {"Geneva Identification System", "GEN# +1.00108671"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.41148257),
        dec: Angle.Degrees(-66.59859019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95801"},
        {"Hipparcos Number", "HIP 53919"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.50004433),
        dec: Angle.Degrees(-66.59812110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88510"},
        {"Hipparcos Number", "HIP 49804"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.48894773),
        dec: Angle.Degrees(-66.59788280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129954"},
        {"Hipparcos Number", "HIP 72438"},
        {"Geneva Identification System", "GEN# +1.00129954"},
        {"Smithsonian Astrophysical Observation", "SAO 252894"},
        {"Wilson Evans Batten Catalogue", "WEB 12448"},
    },
    visualMagnitude: 5.91,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.18567167),
        dec: Angle.Degrees(-66.59353612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89465"},
        {"Hipparcos Number", "HIP 50377"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.29325523),
        dec: Angle.Degrees(-66.59158194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124471"},
        {"Hipparcos Number", "HIP 69763"},
        {"Geneva Identification System", "GEN# +1.00124471A"},
        {"Smithsonian Astrophysical Observation", "SAO 252678"},
        {"Wilson Evans Batten Catalogue", "WEB 12145"},
    },
    visualMagnitude: 5.72,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.16135836),
        dec: Angle.Degrees(-66.58788092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111333"},
        {"Hipparcos Number", "HIP 62588"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.38065512),
        dec: Angle.Degrees(-66.58778312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220759"},
        {"Hipparcos Number", "HIP 115756"},
        {"Geneva Identification System", "GEN# +1.00220759"},
        {"Smithsonian Astrophysical Observation", "SAO 255486"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.78112296),
        dec: Angle.Degrees(-66.58085439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186633"},
        {"Hipparcos Number", "HIP 97597"},
        {"Smithsonian Astrophysical Observation", "SAO 254660"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.55826175),
        dec: Angle.Degrees(-66.57987305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82187"},
        {"Hipparcos Number", "HIP 46370"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.82414574),
        dec: Angle.Degrees(-66.57374606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86257"},
    },
    visualMagnitude: 10.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)37, 32.6900),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)34, 10.700)
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
    primaryId: "HIP 70661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126226"},
        {"Hipparcos Number", "HIP 70661"},
        {"Geneva Identification System", "GEN# +1.00126226"},
        {"Smithsonian Astrophysical Observation", "SAO 252746"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.79703099),
        dec: Angle.Degrees(-66.56801115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223226"},
        {"Hipparcos Number", "HIP 117374"},
        {"Geneva Identification System", "GEN# +1.00223226"},
        {"Smithsonian Astrophysical Observation", "SAO 255571"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.98479611),
        dec: Angle.Degrees(-66.56747816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1358"},
        {"Hipparcos Number", "HIP 1394"},
        {"Smithsonian Astrophysical Observation", "SAO 248152"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.35158760),
        dec: Angle.Degrees(-66.56708402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86773"},
        {"Hipparcos Number", "HIP 48869"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.50408150),
        dec: Angle.Degrees(-66.56247987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5756"},
        {"Hipparcos Number", "HIP 4512"},
        {"Smithsonian Astrophysical Observation", "SAO 248291"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.46706139),
        dec: Angle.Degrees(-66.56084352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37935"},
        {"Hipparcos Number", "HIP 26368"},
        {"Geneva Identification System", "GEN# +1.00037935"},
        {"Smithsonian Astrophysical Observation", "SAO 249322"},
    },
    visualMagnitude: 6.28,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.22911509),
        dec: Angle.Degrees(-66.56031364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143104"},
        {"Hipparcos Number", "HIP 78582"},
        {"Geneva Identification System", "GEN# +1.00143104J"},
        {"Wilson Evans Batten Catalogue", "WEB 13280"},
    },
    visualMagnitude: 9.32,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.68563607),
        dec: Angle.Degrees(-66.55863030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80602"},
        {"Hipparcos Number", "HIP 45587"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.36798907),
        dec: Angle.Degrees(-66.55763664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95542"},
        {"Hipparcos Number", "HIP 53787"},
        {"Geneva Identification System", "GEN# +1.00095542"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.07377070),
        dec: Angle.Degrees(-66.55708255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10242"},
        {"Hipparcos Number", "HIP 7615"},
        {"Fundamental Katalog 5th Edition", "FK5 4148"},
        {"Smithsonian Astrophysical Observation", "SAO 248412"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.52086905),
        dec: Angle.Degrees(-66.55643819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182860"},
        {"Hipparcos Number", "HIP 96026"},
        {"Smithsonian Astrophysical Observation", "SAO 254591"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.86249708),
        dec: Angle.Degrees(-66.55346284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139100"},
        {"Hipparcos Number", "HIP 76755"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.09098640),
        dec: Angle.Degrees(-66.54915825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106344"},
        {"Hipparcos Number", "HIP 59679"},
        {"Celescope Catalog", "CEL 4072"},
        {"Geneva Identification System", "GEN# +1.00106344"},
        {"Smithsonian Astrophysical Observation", "SAO 251802"},
        {"Wilson Evans Batten Catalogue", "WEB 10604"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.57108436),
        dec: Angle.Degrees(-66.54869467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138499"},
        {"Hipparcos Number", "HIP 76422"},
        {"Smithsonian Astrophysical Observation", "SAO 253223"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.11722569),
        dec: Angle.Degrees(-66.54544434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114083"},
        {"Hipparcos Number", "HIP 64209"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.39985426),
        dec: Angle.Degrees(-66.54310666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58916"},
        {"Hipparcos Number", "HIP 35781"},
        {"Smithsonian Astrophysical Observation", "SAO 249840"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.70544303),
        dec: Angle.Degrees(-66.53888833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163880"},
        {"Hipparcos Number", "HIP 88454"},
        {"Smithsonian Astrophysical Observation", "SAO 254122"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.89067680),
        dec: Angle.Degrees(-66.53831090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195962"},
        {"Hipparcos Number", "HIP 101857"},
        {"Geneva Identification System", "GEN# +1.00195962"},
        {"Smithsonian Astrophysical Observation", "SAO 254838"},
        {"Wilson Evans Batten Catalogue", "WEB 18403"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.60572480),
        dec: Angle.Degrees(-66.53784050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -381.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79279"},
        {"Hipparcos Number", "HIP 44973"},
        {"Geneva Identification System", "GEN# +1.00079279"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.41968833),
        dec: Angle.Degrees(-66.53689382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115705"},
        {"Hipparcos Number", "HIP 65100"},
        {"Geneva Identification System", "GEN# +1.00115705"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.12586392),
        dec: Angle.Degrees(-66.53348360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198162"},
        {"Hipparcos Number", "HIP 103010"},
        {"Smithsonian Astrophysical Observation", "SAO 254886"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.05645443),
        dec: Angle.Degrees(-66.53076167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11118"},
        {"Hipparcos Number", "HIP 8299"},
        {"Smithsonian Astrophysical Observation", "SAO 248435"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.75425709),
        dec: Angle.Degrees(-66.52918921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198912"},
        {"Hipparcos Number", "HIP 103427"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.31670329),
        dec: Angle.Degrees(-66.52856231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73370"},
        {"Hipparcos Number", "HIP 42031"},
        {"Geneva Identification System", "GEN# +1.00073370"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.51388520),
        dec: Angle.Degrees(-66.52588948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106362"},
        {"Hipparcos Number", "HIP 59689"},
        {"Geneva Identification System", "GEN# +1.00106362"},
        {"Smithsonian Astrophysical Observation", "SAO 251804"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.60912538),
        dec: Angle.Degrees(-66.52458659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23012"},
        {"Hipparcos Number", "HIP 16903"},
        {"Smithsonian Astrophysical Observation", "SAO 248856"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.37240781),
        dec: Angle.Degrees(-66.52458452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159046"},
        {"Hipparcos Number", "HIP 86242"},
        {"Smithsonian Astrophysical Observation", "SAO 253979"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.35549060),
        dec: Angle.Degrees(-66.52177176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139720"},
        {"Hipparcos Number", "HIP 77039"},
        {"Geneva Identification System", "GEN# +1.00139720"},
        {"Smithsonian Astrophysical Observation", "SAO 253265"},
        {"Wilson Evans Batten Catalogue", "WEB 13063"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.96149191),
        dec: Angle.Degrees(-66.52049439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30818"},
        {"Hipparcos Number", "HIP 22145"},
        {"Geneva Identification System", "GEN# +1.00030818"},
        {"Smithsonian Astrophysical Observation", "SAO 249103"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.48175894),
        dec: Angle.Degrees(-66.51898167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 216.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218485"},
        {"Hipparcos Number", "HIP 114346"},
        {"Geneva Identification System", "GEN# +1.00218485"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.37535446),
        dec: Angle.Degrees(-66.51587384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 403"},
        {"Hipparcos Number", "HIP 690"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.12406316),
        dec: Angle.Degrees(-66.51414469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3957"},
        {"Hipparcos Number", "HIP 3241"},
        {"Smithsonian Astrophysical Observation", "SAO 248234"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.30902963),
        dec: Angle.Degrees(-66.51396019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120680"},
        {"Hipparcos Number", "HIP 67796"},
        {"Geneva Identification System", "GEN# +1.00120680"},
        {"Smithsonian Astrophysical Observation", "SAO 252498"},
        {"Wilson Evans Batten Catalogue", "WEB 11918"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.32558078),
        dec: Angle.Degrees(-66.51242413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98027"},
        {"Hipparcos Number", "HIP 54971"},
        {"Smithsonian Astrophysical Observation", "SAO 251334"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.84236143),
        dec: Angle.Degrees(-66.51194568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152893"},
        {"Hipparcos Number", "HIP 83256"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.25242043),
        dec: Angle.Degrees(-66.51126104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110020"},
        {"Hipparcos Number", "HIP 61796"},
        {"Geneva Identification System", "GEN# +1.00110020"},
        {"Smithsonian Astrophysical Observation", "SAO 251987"},
        {"Wilson Evans Batten Catalogue", "WEB 10990"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.98292570),
        dec: Angle.Degrees(-66.51112210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1581"},
        {"Hipparcos Number", "HIP 1599"},
        {"Cincinnati Publication", "Ci 20 22"},
        {"Fundamental Katalog 5th Edition", "FK5 10"},
        {"Geneva Identification System", "GEN# +1.00001581"},
        {"Smithsonian Astrophysical Observation", "SAO 248163"},
        {"Wilson Evans Batten Catalogue", "WEB 286"},
    },
    visualMagnitude: 4.23,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.00797581),
        dec: Angle.Degrees(-64.87762320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1707.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1165.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80601"},
        {"Hipparcos Number", "HIP 45576"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.33392525),
        dec: Angle.Degrees(-66.51073973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24136"},
        {"Hipparcos Number", "HIP 17604"},
        {"Geneva Identification System", "GEN# +1.00024136"},
        {"Smithsonian Astrophysical Observation", "SAO 248886"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.56515569),
        dec: Angle.Degrees(-66.50403295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49424"},
        {"Hipparcos Number", "HIP 32200"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.82140911),
        dec: Angle.Degrees(-66.50103215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126167"},
        {"Hipparcos Number", "HIP 70620"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.68842767),
        dec: Angle.Degrees(-66.50094587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126184"},
        {"Hipparcos Number", "HIP 70632"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.72143502),
        dec: Angle.Degrees(-66.50088135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20160"},
        {"Hipparcos Number", "HIP 14752"},
        {"Smithsonian Astrophysical Observation", "SAO 248751"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.62308418),
        dec: Angle.Degrees(-66.49944888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196968"},
        {"Hipparcos Number", "HIP 102372"},
        {"Smithsonian Astrophysical Observation", "SAO 254859"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.14478648),
        dec: Angle.Degrees(-66.49809771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209758"},
        {"Hipparcos Number", "HIP 109260"},
        {"Smithsonian Astrophysical Observation", "SAO 255149"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.03631033),
        dec: Angle.Degrees(-66.49722989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70840"},
        {"Hipparcos Number", "HIP 40837"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.00663808),
        dec: Angle.Degrees(-66.49717087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9478"},
        {"Hipparcos Number", "HIP 7062"},
        {"Smithsonian Astrophysical Observation", "SAO 248393"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.75850349),
        dec: Angle.Degrees(-66.49664213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150376"},
        {"Hipparcos Number", "HIP 82025"},
        {"Geneva Identification System", "GEN# +1.00150376"},
        {"Smithsonian Astrophysical Observation", "SAO 253683"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.33214904),
        dec: Angle.Degrees(-66.49654708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135592"},
        {"Hipparcos Number", "HIP 75018"},
        {"Geneva Identification System", "GEN# +1.00135592"},
        {"Smithsonian Astrophysical Observation", "SAO 253107"},
        {"Wilson Evans Batten Catalogue", "WEB 12798"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.94050332),
        dec: Angle.Degrees(-66.49601893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15379"},
        {"Hipparcos Number", "HIP 11293"},
        {"Geneva Identification System", "GEN# +1.00015379"},
        {"Smithsonian Astrophysical Observation", "SAO 248556"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.36035123),
        dec: Angle.Degrees(-66.49402863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115865"},
        {"Hipparcos Number", "HIP 65193"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.40417215),
        dec: Angle.Degrees(-66.49242832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151824"},
        {"Hipparcos Number", "HIP 82727"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.63891459),
        dec: Angle.Degrees(-66.49221490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119145"},
        {"Hipparcos Number", "HIP 66970"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.88704892),
        dec: Angle.Degrees(-66.49186288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77964"},
        {"Hipparcos Number", "HIP 44348"},
        {"Geneva Identification System", "GEN# +1.00077964"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.48096405),
        dec: Angle.Degrees(-66.49095884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140810"},
        {"Hipparcos Number", "HIP 77533"},
        {"Smithsonian Astrophysical Observation", "SAO 253305"},
    },
    visualMagnitude: 9.29,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.46697421),
        dec: Angle.Degrees(-66.48975487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22252"},
        {"Hipparcos Number", "HIP 16368"},
        {"Geneva Identification System", "GEN# +1.00022252"},
        {"Smithsonian Astrophysical Observation", "SAO 248825"},
        {"Wilson Evans Batten Catalogue", "WEB 3129"},
    },
    visualMagnitude: 5.81,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.71534366),
        dec: Angle.Degrees(-66.48971810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99857"},
        {"Hipparcos Number", "HIP 55986"},
        {"Celescope Catalog", "CEL 3905"},
        {"Geneva Identification System", "GEN# +1.00099857"},
        {"Smithsonian Astrophysical Observation", "SAO 251417"},
        {"Wilson Evans Batten Catalogue", "WEB 10053"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.11335935),
        dec: Angle.Degrees(-66.48926860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81141"},
        {"Hipparcos Number", "HIP 45815"},
        {"Geneva Identification System", "GEN# +1.00081141"},
        {"Renson", "Renson 23030"},
        {"Smithsonian Astrophysical Observation", "SAO 250542"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.12575708),
        dec: Angle.Degrees(-66.48915422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130300"},
        {"Hipparcos Number", "HIP 72601"},
        {"Smithsonian Astrophysical Observation", "SAO 252910"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.66742024),
        dec: Angle.Degrees(-66.48616331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55987"},
    },
    visualMagnitude: 11.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.11607074),
        dec: Angle.Degrees(-66.48569023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 197.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112855"},
        {"Hipparcos Number", "HIP 63514"},
        {"Smithsonian Astrophysical Observation", "SAO 252125"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.22267914),
        dec: Angle.Degrees(-66.48160700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23509"},
        {"Hipparcos Number", "HIP 17239"},
        {"Geneva Identification System", "GEN# +1.00023509"},
        {"Renson", "Renson 6020"},
        {"Smithsonian Astrophysical Observation", "SAO 248868"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.37415237),
        dec: Angle.Degrees(-66.47721370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1719"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.39830258),
        dec: Angle.Degrees(-66.47672144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 255.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 161.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133525"},
        {"Hipparcos Number", "HIP 74093"},
        {"Smithsonian Astrophysical Observation", "SAO 253026"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.12628900),
        dec: Angle.Degrees(-66.47581063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218496"},
        {"Hipparcos Number", "HIP 114358"},
        {"Geneva Identification System", "GEN# +1.00218496"},
        {"Smithsonian Astrophysical Observation", "SAO 255416"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.41529180),
        dec: Angle.Degrees(-66.47200721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192741"},
        {"Hipparcos Number", "HIP 100318"},
        {"Smithsonian Astrophysical Observation", "SAO 254774"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.17785239),
        dec: Angle.Degrees(-66.47095579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181433"},
        {"Hipparcos Number", "HIP 95467"},
        {"Geneva Identification System", "GEN# +1.00181433"},
        {"Smithsonian Astrophysical Observation", "SAO 254563"},
        {"Wilson Evans Batten Catalogue", "WEB 16690"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.29126990),
        dec: Angle.Degrees(-66.46937115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 236.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163544"},
        {"Hipparcos Number", "HIP 88289"},
        {"Smithsonian Astrophysical Observation", "SAO 254108"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.43493476),
        dec: Angle.Degrees(-66.46442644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205327"},
        {"Hipparcos Number", "HIP 106766"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.40429997),
        dec: Angle.Degrees(-66.46209873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91177"},
        {"Hipparcos Number", "HIP 51374"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.39093492),
        dec: Angle.Degrees(-66.46050340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110434"},
        {"Hipparcos Number", "HIP 62025"},
        {"Geneva Identification System", "GEN# +1.00110434"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.70615108),
        dec: Angle.Degrees(-66.45772652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123873"},
        {"Hipparcos Number", "HIP 69420"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.21023216),
        dec: Angle.Degrees(-66.45256521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91466"},
        {"Hipparcos Number", "HIP 51544"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.91191793),
        dec: Angle.Degrees(-66.45217900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25106"},
        {"Hipparcos Number", "HIP 18311"},
        {"Smithsonian Astrophysical Observation", "SAO 248906"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.72181765),
        dec: Angle.Degrees(-66.44931209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169773"},
        {"Hipparcos Number", "HIP 90785"},
        {"Smithsonian Astrophysical Observation", "SAO 254267"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.82613503),
        dec: Angle.Degrees(-66.44618507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26565"},
        {"Hipparcos Number", "HIP 19246"},
        {"Geneva Identification System", "GEN# +1.00026565"},
        {"Smithsonian Astrophysical Observation", "SAO 248947"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.86806635),
        dec: Angle.Degrees(-66.44518555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35461"},
        {"Hipparcos Number", "HIP 24865"},
        {"Smithsonian Astrophysical Observation", "SAO 249253"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.95746141),
        dec: Angle.Degrees(-66.44311540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36849"},
        {"Hipparcos Number", "HIP 25713"},
        {"Geneva Identification System", "GEN# +1.00036849"},
        {"Smithsonian Astrophysical Observation", "SAO 249294"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.35510568),
        dec: Angle.Degrees(-66.43906806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129862"},
        {"Hipparcos Number", "HIP 72403"},
        {"Smithsonian Astrophysical Observation", "SAO 252891"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.05444971),
        dec: Angle.Degrees(-66.43902486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29794"},
        {"Hipparcos Number", "HIP 21483"},
        {"Smithsonian Astrophysical Observation", "SAO 249067"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.20517202),
        dec: Angle.Degrees(-66.43071899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221932"},
        {"Hipparcos Number", "HIP 116516"},
        {"Smithsonian Astrophysical Observation", "SAO 255524"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.18581182),
        dec: Angle.Degrees(-66.43013728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217141"},
        {"Hipparcos Number", "HIP 113548"},
        {"Smithsonian Astrophysical Observation", "SAO 255369"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.96244661),
        dec: Angle.Degrees(-66.42459667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142003"},
        {"Hipparcos Number", "HIP 78062"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.07827232),
        dec: Angle.Degrees(-66.42349299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69432"},
        {"Hipparcos Number", "HIP 40204"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.17303037),
        dec: Angle.Degrees(-66.39049469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130940"},
        {"Hipparcos Number", "HIP 72921"},
        {"Geneva Identification System", "GEN# +1.00130940"},
        {"Smithsonian Astrophysical Observation", "SAO 252945"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.54718569),
        dec: Angle.Degrees(-66.41966580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -263.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127300"},
        {"Hipparcos Number", "HIP 71191"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.39498595),
        dec: Angle.Degrees(-66.41370433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126627"},
        {"Hipparcos Number", "HIP 70875"},
        {"Geneva Identification System", "GEN# +1.00126627"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.40861750),
        dec: Angle.Degrees(-66.41166515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136372"},
        {"Hipparcos Number", "HIP 75383"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.06607842),
        dec: Angle.Degrees(-66.41039240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83643"},
        {"Hipparcos Number", "HIP 47183"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.22847724),
        dec: Angle.Degrees(-66.41000528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103559"},
        {"Hipparcos Number", "HIP 58121"},
        {"Geneva Identification System", "GEN# +1.00103559"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.81473879),
        dec: Angle.Degrees(-66.40892783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32414"},
    },
    visualMagnitude: 11.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.50343320),
        dec: Angle.Degrees(-66.40801730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123610"},
        {"Hipparcos Number", "HIP 69323"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.82461713),
        dec: Angle.Degrees(-66.40789961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100281"},
        {"Hipparcos Number", "HIP 56237"},
        {"Geneva Identification System", "GEN# +1.00100281"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.92101884),
        dec: Angle.Degrees(-66.40682140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177150"},
        {"Hipparcos Number", "HIP 93998"},
        {"Geneva Identification System", "GEN# +1.00177150"},
        {"Renson", "Renson 49410"},
        {"Smithsonian Astrophysical Observation", "SAO 254469"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.08215147),
        dec: Angle.Degrees(-66.40548006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120526"},
        {"Hipparcos Number", "HIP 67711"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.07224218),
        dec: Angle.Degrees(-66.40438178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175572"},
        {"Hipparcos Number", "HIP 93358"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.23913715),
        dec: Angle.Degrees(-66.40288261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120102"},
        {"Hipparcos Number", "HIP 67466"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.38360496),
        dec: Angle.Degrees(-66.40258343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7916"},
        {"Hipparcos Number", "HIP 5992"},
        {"Geneva Identification System", "GEN# +1.00007916"},
        {"Smithsonian Astrophysical Observation", "SAO 248350"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.26533831),
        dec: Angle.Degrees(-66.39789075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78045"},
        {"Hipparcos Number", "HIP 44382"},
        {"Fundamental Katalog 5th Edition", "FK5 343"},
        {"Geneva Identification System", "GEN# +1.00078045"},
        {"Renson", "Renson 22080"},
        {"Smithsonian Astrophysical Observation", "SAO 250422"},
        {"Wilson Evans Batten Catalogue", "WEB 8508"},
    },
    visualMagnitude: 4.00,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.61166181),
        dec: Angle.Degrees(-66.39584369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212999"},
        {"Hipparcos Number", "HIP 111095"},
        {"Smithsonian Astrophysical Observation", "SAO 255234"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.60183934),
        dec: Angle.Degrees(-66.39100372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156960"},
        {"Hipparcos Number", "HIP 85274"},
        {"Smithsonian Astrophysical Observation", "SAO 253913"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.36783964),
        dec: Angle.Degrees(-66.38991787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121101"},
        {"Hipparcos Number", "HIP 68033"},
        {"Geneva Identification System", "GEN# +1.00121101"},
        {"Smithsonian Astrophysical Observation", "SAO 252521"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.96165866),
        dec: Angle.Degrees(-66.38636419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8437"},
        {"Hipparcos Number", "HIP 6369"},
        {"Renson", "Renson 2040"},
        {"Smithsonian Astrophysical Observation", "SAO 248369"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.45364903),
        dec: Angle.Degrees(-66.38411535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207838"},
        {"Hipparcos Number", "HIP 108148"},
        {"Smithsonian Astrophysical Observation", "SAO 255098"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.65642455),
        dec: Angle.Degrees(-66.37910215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143088"},
        {"Hipparcos Number", "HIP 78568"},
        {"Smithsonian Astrophysical Observation", "SAO 253385"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.64879158),
        dec: Angle.Degrees(-66.37791474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103482"},
        {"Hipparcos Number", "HIP 58085"},
        {"Geneva Identification System", "GEN# +1.00103482"},
        {"Smithsonian Astrophysical Observation", "SAO 251637"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.68590817),
        dec: Angle.Degrees(-66.37603942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202416"},
        {"Hipparcos Number", "HIP 105233"},
        {"Smithsonian Astrophysical Observation", "SAO 254969"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.74253911),
        dec: Angle.Degrees(-66.37433511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75402"},
        {"Hipparcos Number", "HIP 43001"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.45535786),
        dec: Angle.Degrees(-66.37331891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88981"},
        {"Hipparcos Number", "HIP 50083"},
        {"Geneva Identification System", "GEN# +1.00088981"},
        {"Renson", "Renson 25460"},
        {"Smithsonian Astrophysical Observation", "SAO 250880"},
        {"Wilson Evans Batten Catalogue", "WEB 9208"},
    },
    visualMagnitude: 5.15,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.37784420),
        dec: Angle.Degrees(-66.37283938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140451"},
        {"Hipparcos Number", "HIP 77382"},
        {"Renson", "Renson 39920"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.94930977),
        dec: Angle.Degrees(-66.37110874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148598"},
        {"Hipparcos Number", "HIP 81094"},
        {"Renson", "Renson 42020"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.45696715),
        dec: Angle.Degrees(-66.37092775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147674"},
        {"Hipparcos Number", "HIP 80635"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.96767074),
        dec: Angle.Degrees(-66.36807787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1397"},
        {"Hipparcos Number", "HIP 1419"},
        {"Geneva Identification System", "GEN# +1.00001397"},
        {"Smithsonian Astrophysical Observation", "SAO 248155"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.44607568),
        dec: Angle.Degrees(-66.35889343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190222"},
        {"Hipparcos Number", "HIP 99200"},
        {"Geneva Identification System", "GEN# +1.00190222"},
        {"Smithsonian Astrophysical Observation", "SAO 254731"},
        {"Wilson Evans Batten Catalogue", "WEB 17665"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.08533425),
        dec: Angle.Degrees(-66.35467601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144166"},
        {"Hipparcos Number", "HIP 79108"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.20614275),
        dec: Angle.Degrees(-66.35248847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113542"},
        {"Hipparcos Number", "HIP 63906"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.44446337),
        dec: Angle.Degrees(-66.35094769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77672"},
        {"Hipparcos Number", "HIP 44214"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.09268095),
        dec: Angle.Degrees(-66.34953335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12634"},
        {"Hipparcos Number", "HIP 9437"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.30055031),
        dec: Angle.Degrees(-66.34878614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60650"},
        {"Hipparcos Number", "HIP 36529"},
        {"Smithsonian Astrophysical Observation", "SAO 249871"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.72026933),
        dec: Angle.Degrees(-66.34866921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155577"},
        {"Hipparcos Number", "HIP 84577"},
        {"Smithsonian Astrophysical Observation", "SAO 253855"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.33692308),
        dec: Angle.Degrees(-66.34773933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201248"},
        {"Hipparcos Number", "HIP 104635"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.92542809),
        dec: Angle.Degrees(-66.34447019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24629"},
        {"Hipparcos Number", "HIP 17981"},
        {"Geneva Identification System", "GEN# +1.00024629"},
        {"Smithsonian Astrophysical Observation", "SAO 248894"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.65280916),
        dec: Angle.Degrees(-66.34440226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67478"},
        {"Hipparcos Number", "HIP 39442"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.94800880),
        dec: Angle.Degrees(-66.34337481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49900"},
        {"Hipparcos Number", "HIP 32392"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.42717448),
        dec: Angle.Degrees(-66.34260395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210196"},
        {"Hipparcos Number", "HIP 109512"},
        {"Geneva Identification System", "GEN# +1.00210196"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.76791981),
        dec: Angle.Degrees(-66.34120973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121100"},
        {"Hipparcos Number", "HIP 68036"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.96979399),
        dec: Angle.Degrees(-66.33971554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66678"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.03519277),
        dec: Angle.Degrees(-66.33946416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147619"},
        {"Hipparcos Number", "HIP 80605"},
        {"Geneva Identification System", "GEN# +1.00147619"},
        {"Smithsonian Astrophysical Observation", "SAO 253553"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.87261475),
        dec: Angle.Degrees(-66.33810549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216876"},
        {"Hipparcos Number", "HIP 113407"},
        {"Smithsonian Astrophysical Observation", "SAO 255358"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.51414690),
        dec: Angle.Degrees(-66.33579783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114491"},
        {"Hipparcos Number", "HIP 64431"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.09037177),
        dec: Angle.Degrees(-66.33544619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129795"},
        {"Hipparcos Number", "HIP 72364"},
        {"Smithsonian Astrophysical Observation", "SAO 252884"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.95043764),
        dec: Angle.Degrees(-66.33191496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174787"},
        {"Hipparcos Number", "HIP 93052"},
        {"Geneva Identification System", "GEN# +1.00174787"},
        {"Smithsonian Astrophysical Observation", "SAO 254414"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.31983825),
        dec: Angle.Degrees(-66.33170666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56118"},
        {"Hipparcos Number", "HIP 34679"},
        {"Smithsonian Astrophysical Observation", "SAO 249769"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.72783523),
        dec: Angle.Degrees(-66.32447522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17589"},
        {"Hipparcos Number", "HIP 12908"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.48191607),
        dec: Angle.Degrees(-66.31778098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138538"},
        {"Hipparcos Number", "HIP 76440"},
        {"Fundamental Katalog 5th Edition", "FK5 574"},
        {"Geneva Identification System", "GEN# +1.00138538"},
        {"Smithsonian Astrophysical Observation", "SAO 253226"},
        {"Wilson Evans Batten Catalogue", "WEB 12978"},
    },
    visualMagnitude: 4.11,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.17994543),
        dec: Angle.Degrees(-66.31690469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124584"},
        {"Hipparcos Number", "HIP 69796"},
        {"Geneva Identification System", "GEN# +1.00124584"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.27226467),
        dec: Angle.Degrees(-66.31551503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -391.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131738"},
        {"Hipparcos Number", "HIP 73298"},
        {"Smithsonian Astrophysical Observation", "SAO 252978"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.69741980),
        dec: Angle.Degrees(-66.31400489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45503"},
        {"Hipparcos Number", "HIP 30323"},
        {"Smithsonian Astrophysical Observation", "SAO 249529"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.66490330),
        dec: Angle.Degrees(-66.31231854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40924"},
        {"Hipparcos Number", "HIP 28146"},
        {"Smithsonian Astrophysical Observation", "SAO 249402"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.22302790),
        dec: Angle.Degrees(-66.31054271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1777"},
        {"Hipparcos Number", "HIP 1714"},
        {"Geneva Identification System", "GEN# +1.00001777"},
        {"Smithsonian Astrophysical Observation", "SAO 248170"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.38914076),
        dec: Angle.Degrees(-66.30452329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185523"},
        {"Hipparcos Number", "HIP 97099"},
        {"Smithsonian Astrophysical Observation", "SAO 254636"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.00002243),
        dec: Angle.Degrees(-66.29699847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215683"},
        {"Hipparcos Number", "HIP 112622"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.13826358),
        dec: Angle.Degrees(-66.29518075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97096"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.98775301),
        dec: Angle.Degrees(-66.29355752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50862"},
        {"Hipparcos Number", "HIP 32779"},
        {"Fundamental Katalog 5th Edition", "FK5 2531"},
        {"Geneva Identification System", "GEN# +1.00050862"},
        {"Smithsonian Astrophysical Observation", "SAO 249658"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.51051426),
        dec: Angle.Degrees(-66.29348785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222299"},
        {"Hipparcos Number", "HIP 116764"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.96957240),
        dec: Angle.Degrees(-66.29340064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44247"},
        {"Hipparcos Number", "HIP 29727"},
        {"Celescope Catalog", "CEL 1165"},
        {"Geneva Identification System", "GEN# +1.00044247"},
        {"Smithsonian Astrophysical Observation", "SAO 249497"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.91445255),
        dec: Angle.Degrees(-66.29230115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22288"},
        {"Hipparcos Number", "HIP 16397"},
        {"Smithsonian Astrophysical Observation", "SAO 248829"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.78456552),
        dec: Angle.Degrees(-66.29127426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37853"},
        {"Hipparcos Number", "HIP 26324"},
        {"Smithsonian Astrophysical Observation", "SAO 249320"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.09307055),
        dec: Angle.Degrees(-66.29035728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107285"},
        {"Hipparcos Number", "HIP 60169"},
        {"Geneva Identification System", "GEN# +1.00107285"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.07908402),
        dec: Angle.Degrees(-66.28354946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201279"},
        {"Hipparcos Number", "HIP 104650"},
        {"Smithsonian Astrophysical Observation", "SAO 254952"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.98425994),
        dec: Angle.Degrees(-66.28320818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149648"},
        {"Hipparcos Number", "HIP 81638"},
        {"Smithsonian Astrophysical Observation", "SAO 253646"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.15516539),
        dec: Angle.Degrees(-66.27982399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116849"},
        {"Hipparcos Number", "HIP 65693"},
        {"Geneva Identification System", "GEN# +1.00116849"},
        {"Wilson Evans Batten Catalogue", "WEB 11624"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.03051686),
        dec: Angle.Degrees(-66.27976020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170407"},
        {"Hipparcos Number", "HIP 91035"},
        {"Geneva Identification System", "GEN# +1.00170407"},
        {"Smithsonian Astrophysical Observation", "SAO 254286"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.56032952),
        dec: Angle.Degrees(-66.27926013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69864"},
        {"Hipparcos Number", "HIP 40377"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.66509051),
        dec: Angle.Degrees(-66.27011117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156427"},
        {"Hipparcos Number", "HIP 85008"},
        {"Smithsonian Astrophysical Observation", "SAO 253886"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.61964614),
        dec: Angle.Degrees(-66.26888269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104478"},
        {"Hipparcos Number", "HIP 58670"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.44716198),
        dec: Angle.Degrees(-66.26887219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121932"},
        {"Hipparcos Number", "HIP 68455"},
        {"Geneva Identification System", "GEN# +1.00121932"},
        {"Smithsonian Astrophysical Observation", "SAO 252554"},
        {"Wilson Evans Batten Catalogue", "WEB 11996"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.21922701),
        dec: Angle.Degrees(-66.26885149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74667"},
        {"Hipparcos Number", "HIP 42642"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.34336984),
        dec: Angle.Degrees(-66.26476469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212134"},
        {"Hipparcos Number", "HIP 110592"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.06926478),
        dec: Angle.Degrees(-66.26270953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269408"},
        {"Hipparcos Number", "HIP 25097"},
        {"Geneva Identification System", "GEN# +1.00269408"},
    },
    visualMagnitude: 11.60,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.58779210),
        dec: Angle.Degrees(-66.26027871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130287"},
        {"Hipparcos Number", "HIP 72592"},
        {"Smithsonian Astrophysical Observation", "SAO 252909"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.64237181),
        dec: Angle.Degrees(-66.25932360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223400"},
        {"Hipparcos Number", "HIP 117493"},
        {"Geneva Identification System", "GEN# +1.00223400"},
        {"Smithsonian Astrophysical Observation", "SAO 255576"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.38163644),
        dec: Angle.Degrees(-66.25740648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 352.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59896"},
        {"Hipparcos Number", "HIP 36204"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.84193732),
        dec: Angle.Degrees(-66.25480721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200116"},
        {"Hipparcos Number", "HIP 104065"},
        {"Smithsonian Astrophysical Observation", "SAO 254931"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.25176419),
        dec: Angle.Degrees(-66.25386856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222272"},
        {"Hipparcos Number", "HIP 116749"},
        {"Smithsonian Astrophysical Observation", "SAO 255540"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.92109069),
        dec: Angle.Degrees(-66.25364952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204841"},
        {"Hipparcos Number", "HIP 106501"},
        {"Smithsonian Astrophysical Observation", "SAO 255025"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.57250791),
        dec: Angle.Degrees(-66.24523343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132927"},
        {"Hipparcos Number", "HIP 73828"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.33342388),
        dec: Angle.Degrees(-66.24502390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28044"},
        {"Hipparcos Number", "HIP 20285"},
        {"Geneva Identification System", "GEN# +1.00028044"},
        {"Smithsonian Astrophysical Observation", "SAO 249002"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.22022009),
        dec: Angle.Degrees(-66.24077024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65961"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.86651889),
        dec: Angle.Degrees(-66.23862930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136287"},
        {"Hipparcos Number", "HIP 75338"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.91580711),
        dec: Angle.Degrees(-66.23825530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111038"},
        {"Hipparcos Number", "HIP 62403"},
        {"Geneva Identification System", "GEN# +1.00111038"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.82970240),
        dec: Angle.Degrees(-66.23747409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80255"},
        {"Hipparcos Number", "HIP 45416"},
        {"Geneva Identification System", "GEN# +1.00080255"},
    },
    visualMagnitude: 9.65,
    bvColour: 2.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.82031487),
        dec: Angle.Degrees(-66.23613139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127804"},
        {"Hipparcos Number", "HIP 71435"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.11395947),
        dec: Angle.Degrees(-66.23088335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118294"},
        {"Hipparcos Number", "HIP 66507"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.49440457),
        dec: Angle.Degrees(-66.23050235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145545"},
        {"Hipparcos Number", "HIP 79709"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.01555645),
        dec: Angle.Degrees(-66.22805237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114570"},
        {"Hipparcos Number", "HIP 64466"},
        {"Geneva Identification System", "GEN# +1.00114570"},
        {"Renson", "Renson 33112"},
        {"Smithsonian Astrophysical Observation", "SAO 252196"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.20319288),
        dec: Angle.Degrees(-66.22676607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41466"},
        {"Hipparcos Number", "HIP 28437"},
        {"Smithsonian Astrophysical Observation", "SAO 249419"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.07743215),
        dec: Angle.Degrees(-66.22420675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212879"},
        {"Hipparcos Number", "HIP 111017"},
        {"Smithsonian Astrophysical Observation", "SAO 255230"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.36818242),
        dec: Angle.Degrees(-66.22323140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11796"},
        {"Hipparcos Number", "HIP 8813"},
        {"Smithsonian Astrophysical Observation", "SAO 248458"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.31280187),
        dec: Angle.Degrees(-66.21656059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101827"},
        {"Hipparcos Number", "HIP 57120"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.65637579),
        dec: Angle.Degrees(-66.21442022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65555"},
        {"Hipparcos Number", "HIP 38645"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.69502737),
        dec: Angle.Degrees(-66.21234687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 155.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67298"},
        {"Hipparcos Number", "HIP 39374"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.73635245),
        dec: Angle.Degrees(-66.21189907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104673"},
        {"Hipparcos Number", "HIP 58760"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.76505341),
        dec: Angle.Degrees(-66.21017136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15053"},
        {"Hipparcos Number", "HIP 11061"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.59467913),
        dec: Angle.Degrees(-66.20908798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77187B"},
        {"Hipparcos Number", "HIP 43980"},
        {"Smithsonian Astrophysical Observation", "SAO 250397"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.34237320),
        dec: Angle.Degrees(-66.20666129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74239"},
        {"Hipparcos Number", "HIP 42413"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.73568657),
        dec: Angle.Degrees(-66.20658823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161013"},
        {"Hipparcos Number", "HIP 87127"},
        {"Smithsonian Astrophysical Observation", "SAO 254034"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.02652855),
        dec: Angle.Degrees(-66.20424528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77187"},
        {"Hipparcos Number", "HIP 43979"},
        {"Smithsonian Astrophysical Observation", "SAO 250396"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.33815531),
        dec: Angle.Degrees(-66.20423039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197051"},
        {"Hipparcos Number", "HIP 102395"},
        {"Fundamental Katalog 5th Edition", "FK5 775"},
        {"Geneva Identification System", "GEN# +1.00197051"},
        {"Smithsonian Astrophysical Observation", "SAO 254862"},
        {"Wilson Evans Batten Catalogue", "WEB 18537"},
    },
    visualMagnitude: 3.42,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.23981530),
        dec: Angle.Degrees(-66.20323826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4945"},
        {"Hipparcos Number", "HIP 3927"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.60822962),
        dec: Angle.Degrees(-66.20320131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211551"},
        {"Hipparcos Number", "HIP 110257"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.00537668),
        dec: Angle.Degrees(-66.19736658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57286"},
        {"Hipparcos Number", "HIP 35129"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.93689630),
        dec: Angle.Degrees(-66.19707720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64484"},
        {"Hipparcos Number", "HIP 38210"},
        {"Fundamental Katalog 5th Edition", "FK5 2610"},
        {"Geneva Identification System", "GEN# +1.00064484"},
        {"Smithsonian Astrophysical Observation", "SAO 249978"},
        {"Wilson Evans Batten Catalogue", "WEB 7530"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.42081658),
        dec: Angle.Degrees(-66.19597303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124437"},
        {"Hipparcos Number", "HIP 69725"},
        {"Renson", "Renson 35620"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.08746531),
        dec: Angle.Degrees(-66.19335921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29547"},
        {"Hipparcos Number", "HIP 21305"},
        {"Smithsonian Astrophysical Observation", "SAO 249060"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.60699475),
        dec: Angle.Degrees(-66.19306588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175607"},
        {"Hipparcos Number", "HIP 93373"},
        {"Geneva Identification System", "GEN# +1.00175607"},
        {"Wilson Evans Batten Catalogue", "WEB 16187"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.27207019),
        dec: Angle.Degrees(-66.19174084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -387.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35133"},
    },
    visualMagnitude: 10.68,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.94759483),
        dec: Angle.Degrees(-66.19057692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99785"},
        {"Hipparcos Number", "HIP 55956"},
        {"Celescope Catalog", "CEL 3904"},
        {"Geneva Identification System", "GEN# +1.00099785"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.00214495),
        dec: Angle.Degrees(-66.18987300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82731"},
        {"Hipparcos Number", "HIP 46644"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.66466611),
        dec: Angle.Degrees(-66.18870075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5529",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Emiw"},
        {"Henry Draper", "HD 7199"},
        {"Hipparcos Number", "HIP 5529"},
        {"Geneva Identification System", "GEN# +1.00007199"},
        {"Smithsonian Astrophysical Observation", "SAO 248334"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.69608830),
        dec: Angle.Degrees(-66.18786313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95952"},
        {"Hipparcos Number", "HIP 54000"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.70310499),
        dec: Angle.Degrees(-66.18304839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88784"},
        {"Hipparcos Number", "HIP 49978"},
        {"Smithsonian Astrophysical Observation", "SAO 250865"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.04681362),
        dec: Angle.Degrees(-66.18162323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190248"},
        {"Hipparcos Number", "HIP 99240"},
        {"Cincinnati Publication", "Ci 20 1187"},
        {"Fundamental Katalog 5th Edition", "FK5 754"},
        {"Geneva Identification System", "GEN# +1.00190248"},
        {"Smithsonian Astrophysical Observation", "SAO 254733"},
        {"Wilson Evans Batten Catalogue", "WEB 17675"},
    },
    visualMagnitude: 3.55,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.17441713),
        dec: Angle.Degrees(-66.17932101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1210.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1130.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129740"},
        {"Hipparcos Number", "HIP 72332"},
        {"Geneva Identification System", "GEN# +1.00129740"},
        {"Smithsonian Astrophysical Observation", "SAO 252882"},
        {"Wilson Evans Batten Catalogue", "WEB 12438"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.86912903),
        dec: Angle.Degrees(-66.17910248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193365"},
        {"Hipparcos Number", "HIP 100597"},
        {"Geneva Identification System", "GEN# +1.00193365"},
        {"Smithsonian Astrophysical Observation", "SAO 254781"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.97630821),
        dec: Angle.Degrees(-66.17887968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25729"},
        {"Hipparcos Number", "HIP 18699"},
        {"Geneva Identification System", "GEN# +1.00025729"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.09246038),
        dec: Angle.Degrees(-66.17876615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170575"},
        {"Hipparcos Number", "HIP 91108"},
        {"Smithsonian Astrophysical Observation", "SAO 254290"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.76902586),
        dec: Angle.Degrees(-66.17563901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132629"},
        {"Hipparcos Number", "HIP 73685"},
        {"Geneva Identification System", "GEN# +1.00132629"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.92302849),
        dec: Angle.Degrees(-66.17533805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138054"},
        {"Hipparcos Number", "HIP 76175"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.38762619),
        dec: Angle.Degrees(-66.17422470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43942"},
        {"Hipparcos Number", "HIP 29574"},
        {"Geneva Identification System", "GEN# +1.00043942"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.47603142),
        dec: Angle.Degrees(-66.17384762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125990"},
        {"Hipparcos Number", "HIP 70528"},
        {"Geneva Identification System", "GEN# +1.00125990"},
        {"Smithsonian Astrophysical Observation", "SAO 252737"},
        {"Wilson Evans Batten Catalogue", "WEB 12232"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.41583852),
        dec: Angle.Degrees(-66.17288297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6483"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.82731569),
        dec: Angle.Degrees(-66.17273383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 325.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89542"},
        {"Hipparcos Number", "HIP 50427"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.44431682),
        dec: Angle.Degrees(-66.17235083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85716"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.73423073),
        dec: Angle.Degrees(-66.16975087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180775"},
        {"Hipparcos Number", "HIP 95232"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.63446282),
        dec: Angle.Degrees(-66.16719485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2700"},
        {"Hipparcos Number", "HIP 2345"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.48513525),
        dec: Angle.Degrees(-66.16433103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123028"},
        {"Hipparcos Number", "HIP 69023"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.95389750),
        dec: Angle.Degrees(-66.16280703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144375"},
        {"Hipparcos Number", "HIP 79212"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.50007106),
        dec: Angle.Degrees(-66.15839685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134709"},
        {"Hipparcos Number", "HIP 74630"},
        {"Geneva Identification System", "GEN# +1.00134709"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.73395719),
        dec: Angle.Degrees(-66.15720757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213257"},
        {"Henry Draper 2", "HD 213257A"},
        {"Hipparcos Number", "HIP 111231"},
        {"Smithsonian Astrophysical Observation", "SAO 255242"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.03708100),
        dec: Angle.Degrees(-66.15714771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207974"},
        {"Hipparcos Number", "HIP 108247"},
        {"Smithsonian Astrophysical Observation", "SAO 255103"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.93815041),
        dec: Angle.Degrees(-66.15641133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78844"},
        {"Hipparcos Number", "HIP 44732"},
        {"Smithsonian Astrophysical Observation", "SAO 250446"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.72640345),
        dec: Angle.Degrees(-66.15611391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13926"},
        {"Hipparcos Number", "HIP 10299"},
        {"Smithsonian Astrophysical Observation", "SAO 248512"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.17696690),
        dec: Angle.Degrees(-66.15442226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124182"},
        {"Hipparcos Number", "HIP 69584"},
        {"Geneva Identification System", "GEN# +1.00124182J"},
        {"Smithsonian Astrophysical Observation", "SAO 252660"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.64583156),
        dec: Angle.Degrees(-66.15414127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141969"},
        {"Hipparcos Number", "HIP 78034"},
        {"Geneva Identification System", "GEN# +1.00141969"},
    },
    visualMagnitude: 10.44,
    bvColour: -0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.00709507),
        dec: Angle.Degrees(-66.15254943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87862"},
        {"Hipparcos Number", "HIP 49427"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.35772425),
        dec: Angle.Degrees(-66.15237013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123009"},
        {"Hipparcos Number", "HIP 69014"},
        {"Renson", "Renson 35260"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.92384728),
        dec: Angle.Degrees(-66.15216467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180865"},
        {"Hipparcos Number", "HIP 95256"},
        {"Geneva Identification System", "GEN# +1.00180865"},
        {"Smithsonian Astrophysical Observation", "SAO 254544"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.70692777),
        dec: Angle.Degrees(-66.15107198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -362.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198678"},
        {"Hipparcos Number", "HIP 103302"},
        {"Geneva Identification System", "GEN# +1.00198678"},
        {"Smithsonian Astrophysical Observation", "SAO 254899"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.91995521),
        dec: Angle.Degrees(-66.14992478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120563"},
        {"Hipparcos Number", "HIP 67734"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.13609680),
        dec: Angle.Degrees(-66.14698295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145194"},
        {"Hipparcos Number", "HIP 79572"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.53621283),
        dec: Angle.Degrees(-66.14080221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13110"},
        {"Hipparcos Number", "HIP 9771"},
        {"Smithsonian Astrophysical Observation", "SAO 248493"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.41128693),
        dec: Angle.Degrees(-66.13904807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310147"},
        {"Hipparcos Number", "HIP 52217"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.03350629),
        dec: Angle.Degrees(-66.13902684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71878"},
        {"Hipparcos Number", "HIP 41312"},
        {"Fundamental Katalog 5th Edition", "FK5 319"},
        {"Geneva Identification System", "GEN# +1.00071878"},
        {"Smithsonian Astrophysical Observation", "SAO 250228"},
        {"Wilson Evans Batten Catalogue", "WEB 7993"},
    },
    visualMagnitude: 3.77,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.43435936),
        dec: Angle.Degrees(-66.13652042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219852"},
        {"Hipparcos Number", "HIP 115199"},
        {"Smithsonian Astrophysical Observation", "SAO 255460"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.00458049),
        dec: Angle.Degrees(-66.13392292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128216"},
        {"Hipparcos Number", "HIP 71613"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.69525158),
        dec: Angle.Degrees(-66.13119389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128107"},
        {"Hipparcos Number", "HIP 71560"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.53193788),
        dec: Angle.Degrees(-66.12961974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83312"},
        {"Hipparcos Number", "HIP 46978"},
        {"Smithsonian Astrophysical Observation", "SAO 250628"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.62422498),
        dec: Angle.Degrees(-66.12225175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136977"},
        {"Hipparcos Number", "HIP 75658"},
        {"Geneva Identification System", "GEN# +1.00136977"},
        {"Smithsonian Astrophysical Observation", "SAO 253172"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.86241792),
        dec: Angle.Degrees(-66.12139818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86997"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.66776201),
        dec: Angle.Degrees(-66.11839977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -339.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16963"},
        {"Hipparcos Number", "HIP 12418"},
        {"Geneva Identification System", "GEN# +1.00016963"},
        {"Smithsonian Astrophysical Observation", "SAO 248622"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.96183200),
        dec: Angle.Degrees(-66.11820504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109199"},
        {"Hipparcos Number", "HIP 61294"},
        {"Geneva Identification System", "GEN# +1.00109199"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.39233191),
        dec: Angle.Degrees(-66.11704483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129532"},
        {"Hipparcos Number", "HIP 72224"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.57293031),
        dec: Angle.Degrees(-66.11639162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84890"},
        {"Hipparcos Number", "HIP 47883"},
        {"Smithsonian Astrophysical Observation", "SAO 250687"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.37602039),
        dec: Angle.Degrees(-66.11545601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102579"},
        {"Hipparcos Number", "HIP 57572"},
        {"Geneva Identification System", "GEN# +1.00102579"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.01071770),
        dec: Angle.Degrees(-66.11531301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -267.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 175.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107874"},
        {"Hipparcos Number", "HIP 60493"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.02243818),
        dec: Angle.Degrees(-66.11397218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152167"},
        {"Hipparcos Number", "HIP 82908"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.13701398),
        dec: Angle.Degrees(-66.10893920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105545"},
        {"Hipparcos Number", "HIP 59254"},
        {"Celescope Catalog", "CEL 4059"},
        {"Smithsonian Astrophysical Observation", "SAO 251763"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.31944533),
        dec: Angle.Degrees(-66.10780799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167960"},
        {"Hipparcos Number", "HIP 90049"},
        {"Smithsonian Astrophysical Observation", "SAO 254219"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.62619092),
        dec: Angle.Degrees(-66.10492483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8383"},
        {"Hipparcos Number", "HIP 6326"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.30972159),
        dec: Angle.Degrees(-66.10441796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75970"},
        {"Hipparcos Number", "HIP 43319"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.37387358),
        dec: Angle.Degrees(-66.10367862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82282"},
        {"Hipparcos Number", "HIP 46422"},
        {"Geneva Identification System", "GEN# +1.00082282"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.98972188),
        dec: Angle.Degrees(-66.10212508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215267"},
        {"Hipparcos Number", "HIP 112378"},
        {"Fundamental Katalog 5th Edition", "FK5 6005"},
        {"Smithsonian Astrophysical Observation", "SAO 255307"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.40917895),
        dec: Angle.Degrees(-66.09975815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162156"},
        {"Hipparcos Number", "HIP 87669"},
        {"Smithsonian Astrophysical Observation", "SAO 254066"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.61040349),
        dec: Angle.Degrees(-66.09959206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47546"},
        {"Hipparcos Number", "HIP 31331"},
        {"Renson", "Renson 12750"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.54448839),
        dec: Angle.Degrees(-66.09864650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86562"},
    },
    visualMagnitude: 11.68,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.34243182),
        dec: Angle.Degrees(-66.09657861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172921"},
        {"Hipparcos Number", "HIP 92218"},
        {"Smithsonian Astrophysical Observation", "SAO 254367"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.91401507),
        dec: Angle.Degrees(-66.09639993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92784"},
        {"Hipparcos Number", "HIP 52286"},
        {"Geneva Identification System", "GEN# +1.00092784"},
        {"Smithsonian Astrophysical Observation", "SAO 251065"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.25945400),
        dec: Angle.Degrees(-66.09601121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189011"},
        {"Hipparcos Number", "HIP 98659"},
        {"Smithsonian Astrophysical Observation", "SAO 254712"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.58668440),
        dec: Angle.Degrees(-66.09401316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17197"},
        {"Hipparcos Number", "HIP 12629"},
        {"Smithsonian Astrophysical Observation", "SAO 248630"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.57699527),
        dec: Angle.Degrees(-66.09255834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135139"},
        {"Hipparcos Number", "HIP 74801"},
        {"Geneva Identification System", "GEN# +1.00135139"},
        {"Smithsonian Astrophysical Observation", "SAO 253083"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.30785985),
        dec: Angle.Degrees(-66.09229087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38600"},
        {"Hipparcos Number", "HIP 26841"},
        {"Renson", "Renson 10380"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.48826182),
        dec: Angle.Degrees(-66.09206989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100867"},
        {"Hipparcos Number", "HIP 56576"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.99429200),
        dec: Angle.Degrees(-66.09089776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48447"},
        {"Hipparcos Number", "HIP 31742"},
        {"Smithsonian Astrophysical Observation", "SAO 249609"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.60646415),
        dec: Angle.Degrees(-66.08570306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220946"},
        {"Hipparcos Number", "HIP 115878"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.16046601),
        dec: Angle.Degrees(-66.08565656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67933"},
        {"Hipparcos Number", "HIP 39633"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.49451333),
        dec: Angle.Degrees(-66.08470774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208498"},
        {"Hipparcos Number", "HIP 108528"},
        {"Smithsonian Astrophysical Observation", "SAO 255115"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.79365313),
        dec: Angle.Degrees(-66.08306395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18852"},
        {"Hipparcos Number", "HIP 13854"},
        {"Smithsonian Astrophysical Observation", "SAO 248699"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.59511290),
        dec: Angle.Degrees(-66.08057152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84261"},
        {"Hipparcos Number", "HIP 47505"},
        {"Geneva Identification System", "GEN# +1.00084261"},
        {"Smithsonian Astrophysical Observation", "SAO 250664"},
        {"Wilson Evans Batten Catalogue", "WEB 8911"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.27700202),
        dec: Angle.Degrees(-66.08031107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30805"},
        {"Hipparcos Number", "HIP 22150"},
        {"Geneva Identification System", "GEN# +1.00030805"},
        {"Smithsonian Astrophysical Observation", "SAO 249104"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.49638405),
        dec: Angle.Degrees(-66.07878406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117007"},
        {"Hipparcos Number", "HIP 65785"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.29144771),
        dec: Angle.Degrees(-66.07860361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89886",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89886"},
        {"Wilson Evans Batten Catalogue", "WEB 15349"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.11617608),
        dec: Angle.Degrees(-66.07857718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117694"},
        {"Hipparcos Number", "HIP 66178"},
        {"Smithsonian Astrophysical Observation", "SAO 252366"},
        {"Wilson Evans Batten Catalogue", "WEB 11689"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.45861327),
        dec: Angle.Degrees(-66.07841707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120306"},
        {"Geneva Identification System", "GEN# +6.20145125"},
    },
    visualMagnitude: 10.96,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.68747734),
        dec: Angle.Degrees(-66.07528437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117001"},
        {"Hipparcos Number", "HIP 65779"},
        {"Geneva Identification System", "GEN# +1.00117001"},
        {"Smithsonian Astrophysical Observation", "SAO 252327"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.27749917),
        dec: Angle.Degrees(-66.07375226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150704"},
        {"Hipparcos Number", "HIP 82192"},
        {"Geneva Identification System", "GEN# +1.00150704"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.87611707),
        dec: Angle.Degrees(-66.07258471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63513"},
        {"Hipparcos Number", "HIP 37773"},
        {"Geneva Identification System", "GEN# +1.00063513"},
        {"Smithsonian Astrophysical Observation", "SAO 249944"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.18282329),
        dec: Angle.Degrees(-66.07204846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74376"},
        {"Hipparcos Number", "HIP 42496"},
        {"Geneva Identification System", "GEN# +1.00074376"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.96188339),
        dec: Angle.Degrees(-66.07131301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114699"},
        {"Hipparcos Number", "HIP 64536"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.42001593),
        dec: Angle.Degrees(-66.06691609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12477"},
        {"Hipparcos Number", "HIP 9318"},
        {"Fundamental Katalog 5th Edition", "FK5 2137"},
        {"Geneva Identification System", "GEN# +1.00012477"},
        {"Smithsonian Astrophysical Observation", "SAO 248476"},
        {"Wilson Evans Batten Catalogue", "WEB 1959"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.92116544),
        dec: Angle.Degrees(-66.06657323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89903"},
        {"Hipparcos Number", "HIP 50612"},
        {"Smithsonian Astrophysical Observation", "SAO 250925"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.07860285),
        dec: Angle.Degrees(-66.06365051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145141"},
        {"Hipparcos Number", "HIP 79535"},
    },
    visualMagnitude: 9.17,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.45274920),
        dec: Angle.Degrees(-66.06280923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44898"},
        {"Hipparcos Number", "HIP 30050"},
        {"Geneva Identification System", "GEN# +1.00044898"},
        {"Smithsonian Astrophysical Observation", "SAO 249510"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.84399718),
        dec: Angle.Degrees(-66.05996622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6632"},
        {"Hipparcos Number", "HIP 5125"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.41141134),
        dec: Angle.Degrees(-66.05898845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184480"},
        {"Hipparcos Number", "HIP 96676"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.81350872),
        dec: Angle.Degrees(-66.05642449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 271018"},
        {"Hipparcos Number", "HIP 23820"},
        {"Geneva Identification System", "GEN# +1.00271018"},
    },
    visualMagnitude: 11.46,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.80907501),
        dec: Angle.Degrees(-66.05512072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215906"},
        {"Hipparcos Number", "HIP 112753"},
        {"Geneva Identification System", "GEN# +1.00215906"},
        {"Smithsonian Astrophysical Observation", "SAO 255328"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.52147037),
        dec: Angle.Degrees(-66.05044131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163172"},
        {"Hipparcos Number", "HIP 88107"},
        {"Smithsonian Astrophysical Observation", "SAO 254097"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.91003357),
        dec: Angle.Degrees(-66.04947714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26789"},
        {"Hipparcos Number", "HIP 19430"},
        {"Smithsonian Astrophysical Observation", "SAO 248956"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.41766247),
        dec: Angle.Degrees(-66.04685993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3611"},
        {"Hipparcos Number", "HIP 3001"},
        {"Geneva Identification System", "GEN# +1.00003611"},
        {"Smithsonian Astrophysical Observation", "SAO 248228"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.53409480),
        dec: Angle.Degrees(-66.04294098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42525"},
        {"Hipparcos Number", "HIP 28909"},
        {"Celescope Catalog", "CEL 1091"},
        {"Geneva Identification System", "GEN# +1.00042525"},
        {"Renson", "Renson 11330"},
        {"Smithsonian Astrophysical Observation", "SAO 249448"},
        {"Wilson Evans Batten Catalogue", "WEB 5660"},
    },
    visualMagnitude: 5.72,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.53900939),
        dec: Angle.Degrees(-66.03968885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82765"},
        {"Hipparcos Number", "HIP 46683"},
        {"Smithsonian Astrophysical Observation", "SAO 250608"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.75590666),
        dec: Angle.Degrees(-66.03430597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71313"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.74908847),
        dec: Angle.Degrees(-66.03045062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95590"},
        {"Hipparcos Number", "HIP 53815"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.15850062),
        dec: Angle.Degrees(-66.03021034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 525"},
        {"Hipparcos Number", "HIP 775"},
        {"Geneva Identification System", "GEN# +1.00000525"},
        {"Smithsonian Astrophysical Observation", "SAO 248127"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.39204187),
        dec: Angle.Degrees(-66.02972893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112093"},
        {"Hipparcos Number", "HIP 63035"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.74909294),
        dec: Angle.Degrees(-66.02525902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87032"},
        {"Hipparcos Number", "HIP 49001"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.95626384),
        dec: Angle.Degrees(-66.02473784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46819"},
        {"Hipparcos Number", "HIP 31003"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.59474491),
        dec: Angle.Degrees(-66.02313139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195031"},
        {"Hipparcos Number", "HIP 101385"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.21857339),
        dec: Angle.Degrees(-66.02276278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67199"},
        {"Hipparcos Number", "HIP 39342"},
        {"Geneva Identification System", "GEN# +1.00067199"},
        {"Smithsonian Astrophysical Observation", "SAO 250088"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.63089255),
        dec: Angle.Degrees(-66.02062200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139534"},
        {"Hipparcos Number", "HIP 76934"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.64607981),
        dec: Angle.Degrees(-66.02001581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10679"},
        {"Hipparcos Number", "HIP 7954"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.53414970),
        dec: Angle.Degrees(-66.01766387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217436"},
        {"Hipparcos Number", "HIP 113734"},
        {"Smithsonian Astrophysical Observation", "SAO 255379"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.50666481),
        dec: Angle.Degrees(-66.01512094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148740"},
        {"Hipparcos Number", "HIP 81168"},
        {"Geneva Identification System", "GEN# +1.00148740"},
        {"Smithsonian Astrophysical Observation", "SAO 253607"},
        {"Wilson Evans Batten Catalogue", "WEB 13724"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.67401179),
        dec: Angle.Degrees(-66.01407672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127536"},
        {"Hipparcos Number", "HIP 71309"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.73789588),
        dec: Angle.Degrees(-66.01395781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95786"},
        {"Hipparcos Number", "HIP 53913"},
        {"Celescope Catalog", "CEL 3782"},
        {"Geneva Identification System", "GEN# +1.00095786"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.47811652),
        dec: Angle.Degrees(-66.01236272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158431"},
        {"Hipparcos Number", "HIP 85966"},
        {"Geneva Identification System", "GEN# +1.00158431"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.54345679),
        dec: Angle.Degrees(-66.00800015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106087"},
        {"Hipparcos Number", "HIP 59533"},
        {"Geneva Identification System", "GEN# +1.00106087"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.12182443),
        dec: Angle.Degrees(-66.00767852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92042"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.41517730),
        dec: Angle.Degrees(-66.00748953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102533"},
        {"Hipparcos Number", "HIP 57542"},
        {"Geneva Identification System", "GEN# +1.00102533"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.90654346),
        dec: Angle.Degrees(-66.00720978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123818"},
        {"Hipparcos Number", "HIP 69397"},
        {"Smithsonian Astrophysical Observation", "SAO 252645"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.10092312),
        dec: Angle.Degrees(-66.00606727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158819"},
        {"Hipparcos Number", "HIP 86147"},
        {"Renson", "Renson 44690"},
        {"Smithsonian Astrophysical Observation", "SAO 253970"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.07118891),
        dec: Angle.Degrees(-65.99743705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310796"},
        {"Hipparcos Number", "HIP 57334"},
        {"Smithsonian Astrophysical Observation", "SAO 251572"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.33104057),
        dec: Angle.Degrees(-65.99245215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131058"},
        {"Hipparcos Number", "HIP 72965"},
        {"Geneva Identification System", "GEN# +1.00131058"},
        {"Smithsonian Astrophysical Observation", "SAO 252951"},
        {"Wilson Evans Batten Catalogue", "WEB 12521"},
    },
    visualMagnitude: 6.09,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.67746133),
        dec: Angle.Degrees(-65.99106556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203571"},
        {"Hipparcos Number", "HIP 105837"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.55337021),
        dec: Angle.Degrees(-65.98798164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29154"},
        {"Hipparcos Number", "HIP 21051"},
        {"Geneva Identification System", "GEN# +1.00029154"},
        {"Wilson Evans Batten Catalogue", "WEB 4053"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.68883735),
        dec: Angle.Degrees(-65.98777813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86893"},
        {"Hipparcos Number", "HIP 48939"},
        {"Smithsonian Astrophysical Observation", "SAO 250772"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.77108445),
        dec: Angle.Degrees(-65.98333057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186530"},
        {"Hipparcos Number", "HIP 97540"},
        {"Smithsonian Astrophysical Observation", "SAO 254654"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.36806132),
        dec: Angle.Degrees(-65.97901420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85559"},
    },
    visualMagnitude: 11.37,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.26866752),
        dec: Angle.Degrees(-65.97855350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68307"},
        {"Hipparcos Number", "HIP 39756"},
        {"Smithsonian Astrophysical Observation", "SAO 250117"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.88381484),
        dec: Angle.Degrees(-65.97658550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98770"},
        {"Hipparcos Number", "HIP 55439"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.28824198),
        dec: Angle.Degrees(-65.97348412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88756"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.78694639),
        dec: Angle.Degrees(-65.96949504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7900"},
        {"Hipparcos Number", "HIP 5979"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.22700616),
        dec: Angle.Degrees(-65.96744826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27854"},
        {"Hipparcos Number", "HIP 20162"},
        {"Smithsonian Astrophysical Observation", "SAO 248993"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.81893450),
        dec: Angle.Degrees(-65.96660402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155068"},
        {"Hipparcos Number", "HIP 84302"},
        {"Geneva Identification System", "GEN# +1.00155068"},
        {"Smithsonian Astrophysical Observation", "SAO 253831"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.53098713),
        dec: Angle.Degrees(-65.96229340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202474"},
        {"Hipparcos Number", "HIP 105263"},
        {"Smithsonian Astrophysical Observation", "SAO 254973"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.82812324),
        dec: Angle.Degrees(-65.96133743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40625"},
        {"Hipparcos Number", "HIP 27969"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.73922815),
        dec: Angle.Degrees(-65.96028767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195870"},
        {"Hipparcos Number", "HIP 101789"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.43525428),
        dec: Angle.Degrees(-65.95560062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15828"},
        {"Hipparcos Number", "HIP 11605"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.42382172),
        dec: Angle.Degrees(-65.94966231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223913"},
        {"Hipparcos Number", "HIP 117815"},
        {"Geneva Identification System", "GEN# +1.00223913"},
        {"Smithsonian Astrophysical Observation", "SAO 255594"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.41641809),
        dec: Angle.Degrees(-65.94734164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13263"},
        {"Hipparcos Number", "HIP 9870"},
        {"Smithsonian Astrophysical Observation", "SAO 248497"},
        {"Wilson Evans Batten Catalogue", "WEB 2072"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.74551385),
        dec: Angle.Degrees(-65.94572014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 935"},
        {"Hipparcos Number", "HIP 1084"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.37688932),
        dec: Angle.Degrees(-65.94442634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137683"},
        {"Hipparcos Number", "HIP 76000"},
        {"Smithsonian Astrophysical Observation", "SAO 253192"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.82100417),
        dec: Angle.Degrees(-65.94329738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37379"},
        {"Hipparcos Number", "HIP 26026"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.28756735),
        dec: Angle.Degrees(-65.94231178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 323"},
        {"Hipparcos Number", "HIP 631"},
        {"Geneva Identification System", "GEN# +1.00000323"},
        {"Smithsonian Astrophysical Observation", "SAO 248123"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.92048929),
        dec: Angle.Degrees(-65.93227482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103602"},
        {"Hipparcos Number", "HIP 58154"},
        {"Renson", "Renson 29870"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.89926580),
        dec: Angle.Degrees(-65.93046300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24814"},
        {"Hipparcos Number", "HIP 18121"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.12032688),
        dec: Angle.Degrees(-65.92588602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113376"},
        {"Hipparcos Number", "HIP 63797"},
        {"Geneva Identification System", "GEN# +1.00113376"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.12926572),
        dec: Angle.Degrees(-65.92176130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7174"},
        {"Hipparcos Number", "HIP 5514"},
        {"Geneva Identification System", "GEN# +1.00007174"},
        {"Smithsonian Astrophysical Observation", "SAO 248332"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.64846759),
        dec: Angle.Degrees(-65.92173995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19829"},
        {"Hipparcos Number", "HIP 14540"},
        {"Geneva Identification System", "GEN# +1.00019829"},
        {"Smithsonian Astrophysical Observation", "SAO 248739"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.93570485),
        dec: Angle.Degrees(-65.91980096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87408"},
        {"Hipparcos Number", "HIP 49184"},
        {"Smithsonian Astrophysical Observation", "SAO 250785"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.56924232),
        dec: Angle.Degrees(-65.91804185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93684"},
        {"Hipparcos Number", "HIP 52766"},
        {"Celescope Catalog", "CEL 3710"},
        {"Geneva Identification System", "GEN# +1.00093684"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.83610840),
        dec: Angle.Degrees(-65.91773053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62064"},
        {"Hipparcos Number", "HIP 37117"},
        {"Smithsonian Astrophysical Observation", "SAO 249902"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.40215941),
        dec: Angle.Degrees(-65.91709109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158043"},
        {"Hipparcos Number", "HIP 85791"},
        {"Geneva Identification System", "GEN# +1.00158043"},
        {"Smithsonian Astrophysical Observation", "SAO 253947"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.95891738),
        dec: Angle.Degrees(-65.91701671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115611"},
        {"Hipparcos Number", "HIP 65027"},
        {"Geneva Identification System", "GEN# +1.00115611"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.94143824),
        dec: Angle.Degrees(-65.91678000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69747"},
        {"Hipparcos Number", "HIP 40339"},
        {"Smithsonian Astrophysical Observation", "SAO 250163"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.54314160),
        dec: Angle.Degrees(-65.91614890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129629"},
        {"Hipparcos Number", "HIP 72272"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.70020465),
        dec: Angle.Degrees(-65.91534394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41697"},
    },
    visualMagnitude: 12.00,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.51571203),
        dec: Angle.Degrees(-65.91504168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193233"},
        {"Hipparcos Number", "HIP 100537"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.79100956),
        dec: Angle.Degrees(-65.91472074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184327"},
        {"Hipparcos Number", "HIP 96610"},
        {"Smithsonian Astrophysical Observation", "SAO 254610"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.62167294),
        dec: Angle.Degrees(-65.91423825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132224"},
        {"Hipparcos Number", "HIP 73504"},
        {"Smithsonian Astrophysical Observation", "SAO 252992"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.35690388),
        dec: Angle.Degrees(-65.91400887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51772"},
        {"Hipparcos Number", "HIP 33107"},
        {"Smithsonian Astrophysical Observation", "SAO 249673"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.43455537),
        dec: Angle.Degrees(-65.91389952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157119"},
        {"Hipparcos Number", "HIP 85324"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.54990252),
        dec: Angle.Degrees(-65.91238134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12778"},
        {"Hipparcos Number", "HIP 9547"},
        {"Smithsonian Astrophysical Observation", "SAO 248487"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.67517913),
        dec: Angle.Degrees(-65.88431273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2514"},
        {"Hipparcos Number", "HIP 2228"},
        {"Renson", "Renson 590"},
        {"Smithsonian Astrophysical Observation", "SAO 248193"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.06035880),
        dec: Angle.Degrees(-65.91217416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27567"},
        {"Hipparcos Number", "HIP 19935"},
        {"Smithsonian Astrophysical Observation", "SAO 248979"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.14084973),
        dec: Angle.Degrees(-65.91141567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78273"},
        {"Hipparcos Number", "HIP 44484"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.95398957),
        dec: Angle.Degrees(-65.90967701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53500"},
        {"Hipparcos Number", "HIP 33733"},
        {"Smithsonian Astrophysical Observation", "SAO 249708"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.11578874),
        dec: Angle.Degrees(-65.90901776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 131.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66110"},
        {"Hipparcos Number", "HIP 38902"},
        {"Smithsonian Astrophysical Observation", "SAO 250041"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.42319782),
        dec: Angle.Degrees(-65.90873924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43225"},
        {"Hipparcos Number", "HIP 29251"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.50886518),
        dec: Angle.Degrees(-65.90306957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141747"},
        {"Hipparcos Number", "HIP 77921"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.70197129),
        dec: Angle.Degrees(-65.90125859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105285"},
        {"Hipparcos Number", "HIP 59122"},
        {"Geneva Identification System", "GEN# +1.00105285"},
        {"Renson", "Renson 30450"},
        {"Smithsonian Astrophysical Observation", "SAO 251751"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.85777614),
        dec: Angle.Degrees(-65.89957268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128196"},
        {"Hipparcos Number", "HIP 71595"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.64128977),
        dec: Angle.Degrees(-65.89906206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219924"},
        {"Hipparcos Number", "HIP 115243"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.13957391),
        dec: Angle.Degrees(-65.89736767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142842"},
        {"Hipparcos Number", "HIP 78451"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.23940486),
        dec: Angle.Degrees(-65.89575352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97851"},
        {"Hipparcos Number", "HIP 54885"},
        {"Celescope Catalog", "CEL 3860"},
        {"Geneva Identification System", "GEN# +1.00097851"},
        {"Smithsonian Astrophysical Observation", "SAO 251328"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.57512601),
        dec: Angle.Degrees(-65.89123914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137345"},
        {"Hipparcos Number", "HIP 75815"},
        {"Smithsonian Astrophysical Observation", "SAO 253179"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.31579770),
        dec: Angle.Degrees(-65.89013632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171459"},
        {"Hipparcos Number", "HIP 91511"},
        {"Renson", "Renson 48050"},
        {"Smithsonian Astrophysical Observation", "SAO 254323"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.94884277),
        dec: Angle.Degrees(-65.88933662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20958"},
        {"Hipparcos Number", "HIP 15441"},
        {"Geneva Identification System", "GEN# +1.00020958"},
        {"Smithsonian Astrophysical Observation", "SAO 248778"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.75197975),
        dec: Angle.Degrees(-65.88794588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40624"},
        {"Hipparcos Number", "HIP 27966"},
        {"Smithsonian Astrophysical Observation", "SAO 249392"},
    },
    visualMagnitude: 7.92,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.73741242),
        dec: Angle.Degrees(-65.88357950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25527"},
        {"Hipparcos Number", "HIP 18605"},
        {"Fundamental Katalog 5th Edition", "FK5 4360"},
        {"Smithsonian Astrophysical Observation", "SAO 248921"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.71794693),
        dec: Angle.Degrees(-65.88142737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113807"},
        {"Hipparcos Number", "HIP 64054"},
        {"Geneva Identification System", "GEN# +1.00113807"},
        {"Smithsonian Astrophysical Observation", "SAO 252157"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.90937200),
        dec: Angle.Degrees(-65.87771608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177928"},
        {"Hipparcos Number", "HIP 94283"},
        {"Smithsonian Astrophysical Observation", "SAO 254485"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.85214832),
        dec: Angle.Degrees(-65.87683065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148753"},
        {"Hipparcos Number", "HIP 81174"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.70285494),
        dec: Angle.Degrees(-65.87620488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150336"},
        {"Hipparcos Number", "HIP 82004"},
        {"Geneva Identification System", "GEN# +1.00150336"},
        {"Smithsonian Astrophysical Observation", "SAO 253682"},
    },
    visualMagnitude: 8.93,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.27817819),
        dec: Angle.Degrees(-65.87346372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136506"},
        {"Hipparcos Number", "HIP 75440"},
        {"Smithsonian Astrophysical Observation", "SAO 253145"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.18798622),
        dec: Angle.Degrees(-65.87250831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75444"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.19876421),
        dec: Angle.Degrees(-65.87206921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5323"},
        {"Hipparcos Number", "HIP 4222"},
        {"Geneva Identification System", "GEN# +1.00005323"},
        {"Smithsonian Astrophysical Observation", "SAO 248277"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.46836353),
        dec: Angle.Degrees(-65.86732710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100431"},
        {"Hipparcos Number", "HIP 56313"},
        {"Geneva Identification System", "GEN# +1.00100431"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.17704080),
        dec: Angle.Degrees(-65.86343289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110079"},
        {"Hipparcos Number", "HIP 61838"},
        {"Geneva Identification System", "GEN# +1.00110079"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.08866206),
        dec: Angle.Degrees(-65.86212618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143494"},
        {"Hipparcos Number", "HIP 78772"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.23312192),
        dec: Angle.Degrees(-65.85905964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3921"},
        {"Hipparcos Number", "HIP 3209"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.20918153),
        dec: Angle.Degrees(-65.85744412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192356"},
        {"Hipparcos Number", "HIP 100117"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.64626116),
        dec: Angle.Degrees(-65.85726362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184996"},
        {"Hipparcos Number", "HIP 96882"},
        {"Geneva Identification System", "GEN# +1.00184996"},
        {"Smithsonian Astrophysical Observation", "SAO 254627"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.40518256),
        dec: Angle.Degrees(-65.85423920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129739"},
        {"Hipparcos Number", "HIP 72324"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.84432637),
        dec: Angle.Degrees(-65.85282438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95636"},
        {"Hipparcos Number", "HIP 53846"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.22951952),
        dec: Angle.Degrees(-65.84984789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119636"},
        {"Hipparcos Number", "HIP 67217"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.61635067),
        dec: Angle.Degrees(-65.84708529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87103"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.96145391),
        dec: Angle.Degrees(-65.84466426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116630"},
        {"Hipparcos Number", "HIP 65565"},
        {"Geneva Identification System", "GEN# +1.00116630"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.64503563),
        dec: Angle.Degrees(-65.84411761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107301"},
        {"Hipparcos Number", "HIP 60183"},
        {"Celescope Catalog", "CEL 4092"},
        {"Geneva Identification System", "GEN# +1.00107301"},
        {"Smithsonian Astrophysical Observation", "SAO 251854"},
        {"Wilson Evans Batten Catalogue", "WEB 10700"},
    },
    visualMagnitude: 6.20,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.11783762),
        dec: Angle.Degrees(-65.84263025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166178"},
        {"Hipparcos Number", "HIP 89378"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.59486160),
        dec: Angle.Degrees(-65.84097575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119889"},
        {"Hipparcos Number", "HIP 67330"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.00133797),
        dec: Angle.Degrees(-65.83945056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 523"},
        {"Cincinnati Publication", "Ci 20 8"},
        {"Geneva Identification System", "GEN# +6.20145153"},
    },
    visualMagnitude: 12.17,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.57876020),
        dec: Angle.Degrees(-65.83919547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -552.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107411"},
        {"Hipparcos Number", "HIP 60238"},
        {"Geneva Identification System", "GEN# +1.00107411"},
        {"Smithsonian Astrophysical Observation", "SAO 251858"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.28818876),
        dec: Angle.Degrees(-65.83574995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109801"},
        {"Hipparcos Number", "HIP 61646"},
        {"Geneva Identification System", "GEN# +1.00109801J"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.56789707),
        dec: Angle.Degrees(-65.83489106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99149"},
        {"Hipparcos Number", "HIP 55616"},
        {"Smithsonian Astrophysical Observation", "SAO 251385"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.91332533),
        dec: Angle.Degrees(-65.83447477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20449"},
        {"Hipparcos Number", "HIP 15031"},
        {"Smithsonian Astrophysical Observation", "SAO 248758"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.42446640),
        dec: Angle.Degrees(-65.83003609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221762"},
        {"Hipparcos Number", "HIP 116414"},
        {"Smithsonian Astrophysical Observation", "SAO 255521"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.85292713),
        dec: Angle.Degrees(-65.82914367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112067"},
        {"Hipparcos Number", "HIP 63021"},
        {"Smithsonian Astrophysical Observation", "SAO 252087"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.72215251),
        dec: Angle.Degrees(-65.82903275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125291"},
        {"Hipparcos Number", "HIP 70140"},
        {"Geneva Identification System", "GEN# +1.00125291"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.27884347),
        dec: Angle.Degrees(-65.82844977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98085"},
        {"Hipparcos Number", "HIP 55037"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.99850363),
        dec: Angle.Degrees(-65.82772937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225113"},
        {"Hipparcos Number", "HIP 284"},
        {"Smithsonian Astrophysical Observation", "SAO 248108"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.87833784),
        dec: Angle.Degrees(-65.82756660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148990"},
        {"Hipparcos Number", "HIP 81310"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.10204275),
        dec: Angle.Degrees(-65.82751278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75171"},
        {"Hipparcos Number", "HIP 42895"},
        {"Fundamental Katalog 5th Edition", "FK5 2691"},
        {"Geneva Identification System", "GEN# +1.00075171"},
        {"Smithsonian Astrophysical Observation", "SAO 250317"},
        {"Wilson Evans Batten Catalogue", "WEB 8288"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.12520012),
        dec: Angle.Degrees(-65.82568206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128384"},
        {"Hipparcos Number", "HIP 71674"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.90389825),
        dec: Angle.Degrees(-65.82437350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64426"},
        {"Hipparcos Number", "HIP 38176"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.34629002),
        dec: Angle.Degrees(-65.82431536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105523"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.58544843),
        dec: Angle.Degrees(-65.82167249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126241"},
        {"Hipparcos Number", "HIP 70657"},
        {"Fundamental Katalog 5th Edition", "FK5 3141"},
        {"Geneva Identification System", "GEN# +1.00126241"},
        {"Smithsonian Astrophysical Observation", "SAO 252745"},
    },
    visualMagnitude: 5.87,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.77963835),
        dec: Angle.Degrees(-65.82161161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123321"},
        {"Hipparcos Number", "HIP 69155"},
        {"Smithsonian Astrophysical Observation", "SAO 252626"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.34921738),
        dec: Angle.Degrees(-65.81986334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88323"},
        {"Hipparcos Number", "HIP 49698"},
        {"Geneva Identification System", "GEN# +1.00088323"},
        {"Smithsonian Astrophysical Observation", "SAO 250836"},
        {"Wilson Evans Batten Catalogue", "WEB 9164"},
    },
    visualMagnitude: 5.26,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.17849096),
        dec: Angle.Degrees(-65.81553262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194881"},
        {"Hipparcos Number", "HIP 101304"},
        {"Geneva Identification System", "GEN# +1.00194881"},
        {"Smithsonian Astrophysical Observation", "SAO 254807"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.00396209),
        dec: Angle.Degrees(-65.81512095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35918"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.06877178),
        dec: Angle.Degrees(-65.81287088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28554"},
        {"Hipparcos Number", "HIP 20645"},
        {"Smithsonian Astrophysical Observation", "SAO 249021"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.36540827),
        dec: Angle.Degrees(-65.81261595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71492"},
        {"Hipparcos Number", "HIP 41146"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.92571317),
        dec: Angle.Degrees(-65.81148921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204580"},
        {"Hipparcos Number", "HIP 106367"},
        {"Smithsonian Astrophysical Observation", "SAO 255018"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.15387337),
        dec: Angle.Degrees(-65.81128869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 271182"},
        {"Hipparcos Number", "HIP 24988"},
        {"Geneva Identification System", "GEN# +1.00271182"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.25711893),
        dec: Angle.Degrees(-65.80067327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121557"},
        {"Hipparcos Number", "HIP 68270"},
        {"Fundamental Katalog 5th Edition", "FK5 3110"},
        {"Geneva Identification System", "GEN# +1.00121557"},
        {"Smithsonian Astrophysical Observation", "SAO 252534"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.63034736),
        dec: Angle.Degrees(-65.80057278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200800"},
        {"Hipparcos Number", "HIP 104411"},
        {"Renson", "Renson 55990"},
        {"Smithsonian Astrophysical Observation", "SAO 254944"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.27278381),
        dec: Angle.Degrees(-65.79882039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88386"},
        {"Hipparcos Number", "HIP 49726"},
        {"Geneva Identification System", "GEN# +1.00088386"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.28446342),
        dec: Angle.Degrees(-65.79830736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131688"},
        {"Hipparcos Number", "HIP 73265"},
        {"Smithsonian Astrophysical Observation", "SAO 252973"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.60083219),
        dec: Angle.Degrees(-65.79687065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147569"},
        {"Hipparcos Number", "HIP 80575"},
    },
    visualMagnitude: 9.03,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.77426251),
        dec: Angle.Degrees(-65.79586196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130613"},
        {"Hipparcos Number", "HIP 72752"},
        {"Smithsonian Astrophysical Observation", "SAO 252924"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.09461478),
        dec: Angle.Degrees(-65.79363677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16391"},
        {"Hipparcos Number", "HIP 11988"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.65196510),
        dec: Angle.Degrees(-65.79095708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62919"},
        {"Hipparcos Number", "HIP 37496"},
        {"Smithsonian Astrophysical Observation", "SAO 249925"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.44125760),
        dec: Angle.Degrees(-65.78964228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21115"},
        {"Hipparcos Number", "HIP 15568"},
        {"Geneva Identification System", "GEN# +1.00021115"},
        {"Smithsonian Astrophysical Observation", "SAO 248782"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.14471412),
        dec: Angle.Degrees(-65.78606714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88509"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.10741536),
        dec: Angle.Degrees(-65.78424792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186684"},
        {"Hipparcos Number", "HIP 97605"},
        {"Geneva Identification System", "GEN# +1.00186684"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.57082321),
        dec: Angle.Degrees(-65.78303415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21321"},
        {"Hipparcos Number", "HIP 15719"},
        {"Renson", "Renson 5320"},
        {"Smithsonian Astrophysical Observation", "SAO 248789"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.61238863),
        dec: Angle.Degrees(-65.78167366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214510"},
        {"Hipparcos Number", "HIP 111926"},
        {"Smithsonian Astrophysical Observation", "SAO 255275"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.07720875),
        dec: Angle.Degrees(-65.77788349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135260"},
        {"Hipparcos Number", "HIP 74852"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.44465802),
        dec: Angle.Degrees(-65.77648735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224393"},
        {"Hipparcos Number", "HIP 118123"},
        {"Geneva Identification System", "GEN# +1.00224393"},
        {"Smithsonian Astrophysical Observation", "SAO 255608"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.39614258),
        dec: Angle.Degrees(-65.77549961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 261.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6726"},
        {"Geneva Identification System", "GEN# +6.00003209"},
    },
    visualMagnitude: 11.78,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.64473263),
        dec: Angle.Degrees(-65.77494930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45847"},
        {"Hipparcos Number", "HIP 30515"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.21410633),
        dec: Angle.Degrees(-65.77480944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13827"},
        {"Hipparcos Number", "HIP 10262"},
        {"Fundamental Katalog 5th Edition", "FK5 4203"},
        {"Smithsonian Astrophysical Observation", "SAO 248510"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.00783334),
        dec: Angle.Degrees(-65.77399708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120432"},
        {"Hipparcos Number", "HIP 67647"},
        {"Geneva Identification System", "GEN# +1.00120432"},
        {"Smithsonian Astrophysical Observation", "SAO 252482"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.89698183),
        dec: Angle.Degrees(-65.77313735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184022"},
        {"Hipparcos Number", "HIP 96476"},
        {"Geneva Identification System", "GEN# +1.00184022"},
        {"Smithsonian Astrophysical Observation", "SAO 254606"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.20572252),
        dec: Angle.Degrees(-65.77130570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5755"},
        {"Hipparcos Number", "HIP 4514"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.46853292),
        dec: Angle.Degrees(-65.77081752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108054"},
        {"Hipparcos Number", "HIP 60601"},
        {"Geneva Identification System", "GEN# +1.00108054"},
        {"Smithsonian Astrophysical Observation", "SAO 251893"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.32342553),
        dec: Angle.Degrees(-65.76961193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23342"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.31527912),
        dec: Angle.Degrees(-65.76854758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 322.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22634"},
        {"Hipparcos Number", "HIP 16661"},
        {"Geneva Identification System", "GEN# +1.00022634"},
        {"Renson", "Renson 5770"},
        {"Smithsonian Astrophysical Observation", "SAO 248842"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.60311790),
        dec: Angle.Degrees(-65.76425833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310797B"},
        {"Hipparcos Number", "HIP 57475"},
        {"Geneva Identification System", "GEN# -0.06501714B"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.72687889),
        dec: Angle.Degrees(-65.76323937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -496.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310797"},
        {"Hipparcos Number", "HIP 57473"},
        {"Cincinnati Publication", "Ci 20 661"},
        {"Geneva Identification System", "GEN# -0.06501714A"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.71771372),
        dec: Angle.Degrees(-65.76068418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -500.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115515"},
        {"Hipparcos Number", "HIP 64990"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.81526967),
        dec: Angle.Degrees(-65.75214984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1767"},
        {"Hipparcos Number", "HIP 1707"},
        {"Geneva Identification System", "GEN# +1.00001767"},
        {"Smithsonian Astrophysical Observation", "SAO 248169"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.37860588),
        dec: Angle.Degrees(-65.75166584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140018"},
        {"Hipparcos Number", "HIP 77173"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.36494547),
        dec: Angle.Degrees(-65.74973425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153985"},
        {"Hipparcos Number", "HIP 83787"},
        {"Geneva Identification System", "GEN# +1.00153985"},
        {"Smithsonian Astrophysical Observation", "SAO 253798"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.86255757),
        dec: Angle.Degrees(-65.74741250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147692"},
        {"Hipparcos Number", "HIP 80627"},
    },
    visualMagnitude: 9.37,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.94886121),
        dec: Angle.Degrees(-65.74418795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100213"},
        {"Hipparcos Number", "HIP 56196"},
        {"Celescope Catalog", "CEL 3910"},
        {"Geneva Identification System", "GEN# +1.00100213"},
        {"Smithsonian Astrophysical Observation", "SAO 251436"},
        {"Wilson Evans Batten Catalogue", "WEB 10095"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.79555863),
        dec: Angle.Degrees(-65.74224764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 271253"},
        {"Henry Draper 2", "HD 36316"},
        {"Hipparcos Number", "HIP 25389"},
        {"Geneva Identification System", "GEN# +1.00036316"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.47341285),
        dec: Angle.Degrees(-65.74220172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129842"},
        {"Hipparcos Number", "HIP 72383"},
        {"Geneva Identification System", "GEN# +1.00129842"},
        {"Smithsonian Astrophysical Observation", "SAO 252887"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.00309135),
        dec: Angle.Degrees(-65.73957531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78911"},
        {"Hipparcos Number", "HIP 44770"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.86875168),
        dec: Angle.Degrees(-65.73891774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98265"},
    },
    visualMagnitude: 12.55,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.50074410),
        dec: Angle.Degrees(-65.73602296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39014"},
        {"Hipparcos Number", "HIP 27100"},
        {"Fundamental Katalog 5th Edition", "FK5 1154"},
        {"Geneva Identification System", "GEN# +1.00039014"},
        {"Smithsonian Astrophysical Observation", "SAO 249346"},
        {"Wilson Evans Batten Catalogue", "WEB 5333"},
    },
    visualMagnitude: 4.34,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.19341279),
        dec: Angle.Degrees(-65.73554080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20966"},
        {"Hipparcos Number", "HIP 15445"},
        {"Fundamental Katalog 5th Edition", "FK5 4304"},
        {"Smithsonian Astrophysical Observation", "SAO 248779"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.79111040),
        dec: Angle.Degrees(-65.72805993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311201"},
        {"Hipparcos Number", "HIP 45202"},
        {"Smithsonian Astrophysical Observation", "SAO 250486"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.16806049),
        dec: Angle.Degrees(-65.72783410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122765"},
        {"Hipparcos Number", "HIP 68869"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.54161558),
        dec: Angle.Degrees(-65.72414135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181722"},
        {"Hipparcos Number", "HIP 95561"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.56111586),
        dec: Angle.Degrees(-65.72317668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147173"},
        {"Hipparcos Number", "HIP 80395"},
        {"Renson", "Renson 41580"},
        {"Smithsonian Astrophysical Observation", "SAO 253535"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.15131496),
        dec: Angle.Degrees(-65.72174948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162521"},
        {"Hipparcos Number", "HIP 87822"},
        {"Geneva Identification System", "GEN# +1.00162521"},
        {"Smithsonian Astrophysical Observation", "SAO 254079"},
        {"Wilson Evans Batten Catalogue", "WEB 14822"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.10073445),
        dec: Angle.Degrees(-65.72096439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -318.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219473"},
        {"Hipparcos Number", "HIP 114942"},
        {"Smithsonian Astrophysical Observation", "SAO 255443"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.21766249),
        dec: Angle.Degrees(-65.71998625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104651"},
        {"Hipparcos Number", "HIP 58754"},
        {"Geneva Identification System", "GEN# +1.00104651"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.75109183),
        dec: Angle.Degrees(-65.71524261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216013"},
        {"Hipparcos Number", "HIP 112816"},
        {"Geneva Identification System", "GEN# +1.00216013"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.69644605),
        dec: Angle.Degrees(-65.71438021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20875",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20875"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.09725437),
        dec: Angle.Degrees(-65.71335180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28887"},
        {"Hipparcos Number", "HIP 20869"},
        {"Smithsonian Astrophysical Observation", "SAO 249034"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.08854702),
        dec: Angle.Degrees(-65.71220818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146383"},
        {"Hipparcos Number", "HIP 80052"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.10247509),
        dec: Angle.Degrees(-65.71183535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107822"},
        {"Hipparcos Number", "HIP 60465"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.94056634),
        dec: Angle.Degrees(-65.71139584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109938"},
        {"Hipparcos Number", "HIP 61758"},
        {"Geneva Identification System", "GEN# +1.00109938"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.85648482),
        dec: Angle.Degrees(-65.71025490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27690"},
        {"Hipparcos Number", "HIP 20026"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.43056725),
        dec: Angle.Degrees(-65.71002906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59050"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.59618267),
        dec: Angle.Degrees(-65.70942594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53658"},
        {"Hipparcos Number", "HIP 33802"},
        {"Geneva Identification System", "GEN# +1.00053658"},
        {"Smithsonian Astrophysical Observation", "SAO 249715"},
        {"Wilson Evans Batten Catalogue", "WEB 6787"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.27332401),
        dec: Angle.Degrees(-65.70665915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134400"},
        {"Hipparcos Number", "HIP 74484"},
        {"Smithsonian Astrophysical Observation", "SAO 253058"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.29500244),
        dec: Angle.Degrees(-65.70665833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89009"},
        {"Hipparcos Number", "HIP 50107"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.45177062),
        dec: Angle.Degrees(-65.70654050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90874"},
        {"Hipparcos Number", "HIP 51194"},
        {"Geneva Identification System", "GEN# +1.00090874"},
        {"Smithsonian Astrophysical Observation", "SAO 250966"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.85583147),
        dec: Angle.Degrees(-65.70471390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117327"},
        {"Hipparcos Number", "HIP 65958"},
        {"Geneva Identification System", "GEN# +1.00117327"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.85036499),
        dec: Angle.Degrees(-65.70261391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156709"},
        {"Hipparcos Number", "HIP 85138"},
        {"Smithsonian Astrophysical Observation", "SAO 253899"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.99010550),
        dec: Angle.Degrees(-65.70210357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124197"},
        {"Hipparcos Number", "HIP 69591"},
        {"Geneva Identification System", "GEN# +1.00124197J"},
        {"Smithsonian Astrophysical Observation", "SAO 252661"},
        {"Wilson Evans Batten Catalogue", "WEB 12116"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.66527474),
        dec: Angle.Degrees(-65.70137376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114503"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.85497664),
        dec: Angle.Degrees(-65.70101708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75187"},
        {"Hipparcos Number", "HIP 42907"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.16570125),
        dec: Angle.Degrees(-65.69618388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182333"},
        {"Hipparcos Number", "HIP 95778"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.20341788),
        dec: Angle.Degrees(-65.69580647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91005"},
        {"Hipparcos Number", "HIP 51270"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.09263030),
        dec: Angle.Degrees(-65.69420599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106797"},
        {"Hipparcos Number", "HIP 59898"},
        {"Celescope Catalog", "CEL 4086"},
        {"Geneva Identification System", "GEN# +1.00106797"},
        {"Smithsonian Astrophysical Observation", "SAO 251826"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.27651740),
        dec: Angle.Degrees(-65.69293557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87529"},
        {"Hipparcos Number", "HIP 49243"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.78366859),
        dec: Angle.Degrees(-65.69147265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107594"},
        {"Hipparcos Number", "HIP 60342"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.58680105),
        dec: Angle.Degrees(-65.69084294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12004"},
        {"Hipparcos Number", "HIP 8959"},
        {"Geneva Identification System", "GEN# +1.00012004"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.85194235),
        dec: Angle.Degrees(-65.69038100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90152"},
        {"Hipparcos Number", "HIP 50788"},
        {"Smithsonian Astrophysical Observation", "SAO 250934"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.54909092),
        dec: Angle.Degrees(-65.69029343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155022"},
        {"Hipparcos Number", "HIP 84285"},
        {"Smithsonian Astrophysical Observation", "SAO 253829"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.45289169),
        dec: Angle.Degrees(-65.68753274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130080"},
        {"Hipparcos Number", "HIP 72494"},
        {"Geneva Identification System", "GEN# +1.00130080"},
        {"Smithsonian Astrophysical Observation", "SAO 252901"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.35445139),
        dec: Angle.Degrees(-65.68152024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45751"},
        {"Hipparcos Number", "HIP 30467"},
        {"Geneva Identification System", "GEN# +1.00045751"},
        {"Smithsonian Astrophysical Observation", "SAO 249540"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.07336145),
        dec: Angle.Degrees(-65.67625265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110479"},
        {"Hipparcos Number", "HIP 62053"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.77966236),
        dec: Angle.Degrees(-65.67310777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71166"},
        {"Hipparcos Number", "HIP 40981"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.44387148),
        dec: Angle.Degrees(-65.67194295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210529"},
        {"Hipparcos Number", "HIP 109699"},
        {"Smithsonian Astrophysical Observation", "SAO 255172"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.30593693),
        dec: Angle.Degrees(-65.67182619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120890"},
        {"Hipparcos Number", "HIP 67907"},
        {"Smithsonian Astrophysical Observation", "SAO 252508"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.62717523),
        dec: Angle.Degrees(-65.67019477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73015"},
        {"Hipparcos Number", "HIP 41859"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.02034326),
        dec: Angle.Degrees(-65.66859340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209467"},
        {"Hipparcos Number", "HIP 109107"},
        {"Geneva Identification System", "GEN# +1.00209467"},
        {"Smithsonian Astrophysical Observation", "SAO 255142"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.51624997),
        dec: Angle.Degrees(-65.66823656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270920"},
        {"Hipparcos Number", "HIP 23177"},
        {"Geneva Identification System", "GEN# +6.20012064"},
        {"Geneva Identification System 2", "GEN# +1.00270920"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.78774371),
        dec: Angle.Degrees(-65.66770143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30073"},
        {"Hipparcos Number", "HIP 21713"},
        {"Smithsonian Astrophysical Observation", "SAO 249075"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.93068865),
        dec: Angle.Degrees(-65.66630873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217240"},
        {"Hipparcos Number", "HIP 113612"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.16291132),
        dec: Angle.Degrees(-65.66461661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106944"},
        {"Hipparcos Number", "HIP 59985"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.54444187),
        dec: Angle.Degrees(-65.66279492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139072"},
        {"Hipparcos Number", "HIP 76723"},
        {"Smithsonian Astrophysical Observation", "SAO 253244"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.01202551),
        dec: Angle.Degrees(-65.66166661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1371"},
        {"Hipparcos Number", "HIP 1396"},
        {"Smithsonian Astrophysical Observation", "SAO 248153"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.36718940),
        dec: Angle.Degrees(-65.66134075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70334"},
        {"Hipparcos Number", "HIP 40585"},
        {"Smithsonian Astrophysical Observation", "SAO 250177"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.30033961),
        dec: Angle.Degrees(-65.65721286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101174"},
        {"Hipparcos Number", "HIP 56743"},
        {"Celescope Catalog", "CEL 3935"},
        {"Geneva Identification System", "GEN# +1.00101174"},
        {"Smithsonian Astrophysical Observation", "SAO 251504"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.51588282),
        dec: Angle.Degrees(-65.65586768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143185"},
        {"Hipparcos Number", "HIP 78629"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.78014189),
        dec: Angle.Degrees(-65.65551961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6221"},
        {"Hipparcos Number", "HIP 4822"},
        {"Smithsonian Astrophysical Observation", "SAO 248307"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.47335723),
        dec: Angle.Degrees(-65.65403118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153469"},
        {"Hipparcos Number", "HIP 83534"},
        {"Smithsonian Astrophysical Observation", "SAO 253785"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.09973428),
        dec: Angle.Degrees(-65.65099386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28644"},
        {"Hipparcos Number", "HIP 20714"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.58679035),
        dec: Angle.Degrees(-65.65074873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179776"},
        {"Hipparcos Number", "HIP 94882"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.62679837),
        dec: Angle.Degrees(-65.64905228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4308"},
        {"Hipparcos Number", "HIP 3497"},
        {"Cincinnati Publication", "Ci 20 53"},
        {"Geneva Identification System", "GEN# +1.00004308"},
        {"Smithsonian Astrophysical Observation", "SAO 248244"},
        {"Wilson Evans Batten Catalogue", "WEB 617"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.16268466),
        dec: Angle.Degrees(-65.64771794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -742.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25040"},
    },
    visualMagnitude: 12.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.43079981),
        dec: Angle.Degrees(-65.64752596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112410"},
        {"Hipparcos Number", "HIP 63242"},
        {"Smithsonian Astrophysical Observation", "SAO 252106"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.38355527),
        dec: Angle.Degrees(-65.64653767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22367"},
        {"Hipparcos Number", "HIP 16457"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.00289009),
        dec: Angle.Degrees(-65.64541925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 271190"},
        {"Hipparcos Number", "HIP 25039"},
        {"Geneva Identification System", "GEN# +1.00271190"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.42792982),
        dec: Angle.Degrees(-65.64143723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65897"},
        {"Hipparcos Number", "HIP 38815"},
        {"Smithsonian Astrophysical Observation", "SAO 250025"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.15874819),
        dec: Angle.Degrees(-65.61395927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121544"},
        {"Hipparcos Number", "HIP 68248"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.58448514),
        dec: Angle.Degrees(-65.64141432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223452"},
        {"Hipparcos Number", "HIP 117516"},
        {"Geneva Identification System", "GEN# +1.00223452"},
        {"Renson", "Renson 61220"},
        {"Smithsonian Astrophysical Observation", "SAO 255579"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.47912747),
        dec: Angle.Degrees(-65.64114625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16255"},
        {"Hipparcos Number", "HIP 11893"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.35117598),
        dec: Angle.Degrees(-65.63961020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116629"},
        {"Hipparcos Number", "HIP 65562"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.63375835),
        dec: Angle.Degrees(-65.63922742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104632"},
        {"Hipparcos Number", "HIP 58738"},
        {"Geneva Identification System", "GEN# +1.00104632"},
        {"Smithsonian Astrophysical Observation", "SAO 251701"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.71078219),
        dec: Angle.Degrees(-65.63798431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17528"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.29780120),
        dec: Angle.Degrees(-65.63272183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117651"},
        {"Hipparcos Number", "HIP 66152"},
        {"Geneva Identification System", "GEN# +1.00117651"},
        {"Renson", "Renson 33920"},
        {"Smithsonian Astrophysical Observation", "SAO 252361"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.39966813),
        dec: Angle.Degrees(-65.63262230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61969"},
        {"Hipparcos Number", "HIP 37082"},
        {"Smithsonian Astrophysical Observation", "SAO 249897"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.30217965),
        dec: Angle.Degrees(-65.62981963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27607"},
        {"Hipparcos Number", "HIP 19962"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.20588728),
        dec: Angle.Degrees(-65.62980802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201209"},
        {"Hipparcos Number", "HIP 104598"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.83929125),
        dec: Angle.Degrees(-65.62901047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123297"},
        {"Hipparcos Number", "HIP 69137"},
        {"Geneva Identification System", "GEN# +1.00123297"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.28791283),
        dec: Angle.Degrees(-65.62249378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -289.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100445"},
        {"Hipparcos Number", "HIP 56316"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.18948581),
        dec: Angle.Degrees(-65.62178696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212210"},
        {"Hipparcos Number", "HIP 110630"},
        {"Smithsonian Astrophysical Observation", "SAO 255214"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.16574481),
        dec: Angle.Degrees(-65.62143575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51269"},
        {"Hipparcos Number", "HIP 32950"},
        {"Smithsonian Astrophysical Observation", "SAO 249666"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.95408991),
        dec: Angle.Degrees(-65.61960190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93506"},
        {"Hipparcos Number", "HIP 52656"},
        {"Geneva Identification System", "GEN# +1.00093506"},
    },
    visualMagnitude: 8.71,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.51264131),
        dec: Angle.Degrees(-65.61465428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60710"},
        {"Hipparcos Number", "HIP 36567"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.82671671),
        dec: Angle.Degrees(-65.61450871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70514"},
        {"Hipparcos Number", "HIP 40680"},
        {"Geneva Identification System", "GEN# +1.00070514"},
        {"Smithsonian Astrophysical Observation", "SAO 250186"},
        {"Wilson Evans Batten Catalogue", "WEB 7905"},
    },
    visualMagnitude: 5.06,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.57823985),
        dec: Angle.Degrees(-65.61324550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138498"},
        {"Hipparcos Number", "HIP 76407"},
        {"Geneva Identification System", "GEN# +1.00138498"},
        {"Smithsonian Astrophysical Observation", "SAO 253222"},
        {"Wilson Evans Batten Catalogue", "WEB 12973"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.07405658),
        dec: Angle.Degrees(-65.61314236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16322"},
        {"Hipparcos Number", "HIP 11934"},
        {"Smithsonian Astrophysical Observation", "SAO 248601"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.50452822),
        dec: Angle.Degrees(-65.60958321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4125"},
        {"Hipparcos Number", "HIP 3351"},
        {"Smithsonian Astrophysical Observation", "SAO 248239"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.67217785),
        dec: Angle.Degrees(-65.60848571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107593"},
        {"Hipparcos Number", "HIP 60339"},
        {"Celescope Catalog", "CEL 4097"},
        {"Geneva Identification System", "GEN# +1.00107593"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.58254710),
        dec: Angle.Degrees(-65.60835772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126078"},
        {"Hipparcos Number", "HIP 70573"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.53345360),
        dec: Angle.Degrees(-65.60668398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10291"},
        {"Hipparcos Number", "HIP 7656"},
        {"Geneva Identification System", "GEN# +1.00010291"},
        {"Smithsonian Astrophysical Observation", "SAO 248413"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.64898871),
        dec: Angle.Degrees(-65.60643591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186786"},
        {"Hipparcos Number", "HIP 97674"},
        {"Geneva Identification System", "GEN# +1.00186786"},
        {"Smithsonian Astrophysical Observation", "SAO 254669"},
        {"Wilson Evans Batten Catalogue", "WEB 17175"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.75456049),
        dec: Angle.Degrees(-65.60470281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115195"},
        {"Hipparcos Number", "HIP 64814"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.26788288),
        dec: Angle.Degrees(-65.60462935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135396"},
        {"Hipparcos Number", "HIP 74898"},
        {"Geneva Identification System", "GEN# +1.00135396"},
        {"Renson", "Renson 38440"},
        {"Smithsonian Astrophysical Observation", "SAO 253093"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.60515254),
        dec: Angle.Degrees(-65.60398762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137626"},
        {"Hipparcos Number", "HIP 75961"},
        {"Geneva Identification System", "GEN# +1.00137626"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.70762253),
        dec: Angle.Degrees(-65.59931021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158950"},
        {"Hipparcos Number", "HIP 86195"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.21315644),
        dec: Angle.Degrees(-65.59894977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146096"},
        {"Hipparcos Number", "HIP 79920"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.68996532),
        dec: Angle.Degrees(-65.59870853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59761"},
        {"Hipparcos Number", "HIP 36155"},
        {"Geneva Identification System", "GEN# +1.00059761"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.73441211),
        dec: Angle.Degrees(-65.59756303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98811"},
        {"Cincinnati Publication", "Ci 20 1178"},
        {"Geneva Identification System", "GEN# +9.86115021"},
    },
    visualMagnitude: 11.35,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)04, 01.9100),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)35, 50.700)
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
    primaryId: "HIP 62555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111283"},
        {"Hipparcos Number", "HIP 62555"},
        {"Geneva Identification System", "GEN# +1.00111283J"},
        {"Smithsonian Astrophysical Observation", "SAO 252038"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.26038328),
        dec: Angle.Degrees(-65.59315691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102353"},
        {"Hipparcos Number", "HIP 57438"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.62663097),
        dec: Angle.Degrees(-65.59010080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43455"},
        {"Hipparcos Number", "HIP 29353"},
        {"Fundamental Katalog 5th Edition", "FK5 2473"},
        {"Geneva Identification System", "GEN# +1.00043455"},
        {"Smithsonian Astrophysical Observation", "SAO 249469"},
        {"Wilson Evans Batten Catalogue", "WEB 5764"},
    },
    visualMagnitude: 5.01,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.81256272),
        dec: Angle.Degrees(-65.58970507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149079"},
        {"Hipparcos Number", "HIP 81353"},
        {"Geneva Identification System", "GEN# +1.00149079"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.21505199),
        dec: Angle.Degrees(-65.58686975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193425"},
        {"Hipparcos Number", "HIP 100622"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.04916975),
        dec: Angle.Degrees(-65.58053053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219167"},
        {"Hipparcos Number", "HIP 114762"},
        {"Smithsonian Astrophysical Observation", "SAO 255438"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.70050952),
        dec: Angle.Degrees(-65.58044805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186218"},
        {"Hipparcos Number", "HIP 97371"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.85855085),
        dec: Angle.Degrees(-65.57877336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181018"},
        {"Hipparcos Number", "HIP 95304"},
        {"Renson", "Renson 50180"},
        {"Smithsonian Astrophysical Observation", "SAO 254547"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.84625578),
        dec: Angle.Degrees(-65.57876708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224686"},
        {"Hipparcos Number", "HIP 118322"},
        {"Fundamental Katalog 5th Edition", "FK5 903"},
        {"Geneva Identification System", "GEN# +1.00224686"},
        {"Smithsonian Astrophysical Observation", "SAO 255619"},
        {"Wilson Evans Batten Catalogue", "WEB 20795"},
    },
    visualMagnitude: 4.49,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.97879195),
        dec: Angle.Degrees(-65.57707774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26616"},
        {"Hipparcos Number", "HIP 19293"},
        {"Smithsonian Astrophysical Observation", "SAO 248950"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.04460493),
        dec: Angle.Degrees(-65.57690376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142436"},
        {"Hipparcos Number", "HIP 78256"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.66830812),
        dec: Angle.Degrees(-65.57566598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96265"},
        {"Hipparcos Number", "HIP 54151"},
        {"Smithsonian Astrophysical Observation", "SAO 251249"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.16284256),
        dec: Angle.Degrees(-65.57259335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161051"},
        {"Hipparcos Number", "HIP 87138"},
        {"Smithsonian Astrophysical Observation", "SAO 254037"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.06064802),
        dec: Angle.Degrees(-65.57063785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310238"},
        {"Hipparcos Number", "HIP 53138"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.04853212),
        dec: Angle.Degrees(-65.57004018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194353"},
        {"Hipparcos Number", "HIP 101049"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.26826780),
        dec: Angle.Degrees(-65.56980291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46730"},
        {"Hipparcos Number", "HIP 30973"},
        {"Fundamental Katalog 5th Edition", "FK5 2502"},
        {"Geneva Identification System", "GEN# +1.00046730"},
        {"Smithsonian Astrophysical Observation", "SAO 249568"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.51253886),
        dec: Angle.Degrees(-65.56838774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214068"},
        {"Hipparcos Number", "HIP 111690"},
        {"Smithsonian Astrophysical Observation", "SAO 255265"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.38200913),
        dec: Angle.Degrees(-65.56587025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8861"},
        {"Hipparcos Number", "HIP 6676"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.41198727),
        dec: Angle.Degrees(-65.56552684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220831"},
        {"Hipparcos Number", "HIP 115809"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.92656110),
        dec: Angle.Degrees(-65.56483546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15653"},
        {"Hipparcos Number", "HIP 11482"},
        {"Geneva Identification System", "GEN# +1.00015653"},
        {"Smithsonian Astrophysical Observation", "SAO 248571"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.03201996),
        dec: Angle.Degrees(-65.56294717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108464"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.59022899),
        dec: Angle.Degrees(-65.56201340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -287.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33895"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.53242864),
        dec: Angle.Degrees(-65.56078361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215562"},
        {"Hipparcos Number", "HIP 112533"},
        {"Fundamental Katalog 5th Edition", "FK5 3823"},
        {"Smithsonian Astrophysical Observation", "SAO 255316"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.89877427),
        dec: Angle.Degrees(-65.56023545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
