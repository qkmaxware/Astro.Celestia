using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_26() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92755"},
        {"Hipparcos Number", "HIP 52352"},
        {"Geneva Identification System", "GEN# +1.00092755"},
        {"Renson", "Renson 26770"},
        {"Smithsonian Astrophysical Observation", "SAO 222261"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.48364536),
        dec: Angle.Degrees(-40.69138713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73525"},
        {"Hipparcos Number", "HIP 42287"},
        {"Celescope Catalog", "CEL 2712"},
        {"Geneva Identification System", "GEN# +1.00073525"},
        {"Smithsonian Astrophysical Observation", "SAO 220192"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.32837868),
        dec: Angle.Degrees(-40.69138585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200262"},
        {"Hipparcos Number", "HIP 103958"},
        {"Geneva Identification System", "GEN# +1.00200262"},
        {"Smithsonian Astrophysical Observation", "SAO 230500"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.95378590),
        dec: Angle.Degrees(-40.69072346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224780"},
        {"Hipparcos Number", "HIP 48"},
        {"Smithsonian Astrophysical Observation", "SAO 231892"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.13522264),
        dec: Angle.Degrees(-40.69044664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120694"},
        {"Hipparcos Number", "HIP 67678"},
        {"Smithsonian Astrophysical Observation", "SAO 224495"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.97548638),
        dec: Angle.Degrees(-40.68938780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103017"},
        {"Hipparcos Number", "HIP 57826"},
        {"Geneva Identification System", "GEN# +1.00103017"},
        {"Smithsonian Astrophysical Observation", "SAO 223069"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.88294625),
        dec: Angle.Degrees(-40.68743297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222837"},
        {"Hipparcos Number", "HIP 117087"},
        {"Smithsonian Astrophysical Observation", "SAO 231758"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.04685940),
        dec: Angle.Degrees(-40.68589138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7469"},
        {"Hipparcos Number", "HIP 5780"},
        {"Smithsonian Astrophysical Observation", "SAO 215421"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.53890099),
        dec: Angle.Degrees(-40.68571607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81498"},
        {"Hipparcos Number", "HIP 46150"},
        {"Smithsonian Astrophysical Observation", "SAO 221141"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.17676824),
        dec: Angle.Degrees(-40.68482456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37852"},
        {"Hipparcos Number", "HIP 26621"},
        {"Geneva Identification System", "GEN# +1.00037852"},
        {"Smithsonian Astrophysical Observation", "SAO 217460"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.87690017),
        dec: Angle.Degrees(-40.68406902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113504"},
        {"Hipparcos Number", "HIP 63814"},
        {"Geneva Identification System", "GEN# +1.00113504"},
        {"Smithsonian Astrophysical Observation", "SAO 223879"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.18858824),
        dec: Angle.Degrees(-40.68251658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206236"},
        {"Hipparcos Number", "HIP 107115"},
        {"Smithsonian Astrophysical Observation", "SAO 230797"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.44703520),
        dec: Angle.Degrees(-40.68162167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205547"},
        {"Hipparcos Number", "HIP 106724"},
        {"Geneva Identification System", "GEN# +1.00205547"},
        {"Smithsonian Astrophysical Observation", "SAO 230758"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.27655064),
        dec: Angle.Degrees(-40.68130775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200261"},
        {"Hipparcos Number", "HIP 103951"},
        {"Geneva Identification System", "GEN# +1.00200261"},
        {"Smithsonian Astrophysical Observation", "SAO 230499"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.94138717),
        dec: Angle.Degrees(-40.68041967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205429"},
        {"Hipparcos Number", "HIP 106676"},
        {"Geneva Identification System", "GEN# +1.00205429J"},
        {"Smithsonian Astrophysical Observation", "SAO 230749"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.10044109),
        dec: Angle.Degrees(-40.67959827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84805"},
        {"Hipparcos Number", "HIP 47968"},
        {"Smithsonian Astrophysical Observation", "SAO 221482"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.64445612),
        dec: Angle.Degrees(-40.67944609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92298"},
        {"Hipparcos Number", "HIP 52109"},
        {"Renson", "Renson 26550"},
        {"Smithsonian Astrophysical Observation", "SAO 222219"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.70019161),
        dec: Angle.Degrees(-40.67204257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108033"},
        {"Hipparcos Number", "HIP 60563"},
        {"Geneva Identification System", "GEN# +1.00108033"},
        {"Smithsonian Astrophysical Observation", "SAO 223421"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.22220146),
        dec: Angle.Degrees(-40.67085387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180523"},
        {"Hipparcos Number", "HIP 94893"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.66303347),
        dec: Angle.Degrees(-40.66808982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79665"},
        {"Hipparcos Number", "HIP 45309"},
        {"Smithsonian Astrophysical Observation", "SAO 220968"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.52487397),
        dec: Angle.Degrees(-40.66701371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2608"},
        {"Hipparcos Number", "HIP 2304"},
        {"Smithsonian Astrophysical Observation", "SAO 215112"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.34634974),
        dec: Angle.Degrees(-40.66541214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17276"},
        {"Hipparcos Number", "HIP 12846"},
        {"Smithsonian Astrophysical Observation", "SAO 216031"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.28667929),
        dec: Angle.Degrees(-40.66470146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176406"},
        {"Hipparcos Number", "HIP 93458"},
        {"Smithsonian Astrophysical Observation", "SAO 229445"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.50722937),
        dec: Angle.Degrees(-40.66275506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219468"},
        {"Hipparcos Number", "HIP 114887"},
        {"Smithsonian Astrophysical Observation", "SAO 231527"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.07462851),
        dec: Angle.Degrees(-40.66234830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326748"},
        {"Hipparcos Number", "HIP 83471"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.89852740),
        dec: Angle.Degrees(-40.66093363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23508"},
        {"Hipparcos Number", "HIP 17436"},
        {"Geneva Identification System", "GEN# +1.00023508"},
        {"Smithsonian Astrophysical Observation", "SAO 216459"},
        {"Wilson Evans Batten Catalogue", "WEB 3301"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.02650052),
        dec: Angle.Degrees(-40.66008603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152623"},
        {"Hipparcos Number", "HIP 82876"},
        {"Celescope Catalog", "CEL 4459"},
        {"Geneva Identification System", "GEN# +1.00152623"},
        {"Smithsonian Astrophysical Observation", "SAO 227464"},
        {"New General Catalogue", "NGC 6231 334"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.06261639),
        dec: Angle.Degrees(-40.65993444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9262"},
        {"Hipparcos Number", "HIP 7017"},
        {"Smithsonian Astrophysical Observation", "SAO 215531"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.60390481),
        dec: Angle.Degrees(-40.65963971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137476"},
        {"Hipparcos Number", "HIP 75697"},
        {"Smithsonian Astrophysical Observation", "SAO 225811"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.96623531),
        dec: Angle.Degrees(-40.65962281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44058"},
        {"Hipparcos Number", "HIP 29893"},
        {"Smithsonian Astrophysical Observation", "SAO 217830"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.42012823),
        dec: Angle.Degrees(-40.65855228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200056"},
        {"Hipparcos Number", "HIP 103831"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.60600538),
        dec: Angle.Degrees(-40.65783910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56957"},
        {"Hipparcos Number", "HIP 35279"},
        {"Geneva Identification System", "GEN# +1.00056957"},
        {"Smithsonian Astrophysical Observation", "SAO 218604"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.32494998),
        dec: Angle.Degrees(-40.65683667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127215"},
        {"Hipparcos Number", "HIP 70998"},
        {"Geneva Identification System", "GEN# +1.00127215"},
        {"Smithsonian Astrophysical Observation", "SAO 224988"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.80997937),
        dec: Angle.Degrees(-40.65587667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207850"},
        {"Hipparcos Number", "HIP 108016"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.25039272),
        dec: Angle.Degrees(-40.65502797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103728"},
        {"Hipparcos Number", "HIP 58231"},
        {"Smithsonian Astrophysical Observation", "SAO 223124"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.15462552),
        dec: Angle.Degrees(-40.65420184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143084"},
        {"Hipparcos Number", "HIP 78367"},
        {"Geneva Identification System", "GEN# +1.00143084"},
        {"Smithsonian Astrophysical Observation", "SAO 226431"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.99101783),
        dec: Angle.Degrees(-40.65309068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39040"},
        {"Hipparcos Number", "HIP 27383"},
        {"Geneva Identification System", "GEN# +1.00039040"},
        {"Smithsonian Astrophysical Observation", "SAO 217543"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.99198888),
        dec: Angle.Degrees(-40.65301101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63640"},
        {"Hipparcos Number", "HIP 38074"},
        {"Geneva Identification System", "GEN# +1.00063640"},
        {"Smithsonian Astrophysical Observation", "SAO 219006"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.03562523),
        dec: Angle.Degrees(-40.65231342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11482"},
        {"Hipparcos Number", "HIP 8699"},
        {"Smithsonian Astrophysical Observation", "SAO 215682"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.98002877),
        dec: Angle.Degrees(-40.65116983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123258"},
        {"Hipparcos Number", "HIP 68996"},
        {"Smithsonian Astrophysical Observation", "SAO 224704"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.88876871),
        dec: Angle.Degrees(-40.65109907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 513"},
        {"Hipparcos Number", "HIP 774"},
        {"Smithsonian Astrophysical Observation", "SAO 214984"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.38423018),
        dec: Angle.Degrees(-40.64947224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82694"},
        {"Hipparcos Number", "HIP 46811"},
        {"Fundamental Katalog 5th Edition", "FK5 2759"},
        {"Geneva Identification System", "GEN# +1.00082694J"},
        {"Smithsonian Astrophysical Observation", "SAO 221262"},
        {"Wilson Evans Batten Catalogue", "WEB 8828"},
    },
    visualMagnitude: 5.35,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.08029475),
        dec: Angle.Degrees(-40.64932106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6354"},
        {"Hipparcos Number", "HIP 4985"},
        {"Smithsonian Astrophysical Observation", "SAO 215348"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.98163206),
        dec: Angle.Degrees(-40.64830312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148659"},
        {"Hipparcos Number", "HIP 80914"},
        {"Smithsonian Astrophysical Observation", "SAO 226847"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.84965264),
        dec: Angle.Degrees(-40.64775301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193042"},
        {"Hipparcos Number", "HIP 100229"},
        {"Smithsonian Astrophysical Observation", "SAO 230155"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.91551892),
        dec: Angle.Degrees(-40.64765280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136298"},
        {"Hipparcos Number", "HIP 75141"},
        {"Celescope Catalog", "CEL 4364"},
        {"Fundamental Katalog 5th Edition", "FK5 1402"},
        {"Geneva Identification System", "GEN# +1.00136298"},
        {"Smithsonian Astrophysical Observation", "SAO 225691"},
        {"Wilson Evans Batten Catalogue", "WEB 12818"},
    },
    visualMagnitude: 3.22,
    bvColour: -0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.34306833),
        dec: Angle.Degrees(-40.64745946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140499"},
        {"Hipparcos Number", "HIP 77166"},
        {"Smithsonian Astrophysical Observation", "SAO 226153"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.35563598),
        dec: Angle.Degrees(-40.64668924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 991"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.07628651),
        dec: Angle.Degrees(-40.64558079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24121"},
        {"Hipparcos Number", "HIP 17825"},
        {"Smithsonian Astrophysical Observation", "SAO 216500"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.21399379),
        dec: Angle.Degrees(-40.64320626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54038"},
        {"Hipparcos Number", "HIP 34201"},
        {"Geneva Identification System", "GEN# +1.00054038"},
        {"Smithsonian Astrophysical Observation", "SAO 218440"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.38635618),
        dec: Angle.Degrees(-40.64054547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88702"},
        {"Hipparcos Number", "HIP 50033"},
        {"Smithsonian Astrophysical Observation", "SAO 221861"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.22622323),
        dec: Angle.Degrees(-40.64046108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194529"},
        {"Hipparcos Number", "HIP 100915"},
        {"Smithsonian Astrophysical Observation", "SAO 230220"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.90714059),
        dec: Angle.Degrees(-40.63775706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164776"},
        {"Hipparcos Number", "HIP 88523"},
        {"Smithsonian Astrophysical Observation", "SAO 228675"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.15706077),
        dec: Angle.Degrees(-40.63754047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12069"},
        {"Hipparcos Number", "HIP 9120"},
        {"Geneva Identification System", "GEN# +1.00012069"},
        {"Smithsonian Astrophysical Observation", "SAO 215717"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.38446103),
        dec: Angle.Degrees(-40.63629991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84742"},
        {"Hipparcos Number", "HIP 47947"},
        {"Geneva Identification System", "GEN# +1.00084742"},
        {"Smithsonian Astrophysical Observation", "SAO 221477"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.55526786),
        dec: Angle.Degrees(-40.63591061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 323416"},
        {"Hipparcos Number", "HIP 85366"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.66064271),
        dec: Angle.Degrees(-40.63270982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22900"},
        {"Hipparcos Number", "HIP 17028"},
        {"Smithsonian Astrophysical Observation", "SAO 216425"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.75624646),
        dec: Angle.Degrees(-40.63125219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62541"},
        {"Hipparcos Number", "HIP 37572"},
        {"Celescope Catalog", "CEL 1993"},
        {"Smithsonian Astrophysical Observation", "SAO 218915"},
    },
    visualMagnitude: 8.96,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.66291270),
        dec: Angle.Degrees(-40.62649094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129280"},
        {"Hipparcos Number", "HIP 71950"},
        {"Smithsonian Astrophysical Observation", "SAO 225144"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.73513036),
        dec: Angle.Degrees(-40.62624732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84170"},
        {"Hipparcos Number", "HIP 47584"},
        {"Smithsonian Astrophysical Observation", "SAO 221413"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.53656941),
        dec: Angle.Degrees(-40.62357189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7052"},
        {"Hipparcos Number", "HIP 5490"},
        {"Geneva Identification System", "GEN# +1.00007052"},
        {"Smithsonian Astrophysical Observation", "SAO 215392"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.57014071),
        dec: Angle.Degrees(-40.62284209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175951"},
        {"Hipparcos Number", "HIP 93250"},
        {"Smithsonian Astrophysical Observation", "SAO 229423"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.92270393),
        dec: Angle.Degrees(-40.62269336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150456"},
        {"Hipparcos Number", "HIP 81832"},
        {"Smithsonian Astrophysical Observation", "SAO 227093"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.72304763),
        dec: Angle.Degrees(-40.62053366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4848"},
        {"Hipparcos Number", "HIP 3908"},
        {"Fundamental Katalog 5th Edition", "FK5 4073"},
        {"Smithsonian Astrophysical Observation", "SAO 215255"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.53144601),
        dec: Angle.Degrees(-40.61999334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196210"},
        {"Hipparcos Number", "HIP 101737"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.31384369),
        dec: Angle.Degrees(-40.61652121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123565"},
        {"Hipparcos Number", "HIP 69154"},
        {"Smithsonian Astrophysical Observation", "SAO 224728"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.34855645),
        dec: Angle.Degrees(-40.61630190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95347",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Rukbat"},
        {"Henry Draper", "HD 181869"},
        {"Hipparcos Number", "HIP 95347"},
        {"Fundamental Katalog 5th Edition", "FK5 728"},
        {"Geneva Identification System", "GEN# +1.00181869"},
        {"Smithsonian Astrophysical Observation", "SAO 229659"},
        {"Wilson Evans Batten Catalogue", "WEB 16665"},
    },
    visualMagnitude: 3.96,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.97146411),
        dec: Angle.Degrees(-40.61564629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74979"},
        {"Hipparcos Number", "HIP 42996"},
        {"Celescope Catalog", "CEL 2869"},
        {"Geneva Identification System", "GEN# +1.00074979"},
        {"Smithsonian Astrophysical Observation", "SAO 220409"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.44751420),
        dec: Angle.Degrees(-40.61558920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147328"},
        {"Hipparcos Number", "HIP 80251"},
        {"Geneva Identification System", "GEN# +2.61240001"},
        {"New General Catalogue", "NGC 6124 1"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.75406449),
        dec: Angle.Degrees(-40.61370250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142253"},
        {"Hipparcos Number", "HIP 77951"},
        {"Smithsonian Astrophysical Observation", "SAO 226359"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.78058367),
        dec: Angle.Degrees(-40.61261366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7358"},
        {"Hipparcos Number", "HIP 5686"},
        {"Smithsonian Astrophysical Observation", "SAO 215416"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.28793527),
        dec: Angle.Degrees(-40.61171752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119040"},
        {"Hipparcos Number", "HIP 66813"},
        {"Smithsonian Astrophysical Observation", "SAO 224341"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.42670777),
        dec: Angle.Degrees(-40.60952743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43678"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.47310188),
        dec: Angle.Degrees(-40.60877003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43684"},
    },
    visualMagnitude: 11.21,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.48155123),
        dec: Angle.Degrees(-40.60851571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128855"},
        {"Hipparcos Number", "HIP 71742"},
        {"Geneva Identification System", "GEN# +1.00128855"},
        {"Smithsonian Astrophysical Observation", "SAO 225111"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.12852939),
        dec: Angle.Degrees(-40.60805118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32804"},
        {"Hipparcos Number", "HIP 23553"},
        {"Smithsonian Astrophysical Observation", "SAO 217152"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.96974155),
        dec: Angle.Degrees(-40.60764290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198245"},
        {"Hipparcos Number", "HIP 102862"},
        {"Cincinnati Publication", "Ci 20 1231"},
        {"Geneva Identification System", "GEN# +1.00198245"},
        {"Smithsonian Astrophysical Observation", "SAO 230398"},
        {"Wilson Evans Batten Catalogue", "WEB 18660"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.59422993),
        dec: Angle.Degrees(-40.60737944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -448.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66077"},
        {"Hipparcos Number", "HIP 39126"},
        {"Smithsonian Astrophysical Observation", "SAO 219269"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.06483372),
        dec: Angle.Degrees(-40.60517587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 323631"},
        {"Hipparcos Number", "HIP 85774"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.89736040),
        dec: Angle.Degrees(-40.60340755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37225"},
        {"Hipparcos Number", "HIP 26193"},
        {"Smithsonian Astrophysical Observation", "SAO 217407"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.74739055),
        dec: Angle.Degrees(-40.60246762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87251"},
        {"Hipparcos Number", "HIP 49219"},
        {"Smithsonian Astrophysical Observation", "SAO 221721"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.70290127),
        dec: Angle.Degrees(-40.60098613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177613"},
        {"Hipparcos Number", "HIP 93912"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.83768618),
        dec: Angle.Degrees(-40.60026332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158288"},
        {"Hipparcos Number", "HIP 85663"},
        {"Smithsonian Astrophysical Observation", "SAO 228045"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.59216011),
        dec: Angle.Degrees(-40.59799040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172516"},
        {"Hipparcos Number", "HIP 91737"},
        {"Smithsonian Astrophysical Observation", "SAO 229217"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.60802541),
        dec: Angle.Degrees(-40.59664957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127256"},
        {"Hipparcos Number", "HIP 71014"},
        {"Smithsonian Astrophysical Observation", "SAO 224991"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.85586274),
        dec: Angle.Degrees(-40.59557223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219596"},
        {"Hipparcos Number", "HIP 114979"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.31806220),
        dec: Angle.Degrees(-40.59268649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63987"},
        {"Hipparcos Number", "HIP 38227"},
        {"Smithsonian Astrophysical Observation", "SAO 219046"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.47824216),
        dec: Angle.Degrees(-40.59229234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218655"},
        {"Hipparcos Number", "HIP 114407"},
        {"Geneva Identification System", "GEN# +1.00218655"},
        {"Smithsonian Astrophysical Observation", "SAO 231465"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.54049559),
        dec: Angle.Degrees(-40.59143612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224705"},
        {"Hipparcos Number", "HIP 5"},
        {"Smithsonian Astrophysical Observation", "SAO 231883"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.00996534),
        dec: Angle.Degrees(-40.59122440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214150"},
        {"Hipparcos Number", "HIP 111643"},
        {"Geneva Identification System", "GEN# +1.00214150"},
        {"Smithsonian Astrophysical Observation", "SAO 231217"},
        {"Wilson Evans Batten Catalogue", "WEB 19955"},
    },
    visualMagnitude: 5.85,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.24508293),
        dec: Angle.Degrees(-40.59086511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124029"},
        {"Hipparcos Number", "HIP 69372"},
        {"Smithsonian Astrophysical Observation", "SAO 224759"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.01012594),
        dec: Angle.Degrees(-40.59048870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29653"},
        {"Hipparcos Number", "HIP 21613"},
        {"Smithsonian Astrophysical Observation", "SAO 216910"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.59781550),
        dec: Angle.Degrees(-40.58986085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147653"},
        {"Hipparcos Number", "HIP 80418"},
        {"Geneva Identification System", "GEN# +2.61240015"},
        {"Smithsonian Astrophysical Observation", "SAO 226734"},
        {"New General Catalogue", "NGC 6124 15"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.21007667),
        dec: Angle.Degrees(-40.58970355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133022"},
        {"Hipparcos Number", "HIP 73667"},
        {"Smithsonian Astrophysical Observation", "SAO 225407"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.88334965),
        dec: Angle.Degrees(-40.58965837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100493"},
        {"Hipparcos Number", "HIP 56391"},
        {"Geneva Identification System", "GEN# +1.00100493"},
        {"Smithsonian Astrophysical Observation", "SAO 222863"},
        {"Wilson Evans Batten Catalogue", "WEB 10133"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.40526595),
        dec: Angle.Degrees(-40.58670322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47908"},
        {"Hipparcos Number", "HIP 31800"},
        {"Geneva Identification System", "GEN# +1.00047908"},
        {"Smithsonian Astrophysical Observation", "SAO 218094"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.73074807),
        dec: Angle.Degrees(-40.58572479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174291"},
        {"Hipparcos Number", "HIP 92558"},
        {"Geneva Identification System", "GEN# +1.00174291"},
        {"Smithsonian Astrophysical Observation", "SAO 229328"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.91963053),
        dec: Angle.Degrees(-40.58532961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218086"},
        {"Hipparcos Number", "HIP 114043"},
        {"Smithsonian Astrophysical Observation", "SAO 231431"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.42074660),
        dec: Angle.Degrees(-40.58433045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133880"},
        {"Hipparcos Number", "HIP 74066"},
        {"Celescope Catalog", "CEL 4340"},
        {"Fundamental Katalog 5th Edition", "FK5 3194"},
        {"Geneva Identification System", "GEN# +1.00133880"},
        {"Renson", "Renson 38010"},
        {"Smithsonian Astrophysical Observation", "SAO 225474"},
        {"Wilson Evans Batten Catalogue", "WEB 12650"},
    },
    visualMagnitude: 5.75,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.05061050),
        dec: Angle.Degrees(-40.58385604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214085"},
        {"Hipparcos Number", "HIP 111594"},
        {"Fundamental Katalog 5th Edition", "FK5 3811"},
        {"Geneva Identification System", "GEN# +1.00214085"},
        {"Smithsonian Astrophysical Observation", "SAO 231211"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.12196771),
        dec: Angle.Degrees(-40.58251333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175263"},
        {"Hipparcos Number", "HIP 92971"},
        {"Smithsonian Astrophysical Observation", "SAO 229389"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.11289785),
        dec: Angle.Degrees(-40.58218345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65314"},
        {"Hipparcos Number", "HIP 38799"},
        {"Geneva Identification System", "GEN# +1.00065314"},
        {"Smithsonian Astrophysical Observation", "SAO 219170"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.11100909),
        dec: Angle.Degrees(-40.58182047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174872"},
        {"Hipparcos Number", "HIP 92812"},
        {"Geneva Identification System", "GEN# +1.00174872"},
        {"Smithsonian Astrophysical Observation", "SAO 229367"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.66668150),
        dec: Angle.Degrees(-40.58009417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145903"},
        {"Hipparcos Number", "HIP 79640"},
        {"Smithsonian Astrophysical Observation", "SAO 226601"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.78170173),
        dec: Angle.Degrees(-40.57738202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64440"},
        {"Hipparcos Number", "HIP 38414"},
        {"Celescope Catalog", "CEL 2069"},
        {"Fundamental Katalog 5th Edition", "FK5 301"},
        {"Geneva Identification System", "GEN# +1.00064440"},
        {"Smithsonian Astrophysical Observation", "SAO 219082"},
        {"Wilson Evans Batten Catalogue", "WEB 7555"},
    },
    visualMagnitude: 3.71,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.05435622),
        dec: Angle.Degrees(-40.57579889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86862"},
        {"Hipparcos Number", "HIP 49043"},
        {"Smithsonian Astrophysical Observation", "SAO 221686"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.09629537),
        dec: Angle.Degrees(-40.57576598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196781"},
        {"Hipparcos Number", "HIP 102063"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.25489646),
        dec: Angle.Degrees(-40.57492319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101680"},
        {"Hipparcos Number", "HIP 57059"},
        {"Geneva Identification System", "GEN# +1.00101680"},
        {"Smithsonian Astrophysical Observation", "SAO 222964"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.45646876),
        dec: Angle.Degrees(-40.57350719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -308.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94891"},
        {"Hipparcos Number", "HIP 53506"},
        {"Geneva Identification System", "GEN# +1.00094891"},
        {"Smithsonian Astrophysical Observation", "SAO 222442"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.18575861),
        dec: Angle.Degrees(-40.57311490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207790"},
        {"Hipparcos Number", "HIP 107981"},
        {"Geneva Identification System", "GEN# +1.00207790"},
        {"Smithsonian Astrophysical Observation", "SAO 230877"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.13163522),
        dec: Angle.Degrees(-40.57250067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46259"},
        {"Hipparcos Number", "HIP 31016"},
        {"Smithsonian Astrophysical Observation", "SAO 217979"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.62309036),
        dec: Angle.Degrees(-40.57246750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6777"},
        {"Hipparcos Number", "HIP 5314"},
        {"Smithsonian Astrophysical Observation", "SAO 215376"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.99498801),
        dec: Angle.Degrees(-40.57242041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89398"},
        {"Hipparcos Number", "HIP 50452"},
        {"Smithsonian Astrophysical Observation", "SAO 221942"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.52358011),
        dec: Angle.Degrees(-40.57118110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83974"},
        {"Hipparcos Number", "HIP 47486"},
        {"Geneva Identification System", "GEN# +1.00083974"},
        {"Smithsonian Astrophysical Observation", "SAO 221396"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.20255078),
        dec: Angle.Degrees(-40.55475384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32946"},
        {"Hipparcos Number", "HIP 23644"},
        {"Smithsonian Astrophysical Observation", "SAO 217161"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.22739483),
        dec: Angle.Degrees(-40.57055714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198954"},
        {"Hipparcos Number", "HIP 103267"},
        {"Smithsonian Astrophysical Observation", "SAO 230438"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.81465650),
        dec: Angle.Degrees(-40.57051173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98285"},
        {"Hipparcos Number", "HIP 55185"},
        {"Smithsonian Astrophysical Observation", "SAO 222704"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.48339613),
        dec: Angle.Degrees(-40.57001760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141009"},
        {"Hipparcos Number", "HIP 77414"},
        {"Smithsonian Astrophysical Observation", "SAO 226225"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.06007213),
        dec: Angle.Degrees(-40.57001246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21503"},
        {"Hipparcos Number", "HIP 16037"},
        {"Smithsonian Astrophysical Observation", "SAO 216321"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.63769780),
        dec: Angle.Degrees(-40.56976766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133321"},
        {"Hipparcos Number", "HIP 73811"},
        {"Smithsonian Astrophysical Observation", "SAO 225432"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.29207108),
        dec: Angle.Degrees(-40.56932723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168995"},
        {"Hipparcos Number", "HIP 90203"},
        {"Smithsonian Astrophysical Observation", "SAO 228988"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.08570991),
        dec: Angle.Degrees(-40.56854451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156641"},
        {"Hipparcos Number", "HIP 84860"},
        {"Smithsonian Astrophysical Observation", "SAO 227842"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.15896740),
        dec: Angle.Degrees(-40.56710502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74399"},
        {"Hipparcos Number", "HIP 42721"},
        {"Smithsonian Astrophysical Observation", "SAO 220308"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.59463036),
        dec: Angle.Degrees(-40.56424453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207798"},
        {"Hipparcos Number", "HIP 107988"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.16201379),
        dec: Angle.Degrees(-40.56296610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43239"},
        {"Hipparcos Number", "HIP 29530"},
        {"Smithsonian Astrophysical Observation", "SAO 217785"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.31592491),
        dec: Angle.Degrees(-40.56172051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80623"},
        {"Hipparcos Number", "HIP 45741"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.88336928),
        dec: Angle.Degrees(-40.56160995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33680"},
        {"Hipparcos Number", "HIP 24038"},
        {"Smithsonian Astrophysical Observation", "SAO 217208"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.51003968),
        dec: Angle.Degrees(-40.55952157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87922"},
    },
    visualMagnitude: 11.44,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.41106720),
        dec: Angle.Degrees(-40.55754144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195599"},
        {"Hipparcos Number", "HIP 101465"},
        {"Smithsonian Astrophysical Observation", "SAO 230275"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.44516198),
        dec: Angle.Degrees(-40.55718804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148023"},
        {"Hipparcos Number", "HIP 80574"},
        {"Geneva Identification System", "GEN# +2.61240043"},
        {"Smithsonian Astrophysical Observation", "SAO 226775"},
        {"New General Catalogue", "NGC 6124 43"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.76843939),
        dec: Angle.Degrees(-40.55473210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77581"},
        {"Hipparcos Number", "HIP 44368"},
        {"Geneva Identification System", "GEN# +1.00077581"},
        {"Smithsonian Astrophysical Observation", "SAO 220767"},
        {"Wilson Evans Batten Catalogue", "WEB 8506"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.52860251),
        dec: Angle.Degrees(-40.55471679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104385"},
        {"Hipparcos Number", "HIP 58614"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.30348055),
        dec: Angle.Degrees(-40.55262692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31986"},
        {"Hipparcos Number", "HIP 23097"},
        {"Smithsonian Astrophysical Observation", "SAO 217088"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.54885425),
        dec: Angle.Degrees(-40.55170653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 133.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155827"},
        {"Hipparcos Number", "HIP 84442"},
        {"Geneva Identification System", "GEN# +1.00155827"},
        {"Smithsonian Astrophysical Observation", "SAO 227757"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.95801803),
        dec: Angle.Degrees(-40.55138347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62912"},
        {"Hipparcos Number", "HIP 37739"},
        {"Smithsonian Astrophysical Observation", "SAO 218946"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.11187323),
        dec: Angle.Degrees(-40.55038587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50446"},
        {"Hipparcos Number", "HIP 32910"},
        {"Celescope Catalog", "CEL 1412"},
        {"Geneva Identification System", "GEN# +1.00050446"},
        {"Smithsonian Astrophysical Observation", "SAO 218253"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.85828585),
        dec: Angle.Degrees(-40.55026815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7502"},
        {"Hipparcos Number", "HIP 5810"},
        {"Smithsonian Astrophysical Observation", "SAO 215423"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.63529931),
        dec: Angle.Degrees(-40.54927861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85729"},
        {"Hipparcos Number", "HIP 48457"},
        {"Smithsonian Astrophysical Observation", "SAO 221566"},
    },
    visualMagnitude: 9.02,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.19353927),
        dec: Angle.Degrees(-40.54843583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181345"},
        {"Hipparcos Number", "HIP 95196"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.48172908),
        dec: Angle.Degrees(-40.54769117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171813"},
        {"Hipparcos Number", "HIP 91412"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.65211799),
        dec: Angle.Degrees(-40.54662192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40381"},
        {"Hipparcos Number", "HIP 28099"},
        {"Geneva Identification System", "GEN# +1.00040381"},
        {"Smithsonian Astrophysical Observation", "SAO 217631"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.09301851),
        dec: Angle.Degrees(-40.54579158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211994"},
        {"Hipparcos Number", "HIP 110415"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.48821917),
        dec: Angle.Degrees(-40.54528946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137169"},
        {"Hipparcos Number", "HIP 75545"},
        {"Geneva Identification System", "GEN# +1.00137169"},
        {"Smithsonian Astrophysical Observation", "SAO 225768"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.50339641),
        dec: Angle.Degrees(-40.54470088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115370"},
        {"Hipparcos Number", "HIP 64835"},
        {"Smithsonian Astrophysical Observation", "SAO 224038"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.36970351),
        dec: Angle.Degrees(-40.54391002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88589"},
        {"Hipparcos Number", "HIP 49962"},
        {"Smithsonian Astrophysical Observation", "SAO 221853"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.00714959),
        dec: Angle.Degrees(-40.54127566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134992"},
        {"Hipparcos Number", "HIP 74575"},
        {"Smithsonian Astrophysical Observation", "SAO 225563"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.56140036),
        dec: Angle.Degrees(-40.53975156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201464"},
        {"Hipparcos Number", "HIP 104572"},
        {"Geneva Identification System", "GEN# +1.00201464"},
        {"Smithsonian Astrophysical Observation", "SAO 230564"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.75596496),
        dec: Angle.Degrees(-40.53928986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68916"},
        {"Hipparcos Number", "HIP 40227"},
        {"Geneva Identification System", "GEN# +1.00068916"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.23637913),
        dec: Angle.Degrees(-40.53912640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208829"},
        {"Hipparcos Number", "HIP 108599"},
        {"Smithsonian Astrophysical Observation", "SAO 230928"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.99323794),
        dec: Angle.Degrees(-40.53890430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54503"},
        {"Hipparcos Number", "HIP 34346"},
        {"Smithsonian Astrophysical Observation", "SAO 218468"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.79781039),
        dec: Angle.Degrees(-40.53773123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26586"},
        {"Hipparcos Number", "HIP 19491"},
        {"Smithsonian Astrophysical Observation", "SAO 216680"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.62458383),
        dec: Angle.Degrees(-40.53582856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60537"},
        {"Hipparcos Number", "HIP 36726"},
        {"Geneva Identification System", "GEN# +1.00060537"},
        {"Smithsonian Astrophysical Observation", "SAO 218791"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.30373692),
        dec: Angle.Degrees(-40.53299398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43848"},
        {"Hipparcos Number", "HIP 29804"},
        {"Geneva Identification System", "GEN# +1.00043848"},
        {"Smithsonian Astrophysical Observation", "SAO 217824"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.13029034),
        dec: Angle.Degrees(-40.53234686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 200.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79400"},
        {"Hipparcos Number", "HIP 45191"},
        {"Smithsonian Astrophysical Observation", "SAO 220950"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.13301868),
        dec: Angle.Degrees(-40.53156470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94159"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.50413392),
        dec: Angle.Degrees(-40.53136186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3867"},
        {"Hipparcos Number", "HIP 3218"},
        {"Fundamental Katalog 5th Edition", "FK5 4059"},
        {"Geneva Identification System", "GEN# +1.00003867J"},
        {"Smithsonian Astrophysical Observation", "SAO 215192"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.22767826),
        dec: Angle.Degrees(-40.53132872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61192"},
        {"Hipparcos Number", "HIP 37004"},
        {"Smithsonian Astrophysical Observation", "SAO 218830"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.07190063),
        dec: Angle.Degrees(-40.53118436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29558"},
        {"Hipparcos Number", "HIP 21541"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.37310736),
        dec: Angle.Degrees(-40.53117178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159035"},
        {"Hipparcos Number", "HIP 85980"},
        {"Celescope Catalog", "CEL 4533"},
        {"Geneva Identification System", "GEN# +1.00159035"},
        {"Smithsonian Astrophysical Observation", "SAO 228135"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.59440053),
        dec: Angle.Degrees(-40.53115051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6367"},
        {"Hipparcos Number", "HIP 4997"},
        {"Smithsonian Astrophysical Observation", "SAO 215350"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.00879858),
        dec: Angle.Degrees(-40.53051995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28358"},
        {"Hipparcos Number", "HIP 20735"},
        {"Smithsonian Astrophysical Observation", "SAO 216803"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.65705444),
        dec: Angle.Degrees(-40.52942561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17098"},
        {"Hipparcos Number", "HIP 12708"},
        {"Geneva Identification System", "GEN# +1.00017098"},
        {"Smithsonian Astrophysical Observation", "SAO 216019"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.83426702),
        dec: Angle.Degrees(-40.52793963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26042"},
        {"Hipparcos Number", "HIP 19102"},
        {"Smithsonian Astrophysical Observation", "SAO 216637"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.42196970),
        dec: Angle.Degrees(-40.52703545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152405"},
        {"Hipparcos Number", "HIP 82767"},
        {"Celescope Catalog", "CEL 4450"},
        {"Geneva Identification System", "GEN# +1.00152405"},
        {"Smithsonian Astrophysical Observation", "SAO 227424"},
        {"Wilson Evans Batten Catalogue", "WEB 13989"},
        {"New General Catalogue", "NGC 6231 326"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.73071132),
        dec: Angle.Degrees(-40.52483018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100912"},
        {"Hipparcos Number", "HIP 56626"},
        {"Geneva Identification System", "GEN# +1.00100912"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.16133440),
        dec: Angle.Degrees(-40.52451235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12600"},
        {"Hipparcos Number", "HIP 9524"},
        {"Geneva Identification System", "GEN# +1.00012600"},
        {"Smithsonian Astrophysical Observation", "SAO 215744"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.62663088),
        dec: Angle.Degrees(-40.52024602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59352"},
        {"Hipparcos Number", "HIP 36247"},
        {"Renson", "Renson 16210"},
        {"Smithsonian Astrophysical Observation", "SAO 218741"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.95707554),
        dec: Angle.Degrees(-40.51910266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77319"},
        {"Hipparcos Number", "HIP 44239"},
        {"Smithsonian Astrophysical Observation", "SAO 220742"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.14015640),
        dec: Angle.Degrees(-40.51882048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177477"},
        {"Hipparcos Number", "HIP 93848"},
        {"Smithsonian Astrophysical Observation", "SAO 229496"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.68418643),
        dec: Angle.Degrees(-40.51854290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50858"},
        {"Hipparcos Number", "HIP 33046"},
        {"Smithsonian Astrophysical Observation", "SAO 218281"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.26798405),
        dec: Angle.Degrees(-40.51755442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102174"},
        {"Hipparcos Number", "HIP 57340"},
        {"Smithsonian Astrophysical Observation", "SAO 222998"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.35430073),
        dec: Angle.Degrees(-40.51653555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120272"},
        {"Hipparcos Number", "HIP 67438"},
        {"Geneva Identification System", "GEN# +1.00120272"},
        {"Smithsonian Astrophysical Observation", "SAO 224458"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.31897885),
        dec: Angle.Degrees(-40.51640886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21980"},
        {"Hipparcos Number", "HIP 16385"},
        {"Smithsonian Astrophysical Observation", "SAO 216359"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.76106078),
        dec: Angle.Degrees(-40.51607334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116487"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.06747796),
        dec: Angle.Degrees(-40.51583189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32544"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.86664009),
        dec: Angle.Degrees(-40.51525243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -254.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152723"},
        {"Hipparcos Number", "HIP 82936"},
        {"Celescope Catalog", "CEL 4464"},
        {"Geneva Identification System", "GEN# +1.00152723J"},
        {"Smithsonian Astrophysical Observation", "SAO 227479"},
        {"Wilson Evans Batten Catalogue", "WEB 14021"},
    },
    visualMagnitude: 7.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.22778838),
        dec: Angle.Degrees(-40.51233718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72318"},
        {"Hipparcos Number", "HIP 41730"},
        {"Celescope Catalog", "CEL 2587"},
        {"Geneva Identification System", "GEN# +1.00072318"},
        {"Smithsonian Astrophysical Observation", "SAO 220020"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.64341308),
        dec: Angle.Degrees(-40.51167799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214161"},
        {"Hipparcos Number", "HIP 111655"},
        {"Geneva Identification System", "GEN# +1.00214161"},
        {"Smithsonian Astrophysical Observation", "SAO 231218"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.28348417),
        dec: Angle.Degrees(-40.51067233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83528"},
        {"Hipparcos Number", "HIP 47254"},
        {"Smithsonian Astrophysical Observation", "SAO 221354"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.47840684),
        dec: Angle.Degrees(-40.50963454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160204"},
        {"Hipparcos Number", "HIP 86491"},
        {"Smithsonian Astrophysical Observation", "SAO 228269"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.12496470),
        dec: Angle.Degrees(-40.50825443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202135"},
        {"Hipparcos Number", "HIP 104925"},
        {"Geneva Identification System", "GEN# +1.00202135"},
        {"Smithsonian Astrophysical Observation", "SAO 230596"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.80962557),
        dec: Angle.Degrees(-40.50607996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169812"},
        {"Hipparcos Number", "HIP 90522"},
        {"Geneva Identification System", "GEN# +1.00169812"},
        {"Smithsonian Astrophysical Observation", "SAO 229041"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.06887062),
        dec: Angle.Degrees(-40.50331009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68785"},
        {"Hipparcos Number", "HIP 40174"},
        {"Geneva Identification System", "GEN# +1.00068785"},
        {"Smithsonian Astrophysical Observation", "SAO 219592"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.06700947),
        dec: Angle.Degrees(-40.50309110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81780"},
        {"Hipparcos Number", "HIP 46297"},
        {"Geneva Identification System", "GEN# +1.00081780"},
        {"Smithsonian Astrophysical Observation", "SAO 221167"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.61854205),
        dec: Angle.Degrees(-40.50172135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102365"},
        {"Hipparcos Number", "HIP 57443"},
        {"Cincinnati Publication", "Ci 20 660"},
        {"Geneva Identification System", "GEN# +1.00102365"},
        {"Smithsonian Astrophysical Observation", "SAO 223020"},
        {"Wilson Evans Batten Catalogue", "WEB 10319"},
    },
    visualMagnitude: 4.89,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.63436255),
        dec: Angle.Degrees(-40.50133452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1531.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 403.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72317"},
        {"Hipparcos Number", "HIP 41736"},
        {"Geneva Identification System", "GEN# +1.00072317"},
        {"Smithsonian Astrophysical Observation", "SAO 220024"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.66154811),
        dec: Angle.Degrees(-40.50063436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98440"},
        {"Hipparcos Number", "HIP 55271"},
        {"Geneva Identification System", "GEN# +1.00098440"},
        {"Smithsonian Astrophysical Observation", "SAO 222710"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.79433653),
        dec: Angle.Degrees(-40.49992816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55719"},
        {"Henry Draper 2", "HD 55719A"},
        {"Hipparcos Number", "HIP 34802"},
        {"Celescope Catalog", "CEL 1675"},
        {"Geneva Identification System", "GEN# +1.00055719"},
        {"Renson", "Renson 15140"},
        {"Smithsonian Astrophysical Observation", "SAO 218525"},
        {"Wilson Evans Batten Catalogue", "WEB 6957"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.06592133),
        dec: Angle.Degrees(-40.49877843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95506"},
        {"Hipparcos Number", "HIP 53840"},
        {"Geneva Identification System", "GEN# +1.00095506J"},
        {"Smithsonian Astrophysical Observation", "SAO 222499"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.21382274),
        dec: Angle.Degrees(-40.49812916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78627"},
        {"Smithsonian Astrophysical Observation", "SAO 140919"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.77748924),
        dec: Angle.Degrees(-08.45152743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184346"},
        {"Hipparcos Number", "HIP 96391"},
        {"Smithsonian Astrophysical Observation", "SAO 229761"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.95876658),
        dec: Angle.Degrees(-40.49759217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177873"},
        {"Hipparcos Number", "HIP 94005"},
        {"Geneva Identification System", "GEN# +1.00177873"},
        {"Smithsonian Astrophysical Observation", "SAO 229513"},
        {"Wilson Evans Batten Catalogue", "WEB 16360"},
    },
    visualMagnitude: 4.57,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.08722077),
        dec: Angle.Degrees(-40.49663760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57551"},
        {"Hipparcos Number", "HIP 35532"},
        {"Smithsonian Astrophysical Observation", "SAO 218644"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.99743610),
        dec: Angle.Degrees(-40.49490041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205978"},
        {"Hipparcos Number", "HIP 106982"},
        {"Fundamental Katalog 5th Edition", "FK5 5912"},
        {"Smithsonian Astrophysical Observation", "SAO 230780"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.00995282),
        dec: Angle.Degrees(-40.49367584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2339"},
        {"Hipparcos Number", "HIP 2130"},
        {"Geneva Identification System", "GEN# +1.00002339"},
        {"Smithsonian Astrophysical Observation", "SAO 215099"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.75483227),
        dec: Angle.Degrees(-40.49203437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138395"},
        {"Hipparcos Number", "HIP 76165"},
        {"Smithsonian Astrophysical Observation", "SAO 225898"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.35122534),
        dec: Angle.Degrees(-40.49069892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171615"},
        {"Hipparcos Number", "HIP 91330"},
        {"Smithsonian Astrophysical Observation", "SAO 229153"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.42103407),
        dec: Angle.Degrees(-40.49018531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10189"},
        {"Hipparcos Number", "HIP 7675"},
        {"Smithsonian Astrophysical Observation", "SAO 215597"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.70608280),
        dec: Angle.Degrees(-40.48655947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223632"},
        {"Hipparcos Number", "HIP 117631"},
        {"Smithsonian Astrophysical Observation", "SAO 231812"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.84151720),
        dec: Angle.Degrees(-40.48519823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68715"},
        {"Hipparcos Number", "HIP 40154"},
        {"Smithsonian Astrophysical Observation", "SAO 219580"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.99933530),
        dec: Angle.Degrees(-40.48426858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53834"},
        {"Hipparcos Number", "HIP 34137"},
        {"Smithsonian Astrophysical Observation", "SAO 218432"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.17234867),
        dec: Angle.Degrees(-40.48404185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8869"},
        {"Hipparcos Number", "HIP 6735"},
        {"Smithsonian Astrophysical Observation", "SAO 215506"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.68237553),
        dec: Angle.Degrees(-40.48321167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270"},
        {"Hipparcos Number", "HIP 611"},
        {"Geneva Identification System", "GEN# +1.00000270"},
        {"Smithsonian Astrophysical Observation", "SAO 214971"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.85529015),
        dec: Angle.Degrees(-40.47958534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214818"},
        {"Hipparcos Number", "HIP 112011"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.33510424),
        dec: Angle.Degrees(-40.47638657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127082"},
        {"Hipparcos Number", "HIP 70933"},
        {"Smithsonian Astrophysical Observation", "SAO 224976"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.61022510),
        dec: Angle.Degrees(-40.47616150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88241"},
        {"Hipparcos Number", "HIP 49760"},
        {"Geneva Identification System", "GEN# +1.00088241"},
        {"Renson", "Renson 25270"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.36486592),
        dec: Angle.Degrees(-40.47405679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3608"},
        {"Hipparcos Number", "HIP 3040"},
        {"Smithsonian Astrophysical Observation", "SAO 215176"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.66501430),
        dec: Angle.Degrees(-40.47392285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28453"},
        {"Hipparcos Number", "HIP 20811"},
        {"Geneva Identification System", "GEN# +1.00028453"},
        {"Smithsonian Astrophysical Observation", "SAO 216811"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.88581558),
        dec: Angle.Degrees(-40.47244133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167297"},
        {"Hipparcos Number", "HIP 89552"},
        {"Geneva Identification System", "GEN# +1.00167297J"},
        {"Smithsonian Astrophysical Observation", "SAO 228864"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.09643273),
        dec: Angle.Degrees(-40.47213274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20596"},
        {"Hipparcos Number", "HIP 15301"},
        {"Smithsonian Astrophysical Observation", "SAO 216244"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.34608497),
        dec: Angle.Degrees(-40.46992386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12724"},
        {"Hipparcos Number", "HIP 9629"},
        {"Geneva Identification System", "GEN# +1.00012724"},
        {"Smithsonian Astrophysical Observation", "SAO 215753"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.94046614),
        dec: Angle.Degrees(-40.46919597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 377.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82434"},
        {"Hipparcos Number", "HIP 46651"},
        {"Geneva Identification System", "GEN# +1.00082434"},
        {"Smithsonian Astrophysical Observation", "SAO 221234"},
        {"Wilson Evans Batten Catalogue", "WEB 8804"},
    },
    visualMagnitude: 3.60,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.67547063),
        dec: Angle.Degrees(-40.46688763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150287"},
        {"Hipparcos Number", "HIP 81751"},
        {"Smithsonian Astrophysical Observation", "SAO 227068"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.46671591),
        dec: Angle.Degrees(-40.46618228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83029"},
        {"Hipparcos Number", "HIP 46979"},
        {"Geneva Identification System", "GEN# +1.00083029"},
        {"Smithsonian Astrophysical Observation", "SAO 221297"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.62466271),
        dec: Angle.Degrees(-40.46580315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202945"},
        {"Hipparcos Number", "HIP 105354"},
        {"Geneva Identification System", "GEN# +1.00202945"},
        {"Smithsonian Astrophysical Observation", "SAO 230640"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.09095175),
        dec: Angle.Degrees(-40.46543412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63006"},
        {"Hipparcos Number", "HIP 37790"},
        {"Celescope Catalog", "CEL 2012"},
        {"Geneva Identification System", "GEN# +1.00063006"},
        {"Smithsonian Astrophysical Observation", "SAO 218950"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.23638664),
        dec: Angle.Degrees(-40.46279325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186770"},
        {"Hipparcos Number", "HIP 97430"},
        {"Smithsonian Astrophysical Observation", "SAO 229869"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.03487015),
        dec: Angle.Degrees(-40.45837828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17546"},
        {"Hipparcos Number", "HIP 13039"},
        {"Smithsonian Astrophysical Observation", "SAO 216048"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.88898400),
        dec: Angle.Degrees(-40.45630781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183337"},
        {"Hipparcos Number", "HIP 95954"},
        {"Smithsonian Astrophysical Observation", "SAO 229723"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.69587390),
        dec: Angle.Degrees(-40.45528803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54676"},
        {"Hipparcos Number", "HIP 34397"},
        {"Smithsonian Astrophysical Observation", "SAO 218474"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.97216316),
        dec: Angle.Degrees(-40.45517236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70680"},
        {"Hipparcos Number", "HIP 40967"},
        {"Smithsonian Astrophysical Observation", "SAO 219826"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.40669272),
        dec: Angle.Degrees(-40.45481467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1138"},
        {"Hipparcos Number", "HIP 1243"},
        {"Smithsonian Astrophysical Observation", "SAO 215023"},
        {"Smithsonian Astrophysical Observation 2", "SAO 192426"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.87253869),
        dec: Angle.Degrees(-40.45449469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220767"},
        {"Hipparcos Number", "HIP 115728"},
        {"Smithsonian Astrophysical Observation", "SAO 231612"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.68500561),
        dec: Angle.Degrees(-40.45054093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144259"},
        {"Hipparcos Number", "HIP 78915"},
        {"Smithsonian Astrophysical Observation", "SAO 226503"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.62886526),
        dec: Angle.Degrees(-40.45014479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70291"},
        {"Hipparcos Number", "HIP 40790"},
        {"Geneva Identification System", "GEN# +1.00070291J"},
        {"Smithsonian Astrophysical Observation", "SAO 219786"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.87955785),
        dec: Angle.Degrees(-40.44956414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212746"},
        {"Hipparcos Number", "HIP 110832"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.81762210),
        dec: Angle.Degrees(-40.44880363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46288"},
        {"Hipparcos Number", "HIP 31032"},
        {"Celescope Catalog", "CEL 1280"},
        {"Geneva Identification System", "GEN# +1.00046288J"},
        {"Smithsonian Astrophysical Observation", "SAO 217981"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.66950673),
        dec: Angle.Degrees(-40.44815667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164890"},
        {"Hipparcos Number", "HIP 88577"},
        {"Smithsonian Astrophysical Observation", "SAO 228683"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.28929045),
        dec: Angle.Degrees(-40.44788759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76304"},
        {"Henry Draper 2", "HD 76305"},
        {"Hipparcos Number", "HIP 43673"},
        {"Geneva Identification System", "GEN# +1.00076304"},
        {"Smithsonian Astrophysical Observation", "SAO 220628"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.46151651),
        dec: Angle.Degrees(-40.44755087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30670"},
        {"Hipparcos Number", "HIP 22281"},
        {"Geneva Identification System", "GEN# +1.00030670"},
        {"Smithsonian Astrophysical Observation", "SAO 216995"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.96065043),
        dec: Angle.Degrees(-40.44589703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219218"},
        {"Hipparcos Number", "HIP 114743"},
        {"Geneva Identification System", "GEN# +1.00219218"},
        {"Smithsonian Astrophysical Observation", "SAO 231504"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.65225584),
        dec: Angle.Degrees(-40.44579875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -223.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99274"},
        {"Hipparcos Number", "HIP 55732"},
        {"Smithsonian Astrophysical Observation", "SAO 222778"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.28999363),
        dec: Angle.Degrees(-40.44550507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61541"},
    },
    visualMagnitude: 12.32,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.12643739),
        dec: Angle.Degrees(-40.44179882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154912"},
        {"Hipparcos Number", "HIP 83992"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.54610944),
        dec: Angle.Degrees(-40.44132725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119154"},
        {"Hipparcos Number", "HIP 66871"},
        {"Geneva Identification System", "GEN# +1.00119154"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.57311205),
        dec: Angle.Degrees(-40.44110246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25208"},
        {"Hipparcos Number", "HIP 18571"},
        {"Smithsonian Astrophysical Observation", "SAO 216583"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.63741429),
        dec: Angle.Degrees(-40.44084387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167849"},
        {"Hipparcos Number", "HIP 89745"},
        {"Geneva Identification System", "GEN# +1.00167849"},
        {"Smithsonian Astrophysical Observation", "SAO 228901"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.72138271),
        dec: Angle.Degrees(-40.44072804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89102"},
        {"Hipparcos Number", "HIP 50264"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.95322999),
        dec: Angle.Degrees(-40.43846975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145134"},
        {"Hipparcos Number", "HIP 79290"},
        {"Geneva Identification System", "GEN# +1.00145134J"},
        {"Smithsonian Astrophysical Observation", "SAO 226560"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.73197943),
        dec: Angle.Degrees(-40.43673946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186058"},
        {"Hipparcos Number", "HIP 97097"},
        {"Smithsonian Astrophysical Observation", "SAO 229842"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.99478649),
        dec: Angle.Degrees(-40.43659110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100378"},
        {"Hipparcos Number", "HIP 56319"},
        {"Fundamental Katalog 5th Edition", "FK5 2922"},
        {"Geneva Identification System", "GEN# +1.00100378"},
        {"Smithsonian Astrophysical Observation", "SAO 222856"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.20057957),
        dec: Angle.Degrees(-40.43633610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73588"},
        {"Hipparcos Number", "HIP 42315"},
        {"Geneva Identification System", "GEN# +1.00073588"},
        {"Smithsonian Astrophysical Observation", "SAO 220203"},
        {"Wilson Evans Batten Catalogue", "WEB 8134"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.41540181),
        dec: Angle.Degrees(-40.43564739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143248"},
        {"Hipparcos Number", "HIP 78445"},
        {"Geneva Identification System", "GEN# +1.00143248"},
        {"Smithsonian Astrophysical Observation", "SAO 226442"},
        {"Wilson Evans Batten Catalogue", "WEB 13260"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.22374303),
        dec: Angle.Degrees(-40.43556029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15544"},
        {"Hipparcos Number", "HIP 11556"},
        {"Fundamental Katalog 5th Edition", "FK5 4230"},
        {"Geneva Identification System", "GEN# +1.00015544"},
        {"Smithsonian Astrophysical Observation", "SAO 215914"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.22040996),
        dec: Angle.Degrees(-40.43528545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16572"},
        {"Hipparcos Number", "HIP 12280"},
        {"Smithsonian Astrophysical Observation", "SAO 215976"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.55010988),
        dec: Angle.Degrees(-40.43514080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86110"},
        {"Hipparcos Number", "HIP 48666"},
        {"Smithsonian Astrophysical Observation", "SAO 221607"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.87678578),
        dec: Angle.Degrees(-40.43477950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126476"},
        {"Hipparcos Number", "HIP 70636"},
        {"Geneva Identification System", "GEN# +1.00126476"},
        {"Smithsonian Astrophysical Observation", "SAO 224926"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.72990265),
        dec: Angle.Degrees(-40.43375514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69379"},
        {"Hipparcos Number", "HIP 40422"},
        {"Geneva Identification System", "GEN# +1.00069379"},
        {"Smithsonian Astrophysical Observation", "SAO 219675"},
    },
    visualMagnitude: 8.96,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.79270724),
        dec: Angle.Degrees(-40.43292266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6069"},
        {"Hipparcos Number", "HIP 4780"},
        {"Geneva Identification System", "GEN# +1.00006069"},
        {"Smithsonian Astrophysical Observation", "SAO 215330"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.35184670),
        dec: Angle.Degrees(-40.43263677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2670"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.46121362),
        dec: Angle.Degrees(-40.43054539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162698"},
        {"Hipparcos Number", "HIP 87651"},
        {"Smithsonian Astrophysical Observation", "SAO 228531"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.55341285),
        dec: Angle.Degrees(-40.42355403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196922"},
        {"Hipparcos Number", "HIP 102123"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.43000227),
        dec: Angle.Degrees(-40.42317583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130363"},
        {"Hipparcos Number", "HIP 72454"},
        {"Smithsonian Astrophysical Observation", "SAO 225205"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.24437459),
        dec: Angle.Degrees(-40.42092074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1020"},
        {"Hipparcos Number", "HIP 1155"},
        {"Smithsonian Astrophysical Observation", "SAO 215013"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.60698624),
        dec: Angle.Degrees(-40.42017562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73882"},
        {"Hipparcos Number", "HIP 42433"},
        {"Celescope Catalog", "CEL 2741"},
        {"Smithsonian Astrophysical Observation", "SAO 220236"},
        {"Wilson Evans Batten Catalogue", "WEB 8165"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.78973758),
        dec: Angle.Degrees(-40.41924845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220536"},
        {"Hipparcos Number", "HIP 115582"},
        {"Geneva Identification System", "GEN# +1.00220536"},
        {"Smithsonian Astrophysical Observation", "SAO 231596"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.18809241),
        dec: Angle.Degrees(-40.41859075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -211.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42969"},
        {"Hipparcos Number", "HIP 29408"},
        {"Smithsonian Astrophysical Observation", "SAO 217770"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.95100512),
        dec: Angle.Degrees(-40.41816526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94376"},
        {"Hipparcos Number", "HIP 53218"},
        {"Smithsonian Astrophysical Observation", "SAO 222400"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.27189362),
        dec: Angle.Degrees(-40.41728680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194814"},
        {"Hipparcos Number", "HIP 101063"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.31576976),
        dec: Angle.Degrees(-40.41697004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222497"},
        {"Hipparcos Number", "HIP 116872"},
        {"Smithsonian Astrophysical Observation", "SAO 231739"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.33674208),
        dec: Angle.Degrees(-40.41671303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31144"},
        {"Hipparcos Number", "HIP 22579"},
        {"Smithsonian Astrophysical Observation", "SAO 217043"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.88512602),
        dec: Angle.Degrees(-40.41405530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227"},
        {"Hipparcos Number", "HIP 574"},
        {"Smithsonian Astrophysical Observation", "SAO 214968"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.74792713),
        dec: Angle.Degrees(-40.41400635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166268"},
        {"Hipparcos Number", "HIP 89147"},
        {"Smithsonian Astrophysical Observation", "SAO 228787"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.92022483),
        dec: Angle.Degrees(-40.41317290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194368"},
        {"Hipparcos Number", "HIP 100840"},
        {"Smithsonian Astrophysical Observation", "SAO 230210"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.69322096),
        dec: Angle.Degrees(-40.41307058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105008"},
        {"Hipparcos Number", "HIP 58965"},
        {"Geneva Identification System", "GEN# +1.00105008"},
        {"Smithsonian Astrophysical Observation", "SAO 223209"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.36038160),
        dec: Angle.Degrees(-40.41233356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210329"},
        {"Hipparcos Number", "HIP 109468"},
        {"Geneva Identification System", "GEN# +1.00210329"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.64709359),
        dec: Angle.Degrees(-40.41163680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20081"},
        {"Hipparcos Number", "HIP 14895"},
        {"Smithsonian Astrophysical Observation", "SAO 216207"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.06073436),
        dec: Angle.Degrees(-40.40937557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1938"},
        {"Hipparcos Number", "HIP 1857"},
        {"Geneva Identification System", "GEN# +1.00001938"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.86337369),
        dec: Angle.Degrees(-40.40648345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173540"},
        {"Hipparcos Number", "HIP 92226"},
        {"Fundamental Katalog 5th Edition", "FK5 3492"},
        {"Geneva Identification System", "GEN# +1.00173540"},
        {"Smithsonian Astrophysical Observation", "SAO 229285"},
        {"Wilson Evans Batten Catalogue", "WEB 15906"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.93583145),
        dec: Angle.Degrees(-40.40612167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174093"},
        {"Hipparcos Number", "HIP 92474"},
        {"Smithsonian Astrophysical Observation", "SAO 229316"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.68767265),
        dec: Angle.Degrees(-40.40571521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10512"},
        {"Hipparcos Number", "HIP 7905"},
        {"Smithsonian Astrophysical Observation", "SAO 215617"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.40857754),
        dec: Angle.Degrees(-40.40409510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66676"},
        {"Hipparcos Number", "HIP 39373"},
        {"Smithsonian Astrophysical Observation", "SAO 219343"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.73426331),
        dec: Angle.Degrees(-40.40257134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204467"},
        {"Hipparcos Number", "HIP 106129"},
        {"Geneva Identification System", "GEN# +1.00204467"},
        {"Smithsonian Astrophysical Observation", "SAO 230714"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.46436159),
        dec: Angle.Degrees(-40.40085069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24112"},
        {"Hipparcos Number", "HIP 17819"},
        {"Geneva Identification System", "GEN# +1.00024112"},
        {"Smithsonian Astrophysical Observation", "SAO 216499"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.19485555),
        dec: Angle.Degrees(-40.39936137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40524"},
        {"Hipparcos Number", "HIP 28186"},
        {"Geneva Identification System", "GEN# +1.00040524"},
        {"Smithsonian Astrophysical Observation", "SAO 217637"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.35312380),
        dec: Angle.Degrees(-40.39783813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53098"},
        {"Hipparcos Number", "HIP 33879"},
        {"Smithsonian Astrophysical Observation", "SAO 218389"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.48669993),
        dec: Angle.Degrees(-40.39758095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75060"},
        {"Hipparcos Number", "HIP 43059"},
        {"Celescope Catalog", "CEL 2884"},
        {"Geneva Identification System", "GEN# +1.00075060"},
        {"Smithsonian Astrophysical Observation", "SAO 220428"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.58233958),
        dec: Angle.Degrees(-40.39660117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28015"},
        {"Hipparcos Number", "HIP 20500"},
        {"Smithsonian Astrophysical Observation", "SAO 216773"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.90050499),
        dec: Angle.Degrees(-40.39531084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28798"},
        {"Hipparcos Number", "HIP 21035"},
        {"Geneva Identification System", "GEN# +1.00028798"},
        {"Smithsonian Astrophysical Observation", "SAO 216845"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.65286165),
        dec: Angle.Degrees(-40.39521023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125595"},
        {"Hipparcos Number", "HIP 70170"},
        {"Cincinnati Publication", "Ci 20 852"},
        {"Geneva Identification System", "GEN# +1.00125595"},
        {"Wilson Evans Batten Catalogue", "WEB 12189"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.34840032),
        dec: Angle.Degrees(-40.39378369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -561.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24744"},
        {"Henry Draper 2", "HD 24745"},
        {"Hipparcos Number", "HIP 18262"},
        {"Fundamental Katalog 5th Edition", "FK5 2280"},
        {"Geneva Identification System", "GEN# +1.00024744J"},
        {"Smithsonian Astrophysical Observation", "SAO 216546"},
        {"Wilson Evans Batten Catalogue", "WEB 3527"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.59657689),
        dec: Angle.Degrees(-40.35702900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130642"},
        {"Hipparcos Number", "HIP 72591"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.64215467),
        dec: Angle.Degrees(-40.38995387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115053"},
        {"Hipparcos Number", "HIP 64659"},
        {"Geneva Identification System", "GEN# +1.00115053"},
        {"Smithsonian Astrophysical Observation", "SAO 224007"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.81018288),
        dec: Angle.Degrees(-40.38859942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84876"},
        {"Wilson Evans Batten Catalogue", "WEB 14333"},
    },
    visualMagnitude: 9.11,
    bvColour: 2.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.19233110),
        dec: Angle.Degrees(-40.38830236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1858"},
        {"Hipparcos Number", "HIP 1797"},
        {"Geneva Identification System", "GEN# +1.00001858"},
        {"Smithsonian Astrophysical Observation", "SAO 215071"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.70583627),
        dec: Angle.Degrees(-40.38693156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127214"},
        {"Hipparcos Number", "HIP 70988"},
        {"Smithsonian Astrophysical Observation", "SAO 224987"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.79714763),
        dec: Angle.Degrees(-40.38639123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163197"},
        {"Hipparcos Number", "HIP 87848"},
        {"Smithsonian Astrophysical Observation", "SAO 228563"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.19925118),
        dec: Angle.Degrees(-40.38546297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59224"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.20278366),
        dec: Angle.Degrees(-40.38159015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70947"},
        {"Hipparcos Number", "HIP 41103"},
        {"Celescope Catalog", "CEL 2453"},
        {"Geneva Identification System", "GEN# +1.00070947"},
        {"Smithsonian Astrophysical Observation", "SAO 219858"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.78434763),
        dec: Angle.Degrees(-40.38095786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190760"},
        {"Hipparcos Number", "HIP 99189"},
        {"Smithsonian Astrophysical Observation", "SAO 230057"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.04142192),
        dec: Angle.Degrees(-40.38033844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46040"},
        {"Hipparcos Number", "HIP 30904"},
        {"Geneva Identification System", "GEN# +1.00046040"},
        {"Smithsonian Astrophysical Observation", "SAO 217961"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.30047271),
        dec: Angle.Degrees(-40.38025666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52059"},
        {"Hipparcos Number", "HIP 33505"},
        {"Smithsonian Astrophysical Observation", "SAO 218341"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.46976224),
        dec: Angle.Degrees(-40.37919499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137360"},
        {"Hipparcos Number", "HIP 75625"},
        {"Smithsonian Astrophysical Observation", "SAO 225797"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.77765703),
        dec: Angle.Degrees(-40.37876819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110803"},
    },
    visualMagnitude: 11.21,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.73392138),
        dec: Angle.Degrees(-40.37703980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201410"},
        {"Hipparcos Number", "HIP 104546"},
        {"Smithsonian Astrophysical Observation", "SAO 230559"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.65601961),
        dec: Angle.Degrees(-40.37569663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73632"},
        {"Hipparcos Number", "HIP 42339"},
        {"Smithsonian Astrophysical Observation", "SAO 220209"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.48001008),
        dec: Angle.Degrees(-40.37364657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144434"},
        {"Hipparcos Number", "HIP 79001"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.89840163),
        dec: Angle.Degrees(-40.37274302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 706"},
        {"Hipparcos Number", "HIP 913"},
        {"Smithsonian Astrophysical Observation", "SAO 214994"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.82432014),
        dec: Angle.Degrees(-40.37268546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187762"},
        {"Hipparcos Number", "HIP 97874"},
        {"Smithsonian Astrophysical Observation", "SAO 229915"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.33600653),
        dec: Angle.Degrees(-40.37215904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46039"},
        {"Hipparcos Number", "HIP 30895"},
        {"Smithsonian Astrophysical Observation", "SAO 217958"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.27950627),
        dec: Angle.Degrees(-40.37194733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5282"},
        {"Hipparcos Number", "HIP 4250"},
        {"Smithsonian Astrophysical Observation", "SAO 215284"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.54989410),
        dec: Angle.Degrees(-40.37190895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196445"},
        {"Hipparcos Number", "HIP 101887"},
        {"Geneva Identification System", "GEN# +1.00196445"},
        {"Smithsonian Astrophysical Observation", "SAO 230309"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.71645633),
        dec: Angle.Degrees(-40.36884537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109961"},
        {"Hipparcos Number", "HIP 61729"},
        {"Smithsonian Astrophysical Observation", "SAO 223574"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.79353230),
        dec: Angle.Degrees(-40.36870689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16315"},
    },
    visualMagnitude: 11.86,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.56404673),
        dec: Angle.Degrees(-40.36779541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78317"},
    },
    visualMagnitude: 11.41,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.86831385),
        dec: Angle.Degrees(-40.36418061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40691"},
        {"Hipparcos Number", "HIP 28277"},
        {"Smithsonian Astrophysical Observation", "SAO 217647"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.62749217),
        dec: Angle.Degrees(-40.36268909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131373"},
        {"Hipparcos Number", "HIP 72946"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.62451832),
        dec: Angle.Degrees(-40.36178797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156835"},
        {"Hipparcos Number", "HIP 84942"},
        {"Smithsonian Astrophysical Observation", "SAO 227864"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.39666966),
        dec: Angle.Degrees(-40.35958026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70081"},
        {"Hipparcos Number", "HIP 40695"},
        {"Geneva Identification System", "GEN# +1.00070081"},
        {"Smithsonian Astrophysical Observation", "SAO 219759"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.60676046),
        dec: Angle.Degrees(-40.35844287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 924"},
        {"Hipparcos Number", "HIP 1085"},
        {"Geneva Identification System", "GEN# +1.00000924"},
        {"Smithsonian Astrophysical Observation", "SAO 215006"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.37844842),
        dec: Angle.Degrees(-40.35838520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26927"},
        {"Hipparcos Number", "HIP 19721"},
        {"Fundamental Katalog 5th Edition", "FK5 2307"},
        {"Geneva Identification System", "GEN# +1.00026927"},
        {"Smithsonian Astrophysical Observation", "SAO 216705"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.39880393),
        dec: Angle.Degrees(-40.35783872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53405"},
        {"Hipparcos Number", "HIP 33984"},
        {"Renson", "Renson 14730"},
        {"Smithsonian Astrophysical Observation", "SAO 218406"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.77152621),
        dec: Angle.Degrees(-40.35767286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49314"},
    },
    visualMagnitude: 12.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.99131579),
        dec: Angle.Degrees(-39.37903800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77302"},
        {"Hipparcos Number", "HIP 44225"},
    },
    visualMagnitude: 9.15,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.11658266),
        dec: Angle.Degrees(-40.35677225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179551"},
        {"Hipparcos Number", "HIP 94580"},
        {"Smithsonian Astrophysical Observation", "SAO 229575"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.72599348),
        dec: Angle.Degrees(-40.35552622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42682"},
        {"Hipparcos Number", "HIP 29263"},
        {"Geneva Identification System", "GEN# +1.00042682"},
        {"Smithsonian Astrophysical Observation", "SAO 217753"},
        {"Wilson Evans Batten Catalogue", "WEB 5743"},
    },
    visualMagnitude: 5.54,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.54341638),
        dec: Angle.Degrees(-40.35396993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58653"},
        {"Hipparcos Number", "HIP 35966"},
        {"Smithsonian Astrophysical Observation", "SAO 218704"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.20078390),
        dec: Angle.Degrees(-40.35326099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152902"},
        {"Hipparcos Number", "HIP 83036"},
        {"Geneva Identification System", "GEN# +1.00152902"},
        {"Smithsonian Astrophysical Observation", "SAO 227504"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.52686521),
        dec: Angle.Degrees(-40.35267003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22986"},
        {"Hipparcos Number", "HIP 17099"},
        {"Smithsonian Astrophysical Observation", "SAO 216431"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.93942656),
        dec: Angle.Degrees(-40.35223406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67441"},
        {"Hipparcos Number", "HIP 39652"},
        {"Geneva Identification System", "GEN# +1.00067441"},
        {"Smithsonian Astrophysical Observation", "SAO 219415"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.54627886),
        dec: Angle.Degrees(-40.35044143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48383"},
        {"Hipparcos Number", "HIP 32007"},
        {"Celescope Catalog", "CEL 1355"},
        {"Geneva Identification System", "GEN# +1.00048383A"},
        {"Smithsonian Astrophysical Observation", "SAO 218126"},
        {"Wilson Evans Batten Catalogue", "WEB 6451"},
    },
    visualMagnitude: 6.16,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.30905681),
        dec: Angle.Degrees(-40.34987312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33952"},
        {"Hipparcos Number", "HIP 24218"},
        {"Geneva Identification System", "GEN# +1.00033952"},
        {"Smithsonian Astrophysical Observation", "SAO 217231"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.00740470),
        dec: Angle.Degrees(-40.34821284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162805"},
        {"Hipparcos Number", "HIP 87689"},
        {"Geneva Identification System", "GEN# +1.00162805"},
        {"Smithsonian Astrophysical Observation", "SAO 228535"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.66138775),
        dec: Angle.Degrees(-40.34812556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69142"},
        {"Hipparcos Number", "HIP 40326"},
        {"Geneva Identification System", "GEN# +1.00069142"},
        {"Smithsonian Astrophysical Observation", "SAO 219635"},
        {"Wilson Evans Batten Catalogue", "WEB 7864"},
    },
    visualMagnitude: 4.42,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.51202967),
        dec: Angle.Degrees(-40.34773028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149153"},
        {"Hipparcos Number", "HIP 81166"},
        {"Geneva Identification System", "GEN# +1.00149153"},
        {"Smithsonian Astrophysical Observation", "SAO 226923"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.66953057),
        dec: Angle.Degrees(-40.34749918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88809"},
        {"Hipparcos Number", "HIP 50103"},
        {"Geneva Identification System", "GEN# +1.00088809"},
        {"Smithsonian Astrophysical Observation", "SAO 221877"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.44158428),
        dec: Angle.Degrees(-40.34607640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82366"},
        {"Hipparcos Number", "HIP 46612"},
        {"Smithsonian Astrophysical Observation", "SAO 221226"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.57190763),
        dec: Angle.Degrees(-40.34590908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55786"},
        {"Hipparcos Number", "HIP 34840"},
        {"Geneva Identification System", "GEN# +1.00055786"},
        {"Smithsonian Astrophysical Observation", "SAO 218530"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.14702603),
        dec: Angle.Degrees(-40.34561140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67440"},
        {"Hipparcos Number", "HIP 39656"},
        {"Geneva Identification System", "GEN# +1.00067440"},
        {"Smithsonian Astrophysical Observation", "SAO 219416"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.56345521),
        dec: Angle.Degrees(-40.34365818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26559"},
        {"Hipparcos Number", "HIP 19474"},
        {"Renson", "Renson 6770"},
        {"Smithsonian Astrophysical Observation", "SAO 216678"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.56953489),
        dec: Angle.Degrees(-40.34335053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89093"},
        {"Hipparcos Number", "HIP 50260"},
        {"Smithsonian Astrophysical Observation", "SAO 221914"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.94942763),
        dec: Angle.Degrees(-40.34121418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151535"},
        {"Hipparcos Number", "HIP 82358"},
        {"Smithsonian Astrophysical Observation", "SAO 227270"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.42797828),
        dec: Angle.Degrees(-40.34064769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50901"},
        {"Hipparcos Number", "HIP 33078"},
        {"Smithsonian Astrophysical Observation", "SAO 218284"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.32973603),
        dec: Angle.Degrees(-40.33936770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115962"},
        {"Hipparcos Number", "HIP 65155"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.28697746),
        dec: Angle.Degrees(-40.33692140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20623"},
        {"Hipparcos Number", "HIP 15328"},
        {"Smithsonian Astrophysical Observation", "SAO 216247"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.43057538),
        dec: Angle.Degrees(-40.33680770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164050"},
        {"Hipparcos Number", "HIP 88246"},
        {"Smithsonian Astrophysical Observation", "SAO 228629"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.29713036),
        dec: Angle.Degrees(-40.33550416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202339"},
        {"Hipparcos Number", "HIP 105023"},
        {"Smithsonian Astrophysical Observation", "SAO 230609"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.09165308),
        dec: Angle.Degrees(-40.33448857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122090"},
        {"Hipparcos Number", "HIP 68432"},
        {"Smithsonian Astrophysical Observation", "SAO 224611"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.13952767),
        dec: Angle.Degrees(-40.33444996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205448"},
        {"Hipparcos Number", "HIP 106675"},
        {"Smithsonian Astrophysical Observation", "SAO 230748"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.09702092),
        dec: Angle.Degrees(-40.33020740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70119"},
        {"Hipparcos Number", "HIP 40714"},
        {"Geneva Identification System", "GEN# +1.00070119"},
        {"Smithsonian Astrophysical Observation", "SAO 219765"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.65596792),
        dec: Angle.Degrees(-40.32890730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112191"},
        {"Hipparcos Number", "HIP 63047"},
        {"Smithsonian Astrophysical Observation", "SAO 223757"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.78179179),
        dec: Angle.Degrees(-40.32863145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111018"},
        {"Hipparcos Number", "HIP 62352"},
        {"Smithsonian Astrophysical Observation", "SAO 223663"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.64806850),
        dec: Angle.Degrees(-40.32487361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38937"},
        {"Hipparcos Number", "HIP 27329"},
        {"Smithsonian Astrophysical Observation", "SAO 217535"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.84071572),
        dec: Angle.Degrees(-40.32138727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15877"},
        {"Hipparcos Number", "HIP 11774"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.98594695),
        dec: Angle.Degrees(-40.32077811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75630"},
        {"Hipparcos Number", "HIP 43325"},
        {"Celescope Catalog", "CEL 2966"},
        {"Geneva Identification System", "GEN# +1.00075630"},
        {"Smithsonian Astrophysical Observation", "SAO 220531"},
        {"Wilson Evans Batten Catalogue", "WEB 8346"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.41319515),
        dec: Angle.Degrees(-40.32015599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159574"},
        {"Hipparcos Number", "HIP 86231"},
        {"Smithsonian Astrophysical Observation", "SAO 228204"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.33224637),
        dec: Angle.Degrees(-40.32011550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160617"},
        {"Hipparcos Number", "HIP 86694"},
        {"Cincinnati Publication", "Ci 20 1057"},
        {"Geneva Identification System", "GEN# +1.00160617"},
        {"Smithsonian Astrophysical Observation", "SAO 228318"},
        {"Wilson Evans Batten Catalogue", "WEB 14618"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.70571289),
        dec: Angle.Degrees(-40.32001762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -395.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34284"},
        {"Hipparcos Number", "HIP 24429"},
        {"Smithsonian Astrophysical Observation", "SAO 217248"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.62654926),
        dec: Angle.Degrees(-40.31975550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144007"},
        {"Hipparcos Number", "HIP 78801"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.31357405),
        dec: Angle.Degrees(-40.31954180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162020"},
        {"Hipparcos Number", "HIP 87330"},
        {"Geneva Identification System", "GEN# +1.00162020"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.65975616),
        dec: Angle.Degrees(-40.31828768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86230"},
    },
    visualMagnitude: 10.76,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.32999010),
        dec: Angle.Degrees(-40.31708548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181742"},
        {"Hipparcos Number", "HIP 95310"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.85585703),
        dec: Angle.Degrees(-40.31652289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152197"},
        {"Hipparcos Number", "HIP 82652"},
        {"Geneva Identification System", "GEN# +1.00152197"},
        {"Smithsonian Astrophysical Observation", "SAO 227363"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.43503383),
        dec: Angle.Degrees(-40.31639003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209120"},
        {"Hipparcos Number", "HIP 108765"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.49259280),
        dec: Angle.Degrees(-40.31600435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81634"},
        {"Hipparcos Number", "HIP 46244"},
        {"Smithsonian Astrophysical Observation", "SAO 221158"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.41457446),
        dec: Angle.Degrees(-40.31413841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214004"},
        {"Hipparcos Number", "HIP 111556"},
        {"Smithsonian Astrophysical Observation", "SAO 231207"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.00189949),
        dec: Angle.Degrees(-40.31338619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158143"},
        {"Hipparcos Number", "HIP 85595"},
        {"Smithsonian Astrophysical Observation", "SAO 228023"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.36535385),
        dec: Angle.Degrees(-40.31276487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88836"},
        {"Hipparcos Number", "HIP 50122"},
        {"Geneva Identification System", "GEN# +1.00088836"},
        {"Smithsonian Astrophysical Observation", "SAO 221883"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.48575382),
        dec: Angle.Degrees(-40.31075244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62753"},
        {"Hipparcos Number", "HIP 37675"},
        {"Celescope Catalog", "CEL 2003"},
        {"Geneva Identification System", "GEN# +1.00062753"},
        {"Smithsonian Astrophysical Observation", "SAO 218935"},
        {"Wilson Evans Batten Catalogue", "WEB 7449"},
    },
    visualMagnitude: 6.58,
    bvColour: -0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.94965675),
        dec: Angle.Degrees(-40.30932809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96033"},
        {"Hipparcos Number", "HIP 54095"},
        {"Geneva Identification System", "GEN# +1.00096033"},
        {"Smithsonian Astrophysical Observation", "SAO 222533"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.03091707),
        dec: Angle.Degrees(-40.30856255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103041"},
        {"Hipparcos Number", "HIP 57840"},
        {"Smithsonian Astrophysical Observation", "SAO 223073"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.92131993),
        dec: Angle.Degrees(-40.30769131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166198"},
        {"Hipparcos Number", "HIP 89121"},
        {"Geneva Identification System", "GEN# +1.00166198"},
        {"Smithsonian Astrophysical Observation", "SAO 228782"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.83550727),
        dec: Angle.Degrees(-40.30704978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163234"},
        {"Hipparcos Number", "HIP 87865"},
        {"Geneva Identification System", "GEN# +1.00163234"},
        {"Smithsonian Astrophysical Observation", "SAO 228564"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.23285579),
        dec: Angle.Degrees(-40.30564844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13847",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Acamar"},
        {"Hipparcos Number", "HIP 13847"},
        {"Geneva Identification System", "GEN# +1.00018622"},
    },
    visualMagnitude: 2.88,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.56548180),
        dec: Angle.Degrees(-40.30473491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5025"},
        {"Hipparcos Number", "HIP 4045"},
        {"Smithsonian Astrophysical Observation", "SAO 215269"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.96063749),
        dec: Angle.Degrees(-40.30447920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141427"},
        {"Hipparcos Number", "HIP 77604"},
        {"Smithsonian Astrophysical Observation", "SAO 226278"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.64280380),
        dec: Angle.Degrees(-40.30447895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169146"},
        {"Hipparcos Number", "HIP 90264"},
        {"Smithsonian Astrophysical Observation", "SAO 229001"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.26898982),
        dec: Angle.Degrees(-40.30341348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101233"},
        {"Hipparcos Number", "HIP 56813"},
        {"Smithsonian Astrophysical Observation", "SAO 222931"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.69618130),
        dec: Angle.Degrees(-40.30309011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149425"},
        {"Hipparcos Number", "HIP 81316"},
        {"Smithsonian Astrophysical Observation", "SAO 226957"},
        {"Wilson Evans Batten Catalogue", "WEB 13744"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.11950864),
        dec: Angle.Degrees(-40.30298186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221201"},
        {"Hipparcos Number", "HIP 115998"},
        {"Smithsonian Astrophysical Observation", "SAO 231634"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.54099776),
        dec: Angle.Degrees(-40.30252808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161688"},
        {"Hipparcos Number", "HIP 87195"},
        {"Smithsonian Astrophysical Observation", "SAO 228443"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.21362059),
        dec: Angle.Degrees(-40.30042359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182881"},
        {"Hipparcos Number", "HIP 95750"},
        {"Geneva Identification System", "GEN# +1.00182881"},
        {"Smithsonian Astrophysical Observation", "SAO 229703"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.11841911),
        dec: Angle.Degrees(-40.30026709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111048"},
        {"Hipparcos Number", "HIP 62368"},
        {"Smithsonian Astrophysical Observation", "SAO 223666"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.71757056),
        dec: Angle.Degrees(-40.30016608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224022"},
        {"Hipparcos Number", "HIP 117880"},
        {"Fundamental Katalog 5th Edition", "FK5 1626"},
        {"Geneva Identification System", "GEN# +1.00224022"},
        {"Smithsonian Astrophysical Observation", "SAO 231842"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.65975186),
        dec: Angle.Degrees(-40.30013654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 367.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76500"},
        {"Smithsonian Astrophysical Observation", "SAO 140658"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.36525180),
        dec: Angle.Degrees(-07.58304533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124540"},
        {"Hipparcos Number", "HIP 69649"},
        {"Geneva Identification System", "GEN# +1.00124540"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.82001958),
        dec: Angle.Degrees(-40.29803388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71983"},
        {"Hipparcos Number", "HIP 41593"},
        {"Renson", "Renson 19870"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.19738626),
        dec: Angle.Degrees(-40.29602965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59302"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.49479393),
        dec: Angle.Degrees(-40.29516612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20854"},
        {"Hipparcos Number", "HIP 15537"},
        {"Smithsonian Astrophysical Observation", "SAO 216266"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.03932892),
        dec: Angle.Degrees(-40.29448511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218204"},
        {"Hipparcos Number", "HIP 114108"},
        {"Smithsonian Astrophysical Observation", "SAO 231442"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.65642531),
        dec: Angle.Degrees(-40.29400731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48382"},
        {"Hipparcos Number", "HIP 32013"},
        {"Smithsonian Astrophysical Observation", "SAO 218127"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.32552892),
        dec: Angle.Degrees(-40.29283443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102541"},
        {"Hipparcos Number", "HIP 57567"},
        {"Geneva Identification System", "GEN# +1.00102541"},
        {"Smithsonian Astrophysical Observation", "SAO 223032"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.99908183),
        dec: Angle.Degrees(-40.29145980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150441"},
        {"Hipparcos Number", "HIP 81824"},
        {"Smithsonian Astrophysical Observation", "SAO 227088"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.70860320),
        dec: Angle.Degrees(-40.28940418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1857"},
        {"Hipparcos Number", "HIP 1793"},
        {"Geneva Identification System", "GEN# +1.00001857"},
        {"Smithsonian Astrophysical Observation", "SAO 215070"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.69522349),
        dec: Angle.Degrees(-40.28866179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158127"},
        {"Hipparcos Number", "HIP 85584"},
        {"Smithsonian Astrophysical Observation", "SAO 228021"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.33681784),
        dec: Angle.Degrees(-40.28787425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12902"},
        {"Hipparcos Number", "HIP 9752"},
        {"Smithsonian Astrophysical Observation", "SAO 215764"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.35010960),
        dec: Angle.Degrees(-40.28771186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195864"},
        {"Hipparcos Number", "HIP 101591"},
        {"Smithsonian Astrophysical Observation", "SAO 230285"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.83418971),
        dec: Angle.Degrees(-40.28467701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1464"},
        {"Hipparcos Number", "HIP 1491"},
        {"Geneva Identification System", "GEN# +1.00001464"},
        {"Smithsonian Astrophysical Observation", "SAO 215045"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.63831267),
        dec: Angle.Degrees(-40.28450002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211655"},
        {"Hipparcos Number", "HIP 110202"},
        {"Smithsonian Astrophysical Observation", "SAO 231081"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.84166741),
        dec: Angle.Degrees(-40.28402190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45306"},
        {"Hipparcos Number", "HIP 30505"},
        {"Fundamental Katalog 5th Edition", "FK5 2492"},
        {"Geneva Identification System", "GEN# +1.00045306"},
        {"Smithsonian Astrophysical Observation", "SAO 217910"},
        {"Wilson Evans Batten Catalogue", "WEB 6073"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.18541147),
        dec: Angle.Degrees(-40.28397042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68155"},
        {"Hipparcos Number", "HIP 39963"},
        {"Smithsonian Astrophysical Observation", "SAO 219496"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.40371641),
        dec: Angle.Degrees(-40.28348245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98459"},
        {"Hipparcos Number", "HIP 55278"},
        {"Geneva Identification System", "GEN# +1.00098459"},
        {"Smithsonian Astrophysical Observation", "SAO 222712"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.81553346),
        dec: Angle.Degrees(-40.28207433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210396"},
        {"Hipparcos Number", "HIP 109510"},
        {"Smithsonian Astrophysical Observation", "SAO 231018"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.76301727),
        dec: Angle.Degrees(-40.28104402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160069"},
        {"Hipparcos Number", "HIP 86451"},
        {"Smithsonian Astrophysical Observation", "SAO 228255"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.96386042),
        dec: Angle.Degrees(-40.27858008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71966"},
        {"Hipparcos Number", "HIP 41587"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.17997770),
        dec: Angle.Degrees(-40.27678323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17170"},
        {"Hipparcos Number", "HIP 12758"},
        {"Smithsonian Astrophysical Observation", "SAO 216025"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.99150121),
        dec: Angle.Degrees(-40.27675994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102791"},
        {"Hipparcos Number", "HIP 57700"},
        {"Smithsonian Astrophysical Observation", "SAO 202851"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.49893553),
        dec: Angle.Degrees(-40.27634877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61927"},
        {"Hipparcos Number", "HIP 37325"},
        {"Smithsonian Astrophysical Observation", "SAO 218875"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.93746881),
        dec: Angle.Degrees(-40.27608315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82549"},
        {"Hipparcos Number", "HIP 46723"},
        {"Geneva Identification System", "GEN# +1.00082549"},
        {"Smithsonian Astrophysical Observation", "SAO 221245"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.86704773),
        dec: Angle.Degrees(-40.27574428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22663"},
        {"Hipparcos Number", "HIP 16870"},
        {"Fundamental Katalog 5th Edition", "FK5 130"},
        {"Geneva Identification System", "GEN# +1.00022663"},
        {"Smithsonian Astrophysical Observation", "SAO 216405"},
        {"Wilson Evans Batten Catalogue", "WEB 3207"},
    },
    visualMagnitude: 4.57,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.27365880),
        dec: Angle.Degrees(-40.27451075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108963"},
        {"Hipparcos Number", "HIP 61111"},
        {"Smithsonian Astrophysical Observation", "SAO 203554"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.87163964),
        dec: Angle.Degrees(-40.27445433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79829"},
        {"Hipparcos Number", "HIP 45392"},
        {"Celescope Catalog", "CEL 3239"},
        {"Smithsonian Astrophysical Observation", "SAO 220990"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.75329552),
        dec: Angle.Degrees(-40.27323608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168214"},
        {"Hipparcos Number", "HIP 89881"},
        {"Geneva Identification System", "GEN# +1.00168214"},
        {"Smithsonian Astrophysical Observation", "SAO 228931"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.11196207),
        dec: Angle.Degrees(-40.27263927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21043"},
        {"Hipparcos Number", "HIP 15706"},
        {"Geneva Identification System", "GEN# +1.00021043"},
        {"Smithsonian Astrophysical Observation", "SAO 216281"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.58043329),
        dec: Angle.Degrees(-40.27240384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139082"},
        {"Hipparcos Number", "HIP 76521"},
        {"Geneva Identification System", "GEN# +1.00139082"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.41464562),
        dec: Angle.Degrees(-40.27106368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213033"},
        {"Hipparcos Number", "HIP 111000"},
        {"Geneva Identification System", "GEN# +1.00213033"},
        {"Smithsonian Astrophysical Observation", "SAO 231156"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.32659494),
        dec: Angle.Degrees(-40.27038241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6493"},
        {"Hipparcos Number", "HIP 5099"},
        {"Geneva Identification System", "GEN# +1.00006493"},
        {"Smithsonian Astrophysical Observation", "SAO 215355"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.34125379),
        dec: Angle.Degrees(-40.26995916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201647"},
        {"Hipparcos Number", "HIP 104680"},
        {"Geneva Identification System", "GEN# +1.00201647"},
        {"Smithsonian Astrophysical Observation", "SAO 230575"},
        {"Wilson Evans Batten Catalogue", "WEB 19043"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.05695050),
        dec: Angle.Degrees(-40.26882840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91250"},
        {"Hipparcos Number", "HIP 51526"},
        {"Smithsonian Astrophysical Observation", "SAO 222116"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.85818518),
        dec: Angle.Degrees(-40.26873584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69466"},
        {"Hipparcos Number", "HIP 40454"},
        {"Smithsonian Astrophysical Observation", "SAO 219682"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.89244373),
        dec: Angle.Degrees(-40.26821914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12386"},
        {"Hipparcos Number", "HIP 9384"},
        {"Geneva Identification System", "GEN# +1.00012386"},
        {"Smithsonian Astrophysical Observation", "SAO 215735"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.14131308),
        dec: Angle.Degrees(-40.26782503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76477"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.29713725),
        dec: Angle.Degrees(-40.26571976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41200"},
        {"Hipparcos Number", "HIP 28551"},
        {"Smithsonian Astrophysical Observation", "SAO 217676"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.41004557),
        dec: Angle.Degrees(-40.26490714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74067"},
        {"Hipparcos Number", "HIP 42540"},
        {"Celescope Catalog", "CEL 2754"},
        {"Geneva Identification System", "GEN# +1.00074067J"},
        {"Renson", "Renson 20630"},
        {"Smithsonian Astrophysical Observation", "SAO 220252"},
        {"Wilson Evans Batten Catalogue", "WEB 8203"},
    },
    visualMagnitude: 5.20,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.08007139),
        dec: Angle.Degrees(-40.26389330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218492"},
        {"Hipparcos Number", "HIP 114287"},
        {"Smithsonian Astrophysical Observation", "SAO 231457"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.20867485),
        dec: Angle.Degrees(-40.26361868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211238"},
        {"Hipparcos Number", "HIP 109987"},
        {"Smithsonian Astrophysical Observation", "SAO 231066"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.14770174),
        dec: Angle.Degrees(-40.26105911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93197"},
        {"Hipparcos Number", "HIP 52583"},
        {"Smithsonian Astrophysical Observation", "SAO 201711"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.28574820),
        dec: Angle.Degrees(-40.26001135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169854"},
        {"Hipparcos Number", "HIP 90538"},
        {"Smithsonian Astrophysical Observation", "SAO 229045"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.10226507),
        dec: Angle.Degrees(-40.25904996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52585"},
    },
    visualMagnitude: 9.03,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)45, 10.1300),
        dec: Angle.DegreesMinutesSeconds((int)-40, (int)15, 30.900)
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
    primaryId: "HIP 15067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20270"},
        {"Hipparcos Number", "HIP 15067"},
        {"Smithsonian Astrophysical Observation", "SAO 216223"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.54636183),
        dec: Angle.Degrees(-40.25565035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207144"},
        {"Hipparcos Number", "HIP 107625"},
        {"Geneva Identification System", "GEN# +1.00207144"},
        {"Smithsonian Astrophysical Observation", "SAO 230844"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.99984672),
        dec: Angle.Degrees(-40.25522434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -351.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38704"},
        {"Hipparcos Number", "HIP 27187"},
        {"Smithsonian Astrophysical Observation", "SAO 217515"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.44151136),
        dec: Angle.Degrees(-40.25486013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203463"},
        {"Hipparcos Number", "HIP 105619"},
        {"Geneva Identification System", "GEN# +1.00203463"},
        {"Smithsonian Astrophysical Observation", "SAO 230660"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.88245090),
        dec: Angle.Degrees(-40.25438673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57017"},
        {"Hipparcos Number", "HIP 35319"},
        {"Smithsonian Astrophysical Observation", "SAO 218610"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.42942470),
        dec: Angle.Degrees(-40.25334508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162785"},
        {"Hipparcos Number", "HIP 87688"},
        {"Smithsonian Astrophysical Observation", "SAO 228534"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.66121155),
        dec: Angle.Degrees(-40.25296460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210350"},
        {"Hipparcos Number", "HIP 109482"},
        {"Smithsonian Astrophysical Observation", "SAO 231012"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.68939682),
        dec: Angle.Degrees(-40.25253249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95426"},
        {"Hipparcos Number", "HIP 53793"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.09249812),
        dec: Angle.Degrees(-40.25193740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220882"},
        {"Hipparcos Number", "HIP 115799"},
        {"Geneva Identification System", "GEN# +1.00220882"},
        {"Smithsonian Astrophysical Observation", "SAO 231614"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.90079182),
        dec: Angle.Degrees(-40.25158166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176790"},
        {"Hipparcos Number", "HIP 93611"},
        {"Geneva Identification System", "GEN# +1.00176790"},
        {"Smithsonian Astrophysical Observation", "SAO 229468"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.94791809),
        dec: Angle.Degrees(-40.25122853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10903"},
        {"Hipparcos Number", "HIP 8249"},
        {"Smithsonian Astrophysical Observation", "SAO 215639"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.54827998),
        dec: Angle.Degrees(-40.24804367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90336"},
        {"Hipparcos Number", "HIP 50989"},
        {"Smithsonian Astrophysical Observation", "SAO 201370"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.23950906),
        dec: Angle.Degrees(-40.24783084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123268"},
        {"Hipparcos Number", "HIP 68999"},
        {"Smithsonian Astrophysical Observation", "SAO 224705"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.89161484),
        dec: Angle.Degrees(-40.24543337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19051"},
        {"Hipparcos Number", "HIP 14158"},
        {"Smithsonian Astrophysical Observation", "SAO 216147"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.64137153),
        dec: Angle.Degrees(-40.24470011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117988"},
        {"Hipparcos Number", "HIP 66255"},
        {"Smithsonian Astrophysical Observation", "SAO 204610"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.68214745),
        dec: Angle.Degrees(-40.24313371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69837"},
        {"Hipparcos Number", "HIP 40588"},
        {"Geneva Identification System", "GEN# +1.00069837"},
        {"Smithsonian Astrophysical Observation", "SAO 219728"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.31107657),
        dec: Angle.Degrees(-40.24150039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89393"},
        {"Hipparcos Number", "HIP 50454"},
        {"Smithsonian Astrophysical Observation", "SAO 201260"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.52684870),
        dec: Angle.Degrees(-40.23937522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175481"},
        {"Hipparcos Number", "HIP 93066"},
        {"Smithsonian Astrophysical Observation", "SAO 229401"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.35679745),
        dec: Angle.Degrees(-40.23905420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91538"},
        {"Hipparcos Number", "HIP 51686"},
        {"Geneva Identification System", "GEN# +1.00091538"},
        {"Smithsonian Astrophysical Observation", "SAO 201512"},
        {"Wilson Evans Batten Catalogue", "WEB 9425"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.37962518),
        dec: Angle.Degrees(-40.23836887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186235"},
        {"Hipparcos Number", "HIP 97160"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.23359221),
        dec: Angle.Degrees(-40.23681437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8239"},
        {"Hipparcos Number", "HIP 6317"},
        {"Smithsonian Astrophysical Observation", "SAO 215467"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.28485129),
        dec: Angle.Degrees(-40.23263373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73285"},
        {"Hipparcos Number", "HIP 42192"},
        {"Geneva Identification System", "GEN# +1.00073285"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.04513672),
        dec: Angle.Degrees(-40.22698325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66650"},
        {"Hipparcos Number", "HIP 39370"},
        {"Smithsonian Astrophysical Observation", "SAO 219342"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.72872573),
        dec: Angle.Degrees(-40.22629506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192941"},
        {"Hipparcos Number", "HIP 100166"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.76709415),
        dec: Angle.Degrees(-40.22480168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122210"},
        {"Hipparcos Number", "HIP 68493"},
        {"Geneva Identification System", "GEN# +1.00122210"},
        {"Smithsonian Astrophysical Observation", "SAO 205096"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.32950276),
        dec: Angle.Degrees(-40.22194466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154836"},
        {"Hipparcos Number", "HIP 83959"},
        {"Smithsonian Astrophysical Observation", "SAO 227681"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.43176035),
        dec: Angle.Degrees(-40.22186502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198998"},
        {"Hipparcos Number", "HIP 103286"},
        {"Smithsonian Astrophysical Observation", "SAO 230439"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.87588909),
        dec: Angle.Degrees(-40.21865186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28789"},
        {"Hipparcos Number", "HIP 21030"},
        {"Geneva Identification System", "GEN# +1.00028789"},
        {"Smithsonian Astrophysical Observation", "SAO 216843"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.63988124),
        dec: Angle.Degrees(-40.21847841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53310"},
    },
    visualMagnitude: 10.82,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)54, 12.2300),
        dec: Angle.DegreesMinutesSeconds((int)-40, (int)12, 56.100)
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
    primaryId: "HIP 88266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 324758"},
        {"Hipparcos Number", "HIP 88266"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.37295233),
        dec: Angle.Degrees(-40.21482917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6140"},
        {"Hipparcos Number", "HIP 4826"},
        {"Geneva Identification System", "GEN# +1.00006140"},
        {"Smithsonian Astrophysical Observation", "SAO 215332"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.50031902),
        dec: Angle.Degrees(-40.21404447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85996"},
        {"Hipparcos Number", "HIP 48599"},
        {"Smithsonian Astrophysical Observation", "SAO 200858"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.66319111),
        dec: Angle.Degrees(-40.21283202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128207"},
        {"Hipparcos Number", "HIP 71453"},
        {"Geneva Identification System", "GEN# +1.00128207"},
        {"Smithsonian Astrophysical Observation", "SAO 205751"},
        {"Wilson Evans Batten Catalogue", "WEB 12327"},
    },
    visualMagnitude: 5.74,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.18396076),
        dec: Angle.Degrees(-40.21152639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148686"},
        {"Hipparcos Number", "HIP 80924"},
        {"Geneva Identification System", "GEN# +1.00148686"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.87498357),
        dec: Angle.Degrees(-40.21093030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166298"},
        {"Hipparcos Number", "HIP 89150"},
        {"Smithsonian Astrophysical Observation", "SAO 228791"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.92585694),
        dec: Angle.Degrees(-40.21072684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72647"},
        {"Hipparcos Number", "HIP 41890"},
        {"Geneva Identification System", "GEN# +1.00072647"},
        {"Smithsonian Astrophysical Observation", "SAO 220066"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.12975204),
        dec: Angle.Degrees(-40.21029117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -244.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 205.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94528"},
        {"Hipparcos Number", "HIP 53307"},
        {"Smithsonian Astrophysical Observation", "SAO 201878"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.54909300),
        dec: Angle.Degrees(-40.20990269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157193"},
        {"Hipparcos Number", "HIP 85114"},
        {"Smithsonian Astrophysical Observation", "SAO 227905"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.93053196),
        dec: Angle.Degrees(-40.20917947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29046"},
        {"Hipparcos Number", "HIP 21190"},
        {"Smithsonian Astrophysical Observation", "SAO 216863"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.14735216),
        dec: Angle.Degrees(-40.20830798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187357"},
        {"Hipparcos Number", "HIP 97688"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.80036989),
        dec: Angle.Degrees(-40.20491865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 325013"},
        {"Hipparcos Number", "HIP 88933"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.30162312),
        dec: Angle.Degrees(-40.20362103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210622"},
        {"Hipparcos Number", "HIP 109631"},
        {"Smithsonian Astrophysical Observation", "SAO 231028"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.12445962),
        dec: Angle.Degrees(-40.20301596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213773"},
        {"Hipparcos Number", "HIP 111428"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.61881332),
        dec: Angle.Degrees(-40.20291708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189246"},
        {"Hipparcos Number", "HIP 98501"},
        {"Geneva Identification System", "GEN# +1.00189246"},
        {"Smithsonian Astrophysical Observation", "SAO 229983"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.17358858),
        dec: Angle.Degrees(-40.20017833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38612"},
        {"Hipparcos Number", "HIP 27122"},
        {"Smithsonian Astrophysical Observation", "SAO 217509"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.27665788),
        dec: Angle.Degrees(-40.19893969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204807"},
        {"Hipparcos Number", "HIP 106336"},
        {"Geneva Identification System", "GEN# +1.00204807"},
        {"Smithsonian Astrophysical Observation", "SAO 230729"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.04798994),
        dec: Angle.Degrees(-40.19770161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28430"},
        {"Hipparcos Number", "HIP 20795"},
        {"Renson", "Renson 7300"},
        {"Smithsonian Astrophysical Observation", "SAO 216810"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.84377299),
        dec: Angle.Degrees(-40.19728037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66187"},
        {"Hipparcos Number", "HIP 39170"},
        {"Smithsonian Astrophysical Observation", "SAO 219287"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.17421675),
        dec: Angle.Degrees(-40.19687863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140861"},
        {"Hipparcos Number", "HIP 77350"},
        {"Geneva Identification System", "GEN# +1.00140861"},
        {"Smithsonian Astrophysical Observation", "SAO 226206"},
        {"Wilson Evans Batten Catalogue", "WEB 13101"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.85682665),
        dec: Angle.Degrees(-40.19410649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18184"},
        {"Hipparcos Number", "HIP 13499"},
        {"Geneva Identification System", "GEN# +1.00018184"},
        {"Smithsonian Astrophysical Observation", "SAO 216085"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.46578911),
        dec: Angle.Degrees(-40.19403787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62382",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62382"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.76830305),
        dec: Angle.Degrees(-40.19379986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51159"},
        {"Hipparcos Number", "HIP 33185"},
        {"Smithsonian Astrophysical Observation", "SAO 218295"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.60470446),
        dec: Angle.Degrees(-40.19316121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224732"},
        {"Hipparcos Number", "HIP 17"},
        {"Geneva Identification System", "GEN# +1.00224732"},
        {"Smithsonian Astrophysical Observation", "SAO 231884"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.05109957),
        dec: Angle.Degrees(-40.19232842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61332"},
        {"Hipparcos Number", "HIP 37060"},
        {"Geneva Identification System", "GEN# +1.00061332"},
        {"Smithsonian Astrophysical Observation", "SAO 218839"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.24089225),
        dec: Angle.Degrees(-40.19204575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55596"},
        {"Hipparcos Number", "HIP 34761"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.93794300),
        dec: Angle.Degrees(-40.19168473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29666"},
        {"Hipparcos Number", "HIP 21622"},
        {"Geneva Identification System", "GEN# +1.00029666"},
        {"Smithsonian Astrophysical Observation", "SAO 216912"},
        {"Wilson Evans Batten Catalogue", "WEB 4154"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.63455324),
        dec: Angle.Degrees(-40.18508975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 179.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192724"},
        {"Hipparcos Number", "HIP 100045"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.45684902),
        dec: Angle.Degrees(-40.18478474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133320"},
        {"Hipparcos Number", "HIP 73806"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.27909548),
        dec: Angle.Degrees(-40.18306765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223011"},
        {"Hipparcos Number", "HIP 117219"},
        {"Geneva Identification System", "GEN# +1.00223011"},
        {"Smithsonian Astrophysical Observation", "SAO 231769"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.50490918),
        dec: Angle.Degrees(-40.18247763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111968"},
        {"Hipparcos Number", "HIP 62896"},
        {"Fundamental Katalog 5th Edition", "FK5 482"},
        {"Geneva Identification System", "GEN# +1.00111968"},
        {"Smithsonian Astrophysical Observation", "SAO 203907"},
        {"Wilson Evans Batten Catalogue", "WEB 11152"},
    },
    visualMagnitude: 4.25,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.35894159),
        dec: Angle.Degrees(-40.17881857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119415"},
        {"Hipparcos Number", "HIP 66997"},
        {"Smithsonian Astrophysical Observation", "SAO 204777"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.95611612),
        dec: Angle.Degrees(-40.17795679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110575"},
        {"Hipparcos Number", "HIP 62081"},
        {"Geneva Identification System", "GEN# +1.00110575"},
        {"Renson", "Renson 32150"},
        {"Smithsonian Astrophysical Observation", "SAO 203746"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.85934803),
        dec: Angle.Degrees(-40.17781019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10038"},
        {"Hipparcos Number", "HIP 7552"},
        {"Geneva Identification System", "GEN# +1.00010038"},
        {"Renson", "Renson 2480"},
        {"Smithsonian Astrophysical Observation", "SAO 215584"},
        {"Wilson Evans Batten Catalogue", "WEB 1616"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.32750548),
        dec: Angle.Degrees(-40.17732995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220163"},
        {"Hipparcos Number", "HIP 115358"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.49124409),
        dec: Angle.Degrees(-40.17429962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3197"},
        {"Hipparcos Number", "HIP 2738"},
        {"Smithsonian Astrophysical Observation", "SAO 215150"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.74510200),
        dec: Angle.Degrees(-40.17328989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43719"},
        {"Hipparcos Number", "HIP 29745"},
        {"Smithsonian Astrophysical Observation", "SAO 217812"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.97058990),
        dec: Angle.Degrees(-40.17179875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112134"},
        {"Hipparcos Number", "HIP 63001"},
        {"Smithsonian Astrophysical Observation", "SAO 203925"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.64420727),
        dec: Angle.Degrees(-40.16977905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85323"},
        {"Hipparcos Number", "HIP 48234"},
        {"Smithsonian Astrophysical Observation", "SAO 200787"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.50641470),
        dec: Angle.Degrees(-40.16903618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129640"},
        {"Hipparcos Number", "HIP 72086"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.19857097),
        dec: Angle.Degrees(-40.16851281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137786"},
        {"Hipparcos Number", "HIP 75824"},
        {"Geneva Identification System", "GEN# +1.00137786"},
        {"Smithsonian Astrophysical Observation", "SAO 206696"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.34633169),
        dec: Angle.Degrees(-40.16382783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107107"},
        {"Hipparcos Number", "HIP 60069"},
        {"Renson", "Renson 30990"},
        {"Smithsonian Astrophysical Observation", "SAO 203341"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.77035795),
        dec: Angle.Degrees(-40.16321143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221927"},
        {"Hipparcos Number", "HIP 116501"},
        {"Smithsonian Astrophysical Observation", "SAO 231690"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.11447094),
        dec: Angle.Degrees(-40.16313020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116873"},
        {"Hipparcos Number", "HIP 65621"},
        {"Geneva Identification System", "GEN# +1.00116873"},
        {"Smithsonian Astrophysical Observation", "SAO 204483"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.81114289),
        dec: Angle.Degrees(-40.16269074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208592"},
        {"Hipparcos Number", "HIP 108455"},
        {"Smithsonian Astrophysical Observation", "SAO 230918"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.55722026),
        dec: Angle.Degrees(-40.16018667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76978"},
    },
    visualMagnitude: 12.22,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.76821466),
        dec: Angle.Degrees(-40.15745506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87675"},
        {"Hipparcos Number", "HIP 49449"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.43162125),
        dec: Angle.Degrees(-40.15618756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138995"},
        {"Hipparcos Number", "HIP 76472"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.26947820),
        dec: Angle.Degrees(-40.15608628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14769"},
        {"Hipparcos Number", "HIP 10996"},
        {"Smithsonian Astrophysical Observation", "SAO 215871"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.42783464),
        dec: Angle.Degrees(-40.15529626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37780"},
        {"Hipparcos Number", "HIP 26595"},
        {"Smithsonian Astrophysical Observation", "SAO 217453"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.79745397),
        dec: Angle.Degrees(-40.15305740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9989"},
        {"Hipparcos Number", "HIP 7510"},
        {"Smithsonian Astrophysical Observation", "SAO 215580"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.19001194),
        dec: Angle.Degrees(-40.14877440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224914"},
        {"Hipparcos Number", "HIP 133"},
        {"Geneva Identification System", "GEN# +1.00224914"},
        {"Smithsonian Astrophysical Observation", "SAO 231901"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.42336890),
        dec: Angle.Degrees(-40.14866597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73524"},
        {"Hipparcos Number", "HIP 42291"},
        {"Geneva Identification System", "GEN# +1.00073524"},
        {"Smithsonian Astrophysical Observation", "SAO 199438"},
        {"Wilson Evans Batten Catalogue", "WEB 8125"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.33427475),
        dec: Angle.Degrees(-40.14774379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -304.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47870"},
        {"Smithsonian Astrophysical Observation", "SAO 200702"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.34307438),
        dec: Angle.Degrees(-40.14708416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39601"},
        {"Hipparcos Number", "HIP 27691"},
        {"Geneva Identification System", "GEN# +1.00039601"},
        {"Smithsonian Astrophysical Observation", "SAO 217577"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.94046141),
        dec: Angle.Degrees(-40.14656350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6958"},
        {"Hipparcos Number", "HIP 5437"},
        {"Geneva Identification System", "GEN# +1.00006958"},
        {"Smithsonian Astrophysical Observation", "SAO 215388"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.39155485),
        dec: Angle.Degrees(-40.14225548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41199"},
        {"Hipparcos Number", "HIP 28554"},
        {"Smithsonian Astrophysical Observation", "SAO 217677"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.41469845),
        dec: Angle.Degrees(-40.13686546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126559"},
        {"Hipparcos Number", "HIP 70675"},
        {"Smithsonian Astrophysical Observation", "SAO 205573"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.82878896),
        dec: Angle.Degrees(-40.13369043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113942"},
    },
    visualMagnitude: 11.17,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.11266262),
        dec: Angle.Degrees(-40.13074905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64927"},
        {"Hipparcos Number", "HIP 38624"},
        {"Smithsonian Astrophysical Observation", "SAO 198580"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.63781896),
        dec: Angle.Degrees(-40.13074439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144965"},
        {"Hipparcos Number", "HIP 79230"},
        {"Geneva Identification System", "GEN# +1.00144965J"},
        {"Smithsonian Astrophysical Observation", "SAO 207407"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.54399853),
        dec: Angle.Degrees(-40.12880718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215120"},
        {"Hipparcos Number", "HIP 112205"},
        {"Smithsonian Astrophysical Observation", "SAO 231266"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.87586675),
        dec: Angle.Degrees(-40.12874765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40556"},
        {"Hipparcos Number", "HIP 28209"},
        {"Geneva Identification System", "GEN# +1.00040556"},
        {"Smithsonian Astrophysical Observation", "SAO 217640"},
        {"Wilson Evans Batten Catalogue", "WEB 5521"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.40754027),
        dec: Angle.Degrees(-40.12785427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145173"},
        {"Hipparcos Number", "HIP 79311"},
        {"Geneva Identification System", "GEN# +1.00145173"},
        {"Smithsonian Astrophysical Observation", "SAO 207423"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.78992510),
        dec: Angle.Degrees(-40.12785108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107076"},
        {"Hipparcos Number", "HIP 60048"},
        {"Geneva Identification System", "GEN# +1.00107076"},
        {"Smithsonian Astrophysical Observation", "SAO 203336"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.72509422),
        dec: Angle.Degrees(-40.12767312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161471"},
        {"Hipparcos Number", "HIP 87073"},
        {"Fundamental Katalog 5th Edition", "FK5 666"},
        {"Geneva Identification System", "GEN# +1.00161471"},
        {"Smithsonian Astrophysical Observation", "SAO 228420"},
        {"Wilson Evans Batten Catalogue", "WEB 14690"},
    },
    visualMagnitude: 2.99,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.89617137),
        dec: Angle.Degrees(-40.12698197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121912"},
        {"Hipparcos Number", "HIP 68329"},
        {"Geneva Identification System", "GEN# +1.00121912"},
        {"Smithsonian Astrophysical Observation", "SAO 205064"},
        {"New General Catalogue", "NGC 5367 13"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.81331266),
        dec: Angle.Degrees(-40.12423232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65592"},
        {"Hipparcos Number", "HIP 38907"},
        {"Geneva Identification System", "GEN# +1.00065592"},
        {"Smithsonian Astrophysical Observation", "SAO 198641"},
        {"Wilson Evans Batten Catalogue", "WEB 7625"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.44032376),
        dec: Angle.Degrees(-40.12337127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1530"},
        {"Hipparcos Number", "HIP 1552"},
        {"Geneva Identification System", "GEN# +1.00001530"},
        {"Smithsonian Astrophysical Observation", "SAO 215051"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.83911575),
        dec: Angle.Degrees(-40.12056208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -257.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212577"},
        {"Hipparcos Number", "HIP 110732"},
        {"Smithsonian Astrophysical Observation", "SAO 231136"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.51779436),
        dec: Angle.Degrees(-40.11969685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21939"},
        {"Hipparcos Number", "HIP 16353"},
        {"Geneva Identification System", "GEN# +1.00021939"},
        {"Smithsonian Astrophysical Observation", "SAO 216355"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.67482799),
        dec: Angle.Degrees(-40.11859137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80171"},
        {"Hipparcos Number", "HIP 45542"},
        {"Smithsonian Astrophysical Observation", "SAO 200184"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.23338681),
        dec: Angle.Degrees(-40.11664176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61231"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32, 49.5700),
        dec: Angle.DegreesMinutesSeconds((int)-40, (int)06, 58.900)
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
    primaryId: "HIP 115299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220070"},
        {"Hipparcos Number", "HIP 115299"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.28311046),
        dec: Angle.Degrees(-40.11572040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159706"},
        {"Hipparcos Number", "HIP 86296"},
        {"Smithsonian Astrophysical Observation", "SAO 228219"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.49633365),
        dec: Angle.Degrees(-40.11455721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32930"},
        {"Hipparcos Number", "HIP 23637"},
        {"Smithsonian Astrophysical Observation", "SAO 217160"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.21234363),
        dec: Angle.Degrees(-40.11434617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199685"},
        {"Hipparcos Number", "HIP 103662"},
        {"Smithsonian Astrophysical Observation", "SAO 230474"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.05154372),
        dec: Angle.Degrees(-40.11271748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160894"},
        {"Hipparcos Number", "HIP 86810"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.07316237),
        dec: Angle.Degrees(-40.11055438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18277"},
        {"Hipparcos Number", "HIP 13566"},
        {"Smithsonian Astrophysical Observation", "SAO 216093"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.68989427),
        dec: Angle.Degrees(-40.10843888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19201"},
        {"Hipparcos Number", "HIP 14271"},
        {"Smithsonian Astrophysical Observation", "SAO 216155"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.99860792),
        dec: Angle.Degrees(-40.10652807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137751"},
        {"Hipparcos Number", "HIP 75808"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.29520203),
        dec: Angle.Degrees(-40.10586126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7955"},
        {"Hipparcos Number", "HIP 6107"},
        {"Geneva Identification System", "GEN# +1.00007955"},
        {"Smithsonian Astrophysical Observation", "SAO 215448"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.59886561),
        dec: Angle.Degrees(-40.10466692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54932"},
        {"Geneva Identification System", "GEN# -0.03906992"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.72976909),
        dec: Angle.Degrees(-40.10410378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5935"},
        {"Hipparcos Number", "HIP 4694"},
        {"Smithsonian Astrophysical Observation", "SAO 215323"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.07999132),
        dec: Angle.Degrees(-40.10303196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95760"},
        {"Hipparcos Number", "HIP 53981"},
        {"Smithsonian Astrophysical Observation", "SAO 202030"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.64487713),
        dec: Angle.Degrees(-40.10186899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55138"},
        {"Smithsonian Astrophysical Observation", "SAO 202285"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.32303754),
        dec: Angle.Degrees(-40.10169398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124539"},
        {"Hipparcos Number", "HIP 69646"},
        {"Geneva Identification System", "GEN# +1.00124539"},
        {"Smithsonian Astrophysical Observation", "SAO 205351"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.81542109),
        dec: Angle.Degrees(-40.10020722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26363"},
        {"Hipparcos Number", "HIP 19320"},
        {"Smithsonian Astrophysical Observation", "SAO 216663"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.11587800),
        dec: Angle.Degrees(-40.10003575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67439"},
        {"Hipparcos Number", "HIP 39657"},
        {"Smithsonian Astrophysical Observation", "SAO 198805"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.56528594),
        dec: Angle.Degrees(-40.09965325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61200"},
        {"Geneva Identification System", "GEN# -0.03907674"},
        {"Wilson Evans Batten Catalogue", "WEB 10894"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32, 28.3600),
        dec: Angle.DegreesMinutesSeconds((int)-40, (int)05, 54.300)
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
    primaryId: "HIP 95684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182708"},
        {"Hipparcos Number", "HIP 95684"},
        {"Geneva Identification System", "GEN# +1.00182708"},
        {"Smithsonian Astrophysical Observation", "SAO 229690"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.93028858),
        dec: Angle.Degrees(-40.09693528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82066"},
        {"Hipparcos Number", "HIP 46455"},
        {"Smithsonian Astrophysical Observation", "SAO 200404"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.11819484),
        dec: Angle.Degrees(-40.09630206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1116"},
        {"Hipparcos Number", "HIP 1225"},
        {"Geneva Identification System", "GEN# +1.00001116J"},
        {"Smithsonian Astrophysical Observation", "SAO 215021"},
        {"Wilson Evans Batten Catalogue", "WEB 220"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.81273839),
        dec: Angle.Degrees(-40.09595984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160463"},
        {"Hipparcos Number", "HIP 86607"},
        {"Smithsonian Astrophysical Observation", "SAO 228300"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.47454299),
        dec: Angle.Degrees(-40.09435846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112681"},
        {"Hipparcos Number", "HIP 63358"},
        {"Smithsonian Astrophysical Observation", "SAO 204003"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.73941163),
        dec: Angle.Degrees(-40.09387088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156978"},
        {"Hipparcos Number", "HIP 85004"},
        {"Geneva Identification System", "GEN# +1.00156978"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.61224786),
        dec: Angle.Degrees(-40.09359950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32312"},
        {"Hipparcos Number", "HIP 23275"},
        {"Smithsonian Astrophysical Observation", "SAO 217107"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.10947774),
        dec: Angle.Degrees(-40.09263886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1116B"},
        {"Hipparcos Number", "HIP 1226"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.81289574),
        dec: Angle.Degrees(-40.09210991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161912"},
        {"Hipparcos Number", "HIP 87294"},
        {"Geneva Identification System", "GEN# +1.00161912"},
        {"Smithsonian Astrophysical Observation", "SAO 228466"},
        {"Wilson Evans Batten Catalogue", "WEB 14725"},
    },
    visualMagnitude: 4.78,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.54629170),
        dec: Angle.Degrees(-40.09042823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164340"},
        {"Hipparcos Number", "HIP 88352"},
        {"Geneva Identification System", "GEN# +1.00164340"},
        {"Smithsonian Astrophysical Observation", "SAO 228648"},
    },
    visualMagnitude: 9.30,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.63726151),
        dec: Angle.Degrees(-40.08789062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153805"},
        {"Hipparcos Number", "HIP 83457"},
        {"Geneva Identification System", "GEN# +1.00153805"},
        {"Smithsonian Astrophysical Observation", "SAO 227587"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.84250249),
        dec: Angle.Degrees(-40.08783053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24416"},
        {"Hipparcos Number", "HIP 18048"},
        {"Smithsonian Astrophysical Observation", "SAO 216523"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.86035714),
        dec: Angle.Degrees(-40.08570407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57151"},
        {"Hipparcos Number", "HIP 35360"},
        {"Smithsonian Astrophysical Observation", "SAO 197825"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.55388998),
        dec: Angle.Degrees(-40.08368641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120174"},
        {"Hipparcos Number", "HIP 67380"},
        {"Fundamental Katalog 5th Edition", "FK5 5219"},
        {"Smithsonian Astrophysical Observation", "SAO 204861"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.14501391),
        dec: Angle.Degrees(-40.08006921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106232"},
        {"Hipparcos Number", "HIP 59606"},
        {"Smithsonian Astrophysical Observation", "SAO 203249"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.35117637),
        dec: Angle.Degrees(-40.07884912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191524"},
        {"Hipparcos Number", "HIP 99526"},
        {"Smithsonian Astrophysical Observation", "SAO 230095"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.97288551),
        dec: Angle.Degrees(-40.07731421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27301"},
        {"Hipparcos Number", "HIP 19967"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.22269498),
        dec: Angle.Degrees(-40.07688801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21175"},
        {"Hipparcos Number", "HIP 15799"},
        {"Smithsonian Astrophysical Observation", "SAO 216292"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.89679270),
        dec: Angle.Degrees(-40.07649183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176619"},
        {"Hipparcos Number", "HIP 93532"},
        {"Smithsonian Astrophysical Observation", "SAO 229460"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.75271059),
        dec: Angle.Degrees(-40.07648595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165249"},
        {"Hipparcos Number", "HIP 88735"},
        {"Geneva Identification System", "GEN# +1.00165249"},
        {"Smithsonian Astrophysical Observation", "SAO 228713"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.72900530),
        dec: Angle.Degrees(-40.07535822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180154"},
        {"Hipparcos Number", "HIP 94792"},
        {"Smithsonian Astrophysical Observation", "SAO 229596"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.30855092),
        dec: Angle.Degrees(-40.07439138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64316"},
        {"Hipparcos Number", "HIP 38369"},
        {"Geneva Identification System", "GEN# +1.00064316"},
        {"Smithsonian Astrophysical Observation", "SAO 198532"},
        {"Wilson Evans Batten Catalogue", "WEB 7548"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.91463676),
        dec: Angle.Degrees(-40.07005627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138505"},
        {"Hipparcos Number", "HIP 76207"},
        {"Geneva Identification System", "GEN# +1.00138505"},
        {"Smithsonian Astrophysical Observation", "SAO 206763"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.50723930),
        dec: Angle.Degrees(-40.06634857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39012"},
        {"Hipparcos Number", "HIP 27371"},
        {"Geneva Identification System", "GEN# +1.00039012"},
        {"Smithsonian Astrophysical Observation", "SAO 217541"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.95639647),
        dec: Angle.Degrees(-40.06409272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165491"},
        {"Hipparcos Number", "HIP 88845"},
        {"Smithsonian Astrophysical Observation", "SAO 228731"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.04074629),
        dec: Angle.Degrees(-40.06099731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41821"},
        {"Hipparcos Number", "HIP 28857"},
        {"Smithsonian Astrophysical Observation", "SAO 217711"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.37480633),
        dec: Angle.Degrees(-40.06064609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197216"},
        {"Hipparcos Number", "HIP 102303"},
        {"Smithsonian Astrophysical Observation", "SAO 230340"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.92482884),
        dec: Angle.Degrees(-40.06030680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63308"},
        {"Hipparcos Number", "HIP 37938"},
        {"Celescope Catalog", "CEL 2027"},
        {"Geneva Identification System", "GEN# +1.00063308"},
        {"Smithsonian Astrophysical Observation", "SAO 198424"},
        {"Wilson Evans Batten Catalogue", "WEB 7488"},
    },
    visualMagnitude: 6.56,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.63932313),
        dec: Angle.Degrees(-40.05952932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60559"},
        {"Hipparcos Number", "HIP 36728"},
        {"Celescope Catalog", "CEL 1928"},
        {"Geneva Identification System", "GEN# +1.00060559"},
        {"Renson", "Renson 16550"},
        {"Smithsonian Astrophysical Observation", "SAO 198120"},
    },
    visualMagnitude: 6.27,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.30487698),
        dec: Angle.Degrees(-40.05853613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91862"},
        {"Cincinnati Publication", "Ci 20 1104"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.92443814),
        dec: Angle.Degrees(-40.05744614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -498.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79844"},
    },
    visualMagnitude: 12.86,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.46382565),
        dec: Angle.Degrees(-40.05742208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83916"},
        {"Hipparcos Number", "HIP 47456"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.10463635),
        dec: Angle.Degrees(-40.05697573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202844"},
        {"Hipparcos Number", "HIP 105311"},
        {"Smithsonian Astrophysical Observation", "SAO 230631"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.94067749),
        dec: Angle.Degrees(-40.05641019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27079"},
        {"Hipparcos Number", "HIP 19824"},
        {"Renson", "Renson 6920"},
        {"Smithsonian Astrophysical Observation", "SAO 216720"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.76063872),
        dec: Angle.Degrees(-40.05522963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115141"},
        {"Hipparcos Number", "HIP 64715"},
        {"Smithsonian Astrophysical Observation", "SAO 204299"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.95645556),
        dec: Angle.Degrees(-40.05471906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169340"},
        {"Hipparcos Number", "HIP 90349"},
        {"Geneva Identification System", "GEN# +1.00169340"},
        {"Smithsonian Astrophysical Observation", "SAO 229014"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.52852551),
        dec: Angle.Degrees(-40.05284279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28107"},
        {"Hipparcos Number", "HIP 20554"},
        {"Smithsonian Astrophysical Observation", "SAO 216780"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.05376291),
        dec: Angle.Degrees(-40.05274942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118799"},
        {"Hipparcos Number", "HIP 66656"},
        {"Geneva Identification System", "GEN# +1.00118799"},
        {"Smithsonian Astrophysical Observation", "SAO 204712"},
    },
    visualMagnitude: 5.61,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.95244077),
        dec: Angle.Degrees(-40.05157491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36748"},
        {"Hipparcos Number", "HIP 25935"},
        {"Smithsonian Astrophysical Observation", "SAO 217385"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.02408912),
        dec: Angle.Degrees(-40.04957516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23265"},
        {"Hipparcos Number", "HIP 17297"},
        {"Smithsonian Astrophysical Observation", "SAO 216447"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.53976680),
        dec: Angle.Degrees(-40.04945708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58489"},
        {"Hipparcos Number", "HIP 35902"},
        {"Geneva Identification System", "GEN# +1.00058489"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.01928600),
        dec: Angle.Degrees(-40.04643488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 152.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207645"},
        {"Hipparcos Number", "HIP 107879"},
        {"Smithsonian Astrophysical Observation", "SAO 230869"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.87082839),
        dec: Angle.Degrees(-40.04475390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113974"},
        {"Hipparcos Number", "HIP 64069"},
        {"Smithsonian Astrophysical Observation", "SAO 204147"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.95723000),
        dec: Angle.Degrees(-40.04423548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126237"},
        {"Hipparcos Number", "HIP 70512"},
        {"Geneva Identification System", "GEN# +1.00126237"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.36225246),
        dec: Angle.Degrees(-40.04294942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14903"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.08129133),
        dec: Angle.Degrees(-40.04112950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110954"},
        {"Hipparcos Number", "HIP 62301"},
        {"Smithsonian Astrophysical Observation", "SAO 203788"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.50142562),
        dec: Angle.Degrees(-40.04074382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169444"},
        {"Hipparcos Number", "HIP 90383"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.64153624),
        dec: Angle.Degrees(-40.03960326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60128"},
        {"Hipparcos Number", "HIP 36559"},
        {"Smithsonian Astrophysical Observation", "SAO 198083"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.80694552),
        dec: Angle.Degrees(-40.03878225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25038"},
        {"Hipparcos Number", "HIP 18482"},
        {"Smithsonian Astrophysical Observation", "SAO 216568"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.25738161),
        dec: Angle.Degrees(-40.03696413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184035"},
        {"Hipparcos Number", "HIP 96234"},
        {"Fundamental Katalog 5th Edition", "FK5 3560"},
        {"Geneva Identification System", "GEN# +1.00184035"},
        {"Smithsonian Astrophysical Observation", "SAO 229746"},
        {"Wilson Evans Batten Catalogue", "WEB 16865"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.53534254),
        dec: Angle.Degrees(-40.03463308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192252"},
        {"Hipparcos Number", "HIP 99851"},
        {"Smithsonian Astrophysical Observation", "SAO 230122"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.87328773),
        dec: Angle.Degrees(-40.03206019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22434"},
        {"Hipparcos Number", "HIP 16708"},
        {"Smithsonian Astrophysical Observation", "SAO 216389"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.74458921),
        dec: Angle.Degrees(-40.03177650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129766"},
        {"Hipparcos Number", "HIP 72164"},
        {"Smithsonian Astrophysical Observation", "SAO 205909"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.40640933),
        dec: Angle.Degrees(-40.03033894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203555"},
        {"Hipparcos Number", "HIP 105656"},
        {"Geneva Identification System", "GEN# +1.00203555"},
        {"Smithsonian Astrophysical Observation", "SAO 230662"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.01529130),
        dec: Angle.Degrees(-40.03000573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127693"},
        {"Hipparcos Number", "HIP 71213"},
        {"Smithsonian Astrophysical Observation", "SAO 205695"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.44890034),
        dec: Angle.Degrees(-40.02165099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220753"},
        {"Hipparcos Number", "HIP 115706"},
        {"Smithsonian Astrophysical Observation", "SAO 231608"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.64645691),
        dec: Angle.Degrees(-40.02126016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15598"},
        {"Smithsonian Astrophysical Observation", "SAO 130433"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.21842692),
        dec: Angle.Degrees(-07.48227835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213058"},
        {"Hipparcos Number", "HIP 111026"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.38729990),
        dec: Angle.Degrees(-40.01980698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221138"},
        {"Hipparcos Number", "HIP 115957"},
        {"Geneva Identification System", "GEN# +1.00221138"},
        {"Smithsonian Astrophysical Observation", "SAO 231626"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.39987280),
        dec: Angle.Degrees(-40.01800837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6219"},
        {"Hipparcos Number", "HIP 4885"},
        {"Geneva Identification System", "GEN# +1.00006219"},
        {"Smithsonian Astrophysical Observation", "SAO 215341"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.68711439),
        dec: Angle.Degrees(-40.01696096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170624"},
        {"Hipparcos Number", "HIP 90885"},
        {"Smithsonian Astrophysical Observation", "SAO 229102"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.08633275),
        dec: Angle.Degrees(-40.01614789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29292"},
        {"Hipparcos Number", "HIP 21366"},
        {"Smithsonian Astrophysical Observation", "SAO 216882"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.76686032),
        dec: Angle.Degrees(-40.01540151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223831"},
        {"Hipparcos Number", "HIP 117771"},
        {"Smithsonian Astrophysical Observation", "SAO 231823"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.25771835),
        dec: Angle.Degrees(-40.01388911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125201"},
        {"Hipparcos Number", "HIP 69964"},
        {"Geneva Identification System", "GEN# +1.00125201"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.74840090),
        dec: Angle.Degrees(-40.01266579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215085"},
        {"Hipparcos Number", "HIP 112185"},
        {"Smithsonian Astrophysical Observation", "SAO 231263"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.82053260),
        dec: Angle.Degrees(-40.00904619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34586"},
        {"Hipparcos Number", "HIP 24613"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.19458133),
        dec: Angle.Degrees(-40.00889806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36299"},
        {"Hipparcos Number", "HIP 25658"},
        {"Smithsonian Astrophysical Observation", "SAO 217353"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.21021505),
        dec: Angle.Degrees(-40.00846049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31555"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.07666156),
        dec: Angle.Degrees(-40.00673573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -226.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127136"},
        {"Hipparcos Number", "HIP 70962"},
        {"Geneva Identification System", "GEN# +1.00127136"},
        {"Smithsonian Astrophysical Observation", "SAO 205628"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.72289795),
        dec: Angle.Degrees(-40.00561323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13753"},
        {"Hipparcos Number", "HIP 10325"},
        {"Geneva Identification System", "GEN# +1.00013753"},
        {"Smithsonian Astrophysical Observation", "SAO 215820"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.25036727),
        dec: Angle.Degrees(-40.00519109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131051"},
        {"Hipparcos Number", "HIP 72789"},
        {"Smithsonian Astrophysical Observation", "SAO 206032"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.16960189),
        dec: Angle.Degrees(-40.00512382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106866"},
        {"Hipparcos Number", "HIP 59930"},
        {"Smithsonian Astrophysical Observation", "SAO 203312"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.39456923),
        dec: Angle.Degrees(-40.00442104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82674"},
        {"Hipparcos Number", "HIP 46893"},
        {"Geneva Identification System", "GEN# +1.00082674"},
        {"Smithsonian Astrophysical Observation", "SAO 136951"},
        {"Wilson Evans Batten Catalogue", "WEB 8839"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.33309223),
        dec: Angle.Degrees(-07.19014820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39429",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Naos"},
        {"Henry Draper", "HD 66811"},
        {"Hipparcos Number", "HIP 39429"},
        {"Celescope Catalog", "CEL 2154"},
        {"Fundamental Katalog 5th Edition", "FK5 306"},
        {"Geneva Identification System", "GEN# +1.00066811"},
        {"Smithsonian Astrophysical Observation", "SAO 198752"},
        {"Wilson Evans Batten Catalogue", "WEB 7714"},
    },
    visualMagnitude: 2.21,
    bvColour: -0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.89612561),
        dec: Angle.Degrees(-40.00318846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75953"},
        {"Hipparcos Number", "HIP 43514"},
        {"Smithsonian Astrophysical Observation", "SAO 199718"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.94223822),
        dec: Angle.Degrees(-40.00252607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8041"},
        {"Hipparcos Number", "HIP 6179"},
        {"Smithsonian Astrophysical Observation", "SAO 215456"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.81734671),
        dec: Angle.Degrees(-40.00173466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151739"},
        {"Hipparcos Number", "HIP 82454"},
        {"Geneva Identification System", "GEN# +1.00151739"},
        {"Smithsonian Astrophysical Observation", "SAO 208087"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.75581765),
        dec: Angle.Degrees(-40.00147222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197934"},
        {"Hipparcos Number", "HIP 102672"},
        {"Smithsonian Astrophysical Observation", "SAO 230377"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.07993036),
        dec: Angle.Degrees(-40.00106479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16742"},
        {"Hipparcos Number", "HIP 12406"},
        {"Smithsonian Astrophysical Observation", "SAO 215995"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.93821579),
        dec: Angle.Degrees(-40.00074756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78372"},
        {"Hipparcos Number", "HIP 44702"},
        {"Geneva Identification System", "GEN# +1.00078372"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.63440998),
        dec: Angle.Degrees(-40.00067869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218642"},
        {"Hipparcos Number", "HIP 114388"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.50366669),
        dec: Angle.Degrees(-39.99946684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103019"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.06793531),
        dec: Angle.Degrees(-39.99697891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25678"},
        {"Hipparcos Number", "HIP 18876"},
        {"Smithsonian Astrophysical Observation", "SAO 216613"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.69768218),
        dec: Angle.Degrees(-39.99581320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16239"},
        {"Hipparcos Number", "HIP 12029"},
        {"Smithsonian Astrophysical Observation", "SAO 215951"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.77895433),
        dec: Angle.Degrees(-39.99500071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154669"},
        {"Hipparcos Number", "HIP 83880"},
        {"Smithsonian Astrophysical Observation", "SAO 208459"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.16319780),
        dec: Angle.Degrees(-39.99490065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88568"},
        {"Hipparcos Number", "HIP 49953"},
        {"Smithsonian Astrophysical Observation", "SAO 201158"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.98811019),
        dec: Angle.Degrees(-39.99441232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20685"},
        {"Hipparcos Number", "HIP 15391"},
        {"Smithsonian Astrophysical Observation", "SAO 216251"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.60611543),
        dec: Angle.Degrees(-39.99344532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219974"},
        {"Hipparcos Number", "HIP 115238"},
        {"Smithsonian Astrophysical Observation", "SAO 231556"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.11947019),
        dec: Angle.Degrees(-39.99222975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113187"},
        {"Hipparcos Number", "HIP 63628"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.60673151),
        dec: Angle.Degrees(-39.99222256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61623"},
        {"Hipparcos Number", "HIP 37184"},
        {"Celescope Catalog", "CEL 1959"},
        {"Geneva Identification System", "GEN# +1.00061623"},
        {"Smithsonian Astrophysical Observation", "SAO 198226"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.60009972),
        dec: Angle.Degrees(-39.99195849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179772"},
        {"Hipparcos Number", "HIP 94654"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.90860573),
        dec: Angle.Degrees(-39.99161010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115987"},
        {"Hipparcos Number", "HIP 65173"},
        {"Geneva Identification System", "GEN# +1.00115987"},
        {"Smithsonian Astrophysical Observation", "SAO 204378"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.34515190),
        dec: Angle.Degrees(-39.98994207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129590"},
        {"Hipparcos Number", "HIP 72070"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.12908091),
        dec: Angle.Degrees(-39.98900517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181039"},
        {"Hipparcos Number", "HIP 95072"},
        {"Smithsonian Astrophysical Observation", "SAO 229629"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.14743073),
        dec: Angle.Degrees(-39.98888976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110073"},
        {"Hipparcos Number", "HIP 61789"},
        {"Geneva Identification System", "GEN# +1.00110073"},
        {"Renson", "Renson 31980"},
        {"Smithsonian Astrophysical Observation", "SAO 203681"},
        {"Wilson Evans Batten Catalogue", "WEB 10991"},
    },
    visualMagnitude: 4.63,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.96900602),
        dec: Angle.Degrees(-39.98724188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123073"},
        {"Hipparcos Number", "HIP 68909"},
        {"Smithsonian Astrophysical Observation", "SAO 205182"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.62074086),
        dec: Angle.Degrees(-39.98655396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140107"},
        {"Hipparcos Number", "HIP 77004"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.85141708),
        dec: Angle.Degrees(-39.98599985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134653"},
        {"Hipparcos Number", "HIP 74402"},
        {"Smithsonian Astrophysical Observation", "SAO 206401"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.09027765),
        dec: Angle.Degrees(-39.98499130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65981"},
        {"Hipparcos Number", "HIP 39078"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.93355180),
        dec: Angle.Degrees(-39.98398050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139677"},
        {"Hipparcos Number", "HIP 76824"},
        {"Smithsonian Astrophysical Observation", "SAO 206867"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.27876805),
        dec: Angle.Degrees(-39.98266406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30693"},
        {"Hipparcos Number", "HIP 22293"},
        {"Smithsonian Astrophysical Observation", "SAO 217000"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.01607336),
        dec: Angle.Degrees(-39.98141396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213399"},
        {"Hipparcos Number", "HIP 111199"},
        {"Smithsonian Astrophysical Observation", "SAO 231182"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.91906521),
        dec: Angle.Degrees(-39.97878616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124228"},
        {"Hipparcos Number", "HIP 69472"},
        {"Geneva Identification System", "GEN# +1.00124228"},
        {"Smithsonian Astrophysical Observation", "SAO 205316"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.34286312),
        dec: Angle.Degrees(-39.97857928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190308"},
        {"Hipparcos Number", "HIP 99003"},
        {"Smithsonian Astrophysical Observation", "SAO 230035"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.49331965),
        dec: Angle.Degrees(-39.97607555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87477"},
        {"Hipparcos Number", "HIP 49343"},
        {"Fundamental Katalog 5th Edition", "FK5 2809"},
        {"Geneva Identification System", "GEN# +1.00087477"},
        {"Smithsonian Astrophysical Observation", "SAO 201020"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.09746649),
        dec: Angle.Degrees(-39.97585933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115961"},
        {"Hipparcos Number", "HIP 65157"},
        {"Smithsonian Astrophysical Observation", "SAO 204374"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.29118673),
        dec: Angle.Degrees(-39.97568862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52169"},
        {"Hipparcos Number", "HIP 33549"},
        {"Smithsonian Astrophysical Observation", "SAO 197430"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.57620898),
        dec: Angle.Degrees(-39.97530539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201424"},
        {"Hipparcos Number", "HIP 104555"},
        {"Geneva Identification System", "GEN# +1.00201424"},
        {"Smithsonian Astrophysical Observation", "SAO 230562"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.68649648),
        dec: Angle.Degrees(-39.97503971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158455"},
        {"Hipparcos Number", "HIP 85738"},
        {"Smithsonian Astrophysical Observation", "SAO 208902"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.81601314),
        dec: Angle.Degrees(-39.97496204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189833"},
        {"Hipparcos Number", "HIP 98774"},
        {"Smithsonian Astrophysical Observation", "SAO 230015"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.91431325),
        dec: Angle.Degrees(-39.97456383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117736"},
        {"Hipparcos Number", "HIP 66101"},
        {"Geneva Identification System", "GEN# +1.00117736"},
        {"Smithsonian Astrophysical Observation", "SAO 204576"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.25302330),
        dec: Angle.Degrees(-39.97219890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98033"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.82277460),
        dec: Angle.Degrees(-39.97074235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73121"},
        {"Hipparcos Number", "HIP 42123"},
        {"Geneva Identification System", "GEN# +1.00073121"},
        {"Smithsonian Astrophysical Observation", "SAO 199402"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.80200479),
        dec: Angle.Degrees(-39.97055528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108584"},
        {"Hipparcos Number", "HIP 60877"},
        {"Smithsonian Astrophysical Observation", "SAO 203511"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.15443861),
        dec: Angle.Degrees(-39.96831358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5708"},
        {"Hipparcos Number", "HIP 4546"},
        {"Smithsonian Astrophysical Observation", "SAO 215305"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.54960866),
        dec: Angle.Degrees(-39.96527365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48943"},
        {"Hipparcos Number", "HIP 32274"},
        {"Smithsonian Astrophysical Observation", "SAO 197152"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.06956787),
        dec: Angle.Degrees(-39.96526175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53522"},
        {"Hipparcos Number", "HIP 34028"},
        {"Geneva Identification System", "GEN# +1.00053522"},
        {"Smithsonian Astrophysical Observation", "SAO 197528"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.89710183),
        dec: Angle.Degrees(-39.96475107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201963"},
        {"Hipparcos Number", "HIP 104824"},
        {"Geneva Identification System", "GEN# +1.00201963"},
        {"Smithsonian Astrophysical Observation", "SAO 230587"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.54430675),
        dec: Angle.Degrees(-39.96248613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134778"},
        {"Hipparcos Number", "HIP 74473"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.26567545),
        dec: Angle.Degrees(-39.96225495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92418"},
        {"Hipparcos Number", "HIP 52180"},
        {"Smithsonian Astrophysical Observation", "SAO 201609"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.90288371),
        dec: Angle.Degrees(-39.96143327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62608"},
        {"Hipparcos Number", "HIP 37618"},
        {"Geneva Identification System", "GEN# +1.00062608"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.77882454),
        dec: Angle.Degrees(-39.96116934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 133.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177975"},
        {"Hipparcos Number", "HIP 94033"},
        {"Smithsonian Astrophysical Observation", "SAO 229517"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.16500274),
        dec: Angle.Degrees(-39.96009350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175216"},
        {"Hipparcos Number", "HIP 92942"},
        {"Geneva Identification System", "GEN# +1.00175216"},
        {"Smithsonian Astrophysical Observation", "SAO 229381"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.04103557),
        dec: Angle.Degrees(-39.96006600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52248",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52248"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.13732140),
        dec: Angle.Degrees(-39.95831645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -256.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 241.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40091"},
        {"Hipparcos Number", "HIP 27955"},
        {"Fundamental Katalog 5th Edition", "FK5 2449"},
        {"Geneva Identification System", "GEN# +1.00040091"},
        {"Smithsonian Astrophysical Observation", "SAO 196309"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.71872485),
        dec: Angle.Degrees(-39.95790952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193195"},
        {"Hipparcos Number", "HIP 100293"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.12676386),
        dec: Angle.Degrees(-39.95719953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8195"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.33797420),
        dec: Angle.Degrees(-39.95599951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 278.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 133.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75519"},
        {"Hipparcos Number", "HIP 43290"},
        {"Geneva Identification System", "GEN# +1.00075519"},
        {"Smithsonian Astrophysical Observation", "SAO 199666"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.27408759),
        dec: Angle.Degrees(-39.95470159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193059"},
        {"Hipparcos Number", "HIP 100238"},
        {"Smithsonian Astrophysical Observation", "SAO 230156"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.95020776),
        dec: Angle.Degrees(-39.95318707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72573"},
        {"Hipparcos Number", "HIP 41863"},
        {"Celescope Catalog", "CEL 2617"},
        {"Geneva Identification System", "GEN# +1.00072573"},
        {"Smithsonian Astrophysical Observation", "SAO 199341"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.03780823),
        dec: Angle.Degrees(-39.95299084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7643"},
        {"Hipparcos Number", "HIP 5897"},
        {"Geneva Identification System", "GEN# +1.00007643"},
        {"Smithsonian Astrophysical Observation", "SAO 215431"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.93936814),
        dec: Angle.Degrees(-39.95287944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81199"},
        {"Hipparcos Number", "HIP 46013"},
        {"Smithsonian Astrophysical Observation", "SAO 200307"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.76322360),
        dec: Angle.Degrees(-39.95274546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116883"},
        {"Hipparcos Number", "HIP 65626"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.82541633),
        dec: Angle.Degrees(-39.95236710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108205"},
        {"Hipparcos Number", "HIP 60670"},
        {"Smithsonian Astrophysical Observation", "SAO 203462"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.51018262),
        dec: Angle.Degrees(-39.95235704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64999"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.85122831),
        dec: Angle.Degrees(-39.95034023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133175"},
        {"Hipparcos Number", "HIP 73744"},
        {"Smithsonian Astrophysical Observation", "SAO 206259"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.11036205),
        dec: Angle.Degrees(-39.94895949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72711"},
        {"Hipparcos Number", "HIP 41929"},
        {"Smithsonian Astrophysical Observation", "SAO 199356"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.22553063),
        dec: Angle.Degrees(-39.94752690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9895"},
        {"Hipparcos Number", "HIP 7443"},
        {"Fundamental Katalog 5th Edition", "FK5 2105"},
        {"Geneva Identification System", "GEN# +1.00009895"},
        {"Smithsonian Astrophysical Observation", "SAO 215573"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.96083226),
        dec: Angle.Degrees(-39.94700724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5626"},
        {"Hipparcos Number", "HIP 4483"},
        {"Smithsonian Astrophysical Observation", "SAO 215298"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.35970810),
        dec: Angle.Degrees(-39.94672933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117851"},
        {"Hipparcos Number", "HIP 66171"},
        {"Smithsonian Astrophysical Observation", "SAO 204597"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.44914633),
        dec: Angle.Degrees(-39.94569227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22458"},
        {"Hipparcos Number", "HIP 16726"},
        {"Smithsonian Astrophysical Observation", "SAO 216391"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.80276796),
        dec: Angle.Degrees(-39.94558533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10948"},
        {"Hipparcos Number", "HIP 8280"},
        {"Geneva Identification System", "GEN# +1.00010948J"},
        {"Smithsonian Astrophysical Observation", "SAO 215645"},
        {"Wilson Evans Batten Catalogue", "WEB 1766"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.67012575),
        dec: Angle.Degrees(-39.94432091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135535"},
        {"Hipparcos Number", "HIP 74787"},
        {"Smithsonian Astrophysical Observation", "SAO 206479"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.25637231),
        dec: Angle.Degrees(-39.94409520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208000"},
        {"Hipparcos Number", "HIP 108118"},
        {"Smithsonian Astrophysical Observation", "SAO 230893"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.57080841),
        dec: Angle.Degrees(-39.94246867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100569"},
        {"Hipparcos Number", "HIP 56434"},
        {"Smithsonian Astrophysical Observation", "SAO 202578"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.55529147),
        dec: Angle.Degrees(-39.93985694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115772"},
        {"Hipparcos Number", "HIP 65047"},
        {"Geneva Identification System", "GEN# +1.00115772"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.00168462),
        dec: Angle.Degrees(-39.93887860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207999"},
        {"Hipparcos Number", "HIP 108125"},
        {"Smithsonian Astrophysical Observation", "SAO 230894"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.58131017),
        dec: Angle.Degrees(-39.93730648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110420"},
        {"Hipparcos Number", "HIP 61998"},
        {"Geneva Identification System", "GEN# +1.00110420"},
        {"Smithsonian Astrophysical Observation", "SAO 203726"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.58245136),
        dec: Angle.Degrees(-39.93613967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52239"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.08663918),
        dec: Angle.Degrees(-39.93429150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87854"},
        {"Smithsonian Astrophysical Observation", "SAO 209497"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.21184519),
        dec: Angle.Degrees(-39.93273598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17864"},
        {"Hipparcos Number", "HIP 13271"},
        {"Geneva Identification System", "GEN# +1.00017864"},
        {"Smithsonian Astrophysical Observation", "SAO 216065"},
        {"Wilson Evans Batten Catalogue", "WEB 2664"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.69906166),
        dec: Angle.Degrees(-39.93219929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39126"},
        {"Hipparcos Number", "HIP 27441"},
        {"Geneva Identification System", "GEN# +1.00039126"},
        {"Smithsonian Astrophysical Observation", "SAO 196199"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.15329482),
        dec: Angle.Degrees(-39.93218126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128535"},
        {"Hipparcos Number", "HIP 71590"},
        {"Smithsonian Astrophysical Observation", "SAO 205788"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.62644898),
        dec: Angle.Degrees(-39.93128082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24020"},
        {"Hipparcos Number", "HIP 17754"},
        {"Smithsonian Astrophysical Observation", "SAO 216492"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.01178594),
        dec: Angle.Degrees(-39.93078414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91460"},
        {"Hipparcos Number", "HIP 51636"},
        {"Smithsonian Astrophysical Observation", "SAO 201505"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.23780193),
        dec: Angle.Degrees(-39.93074026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95136"},
        {"Hipparcos Number", "HIP 53647"},
        {"Geneva Identification System", "GEN# +1.00095136"},
        {"Smithsonian Astrophysical Observation", "SAO 201960"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.63787628),
        dec: Angle.Degrees(-39.92916530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174871"},
        {"Hipparcos Number", "HIP 92804"},
        {"Smithsonian Astrophysical Observation", "SAO 210697"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.64542078),
        dec: Angle.Degrees(-39.92849432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130163"},
        {"Hipparcos Number", "HIP 72362"},
        {"Geneva Identification System", "GEN# +1.00130163"},
        {"Smithsonian Astrophysical Observation", "SAO 205948"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.94568771),
        dec: Angle.Degrees(-39.92638007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54827"},
        {"Smithsonian Astrophysical Observation", "SAO 202216"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.35968786),
        dec: Angle.Degrees(-39.92534467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3085"},
        {"Hipparcos Number", "HIP 2665"},
        {"Geneva Identification System", "GEN# +1.00003085"},
        {"Smithsonian Astrophysical Observation", "SAO 215143"},
        {"Wilson Evans Batten Catalogue", "WEB 487"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.44997903),
        dec: Angle.Degrees(-39.92461562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38397"},
        {"Hipparcos Number", "HIP 26990"},
        {"Geneva Identification System", "GEN# +1.00038397"},
        {"Smithsonian Astrophysical Observation", "SAO 196118"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.89912288),
        dec: Angle.Degrees(-39.92356834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8678"},
        {"Hipparcos Number", "HIP 6615"},
        {"Smithsonian Astrophysical Observation", "SAO 215496"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.22973945),
        dec: Angle.Degrees(-39.92180527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53734"},
        {"Hipparcos Number", "HIP 34109"},
        {"Geneva Identification System", "GEN# +1.00053734"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.08709521),
        dec: Angle.Degrees(-39.91985013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217109"},
        {"Hipparcos Number", "HIP 113466"},
        {"Smithsonian Astrophysical Observation", "SAO 231377"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.67781494),
        dec: Angle.Degrees(-39.91965095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220325"},
        {"Hipparcos Number", "HIP 115448"},
        {"Smithsonian Astrophysical Observation", "SAO 231579"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.78355569),
        dec: Angle.Degrees(-39.91915836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132782"},
        {"Hipparcos Number", "HIP 73575"},
        {"Smithsonian Astrophysical Observation", "SAO 206228"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.56417899),
        dec: Angle.Degrees(-39.91566663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24988"},
        {"Hipparcos Number", "HIP 18452"},
        {"Smithsonian Astrophysical Observation", "SAO 216564"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.15185380),
        dec: Angle.Degrees(-39.91513342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123090"},
        {"Hipparcos Number", "HIP 68920"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.64044921),
        dec: Angle.Degrees(-39.91499326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2490"},
        {"Hipparcos Number", "HIP 2240"},
        {"Geneva Identification System", "GEN# +1.00002490"},
        {"Smithsonian Astrophysical Observation", "SAO 215103"},
        {"Wilson Evans Batten Catalogue", "WEB 417"},
    },
    visualMagnitude: 5.42,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.11007309),
        dec: Angle.Degrees(-39.91490183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176019"},
        {"Hipparcos Number", "HIP 93265"},
        {"Smithsonian Astrophysical Observation", "SAO 210795"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.98144295),
        dec: Angle.Degrees(-39.91365735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30476"},
        {"Hipparcos Number", "HIP 22178"},
        {"Smithsonian Astrophysical Observation", "SAO 216986"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.58178489),
        dec: Angle.Degrees(-39.91315279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9628"},
        {"Hipparcos Number", "HIP 7273"},
        {"Smithsonian Astrophysical Observation", "SAO 215559"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.41749823),
        dec: Angle.Degrees(-39.91174406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171938"},
        {"Hipparcos Number", "HIP 91465"},
        {"Smithsonian Astrophysical Observation", "SAO 210404"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.82071002),
        dec: Angle.Degrees(-39.91064281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124092"},
        {"Hipparcos Number", "HIP 69395"},
        {"Geneva Identification System", "GEN# +1.00124092"},
        {"Smithsonian Astrophysical Observation", "SAO 205296"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.09792117),
        dec: Angle.Degrees(-39.90937550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75125"},
        {"Hipparcos Number", "HIP 43107"},
        {"Celescope Catalog", "CEL 2896"},
        {"Geneva Identification System", "GEN# +1.00075125"},
        {"Smithsonian Astrophysical Observation", "SAO 199609"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.68240259),
        dec: Angle.Degrees(-39.90790731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8662"},
        {"Hipparcos Number", "HIP 6599"},
        {"Smithsonian Astrophysical Observation", "SAO 215493"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.18939025),
        dec: Angle.Degrees(-39.90746484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132096"},
        {"Hipparcos Number", "HIP 73279"},
        {"Geneva Identification System", "GEN# +1.00132096"},
        {"Smithsonian Astrophysical Observation", "SAO 206154"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.65244058),
        dec: Angle.Degrees(-39.90697956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60686"},
        {"Hipparcos Number", "HIP 36787"},
        {"Geneva Identification System", "GEN# +1.00060686"},
        {"Smithsonian Astrophysical Observation", "SAO 198137"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.49296618),
        dec: Angle.Degrees(-39.90593249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125221"},
        {"Hipparcos Number", "HIP 69967"},
        {"Smithsonian Astrophysical Observation", "SAO 205423"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.76009304),
        dec: Angle.Degrees(-39.90498952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124284"},
        {"Hipparcos Number", "HIP 69495"},
        {"Smithsonian Astrophysical Observation", "SAO 205322"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.42298783),
        dec: Angle.Degrees(-39.90483127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83199"},
        {"Hipparcos Number", "HIP 47076"},
        {"Smithsonian Astrophysical Observation", "SAO 200536"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.91220986),
        dec: Angle.Degrees(-39.90351630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68772"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.14028013),
        dec: Angle.Degrees(-39.90270107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9718"},
        {"Hipparcos Number", "HIP 7329"},
        {"Smithsonian Astrophysical Observation", "SAO 215566"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.59617282),
        dec: Angle.Degrees(-39.90168190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120457"},
        {"Hipparcos Number", "HIP 67537"},
        {"Geneva Identification System", "GEN# +1.00120457"},
        {"Smithsonian Astrophysical Observation", "SAO 204888"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.58080185),
        dec: Angle.Degrees(-39.90083381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7841"},
        {"Hipparcos Number", "HIP 6034"},
        {"Smithsonian Astrophysical Observation", "SAO 215440"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.37443631),
        dec: Angle.Degrees(-39.90013397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161667"},
        {"Hipparcos Number", "HIP 87181"},
        {"Celescope Catalog", "CEL 4569"},
        {"Geneva Identification System", "GEN# +1.00161667"},
        {"Smithsonian Astrophysical Observation", "SAO 209282"},
    },
    visualMagnitude: 6.98,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.17807092),
        dec: Angle.Degrees(-39.89878743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70871"},
        {"Hipparcos Number", "HIP 41078"},
        {"Geneva Identification System", "GEN# +1.00070871"},
        {"Smithsonian Astrophysical Observation", "SAO 199156"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.71438512),
        dec: Angle.Degrees(-39.89577955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217395"},
        {"Hipparcos Number", "HIP 113632"},
        {"Smithsonian Astrophysical Observation", "SAO 231389"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.20080431),
        dec: Angle.Degrees(-39.89501490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141905"},
        {"Hipparcos Number", "HIP 77789"},
        {"Geneva Identification System", "GEN# +1.00141905"},
        {"Smithsonian Astrophysical Observation", "SAO 207077"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.26142416),
        dec: Angle.Degrees(-39.89366958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13885"},
        {"Smithsonian Astrophysical Observation", "SAO 216119"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.70061718),
        dec: Angle.Degrees(-39.89328214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170773"},
        {"Hipparcos Number", "HIP 90936"},
        {"Fundamental Katalog 5th Edition", "FK5 3470"},
        {"Geneva Identification System", "GEN# +1.00170773"},
        {"Smithsonian Astrophysical Observation", "SAO 210286"},
        {"Wilson Evans Batten Catalogue", "WEB 15596"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.25354464),
        dec: Angle.Degrees(-39.89182658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71439"},
        {"Hipparcos Number", "HIP 41331"},
        {"Celescope Catalog", "CEL 2500"},
        {"Geneva Identification System", "GEN# +1.00071439"},
        {"Smithsonian Astrophysical Observation", "SAO 199217"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.49302397),
        dec: Angle.Degrees(-39.89107483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56341"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.24367322),
        dec: Angle.Degrees(-39.88969359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189269"},
        {"Hipparcos Number", "HIP 98506"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.18353013),
        dec: Angle.Degrees(-39.88914889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16281"},
        {"Hipparcos Number", "HIP 12066"},
        {"Smithsonian Astrophysical Observation", "SAO 215953"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.89732570),
        dec: Angle.Degrees(-39.88900519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137193"},
        {"Hipparcos Number", "HIP 75558"},
        {"Geneva Identification System", "GEN# +1.00137193"},
        {"Renson", "Renson 38980"},
        {"Smithsonian Astrophysical Observation", "SAO 206637"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.52860893),
        dec: Angle.Degrees(-39.88898269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150108"},
        {"Hipparcos Number", "HIP 81643"},
        {"Geneva Identification System", "GEN# +1.00150108"},
        {"Smithsonian Astrophysical Observation", "SAO 207908"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.17622960),
        dec: Angle.Degrees(-39.88259116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2320"},
        {"Hipparcos Number", "HIP 2125"},
        {"Geneva Identification System", "GEN# +1.00002320"},
        {"Smithsonian Astrophysical Observation", "SAO 215098"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.72851539),
        dec: Angle.Degrees(-39.88190163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19297"},
        {"Hipparcos Number", "HIP 14338"},
        {"Geneva Identification System", "GEN# +1.00019297"},
        {"Smithsonian Astrophysical Observation", "SAO 216159"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.22323952),
        dec: Angle.Degrees(-39.88162268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21586"},
        {"Hipparcos Number", "HIP 16113"},
        {"Smithsonian Astrophysical Observation", "SAO 216330"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.89542573),
        dec: Angle.Degrees(-39.88056214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150928"},
        {"Hipparcos Number", "HIP 82077"},
        {"Smithsonian Astrophysical Observation", "SAO 208004"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.48012781),
        dec: Angle.Degrees(-39.87689258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99627"},
        {"Hipparcos Number", "HIP 55899"},
        {"Smithsonian Astrophysical Observation", "SAO 202462"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.87250300),
        dec: Angle.Degrees(-39.87648382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187474"},
        {"Hipparcos Number", "HIP 97749"},
        {"Fundamental Katalog 5th Edition", "FK5 3583"},
        {"Geneva Identification System", "GEN# +1.00187474"},
        {"Renson", "Renson 51700"},
        {"Smithsonian Astrophysical Observation", "SAO 229903"},
        {"Wilson Evans Batten Catalogue", "WEB 17194"},
    },
    visualMagnitude: 5.32,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.96079231),
        dec: Angle.Degrees(-39.87433805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32168"},
        {"Hipparcos Number", "HIP 23188"},
        {"Smithsonian Astrophysical Observation", "SAO 195461"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.84735490),
        dec: Angle.Degrees(-39.87422553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126475"},
        {"Hipparcos Number", "HIP 70626"},
        {"Geneva Identification System", "GEN# +1.00126475"},
        {"Smithsonian Astrophysical Observation", "SAO 205561"},
        {"Wilson Evans Batten Catalogue", "WEB 12241"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.70787098),
        dec: Angle.Degrees(-39.87393329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179812"},
        {"Hipparcos Number", "HIP 94662"},
        {"Smithsonian Astrophysical Observation", "SAO 211098"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.93839512),
        dec: Angle.Degrees(-39.87361855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215891"},
        {"Hipparcos Number", "HIP 112681"},
        {"Smithsonian Astrophysical Observation", "SAO 231313"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.27168677),
        dec: Angle.Degrees(-39.87326201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114136"},
        {"Hipparcos Number", "HIP 64177"},
        {"Geneva Identification System", "GEN# +1.00114136"},
        {"Smithsonian Astrophysical Observation", "SAO 204171"},
        {"Wilson Evans Batten Catalogue", "WEB 11343"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.29371960),
        dec: Angle.Degrees(-39.87307696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33836"},
        {"Hipparcos Number", "HIP 24155"},
        {"Geneva Identification System", "GEN# +1.00033836"},
        {"Smithsonian Astrophysical Observation", "SAO 195632"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.80938198),
        dec: Angle.Degrees(-39.87293275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109573"},
        {"Henry Draper 2", "HD 109573A"},
        {"Hipparcos Number", "HIP 61498"},
        {"Geneva Identification System", "GEN# +1.00109573"},
        {"Smithsonian Astrophysical Observation", "SAO 203621"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.00447532),
        dec: Angle.Degrees(-39.86944684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23857"},
        {"Hipparcos Number", "HIP 17637"},
        {"Smithsonian Astrophysical Observation", "SAO 216483"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.68352855),
        dec: Angle.Degrees(-39.86929244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216649"},
        {"Hipparcos Number", "HIP 113150"},
        {"Geneva Identification System", "GEN# +1.00216649"},
        {"Wilson Evans Batten Catalogue", "WEB 20137"},
    },
    visualMagnitude: 10.75,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.69369964),
        dec: Angle.Degrees(-06.96404283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219619"},
        {"Hipparcos Number", "HIP 114997"},
        {"Geneva Identification System", "GEN# +1.00219619"},
        {"Smithsonian Astrophysical Observation", "SAO 231537"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.36389240),
        dec: Angle.Degrees(-39.86899464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54177"},
        {"Hipparcos Number", "HIP 34254"},
        {"Geneva Identification System", "GEN# +1.00054177"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.50975811),
        dec: Angle.Degrees(-39.86721678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48875"},
        {"Hipparcos Number", "HIP 32231"},
        {"Geneva Identification System", "GEN# +1.00048875"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.92810375),
        dec: Angle.Degrees(-39.86494683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142448"},
        {"Hipparcos Number", "HIP 78046"},
        {"Geneva Identification System", "GEN# +1.00142448A"},
        {"Smithsonian Astrophysical Observation", "SAO 207128"},
        {"Wilson Evans Batten Catalogue", "WEB 13197"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.02848203),
        dec: Angle.Degrees(-39.86432110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134411"},
        {"Hipparcos Number", "HIP 74295"},
        {"Celescope Catalog", "CEL 4346"},
        {"Geneva Identification System", "GEN# +1.00134411"},
        {"Smithsonian Astrophysical Observation", "SAO 206370"},
    },
    visualMagnitude: 9.56,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.78662526),
        dec: Angle.Degrees(-39.86419371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61243"},
        {"Hipparcos Number", "HIP 37029"},
        {"Smithsonian Astrophysical Observation", "SAO 198184"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.13882082),
        dec: Angle.Degrees(-39.86206268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28852"},
        {"Hipparcos Number", "HIP 21077"},
        {"Smithsonian Astrophysical Observation", "SAO 195093"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.76533019),
        dec: Angle.Degrees(-39.86112262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45205"},
    },
    visualMagnitude: 12.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)12, 48.6100),
        dec: Angle.DegreesMinutesSeconds((int)-39, (int)51, 36.400)
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
    primaryId: "HIP 4482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4482"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.35974775),
        dec: Angle.Degrees(-39.85850948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184286"},
        {"Hipparcos Number", "HIP 96352"},
        {"Geneva Identification System", "GEN# +1.00184286"},
        {"Smithsonian Astrophysical Observation", "SAO 211385"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.85584470),
        dec: Angle.Degrees(-39.85795778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214291"},
        {"Hipparcos Number", "HIP 111718"},
        {"Smithsonian Astrophysical Observation", "SAO 231223"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.44894698),
        dec: Angle.Degrees(-39.85711935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6629"},
        {"Hipparcos Number", "HIP 5198"},
        {"Fundamental Katalog 5th Edition", "FK5 4101"},
        {"Smithsonian Astrophysical Observation", "SAO 215367"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.61533292),
        dec: Angle.Degrees(-39.85632513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16815"},
        {"Hipparcos Number", "HIP 12486"},
        {"Fundamental Katalog 5th Edition", "FK5 1075"},
        {"Geneva Identification System", "GEN# +1.00016815"},
        {"Smithsonian Astrophysical Observation", "SAO 215999"},
        {"Wilson Evans Batten Catalogue", "WEB 2555"},
    },
    visualMagnitude: 4.11,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.16638213),
        dec: Angle.Degrees(-39.85530905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174231"},
        {"Hipparcos Number", "HIP 92534"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.85624012),
        dec: Angle.Degrees(-39.85393820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185202"},
        {"Hipparcos Number", "HIP 96716"},
        {"Geneva Identification System", "GEN# +1.00185202"},
        {"Smithsonian Astrophysical Observation", "SAO 211446"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.91371857),
        dec: Angle.Degrees(-39.85388980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29890"},
        {"Hipparcos Number", "HIP 21785"},
        {"Geneva Identification System", "GEN# +1.00029890"},
        {"Smithsonian Astrophysical Observation", "SAO 195223"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.20249812),
        dec: Angle.Degrees(-39.85307647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83166"},
        {"Hipparcos Number", "HIP 47060"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.85842899),
        dec: Angle.Degrees(-39.85228076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182186"},
        {"Hipparcos Number", "HIP 95464"},
        {"Smithsonian Astrophysical Observation", "SAO 211246"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.28934916),
        dec: Angle.Degrees(-39.85221732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63033"},
        {"Hipparcos Number", "HIP 37809"},
        {"Smithsonian Astrophysical Observation", "SAO 198396"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.28506981),
        dec: Angle.Degrees(-39.84880323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160959"},
        {"Hipparcos Number", "HIP 86853"},
        {"Geneva Identification System", "GEN# +1.00160959"},
        {"Smithsonian Astrophysical Observation", "SAO 209209"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.18885404),
        dec: Angle.Degrees(-39.84834877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59196"},
        {"Hipparcos Number", "HIP 36177"},
        {"Smithsonian Astrophysical Observation", "SAO 198008"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.76138826),
        dec: Angle.Degrees(-39.84692783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57454"},
        {"Smithsonian Astrophysical Observation", "SAO 202796"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.66678988),
        dec: Angle.Degrees(-39.84569259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29889"},
        {"Hipparcos Number", "HIP 21784"},
        {"Geneva Identification System", "GEN# +1.00029889"},
        {"Smithsonian Astrophysical Observation", "SAO 195222"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.20201177),
        dec: Angle.Degrees(-39.84400738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144118"},
        {"Hipparcos Number", "HIP 78853"},
        {"Smithsonian Astrophysical Observation", "SAO 207320"},
    },
    visualMagnitude: 7.83,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.44288484),
        dec: Angle.Degrees(-39.84324986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9875"},
        {"Hipparcos Number", "HIP 7424"},
        {"Geneva Identification System", "GEN# +1.00009875"},
        {"Smithsonian Astrophysical Observation", "SAO 215572"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.91225188),
        dec: Angle.Degrees(-39.83839056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77550"},
        {"Hipparcos Number", "HIP 44346"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.47720387),
        dec: Angle.Degrees(-39.83701393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41574"},
        {"Hipparcos Number", "HIP 28732"},
        {"Smithsonian Astrophysical Observation", "SAO 196460"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.02893301),
        dec: Angle.Degrees(-39.83626398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28253"},
        {"Hipparcos Number", "HIP 20670"},
        {"Smithsonian Astrophysical Observation", "SAO 195007"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.41809821),
        dec: Angle.Degrees(-39.83600911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11421"},
        {"Hipparcos Number", "HIP 8641"},
        {"Smithsonian Astrophysical Observation", "SAO 215679"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.85977105),
        dec: Angle.Degrees(-39.83587507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88204"},
        {"Hipparcos Number", "HIP 49745"},
        {"Smithsonian Astrophysical Observation", "SAO 201104"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.32974985),
        dec: Angle.Degrees(-39.83544851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21594"},
        {"Hipparcos Number", "HIP 16121"},
        {"Geneva Identification System", "GEN# +1.00021594"},
        {"Smithsonian Astrophysical Observation", "SAO 216331"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.91607932),
        dec: Angle.Degrees(-39.83329747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63421"},
    },
    visualMagnitude: 11.85,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.94789588),
        dec: Angle.Degrees(-06.86039658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -251.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136166"},
        {"Hipparcos Number", "HIP 75080"},
        {"Smithsonian Astrophysical Observation", "SAO 206535"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.13975873),
        dec: Angle.Degrees(-39.83247655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78564"},
        {"Hipparcos Number", "HIP 44776"},
        {"Smithsonian Astrophysical Observation", "SAO 200003"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.88637690),
        dec: Angle.Degrees(-39.83212805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178254"},
        {"Hipparcos Number", "HIP 94130"},
        {"Geneva Identification System", "GEN# +1.00178254"},
        {"Smithsonian Astrophysical Observation", "SAO 210994"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.41566407),
        dec: Angle.Degrees(-39.82718505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26999"},
        {"Hipparcos Number", "HIP 19768"},
        {"Smithsonian Astrophysical Observation", "SAO 194860"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.58225005),
        dec: Angle.Degrees(-39.82580534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175529"},
        {"Hipparcos Number", "HIP 93074"},
        {"Geneva Identification System", "GEN# +1.00175529"},
        {"Smithsonian Astrophysical Observation", "SAO 210754"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.39330316),
        dec: Angle.Degrees(-39.82328561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133259"},
        {"Hipparcos Number", "HIP 73777"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.20390609),
        dec: Angle.Degrees(-39.82315686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148055"},
        {"Hipparcos Number", "HIP 80591"},
        {"Smithsonian Astrophysical Observation", "SAO 207673"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.81081998),
        dec: Angle.Degrees(-39.82270275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19352"},
        {"Hipparcos Number", "HIP 14372"},
        {"Smithsonian Astrophysical Observation", "SAO 216163"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.34999123),
        dec: Angle.Degrees(-39.82209991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53718"},
        {"Smithsonian Astrophysical Observation", "SAO 201981"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.86167159),
        dec: Angle.Degrees(-39.82119527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96082"},
        {"Hipparcos Number", "HIP 54123"},
        {"Smithsonian Astrophysical Observation", "SAO 202057"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.10820763),
        dec: Angle.Degrees(-39.82073365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99819"},
        {"Hipparcos Number", "HIP 56010"},
        {"Geneva Identification System", "GEN# +1.00099819"},
        {"Smithsonian Astrophysical Observation", "SAO 202492"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.17728522),
        dec: Angle.Degrees(-39.82066382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52620"},
        {"Hipparcos Number", "HIP 33700"},
        {"Celescope Catalog", "CEL 1500"},
        {"Geneva Identification System", "GEN# +1.00052620"},
        {"Smithsonian Astrophysical Observation", "SAO 197462"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.02884460),
        dec: Angle.Degrees(-39.82064481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212036"},
        {"Hipparcos Number", "HIP 110440"},
        {"Geneva Identification System", "GEN# +1.00212036"},
        {"Smithsonian Astrophysical Observation", "SAO 231098"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.55672738),
        dec: Angle.Degrees(-39.81960870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24438"},
        {"Hipparcos Number", "HIP 18065"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.91521829),
        dec: Angle.Degrees(-39.81428214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93556"},
        {"Hipparcos Number", "HIP 52779"},
        {"Smithsonian Astrophysical Observation", "SAO 201749"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.86224442),
        dec: Angle.Degrees(-39.81398850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135667"},
        {"Hipparcos Number", "HIP 74847"},
        {"Geneva Identification System", "GEN# +1.00135667"},
        {"Smithsonian Astrophysical Observation", "SAO 206492"},
        {"Wilson Evans Batten Catalogue", "WEB 12766"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.42988538),
        dec: Angle.Degrees(-39.81196476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91147",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91147"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.91739099),
        dec: Angle.Degrees(-39.81156356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173971"},
        {"Hipparcos Number", "HIP 92421"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.51986355),
        dec: Angle.Degrees(-39.81053896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198716"},
        {"Hipparcos Number", "HIP 103127"},
        {"Geneva Identification System", "GEN# +1.00198716"},
        {"Smithsonian Astrophysical Observation", "SAO 212522"},
        {"Wilson Evans Batten Catalogue", "WEB 18727"},
    },
    visualMagnitude: 5.34,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.41730078),
        dec: Angle.Degrees(-39.80962825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137933"},
        {"Hipparcos Number", "HIP 75925"},
        {"Smithsonian Astrophysical Observation", "SAO 206704"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.61192116),
        dec: Angle.Degrees(-39.80908046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156409"},
        {"Hipparcos Number", "HIP 84735"},
        {"Geneva Identification System", "GEN# +1.00156409"},
        {"Smithsonian Astrophysical Observation", "SAO 208679"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.82017034),
        dec: Angle.Degrees(-39.80697230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173149"},
        {"Hipparcos Number", "HIP 92051"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.43193983),
        dec: Angle.Degrees(-39.80600578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25703"},
        {"Hipparcos Number", "HIP 18885"},
        {"Smithsonian Astrophysical Observation", "SAO 194717"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.73239677),
        dec: Angle.Degrees(-39.80570676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17588"},
        {"Hipparcos Number", "HIP 13078"},
        {"Fundamental Katalog 5th Edition", "FK5 4256"},
        {"Smithsonian Astrophysical Observation", "SAO 216051"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.02264766),
        dec: Angle.Degrees(-39.80346907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37608"},
        {"Hipparcos Number", "HIP 26478"},
        {"Geneva Identification System", "GEN# +1.00037608"},
        {"Smithsonian Astrophysical Observation", "SAO 196037"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.47354631),
        dec: Angle.Degrees(-39.80237305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103030"},
        {"Hipparcos Number", "HIP 57830"},
        {"Smithsonian Astrophysical Observation", "SAO 202879"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.89264809),
        dec: Angle.Degrees(-39.80057415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75223"},
        {"Hipparcos Number", "HIP 43154"},
        {"Smithsonian Astrophysical Observation", "SAO 199622"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.84161511),
        dec: Angle.Degrees(-39.79979745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73901"},
        {"Hipparcos Number", "HIP 42453"},
        {"Geneva Identification System", "GEN# +1.00073901"},
        {"Renson", "Renson 20600"},
        {"Smithsonian Astrophysical Observation", "SAO 199474"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.82877417),
        dec: Angle.Degrees(-39.79927279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132381"},
        {"Hipparcos Number", "HIP 73407"},
        {"Smithsonian Astrophysical Observation", "SAO 206184"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.01939320),
        dec: Angle.Degrees(-39.79797040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113582"},
        {"Hipparcos Number", "HIP 63860"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.31764064),
        dec: Angle.Degrees(-39.79524030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211191"},
        {"Hipparcos Number", "HIP 109958"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.06101463),
        dec: Angle.Degrees(-39.79467252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1040"},
        {"Hipparcos Number", "HIP 1173"},
        {"Smithsonian Astrophysical Observation", "SAO 215015"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.66271500),
        dec: Angle.Degrees(-39.79415833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161949"},
        {"Hipparcos Number", "HIP 87301"},
        {"Smithsonian Astrophysical Observation", "SAO 209326"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.57367704),
        dec: Angle.Degrees(-39.79402187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14005"},
        {"Hipparcos Number", "HIP 10477"},
        {"Smithsonian Astrophysical Observation", "SAO 215837"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.77674917),
        dec: Angle.Degrees(-39.79214050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206073"},
        {"Hipparcos Number", "HIP 107035"},
        {"Smithsonian Astrophysical Observation", "SAO 230789"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.16225374),
        dec: Angle.Degrees(-39.79093021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137619"},
        {"Hipparcos Number", "HIP 75743"},
        {"Geneva Identification System", "GEN# +1.00137619"},
        {"Smithsonian Astrophysical Observation", "SAO 206679"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.11289565),
        dec: Angle.Degrees(-39.78888497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170463"},
        {"Hipparcos Number", "HIP 90802"},
        {"Smithsonian Astrophysical Observation", "SAO 210261"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.85297905),
        dec: Angle.Degrees(-39.78823780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48503"},
        {"Hipparcos Number", "HIP 32059"},
        {"Celescope Catalog", "CEL 1361"},
        {"Geneva Identification System", "GEN# +1.00048503"},
        {"Smithsonian Astrophysical Observation", "SAO 197101"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.47448420),
        dec: Angle.Degrees(-39.78767538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181548"},
        {"Hipparcos Number", "HIP 95243"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.66314107),
        dec: Angle.Degrees(-39.78725107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176337"},
        {"Hipparcos Number", "HIP 93420"},
        {"Geneva Identification System", "GEN# +1.00176337"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.39712607),
        dec: Angle.Degrees(-39.78675743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184019"},
        {"Hipparcos Number", "HIP 96223"},
        {"Smithsonian Astrophysical Observation", "SAO 211366"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.50756301),
        dec: Angle.Degrees(-39.78627710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112453"},
        {"Hipparcos Number", "HIP 63213"},
        {"Smithsonian Astrophysical Observation", "SAO 203967"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.28530977),
        dec: Angle.Degrees(-39.78591607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160002"},
        {"Hipparcos Number", "HIP 86425"},
        {"Geneva Identification System", "GEN# +1.00160002"},
        {"Smithsonian Astrophysical Observation", "SAO 209080"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.88185450),
        dec: Angle.Degrees(-39.78033392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19480"},
        {"Hipparcos Number", "HIP 14457"},
        {"Smithsonian Astrophysical Observation", "SAO 194091"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.64027403),
        dec: Angle.Degrees(-39.78012958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203493"},
        {"Hipparcos Number", "HIP 105631"},
        {"Geneva Identification System", "GEN# +1.00203493"},
        {"Smithsonian Astrophysical Observation", "SAO 212968"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.91886594),
        dec: Angle.Degrees(-39.77870228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76859"},
        {"Hipparcos Number", "HIP 43991"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.37314157),
        dec: Angle.Degrees(-39.77842562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73194"},
    },
    visualMagnitude: 11.43,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.38858481),
        dec: Angle.Degrees(-06.32972484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219009"},
        {"Hipparcos Number", "HIP 114591"},
        {"Smithsonian Astrophysical Observation", "SAO 231489"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.21498184),
        dec: Angle.Degrees(-39.77781718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81134"},
        {"Hipparcos Number", "HIP 45980"},
        {"Geneva Identification System", "GEN# +1.00081134"},
        {"Smithsonian Astrophysical Observation", "SAO 200299"},
        {"Wilson Evans Batten Catalogue", "WEB 8717"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.65261590),
        dec: Angle.Degrees(-39.77542078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151397"},
        {"Hipparcos Number", "HIP 82286"},
        {"Geneva Identification System", "GEN# +1.00151397"},
        {"Wilson Evans Batten Catalogue", "WEB 13891"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.20813296),
        dec: Angle.Degrees(-39.77129949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74007"},
        {"Hipparcos Number", "HIP 42500"},
        {"Smithsonian Astrophysical Observation", "SAO 199484"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.96363042),
        dec: Angle.Degrees(-39.77108934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217655"},
        {"Hipparcos Number", "HIP 113795"},
        {"Smithsonian Astrophysical Observation", "SAO 231407"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.67907011),
        dec: Angle.Degrees(-39.76937959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155603"},
        {"Hipparcos Number", "HIP 84332"},
        {"Geneva Identification System", "GEN# +1.00155603A"},
        {"Smithsonian Astrophysical Observation", "SAO 208569"},
    },
    visualMagnitude: 6.42,
    bvColour: 2.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.61523157),
        dec: Angle.Degrees(-39.76664573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36464"},
        {"Hipparcos Number", "HIP 25757"},
        {"Smithsonian Astrophysical Observation", "SAO 195910"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.51111068),
        dec: Angle.Degrees(-39.76614940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113521"},
        {"Hipparcos Number", "HIP 63823"},
        {"Smithsonian Astrophysical Observation", "SAO 204102"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.21090990),
        dec: Angle.Degrees(-39.76481230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224123"},
        {"Hipparcos Number", "HIP 117943"},
        {"Smithsonian Astrophysical Observation", "SAO 231847"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.85241899),
        dec: Angle.Degrees(-39.76395139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114872"},
        {"Hipparcos Number", "HIP 64553"},
        {"Smithsonian Astrophysical Observation", "SAO 204259"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.47541427),
        dec: Angle.Degrees(-39.76327079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20398"},
        {"Hipparcos Number", "HIP 15162"},
        {"Smithsonian Astrophysical Observation", "SAO 194190"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.86141377),
        dec: Angle.Degrees(-39.76208786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69298"},
        {"Hipparcos Number", "HIP 40389"},
        {"Smithsonian Astrophysical Observation", "SAO 198987"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.69005643),
        dec: Angle.Degrees(-39.76141155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3013"},
        {"Hipparcos Number", "HIP 2607"},
        {"Smithsonian Astrophysical Observation", "SAO 215138"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.28057504),
        dec: Angle.Degrees(-39.75963452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31603"},
        {"Hipparcos Number", "HIP 22883"},
        {"Geneva Identification System", "GEN# +1.00031603"},
        {"Smithsonian Astrophysical Observation", "SAO 195405"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.83359060),
        dec: Angle.Degrees(-39.75880516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80483"},
        {"Hipparcos Number", "HIP 45683"},
        {"Smithsonian Astrophysical Observation", "SAO 200227"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.70133705),
        dec: Angle.Degrees(-39.75746668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76227"},
    },
    visualMagnitude: 12.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.56798399),
        dec: Angle.Degrees(-39.75685308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217566"},
        {"Hipparcos Number", "HIP 113730"},
        {"Geneva Identification System", "GEN# +1.00217566"},
        {"Smithsonian Astrophysical Observation", "SAO 231399"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.49275296),
        dec: Angle.Degrees(-39.75589038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138530"},
        {"Hipparcos Number", "HIP 76229"},
        {"Smithsonian Astrophysical Observation", "SAO 206767"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.57178194),
        dec: Angle.Degrees(-39.75546791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35114"},
        {"Hipparcos Number", "HIP 24947"},
        {"Geneva Identification System", "GEN# +1.00035114"},
        {"Smithsonian Astrophysical Observation", "SAO 195766"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.15841138),
        dec: Angle.Degrees(-39.75497535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116713"},
        {"Hipparcos Number", "HIP 65535"},
        {"Fundamental Katalog 5th Edition", "FK5 3073"},
        {"Geneva Identification System", "GEN# +1.00116713"},
        {"Smithsonian Astrophysical Observation", "SAO 204465"},
        {"Wilson Evans Batten Catalogue", "WEB 11571"},
    },
    visualMagnitude: 5.11,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.53182918),
        dec: Angle.Degrees(-39.75496493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31604"},
        {"Hipparcos Number", "HIP 22892"},
        {"Smithsonian Astrophysical Observation", "SAO 195407"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.85491149),
        dec: Angle.Degrees(-39.75464177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46173"},
        {"Hipparcos Number", "HIP 30966"},
        {"Smithsonian Astrophysical Observation", "SAO 196882"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.49407942),
        dec: Angle.Degrees(-39.75435310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201972"},
        {"Hipparcos Number", "HIP 104841"},
        {"Smithsonian Astrophysical Observation", "SAO 212814"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.57312350),
        dec: Angle.Degrees(-39.75338584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69674"},
        {"Hipparcos Number", "HIP 40520"},
        {"Smithsonian Astrophysical Observation", "SAO 199024"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.10488713),
        dec: Angle.Degrees(-39.75309981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74935"},
        {"Hipparcos Number", "HIP 42977"},
        {"Geneva Identification System", "GEN# +1.00074935"},
        {"Smithsonian Astrophysical Observation", "SAO 199585"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.38576605),
        dec: Angle.Degrees(-39.75232787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124077"},
        {"Hipparcos Number", "HIP 69392"},
        {"Smithsonian Astrophysical Observation", "SAO 205295"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.08560097),
        dec: Angle.Degrees(-39.75155182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39445"},
        {"Hipparcos Number", "HIP 27611"},
        {"Smithsonian Astrophysical Observation", "SAO 196238"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.69832566),
        dec: Angle.Degrees(-39.75029202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172127"},
        {"Hipparcos Number", "HIP 91566"},
        {"Geneva Identification System", "GEN# +1.00172127"},
    },
    visualMagnitude: 10.48,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.08850590),
        dec: Angle.Degrees(-39.74993336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172993"},
        {"Hipparcos Number", "HIP 91992"},
        {"Geneva Identification System", "GEN# +1.00172993"},
        {"Smithsonian Astrophysical Observation", "SAO 210520"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.24683926),
        dec: Angle.Degrees(-39.74968463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223010"},
        {"Hipparcos Number", "HIP 117211"},
        {"Smithsonian Astrophysical Observation", "SAO 231768"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.49792396),
        dec: Angle.Degrees(-39.74804475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210900"},
        {"Hipparcos Number", "HIP 109795"},
        {"Geneva Identification System", "GEN# +1.00210900"},
        {"Smithsonian Astrophysical Observation", "SAO 213654"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.58710868),
        dec: Angle.Degrees(-39.74793274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146499"},
        {"Hipparcos Number", "HIP 79871"},
        {"Geneva Identification System", "GEN# +1.00146499"},
        {"Smithsonian Astrophysical Observation", "SAO 207523"},
        {"Wilson Evans Batten Catalogue", "WEB 13520"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.55231771),
        dec: Angle.Degrees(-39.74764832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118781"},
        {"Hipparcos Number", "HIP 66645"},
        {"Geneva Identification System", "GEN# +1.00118781"},
        {"Smithsonian Astrophysical Observation", "SAO 204708"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.92022537),
        dec: Angle.Degrees(-39.74756765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185217"},
        {"Hipparcos Number", "HIP 96719"},
        {"Smithsonian Astrophysical Observation", "SAO 211448"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.92222192),
        dec: Angle.Degrees(-39.74633147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3277"},
        {"Hipparcos Number", "HIP 2790"},
        {"Cincinnati Publication", "Ci 18 72"},
        {"Geneva Identification System", "GEN# +1.00003277"},
        {"Smithsonian Astrophysical Observation", "SAO 215155"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.89236491),
        dec: Angle.Degrees(-39.74588990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75870"},
        {"Hipparcos Number", "HIP 43473"},
        {"Geneva Identification System", "GEN# +1.00075870"},
        {"Smithsonian Astrophysical Observation", "SAO 199710"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.83082341),
        dec: Angle.Degrees(-39.74512881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110123"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.61097354),
        dec: Angle.Degrees(-39.74499842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184711"},
        {"Hipparcos Number", "HIP 96508"},
        {"Geneva Identification System", "GEN# +1.00184711"},
        {"Smithsonian Astrophysical Observation", "SAO 211415"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.29968096),
        dec: Angle.Degrees(-39.74348735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100625"},
    },
    visualMagnitude: 12.14,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.06198738),
        dec: Angle.Degrees(-39.74283642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145445"},
        {"Hipparcos Number", "HIP 79429"},
        {"Geneva Identification System", "GEN# +1.00145445"},
        {"Smithsonian Astrophysical Observation", "SAO 207447"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.16391468),
        dec: Angle.Degrees(-39.74209458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93606"},
        {"Hipparcos Number", "HIP 52807"},
        {"Smithsonian Astrophysical Observation", "SAO 201756"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.94011031),
        dec: Angle.Degrees(-39.74024361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183804"},
        {"Hipparcos Number", "HIP 96144"},
        {"Smithsonian Astrophysical Observation", "SAO 211350"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.22935540),
        dec: Angle.Degrees(-39.74023460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193903"},
        {"Hipparcos Number", "HIP 100626"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.06370244),
        dec: Angle.Degrees(-39.73931048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215238"},
        {"Hipparcos Number", "HIP 112266"},
        {"Geneva Identification System", "GEN# +1.00215238"},
        {"Smithsonian Astrophysical Observation", "SAO 231271"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.08799825),
        dec: Angle.Degrees(-39.73887082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118352"},
        {"Hipparcos Number", "HIP 66425"},
        {"Smithsonian Astrophysical Observation", "SAO 204657"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.27020264),
        dec: Angle.Degrees(-39.73776665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 457"},
        {"Hipparcos Number", "HIP 726"},
        {"Geneva Identification System", "GEN# +1.00000457"},
        {"Smithsonian Astrophysical Observation", "SAO 214980"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.24830416),
        dec: Angle.Degrees(-39.73711336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110330"},
        {"Hipparcos Number", "HIP 61943"},
        {"Smithsonian Astrophysical Observation", "SAO 203715"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.42137701),
        dec: Angle.Degrees(-39.73226544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173357"},
        {"Hipparcos Number", "HIP 92130"},
        {"Smithsonian Astrophysical Observation", "SAO 210557"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.66428606),
        dec: Angle.Degrees(-39.73086024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212085"},
        {"Hipparcos Number", "HIP 110460"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.61779014),
        dec: Angle.Degrees(-39.72987596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72957"},
        {"Hipparcos Number", "HIP 42040"},
        {"Smithsonian Astrophysical Observation", "SAO 199383"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.54572003),
        dec: Angle.Degrees(-39.72916804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106387"},
        {"Hipparcos Number", "HIP 59686"},
        {"Smithsonian Astrophysical Observation", "SAO 203264"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.60670132),
        dec: Angle.Degrees(-39.72443281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19336"},
        {"Hipparcos Number", "HIP 14367"},
        {"Smithsonian Astrophysical Observation", "SAO 194076"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.34172592),
        dec: Angle.Degrees(-39.72155715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15840"},
        {"Hipparcos Number", "HIP 11758"},
        {"Smithsonian Astrophysical Observation", "SAO 193753"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.92395410),
        dec: Angle.Degrees(-39.72092320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32453"},
        {"Hipparcos Number", "HIP 23377"},
        {"Geneva Identification System", "GEN# +1.00032453"},
        {"Smithsonian Astrophysical Observation", "SAO 195501"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.39385911),
        dec: Angle.Degrees(-39.71812649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105454"},
        {"Hipparcos Number", "HIP 59202"},
        {"Smithsonian Astrophysical Observation", "SAO 203164"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.10822298),
        dec: Angle.Degrees(-39.71744291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118945"},
        {"Hipparcos Number", "HIP 66755"},
        {"Smithsonian Astrophysical Observation", "SAO 204724"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.23778490),
        dec: Angle.Degrees(-39.71740771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17354"},
        {"Hipparcos Number", "HIP 12894"},
        {"Smithsonian Astrophysical Observation", "SAO 193896"},
        {"Smithsonian Astrophysical Observation 2", "SAO 193898"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.43652240),
        dec: Angle.Degrees(-39.71717957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111373"},
        {"Hipparcos Number", "HIP 62566"},
        {"Smithsonian Astrophysical Observation", "SAO 203835"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.29184598),
        dec: Angle.Degrees(-39.71713997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123790"},
        {"Hipparcos Number", "HIP 69258"},
        {"Geneva Identification System", "GEN# +1.00123790"},
        {"Smithsonian Astrophysical Observation", "SAO 205260"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.67520542),
        dec: Angle.Degrees(-39.71543059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125865"},
        {"Hipparcos Number", "HIP 70313"},
        {"Smithsonian Astrophysical Observation", "SAO 205499"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.78948971),
        dec: Angle.Degrees(-39.71491447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166649"},
        {"Hipparcos Number", "HIP 89315"},
        {"Geneva Identification System", "GEN# +1.00166649"},
        {"Smithsonian Astrophysical Observation", "SAO 209864"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.36860249),
        dec: Angle.Degrees(-39.71121308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219105"},
        {"Hipparcos Number", "HIP 114667"},
        {"Smithsonian Astrophysical Observation", "SAO 214393"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.42379150),
        dec: Angle.Degrees(-39.71071253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136933"},
        {"Hipparcos Number", "HIP 75439"},
        {"Geneva Identification System", "GEN# +1.00136933"},
        {"Renson", "Renson 38890"},
        {"Smithsonian Astrophysical Observation", "SAO 206597"},
        {"Wilson Evans Batten Catalogue", "WEB 12866"},
    },
    visualMagnitude: 5.36,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.18761813),
        dec: Angle.Degrees(-39.71013154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5955"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.15863708),
        dec: Angle.Degrees(-39.70875905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198190"},
        {"Hipparcos Number", "HIP 102839"},
        {"Smithsonian Astrophysical Observation", "SAO 212471"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.51321229),
        dec: Angle.Degrees(-39.70848842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158216"},
        {"Hipparcos Number", "HIP 85627"},
        {"Smithsonian Astrophysical Observation", "SAO 208879"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.46451990),
        dec: Angle.Degrees(-39.70612457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58414"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.65676223),
        dec: Angle.Degrees(-39.70610550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70642"},
        {"Hipparcos Number", "HIP 40952"},
        {"Geneva Identification System", "GEN# +1.00070642"},
        {"Smithsonian Astrophysical Observation", "SAO 199126"},
        {"Wilson Evans Batten Catalogue", "WEB 7942"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.36787219),
        dec: Angle.Degrees(-39.70595775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 225.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40690"},
        {"Hipparcos Number", "HIP 28288"},
        {"Smithsonian Astrophysical Observation", "SAO 196373"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.65921830),
        dec: Angle.Degrees(-39.70489386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170642"},
        {"Hipparcos Number", "HIP 90887"},
        {"Geneva Identification System", "GEN# +1.00170642"},
        {"Smithsonian Astrophysical Observation", "SAO 210277"},
        {"Wilson Evans Batten Catalogue", "WEB 15586"},
    },
    visualMagnitude: 5.16,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.08877815),
        dec: Angle.Degrees(-39.70390941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45171"},
        {"Hipparcos Number", "HIP 30451"},
        {"Fundamental Katalog 5th Edition", "FK5 4579"},
        {"Smithsonian Astrophysical Observation", "SAO 196778"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.01515956),
        dec: Angle.Degrees(-39.70279590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122511"},
        {"Hipparcos Number", "HIP 68653"},
        {"Celescope Catalog", "CEL 4296"},
        {"Geneva Identification System", "GEN# +1.00122511"},
        {"Smithsonian Astrophysical Observation", "SAO 205125"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.79766567),
        dec: Angle.Degrees(-39.70275227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89677"},
        {"Hipparcos Number", "HIP 50590"},
        {"Celescope Catalog", "CEL 3509"},
        {"Geneva Identification System", "GEN# +1.00089677"},
        {"Smithsonian Astrophysical Observation", "SAO 201291"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.02175273),
        dec: Angle.Degrees(-39.70252701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143280"},
        {"Hipparcos Number", "HIP 78456"},
        {"Geneva Identification System", "GEN# +1.00143280"},
        {"Smithsonian Astrophysical Observation", "SAO 207229"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.25473751),
        dec: Angle.Degrees(-39.70242291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2279"},
        {"Hipparcos Number", "HIP 2094"},
        {"Geneva Identification System", "GEN# +1.00002279"},
        {"Smithsonian Astrophysical Observation", "SAO 192525"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.61110099),
        dec: Angle.Degrees(-39.70104781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151833"},
        {"Hipparcos Number", "HIP 82489"},
        {"Smithsonian Astrophysical Observation", "SAO 208095"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.88647862),
        dec: Angle.Degrees(-39.69753142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92794"},
        {"Hipparcos Number", "HIP 52367"},
        {"Smithsonian Astrophysical Observation", "SAO 201654"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.54897706),
        dec: Angle.Degrees(-39.69498689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171206"},
        {"Hipparcos Number", "HIP 91125"},
        {"Geneva Identification System", "GEN# +1.00171206"},
        {"Smithsonian Astrophysical Observation", "SAO 210339"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.81779024),
        dec: Angle.Degrees(-39.69431360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188943"},
        {"Hipparcos Number", "HIP 98380"},
        {"Smithsonian Astrophysical Observation", "SAO 211710"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.82078039),
        dec: Angle.Degrees(-39.69428016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115092"},
        {"Hipparcos Number", "HIP 64687"},
        {"Smithsonian Astrophysical Observation", "SAO 204290"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.86821159),
        dec: Angle.Degrees(-39.69308122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156216"},
        {"Hipparcos Number", "HIP 84638"},
        {"Smithsonian Astrophysical Observation", "SAO 208651"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.54977762),
        dec: Angle.Degrees(-39.69075640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50857"},
        {"Hipparcos Number", "HIP 33055"},
        {"Smithsonian Astrophysical Observation", "SAO 197319"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.27734267),
        dec: Angle.Degrees(-39.69029882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49726"},
        {"Hipparcos Number", "HIP 32597"},
        {"Geneva Identification System", "GEN# +1.00049726"},
        {"Smithsonian Astrophysical Observation", "SAO 197226"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.00269246),
        dec: Angle.Degrees(-39.68950102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103637"},
        {"Hipparcos Number", "HIP 58177"},
        {"Geneva Identification System", "GEN# +1.00103637"},
        {"Smithsonian Astrophysical Observation", "SAO 202950"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.97802134),
        dec: Angle.Degrees(-39.68947554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200236"},
        {"Hipparcos Number", "HIP 103941"},
        {"Smithsonian Astrophysical Observation", "SAO 212672"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.90219271),
        dec: Angle.Degrees(-39.68770298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54416"},
        {"Smithsonian Astrophysical Observation", "SAO 202117"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.02463584),
        dec: Angle.Degrees(-39.68741947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32327"},
        {"Hipparcos Number", "HIP 23281"},
        {"Smithsonian Astrophysical Observation", "SAO 195483"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.13677053),
        dec: Angle.Degrees(-39.68628358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172991"},
        {"Henry Draper 2", "HD 172992"},
        {"Hipparcos Number", "HIP 91989"},
        {"Geneva Identification System", "GEN# +1.00172991"},
        {"Smithsonian Astrophysical Observation", "SAO 210518"},
        {"Wilson Evans Batten Catalogue", "WEB 15844"},
    },
    visualMagnitude: 5.40,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.23812444),
        dec: Angle.Degrees(-39.68617292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45570"},
        {"Hipparcos Number", "HIP 30649"},
        {"Smithsonian Astrophysical Observation", "SAO 196823"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.60413219),
        dec: Angle.Degrees(-39.68535604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195982"},
        {"Hipparcos Number", "HIP 101625"},
        {"Smithsonian Astrophysical Observation", "SAO 212264"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.95500136),
        dec: Angle.Degrees(-39.68442477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48359"},
        {"Smithsonian Astrophysical Observation", "SAO 200816"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.88780240),
        dec: Angle.Degrees(-39.68422343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101900"},
        {"Hipparcos Number", "HIP 57177"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.88543602),
        dec: Angle.Degrees(-39.68296317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130732"},
        {"Hipparcos Number", "HIP 72632"},
        {"Smithsonian Astrophysical Observation", "SAO 206002"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.75775943),
        dec: Angle.Degrees(-39.68055172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111774"},
        {"Hipparcos Number", "HIP 62786"},
        {"Geneva Identification System", "GEN# +1.00111774"},
        {"Smithsonian Astrophysical Observation", "SAO 203881"},
        {"Wilson Evans Batten Catalogue", "WEB 11130"},
    },
    visualMagnitude: 5.99,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.98729210),
        dec: Angle.Degrees(-39.68038459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35515"},
        {"Hipparcos Number", "HIP 25194"},
        {"Fundamental Katalog 5th Edition", "FK5 2405"},
        {"Geneva Identification System", "GEN# +1.00035515"},
        {"Smithsonian Astrophysical Observation", "SAO 195807"},
    },
    visualMagnitude: 5.73,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.85001902),
        dec: Angle.Degrees(-39.67843559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1482"},
        {"Hipparcos Number", "HIP 1507"},
        {"Geneva Identification System", "GEN# +1.00001482"},
        {"Smithsonian Astrophysical Observation", "SAO 192457"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.69103252),
        dec: Angle.Degrees(-39.67729918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167952"},
        {"Hipparcos Number", "HIP 89785"},
        {"Geneva Identification System", "GEN# +1.00167952"},
        {"Smithsonian Astrophysical Observation", "SAO 209985"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.84681939),
        dec: Angle.Degrees(-39.67672946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172411"},
        {"Hipparcos Number", "HIP 91690"},
        {"Geneva Identification System", "GEN# +1.00172411"},
        {"Smithsonian Astrophysical Observation", "SAO 210466"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.46647545),
        dec: Angle.Degrees(-39.67520752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11511"},
        {"Hipparcos Number", "HIP 8722"},
        {"Smithsonian Astrophysical Observation", "SAO 193346"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.05146655),
        dec: Angle.Degrees(-39.67437883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122209"},
        {"Hipparcos Number", "HIP 68499"},
        {"Smithsonian Astrophysical Observation", "SAO 205098"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.34115374),
        dec: Angle.Degrees(-39.66974060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159513"},
        {"Hipparcos Number", "HIP 86203"},
        {"Smithsonian Astrophysical Observation", "SAO 209024"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.23951810),
        dec: Angle.Degrees(-39.66846650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186915"},
        {"Hipparcos Number", "HIP 97480"},
        {"Smithsonian Astrophysical Observation", "SAO 211569"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.19585607),
        dec: Angle.Degrees(-39.66768686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12409"},
        {"Hipparcos Number", "HIP 9387"},
        {"Smithsonian Astrophysical Observation", "SAO 193451"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.15919068),
        dec: Angle.Degrees(-39.66470653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68391"},
        {"Hipparcos Number", "HIP 40029"},
        {"Geneva Identification System", "GEN# +1.00068391"},
        {"Smithsonian Astrophysical Observation", "SAO 198886"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.64358876),
        dec: Angle.Degrees(-39.66461499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179699"},
        {"Hipparcos Number", "HIP 94625"},
        {"Geneva Identification System", "GEN# +1.00179699"},
        {"Smithsonian Astrophysical Observation", "SAO 211089"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.83453559),
        dec: Angle.Degrees(-39.66303465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56403"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.44518400),
        dec: Angle.Degrees(-39.66253820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183313"},
        {"Hipparcos Number", "HIP 95939"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.66671192),
        dec: Angle.Degrees(-39.65623696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209242"},
        {"Hipparcos Number", "HIP 108824"},
        {"Smithsonian Astrophysical Observation", "SAO 213496"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.69770080),
        dec: Angle.Degrees(-39.65616323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54893"},
        {"Hipparcos Number", "HIP 34495"},
        {"Celescope Catalog", "CEL 1619"},
        {"Fundamental Katalog 5th Edition", "FK5 2551"},
        {"Geneva Identification System", "GEN# +1.00054893"},
        {"Smithsonian Astrophysical Observation", "SAO 197632"},
        {"Wilson Evans Batten Catalogue", "WEB 6911"},
    },
    visualMagnitude: 4.83,
    bvColour: -0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.21281817),
        dec: Angle.Degrees(-39.65567374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108684"},
        {"Hipparcos Number", "HIP 60935"},
        {"Geneva Identification System", "GEN# +1.00108684"},
        {"Smithsonian Astrophysical Observation", "SAO 203522"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.33835141),
        dec: Angle.Degrees(-39.65513123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77668"},
        {"Hipparcos Number", "HIP 44394"},
        {"Smithsonian Astrophysical Observation", "SAO 199914"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.64795466),
        dec: Angle.Degrees(-39.65429880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2259"},
        {"Hipparcos Number", "HIP 2076"},
        {"Smithsonian Astrophysical Observation", "SAO 192523"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.55594867),
        dec: Angle.Degrees(-39.64919605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126474"},
        {"Hipparcos Number", "HIP 70627"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.70867660),
        dec: Angle.Degrees(-39.64709451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144810"},
        {"Hipparcos Number", "HIP 79151"},
        {"Smithsonian Astrophysical Observation", "SAO 207383"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.32247547),
        dec: Angle.Degrees(-39.64639377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64953"},
        {"Hipparcos Number", "HIP 38628"},
        {"Smithsonian Astrophysical Observation", "SAO 198582"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.65160979),
        dec: Angle.Degrees(-39.64320232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76763"},
        {"Hipparcos Number", "HIP 43917"},
        {"Smithsonian Astrophysical Observation", "SAO 199815"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.19753066),
        dec: Angle.Degrees(-39.64182039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46816"},
        {"Hipparcos Number", "HIP 31280"},
        {"Geneva Identification System", "GEN# +1.00046816"},
        {"Smithsonian Astrophysical Observation", "SAO 196944"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.41021509),
        dec: Angle.Degrees(-39.64181338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141339"},
        {"Hipparcos Number", "HIP 77560"},
        {"Smithsonian Astrophysical Observation", "SAO 207022"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.52588211),
        dec: Angle.Degrees(-39.63893419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192488"},
        {"Hipparcos Number", "HIP 99939"},
        {"Smithsonian Astrophysical Observation", "SAO 211953"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.15906847),
        dec: Angle.Degrees(-39.63475852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103973"},
        {"Hipparcos Number", "HIP 58381"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.57405631),
        dec: Angle.Degrees(-39.63288065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43881"},
        {"Hipparcos Number", "HIP 29823"},
        {"Smithsonian Astrophysical Observation", "SAO 196650"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.20988581),
        dec: Angle.Degrees(-39.63266377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139596"},
        {"Hipparcos Number", "HIP 76775"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.13516195),
        dec: Angle.Degrees(-39.63162766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146906"},
        {"Hipparcos Number", "HIP 80035"},
        {"Geneva Identification System", "GEN# +1.00146906"},
        {"Smithsonian Astrophysical Observation", "SAO 207570"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.06087603),
        dec: Angle.Degrees(-39.63006014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31529"},
        {"Hipparcos Number", "HIP 22847"},
        {"Fundamental Katalog 5th Edition", "FK5 2371"},
        {"Geneva Identification System", "GEN# +1.00031529"},
        {"Smithsonian Astrophysical Observation", "SAO 195400"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.72840898),
        dec: Angle.Degrees(-39.62866145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116293"},
        {"Hipparcos Number", "HIP 65328"},
        {"Smithsonian Astrophysical Observation", "SAO 204423"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.84686995),
        dec: Angle.Degrees(-39.62794255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218491"},
        {"Hipparcos Number", "HIP 114295"},
        {"Smithsonian Astrophysical Observation", "SAO 214341"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.21821764),
        dec: Angle.Degrees(-39.62776948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145880"},
        {"Hipparcos Number", "HIP 79631"},
        {"Geneva Identification System", "GEN# +1.00145880"},
        {"Smithsonian Astrophysical Observation", "SAO 207487"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.74075171),
        dec: Angle.Degrees(-39.62773519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125805"},
        {"Hipparcos Number", "HIP 70289"},
        {"Smithsonian Astrophysical Observation", "SAO 205495"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.71636138),
        dec: Angle.Degrees(-39.62394574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17390"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.86151642),
        dec: Angle.Degrees(-39.62305799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210233"},
        {"Hipparcos Number", "HIP 109399"},
        {"Smithsonian Astrophysical Observation", "SAO 213596"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.45125044),
        dec: Angle.Degrees(-39.62207853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70612"},
        {"Hipparcos Number", "HIP 40947"},
        {"Fundamental Katalog 5th Edition", "FK5 2648"},
        {"Geneva Identification System", "GEN# +1.00070612"},
        {"Smithsonian Astrophysical Observation", "SAO 199123"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.35075062),
        dec: Angle.Degrees(-39.62072962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27208"},
        {"Hipparcos Number", "HIP 19898"},
        {"Smithsonian Astrophysical Observation", "SAO 194884"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.02478379),
        dec: Angle.Degrees(-39.61993730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222136"},
        {"Hipparcos Number", "HIP 116642"},
        {"Geneva Identification System", "GEN# +1.00222136"},
        {"Smithsonian Astrophysical Observation", "SAO 214676"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.56439486),
        dec: Angle.Degrees(-39.61887480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68553"},
        {"Hipparcos Number", "HIP 40091"},
        {"Geneva Identification System", "GEN# +1.00068553"},
        {"Smithsonian Astrophysical Observation", "SAO 198908"},
        {"Wilson Evans Batten Catalogue", "WEB 7825"},
    },
    visualMagnitude: 4.44,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.83958436),
        dec: Angle.Degrees(-39.61855304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24268"},
        {"Hipparcos Number", "HIP 17934"},
        {"Smithsonian Astrophysical Observation", "SAO 194565"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.53166014),
        dec: Angle.Degrees(-39.61817829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182325"},
        {"Hipparcos Number", "HIP 95530"},
        {"Smithsonian Astrophysical Observation", "SAO 211252"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.47659977),
        dec: Angle.Degrees(-39.61674406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113104"},
        {"Hipparcos Number", "HIP 63583"},
        {"Smithsonian Astrophysical Observation", "SAO 204049"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.44330073),
        dec: Angle.Degrees(-39.61621266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197651"},
        {"Hipparcos Number", "HIP 102503"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.60545725),
        dec: Angle.Degrees(-39.61617405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19692"},
        {"Hipparcos Number", "HIP 14628"},
        {"Smithsonian Astrophysical Observation", "SAO 194113"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.23540908),
        dec: Angle.Degrees(-39.61577455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83610"},
        {"Hipparcos Number", "HIP 47328"},
        {"Geneva Identification System", "GEN# +1.00083610"},
        {"Smithsonian Astrophysical Observation", "SAO 200590"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.66976956),
        dec: Angle.Degrees(-39.61397828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65683"},
        {"Hipparcos Number", "HIP 38955"},
        {"Celescope Catalog", "CEL 2119"},
        {"Geneva Identification System", "GEN# +1.00065683"},
        {"Smithsonian Astrophysical Observation", "SAO 198646"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.55051782),
        dec: Angle.Degrees(-39.61310989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345"},
        {"Hipparcos Number", "HIP 651"},
        {"Smithsonian Astrophysical Observation", "SAO 192366"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.00331222),
        dec: Angle.Degrees(-39.61207474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77255"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.60922600),
        dec: Angle.Degrees(-39.61062066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155932"},
        {"Hipparcos Number", "HIP 84485"},
        {"Smithsonian Astrophysical Observation", "SAO 208608"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.07658020),
        dec: Angle.Degrees(-39.61060002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195598"},
        {"Hipparcos Number", "HIP 101466"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.44573945),
        dec: Angle.Degrees(-39.60637676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103565"},
        {"Hipparcos Number", "HIP 58138"},
        {"Smithsonian Astrophysical Observation", "SAO 202944"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.86263286),
        dec: Angle.Degrees(-39.60586157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47626"},
    },
    visualMagnitude: 12.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.67192315),
        dec: Angle.Degrees(-39.60566634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117222"},
        {"Hipparcos Number", "HIP 65827"},
        {"Smithsonian Astrophysical Observation", "SAO 204520"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.41448016),
        dec: Angle.Degrees(-39.60497511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99431"},
        {"Hipparcos Number", "HIP 55807"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.52672932),
        dec: Angle.Degrees(-39.60465238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74617"},
        {"Hipparcos Number", "HIP 42821"},
        {"Geneva Identification System", "GEN# +1.00074617"},
        {"Smithsonian Astrophysical Observation", "SAO 199549"},
        {"Wilson Evans Batten Catalogue", "WEB 8271"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.88433562),
        dec: Angle.Degrees(-39.59992414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128152"},
        {"Hipparcos Number", "HIP 71429"},
        {"Geneva Identification System", "GEN# +1.00128152"},
        {"Smithsonian Astrophysical Observation", "SAO 205744"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.10058028),
        dec: Angle.Degrees(-39.59734913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16877"},
        {"Hipparcos Number", "HIP 12522"},
        {"Smithsonian Astrophysical Observation", "SAO 193856"},
        {"Smithsonian Astrophysical Observation 2", "SAO 193858"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.28653800),
        dec: Angle.Degrees(-39.59633937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46933"},
        {"Geneva Identification System", "GEN# -0.03905624"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.48463899),
        dec: Angle.Degrees(-39.59463645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -246.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51093"},
        {"Hipparcos Number", "HIP 33161"},
        {"Smithsonian Astrophysical Observation", "SAO 197337"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.54941781),
        dec: Angle.Degrees(-39.59458968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52415"},
        {"Hipparcos Number", "HIP 33642"},
        {"Geneva Identification System", "GEN# +1.00052415"},
        {"Smithsonian Astrophysical Observation", "SAO 197444"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.83291049),
        dec: Angle.Degrees(-39.59291249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 181.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168358"},
        {"Hipparcos Number", "HIP 89945"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.28700122),
        dec: Angle.Degrees(-39.59268715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187292"},
        {"Hipparcos Number", "HIP 97667"},
        {"Smithsonian Astrophysical Observation", "SAO 211595"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.73102059),
        dec: Angle.Degrees(-39.59230975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91846"},
        {"Hipparcos Number", "HIP 51851"},
        {"Smithsonian Astrophysical Observation", "SAO 201542"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.91097562),
        dec: Angle.Degrees(-39.59129039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123458"},
        {"Hipparcos Number", "HIP 69108"},
        {"Smithsonian Astrophysical Observation", "SAO 205228"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.19797100),
        dec: Angle.Degrees(-39.59061057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4342"},
        {"Hipparcos Number", "HIP 3557"},
        {"Smithsonian Astrophysical Observation", "SAO 192717"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.36813605),
        dec: Angle.Degrees(-39.58859783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15310"},
        {"Hipparcos Number", "HIP 11385"},
        {"Smithsonian Astrophysical Observation", "SAO 193712"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.68057049),
        dec: Angle.Degrees(-39.58687974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59842"},
        {"Hipparcos Number", "HIP 36457"},
        {"Geneva Identification System", "GEN# +1.00059842"},
        {"Smithsonian Astrophysical Observation", "SAO 198060"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.52486301),
        dec: Angle.Degrees(-39.58314274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29904"},
        {"Hipparcos Number", "HIP 21805"},
        {"Smithsonian Astrophysical Observation", "SAO 195226"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.26398253),
        dec: Angle.Degrees(-39.58304347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36242"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.95158452),
        dec: Angle.Degrees(-39.58176743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86487"},
        {"Hipparcos Number", "HIP 48863"},
        {"Fundamental Katalog 5th Edition", "FK5 4887"},
        {"Smithsonian Astrophysical Observation", "SAO 200915"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.48942900),
        dec: Angle.Degrees(-39.57472983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11056"},
        {"Hipparcos Number", "HIP 8368"},
        {"Smithsonian Astrophysical Observation", "SAO 193304"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.94775744),
        dec: Angle.Degrees(-39.57420911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27440"},
        {"Hipparcos Number", "HIP 20061"},
        {"Smithsonian Astrophysical Observation", "SAO 194908"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.52854756),
        dec: Angle.Degrees(-39.57381906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168819"},
        {"Hipparcos Number", "HIP 90127"},
        {"Smithsonian Astrophysical Observation", "SAO 210073"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.88791818),
        dec: Angle.Degrees(-39.57275843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142303"},
        {"Hipparcos Number", "HIP 77962"},
        {"Geneva Identification System", "GEN# +1.00142303"},
        {"Smithsonian Astrophysical Observation", "SAO 207111"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.82867995),
        dec: Angle.Degrees(-39.57203787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84447"},
        {"Hipparcos Number", "HIP 47762"},
        {"Geneva Identification System", "GEN# +1.00084447"},
        {"Smithsonian Astrophysical Observation", "SAO 200681"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.06520213),
        dec: Angle.Degrees(-39.57119026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162892"},
        {"Hipparcos Number", "HIP 87731"},
        {"Geneva Identification System", "GEN# +1.00162892"},
        {"Smithsonian Astrophysical Observation", "SAO 209457"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.80423722),
        dec: Angle.Degrees(-39.56749634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
