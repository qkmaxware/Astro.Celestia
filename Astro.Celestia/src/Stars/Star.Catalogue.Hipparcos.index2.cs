using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_2() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212168"},
        {"Hipparcos Number", "HIP 110712"},
        {"Fundamental Katalog 5th Edition", "FK5 3789"},
        {"Geneva Identification System", "GEN# +1.00212168J"},
        {"Geneva Identification System 2", "GEN# +1.00212168A"},
        {"Smithsonian Astrophysical Observation", "SAO 258036"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.46260706),
        dec: Angle.Degrees(-75.01571925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71086"},
        {"Hipparcos Number", "HIP 40725"},
        {"Smithsonian Astrophysical Observation", "SAO 256495"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.68537750),
        dec: Angle.Degrees(-75.01470104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212168B"},
        {"Hipparcos Number", "HIP 110719"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.48437945),
        dec: Angle.Degrees(-75.01469938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36288"},
        {"Hipparcos Number", "HIP 25095"},
        {"Renson", "Renson 9360"},
        {"Smithsonian Astrophysical Observation", "SAO 256183"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.58687162),
        dec: Angle.Degrees(-75.01007313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93580"},
        {"Hipparcos Number", "HIP 52614"},
        {"Geneva Identification System", "GEN# +1.00093580"},
        {"Smithsonian Astrophysical Observation", "SAO 256754"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.38487642),
        dec: Angle.Degrees(-75.00789460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57294"},
    },
    visualMagnitude: 12.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.21434518),
        dec: Angle.Degrees(-75.00405501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88446"},
    },
    visualMagnitude: 12.33,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.86128555),
        dec: Angle.Degrees(-75.00242419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69765"},
        {"Hipparcos Number", "HIP 40108"},
        {"Geneva Identification System", "GEN# +1.00069765"},
        {"Smithsonian Astrophysical Observation", "SAO 256486"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.88820046),
        dec: Angle.Degrees(-74.99915480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88444"},
    },
    visualMagnitude: 12.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)03, 26.0800),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)59, 51.800)
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
    primaryId: "HIP 109840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210510"},
        {"Hipparcos Number", "HIP 109840"},
        {"Smithsonian Astrophysical Observation", "SAO 258016"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.69837841),
        dec: Angle.Degrees(-74.99544142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216519"},
        {"Hipparcos Number", "HIP 113247"},
        {"Smithsonian Astrophysical Observation", "SAO 258085"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.98995333),
        dec: Angle.Degrees(-74.99530649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205071"},
        {"Hipparcos Number", "HIP 106798"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.47718055),
        dec: Angle.Degrees(-74.99420153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128796"},
        {"Hipparcos Number", "HIP 72036"},
        {"Smithsonian Astrophysical Observation", "SAO 257188"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.03428920),
        dec: Angle.Degrees(-74.98804027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10608"},
        {"Hipparcos Number", "HIP 7756"},
        {"Geneva Identification System", "GEN# +1.00010608"},
        {"Smithsonian Astrophysical Observation", "SAO 255801"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.97234294),
        dec: Angle.Degrees(-74.98365096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13825"},
    },
    visualMagnitude: 11.20,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.47863457),
        dec: Angle.Degrees(-74.98168441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182377"},
        {"Hipparcos Number", "HIP 96080"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.01856562),
        dec: Angle.Degrees(-74.98162749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159869"},
        {"Hipparcos Number", "HIP 86888"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.29095402),
        dec: Angle.Degrees(-74.98024155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211511"},
        {"Hipparcos Number", "HIP 110364"},
        {"Smithsonian Astrophysical Observation", "SAO 258024"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.30071090),
        dec: Angle.Degrees(-74.96756269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151827"},
        {"Hipparcos Number", "HIP 82983"},
        {"Geneva Identification System", "GEN# +1.00151827"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.37022965),
        dec: Angle.Degrees(-74.96115925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173491"},
        {"Hipparcos Number", "HIP 92727"},
        {"Smithsonian Astrophysical Observation", "SAO 257637"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.42792182),
        dec: Angle.Degrees(-74.95822549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72844"},
        {"Hipparcos Number", "HIP 41565"},
        {"Smithsonian Astrophysical Observation", "SAO 256519"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.12849745),
        dec: Angle.Degrees(-74.95486033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210921"},
        {"Hipparcos Number", "HIP 110048"},
        {"Smithsonian Astrophysical Observation", "SAO 258019"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.35266223),
        dec: Angle.Degrees(-74.95013433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63566"},
        {"Hipparcos Number", "HIP 37523"},
        {"Smithsonian Astrophysical Observation", "SAO 256444"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.52119984),
        dec: Angle.Degrees(-74.94813773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152548"},
        {"Hipparcos Number", "HIP 83328"},
        {"Smithsonian Astrophysical Observation", "SAO 257452"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.45870128),
        dec: Angle.Degrees(-74.94125896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106001"},
        {"Hipparcos Number", "HIP 59499"},
        {"Geneva Identification System", "GEN# +1.00106001"},
        {"Smithsonian Astrophysical Observation", "SAO 256912"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.02989817),
        dec: Angle.Degrees(-74.93902102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32440"},
        {"Hipparcos Number", "HIP 22871"},
        {"Fundamental Katalog 5th Edition", "FK5 1138"},
        {"Geneva Identification System", "GEN# +1.00032440"},
        {"Smithsonian Astrophysical Observation", "SAO 256145"},
        {"Wilson Evans Batten Catalogue", "WEB 4433"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.79641541),
        dec: Angle.Degrees(-74.93700232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130081"},
        {"Hipparcos Number", "HIP 72671"},
        {"Renson", "Renson 37074"},
        {"Smithsonian Astrophysical Observation", "SAO 257204"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.87574115),
        dec: Angle.Degrees(-74.93309372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61268"},
        {"Hipparcos Number", "HIP 36527"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.71411730),
        dec: Angle.Degrees(-74.93004626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4815"},
        {"Hipparcos Number", "HIP 3781"},
        {"Fundamental Katalog 5th Edition", "FK5 31"},
        {"Geneva Identification System", "GEN# +1.00004815"},
        {"Smithsonian Astrophysical Observation", "SAO 255710"},
        {"Wilson Evans Batten Catalogue", "WEB 671"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.14632729),
        dec: Angle.Degrees(-74.92335356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33763"},
        {"Hipparcos Number", "HIP 23594"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.09475407),
        dec: Angle.Degrees(-74.92109080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139722"},
        {"Hipparcos Number", "HIP 77261"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.61387489),
        dec: Angle.Degrees(-74.91383677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72234"},
        {"Hipparcos Number", "HIP 41254"},
        {"Fundamental Katalog 5th Edition", "FK5 4756"},
        {"Geneva Identification System", "GEN# +1.00072234"},
        {"Smithsonian Astrophysical Observation", "SAO 256511"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.25127877),
        dec: Angle.Degrees(-74.91229920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1025"},
        {"Hipparcos Number", "HIP 1126"},
        {"Smithsonian Astrophysical Observation", "SAO 255647"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.51691854),
        dec: Angle.Degrees(-74.91206044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158606"},
        {"Hipparcos Number", "HIP 86331"},
        {"Smithsonian Astrophysical Observation", "SAO 257513"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.59908275),
        dec: Angle.Degrees(-74.91150782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134082"},
        {"Hipparcos Number", "HIP 74536"},
        {"Smithsonian Astrophysical Observation", "SAO 257250"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.46360207),
        dec: Angle.Degrees(-74.91146293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119900"},
        {"Hipparcos Number", "HIP 67478"},
        {"Smithsonian Astrophysical Observation", "SAO 257091"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.41823559),
        dec: Angle.Degrees(-74.90984084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157252"},
        {"Hipparcos Number", "HIP 85654"},
        {"Smithsonian Astrophysical Observation", "SAO 257505"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.57093258),
        dec: Angle.Degrees(-74.90755329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116925"},
        {"Hipparcos Number", "HIP 65832"},
        {"Smithsonian Astrophysical Observation", "SAO 257052"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.42684811),
        dec: Angle.Degrees(-74.90521489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74637"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.75207222),
        dec: Angle.Degrees(-74.90217437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222498"},
        {"Hipparcos Number", "HIP 116913"},
        {"Smithsonian Astrophysical Observation", "SAO 258172"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.47829777),
        dec: Angle.Degrees(-74.89499918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80951"},
        {"Hipparcos Number", "HIP 45581"},
        {"Geneva Identification System", "GEN# +1.00080951J"},
        {"Smithsonian Astrophysical Observation", "SAO 256599"},
        {"Wilson Evans Batten Catalogue", "WEB 8663"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.35504716),
        dec: Angle.Degrees(-74.89439024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113434"},
        {"Hipparcos Number", "HIP 63899"},
        {"Renson", "Renson 32890"},
        {"Smithsonian Astrophysical Observation", "SAO 257008"},
    },
    visualMagnitude: 9.44,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.43374047),
        dec: Angle.Degrees(-74.89153767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116244"},
        {"Hipparcos Number", "HIP 65468"},
        {"Fundamental Katalog 5th Edition", "FK5 3070"},
        {"Geneva Identification System", "GEN# +1.00116244"},
        {"Smithsonian Astrophysical Observation", "SAO 257041"},
        {"Wilson Evans Batten Catalogue", "WEB 11551"},
    },
    visualMagnitude: 5.04,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.28066834),
        dec: Angle.Degrees(-74.88749735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77049"},
        {"Hipparcos Number", "HIP 43700"},
        {"Smithsonian Astrophysical Observation", "SAO 256565"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.50089334),
        dec: Angle.Degrees(-74.88499797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102241"},
        {"Hipparcos Number", "HIP 57333"},
        {"Geneva Identification System", "GEN# +1.00102241J"},
        {"Smithsonian Astrophysical Observation", "SAO 256869"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.32795818),
        dec: Angle.Degrees(-74.87395954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63121"},
        {"Hipparcos Number", "HIP 37319"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.92562273),
        dec: Angle.Degrees(-74.87243693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5210"},
        {"Hipparcos Number", "HIP 4062"},
        {"Smithsonian Astrophysical Observation", "SAO 255714"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.00601299),
        dec: Angle.Degrees(-74.86998379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3427"},
        {"Hipparcos Number", "HIP 2820"},
        {"Smithsonian Astrophysical Observation", "SAO 255685"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.96571791),
        dec: Angle.Degrees(-74.86979208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146636"},
        {"Hipparcos Number", "HIP 80389"},
        {"Smithsonian Astrophysical Observation", "SAO 257392"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.13135741),
        dec: Angle.Degrees(-74.86789657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216326"},
        {"Hipparcos Number", "HIP 113118"},
        {"Geneva Identification System", "GEN# +1.00216326"},
        {"Smithsonian Astrophysical Observation", "SAO 258082"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.61685555),
        dec: Angle.Degrees(-74.86487255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71919"},
        {"Geneva Identification System", "GEN# -0.07401221"},
        {"Smithsonian Astrophysical Observation", "SAO 257185"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.64732441),
        dec: Angle.Degrees(-74.86363933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39196"},
        {"Henry Draper 2", "HD 39196A"},
        {"Hipparcos Number", "HIP 26900"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.66359489),
        dec: Angle.Degrees(-74.85900675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80098"},
        {"Hipparcos Number", "HIP 45169"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.06008384),
        dec: Angle.Degrees(-74.85880175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221467"},
        {"Hipparcos Number", "HIP 116252"},
        {"Smithsonian Astrophysical Observation", "SAO 258155"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.34391700),
        dec: Angle.Degrees(-74.85613119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73391"},
        {"Hipparcos Number", "HIP 41837"},
        {"Smithsonian Astrophysical Observation", "SAO 256522"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.93599972),
        dec: Angle.Degrees(-74.85501188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122862"},
        {"Hipparcos Number", "HIP 69090"},
        {"Fundamental Katalog 5th Edition", "FK5 3120"},
        {"Geneva Identification System", "GEN# +1.00122862"},
        {"Smithsonian Astrophysical Observation", "SAO 257116"},
        {"Wilson Evans Batten Catalogue", "WEB 12063"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.11544595),
        dec: Angle.Degrees(-74.85072342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -242.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 180.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85050"},
        {"Hipparcos Number", "HIP 47804"},
        {"Smithsonian Astrophysical Observation", "SAO 256655"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.18129660),
        dec: Angle.Degrees(-74.85012376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149376"},
        {"Hipparcos Number", "HIP 81750"},
        {"Smithsonian Astrophysical Observation", "SAO 257423"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.46206549),
        dec: Angle.Degrees(-74.84153662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115346"},
        {"Hipparcos Number", "HIP 64972"},
        {"Geneva Identification System", "GEN# +1.00115346"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.74656366),
        dec: Angle.Degrees(-74.84038740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -346.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143512"},
        {"Hipparcos Number", "HIP 79027"},
        {"Geneva Identification System", "GEN# +1.00143512"},
        {"Smithsonian Astrophysical Observation", "SAO 257361"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.95002151),
        dec: Angle.Degrees(-74.84015933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85671"},
        {"Hipparcos Number", "HIP 48149"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.22826606),
        dec: Angle.Degrees(-74.83682957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88309"},
        {"Hipparcos Number", "HIP 49567"},
        {"Geneva Identification System", "GEN# +1.00088309"},
        {"Smithsonian Astrophysical Observation", "SAO 256684"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.78552616),
        dec: Angle.Degrees(-74.83403226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72279"},
        {"Hipparcos Number", "HIP 41273"},
        {"Smithsonian Astrophysical Observation", "SAO 256513"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.30867040),
        dec: Angle.Degrees(-74.83089560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88387"},
        {"Hipparcos Number", "HIP 49612"},
        {"Smithsonian Astrophysical Observation", "SAO 256685"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.88721573),
        dec: Angle.Degrees(-74.83037637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151021"},
        {"Hipparcos Number", "HIP 82553"},
        {"Geneva Identification System", "GEN# +1.00151021"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.11093936),
        dec: Angle.Degrees(-74.82955292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23358"},
        {"Hipparcos Number", "HIP 16914"},
        {"Geneva Identification System", "GEN# +1.00023358"},
        {"Smithsonian Astrophysical Observation", "SAO 256006"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.42123987),
        dec: Angle.Degrees(-74.82256689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93579"},
        {"Hipparcos Number", "HIP 52613"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.38486686),
        dec: Angle.Degrees(-74.82189236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191453"},
        {"Hipparcos Number", "HIP 99959"},
        {"Geneva Identification System", "GEN# +1.00191453J"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.21455151),
        dec: Angle.Degrees(-74.82181428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214917"},
        {"Hipparcos Number", "HIP 112265"},
        {"Geneva Identification System", "GEN# +1.00214917"},
        {"Smithsonian Astrophysical Observation", "SAO 258063"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.08703116),
        dec: Angle.Degrees(-74.82058392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48819"},
        {"Hipparcos Number", "HIP 31627"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.27201047),
        dec: Angle.Degrees(-74.79617105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75590"},
        {"Hipparcos Number", "HIP 42915"},
        {"Fundamental Katalog 5th Edition", "FK5 2694"},
        {"Smithsonian Astrophysical Observation", "SAO 256550"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.17817847),
        dec: Angle.Degrees(-74.78805990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83902"},
        {"Hipparcos Number", "HIP 47166"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.17460208),
        dec: Angle.Degrees(-74.78733272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311508"},
        {"Hipparcos Number", "HIP 43598"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.19421395),
        dec: Angle.Degrees(-74.78271704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93199",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93199"},
        {"Smithsonian Astrophysical Observation", "SAO 257642"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.75543283),
        dec: Angle.Degrees(-74.78198027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179524"},
        {"Hipparcos Number", "HIP 95090"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.18534247),
        dec: Angle.Degrees(-74.77979996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104585"},
        {"Hipparcos Number", "HIP 58717"},
        {"Geneva Identification System", "GEN# +1.00104585"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.65244683),
        dec: Angle.Degrees(-74.77830365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118739"},
        {"Hipparcos Number", "HIP 66852"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.50856380),
        dec: Angle.Degrees(-74.77618022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207046"},
        {"Hipparcos Number", "HIP 107837"},
        {"Smithsonian Astrophysical Observation", "SAO 257965"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.70181468),
        dec: Angle.Degrees(-74.77491261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215133"},
        {"Hipparcos Number", "HIP 112391"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.45003290),
        dec: Angle.Degrees(-74.77394813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194778"},
        {"Hipparcos Number", "HIP 101498"},
        {"Geneva Identification System", "GEN# +1.00194778"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.52724057),
        dec: Angle.Degrees(-74.77138610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83064"},
        {"Hipparcos Number", "HIP 46670"},
        {"Geneva Identification System", "GEN# +1.00083064"},
        {"Wilson Evans Batten Catalogue", "WEB 8805"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.72987012),
        dec: Angle.Degrees(-74.76989831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184735"},
        {"Hipparcos Number", "HIP 97046"},
        {"Geneva Identification System", "GEN# +1.00184735"},
        {"Smithsonian Astrophysical Observation", "SAO 257720"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.84527354),
        dec: Angle.Degrees(-74.76909166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217917"},
        {"Hipparcos Number", "HIP 114063"},
        {"Renson", "Renson 60070"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.50536515),
        dec: Angle.Degrees(-74.76611248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188322"},
        {"Hipparcos Number", "HIP 98601"},
        {"Geneva Identification System", "GEN# +1.00188322"},
        {"Smithsonian Astrophysical Observation", "SAO 257759"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.41504344),
        dec: Angle.Degrees(-74.76381103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70942"},
        {"Geneva Identification System", "GEN# -0.07401182"},
    },
    visualMagnitude: 10.24,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.66003397),
        dec: Angle.Degrees(-74.75824312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105961"},
        {"Hipparcos Number", "HIP 59477"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.98640003),
        dec: Angle.Degrees(-74.75771283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176196"},
        {"Hipparcos Number", "HIP 93863"},
        {"Renson", "Renson 49150"},
        {"Smithsonian Astrophysical Observation", "SAO 257656"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.73382344),
        dec: Angle.Degrees(-74.75739123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189723"},
        {"Hipparcos Number", "HIP 99219"},
        {"Geneva Identification System", "GEN# +1.00189723"},
        {"Smithsonian Astrophysical Observation", "SAO 257772"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.12654209),
        dec: Angle.Degrees(-74.75729347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79106"},
        {"Hipparcos Number", "HIP 44699"},
        {"Smithsonian Astrophysical Observation", "SAO 256586"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.63107383),
        dec: Angle.Degrees(-74.75405172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95378"},
        {"Hipparcos Number", "HIP 53642"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.60873036),
        dec: Angle.Degrees(-74.75258753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43834"},
        {"Hipparcos Number", "HIP 29271"},
        {"Fundamental Katalog 5th Edition", "FK5 239"},
        {"Geneva Identification System", "GEN# +1.00043834"},
        {"Smithsonian Astrophysical Observation", "SAO 256274"},
        {"Wilson Evans Batten Catalogue", "WEB 5744"},
    },
    visualMagnitude: 5.08,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.55918047),
        dec: Angle.Degrees(-74.75252790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171676"},
        {"Hipparcos Number", "HIP 91912"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.05817355),
        dec: Angle.Degrees(-74.74153681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6757"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.74047476),
        dec: Angle.Degrees(-74.73912519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11234"},
        {"Hipparcos Number", "HIP 8273"},
        {"Geneva Identification System", "GEN# +1.00011234"},
        {"Smithsonian Astrophysical Observation", "SAO 255815"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.65643840),
        dec: Angle.Degrees(-74.73900851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311757"},
        {"Hipparcos Number", "HIP 40705"},
        {"Geneva Identification System", "GEN# +1.00311757"},
        {"Smithsonian Astrophysical Observation", "SAO 256494"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.63874056),
        dec: Angle.Degrees(-74.73789586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80950"},
        {"Hipparcos Number", "HIP 45585"},
        {"Geneva Identification System", "GEN# +1.00080950"},
        {"Smithsonian Astrophysical Observation", "SAO 256600"},
    },
    visualMagnitude: 5.86,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.36514198),
        dec: Angle.Degrees(-74.73467629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59778"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.86226244),
        dec: Angle.Degrees(-74.72995160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 170.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8652"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.87277474),
        dec: Angle.Degrees(-74.72598097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52449"},
        {"Hipparcos Number", "HIP 33072"},
        {"Geneva Identification System", "GEN# +1.00052449"},
        {"Smithsonian Astrophysical Observation", "SAO 256349"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.31898341),
        dec: Angle.Degrees(-74.72562584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 181.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135398"},
        {"Hipparcos Number", "HIP 75113"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.24018530),
        dec: Angle.Degrees(-74.72117964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15132"},
    },
    visualMagnitude: 11.29,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.77860046),
        dec: Angle.Degrees(-74.72034406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38331"},
        {"Hipparcos Number", "HIP 26352"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.16929651),
        dec: Angle.Degrees(-74.71601901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48139"},
        {"Hipparcos Number", "HIP 31289"},
        {"Geneva Identification System", "GEN# +1.00048139"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.42607208),
        dec: Angle.Degrees(-74.70044472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35666"},
        {"Hipparcos Number", "HIP 24737"},
        {"Smithsonian Astrophysical Observation", "SAO 256177"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.56502072),
        dec: Angle.Degrees(-74.69819529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24636"},
        {"Hipparcos Number", "HIP 17764"},
        {"Geneva Identification System", "GEN# +1.00024636"},
        {"Smithsonian Astrophysical Observation", "SAO 256034"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.04721333),
        dec: Angle.Degrees(-74.69417637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116579"},
        {"Hipparcos Number", "HIP 65628"},
        {"Geneva Identification System", "GEN# +1.00116579"},
        {"Smithsonian Astrophysical Observation", "SAO 257047"},
        {"Wilson Evans Batten Catalogue", "WEB 11607"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.82739654),
        dec: Angle.Degrees(-74.69172237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61314"},
        {"Hipparcos Number", "HIP 36556"},
        {"Renson", "Renson 16780"},
        {"Smithsonian Astrophysical Observation", "SAO 256419"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.80104582),
        dec: Angle.Degrees(-74.69102504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122726"},
        {"Hipparcos Number", "HIP 69002"},
        {"Renson", "Renson 35200"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.89939941),
        dec: Angle.Degrees(-74.68956052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 987"},
        {"Hipparcos Number", "HIP 1113"},
        {"Geneva Identification System", "GEN# +1.00000987"},
        {"Smithsonian Astrophysical Observation", "SAO 255646"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.47011668),
        dec: Angle.Degrees(-74.68817231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205098"},
        {"Hipparcos Number", "HIP 106806"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.48733025),
        dec: Angle.Degrees(-74.67760494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10029"},
        {"Hipparcos Number", "HIP 7343"},
        {"Geneva Identification System", "GEN# +1.00010029"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.65047602),
        dec: Angle.Degrees(-74.67429015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173896"},
        {"Hipparcos Number", "HIP 92894"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.91608414),
        dec: Angle.Degrees(-74.67358180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166973"},
        {"Hipparcos Number", "HIP 89949"},
        {"Smithsonian Astrophysical Observation", "SAO 257582"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.29007798),
        dec: Angle.Degrees(-74.67281617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180840"},
        {"Hipparcos Number", "HIP 95513"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.42477196),
        dec: Angle.Degrees(-74.67270935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20465"},
        {"Hipparcos Number", "HIP 14828"},
        {"Smithsonian Astrophysical Observation", "SAO 255966"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.86885333),
        dec: Angle.Degrees(-74.66561861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213305"},
        {"Hipparcos Number", "HIP 111353"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.39316553),
        dec: Angle.Degrees(-74.66520879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179555"},
        {"Hipparcos Number", "HIP 95086"},
        {"Smithsonian Astrophysical Observation", "SAO 257678"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.17767509),
        dec: Angle.Degrees(-74.65973792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30840"},
        {"Hipparcos Number", "HIP 21968"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.82719544),
        dec: Angle.Degrees(-74.65953316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109049"},
        {"Hipparcos Number", "HIP 61217"},
        {"Geneva Identification System", "GEN# +1.00109049"},
        {"Smithsonian Astrophysical Observation", "SAO 256956"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.17114415),
        dec: Angle.Degrees(-74.65952746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5303"},
        {"Hipparcos Number", "HIP 4157"},
        {"Geneva Identification System", "GEN# +1.00005303"},
        {"Renson", "Renson 1400"},
        {"Smithsonian Astrophysical Observation", "SAO 255716"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.28013031),
        dec: Angle.Degrees(-74.65161042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 243.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151731"},
        {"Hipparcos Number", "HIP 82922"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.18968250),
        dec: Angle.Degrees(-74.64602687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222899"},
        {"Hipparcos Number", "HIP 117165"},
        {"Smithsonian Astrophysical Observation", "SAO 258181"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.30754221),
        dec: Angle.Degrees(-74.63888932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65040"},
        {"Hipparcos Number", "HIP 38205"},
        {"Smithsonian Astrophysical Observation", "SAO 256453"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.41183232),
        dec: Angle.Degrees(-74.63747405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36532"},
        {"Hipparcos Number", "HIP 25270"},
        {"Geneva Identification System", "GEN# +1.00036532"},
        {"Smithsonian Astrophysical Observation", "SAO 256186"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.06817120),
        dec: Angle.Degrees(-74.63280206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7708"},
        {"Hipparcos Number", "HIP 5786"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.55699426),
        dec: Angle.Degrees(-74.62943334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11939"},
        {"Hipparcos Number", "HIP 8811"},
        {"Smithsonian Astrophysical Observation", "SAO 255829"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.30918579),
        dec: Angle.Degrees(-74.62700015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88246"},
        {"Hipparcos Number", "HIP 49523"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.67343935),
        dec: Angle.Degrees(-74.62357809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223968"},
        {"Hipparcos Number", "HIP 117857"},
        {"Smithsonian Astrophysical Observation", "SAO 258196"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.57988342),
        dec: Angle.Degrees(-74.62343243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31352"},
        {"Hipparcos Number", "HIP 22248"},
        {"Smithsonian Astrophysical Observation", "SAO 256132"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.83271707),
        dec: Angle.Degrees(-74.61241422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9665"},
        {"Hipparcos Number", "HIP 7098"},
        {"Geneva Identification System", "GEN# +1.00009665"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.87311605),
        dec: Angle.Degrees(-74.61138471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95097"},
        {"Hipparcos Number", "HIP 53490"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.13963418),
        dec: Angle.Degrees(-74.61031418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75134"},
        {"Hipparcos Number", "HIP 42690"},
        {"Smithsonian Astrophysical Observation", "SAO 256542"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.51751014),
        dec: Angle.Degrees(-74.60925171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100175"},
        {"Hipparcos Number", "HIP 56144"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.61890281),
        dec: Angle.Degrees(-74.60869453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218465"},
        {"Hipparcos Number", "HIP 114402"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.53275003),
        dec: Angle.Degrees(-74.60759064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155497"},
        {"Hipparcos Number", "HIP 84782"},
        {"Geneva Identification System", "GEN# +1.00155497"},
        {"Smithsonian Astrophysical Observation", "SAO 257483"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.94688447),
        dec: Angle.Degrees(-74.60567913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142191"},
        {"Hipparcos Number", "HIP 78365"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.98901498),
        dec: Angle.Degrees(-74.60505102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92177"},
        {"Hipparcos Number", "HIP 51842"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.87544254),
        dec: Angle.Degrees(-74.60028555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132656"},
        {"Henry Draper 2", "HD 132657"},
        {"Hipparcos Number", "HIP 73871"},
        {"Smithsonian Astrophysical Observation", "SAO 257235"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.46425286),
        dec: Angle.Degrees(-74.59544220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21475"},
        {"Hipparcos Number", "HIP 15641"},
        {"Geneva Identification System", "GEN# +1.00021475"},
        {"Smithsonian Astrophysical Observation", "SAO 255982"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.34577533),
        dec: Angle.Degrees(-74.59428345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22449"},
        {"Hipparcos Number", "HIP 16300"},
        {"Geneva Identification System", "GEN# +1.00022449"},
        {"Smithsonian Astrophysical Observation", "SAO 255996"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.53298650),
        dec: Angle.Degrees(-74.59423894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121027"},
        {"Hipparcos Number", "HIP 68122"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.19745512),
        dec: Angle.Degrees(-74.58377582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109833"},
        {"Hipparcos Number", "HIP 61723"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.77713793),
        dec: Angle.Degrees(-74.57397515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74461"},
        {"Hipparcos Number", "HIP 42342"},
        {"Geneva Identification System", "GEN# +1.00074461"},
        {"Smithsonian Astrophysical Observation", "SAO 256532"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.48368833),
        dec: Angle.Degrees(-74.57389396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90530"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.08585343),
        dec: Angle.Degrees(-74.57000533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117565"},
        {"Hipparcos Number", "HIP 66206"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.55061004),
        dec: Angle.Degrees(-74.56561207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85064"},
        {"Hipparcos Number", "HIP 47832"},
        {"Geneva Identification System", "GEN# +1.00085064"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.24552212),
        dec: Angle.Degrees(-74.56540403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10874"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.98709417),
        dec: Angle.Degrees(-74.56516789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 352.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 254.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13529"},
        {"Hipparcos Number", "HIP 9916"},
        {"Smithsonian Astrophysical Observation", "SAO 255851"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.90948120),
        dec: Angle.Degrees(-74.56200011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142700"},
        {"Hipparcos Number", "HIP 78596"},
        {"Geneva Identification System", "GEN# +1.00142700"},
        {"Smithsonian Astrophysical Observation", "SAO 257351"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.70669953),
        dec: Angle.Degrees(-74.56148794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51494"},
        {"Hipparcos Number", "HIP 32735"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.41910995),
        dec: Angle.Degrees(-74.55745716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194777"},
        {"Hipparcos Number", "HIP 101480"},
        {"Geneva Identification System", "GEN# +1.00194777"},
        {"Smithsonian Astrophysical Observation", "SAO 257821"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.48390113),
        dec: Angle.Degrees(-74.54446650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103306"},
        {"Hipparcos Number", "HIP 57965"},
        {"Geneva Identification System", "GEN# +1.00103306"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.34170005),
        dec: Angle.Degrees(-74.53957239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82436"},
        {"Geneva Identification System", "GEN# -0.07401569"},
        {"Smithsonian Astrophysical Observation", "SAO 257434"},
    },
    visualMagnitude: 10.17,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.70886675),
        dec: Angle.Degrees(-74.53848189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154972"},
        {"Hipparcos Number", "HIP 84510"},
        {"Fundamental Katalog 5th Edition", "FK5 3368"},
        {"Geneva Identification System", "GEN# +1.00154972"},
        {"Smithsonian Astrophysical Observation", "SAO 257478"},
        {"Wilson Evans Batten Catalogue", "WEB 14267"},
    },
    visualMagnitude: 6.24,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.14874621),
        dec: Angle.Degrees(-74.53288068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219160"},
        {"Hipparcos Number", "HIP 114813"},
        {"Geneva Identification System", "GEN# +1.00219160"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.85641356),
        dec: Angle.Degrees(-74.52553009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13247"},
    },
    visualMagnitude: 12.02,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.62941022),
        dec: Angle.Degrees(-74.52303611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69070"},
        {"Hipparcos Number", "HIP 39853"},
        {"Smithsonian Astrophysical Observation", "SAO 256478"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.12439537),
        dec: Angle.Degrees(-74.52204590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130579"},
        {"Hipparcos Number", "HIP 72925"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.56290348),
        dec: Angle.Degrees(-74.52058689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219585"},
        {"Hipparcos Number", "HIP 115072"},
        {"Geneva Identification System", "GEN# +1.00219585"},
        {"Smithsonian Astrophysical Observation", "SAO 258126"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.61251846),
        dec: Angle.Degrees(-74.51615885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44122"},
        {"Henry Draper 2", "HD 44122A"},
        {"Hipparcos Number", "HIP 29431"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.99552781),
        dec: Angle.Degrees(-74.51414405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28769"},
        {"Hipparcos Number", "HIP 20592"},
        {"Fundamental Katalog 5th Edition", "FK5 4405"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.16076507),
        dec: Angle.Degrees(-74.50910110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24450"},
        {"Hipparcos Number", "HIP 17628"},
        {"Geneva Identification System", "GEN# +1.00024450"},
        {"Smithsonian Astrophysical Observation", "SAO 256026"},
        {"Wilson Evans Batten Catalogue", "WEB 3360"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.65323221),
        dec: Angle.Degrees(-74.50814758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20073"},
        {"Hipparcos Number", "HIP 14519"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.87938341),
        dec: Angle.Degrees(-74.50749916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13950"},
        {"Hipparcos Number", "HIP 10206"},
        {"Smithsonian Astrophysical Observation", "SAO 255859"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.82328345),
        dec: Angle.Degrees(-74.50138532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208681"},
        {"Hipparcos Number", "HIP 108777"},
        {"Geneva Identification System", "GEN# +1.00208681"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.52633478),
        dec: Angle.Degrees(-74.49867335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92682"},
        {"Hipparcos Number", "HIP 52150"},
        {"Geneva Identification System", "GEN# +1.00092682"},
        {"Smithsonian Astrophysical Observation", "SAO 256742"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.81640749),
        dec: Angle.Degrees(-74.49338395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112183"},
        {"Hipparcos Number", "HIP 63154"},
        {"Smithsonian Astrophysical Observation", "SAO 256991"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.11042581),
        dec: Angle.Degrees(-74.49249899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199265"},
        {"Hipparcos Number", "HIP 103786"},
        {"Smithsonian Astrophysical Observation", "SAO 257874"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.46897995),
        dec: Angle.Degrees(-74.49241243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122672"},
        {"Hipparcos Number", "HIP 68972"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.80945601),
        dec: Angle.Degrees(-74.48993640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55025"},
        {"Hipparcos Number", "HIP 34013"},
        {"Smithsonian Astrophysical Observation", "SAO 256367"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.87254114),
        dec: Angle.Degrees(-74.48749063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12506"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.22973629),
        dec: Angle.Degrees(-74.48238658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205313"},
        {"Hipparcos Number", "HIP 106920"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.81076877),
        dec: Angle.Degrees(-74.48194411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82318",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82318"},
    },
    visualMagnitude: 12.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.29720389),
        dec: Angle.Degrees(-74.46835898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92499"},
        {"Smithsonian Astrophysical Observation", "SAO 257631"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.77190431),
        dec: Angle.Degrees(-74.46497715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97473"},
        {"Hipparcos Number", "HIP 54653"},
        {"Smithsonian Astrophysical Observation", "SAO 256807"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.81343429),
        dec: Angle.Degrees(-74.46344436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88908"},
        {"Hipparcos Number", "HIP 49913"},
        {"Geneva Identification System", "GEN# +1.00088908"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.86362033),
        dec: Angle.Degrees(-74.46051386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -272.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184997"},
        {"Hipparcos Number", "HIP 97119"},
        {"Geneva Identification System", "GEN# +1.00184997"},
        {"Smithsonian Astrophysical Observation", "SAO 257722"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.07155345),
        dec: Angle.Degrees(-74.45575911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12853"},
        {"Hipparcos Number", "HIP 9472"},
        {"Fundamental Katalog 5th Edition", "FK5 2144"},
        {"Smithsonian Astrophysical Observation", "SAO 255841"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.46801600),
        dec: Angle.Degrees(-74.44569171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198958"},
        {"Hipparcos Number", "HIP 103622"},
        {"Smithsonian Astrophysical Observation", "SAO 257870"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.92397762),
        dec: Angle.Degrees(-74.44340442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138758"},
        {"Hipparcos Number", "HIP 76767"},
        {"Geneva Identification System", "GEN# +1.00138758"},
        {"Renson", "Renson 39500"},
        {"Smithsonian Astrophysical Observation", "SAO 257306"},
    },
    visualMagnitude: 7.92,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.11354864),
        dec: Angle.Degrees(-74.44316936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123173"},
        {"Hipparcos Number", "HIP 69204"},
        {"Smithsonian Astrophysical Observation", "SAO 257118"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.52970920),
        dec: Angle.Degrees(-74.44295054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115673"},
        {"Hipparcos Number", "HIP 65166"},
        {"Geneva Identification System", "GEN# +1.00115673"},
    },
    visualMagnitude: 7.77,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.30763980),
        dec: Angle.Degrees(-74.44193577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149323"},
        {"Hipparcos Number", "HIP 81701"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.33422779),
        dec: Angle.Degrees(-74.43745050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15429"},
        {"Hipparcos Number", "HIP 11196"},
        {"Smithsonian Astrophysical Observation", "SAO 255881"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.04812061),
        dec: Angle.Degrees(-74.43634500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138264"},
        {"Hipparcos Number", "HIP 76481"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.31052029),
        dec: Angle.Degrees(-74.42836673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89591"},
        {"Hipparcos Number", "HIP 50350"},
        {"Geneva Identification System", "GEN# +1.00089591"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.21707161),
        dec: Angle.Degrees(-74.42670628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133510"},
        {"Hipparcos Number", "HIP 74262"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.65049590),
        dec: Angle.Degrees(-74.42559960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49113"},
        {"Hipparcos Number", "HIP 31801"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.73120823),
        dec: Angle.Degrees(-74.42553602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130892"},
        {"Hipparcos Number", "HIP 73075"},
        {"Geneva Identification System", "GEN# +1.00130892"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.01365826),
        dec: Angle.Degrees(-74.42309766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125943"},
        {"Hipparcos Number", "HIP 70654"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.76841757),
        dec: Angle.Degrees(-74.41730285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201502"},
        {"Hipparcos Number", "HIP 104945"},
        {"Smithsonian Astrophysical Observation", "SAO 257901"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.87470861),
        dec: Angle.Degrees(-74.41288631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68402"},
        {"Hipparcos Number", "HIP 39589"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.34942499),
        dec: Angle.Degrees(-74.41060586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154062"},
        {"Hipparcos Number", "HIP 84035"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.68867663),
        dec: Angle.Degrees(-74.40879372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2243"},
        {"Hipparcos Number", "HIP 2007"},
        {"Geneva Identification System", "GEN# +1.00002243"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.35226076),
        dec: Angle.Degrees(-74.40420108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46048",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46048"},
    },
    visualMagnitude: 12.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.86062675),
        dec: Angle.Degrees(-74.40293668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183"},
        {"Hipparcos Number", "HIP 532"},
        {"Geneva Identification System", "GEN# +1.00000183"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.61191859),
        dec: Angle.Degrees(-74.40111182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77981"},
        {"Hipparcos Number", "HIP 44192"},
        {"Smithsonian Astrophysical Observation", "SAO 256573"},
    },
    visualMagnitude: 6.85,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.02506999),
        dec: Angle.Degrees(-74.39994697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135719"},
        {"Hipparcos Number", "HIP 75243"},
        {"Smithsonian Astrophysical Observation", "SAO 257268"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.62235443),
        dec: Angle.Degrees(-74.39942482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16814"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.10364783),
        dec: Angle.Degrees(-74.39203813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126673"},
        {"Hipparcos Number", "HIP 71031"},
        {"Smithsonian Astrophysical Observation", "SAO 257168"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.91326242),
        dec: Angle.Degrees(-74.39154893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55723"},
        {"Hipparcos Number", "HIP 34280"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.59641234),
        dec: Angle.Degrees(-74.39030742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170505"},
        {"Hipparcos Number", "HIP 91321"},
        {"Geneva Identification System", "GEN# +1.00170505"},
        {"Smithsonian Astrophysical Observation", "SAO 257608"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.39953159),
        dec: Angle.Degrees(-74.37840429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167062"},
        {"Hipparcos Number", "HIP 89969"},
        {"Geneva Identification System", "GEN# +1.00167062"},
        {"Smithsonian Astrophysical Observation", "SAO 257583"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.35442166),
        dec: Angle.Degrees(-74.37430716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72921"},
        {"Hipparcos Number", "HIP 41631"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.30872656),
        dec: Angle.Degrees(-74.37201717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21392"},
        {"Smithsonian Astrophysical Observation", "SAO 256109"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.88671950),
        dec: Angle.Degrees(-74.37120437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51793"},
    },
    visualMagnitude: 10.71,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.73641825),
        dec: Angle.Degrees(-74.36244043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -201.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 194.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138171"},
        {"Hipparcos Number", "HIP 76429"},
        {"Smithsonian Astrophysical Observation", "SAO 257298"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.14439742),
        dec: Angle.Degrees(-74.35401904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186921"},
        {"Hipparcos Number", "HIP 97945"},
        {"Geneva Identification System", "GEN# +1.00186921"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.57478453),
        dec: Angle.Degrees(-74.34916302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137628"},
        {"Hipparcos Number", "HIP 76147"},
        {"Geneva Identification System", "GEN# +1.00137628"},
        {"Smithsonian Astrophysical Observation", "SAO 257291"},
        {"Wilson Evans Batten Catalogue", "WEB 12935"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.29350521),
        dec: Angle.Degrees(-74.34733411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33244"},
        {"Hipparcos Number", "HIP 23335"},
        {"Smithsonian Astrophysical Observation", "SAO 256152"},
    },
    visualMagnitude: 6.90,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.28923561),
        dec: Angle.Degrees(-74.34087077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178873"},
        {"Hipparcos Number", "HIP 94836"},
        {"Smithsonian Astrophysical Observation", "SAO 257675"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.45767237),
        dec: Angle.Degrees(-74.32477338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17255"},
        {"Hipparcos Number", "HIP 12501"},
        {"Smithsonian Astrophysical Observation", "SAO 255912"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.21413156),
        dec: Angle.Degrees(-74.32404512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19755"},
        {"Hipparcos Number", "HIP 14345"},
        {"Smithsonian Astrophysical Observation", "SAO 255951"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.24674293),
        dec: Angle.Degrees(-74.31995528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163264"},
        {"Hipparcos Number", "HIP 88405"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.77060371),
        dec: Angle.Degrees(-74.31172224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128575"},
        {"Hipparcos Number", "HIP 71929"},
        {"Geneva Identification System", "GEN# +1.00128575"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.67638708),
        dec: Angle.Degrees(-74.31151634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165457"},
        {"Hipparcos Number", "HIP 89351"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.48661546),
        dec: Angle.Degrees(-74.31038546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197243"},
        {"Hipparcos Number", "HIP 102692"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.11899676),
        dec: Angle.Degrees(-74.30810741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145869"},
        {"Hipparcos Number", "HIP 80041"},
        {"Smithsonian Astrophysical Observation", "SAO 257384"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.07144339),
        dec: Angle.Degrees(-74.30593988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5499"},
        {"Hipparcos Number", "HIP 4291"},
        {"Geneva Identification System", "GEN# +1.00005499"},
        {"Smithsonian Astrophysical Observation", "SAO 255721"},
        {"Wilson Evans Batten Catalogue", "WEB 773"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.74796307),
        dec: Angle.Degrees(-74.30263442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75428"},
        {"Hipparcos Number", "HIP 42858"},
        {"Smithsonian Astrophysical Observation", "SAO 256547"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.00398058),
        dec: Angle.Degrees(-74.30242889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224339"},
        {"Hipparcos Number", "HIP 118079"},
        {"Smithsonian Astrophysical Observation", "SAO 258202"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.28944873),
        dec: Angle.Degrees(-74.30143328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26667"},
        {"Hipparcos Number", "HIP 19269"},
        {"Geneva Identification System", "GEN# +1.00026667"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.94769887),
        dec: Angle.Degrees(-69.78768579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20335"},
        {"Hipparcos Number", "HIP 14739"},
        {"Geneva Identification System", "GEN# +1.00020335"},
        {"Smithsonian Astrophysical Observation", "SAO 255963"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.58010545),
        dec: Angle.Degrees(-74.29777198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 280.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161111"},
        {"Hipparcos Number", "HIP 87394"},
        {"Geneva Identification System", "GEN# +1.00161111"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.89894117),
        dec: Angle.Degrees(-74.29125334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61313"},
        {"Hipparcos Number", "HIP 36577"},
        {"Geneva Identification System", "GEN# +1.00061313"},
        {"Smithsonian Astrophysical Observation", "SAO 256420"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.85088934),
        dec: Angle.Degrees(-74.29060882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165260"},
        {"Hipparcos Number", "HIP 89256"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.21863944),
        dec: Angle.Degrees(-74.28657259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193607"},
        {"Hipparcos Number", "HIP 100903"},
        {"Fundamental Katalog 5th Edition", "FK5 5806"},
        {"Geneva Identification System", "GEN# +1.00193607"},
        {"Smithsonian Astrophysical Observation", "SAO 257809"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.88988132),
        dec: Angle.Degrees(-74.28503726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7573"},
        {"Hipparcos Number", "HIP 5700"},
        {"Geneva Identification System", "GEN# +1.00007573"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.33759830),
        dec: Angle.Degrees(-74.27722491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 239.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36914"},
        {"Geneva Identification System", "GEN# +1.00062153"},
        {"Smithsonian Astrophysical Observation", "SAO 256428"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.84025431),
        dec: Angle.Degrees(-74.27500789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140292"},
        {"Hipparcos Number", "HIP 77491"},
        {"Smithsonian Astrophysical Observation", "SAO 257320"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.33610181),
        dec: Angle.Degrees(-74.26757644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4309"},
        {"Hipparcos Number", "HIP 3451"},
        {"Geneva Identification System", "GEN# +1.00004309"},
        {"Smithsonian Astrophysical Observation", "SAO 255698"},
        {"Wilson Evans Batten Catalogue", "WEB 609"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.03146791),
        dec: Angle.Degrees(-74.26521969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109939"},
        {"Hipparcos Number", "HIP 61788"},
        {"Geneva Identification System", "GEN# +1.00109939"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.96802131),
        dec: Angle.Degrees(-74.26023002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96290"},
        {"Hipparcos Number", "HIP 54083"},
        {"Geneva Identification System", "GEN# +1.00096290"},
        {"Smithsonian Astrophysical Observation", "SAO 256792"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.00078239),
        dec: Angle.Degrees(-74.24801096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46508"},
        {"Hipparcos Number", "HIP 30614"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.50558970),
        dec: Angle.Degrees(-74.24095002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24512"},
        {"Hipparcos Number", "HIP 17678"},
        {"Fundamental Katalog 5th Edition", "FK5 146"},
        {"Geneva Identification System", "GEN# +1.00024512"},
        {"Smithsonian Astrophysical Observation", "SAO 256029"},
        {"Wilson Evans Batten Catalogue", "WEB 3371"},
    },
    visualMagnitude: 3.26,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.80929799),
        dec: Angle.Degrees(-74.23924251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 442"},
        {"Hipparcos Number", "HIP 698"},
        {"Smithsonian Astrophysical Observation", "SAO 255638"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.16158530),
        dec: Angle.Degrees(-74.23842588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2133"},
        {"Hipparcos Number", "HIP 1953"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.17170605),
        dec: Angle.Degrees(-74.23452493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70469"},
        {"Hipparcos Number", "HIP 40456"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.90888352),
        dec: Angle.Degrees(-74.22872854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183532"},
        {"Hipparcos Number", "HIP 96520"},
        {"Smithsonian Astrophysical Observation", "SAO 257709"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.33519162),
        dec: Angle.Degrees(-74.22834461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99786"},
        {"Hipparcos Number", "HIP 55902"},
        {"Geneva Identification System", "GEN# +1.00099786"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.88190380),
        dec: Angle.Degrees(-74.22707903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103496"},
        {"Hipparcos Number", "HIP 58086"},
        {"Geneva Identification System", "GEN# +1.00103496"},
        {"Smithsonian Astrophysical Observation", "SAO 256882"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.68660943),
        dec: Angle.Degrees(-74.22688929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132861"},
        {"Hipparcos Number", "HIP 73958"},
        {"Geneva Identification System", "GEN# +1.00132861"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.71751764),
        dec: Angle.Degrees(-74.22329715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189899"},
        {"Hipparcos Number", "HIP 99271"},
        {"Geneva Identification System", "GEN# +1.00189899"},
        {"Smithsonian Astrophysical Observation", "SAO 257777"},
        {"Wilson Evans Batten Catalogue", "WEB 17694"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.26783216),
        dec: Angle.Degrees(-74.21919910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222690"},
        {"Hipparcos Number", "HIP 117035"},
        {"Geneva Identification System", "GEN# +1.00222690"},
        {"Smithsonian Astrophysical Observation", "SAO 258174"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.88319908),
        dec: Angle.Degrees(-74.21499237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104752"},
        {"Hipparcos Number", "HIP 58810"},
        {"Geneva Identification System", "GEN# +1.00104752"},
        {"Smithsonian Astrophysical Observation", "SAO 256898"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.93557093),
        dec: Angle.Degrees(-74.21408634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97642"},
        {"Hipparcos Number", "HIP 54735"},
        {"Geneva Identification System", "GEN# +1.00097642"},
        {"Smithsonian Astrophysical Observation", "SAO 256811"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.09969994),
        dec: Angle.Degrees(-74.20942828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85827"},
        {"Hipparcos Number", "HIP 48244"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.53499262),
        dec: Angle.Degrees(-74.20401134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221375"},
        {"Hipparcos Number", "HIP 116176"},
        {"Smithsonian Astrophysical Observation", "SAO 258151"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.09447476),
        dec: Angle.Degrees(-74.20159397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203987"},
        {"Hipparcos Number", "HIP 106190"},
        {"Smithsonian Astrophysical Observation", "SAO 257929"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.63741458),
        dec: Angle.Degrees(-74.19111078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98537"},
        {"Hipparcos Number", "HIP 55237"},
        {"Geneva Identification System", "GEN# +1.00098537"},
        {"Smithsonian Astrophysical Observation", "SAO 256822"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.67336118),
        dec: Angle.Degrees(-74.19058476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116510"},
        {"Hipparcos Number", "HIP 65585"},
        {"Smithsonian Astrophysical Observation", "SAO 257045"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.69339161),
        dec: Angle.Degrees(-74.18881148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108098"},
        {"Hipparcos Number", "HIP 60651"},
        {"Geneva Identification System", "GEN# +1.00108098"},
        {"Renson", "Renson 31380"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.46922909),
        dec: Angle.Degrees(-74.18563532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65588"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.69911295),
        dec: Angle.Degrees(-74.18521159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45925"},
        {"Hipparcos Number", "HIP 30317"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.64640121),
        dec: Angle.Degrees(-74.18110968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4067"},
        {"Hipparcos Number", "HIP 3268"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.39955241),
        dec: Angle.Degrees(-74.17705889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71922"},
        {"Hipparcos Number", "HIP 41140"},
        {"Smithsonian Astrophysical Observation", "SAO 256510"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.90900796),
        dec: Angle.Degrees(-74.16617539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85896"},
    },
    visualMagnitude: 12.32,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.29759182),
        dec: Angle.Degrees(-74.16268427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57376"},
        {"Hipparcos Number", "HIP 34915"},
        {"Smithsonian Astrophysical Observation", "SAO 256385"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.36276993),
        dec: Angle.Degrees(-74.15706607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83097"},
        {"Hipparcos Number", "HIP 46719"},
        {"Geneva Identification System", "GEN# +1.00083097"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.84934364),
        dec: Angle.Degrees(-74.15551435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8113"},
        {"Hipparcos Number", "HIP 6072"},
        {"Geneva Identification System", "GEN# +1.00008113"},
        {"Smithsonian Astrophysical Observation", "SAO 255759"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.48887797),
        dec: Angle.Degrees(-74.15350000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83033"},
        {"Hipparcos Number", "HIP 46679"},
        {"Geneva Identification System", "GEN# +1.00083033"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.74964183),
        dec: Angle.Degrees(-74.15331696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145271"},
        {"Hipparcos Number", "HIP 79770"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.21102124),
        dec: Angle.Degrees(-74.14896049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106759"},
        {"Hipparcos Number", "HIP 59891"},
        {"Geneva Identification System", "GEN# +1.00106759"},
        {"Smithsonian Astrophysical Observation", "SAO 256920"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.25190770),
        dec: Angle.Degrees(-74.14367418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207392"},
        {"Hipparcos Number", "HIP 108010"},
        {"Smithsonian Astrophysical Observation", "SAO 257973"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.23493109),
        dec: Angle.Degrees(-74.14313157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58804"},
        {"Hipparcos Number", "HIP 35512"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.95549336),
        dec: Angle.Degrees(-74.13982356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123378"},
        {"Hipparcos Number", "HIP 69313"},
        {"Geneva Identification System", "GEN# +1.00123378"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.80678400),
        dec: Angle.Degrees(-74.13670556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221202"},
        {"Hipparcos Number", "HIP 116066"},
        {"Smithsonian Astrophysical Observation", "SAO 258150"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.77344599),
        dec: Angle.Degrees(-74.13456457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42230"},
        {"Hipparcos Number", "HIP 28559"},
        {"Smithsonian Astrophysical Observation", "SAO 256263"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.41954838),
        dec: Angle.Degrees(-74.13310346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187915"},
        {"Hipparcos Number", "HIP 98384"},
        {"Geneva Identification System", "GEN# +1.00187915"},
        {"Smithsonian Astrophysical Observation", "SAO 257751"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.84317955),
        dec: Angle.Degrees(-74.13026298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185996"},
        {"Hipparcos Number", "HIP 97494"},
        {"Geneva Identification System", "GEN# +1.00185996"},
        {"Smithsonian Astrophysical Observation", "SAO 257733"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.24272999),
        dec: Angle.Degrees(-74.12681514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128640"},
        {"Hipparcos Number", "HIP 71955"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.74707110),
        dec: Angle.Degrees(-74.11949295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88159"},
        {"Hipparcos Number", "HIP 49480"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.53626686),
        dec: Angle.Degrees(-74.11667279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85195"},
        {"Hipparcos Number", "HIP 47922"},
        {"Smithsonian Astrophysical Observation", "SAO 256657"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.49985914),
        dec: Angle.Degrees(-74.11572224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59503"},
        {"Hipparcos Number", "HIP 35794"},
        {"Geneva Identification System", "GEN# +1.00059503"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.74938656),
        dec: Angle.Degrees(-74.11536240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 169.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78621"},
        {"Hipparcos Number", "HIP 44480"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.94434079),
        dec: Angle.Degrees(-74.10997531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12147",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12147"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.14659654),
        dec: Angle.Degrees(-74.10955081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 137.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12440"},
        {"Hipparcos Number", "HIP 9167"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.50627894),
        dec: Angle.Degrees(-74.10752069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64409"},
        {"Hipparcos Number", "HIP 37958"},
        {"Smithsonian Astrophysical Observation", "SAO 256448"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.71083409),
        dec: Angle.Degrees(-74.09069078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14009"},
        {"Hipparcos Number", "HIP 10250"},
        {"Geneva Identification System", "GEN# +1.00014009"},
        {"Renson", "Renson 3580"},
        {"Smithsonian Astrophysical Observation", "SAO 255862"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.97067813),
        dec: Angle.Degrees(-74.08752119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209436"},
        {"Hipparcos Number", "HIP 109198"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.81152241),
        dec: Angle.Degrees(-74.08616605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311505"},
        {"Hipparcos Number", "HIP 43449"},
        {"Smithsonian Astrophysical Observation", "SAO 256559"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.74960293),
        dec: Angle.Degrees(-74.08443732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175168"},
        {"Hipparcos Number", "HIP 93432"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.42829413),
        dec: Angle.Degrees(-74.08177254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118477"},
        {"Hipparcos Number", "HIP 66683"},
        {"Geneva Identification System", "GEN# +1.00118477"},
        {"Smithsonian Astrophysical Observation", "SAO 257073"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.04854890),
        dec: Angle.Degrees(-74.07910837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125486"},
        {"Hipparcos Number", "HIP 70388"},
        {"Smithsonian Astrophysical Observation", "SAO 257147"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.02503143),
        dec: Angle.Degrees(-74.07801398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205536"},
        {"Hipparcos Number", "HIP 107022"},
        {"Geneva Identification System", "GEN# +1.00205536"},
        {"Smithsonian Astrophysical Observation", "SAO 257944"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.12528790),
        dec: Angle.Degrees(-74.07479689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 211.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74543"},
        {"Hipparcos Number", "HIP 42388"},
        {"Geneva Identification System", "GEN# +1.00074543"},
        {"Smithsonian Astrophysical Observation", "SAO 256536"},
        {"Wilson Evans Batten Catalogue", "WEB 8149"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.65309809),
        dec: Angle.Degrees(-74.07462588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 155.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35605"},
        {"Hipparcos Number", "HIP 24739"},
        {"Renson", "Renson 9180"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.57728770),
        dec: Angle.Degrees(-74.06261709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224556"},
        {"Hipparcos Number", "HIP 118245"},
        {"Smithsonian Astrophysical Observation", "SAO 258204"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.75960507),
        dec: Angle.Degrees(-74.05572354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167532"},
        {"Hipparcos Number", "HIP 90122"},
        {"Smithsonian Astrophysical Observation", "SAO 257586"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.86477468),
        dec: Angle.Degrees(-74.05531757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39657"},
        {"Hipparcos Number", "HIP 27219"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.53736120),
        dec: Angle.Degrees(-74.04919475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104856"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.61368119),
        dec: Angle.Degrees(-74.04660574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 228.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139919"},
        {"Hipparcos Number", "HIP 77319"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.78048182),
        dec: Angle.Degrees(-74.04410078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77090"},
        {"Hipparcos Number", "HIP 43747"},
        {"Smithsonian Astrophysical Observation", "SAO 256566"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.66154720),
        dec: Angle.Degrees(-74.04350856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165736"},
        {"Hipparcos Number", "HIP 89437"},
        {"Geneva Identification System", "GEN# +1.00165736"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.79993846),
        dec: Angle.Degrees(-74.03859517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101089"},
        {"Hipparcos Number", "HIP 56655"},
        {"Geneva Identification System", "GEN# +1.00101089"},
        {"Renson", "Renson 29130"},
        {"Smithsonian Astrophysical Observation", "SAO 256856"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.24941947),
        dec: Angle.Degrees(-74.03795504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90589"},
        {"Hipparcos Number", "HIP 50954"},
        {"Fundamental Katalog 5th Edition", "FK5 391"},
        {"Geneva Identification System", "GEN# +1.00090589"},
        {"Smithsonian Astrophysical Observation", "SAO 256710"},
        {"Wilson Evans Batten Catalogue", "WEB 9321"},
    },
    visualMagnitude: 3.99,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.09891874),
        dec: Angle.Degrees(-74.03154474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16530"},
        {"Hipparcos Number", "HIP 11944"},
        {"Renson", "Renson 4110"},
        {"Smithsonian Astrophysical Observation", "SAO 255906"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.52842894),
        dec: Angle.Degrees(-74.02338751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114572"},
        {"Hipparcos Number", "HIP 64531"},
        {"Geneva Identification System", "GEN# +1.00114572"},
        {"Smithsonian Astrophysical Observation", "SAO 257018"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.40088063),
        dec: Angle.Degrees(-74.02153036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92900"},
        {"Hipparcos Number", "HIP 52281"},
        {"Geneva Identification System", "GEN# +1.00092900"},
        {"Smithsonian Astrophysical Observation", "SAO 256744"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.24399440),
        dec: Angle.Degrees(-74.02038479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20486"},
        {"Hipparcos Number", "HIP 14860"},
        {"Geneva Identification System", "GEN# +1.00020486"},
        {"Smithsonian Astrophysical Observation", "SAO 255967"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.97993697),
        dec: Angle.Degrees(-74.01634256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188229"},
        {"Hipparcos Number", "HIP 98522"},
        {"Geneva Identification System", "GEN# +1.00188229"},
        {"Smithsonian Astrophysical Observation", "SAO 257758"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.23311831),
        dec: Angle.Degrees(-74.01250238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8470"},
        {"Geneva Identification System", "GEN# +6.20027196"},
    },
    visualMagnitude: 12.09,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.30237149),
        dec: Angle.Degrees(-74.01029955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135362"},
        {"Hipparcos Number", "HIP 75068"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.10545369),
        dec: Angle.Degrees(-74.00905724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24063"},
        {"Hipparcos Number", "HIP 17388"},
        {"Geneva Identification System", "GEN# +1.00024063"},
        {"Renson", "Renson 6160"},
        {"Smithsonian Astrophysical Observation", "SAO 256019"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.85271145),
        dec: Angle.Degrees(-74.00863486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104072"},
        {"Hipparcos Number", "HIP 58441"},
        {"Geneva Identification System", "GEN# +1.00104072"},
        {"Smithsonian Astrophysical Observation", "SAO 256893"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.75911603),
        dec: Angle.Degrees(-74.00849780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98640"},
        {"Hipparcos Number", "HIP 55300"},
        {"Geneva Identification System", "GEN# +1.00098640"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.87583773),
        dec: Angle.Degrees(-74.00558668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107265"},
        {"Smithsonian Astrophysical Observation", "SAO 257952"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.89679267),
        dec: Angle.Degrees(-74.00477324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163858"},
        {"Hipparcos Number", "HIP 88664"},
        {"Smithsonian Astrophysical Observation", "SAO 257559"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.52044428),
        dec: Angle.Degrees(-74.00474713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10947"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.25244181),
        dec: Angle.Degrees(-74.00009286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80129"},
        {"Hipparcos Number", "HIP 45212"},
        {"Smithsonian Astrophysical Observation", "SAO 256595"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.20918031),
        dec: Angle.Degrees(-73.99750776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140534"},
        {"Hipparcos Number", "HIP 77593"},
        {"Smithsonian Astrophysical Observation", "SAO 257324"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.62664118),
        dec: Angle.Degrees(-73.99542647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21166"},
        {"Hipparcos Number", "HIP 15438"},
        {"Geneva Identification System", "GEN# +1.00021166"},
        {"Smithsonian Astrophysical Observation", "SAO 255979"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.74060819),
        dec: Angle.Degrees(-73.98601253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182254"},
        {"Hipparcos Number", "HIP 95979"},
        {"Smithsonian Astrophysical Observation", "SAO 257696"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.75416874),
        dec: Angle.Degrees(-73.98517621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192418"},
        {"Hipparcos Number", "HIP 100362"},
        {"Smithsonian Astrophysical Observation", "SAO 257795"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.30973882),
        dec: Angle.Degrees(-73.97747700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97015"},
        {"Hipparcos Number", "HIP 54452"},
        {"Smithsonian Astrophysical Observation", "SAO 256803"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.11195971),
        dec: Angle.Degrees(-73.97581875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23128"},
        {"Hipparcos Number", "HIP 16797"},
        {"Geneva Identification System", "GEN# +1.00023128"},
        {"Smithsonian Astrophysical Observation", "SAO 256002"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.05077748),
        dec: Angle.Degrees(-73.97396998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90630"},
        {"Hipparcos Number", "HIP 50976"},
        {"Geneva Identification System", "GEN# +1.00090630"},
        {"Smithsonian Astrophysical Observation", "SAO 256711"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.18568628),
        dec: Angle.Degrees(-73.97175863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160449"},
        {"Hipparcos Number", "HIP 87087"},
        {"Smithsonian Astrophysical Observation", "SAO 257526"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.92500892),
        dec: Angle.Degrees(-73.97087107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112079"},
        {"Hipparcos Number", "HIP 63073"},
        {"Geneva Identification System", "GEN# +1.00112079"},
        {"Smithsonian Astrophysical Observation", "SAO 256989"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.85744211),
        dec: Angle.Degrees(-73.96865166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124834"},
        {"Hipparcos Number", "HIP 70042"},
        {"Fundamental Katalog 5th Edition", "FK5 3133"},
        {"Geneva Identification System", "GEN# +1.00124834"},
        {"Smithsonian Astrophysical Observation", "SAO 257140"},
    },
    visualMagnitude: 6.58,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.98911530),
        dec: Angle.Degrees(-73.96844188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311626"},
        {"Hipparcos Number", "HIP 49499"},
        {"Smithsonian Astrophysical Observation", "SAO 256682"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.60008447),
        dec: Angle.Degrees(-73.96841546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128862"},
        {"Hipparcos Number", "HIP 72055"},
        {"Geneva Identification System", "GEN# +1.00128862"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.07182688),
        dec: Angle.Degrees(-73.96814001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169570"},
        {"Hipparcos Number", "HIP 90930"},
        {"Fundamental Katalog 5th Edition", "FK5 3466"},
        {"Geneva Identification System", "GEN# +1.00169570"},
        {"Smithsonian Astrophysical Observation", "SAO 257601"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.23053953),
        dec: Angle.Degrees(-73.96538378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3689"},
        {"Hipparcos Number", "HIP 3010"},
        {"Geneva Identification System", "GEN# +1.00003689"},
        {"Smithsonian Astrophysical Observation", "SAO 255689"},
        {"Wilson Evans Batten Catalogue", "WEB 539"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.57520040),
        dec: Angle.Degrees(-73.96249617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106246"},
        {"Hipparcos Number", "HIP 59635"},
        {"Geneva Identification System", "GEN# +1.00106246"},
        {"Smithsonian Astrophysical Observation", "SAO 256914"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.45364611),
        dec: Angle.Degrees(-73.96015844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214278"},
        {"Hipparcos Number", "HIP 111889"},
        {"Smithsonian Astrophysical Observation", "SAO 258057"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.96796920),
        dec: Angle.Degrees(-73.95010289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25423"},
        {"Hipparcos Number", "HIP 18362"},
        {"Geneva Identification System", "GEN# +1.00025423"},
        {"Renson", "Renson 6470"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.89747553),
        dec: Angle.Degrees(-73.94943949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25191"},
        {"Hipparcos Number", "HIP 18184"},
        {"Smithsonian Astrophysical Observation", "SAO 256042"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.34573973),
        dec: Angle.Degrees(-73.94847032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102156"},
        {"Hipparcos Number", "HIP 57287"},
        {"Geneva Identification System", "GEN# +1.00102156"},
        {"Smithsonian Astrophysical Observation", "SAO 256867"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.19999385),
        dec: Angle.Degrees(-73.94321091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210331"},
        {"Hipparcos Number", "HIP 109702"},
        {"Smithsonian Astrophysical Observation", "SAO 258009"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.31404305),
        dec: Angle.Degrees(-73.93072013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223803"},
        {"Hipparcos Number", "HIP 117773"},
        {"Smithsonian Astrophysical Observation", "SAO 258193"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.26049613),
        dec: Angle.Degrees(-73.92963142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23760"},
        {"Hipparcos Number", "HIP 17209"},
        {"Geneva Identification System", "GEN# +1.00023760"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.29654506),
        dec: Angle.Degrees(-73.92939539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77440"},
        {"Hipparcos Number", "HIP 43930"},
        {"Smithsonian Astrophysical Observation", "SAO 256569"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.23290768),
        dec: Angle.Degrees(-73.92196735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111601"},
        {"Hipparcos Number", "HIP 62793"},
        {"Geneva Identification System", "GEN# +1.00111601"},
        {"Smithsonian Astrophysical Observation", "SAO 256985"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.00711057),
        dec: Angle.Degrees(-73.92114584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207592"},
        {"Hipparcos Number", "HIP 108113"},
        {"Smithsonian Astrophysical Observation", "SAO 257977"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.56093235),
        dec: Angle.Degrees(-73.92104490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58659"},
        {"Hipparcos Number", "HIP 35470"},
        {"Smithsonian Astrophysical Observation", "SAO 256396"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.83070746),
        dec: Angle.Degrees(-73.91945297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31251"},
        {"Hipparcos Number", "HIP 22219"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.68460432),
        dec: Angle.Degrees(-73.91853038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81739"},
        {"Hipparcos Number", "HIP 45976"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.63569833),
        dec: Angle.Degrees(-73.91719566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119388"},
        {"Hipparcos Number", "HIP 67197"},
        {"Geneva Identification System", "GEN# +1.00119388"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.56096806),
        dec: Angle.Degrees(-73.91224527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7442"},
        {"Hipparcos Number", "HIP 5623"},
        {"Fundamental Katalog 5th Edition", "FK5 2081"},
        {"Geneva Identification System", "GEN# +1.00007442"},
        {"Smithsonian Astrophysical Observation", "SAO 255751"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.04322839),
        dec: Angle.Degrees(-73.90714356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100359"},
        {"Hipparcos Number", "HIP 56246"},
        {"Geneva Identification System", "GEN# +1.00100359A"},
        {"Smithsonian Astrophysical Observation", "SAO 256849"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.94949744),
        dec: Angle.Degrees(-73.90266991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84963"},
        {"Hipparcos Number", "HIP 47783"},
        {"Geneva Identification System", "GEN# +1.00084963"},
        {"Smithsonian Astrophysical Observation", "SAO 256653"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.12891261),
        dec: Angle.Degrees(-73.90040566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85642"},
        {"Hipparcos Number", "HIP 48156"},
        {"Smithsonian Astrophysical Observation", "SAO 256661"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.23972069),
        dec: Angle.Degrees(-73.89852997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89727"},
        {"Hipparcos Number", "HIP 50430"},
        {"Smithsonian Astrophysical Observation", "SAO 256698"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.45372721),
        dec: Angle.Degrees(-73.89828686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204320"},
        {"Hipparcos Number", "HIP 106360"},
        {"Smithsonian Astrophysical Observation", "SAO 257933"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.12617126),
        dec: Angle.Degrees(-73.89290205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208374"},
        {"Hipparcos Number", "HIP 108591"},
        {"Smithsonian Astrophysical Observation", "SAO 257987"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.96794703),
        dec: Angle.Degrees(-73.89199036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79850"},
    },
    visualMagnitude: 12.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.49185797),
        dec: Angle.Degrees(-73.88236041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75813",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75813"},
    },
    visualMagnitude: 11.60,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.30609577),
        dec: Angle.Degrees(-73.88106649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -634.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154272"},
        {"Hipparcos Number", "HIP 84127"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.97719319),
        dec: Angle.Degrees(-73.87881387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112370"},
        {"Hipparcos Number", "HIP 63268"},
        {"Smithsonian Astrophysical Observation", "SAO 256994"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.46981485),
        dec: Angle.Degrees(-73.87617269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219223"},
        {"Hipparcos Number", "HIP 114857"},
        {"Smithsonian Astrophysical Observation", "SAO 258122"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.97473961),
        dec: Angle.Degrees(-73.87583326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132578"},
        {"Hipparcos Number", "HIP 73810"},
        {"Smithsonian Astrophysical Observation", "SAO 257232"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.28993796),
        dec: Angle.Degrees(-73.86958940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133639"},
        {"Hipparcos Number", "HIP 74289"},
        {"Geneva Identification System", "GEN# +1.00133639"},
        {"Smithsonian Astrophysical Observation", "SAO 257245"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.75292940),
        dec: Angle.Degrees(-73.86942196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5370"},
        {"Hipparcos Number", "HIP 4208"},
        {"Geneva Identification System", "GEN# +1.00005370"},
        {"Smithsonian Astrophysical Observation", "SAO 255717"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.42292642),
        dec: Angle.Degrees(-73.86940886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215438"},
        {"Hipparcos Number", "HIP 112538"},
        {"Smithsonian Astrophysical Observation", "SAO 258067"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.90769490),
        dec: Angle.Degrees(-73.86771873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202581"},
        {"Hipparcos Number", "HIP 105480"},
        {"Geneva Identification System", "GEN# +1.00202581"},
        {"Smithsonian Astrophysical Observation", "SAO 257913"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.46123038),
        dec: Angle.Degrees(-73.85542000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7912"},
        {"Geneva Identification System", "GEN# +6.20027191"},
    },
    visualMagnitude: 11.86,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.42527326),
        dec: Angle.Degrees(-73.84393647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30084"},
        {"Hipparcos Number", "HIP 21513"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.30462496),
        dec: Angle.Degrees(-73.84337911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64033"},
        {"Hipparcos Number", "HIP 37796"},
        {"Geneva Identification System", "GEN# +1.00064033"},
        {"Smithsonian Astrophysical Observation", "SAO 256446"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.25108304),
        dec: Angle.Degrees(-73.84208140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18050"},
        {"Hipparcos Number", "HIP 13119"},
        {"Fundamental Katalog 5th Edition", "FK5 4258"},
        {"Smithsonian Astrophysical Observation", "SAO 255926"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.18513597),
        dec: Angle.Degrees(-73.84156862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220679"},
        {"Hipparcos Number", "HIP 115739"},
        {"Fundamental Katalog 5th Edition", "FK5 6071"},
        {"Geneva Identification System", "GEN# +1.00220679"},
        {"Smithsonian Astrophysical Observation", "SAO 258143"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.72771887),
        dec: Angle.Degrees(-73.83649143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77992"},
        {"Hipparcos Number", "HIP 44219"},
        {"Geneva Identification System", "GEN# +1.00077992"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.10008392),
        dec: Angle.Degrees(-73.82780979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115401"},
        {"Hipparcos Number", "HIP 65000"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.85199206),
        dec: Angle.Degrees(-73.81756449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101415"},
        {"Hipparcos Number", "HIP 56847"},
        {"Geneva Identification System", "GEN# +1.00101415"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.82842803),
        dec: Angle.Degrees(-73.81315994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111012"},
        {"Hipparcos Number", "HIP 62429"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.91431790),
        dec: Angle.Degrees(-73.81268145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70270"},
        {"Hipparcos Number", "HIP 40386"},
        {"Smithsonian Astrophysical Observation", "SAO 256489"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.67794295),
        dec: Angle.Degrees(-73.80728056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36208"},
        {"Hipparcos Number", "HIP 25107"},
        {"Fundamental Katalog 5th Edition", "FK5 4493"},
        {"Smithsonian Astrophysical Observation", "SAO 256182"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.63472751),
        dec: Angle.Degrees(-73.80146604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182291"},
        {"Hipparcos Number", "HIP 95992"},
        {"Geneva Identification System", "GEN# +1.00182291"},
        {"Smithsonian Astrophysical Observation", "SAO 257698"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.77776781),
        dec: Angle.Degrees(-73.79905205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110720"},
        {"Hipparcos Number", "HIP 62243"},
        {"Geneva Identification System", "GEN# +1.00110720"},
        {"Smithsonian Astrophysical Observation", "SAO 256978"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.34901036),
        dec: Angle.Degrees(-73.79702135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131805"},
        {"Hipparcos Number", "HIP 73469"},
        {"Smithsonian Astrophysical Observation", "SAO 257222"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.23070943),
        dec: Angle.Degrees(-73.79414512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116041"},
        {"Hipparcos Number", "HIP 65341"},
        {"Smithsonian Astrophysical Observation", "SAO 257035"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.88370151),
        dec: Angle.Degrees(-73.79402912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200075"},
        {"Hipparcos Number", "HIP 104188"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.63932897),
        dec: Angle.Degrees(-73.79062332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95975"},
        {"Smithsonian Astrophysical Observation", "SAO 257697"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.74880428),
        dec: Angle.Degrees(-73.78792382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137254"},
        {"Hipparcos Number", "HIP 75968"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.71750587),
        dec: Angle.Degrees(-73.78676770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186338"},
        {"Hipparcos Number", "HIP 97633"},
        {"Geneva Identification System", "GEN# +1.00186338"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.64925800),
        dec: Angle.Degrees(-73.78354010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222470"},
        {"Hipparcos Number", "HIP 116887"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.39058174),
        dec: Angle.Degrees(-73.78053101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175954"},
        {"Hipparcos Number", "HIP 93739"},
        {"Smithsonian Astrophysical Observation", "SAO 257651"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.30127884),
        dec: Angle.Degrees(-73.77905328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216838"},
        {"Hipparcos Number", "HIP 113432"},
        {"Fundamental Katalog 5th Edition", "FK5 6033"},
        {"Smithsonian Astrophysical Observation", "SAO 258092"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.59531129),
        dec: Angle.Degrees(-73.77696513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161936"},
        {"Hipparcos Number", "HIP 87781"},
        {"Geneva Identification System", "GEN# +1.00161936"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.97760664),
        dec: Angle.Degrees(-73.77392437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42541"},
    },
    visualMagnitude: 11.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.08058701),
        dec: Angle.Degrees(-73.77339474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84968"},
    },
    visualMagnitude: 12.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.49535701),
        dec: Angle.Degrees(-73.77130874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11620"},
        {"Hipparcos Number", "HIP 8559"},
        {"Geneva Identification System", "GEN# +1.00011620"},
        {"Smithsonian Astrophysical Observation", "SAO 255823"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.60083256),
        dec: Angle.Degrees(-73.77040353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32385"},
        {"Hipparcos Number", "HIP 22891"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.85382779),
        dec: Angle.Degrees(-73.76213181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98848"},
        {"Hipparcos Number", "HIP 55441"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.30265106),
        dec: Angle.Degrees(-73.76205621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3880"},
        {"Hipparcos Number", "HIP 3147"},
        {"Geneva Identification System", "GEN# +1.00003880"},
        {"Smithsonian Astrophysical Observation", "SAO 255694"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.00271110),
        dec: Angle.Degrees(-73.76182146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19671"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.21201839),
        dec: Angle.Degrees(-73.75503009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12760"},
        {"Hipparcos Number", "HIP 9432"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.28392042),
        dec: Angle.Degrees(-73.75424149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98764"},
        {"Geneva Identification System", "GEN# -0.07401864"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.89725630),
        dec: Angle.Degrees(-73.75324870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199595"},
        {"Hipparcos Number", "HIP 103962"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.96390091),
        dec: Angle.Degrees(-73.75254494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28116"},
    },
    visualMagnitude: 12.01,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.13920124),
        dec: Angle.Degrees(-73.75240600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 240.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130891"},
        {"Hipparcos Number", "HIP 73050"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.93733860),
        dec: Angle.Degrees(-73.75149402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47831"},
        {"Hipparcos Number", "HIP 31229"},
        {"Fundamental Katalog 5th Edition", "FK5 4594"},
        {"Geneva Identification System", "GEN# +1.00047831"},
        {"Smithsonian Astrophysical Observation", "SAO 256314"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.25832842),
        dec: Angle.Degrees(-73.75127803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6005"},
        {"Hipparcos Number", "HIP 4622"},
        {"Geneva Identification System", "GEN# +1.00006005"},
        {"Smithsonian Astrophysical Observation", "SAO 255725"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.84233163),
        dec: Angle.Degrees(-73.74886549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83096"},
        {"Hipparcos Number", "HIP 46720"},
        {"Smithsonian Astrophysical Observation", "SAO 256633"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.85398414),
        dec: Angle.Degrees(-73.74711172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158433"},
        {"Hipparcos Number", "HIP 86194"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.21200720),
        dec: Angle.Degrees(-73.74654133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37993"},
        {"Hipparcos Number", "HIP 26169"},
        {"Fundamental Katalog 5th Edition", "FK5 2422"},
        {"Geneva Identification System", "GEN# +1.00037993"},
        {"Smithsonian Astrophysical Observation", "SAO 256208"},
        {"Wilson Evans Batten Catalogue", "WEB 5099"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.68659342),
        dec: Angle.Degrees(-73.74136684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221536"},
        {"Hipparcos Number", "HIP 116301"},
        {"Geneva Identification System", "GEN# +1.00221536"},
        {"Smithsonian Astrophysical Observation", "SAO 258156"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.46679644),
        dec: Angle.Degrees(-73.73688789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94536"},
        {"Hipparcos Number", "HIP 53152"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.12181126),
        dec: Angle.Degrees(-73.73505149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207467"},
        {"Hipparcos Number", "HIP 108041"},
        {"Geneva Identification System", "GEN# +1.00207467"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.33520805),
        dec: Angle.Degrees(-73.72526156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150995"},
        {"Hipparcos Number", "HIP 82503"},
        {"Fundamental Katalog 5th Edition", "FK5 3334"},
        {"Geneva Identification System", "GEN# +1.00150995"},
        {"Smithsonian Astrophysical Observation", "SAO 257437"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.93754742),
        dec: Angle.Degrees(-73.72257281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31876"},
        {"Hipparcos Number", "HIP 22613"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.98222587),
        dec: Angle.Degrees(-73.71833401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159099"},
        {"Hipparcos Number", "HIP 86477"},
        {"Smithsonian Astrophysical Observation", "SAO 257518"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.05131471),
        dec: Angle.Degrees(-73.71000544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53328"},
        {"Hipparcos Number", "HIP 33448"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.31462220),
        dec: Angle.Degrees(-73.70903358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9888"},
        {"Hipparcos Number", "HIP 7264"},
        {"Smithsonian Astrophysical Observation", "SAO 255793"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.39400952),
        dec: Angle.Degrees(-73.70750837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 253.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220029"},
        {"Hipparcos Number", "HIP 115354"},
        {"Smithsonian Astrophysical Observation", "SAO 258132"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.47757326),
        dec: Angle.Degrees(-73.70737395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26380",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Bubup"},
        {"Henry Draper", "HD 38283"},
        {"Hipparcos Number", "HIP 26380"},
        {"Geneva Identification System", "GEN# +1.00038283"},
        {"Smithsonian Astrophysical Observation", "SAO 256213"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.25720205),
        dec: Angle.Degrees(-73.69908204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127369"},
        {"Hipparcos Number", "HIP 71350"},
        {"Fundamental Katalog 5th Edition", "FK5 3152"},
        {"Smithsonian Astrophysical Observation", "SAO 257174"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.87288824),
        dec: Angle.Degrees(-73.69426742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78907"},
    },
    visualMagnitude: 11.20,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.61140893),
        dec: Angle.Degrees(-73.69348957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197808"},
        {"Hipparcos Number", "HIP 102961"},
        {"Geneva Identification System", "GEN# +1.00197808"},
        {"Smithsonian Astrophysical Observation", "SAO 257859"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.90613587),
        dec: Angle.Degrees(-73.69190532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120892"},
        {"Hipparcos Number", "HIP 68018"},
        {"Smithsonian Astrophysical Observation", "SAO 257100"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.93395686),
        dec: Angle.Degrees(-73.68128734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154122"},
        {"Hipparcos Number", "HIP 84042"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.71342576),
        dec: Angle.Degrees(-73.68025611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162948"},
        {"Hipparcos Number", "HIP 88248"},
        {"Smithsonian Astrophysical Observation", "SAO 257549"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.30133331),
        dec: Angle.Degrees(-73.67981235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134748"},
        {"Hipparcos Number", "HIP 74798"},
        {"Smithsonian Astrophysical Observation", "SAO 257259"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.29452964),
        dec: Angle.Degrees(-73.67875273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165259"},
        {"Hipparcos Number", "HIP 89234"},
        {"Geneva Identification System", "GEN# +1.00165259"},
        {"Smithsonian Astrophysical Observation", "SAO 257571"},
        {"Wilson Evans Batten Catalogue", "WEB 15167"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.14235762),
        dec: Angle.Degrees(-73.67177867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -262.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311500"},
        {"Hipparcos Number", "HIP 44418"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.72769505),
        dec: Angle.Degrees(-73.67036745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211852"},
        {"Hipparcos Number", "HIP 110515"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.81849343),
        dec: Angle.Degrees(-73.66708458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36791"},
        {"Hipparcos Number", "HIP 25451"},
        {"Geneva Identification System", "GEN# +1.00036791"},
        {"Smithsonian Astrophysical Observation", "SAO 256192"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.66045365),
        dec: Angle.Degrees(-73.66542107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7648"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.62675330),
        dec: Angle.Degrees(-73.65891621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109048"},
        {"Hipparcos Number", "HIP 61216"},
        {"Geneva Identification System", "GEN# +1.00109048"},
        {"Smithsonian Astrophysical Observation", "SAO 256957"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.16669307),
        dec: Angle.Degrees(-73.65639411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139173"},
        {"Hipparcos Number", "HIP 76940"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.66013745),
        dec: Angle.Degrees(-73.65535513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 635"},
        {"Hipparcos Number", "HIP 853"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.61434147),
        dec: Angle.Degrees(-73.64945333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120027"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.80472444),
        dec: Angle.Degrees(-73.64838618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207542"},
        {"Hipparcos Number", "HIP 108077"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.46035118),
        dec: Angle.Degrees(-73.64609331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15248"},
        {"Hipparcos Number", "HIP 11095"},
        {"Fundamental Katalog 5th Edition", "FK5 1067"},
        {"Geneva Identification System", "GEN# +1.00015248"},
        {"Smithsonian Astrophysical Observation", "SAO 255880"},
        {"Wilson Evans Batten Catalogue", "WEB 2336"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.71864225),
        dec: Angle.Degrees(-73.64582097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106148"},
        {"Hipparcos Number", "HIP 59586"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.29249289),
        dec: Angle.Degrees(-73.64546635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27591"},
        {"Hipparcos Number", "HIP 19782"},
        {"Geneva Identification System", "GEN# +1.00027591"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.60773490),
        dec: Angle.Degrees(-73.64511438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121315"},
        {"Hipparcos Number", "HIP 68247"},
        {"Smithsonian Astrophysical Observation", "SAO 257104"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.57785946),
        dec: Angle.Degrees(-73.63875706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119109"},
        {"Hipparcos Number", "HIP 67042"},
        {"Geneva Identification System", "GEN# +1.00119109"},
        {"Smithsonian Astrophysical Observation", "SAO 257085"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.09095975),
        dec: Angle.Degrees(-73.63681557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99441"},
        {"Hipparcos Number", "HIP 55735"},
        {"Geneva Identification System", "GEN# +1.00099441"},
        {"Smithsonian Astrophysical Observation", "SAO 256837"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.29941138),
        dec: Angle.Degrees(-73.63248324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173545"},
        {"Hipparcos Number", "HIP 92690"},
        {"Smithsonian Astrophysical Observation", "SAO 257636"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.30656298),
        dec: Angle.Degrees(-73.62961980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44533"},
        {"Hipparcos Number", "HIP 29635"},
        {"Smithsonian Astrophysical Observation", "SAO 256286"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.67475595),
        dec: Angle.Degrees(-73.62656481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196155"},
        {"Hipparcos Number", "HIP 102103"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.37016675),
        dec: Angle.Degrees(-73.62647543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86586"},
        {"Hipparcos Number", "HIP 48661"},
        {"Geneva Identification System", "GEN# +1.00086586"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.85725075),
        dec: Angle.Degrees(-73.62028962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114373"},
        {"Hipparcos Number", "HIP 64432"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.09378991),
        dec: Angle.Degrees(-73.61815654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74985"},
        {"Hipparcos Number", "HIP 42649"},
        {"Fundamental Katalog 5th Edition", "FK5 4780"},
        {"Smithsonian Astrophysical Observation", "SAO 256540"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.38539901),
        dec: Angle.Degrees(-73.61461544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142370"},
        {"Hipparcos Number", "HIP 78428"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.15987054),
        dec: Angle.Degrees(-73.60858409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173346"},
        {"Hipparcos Number", "HIP 92604"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.04159266),
        dec: Angle.Degrees(-73.60784649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81372"},
        {"Hipparcos Number", "HIP 45799"},
        {"Smithsonian Astrophysical Observation", "SAO 256607"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.07828691),
        dec: Angle.Degrees(-73.60486750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102325"},
        {"Hipparcos Number", "HIP 57409"},
        {"Geneva Identification System", "GEN# +1.00102325"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.53954017),
        dec: Angle.Degrees(-73.60396209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140931"},
        {"Hipparcos Number", "HIP 77746"},
        {"Smithsonian Astrophysical Observation", "SAO 257328"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.11137027),
        dec: Angle.Degrees(-73.60210137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43536"},
        {"Hipparcos Number", "HIP 29171"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.29766913),
        dec: Angle.Degrees(-73.59759496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33876"},
        {"Hipparcos Number", "HIP 23719"},
        {"Geneva Identification System", "GEN# +1.00033876"},
        {"Wilson Evans Batten Catalogue", "WEB 4629"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.48953169),
        dec: Angle.Degrees(-73.59444401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 149.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47067"},
        {"Hipparcos Number", "HIP 30907"},
        {"Smithsonian Astrophysical Observation", "SAO 256307"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.31199163),
        dec: Angle.Degrees(-73.58947641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35184"},
        {"Hipparcos Number", "HIP 24507"},
        {"Smithsonian Astrophysical Observation", "SAO 256172"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.85368002),
        dec: Angle.Degrees(-73.58848926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48891"},
    },
    visualMagnitude: 11.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.57806184),
        dec: Angle.Degrees(-73.58781406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218288"},
        {"Hipparcos Number", "HIP 114268"},
        {"Geneva Identification System", "GEN# +1.00218288"},
        {"Smithsonian Astrophysical Observation", "SAO 258106"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.14811916),
        dec: Angle.Degrees(-73.58611126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113709"},
        {"Hipparcos Number", "HIP 64047"},
        {"Geneva Identification System", "GEN# +1.00113709"},
        {"Smithsonian Astrophysical Observation", "SAO 257010"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.89517025),
        dec: Angle.Degrees(-73.58569820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106206"},
        {"Hipparcos Number", "HIP 59614"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.37678394),
        dec: Angle.Degrees(-73.58378112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154047"},
        {"Hipparcos Number", "HIP 84011"},
        {"Renson", "Renson 43530"},
        {"Smithsonian Astrophysical Observation", "SAO 257467"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.58925604),
        dec: Angle.Degrees(-73.58335128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85288"},
        {"Hipparcos Number", "HIP 47970"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.65702963),
        dec: Angle.Degrees(-73.58055681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84537"},
        {"Hipparcos Number", "HIP 47555"},
        {"Smithsonian Astrophysical Observation", "SAO 256646"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.43564692),
        dec: Angle.Degrees(-73.56607349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92645"},
        {"Hipparcos Number", "HIP 52149"},
        {"Geneva Identification System", "GEN# +1.00092645"},
        {"Smithsonian Astrophysical Observation", "SAO 256741"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.80114878),
        dec: Angle.Degrees(-73.55979894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105121"},
        {"Hipparcos Number", "HIP 59031"},
        {"Geneva Identification System", "GEN# +1.00105121"},
        {"Smithsonian Astrophysical Observation", "SAO 256902"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.54622414),
        dec: Angle.Degrees(-73.55677725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125292"},
        {"Hipparcos Number", "HIP 70271"},
        {"Smithsonian Astrophysical Observation", "SAO 257145"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.66096158),
        dec: Angle.Degrees(-73.55580525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54344"},
        {"Hipparcos Number", "HIP 33813"},
        {"Smithsonian Astrophysical Observation", "SAO 256364"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.29814885),
        dec: Angle.Degrees(-73.55251272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22167"},
        {"Hipparcos Number", "HIP 16162"},
        {"Geneva Identification System", "GEN# +1.00022167"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.06674294),
        dec: Angle.Degrees(-73.54975090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187337"},
        {"Hipparcos Number", "HIP 98097"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.04082819),
        dec: Angle.Degrees(-73.54536010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167961"},
        {"Hipparcos Number", "HIP 90262"},
        {"Geneva Identification System", "GEN# +1.00167961"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.25991625),
        dec: Angle.Degrees(-73.54511672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137701"},
        {"Hipparcos Number", "HIP 76154"},
        {"Smithsonian Astrophysical Observation", "SAO 257292"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.31353760),
        dec: Angle.Degrees(-73.54377966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81639"},
        {"Hipparcos Number", "HIP 45940"},
        {"Geneva Identification System", "GEN# +1.00081639"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.52557513),
        dec: Angle.Degrees(-73.54307817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191871"},
        {"Hipparcos Number", "HIP 100105"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.61572757),
        dec: Angle.Degrees(-73.54184323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39245"},
        {"Hipparcos Number", "HIP 27005"},
        {"Smithsonian Astrophysical Observation", "SAO 256230"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.92864236),
        dec: Angle.Degrees(-73.53921037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131664"},
        {"Hipparcos Number", "HIP 73408"},
        {"Geneva Identification System", "GEN# +1.00131664"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.02518257),
        dec: Angle.Degrees(-73.53540918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106782"},
        {"Hipparcos Number", "HIP 59899"},
        {"Geneva Identification System", "GEN# +1.00106782"},
        {"Smithsonian Astrophysical Observation", "SAO 256921"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.27749475),
        dec: Angle.Degrees(-73.53390281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71320"},
        {"Geneva Identification System", "GEN# -0.07201542J"},
    },
    visualMagnitude: 10.21,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.77050780),
        dec: Angle.Degrees(-73.53239559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186117"},
        {"Hipparcos Number", "HIP 97533"},
        {"Geneva Identification System", "GEN# +1.00186117"},
        {"Renson", "Renson 51320"},
        {"Smithsonian Astrophysical Observation", "SAO 257735"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.34650075),
        dec: Angle.Degrees(-73.52311214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19951"},
        {"Hipparcos Number", "HIP 14466"},
        {"Geneva Identification System", "GEN# +1.00019951"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.67376687),
        dec: Angle.Degrees(-73.52108578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98943"},
        {"Hipparcos Number", "HIP 55494"},
        {"Smithsonian Astrophysical Observation", "SAO 256831"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.48203088),
        dec: Angle.Degrees(-73.51887034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142678"},
        {"Hipparcos Number", "HIP 78553"},
        {"Geneva Identification System", "GEN# +1.00142678"},
        {"Smithsonian Astrophysical Observation", "SAO 257350"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.56691601),
        dec: Angle.Degrees(-73.51522779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5905"},
        {"Geneva Identification System", "GEN# +6.20102322"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.97149819),
        dec: Angle.Degrees(-73.51387794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88758"},
    },
    visualMagnitude: 12.42,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.79263955),
        dec: Angle.Degrees(-73.50992748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 677"},
        {"Hipparcos Number", "HIP 879"},
        {"Geneva Identification System", "GEN# +1.00000677"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.69464885),
        dec: Angle.Degrees(-73.50742387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107547"},
        {"Hipparcos Number", "HIP 60334"},
        {"Geneva Identification System", "GEN# +1.00107547"},
        {"Smithsonian Astrophysical Observation", "SAO 256934"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.56282510),
        dec: Angle.Degrees(-73.50367818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83447"},
        {"Hipparcos Number", "HIP 46940"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.49971770),
        dec: Angle.Degrees(-73.50350092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13693"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.08584175),
        dec: Angle.Degrees(-73.49741889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182687"},
        {"Hipparcos Number", "HIP 96132"},
        {"Smithsonian Astrophysical Observation", "SAO 257701"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.20157507),
        dec: Angle.Degrees(-73.49627317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95915"},
        {"Hipparcos Number", "HIP 53921"},
        {"Geneva Identification System", "GEN# +1.00095915"},
        {"Smithsonian Astrophysical Observation", "SAO 256786"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.50601977),
        dec: Angle.Degrees(-73.48789455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148600"},
        {"Hipparcos Number", "HIP 81277"},
        {"Geneva Identification System", "GEN# +1.00148600"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.00989657),
        dec: Angle.Degrees(-73.48571849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192511"},
        {"Hipparcos Number", "HIP 100389"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.38236694),
        dec: Angle.Degrees(-73.48530344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68872"},
        {"Hipparcos Number", "HIP 39802"},
        {"Smithsonian Astrophysical Observation", "SAO 256475"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.00275363),
        dec: Angle.Degrees(-73.48032766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5030"},
        {"Hipparcos Number", "HIP 3934"},
        {"Geneva Identification System", "GEN# +1.00005030"},
        {"Wilson Evans Batten Catalogue", "WEB 703"},
    },
    visualMagnitude: 11.18,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.63158529),
        dec: Angle.Degrees(-73.47848410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161794"},
        {"Hipparcos Number", "HIP 87707"},
        {"Smithsonian Astrophysical Observation", "SAO 257538"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.72900370),
        dec: Angle.Degrees(-73.47473205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66631"},
        {"Hipparcos Number", "HIP 38927"},
        {"Geneva Identification System", "GEN# +1.00066631"},
        {"Smithsonian Astrophysical Observation", "SAO 256461"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.47963728),
        dec: Angle.Degrees(-73.47305680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121723"},
        {"Hipparcos Number", "HIP 68445"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.18755939),
        dec: Angle.Degrees(-73.47256209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5045"},
        {"Hipparcos Number", "HIP 3945"},
        {"Geneva Identification System", "GEN# +1.00005045"},
        {"Wilson Evans Batten Catalogue", "WEB 704"},
    },
    visualMagnitude: 11.04,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.65994081),
        dec: Angle.Degrees(-73.47173512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19783"},
        {"Hipparcos Number", "HIP 14366"},
        {"Geneva Identification System", "GEN# +1.00019783"},
        {"Smithsonian Astrophysical Observation", "SAO 255953"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.34182692),
        dec: Angle.Degrees(-73.47172089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6509"},
        {"Hipparcos Number", "HIP 4991"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.99504809),
        dec: Angle.Degrees(-73.46245048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95999"},
        {"Hipparcos Number", "HIP 53966"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.60368638),
        dec: Angle.Degrees(-73.46111144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15656"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.39190274),
        dec: Angle.Degrees(-73.45325235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 289.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18610"},
        {"Hipparcos Number", "HIP 13534"},
        {"Geneva Identification System", "GEN# +1.00018610"},
        {"Renson", "Renson 4670"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.57507654),
        dec: Angle.Degrees(-73.45276235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138800"},
        {"Hipparcos Number", "HIP 76750"},
        {"Geneva Identification System", "GEN# +1.00138800A"},
        {"Smithsonian Astrophysical Observation", "SAO 257307"},
        {"Wilson Evans Batten Catalogue", "WEB 13025"},
    },
    visualMagnitude: 5.64,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.08899554),
        dec: Angle.Degrees(-73.44663458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76974"},
    },
    visualMagnitude: 11.33,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.75854877),
        dec: Angle.Degrees(-73.44605373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211921"},
        {"Hipparcos Number", "HIP 110545"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.91316242),
        dec: Angle.Degrees(-73.44170951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22104"},
        {"Hipparcos Number", "HIP 16115"},
        {"Geneva Identification System", "GEN# +1.00022104"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.90428222),
        dec: Angle.Degrees(-73.43987482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207700"},
        {"Hipparcos Number", "HIP 108158"},
        {"Cincinnati Publication", "Ci 20 1317"},
        {"Geneva Identification System", "GEN# +1.00207700"},
        {"Smithsonian Astrophysical Observation", "SAO 257978"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.69000586),
        dec: Angle.Degrees(-73.43741843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -438.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149458"},
        {"Hipparcos Number", "HIP 81743"},
        {"Renson", "Renson 42295"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.45166048),
        dec: Angle.Degrees(-73.43273064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213928"},
        {"Hipparcos Number", "HIP 111707"},
        {"Geneva Identification System", "GEN# +1.00213928"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.43231092),
        dec: Angle.Degrees(-73.43218406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58439"},
        {"Geneva Identification System", "GEN# -0.07201184"},
    },
    visualMagnitude: 10.69,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.74988034),
        dec: Angle.Degrees(-73.43007593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103374"},
        {"Hipparcos Number", "HIP 57999"},
        {"Geneva Identification System", "GEN# +1.00103374"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.44879941),
        dec: Angle.Degrees(-73.42720291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123723"},
        {"Hipparcos Number", "HIP 69451"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.29554647),
        dec: Angle.Degrees(-73.42624186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8191"},
        {"Hipparcos Number", "HIP 6132"},
    },
    visualMagnitude: 11.14,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)18, 42.0000),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)25, 26.000)
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
    primaryId: "HIP 83173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152339"},
        {"Hipparcos Number", "HIP 83173"},
        {"Smithsonian Astrophysical Observation", "SAO 257448"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.97798095),
        dec: Angle.Degrees(-73.42245533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167467"},
        {"Hipparcos Number", "HIP 90064"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.69290100),
        dec: Angle.Degrees(-73.41447035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210475"},
        {"Hipparcos Number", "HIP 109780"},
        {"Geneva Identification System", "GEN# +1.00210475"},
        {"Smithsonian Astrophysical Observation", "SAO 258013"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.54812341),
        dec: Angle.Degrees(-73.41023477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12097"},
        {"Hipparcos Number", "HIP 8935"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.76390170),
        dec: Angle.Degrees(-73.40950991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13447"},
        {"Hipparcos Number", "HIP 9899"},
        {"Smithsonian Astrophysical Observation", "SAO 255850"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.84857142),
        dec: Angle.Degrees(-73.40835432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122943"},
        {"Hipparcos Number", "HIP 69095"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.14960307),
        dec: Angle.Degrees(-73.40789705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71576"},
        {"Hipparcos Number", "HIP 41003"},
        {"Fundamental Katalog 5th Edition", "FK5 2653"},
        {"Geneva Identification System", "GEN# +1.00071576"},
        {"Smithsonian Astrophysical Observation", "SAO 256505"},
        {"Wilson Evans Batten Catalogue", "WEB 7949"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.51884143),
        dec: Angle.Degrees(-73.40005893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2431"},
        {"Hipparcos Number", "HIP 2148"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.79607936),
        dec: Angle.Degrees(-73.39734455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200475"},
        {"Hipparcos Number", "HIP 104391"},
        {"Geneva Identification System", "GEN# +1.00200475"},
        {"Renson", "Renson 55870"},
        {"Smithsonian Astrophysical Observation", "SAO 257889"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.22082692),
        dec: Angle.Degrees(-73.39620159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23117"},
        {"Hipparcos Number", "HIP 16812"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.09860439),
        dec: Angle.Degrees(-73.39518653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159495"},
        {"Hipparcos Number", "HIP 86664"},
        {"Fundamental Katalog 5th Edition", "FK5 3402"},
        {"Geneva Identification System", "GEN# +1.00159495"},
        {"Smithsonian Astrophysical Observation", "SAO 257521"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.61185858),
        dec: Angle.Degrees(-73.39271879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137387"},
        {"Hipparcos Number", "HIP 76013"},
        {"Fundamental Katalog 5th Edition", "FK5 567"},
        {"Geneva Identification System", "GEN# +1.00137387A"},
        {"Smithsonian Astrophysical Observation", "SAO 257289"},
        {"Wilson Evans Batten Catalogue", "WEB 12922"},
    },
    visualMagnitude: 5.40,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.87841929),
        dec: Angle.Degrees(-73.38954647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25772"},
        {"Hipparcos Number", "HIP 18590"},
        {"Geneva Identification System", "GEN# +1.00025772"},
        {"Smithsonian Astrophysical Observation", "SAO 256052"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.67157858),
        dec: Angle.Degrees(-73.38203417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209450"},
        {"Hipparcos Number", "HIP 109185"},
        {"Smithsonian Astrophysical Observation", "SAO 257997"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.77734692),
        dec: Angle.Degrees(-73.37915823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36423"},
        {"Geneva Identification System", "GEN# -0.07300453"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.43986516),
        dec: Angle.Degrees(-73.37891339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60842"},
        {"Hipparcos Number", "HIP 36415"},
        {"Smithsonian Astrophysical Observation", "SAO 256416"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.38331763),
        dec: Angle.Degrees(-73.37873533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129044"},
        {"Hipparcos Number", "HIP 72107"},
        {"Smithsonian Astrophysical Observation", "SAO 257190"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.25131945),
        dec: Angle.Degrees(-73.37557612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100081"},
        {"Hipparcos Number", "HIP 56096"},
        {"Geneva Identification System", "GEN# +1.00100081"},
        {"Smithsonian Astrophysical Observation", "SAO 256845"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.48484960),
        dec: Angle.Degrees(-73.37534914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34822"},
        {"Hipparcos Number", "HIP 24290"},
        {"Geneva Identification System", "GEN# +1.00034822"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.19198540),
        dec: Angle.Degrees(-73.37141489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125872"},
        {"Hipparcos Number", "HIP 70594"},
        {"Smithsonian Astrophysical Observation", "SAO 257153"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.59427189),
        dec: Angle.Degrees(-73.36788484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45230"},
        {"Hipparcos Number", "HIP 29999"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.71409621),
        dec: Angle.Degrees(-73.36089716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73468"},
        {"Hipparcos Number", "HIP 41907"},
        {"Geneva Identification System", "GEN# +1.00073468"},
        {"Smithsonian Astrophysical Observation", "SAO 256524"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.17448213),
        dec: Angle.Degrees(-73.35696538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101011"},
        {"Hipparcos Number", "HIP 56625"},
        {"Geneva Identification System", "GEN# +1.00101011"},
        {"Renson", "Renson 29080"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.16125790),
        dec: Angle.Degrees(-73.35363317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146007"},
        {"Hipparcos Number", "HIP 80067"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.13807620),
        dec: Angle.Degrees(-73.34797536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115214"},
        {"Hipparcos Number", "HIP 64882"},
        {"Geneva Identification System", "GEN# +1.00115214"},
        {"Renson", "Renson 33290"},
        {"Smithsonian Astrophysical Observation", "SAO 257027"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.49873950),
        dec: Angle.Degrees(-73.34442378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15067"},
        {"Hipparcos Number", "HIP 10967"},
        {"Smithsonian Astrophysical Observation", "SAO 255879"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.31324179),
        dec: Angle.Degrees(-73.34199327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7583"},
        {"Hipparcos Number", "HIP 5714"},
        {"Geneva Identification System", "GEN# +1.00007583"},
        {"Wilson Evans Batten Catalogue", "WEB 1302"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.37707739),
        dec: Angle.Degrees(-73.33619761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89143"},
        {"Hipparcos Number", "HIP 50088"},
        {"Renson", "Renson 25550"},
        {"Smithsonian Astrophysical Observation", "SAO 256692"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.39094967),
        dec: Angle.Degrees(-73.33452641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117872"},
        {"Hipparcos Number", "HIP 66351"},
        {"Geneva Identification System", "GEN# +1.00117872"},
        {"Smithsonian Astrophysical Observation", "SAO 257066"},
        {"Wilson Evans Batten Catalogue", "WEB 11719"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.99578111),
        dec: Angle.Degrees(-73.32741495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23907"},
        {"Hipparcos Number", "HIP 17327"},
        {"Smithsonian Astrophysical Observation", "SAO 256015"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.63431570),
        dec: Angle.Degrees(-73.32625360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28790"},
        {"Hipparcos Number", "HIP 20639"},
        {"Smithsonian Astrophysical Observation", "SAO 256090"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.35120982),
        dec: Angle.Degrees(-73.32599736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177805"},
        {"Hipparcos Number", "HIP 94443"},
        {"Smithsonian Astrophysical Observation", "SAO 257668"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.32053890),
        dec: Angle.Degrees(-73.31482633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125137"},
        {"Hipparcos Number", "HIP 70195"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.43133261),
        dec: Angle.Degrees(-73.31396374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14997"},
        {"Hipparcos Number", "HIP 10923"},
        {"Smithsonian Astrophysical Observation", "SAO 255876"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.16645338),
        dec: Angle.Degrees(-73.31282204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176597"},
        {"Hipparcos Number", "HIP 93988"},
        {"Smithsonian Astrophysical Observation", "SAO 257658"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.04931168),
        dec: Angle.Degrees(-73.31066897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215938"},
        {"Hipparcos Number", "HIP 112834"},
        {"Smithsonian Astrophysical Observation", "SAO 258075"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.76454916),
        dec: Angle.Degrees(-73.30747728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102089"},
        {"Hipparcos Number", "HIP 57247"},
        {"Geneva Identification System", "GEN# +1.00102089"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.08155395),
        dec: Angle.Degrees(-73.30430301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51161"},
        {"Hipparcos Number", "HIP 32674"},
        {"Geneva Identification System", "GEN# +1.00051161"},
        {"Smithsonian Astrophysical Observation", "SAO 256342"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.22517450),
        dec: Angle.Degrees(-73.30020920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104481"},
        {"Hipparcos Number", "HIP 58674"},
        {"Fundamental Katalog 5th Edition", "FK5 2964"},
        {"Geneva Identification System", "GEN# +1.00104481"},
        {"Smithsonian Astrophysical Observation", "SAO 256896"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.46205861),
        dec: Angle.Degrees(-73.29851893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202213"},
        {"Hipparcos Number", "HIP 105262"},
        {"Smithsonian Astrophysical Observation", "SAO 257908"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.82715775),
        dec: Angle.Degrees(-73.29843544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92914"},
        {"Hipparcos Number", "HIP 52291"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.27315394),
        dec: Angle.Degrees(-73.28337201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26594"},
        {"Hipparcos Number", "HIP 19108"},
        {"Geneva Identification System", "GEN# +1.00026594"},
        {"Smithsonian Astrophysical Observation", "SAO 256061"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.43425824),
        dec: Angle.Degrees(-73.28083816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220883"},
        {"Hipparcos Number", "HIP 115863"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.11310684),
        dec: Angle.Degrees(-73.27889844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115672"},
        {"Hipparcos Number", "HIP 65153"},
        {"Smithsonian Astrophysical Observation", "SAO 257031"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.27825423),
        dec: Angle.Degrees(-73.27440068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220458"},
        {"Hipparcos Number", "HIP 115605"},
        {"Geneva Identification System", "GEN# +1.00220458"},
        {"Smithsonian Astrophysical Observation", "SAO 258138"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.27460989),
        dec: Angle.Degrees(-73.27360592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131760"},
        {"Hipparcos Number", "HIP 73439"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.11574990),
        dec: Angle.Degrees(-73.27011595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120508"},
        {"Hipparcos Number", "HIP 67775"},
        {"Smithsonian Astrophysical Observation", "SAO 257098"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.27620988),
        dec: Angle.Degrees(-73.26863238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12272"},
        {"Hipparcos Number", "HIP 9064"},
        {"Geneva Identification System", "GEN# +1.00012272"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.17311806),
        dec: Angle.Degrees(-73.26447779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90949"},
        {"Hipparcos Number", "HIP 51154"},
    },
    visualMagnitude: 9.09,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.74062804),
        dec: Angle.Degrees(-73.26150471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184846"},
        {"Hipparcos Number", "HIP 97024"},
        {"Geneva Identification System", "GEN# +1.00184846"},
        {"Smithsonian Astrophysical Observation", "SAO 257721"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.78006025),
        dec: Angle.Degrees(-73.24822889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66920"},
        {"Hipparcos Number", "HIP 39041"},
        {"Geneva Identification System", "GEN# +1.00066920"},
        {"Smithsonian Astrophysical Observation", "SAO 256463"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.81573907),
        dec: Angle.Degrees(-73.24412159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214691"},
        {"Hipparcos Number", "HIP 112113"},
        {"Geneva Identification System", "GEN# +1.00214691"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.64577151),
        dec: Angle.Degrees(-73.24166397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -279.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106051"},
        {"Hipparcos Number", "HIP 59530"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.11510795),
        dec: Angle.Degrees(-73.23799740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46668"},
        {"Hipparcos Number", "HIP 30716"},
        {"Smithsonian Astrophysical Observation", "SAO 256305"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.80684436),
        dec: Angle.Degrees(-73.22841582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19275"},
    },
    visualMagnitude: 11.53,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.96566789),
        dec: Angle.Degrees(-73.22795509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 661"},
        {"Henry Draper 2", "HD 662"},
        {"Hipparcos Number", "HIP 865"},
        {"Geneva Identification System", "GEN# +1.00000661"},
        {"Smithsonian Astrophysical Observation", "SAO 255642"},
        {"Wilson Evans Batten Catalogue", "WEB 148"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.65962298),
        dec: Angle.Degrees(-73.22443438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120230"},
        {"Hipparcos Number", "HIP 67630"},
        {"Geneva Identification System", "GEN# +1.00120230"},
        {"Smithsonian Astrophysical Observation", "SAO 257092"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.86084861),
        dec: Angle.Degrees(-73.14370048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3395"},
        {"Hipparcos Number", "HIP 2812"},
        {"Geneva Identification System", "GEN# +1.00003395"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.94702095),
        dec: Angle.Degrees(-73.22202722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91496"},
        {"Hipparcos Number", "HIP 51495"},
        {"Geneva Identification System", "GEN# +1.00091496"},
        {"Smithsonian Astrophysical Observation", "SAO 256723"},
        {"Wilson Evans Batten Catalogue", "WEB 9398"},
    },
    visualMagnitude: 4.94,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.75864399),
        dec: Angle.Degrees(-73.22150890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77723"},
        {"Hipparcos Number", "HIP 44106"},
        {"Smithsonian Astrophysical Observation", "SAO 256572"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.74779957),
        dec: Angle.Degrees(-73.22044446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29751"},
        {"Hipparcos Number", "HIP 21300"},
        {"Fundamental Katalog 5th Edition", "FK5 2340"},
        {"Geneva Identification System", "GEN# +1.00029751"},
        {"Smithsonian Astrophysical Observation", "SAO 256106"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.56432650),
        dec: Angle.Degrees(-73.20891718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203572"},
        {"Hipparcos Number", "HIP 105974"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.94453679),
        dec: Angle.Degrees(-73.20291119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90658"},
    },
    visualMagnitude: 12.20,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.47381619),
        dec: Angle.Degrees(-73.20207843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129535"},
        {"Hipparcos Number", "HIP 72355"},
        {"Renson", "Renson 36930"},
        {"Smithsonian Astrophysical Observation", "SAO 257194"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.93445171),
        dec: Angle.Degrees(-73.19583556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92726"},
        {"Hipparcos Number", "HIP 52194"},
        {"Geneva Identification System", "GEN# +1.00092726"},
        {"Smithsonian Astrophysical Observation", "SAO 256743"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.94913405),
        dec: Angle.Degrees(-73.19039451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130458"},
        {"Hipparcos Number", "HIP 72833"},
        {"Geneva Identification System", "GEN# +1.00130458J"},
        {"Smithsonian Astrophysical Observation", "SAO 257206"},
        {"Wilson Evans Batten Catalogue", "WEB 12510"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.30640336),
        dec: Angle.Degrees(-73.19015457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223644"},
        {"Hipparcos Number", "HIP 117658"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.92757947),
        dec: Angle.Degrees(-73.18940219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224489"},
        {"Hipparcos Number", "HIP 118190"},
        {"Geneva Identification System", "GEN# +1.00224489"},
        {"Smithsonian Astrophysical Observation", "SAO 258203"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.60598909),
        dec: Angle.Degrees(-73.18854522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63739"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.94239835),
        dec: Angle.Degrees(-73.18685779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -285.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94512"},
        {"Hipparcos Number", "HIP 53149"},
        {"Geneva Identification System", "GEN# +1.00094512"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.10828813),
        dec: Angle.Degrees(-73.18639417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69784"},
        {"Hipparcos Number", "HIP 40179"},
        {"Smithsonian Astrophysical Observation", "SAO 256488"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.09433378),
        dec: Angle.Degrees(-73.18215518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9489"},
        {"Hipparcos Number", "HIP 7009"},
        {"Geneva Identification System", "GEN# +1.00009489"},
        {"Smithsonian Astrophysical Observation", "SAO 255786"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.56346831),
        dec: Angle.Degrees(-73.17373170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136978"},
        {"Hipparcos Number", "HIP 75814"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.30665653),
        dec: Angle.Degrees(-73.17317039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200525"},
        {"Hipparcos Number", "HIP 104440"},
        {"Geneva Identification System", "GEN# +1.00200525"},
        {"Smithsonian Astrophysical Observation", "SAO 257890"},
        {"Wilson Evans Batten Catalogue", "WEB 19009"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.33965419),
        dec: Angle.Degrees(-73.17226994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 461.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -287.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62646"},
        {"Hipparcos Number", "HIP 37189"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.60562843),
        dec: Angle.Degrees(-73.17221343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19529"},
        {"Hipparcos Number", "HIP 14200"},
        {"Smithsonian Astrophysical Observation", "SAO 255949"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.78418720),
        dec: Angle.Degrees(-73.16938054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90914"},
        {"Hipparcos Number", "HIP 51141"},
        {"Smithsonian Astrophysical Observation", "SAO 256714"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.70548746),
        dec: Angle.Degrees(-73.16799231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130943"},
        {"Hipparcos Number", "HIP 73052"},
        {"Geneva Identification System", "GEN# +1.00130943"},
        {"Smithsonian Astrophysical Observation", "SAO 257210"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.94295602),
        dec: Angle.Degrees(-73.16651011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157578"},
        {"Hipparcos Number", "HIP 85737"},
    },
    visualMagnitude: 8.71,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.80859467),
        dec: Angle.Degrees(-73.16254066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98600"},
        {"Hipparcos Number", "HIP 55284"},
        {"Smithsonian Astrophysical Observation", "SAO 256825"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.83767994),
        dec: Angle.Degrees(-73.15433016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133795"},
        {"Hipparcos Number", "HIP 74330"},
        {"Geneva Identification System", "GEN# +1.00133795"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.88380881),
        dec: Angle.Degrees(-73.15266418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156695"},
        {"Hipparcos Number", "HIP 85328"},
        {"Smithsonian Astrophysical Observation", "SAO 257496"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.56070489),
        dec: Angle.Degrees(-73.15129867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41024"},
        {"Hipparcos Number", "HIP 27991"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.80676544),
        dec: Angle.Degrees(-73.15075170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102155"},
        {"Hipparcos Number", "HIP 57296"},
        {"Geneva Identification System", "GEN# +1.00102155"},
        {"Smithsonian Astrophysical Observation", "SAO 256868"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.21852155),
        dec: Angle.Degrees(-73.15055091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219012"},
        {"Hipparcos Number", "HIP 114701"},
        {"Smithsonian Astrophysical Observation", "SAO 258118"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.52859185),
        dec: Angle.Degrees(-73.15039651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311411"},
        {"Hipparcos Number", "HIP 40502"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.03967811),
        dec: Angle.Degrees(-73.14979119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157306"},
        {"Hipparcos Number", "HIP 85609"},
        {"Geneva Identification System", "GEN# +1.00157306"},
        {"Smithsonian Astrophysical Observation", "SAO 257504"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.41136482),
        dec: Angle.Degrees(-73.14965381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142051"},
        {"Hipparcos Number", "HIP 78229"},
        {"Smithsonian Astrophysical Observation", "SAO 257340"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.61076855),
        dec: Angle.Degrees(-73.14795600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12445"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.05708257),
        dec: Angle.Degrees(-73.14765813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133702"},
        {"Hipparcos Number", "HIP 74293"},
        {"Renson", "Renson 37910"},
    },
    visualMagnitude: 9.50,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.78152381),
        dec: Angle.Degrees(-73.13837994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3719"},
        {"Hipparcos Number", "HIP 3042"},
        {"Geneva Identification System", "GEN# +1.00003719"},
        {"Renson", "Renson 1000"},
        {"Smithsonian Astrophysical Observation", "SAO 255690"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.66940318),
        dec: Angle.Degrees(-73.13763182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22002"},
        {"Hipparcos Number", "HIP 16059"},
        {"Geneva Identification System", "GEN# +1.00022002"},
        {"Smithsonian Astrophysical Observation", "SAO 255991"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.71691434),
        dec: Angle.Degrees(-73.13324784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107840"},
        {"Hipparcos Number", "HIP 60487"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.01161567),
        dec: Angle.Degrees(-73.12690733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49947"},
        {"Hipparcos Number", "HIP 32222"},
        {"Fundamental Katalog 5th Edition", "FK5 2522"},
        {"Geneva Identification System", "GEN# +1.00049947"},
        {"Smithsonian Astrophysical Observation", "SAO 256330"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.90305337),
        dec: Angle.Degrees(-73.11796953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151587"},
        {"Hipparcos Number", "HIP 82793"},
        {"Geneva Identification System", "GEN# +1.00151587"},
        {"Smithsonian Astrophysical Observation", "SAO 257441"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.79450104),
        dec: Angle.Degrees(-73.11520201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5277"},
        {"Hipparcos Number", "HIP 4126"},
        {"Geneva Identification System", "GEN# +1.00005277"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.21348087),
        dec: Angle.Degrees(-73.11489670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4027"},
        {"Hipparcos Number", "HIP 3254"},
        {"Smithsonian Astrophysical Observation", "SAO 255695"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.36135883),
        dec: Angle.Degrees(-73.11292731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66044"},
        {"Hipparcos Number", "HIP 38695"},
        {"Smithsonian Astrophysical Observation", "SAO 256458"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.83513263),
        dec: Angle.Degrees(-73.10992635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212348"},
        {"Hipparcos Number", "HIP 110779"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.64258099),
        dec: Angle.Degrees(-73.10795956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84962"},
        {"Hipparcos Number", "HIP 47800"},
        {"Smithsonian Astrophysical Observation", "SAO 256654"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.16924642),
        dec: Angle.Degrees(-73.10745646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223091"},
        {"Hipparcos Number", "HIP 117303"},
        {"Geneva Identification System", "GEN# +1.00223091"},
        {"Smithsonian Astrophysical Observation", "SAO 258184"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.77492961),
        dec: Angle.Degrees(-73.09928596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164233"},
        {"Hipparcos Number", "HIP 88785"},
        {"Geneva Identification System", "GEN# +1.00164233"},
        {"Smithsonian Astrophysical Observation", "SAO 257562"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.86665337),
        dec: Angle.Degrees(-73.09712317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181673"},
        {"Hipparcos Number", "HIP 95720"},
        {"Fundamental Katalog 5th Edition", "FK5 3551"},
        {"Smithsonian Astrophysical Observation", "SAO 257690"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.04588756),
        dec: Angle.Degrees(-73.09044264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108791"},
        {"Hipparcos Number", "HIP 61045"},
        {"Geneva Identification System", "GEN# +1.00108791"},
        {"Smithsonian Astrophysical Observation", "SAO 256950"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.67778037),
        dec: Angle.Degrees(-73.08869899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311573"},
        {"Hipparcos Number", "HIP 46682"},
        {"Geneva Identification System", "GEN# +1.00311573"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.75505161),
        dec: Angle.Degrees(-73.08836276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147320"},
        {"Hipparcos Number", "HIP 80626"},
        {"Smithsonian Astrophysical Observation", "SAO 257399"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.94719703),
        dec: Angle.Degrees(-73.08665324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32934"},
        {"Hipparcos Number", "HIP 23199"},
        {"Smithsonian Astrophysical Observation", "SAO 256147"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.89019783),
        dec: Angle.Degrees(-73.08251264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83095"},
        {"Hipparcos Number", "HIP 46741"},
        {"Fundamental Katalog 5th Edition", "FK5 362"},
        {"Geneva Identification System", "GEN# +1.00083095"},
        {"Smithsonian Astrophysical Observation", "SAO 256634"},
    },
    visualMagnitude: 5.46,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.90134667),
        dec: Angle.Degrees(-73.08091865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105196"},
        {"Hipparcos Number", "HIP 59070"},
        {"Geneva Identification System", "GEN# +1.00105196"},
        {"Smithsonian Astrophysical Observation", "SAO 256903"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.70409820),
        dec: Angle.Degrees(-73.07174383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194492"},
        {"Hipparcos Number", "HIP 101286"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.94759900),
        dec: Angle.Degrees(-73.07165967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166654"},
        {"Hipparcos Number", "HIP 89746"},
        {"Smithsonian Astrophysical Observation", "SAO 257580"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.72799296),
        dec: Angle.Degrees(-73.07124268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216463"},
        {"Hipparcos Number", "HIP 113182"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.78891924),
        dec: Angle.Degrees(-73.06951475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198299"},
        {"Hipparcos Number", "HIP 103228"},
        {"Smithsonian Astrophysical Observation", "SAO 257863"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.70253299),
        dec: Angle.Degrees(-73.06803651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54238"},
        {"Hipparcos Number", "HIP 33795"},
        {"Smithsonian Astrophysical Observation", "SAO 256361"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.26140406),
        dec: Angle.Degrees(-73.06732360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93578"},
        {"Hipparcos Number", "HIP 52631"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.44394736),
        dec: Angle.Degrees(-73.06621523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132929"},
        {"Hipparcos Number", "HIP 73954"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.70568061),
        dec: Angle.Degrees(-73.06579014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159830"},
        {"Hipparcos Number", "HIP 86783"},
        {"Geneva Identification System", "GEN# +1.00159830"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.99753366),
        dec: Angle.Degrees(-73.06476795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21090"},
        {"Hipparcos Number", "HIP 15398"},
        {"Smithsonian Astrophysical Observation", "SAO 255977"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.62961576),
        dec: Angle.Degrees(-73.06427564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106477"},
        {"Hipparcos Number", "HIP 59758"},
        {"Geneva Identification System", "GEN# +1.00106477"},
        {"Smithsonian Astrophysical Observation", "SAO 256918"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.81018830),
        dec: Angle.Degrees(-73.06108314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127384"},
        {"Hipparcos Number", "HIP 71345"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.85991329),
        dec: Angle.Degrees(-73.04756840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85128"},
    },
    visualMagnitude: 11.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.97070698),
        dec: Angle.Degrees(-72.18491569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210305"},
        {"Hipparcos Number", "HIP 109663"},
        {"Smithsonian Astrophysical Observation", "SAO 258008"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.22980261),
        dec: Angle.Degrees(-73.04725208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199577"},
        {"Hipparcos Number", "HIP 103925"},
        {"Smithsonian Astrophysical Observation", "SAO 257877"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.84917210),
        dec: Angle.Degrees(-73.04663463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145619"},
        {"Hipparcos Number", "HIP 79887"},
        {"Fundamental Katalog 5th Edition", "FK5 3285"},
        {"Geneva Identification System", "GEN# +1.00145619"},
        {"Smithsonian Astrophysical Observation", "SAO 257379"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.59807052),
        dec: Angle.Degrees(-73.04336187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116750"},
        {"Hipparcos Number", "HIP 65695"},
        {"Smithsonian Astrophysical Observation", "SAO 257051"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.03298930),
        dec: Angle.Degrees(-73.04092794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33875"},
        {"Hipparcos Number", "HIP 23737"},
        {"Fundamental Katalog 5th Edition", "FK5 2388"},
        {"Geneva Identification System", "GEN# +1.00033875"},
        {"Renson", "Renson 8630"},
        {"Smithsonian Astrophysical Observation", "SAO 256160"},
        {"Wilson Evans Batten Catalogue", "WEB 4634"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.53858384),
        dec: Angle.Degrees(-73.03782413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80866"},
        {"Hipparcos Number", "HIP 45583"},
        {"Geneva Identification System", "GEN# +1.00080866"},
        {"Smithsonian Astrophysical Observation", "SAO 256598"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.36231841),
        dec: Angle.Degrees(-73.03576938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8479"},
        {"Hipparcos Number", "HIP 6328"},
        {"Geneva Identification System", "GEN# +1.00008479"},
        {"Smithsonian Astrophysical Observation", "SAO 255767"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.31624077),
        dec: Angle.Degrees(-73.03374035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112124"},
        {"Hipparcos Number", "HIP 63106"},
        {"Fundamental Katalog 5th Edition", "FK5 5141"},
        {"Smithsonian Astrophysical Observation", "SAO 256990"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.96394761),
        dec: Angle.Degrees(-73.03256303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1893"},
        {"Hipparcos Number", "HIP 1779"},
        {"Geneva Identification System", "GEN# +1.00001893"},
        {"Smithsonian Astrophysical Observation", "SAO 255665"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.64495308),
        dec: Angle.Degrees(-73.03224385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81597"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.95100143),
        dec: Angle.Degrees(-73.02976919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202065"},
        {"Hipparcos Number", "HIP 105178"},
        {"Smithsonian Astrophysical Observation", "SAO 257905"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.60582880),
        dec: Angle.Degrees(-73.02652924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144029"},
        {"Hipparcos Number", "HIP 79222"},
        {"Geneva Identification System", "GEN# +1.00144029"},
        {"Smithsonian Astrophysical Observation", "SAO 257367"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.52388371),
        dec: Angle.Degrees(-73.02558384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147350"},
        {"Hipparcos Number", "HIP 80651"},
        {"Geneva Identification System", "GEN# +1.00147350"},
        {"Smithsonian Astrophysical Observation", "SAO 257400"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.99631922),
        dec: Angle.Degrees(-73.02179728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167586"},
        {"Hipparcos Number", "HIP 90094"},
        {"Geneva Identification System", "GEN# +1.00167586"},
        {"Smithsonian Astrophysical Observation", "SAO 257585"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.77882029),
        dec: Angle.Degrees(-73.01455748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43770"},
        {"Hipparcos Number", "HIP 29307"},
        {"Renson", "Renson 11610"},
        {"Smithsonian Astrophysical Observation", "SAO 256276"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.67798775),
        dec: Angle.Degrees(-73.01313972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203882"},
        {"Hipparcos Number", "HIP 106099"},
        {"Smithsonian Astrophysical Observation", "SAO 257927"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.38115238),
        dec: Angle.Degrees(-73.00552880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108970"},
        {"Hipparcos Number", "HIP 61181"},
        {"Geneva Identification System", "GEN# +1.00108970"},
        {"Smithsonian Astrophysical Observation", "SAO 256954"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.04122968),
        dec: Angle.Degrees(-73.00104307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124199"},
        {"Hipparcos Number", "HIP 69687"},
        {"Smithsonian Astrophysical Observation", "SAO 257130"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.97620734),
        dec: Angle.Degrees(-72.99853815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172881"},
        {"Hipparcos Number", "HIP 92394"},
        {"Geneva Identification System", "GEN# +1.00172881J"},
        {"Smithsonian Astrophysical Observation", "SAO 257630"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.43198464),
        dec: Angle.Degrees(-72.99571254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31841"},
        {"Hipparcos Number", "HIP 22622"},
        {"Geneva Identification System", "GEN# +1.00031841"},
        {"Wilson Evans Batten Catalogue", "WEB 4375"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.01324244),
        dec: Angle.Degrees(-72.99564901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119006"},
        {"Hipparcos Number", "HIP 66977"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.90971322),
        dec: Angle.Degrees(-72.98964938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108735"},
        {"Hipparcos Number", "HIP 61017"},
        {"Geneva Identification System", "GEN# +1.00108735"},
        {"Smithsonian Astrophysical Observation", "SAO 256947"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.57404000),
        dec: Angle.Degrees(-72.98521229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38175"},
        {"Hipparcos Number", "HIP 26336"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.13336587),
        dec: Angle.Degrees(-72.98222142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197636"},
        {"Hipparcos Number", "HIP 102866"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.61203465),
        dec: Angle.Degrees(-72.98115873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191937"},
        {"Hipparcos Number", "HIP 100103"},
        {"Fundamental Katalog 5th Edition", "FK5 3622"},
        {"Geneva Identification System", "GEN# +1.00191937"},
        {"Smithsonian Astrophysical Observation", "SAO 257788"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.61228010),
        dec: Angle.Degrees(-72.97924251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82256"},
        {"Geneva Identification System", "GEN# +9.86074113"},
    },
    visualMagnitude: 11.36,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.10593351),
        dec: Angle.Degrees(-72.97479207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -480.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -531.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194574"},
        {"Hipparcos Number", "HIP 101322"},
        {"Smithsonian Astrophysical Observation", "SAO 257817"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.04532408),
        dec: Angle.Degrees(-72.97170355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217991"},
        {"Hipparcos Number", "HIP 114080"},
        {"Renson", "Renson 60090"},
        {"Smithsonian Astrophysical Observation", "SAO 258101"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.57517953),
        dec: Angle.Degrees(-72.97127579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97987"},
        {"Hipparcos Number", "HIP 54912"},
        {"Renson", "Renson 28270"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.67330405),
        dec: Angle.Degrees(-72.97108312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71532"},
        {"Hipparcos Number", "HIP 41000"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.51304547),
        dec: Angle.Degrees(-72.96014636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311451"},
        {"Hipparcos Number", "HIP 43022"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.50567725),
        dec: Angle.Degrees(-72.95871148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98671"},
        {"Hipparcos Number", "HIP 55332"},
        {"Geneva Identification System", "GEN# +1.00098671"},
        {"Smithsonian Astrophysical Observation", "SAO 256827"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.96181267),
        dec: Angle.Degrees(-72.95827692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172802"},
        {"Hipparcos Number", "HIP 92348"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.31040646),
        dec: Angle.Degrees(-72.95491099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163713"},
        {"Hipparcos Number", "HIP 88547"},
        {"Smithsonian Astrophysical Observation", "SAO 257556"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.20622138),
        dec: Angle.Degrees(-72.95186105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115226"},
        {"Hipparcos Number", "HIP 64883"},
        {"Renson", "Renson 33300"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.50018623),
        dec: Angle.Degrees(-72.95022981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60958"},
        {"Hipparcos Number", "HIP 36467"},
        {"Smithsonian Astrophysical Observation", "SAO 256417"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.55904028),
        dec: Angle.Degrees(-72.94523156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17815"},
        {"Hipparcos Number", "HIP 12960"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.66858637),
        dec: Angle.Degrees(-72.93160393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56438"},
    },
    visualMagnitude: 11.46,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.56151621),
        dec: Angle.Degrees(-72.92711493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148414"},
        {"Hipparcos Number", "HIP 81155"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.61940267),
        dec: Angle.Degrees(-72.91477248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188228"},
        {"Hipparcos Number", "HIP 98495"},
        {"Fundamental Katalog 5th Edition", "FK5 748"},
        {"Geneva Identification System", "GEN# +1.00188228"},
        {"Smithsonian Astrophysical Observation", "SAO 257757"},
        {"Wilson Evans Batten Catalogue", "WEB 17392"},
    },
    visualMagnitude: 3.97,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.14747226),
        dec: Angle.Degrees(-72.91018443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173070"},
        {"Hipparcos Number", "HIP 92458"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.63059683),
        dec: Angle.Degrees(-72.90394885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225233"},
        {"Hipparcos Number", "HIP 357"},
        {"Geneva Identification System", "GEN# +1.00225233"},
        {"Smithsonian Astrophysical Observation", "SAO 255629"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.12719406),
        dec: Angle.Degrees(-72.89722070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85994"},
    },
    visualMagnitude: 11.36,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.63228386),
        dec: Angle.Degrees(-72.88218503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220718"},
        {"Hipparcos Number", "HIP 115757"},
        {"Geneva Identification System", "GEN# +1.00220718"},
        {"Smithsonian Astrophysical Observation", "SAO 258144"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.78129794),
        dec: Angle.Degrees(-72.88161471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186393"},
        {"Hipparcos Number", "HIP 97627"},
        {"Smithsonian Astrophysical Observation", "SAO 257740"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.63622876),
        dec: Angle.Degrees(-72.87538540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89599"},
        {"Hipparcos Number", "HIP 50381"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.30489292),
        dec: Angle.Degrees(-72.86823187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16941"},
        {"Hipparcos Number", "HIP 12289"},
        {"Geneva Identification System", "GEN# +1.00016941"},
        {"Smithsonian Astrophysical Observation", "SAO 255909"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.57811495),
        dec: Angle.Degrees(-72.86644570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138699"},
        {"Hipparcos Number", "HIP 76660"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.81956123),
        dec: Angle.Degrees(-72.86555836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200773"},
        {"Hipparcos Number", "HIP 104528"},
        {"Smithsonian Astrophysical Observation", "SAO 257891"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.61816860),
        dec: Angle.Degrees(-72.85390533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154208"},
        {"Hipparcos Number", "HIP 84053"},
        {"Geneva Identification System", "GEN# +1.00154208"},
        {"Smithsonian Astrophysical Observation", "SAO 257470"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.75587626),
        dec: Angle.Degrees(-72.85297487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22842"},
        {"Hipparcos Number", "HIP 16650"},
        {"Geneva Identification System", "GEN# +1.00022842"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.55499908),
        dec: Angle.Degrees(-72.84580691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174255"},
        {"Hipparcos Number", "HIP 92987"},
        {"Renson", "Renson 48810"},
        {"Smithsonian Astrophysical Observation", "SAO 257641"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.16070959),
        dec: Angle.Degrees(-72.84517614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100901"},
        {"Hipparcos Number", "HIP 56558"},
        {"Geneva Identification System", "GEN# +1.00100901"},
        {"Smithsonian Astrophysical Observation", "SAO 256853"},
        {"Wilson Evans Batten Catalogue", "WEB 10167"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.93908387),
        dec: Angle.Degrees(-72.84206090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138196"},
        {"Hipparcos Number", "HIP 76401"},
        {"Smithsonian Astrophysical Observation", "SAO 257296"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.05439094),
        dec: Angle.Degrees(-72.83930978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96623"},
        {"Hipparcos Number", "HIP 54273"},
        {"Smithsonian Astrophysical Observation", "SAO 256797"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.53947901),
        dec: Angle.Degrees(-72.83606763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37584"},
        {"Hipparcos Number", "HIP 25961"},
        {"Smithsonian Astrophysical Observation", "SAO 256200"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.07752892),
        dec: Angle.Degrees(-72.83261100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151664"},
        {"Hipparcos Number", "HIP 82823"},
        {"Geneva Identification System", "GEN# +1.00151664"},
        {"Smithsonian Astrophysical Observation", "SAO 257444"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.88891768),
        dec: Angle.Degrees(-72.83239111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136724"},
        {"Hipparcos Number", "HIP 75679"},
        {"Smithsonian Astrophysical Observation", "SAO 257279"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.92142803),
        dec: Angle.Degrees(-72.82981078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114372"},
        {"Hipparcos Number", "HIP 64424"},
        {"Smithsonian Astrophysical Observation", "SAO 257016"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.07004643),
        dec: Angle.Degrees(-72.82838911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4651"},
        {"Hipparcos Number", "HIP 3679"},
        {"Geneva Identification System", "GEN# +1.00004651"},
        {"Smithsonian Astrophysical Observation", "SAO 255707"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.77060301),
        dec: Angle.Degrees(-72.82548353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13227"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.57501760),
        dec: Angle.Degrees(-72.82274752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27415"},
        {"Hipparcos Number", "HIP 19693"},
        {"Geneva Identification System", "GEN# +1.00027415"},
        {"Smithsonian Astrophysical Observation", "SAO 256074"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.27810038),
        dec: Angle.Degrees(-72.82070688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107359"},
        {"Hipparcos Number", "HIP 60232"},
        {"Geneva Identification System", "GEN# +1.00107359"},
        {"Smithsonian Astrophysical Observation", "SAO 256929"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.26644047),
        dec: Angle.Degrees(-72.81527444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40992"},
        {"Hipparcos Number", "HIP 27983"},
        {"Geneva Identification System", "GEN# +1.00040992"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.76948388),
        dec: Angle.Degrees(-72.81459662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172266"},
        {"Hipparcos Number", "HIP 92103"},
        {"Fundamental Katalog 5th Edition", "FK5 3488"},
        {"Geneva Identification System", "GEN# +1.00172266"},
        {"Smithsonian Astrophysical Observation", "SAO 257626"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.56583128),
        dec: Angle.Degrees(-72.81337122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45847",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45847"},
    },
    visualMagnitude: 11.56,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.20824076),
        dec: Angle.Degrees(-72.81175344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37196"},
        {"Hipparcos Number", "HIP 25721"},
        {"Smithsonian Astrophysical Observation", "SAO 256198"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.39255574),
        dec: Angle.Degrees(-72.81172086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118155"},
        {"Hipparcos Number", "HIP 66490"},
        {"Geneva Identification System", "GEN# +1.00118155"},
        {"Smithsonian Astrophysical Observation", "SAO 257068"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.46052865),
        dec: Angle.Degrees(-72.80832630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191973"},
        {"Hipparcos Number", "HIP 100110"},
        {"Geneva Identification System", "GEN# +1.00191973"},
        {"Smithsonian Astrophysical Observation", "SAO 257789"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.62528915),
        dec: Angle.Degrees(-72.80815755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125485"},
        {"Hipparcos Number", "HIP 70351"},
        {"Smithsonian Astrophysical Observation", "SAO 257146"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.91328033),
        dec: Angle.Degrees(-72.80809697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207366"},
        {"Hipparcos Number", "HIP 107954"},
        {"Renson", "Renson 57710"},
        {"Smithsonian Astrophysical Observation", "SAO 257970"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.06225296),
        dec: Angle.Degrees(-72.80612072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211920"},
        {"Hipparcos Number", "HIP 110547"},
        {"Smithsonian Astrophysical Observation", "SAO 258031"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.91340537),
        dec: Angle.Degrees(-72.80406286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211931"},
        {"Hipparcos Number", "HIP 110551"},
        {"Smithsonian Astrophysical Observation", "SAO 258032"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.93118208),
        dec: Angle.Degrees(-72.80377558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141710"},
        {"Hipparcos Number", "HIP 78073"},
        {"Geneva Identification System", "GEN# +1.00141710"},
        {"Smithsonian Astrophysical Observation", "SAO 257337"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.11259860),
        dec: Angle.Degrees(-72.80091487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113476"},
        {"Hipparcos Number", "HIP 63924"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.49764628),
        dec: Angle.Degrees(-72.79965087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80020"},
        {"Hipparcos Number", "HIP 45192"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.13298364),
        dec: Angle.Degrees(-72.79659925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183140"},
        {"Hipparcos Number", "HIP 96289"},
        {"Geneva Identification System", "GEN# +1.00183140"},
        {"Smithsonian Astrophysical Observation", "SAO 257705"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.67329430),
        dec: Angle.Degrees(-72.79562675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186502"},
        {"Hipparcos Number", "HIP 97690"},
        {"Geneva Identification System", "GEN# +1.00186502"},
        {"Smithsonian Astrophysical Observation", "SAO 257743"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.80885946),
        dec: Angle.Degrees(-72.79504967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70933"},
        {"Hipparcos Number", "HIP 40728"},
        {"Smithsonian Astrophysical Observation", "SAO 256493"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.69129455),
        dec: Angle.Degrees(-72.79152943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160074"},
        {"Hipparcos Number", "HIP 86881"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.26117645),
        dec: Angle.Degrees(-72.79050920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87090"},
        {"Hipparcos Number", "HIP 48941"},
        {"Smithsonian Astrophysical Observation", "SAO 256674"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.77324630),
        dec: Angle.Degrees(-72.78907160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170487"},
        {"Hipparcos Number", "HIP 91248"},
        {"Smithsonian Astrophysical Observation", "SAO 257607"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.17633565),
        dec: Angle.Degrees(-72.78751936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48406"},
        {"Hipparcos Number", "HIP 31539"},
        {"Smithsonian Astrophysical Observation", "SAO 256319"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.03351613),
        dec: Angle.Degrees(-72.78525517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103185"},
        {"Hipparcos Number", "HIP 57892"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.10485401),
        dec: Angle.Degrees(-72.78332152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133981"},
        {"Hipparcos Number", "HIP 74421"},
        {"Geneva Identification System", "GEN# +1.00133981"},
        {"Smithsonian Astrophysical Observation", "SAO 257247"},
    },
    visualMagnitude: 6.02,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.14169683),
        dec: Angle.Degrees(-72.77056092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32035"},
        {"Hipparcos Number", "HIP 22736"},
        {"Renson", "Renson 8160"},
        {"Smithsonian Astrophysical Observation", "SAO 256140"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.36655444),
        dec: Angle.Degrees(-72.76480280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190160"},
        {"Hipparcos Number", "HIP 99338"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.43886759),
        dec: Angle.Degrees(-72.76257751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56708"},
        {"Hipparcos Number", "HIP 34715"},
        {"Smithsonian Astrophysical Observation", "SAO 256379"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.83232036),
        dec: Angle.Degrees(-72.75515336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8353"},
        {"Hipparcos Number", "HIP 6256"},
        {"Geneva Identification System", "GEN# +1.00008353"},
        {"Smithsonian Astrophysical Observation", "SAO 255765"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.05971307),
        dec: Angle.Degrees(-72.74929246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4693",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Butler's Star"},
        {"Henry Draper", "HD 6090"},
        {"Hipparcos Number", "HIP 4693"},
        {"Geneva Identification System", "GEN# +6.20054018"},
        {"Geneva Identification System 2", "GEN# +1.00006090"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.07878648),
        dec: Angle.Degrees(-72.74328235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57723"},
        {"Hipparcos Number", "HIP 35123"},
        {"Geneva Identification System", "GEN# +1.00057723"},
        {"Smithsonian Astrophysical Observation", "SAO 256387"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.92302779),
        dec: Angle.Degrees(-72.74141505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10102"},
        {"Hipparcos Number", "HIP 7434"},
        {"Geneva Identification System", "GEN# +1.00010102"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.93708760),
        dec: Angle.Degrees(-72.73945994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112747"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.49825681),
        dec: Angle.Degrees(-72.73899470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140471"},
        {"Hipparcos Number", "HIP 77511"},
        {"Smithsonian Astrophysical Observation", "SAO 257323"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.39541601),
        dec: Angle.Degrees(-72.73547782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29769"},
        {"Hipparcos Number", "HIP 21315"},
        {"Geneva Identification System", "GEN# +1.00029769"},
        {"Smithsonian Astrophysical Observation", "SAO 256107"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.64548928),
        dec: Angle.Degrees(-72.73383223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222237"},
        {"Hipparcos Number", "HIP 116745"},
        {"Cincinnati Publication", "Ci 20 1443"},
        {"Geneva Identification System", "GEN# +1.00222237"},
        {"Smithsonian Astrophysical Observation", "SAO 258167"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.90462518),
        dec: Angle.Degrees(-72.72036398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -736.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131891"},
        {"Hipparcos Number", "HIP 73486"},
        {"Geneva Identification System", "GEN# +1.00131891"},
        {"Smithsonian Astrophysical Observation", "SAO 257224"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.28182445),
        dec: Angle.Degrees(-72.71905711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109399"},
        {"Hipparcos Number", "HIP 61431"},
        {"Geneva Identification System", "GEN# +1.00109399"},
        {"Wilson Evans Batten Catalogue", "WEB 10936"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.81891364),
        dec: Angle.Degrees(-72.71689334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213742"},
        {"Hipparcos Number", "HIP 111587"},
        {"Smithsonian Astrophysical Observation", "SAO 258053"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.09042045),
        dec: Angle.Degrees(-72.71287001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39810"},
        {"Hipparcos Number", "HIP 27369"},
        {"Fundamental Katalog 5th Edition", "FK5 2441"},
        {"Geneva Identification System", "GEN# +1.00039810"},
        {"Smithsonian Astrophysical Observation", "SAO 256239"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.95061273),
        dec: Angle.Degrees(-72.70230962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35390"},
        {"Hipparcos Number", "HIP 24646"},
        {"Smithsonian Astrophysical Observation", "SAO 256174"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.32796018),
        dec: Angle.Degrees(-72.70084699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84141"},
        {"Hipparcos Number", "HIP 47347"},
        {"Smithsonian Astrophysical Observation", "SAO 256644"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.71077965),
        dec: Angle.Degrees(-72.70042745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162026"},
        {"Hipparcos Number", "HIP 87783"},
        {"Geneva Identification System", "GEN# +1.00162026"},
        {"Smithsonian Astrophysical Observation", "SAO 257540"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.97918235),
        dec: Angle.Degrees(-72.69067647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169614"},
        {"Hipparcos Number", "HIP 90903"},
        {"Geneva Identification System", "GEN# +1.00169614"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.13126874),
        dec: Angle.Degrees(-72.68869204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16348"},
        {"Hipparcos Number", "HIP 11852"},
        {"Geneva Identification System", "GEN# +1.00016348"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.24439125),
        dec: Angle.Degrees(-72.68790873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 197.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155419"},
        {"Hipparcos Number", "HIP 84660"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.60796482),
        dec: Angle.Degrees(-72.68258228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2317"},
        {"Geneva Identification System", "GEN# +6.20110033"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.38922881),
        dec: Angle.Degrees(-72.68208644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 208.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206692"},
        {"Hipparcos Number", "HIP 107616"},
        {"Geneva Identification System", "GEN# +1.00206692"},
        {"Smithsonian Astrophysical Observation", "SAO 257958"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.95675452),
        dec: Angle.Degrees(-72.68182775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89178"},
        {"Hipparcos Number", "HIP 50121"},
        {"Geneva Identification System", "GEN# +1.00089178"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.48470817),
        dec: Angle.Degrees(-72.67885343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135044"},
        {"Hipparcos Number", "HIP 74894"},
        {"Smithsonian Astrophysical Observation", "SAO 257262"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.59208891),
        dec: Angle.Degrees(-72.67880167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83254"},
        {"Hipparcos Number", "HIP 46849"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.20471401),
        dec: Angle.Degrees(-72.67611465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96570"},
        {"Hipparcos Number", "HIP 54249"},
        {"Geneva Identification System", "GEN# +1.00096570"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.46890923),
        dec: Angle.Degrees(-72.67239251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16408"},
        {"Hipparcos Number", "HIP 11892"},
        {"Geneva Identification System", "GEN# +1.00016408"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.34827095),
        dec: Angle.Degrees(-72.67191692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161317"},
        {"Hipparcos Number", "HIP 87421"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.97721471),
        dec: Angle.Degrees(-72.66814839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154506"},
        {"Hipparcos Number", "HIP 84201"},
        {"Smithsonian Astrophysical Observation", "SAO 257473"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.17816779),
        dec: Angle.Degrees(-72.66383229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220998"},
        {"Hipparcos Number", "HIP 115933"},
        {"Smithsonian Astrophysical Observation", "SAO 258146"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.33244223),
        dec: Angle.Degrees(-72.66325939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39337"},
        {"Hipparcos Number", "HIP 27099"},
        {"Smithsonian Astrophysical Observation", "SAO 256234"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.19098407),
        dec: Angle.Degrees(-72.66227588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146163"},
        {"Hipparcos Number", "HIP 80116"},
        {"Smithsonian Astrophysical Observation", "SAO 257387"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.30467313),
        dec: Angle.Degrees(-72.65348930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192905"},
        {"Hipparcos Number", "HIP 100549"},
        {"Geneva Identification System", "GEN# +1.00192905"},
        {"Smithsonian Astrophysical Observation", "SAO 257798"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.82559335),
        dec: Angle.Degrees(-72.65182673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179392"},
        {"Hipparcos Number", "HIP 94943"},
        {"Geneva Identification System", "GEN# +1.00179392"},
        {"Smithsonian Astrophysical Observation", "SAO 257676"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.79542444),
        dec: Angle.Degrees(-72.64966024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130637"},
        {"Hipparcos Number", "HIP 72898"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.47845966),
        dec: Angle.Degrees(-72.64814827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53027"},
        {"Hipparcos Number", "HIP 33374"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.12133965),
        dec: Angle.Degrees(-72.64613082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33283"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.84966747),
        dec: Angle.Degrees(-72.64221127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 223.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121777"},
        {"Hipparcos Number", "HIP 68457"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.22343987),
        dec: Angle.Degrees(-72.63993047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28939"},
        {"Hipparcos Number", "HIP 20766"},
        {"Smithsonian Astrophysical Observation", "SAO 256096"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.74065853),
        dec: Angle.Degrees(-72.63383435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5291"},
        {"Hipparcos Number", "HIP 4153"},
        {"Geneva Identification System", "GEN# +1.00005291"},
        {"Wilson Evans Batten Catalogue", "WEB 745"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.27035997),
        dec: Angle.Degrees(-72.63336876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112843"},
        {"Hipparcos Number", "HIP 63539"},
        {"Geneva Identification System", "GEN# +1.00112843"},
        {"Wilson Evans Batten Catalogue", "WEB 11242"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.30777068),
        dec: Angle.Degrees(-72.62984172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141396"},
        {"Hipparcos Number", "HIP 77918"},
        {"Smithsonian Astrophysical Observation", "SAO 257333"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.68741535),
        dec: Angle.Degrees(-72.62908000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179866"},
        {"Hipparcos Number", "HIP 95100"},
        {"Geneva Identification System", "GEN# +1.00179866"},
        {"Smithsonian Astrophysical Observation", "SAO 257679"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.20612618),
        dec: Angle.Degrees(-72.62864338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12432"},
        {"Hipparcos Number", "HIP 9183"},
        {"Smithsonian Astrophysical Observation", "SAO 255837"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.56135965),
        dec: Angle.Degrees(-72.62749403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222084"},
        {"Hipparcos Number", "HIP 116647"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.58196477),
        dec: Angle.Degrees(-72.62440395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125724"},
        {"Hipparcos Number", "HIP 70503"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.33212492),
        dec: Angle.Degrees(-72.62074334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101545"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.68706642),
        dec: Angle.Degrees(-72.61533937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106676"},
        {"Hipparcos Number", "HIP 59851"},
        {"Geneva Identification System", "GEN# +1.00106676"},
        {"Smithsonian Astrophysical Observation", "SAO 256919"},
    },
    visualMagnitude: 6.21,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.09947877),
        dec: Angle.Degrees(-72.61445993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24035"},
        {"Hipparcos Number", "HIP 17402"},
        {"Geneva Identification System", "GEN# +1.00024035"},
        {"Smithsonian Astrophysical Observation", "SAO 256020"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.92757865),
        dec: Angle.Degrees(-72.60919068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152827"},
        {"Hipparcos Number", "HIP 83377"},
        {"Smithsonian Astrophysical Observation", "SAO 257456"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.61251519),
        dec: Angle.Degrees(-72.60905296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63295"},
        {"Hipparcos Number", "HIP 37504"},
        {"Fundamental Katalog 5th Edition", "FK5 297"},
        {"Geneva Identification System", "GEN# +1.00063295J"},
        {"Smithsonian Astrophysical Observation", "SAO 256438"},
        {"Wilson Evans Batten Catalogue", "WEB 7417"},
    },
    visualMagnitude: 3.93,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.45498347),
        dec: Angle.Degrees(-72.60613528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224879"},
        {"Hipparcos Number", "HIP 117"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.38040810),
        dec: Angle.Degrees(-72.60590348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107947"},
        {"Hipparcos Number", "HIP 60561"},
        {"Geneva Identification System", "GEN# +1.00107947"},
        {"Smithsonian Astrophysical Observation", "SAO 256939"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.21665756),
        dec: Angle.Degrees(-72.60387327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78791"},
        {"Hipparcos Number", "HIP 44599"},
        {"Fundamental Katalog 5th Edition", "FK5 2720"},
        {"Geneva Identification System", "GEN# +1.00078791"},
        {"Smithsonian Astrophysical Observation", "SAO 256582"},
        {"Wilson Evans Batten Catalogue", "WEB 8534"},
    },
    visualMagnitude: 4.47,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.28679299),
        dec: Angle.Degrees(-72.60269387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203213"},
        {"Hipparcos Number", "HIP 105781"},
        {"Smithsonian Astrophysical Observation", "SAO 257921"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.35136859),
        dec: Angle.Degrees(-72.59533720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74923"},
        {"Hipparcos Number", "HIP 42644"},
        {"Geneva Identification System", "GEN# +1.00074923"},
        {"Smithsonian Astrophysical Observation", "SAO 256539"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.34714894),
        dec: Angle.Degrees(-72.58891481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61495"},
        {"Hipparcos Number", "HIP 36705"},
        {"Smithsonian Astrophysical Observation", "SAO 256423"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.25668182),
        dec: Angle.Degrees(-72.58796109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146847"},
        {"Hipparcos Number", "HIP 80410"},
        {"Smithsonian Astrophysical Observation", "SAO 257395"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.19063550),
        dec: Angle.Degrees(-72.58574966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193385"},
        {"Hipparcos Number", "HIP 100766"},
        {"Geneva Identification System", "GEN# +1.00193385"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.45650836),
        dec: Angle.Degrees(-72.58519922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62920"},
        {"Hipparcos Number", "HIP 37331"},
        {"Smithsonian Astrophysical Observation", "SAO 256433"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.95202953),
        dec: Angle.Degrees(-72.58209709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83781",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83781"},
    },
    visualMagnitude: 11.41,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.84462137),
        dec: Angle.Degrees(-72.58103532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153620"},
        {"Hipparcos Number", "HIP 83778"},
        {"Smithsonian Astrophysical Observation", "SAO 257461"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.84113202),
        dec: Angle.Degrees(-72.57543162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144125"},
        {"Hipparcos Number", "HIP 79246"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.59381094),
        dec: Angle.Degrees(-72.57463149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127127"},
        {"Hipparcos Number", "HIP 71214"},
        {"Smithsonian Astrophysical Observation", "SAO 257172"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.44949456),
        dec: Angle.Degrees(-72.56103613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75775"},
    },
    visualMagnitude: 11.85,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.19681570),
        dec: Angle.Degrees(-72.56071538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54154"},
        {"Hipparcos Number", "HIP 33788"},
        {"Geneva Identification System", "GEN# +1.00054154"},
        {"Smithsonian Astrophysical Observation", "SAO 256360"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.23873901),
        dec: Angle.Degrees(-72.56067296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87257"},
        {"Hipparcos Number", "HIP 49028"},
        {"Geneva Identification System", "GEN# +1.00087257"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.04650186),
        dec: Angle.Degrees(-72.55913110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155088"},
        {"Hipparcos Number", "HIP 84482"},
        {"Smithsonian Astrophysical Observation", "SAO 257479"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.07257135),
        dec: Angle.Degrees(-72.55567887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213591"},
        {"Hipparcos Number", "HIP 111478"},
        {"Geneva Identification System", "GEN# +1.00213591"},
        {"Smithsonian Astrophysical Observation", "SAO 258051"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.79670514),
        dec: Angle.Degrees(-72.55174296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76270"},
        {"Hipparcos Number", "HIP 43351"},
        {"Geneva Identification System", "GEN# +1.00076270"},
        {"Renson", "Renson 21370"},
        {"Smithsonian Astrophysical Observation", "SAO 256556"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.45890766),
        dec: Angle.Degrees(-72.55125950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125794"},
        {"Hipparcos Number", "HIP 70533"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.43891767),
        dec: Angle.Degrees(-72.54961266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205712"},
        {"Hipparcos Number", "HIP 107081"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.32961974),
        dec: Angle.Degrees(-72.54561655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200924"},
        {"Hipparcos Number", "HIP 104597"},
        {"Geneva Identification System", "GEN# +1.00200924"},
        {"Smithsonian Astrophysical Observation", "SAO 257893"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.83694548),
        dec: Angle.Degrees(-72.54427874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114531"},
        {"Hipparcos Number", "HIP 64501"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.30916146),
        dec: Angle.Degrees(-72.54400054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7099"},
        {"Hipparcos Number", "HIP 5397"},
        {"Geneva Identification System", "GEN# +1.00007099"},
        {"Wilson Evans Batten Catalogue", "WEB 1177"},
    },
    visualMagnitude: 10.96,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.26646785),
        dec: Angle.Degrees(-72.53822788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197431"},
        {"Hipparcos Number", "HIP 102730"},
        {"Smithsonian Astrophysical Observation", "SAO 257854"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.25344356),
        dec: Angle.Degrees(-72.53268412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218656"},
        {"Hipparcos Number", "HIP 114500"},
        {"Geneva Identification System", "GEN# +1.00218656"},
        {"Smithsonian Astrophysical Observation", "SAO 258111"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.84775967),
        dec: Angle.Degrees(-72.52517800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130815"},
        {"Hipparcos Number", "HIP 72987"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.73114291),
        dec: Angle.Degrees(-72.51935841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113240"},
        {"Hipparcos Number", "HIP 63761"},
        {"Geneva Identification System", "GEN# +1.00113240"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.03421373),
        dec: Angle.Degrees(-72.51283777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42936"},
        {"Hipparcos Number", "HIP 28941"},
        {"Cincinnati Publication", "Ci 20 378"},
        {"Geneva Identification System", "GEN# +1.00042936"},
        {"Smithsonian Astrophysical Observation", "SAO 256269"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.62437646),
        dec: Angle.Degrees(-72.51172832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -384.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137553"},
        {"Hipparcos Number", "HIP 76064"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.01838415),
        dec: Angle.Degrees(-72.51142888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92219"},
        {"Hipparcos Number", "HIP 51913"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.08786174),
        dec: Angle.Degrees(-72.50828995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88043"},
        {"Hipparcos Number", "HIP 49436"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.39682891),
        dec: Angle.Degrees(-72.50594639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13928"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.86197942),
        dec: Angle.Degrees(-72.50477652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118386"},
        {"Hipparcos Number", "HIP 66635"},
        {"Geneva Identification System", "GEN# +1.00118386"},
        {"Renson", "Renson 34180"},
        {"Smithsonian Astrophysical Observation", "SAO 257072"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.88479312),
        dec: Angle.Degrees(-72.50423597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186219"},
        {"Hipparcos Number", "HIP 97534"},
        {"Fundamental Katalog 5th Edition", "FK5 3580"},
        {"Geneva Identification System", "GEN# +1.00186219"},
        {"Renson", "Renson 51350"},
        {"Smithsonian Astrophysical Observation", "SAO 257736"},
        {"Wilson Evans Batten Catalogue", "WEB 17149"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.35538694),
        dec: Angle.Degrees(-72.50341408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30986"},
        {"Hipparcos Number", "HIP 22102"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.34337763),
        dec: Angle.Degrees(-72.50230299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44489"},
        {"Hipparcos Number", "HIP 29666"},
        {"Smithsonian Astrophysical Observation", "SAO 256287"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.74073888),
        dec: Angle.Degrees(-72.49670663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13732"},
        {"Hipparcos Number", "HIP 10105"},
        {"Fundamental Katalog 5th Edition", "FK5 4200"},
        {"Smithsonian Astrophysical Observation", "SAO 255855"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.49783604),
        dec: Angle.Degrees(-72.49515066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171605"},
        {"Hipparcos Number", "HIP 91763"},
        {"Smithsonian Astrophysical Observation", "SAO 257618"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.68493284),
        dec: Angle.Degrees(-72.48404732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74424"},
        {"Hipparcos Number", "HIP 42384"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.63325993),
        dec: Angle.Degrees(-72.48093433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136042"},
        {"Hipparcos Number", "HIP 75344"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.93356746),
        dec: Angle.Degrees(-72.47689593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30031"},
        {"Hipparcos Number", "HIP 21523"},
        {"Smithsonian Astrophysical Observation", "SAO 256112"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.32572996),
        dec: Angle.Degrees(-72.47684622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99872"},
        {"Hipparcos Number", "HIP 55979"},
        {"Geneva Identification System", "GEN# +1.00099872J"},
        {"Smithsonian Astrophysical Observation", "SAO 256843"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.07692869),
        dec: Angle.Degrees(-72.47396862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91947"},
        {"Hipparcos Number", "HIP 51749"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.58567938),
        dec: Angle.Degrees(-72.47357068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186879"},
        {"Hipparcos Number", "HIP 97869"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.32188721),
        dec: Angle.Degrees(-72.47346433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212662"},
        {"Hipparcos Number", "HIP 110950"},
        {"Smithsonian Astrophysical Observation", "SAO 258041"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.19090562),
        dec: Angle.Degrees(-72.47125074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86636"},
        {"Hipparcos Number", "HIP 48716"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.04170660),
        dec: Angle.Degrees(-72.46868868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83093"},
        {"Hipparcos Number", "HIP 46760"},
        {"Celescope Catalog", "CEL 3323"},
        {"Geneva Identification System", "GEN# +1.00083093J"},
        {"Wilson Evans Batten Catalogue", "WEB 8819"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.95948268),
        dec: Angle.Degrees(-72.46836824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6884"},
        {"Hipparcos Number", "HIP 5267"},
        {"Geneva Identification System", "GEN# +1.00006884"},
        {"Wilson Evans Batten Catalogue", "WEB 1115"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.82590189),
        dec: Angle.Degrees(-72.46767938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142497"},
        {"Hipparcos Number", "HIP 78434"},
        {"Smithsonian Astrophysical Observation", "SAO 257347"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.19537411),
        dec: Angle.Degrees(-72.46281934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205597"},
        {"Hipparcos Number", "HIP 107029"},
        {"Smithsonian Astrophysical Observation", "SAO 257947"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.13998877),
        dec: Angle.Degrees(-72.46261150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51017"},
        {"Hipparcos Number", "HIP 32656"},
        {"Smithsonian Astrophysical Observation", "SAO 256340"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.17933818),
        dec: Angle.Degrees(-72.46085421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88774"},
        {"Hipparcos Number", "HIP 49879"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.77218966),
        dec: Angle.Degrees(-72.45815730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19493"},
        {"Hipparcos Number", "HIP 14180"},
        {"Geneva Identification System", "GEN# +1.00019493"},
        {"Smithsonian Astrophysical Observation", "SAO 255946"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.71196513),
        dec: Angle.Degrees(-72.45755250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 125.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104920"},
        {"Hipparcos Number", "HIP 58915"},
        {"Geneva Identification System", "GEN# +1.00104920"},
        {"Smithsonian Astrophysical Observation", "SAO 256900"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.21564817),
        dec: Angle.Degrees(-72.45722572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33032"},
        {"Hipparcos Number", "HIP 23285"},
        {"Geneva Identification System", "GEN# +1.00033032"},
        {"Smithsonian Astrophysical Observation", "SAO 256150"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.14059504),
        dec: Angle.Degrees(-72.45608925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110480"},
        {"Hipparcos Number", "HIP 62098"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.89414219),
        dec: Angle.Degrees(-72.44767239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184587"},
        {"Hipparcos Number", "HIP 96880"},
        {"Geneva Identification System", "GEN# +1.00184587"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.39884022),
        dec: Angle.Degrees(-72.44564702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101915"},
        {"Hipparcos Number", "HIP 57143"},
        {"Geneva Identification System", "GEN# +1.00101915"},
        {"Smithsonian Astrophysical Observation", "SAO 256866"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.78222209),
        dec: Angle.Degrees(-72.44553863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16382"},
        {"Hipparcos Number", "HIP 11866"},
        {"Smithsonian Astrophysical Observation", "SAO 255899"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.27641098),
        dec: Angle.Degrees(-72.44401331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140022"},
        {"Hipparcos Number", "HIP 77320"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.77877764),
        dec: Angle.Degrees(-72.44363631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93372"},
        {"Hipparcos Number", "HIP 52535"},
        {"Geneva Identification System", "GEN# +1.00093372"},
        {"Smithsonian Astrophysical Observation", "SAO 256752"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.11356183),
        dec: Angle.Degrees(-72.44362716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91700"},
        {"Hipparcos Number", "HIP 51611"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.14679833),
        dec: Angle.Degrees(-72.44133925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222469"},
        {"Hipparcos Number", "HIP 116879"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.36789183),
        dec: Angle.Degrees(-72.44116982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102402",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102402"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.26597752),
        dec: Angle.Degrees(-72.43857758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169242"},
        {"Hipparcos Number", "HIP 90734"},
        {"Smithsonian Astrophysical Observation", "SAO 257600"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.68958825),
        dec: Angle.Degrees(-72.43642710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113061"},
        {"Hipparcos Number", "HIP 63649"},
        {"Geneva Identification System", "GEN# +1.00113061"},
        {"Smithsonian Astrophysical Observation", "SAO 257001"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.68018547),
        dec: Angle.Degrees(-72.43176393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91680"},
        {"Hipparcos Number", "HIP 51608"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.13542350),
        dec: Angle.Degrees(-72.42810558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195685"},
        {"Hipparcos Number", "HIP 101854"},
        {"Smithsonian Astrophysical Observation", "SAO 257832"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.59449463),
        dec: Angle.Degrees(-72.42516355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31661"},
        {"Hipparcos Number", "HIP 22525"},
        {"Smithsonian Astrophysical Observation", "SAO 256136"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.70418289),
        dec: Angle.Degrees(-72.42423433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218764"},
        {"Hipparcos Number", "HIP 114545"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.03417454),
        dec: Angle.Degrees(-72.42348680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82567"},
        {"Hipparcos Number", "HIP 46452"},
        {"Geneva Identification System", "GEN# +1.00082567"},
        {"Renson", "Renson 23480"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.10965983),
        dec: Angle.Degrees(-72.42239015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33652"},
        {"Hipparcos Number", "HIP 23647"},
        {"Smithsonian Astrophysical Observation", "SAO 256158"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.24002234),
        dec: Angle.Degrees(-72.41952506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181704"},
        {"Hipparcos Number", "HIP 95712"},
        {"Smithsonian Astrophysical Observation", "SAO 257691"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.01506361),
        dec: Angle.Degrees(-72.41866409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95704"},
    },
    visualMagnitude: 11.65,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.00133646),
        dec: Angle.Degrees(-72.41807836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40107"},
        {"Hipparcos Number", "HIP 27531"},
        {"Geneva Identification System", "GEN# +1.00040107"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.45843796),
        dec: Angle.Degrees(-72.41324241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 299.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11462"},
        {"Hipparcos Number", "HIP 8485"},
        {"Smithsonian Astrophysical Observation", "SAO 255818"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.34436252),
        dec: Angle.Degrees(-72.41187994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31975"},
        {"Hipparcos Number", "HIP 22717"},
        {"Geneva Identification System", "GEN# +1.00031975"},
        {"Smithsonian Astrophysical Observation", "SAO 256139"},
        {"Wilson Evans Batten Catalogue", "WEB 4392"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.27389230),
        dec: Angle.Degrees(-72.40833805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 270.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164751"},
        {"Hipparcos Number", "HIP 88979"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.42442640),
        dec: Angle.Degrees(-72.40700832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77348"},
        {"Hipparcos Number", "HIP 43927"},
        {"Geneva Identification System", "GEN# +1.00077348"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.22705194),
        dec: Angle.Degrees(-72.40650445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109911"},
        {"Hipparcos Number", "HIP 61765"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.88482484),
        dec: Angle.Degrees(-72.40192263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143346"},
        {"Hipparcos Number", "HIP 78868"},
        {"Fundamental Katalog 5th Edition", "FK5 3269"},
        {"Geneva Identification System", "GEN# +1.00143346"},
        {"Smithsonian Astrophysical Observation", "SAO 257357"},
    },
    visualMagnitude: 5.70,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.48284121),
        dec: Angle.Degrees(-72.40107181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223777"},
        {"Hipparcos Number", "HIP 117749"},
        {"Smithsonian Astrophysical Observation", "SAO 258192"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.20194845),
        dec: Angle.Degrees(-72.39945404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134567"},
        {"Hipparcos Number", "HIP 74673"},
        {"Fundamental Katalog 5th Edition", "FK5 5355"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.90921166),
        dec: Angle.Degrees(-72.39852853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35107"},
        {"Hipparcos Number", "HIP 24513"},
        {"Smithsonian Astrophysical Observation", "SAO 256170"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.87104670),
        dec: Angle.Degrees(-72.39829232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219778"},
        {"Hipparcos Number", "HIP 115180"},
        {"Smithsonian Astrophysical Observation", "SAO 258129"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.94114682),
        dec: Angle.Degrees(-72.39470532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175739"},
        {"Hipparcos Number", "HIP 93584"},
        {"Geneva Identification System", "GEN# +1.00175739"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.88984689),
        dec: Angle.Degrees(-72.39160369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153183"},
        {"Hipparcos Number", "HIP 83554"},
        {"Renson", "Renson 43330"},
        {"Smithsonian Astrophysical Observation", "SAO 257459"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.13834647),
        dec: Angle.Degrees(-72.38689546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311493"},
        {"Henry Draper 2", "HD 311493A"},
        {"Hipparcos Number", "HIP 44488"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.96513193),
        dec: Angle.Degrees(-72.38565507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4004"},
        {"Geneva Identification System", "GEN# +6.20053098"},
    },
    visualMagnitude: 11.48,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.85248280),
        dec: Angle.Degrees(-72.38294081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116529"},
        {"Hipparcos Number", "HIP 65571"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.66052516),
        dec: Angle.Degrees(-72.37965795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22462"},
        {"Hipparcos Number", "HIP 16392"},
        {"Geneva Identification System", "GEN# +1.00022462"},
        {"Smithsonian Astrophysical Observation", "SAO 255997"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.77235427),
        dec: Angle.Degrees(-72.37331087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109082"},
        {"Hipparcos Number", "HIP 61229"},
        {"Geneva Identification System", "GEN# +1.00109082"},
        {"Smithsonian Astrophysical Observation", "SAO 256959"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.20016395),
        dec: Angle.Degrees(-72.37303006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94652"},
        {"Hipparcos Number", "HIP 53255"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.37845302),
        dec: Angle.Degrees(-72.36926966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101288"},
        {"Hipparcos Number", "HIP 56797"},
        {"Geneva Identification System", "GEN# +1.00101288"},
        {"Smithsonian Astrophysical Observation", "SAO 256859"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.65803316),
        dec: Angle.Degrees(-72.36861674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163766"},
        {"Hipparcos Number", "HIP 88540"},
        {"Smithsonian Astrophysical Observation", "SAO 257558"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.20148813),
        dec: Angle.Degrees(-72.36574168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187456"},
        {"Hipparcos Number", "HIP 98106"},
        {"Geneva Identification System", "GEN# +1.00187456"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.06739256),
        dec: Angle.Degrees(-72.36356780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -300.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112885"},
        {"Hipparcos Number", "HIP 63563"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.39373635),
        dec: Angle.Degrees(-72.34933842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16427"},
        {"Hipparcos Number", "HIP 11909"},
        {"Geneva Identification System", "GEN# +1.00016427"},
        {"Smithsonian Astrophysical Observation", "SAO 255901"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.43158060),
        dec: Angle.Degrees(-72.34909143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74460"},
        {"Hipparcos Number", "HIP 42407"},
        {"Geneva Identification System", "GEN# +1.00074460A"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.69926269),
        dec: Angle.Degrees(-72.34606839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164479"},
        {"Hipparcos Number", "HIP 88854"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.09632382),
        dec: Angle.Degrees(-72.34407933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75681",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75681"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.92503584),
        dec: Angle.Degrees(-71.41832682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56480"},
        {"Hipparcos Number", "HIP 34643"},
        {"Renson", "Renson 15420"},
        {"Smithsonian Astrophysical Observation", "SAO 256377"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.62498315),
        dec: Angle.Degrees(-72.34269407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158314"},
        {"Hipparcos Number", "HIP 86074"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.86804964),
        dec: Angle.Degrees(-72.34250411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25327"},
        {"Hipparcos Number", "HIP 18356"},
        {"Smithsonian Astrophysical Observation", "SAO 256046"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.86269278),
        dec: Angle.Degrees(-72.34158926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36145"},
        {"Hipparcos Number", "HIP 25133"},
        {"Geneva Identification System", "GEN# +1.00036145"},
        {"Smithsonian Astrophysical Observation", "SAO 256181"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.68694179),
        dec: Angle.Degrees(-72.33875575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211122"},
        {"Hipparcos Number", "HIP 110105"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.55349148),
        dec: Angle.Degrees(-72.33717029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 225.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144869"},
        {"Hipparcos Number", "HIP 79556"},
        {"Geneva Identification System", "GEN# +1.00144869"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.50774902),
        dec: Angle.Degrees(-72.32727278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8783"},
        {"Hipparcos Number", "HIP 6534"},
        {"Fundamental Katalog 5th Edition", "FK5 4128"},
        {"Geneva Identification System", "GEN# +1.00008783"},
        {"Renson", "Renson 2110"},
        {"Smithsonian Astrophysical Observation", "SAO 255773"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.00166463),
        dec: Angle.Degrees(-72.32441132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121387"},
        {"Hipparcos Number", "HIP 68246"},
        {"Geneva Identification System", "GEN# +1.00121387"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.57410324),
        dec: Angle.Degrees(-72.32362435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184291"},
        {"Hipparcos Number", "HIP 96764"},
        {"Smithsonian Astrophysical Observation", "SAO 257715"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.04296203),
        dec: Angle.Degrees(-72.32208076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20003"},
        {"Hipparcos Number", "HIP 14530"},
        {"Geneva Identification System", "GEN# +1.00020003"},
        {"Smithsonian Astrophysical Observation", "SAO 255959"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.90741456),
        dec: Angle.Degrees(-72.32186752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128420"},
        {"Hipparcos Number", "HIP 71789"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.27272841),
        dec: Angle.Degrees(-72.31938523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87367"},
        {"Hipparcos Number", "HIP 49086"},
        {"Geneva Identification System", "GEN# +1.00087367"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.27553209),
        dec: Angle.Degrees(-72.31868742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224790"},
        {"Hipparcos Number", "HIP 66"},
        {"Geneva Identification System", "GEN# +1.00224790"},
        {"Smithsonian Astrophysical Observation", "SAO 258205"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.18854917),
        dec: Angle.Degrees(-72.31824913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125136"},
        {"Hipparcos Number", "HIP 70175"},
        {"Geneva Identification System", "GEN# +1.00125136"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.36892000),
        dec: Angle.Degrees(-72.31752972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162128"},
        {"Hipparcos Number", "HIP 87817"},
        {"Smithsonian Astrophysical Observation", "SAO 257541"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.08874060),
        dec: Angle.Degrees(-72.31199025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15009"},
        {"Hipparcos Number", "HIP 10943"},
        {"Smithsonian Astrophysical Observation", "SAO 255878"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.23633019),
        dec: Angle.Degrees(-72.31166338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59681"},
        {"Hipparcos Number", "HIP 35938"},
        {"Smithsonian Astrophysical Observation", "SAO 256409"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.12720911),
        dec: Angle.Degrees(-72.31000913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133385"},
        {"Hipparcos Number", "HIP 74141"},
        {"Geneva Identification System", "GEN# +1.00133385"},
        {"Smithsonian Astrophysical Observation", "SAO 257241"},
        {"Wilson Evans Batten Catalogue", "WEB 12663"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.25318731),
        dec: Angle.Degrees(-72.30743918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149392"},
        {"Hipparcos Number", "HIP 81653"},
        {"Smithsonian Astrophysical Observation", "SAO 257421"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.19749775),
        dec: Angle.Degrees(-72.29967668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138682"},
        {"Hipparcos Number", "HIP 76648"},
        {"Smithsonian Astrophysical Observation", "SAO 257304"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.77789580),
        dec: Angle.Degrees(-72.29761939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97176"},
        {"Hipparcos Number", "HIP 54533"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.39175254),
        dec: Angle.Degrees(-72.29349520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4768"},
        {"Geneva Identification System", "GEN# +6.20027098"},
        {"Geneva Identification System 2", "GEN# +6.20053270"},
    },
    visualMagnitude: 11.42,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.32081900),
        dec: Angle.Degrees(-72.29197897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207591"},
        {"Hipparcos Number", "HIP 108081"},
        {"Geneva Identification System", "GEN# +1.00207591"},
        {"Smithsonian Astrophysical Observation", "SAO 257975"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.47310859),
        dec: Angle.Degrees(-72.29063753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4773"},
        {"Geneva Identification System", "GEN# +6.20053271"},
    },
    visualMagnitude: 13.27,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.33396567),
        dec: Angle.Degrees(-72.28840663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198780"},
        {"Hipparcos Number", "HIP 103470"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.44584980),
        dec: Angle.Degrees(-72.28823773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70685"},
        {"Hipparcos Number", "HIP 40618"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.38388611),
        dec: Angle.Degrees(-72.28574508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3738"},
        {"Hipparcos Number", "HIP 3076"},
        {"Geneva Identification System", "GEN# +1.00003738"},
        {"Smithsonian Astrophysical Observation", "SAO 255692"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.75161755),
        dec: Angle.Degrees(-72.28257534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311528"},
        {"Hipparcos Number", "HIP 46573"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.46629105),
        dec: Angle.Degrees(-72.28118071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29255"},
        {"Hipparcos Number", "HIP 20981"},
        {"Geneva Identification System", "GEN# +1.00029255"},
        {"Smithsonian Astrophysical Observation", "SAO 256099"},
        {"Wilson Evans Batten Catalogue", "WEB 4037"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.49431716),
        dec: Angle.Degrees(-72.27551873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 751"},
        {"Hipparcos Number", "HIP 941"},
        {"Geneva Identification System", "GEN# +1.00000751"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.90527264),
        dec: Angle.Degrees(-72.27547333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38728"},
        {"Hipparcos Number", "HIP 26741"},
        {"Smithsonian Astrophysical Observation", "SAO 256223"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.23231181),
        dec: Angle.Degrees(-72.27447032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154440"},
        {"Hipparcos Number", "HIP 84145"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.04721080),
        dec: Angle.Degrees(-72.27407644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47953"},
        {"Hipparcos Number", "HIP 31318"},
        {"Renson", "Renson 12890"},
        {"Smithsonian Astrophysical Observation", "SAO 256315"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.51973392),
        dec: Angle.Degrees(-72.26983099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89522"},
        {"Hipparcos Number", "HIP 50329"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.16592814),
        dec: Angle.Degrees(-72.26374948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99264"},
        {"Hipparcos Number", "HIP 55657"},
        {"Fundamental Katalog 5th Edition", "FK5 2911"},
        {"Geneva Identification System", "GEN# +1.00099264"},
        {"Smithsonian Astrophysical Observation", "SAO 256834"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.04657107),
        dec: Angle.Degrees(-72.25660192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311568"},
        {"Hipparcos Number", "HIP 47590"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.55393709),
        dec: Angle.Degrees(-72.25456500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211998"},
        {"Hipparcos Number", "HIP 110618"},
        {"Cincinnati Publication", "Ci 20 1357"},
        {"Geneva Identification System", "GEN# +1.00211998J"},
        {"Smithsonian Astrophysical Observation", "SAO 258033"},
        {"Wilson Evans Batten Catalogue", "WEB 19820"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.14329493),
        dec: Angle.Degrees(-72.25377388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1302.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -674.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11916"},
        {"Hipparcos Number", "HIP 8839"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.41443135),
        dec: Angle.Degrees(-72.25173919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96044"},
        {"Hipparcos Number", "HIP 54006"},
        {"Geneva Identification System", "GEN# +1.00096044"},
        {"Smithsonian Astrophysical Observation", "SAO 256788"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.72841324),
        dec: Angle.Degrees(-72.24221953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98213"},
        {"Hipparcos Number", "HIP 55070"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.11981863),
        dec: Angle.Degrees(-72.24126356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201803"},
        {"Hipparcos Number", "HIP 105045"},
        {"Smithsonian Astrophysical Observation", "SAO 257902"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.15916319),
        dec: Angle.Degrees(-72.24081224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192762"},
        {"Hipparcos Number", "HIP 100457"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.56785043),
        dec: Angle.Degrees(-72.23850018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116924"},
        {"Hipparcos Number", "HIP 65805"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.33321045),
        dec: Angle.Degrees(-72.23759346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20557"},
        {"Hipparcos Number", "HIP 14979"},
        {"Renson", "Renson 5130"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.26985006),
        dec: Angle.Degrees(-72.23707052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15237"},
    },
    visualMagnitude: 11.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.12706591),
        dec: Angle.Degrees(-72.23137928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171382"},
        {"Hipparcos Number", "HIP 91648"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.33816450),
        dec: Angle.Degrees(-72.22271202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159964"},
        {"Hipparcos Number", "HIP 86815"},
        {"Geneva Identification System", "GEN# +1.00159964"},
        {"Smithsonian Astrophysical Observation", "SAO 257525"},
        {"Wilson Evans Batten Catalogue", "WEB 14639"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.08248340),
        dec: Angle.Degrees(-72.22118931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149264"},
        {"Hipparcos Number", "HIP 81615"},
        {"Renson", "Renson 42250"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.03834528),
        dec: Angle.Degrees(-72.21877274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123395"},
        {"Hipparcos Number", "HIP 69277"},
        {"Smithsonian Astrophysical Observation", "SAO 257120"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.72499359),
        dec: Angle.Degrees(-72.21723469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184822"},
        {"Hipparcos Number", "HIP 96968"},
        {"Smithsonian Astrophysical Observation", "SAO 257719"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.65591030),
        dec: Angle.Degrees(-72.21342504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197417"},
        {"Hipparcos Number", "HIP 102717"},
        {"Geneva Identification System", "GEN# +1.00197417"},
        {"Renson", "Renson 55030"},
        {"Smithsonian Astrophysical Observation", "SAO 257852"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.20071286),
        dec: Angle.Degrees(-72.21206177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128964"},
        {"Hipparcos Number", "HIP 72059"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.08847654),
        dec: Angle.Degrees(-72.20783181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68031"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.95958209),
        dec: Angle.Degrees(-72.20478060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224766"},
        {"Hipparcos Number", "HIP 45"},
    },
    visualMagnitude: 9.59,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.13420453),
        dec: Angle.Degrees(-72.20271031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93164"},
        {"Hipparcos Number", "HIP 52427"},
        {"Geneva Identification System", "GEN# +1.00093164"},
        {"Smithsonian Astrophysical Observation", "SAO 256748"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.77092045),
        dec: Angle.Degrees(-72.19524684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104724"},
        {"Hipparcos Number", "HIP 58790"},
        {"Geneva Identification System", "GEN# +1.00104724"},
        {"Wilson Evans Batten Catalogue", "WEB 10475"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.87792281),
        dec: Angle.Degrees(-72.19434282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84631"},
        {"Hipparcos Number", "HIP 47623"},
        {"Smithsonian Astrophysical Observation", "SAO 256647"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.66390582),
        dec: Angle.Degrees(-72.19082532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132675"},
        {"Hipparcos Number", "HIP 73812"},
        {"Geneva Identification System", "GEN# +1.00132675"},
        {"Smithsonian Astrophysical Observation", "SAO 257234"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.29527997),
        dec: Angle.Degrees(-72.18956214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311490"},
        {"Hipparcos Number", "HIP 45435"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.89287352),
        dec: Angle.Degrees(-72.18812351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173313"},
        {"Hipparcos Number", "HIP 92518"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.82232336),
        dec: Angle.Degrees(-72.18695167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58380"},
        {"Hipparcos Number", "HIP 35422"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.69881860),
        dec: Angle.Degrees(-72.18693997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216379"},
        {"Hipparcos Number", "HIP 113121"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.62184211),
        dec: Angle.Degrees(-72.18586236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79593"},
        {"Hipparcos Number", "HIP 45036"},
        {"Smithsonian Astrophysical Observation", "SAO 256591"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.59367436),
        dec: Angle.Degrees(-72.18583922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112219"},
        {"Hipparcos Number", "HIP 63165"},
        {"Geneva Identification System", "GEN# +1.00112219"},
        {"Smithsonian Astrophysical Observation", "SAO 256992"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.13216726),
        dec: Angle.Degrees(-72.18518249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191686"},
        {"Hipparcos Number", "HIP 99973"},
        {"Smithsonian Astrophysical Observation", "SAO 257786"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.23613640),
        dec: Angle.Degrees(-72.18441636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204319"},
        {"Hipparcos Number", "HIP 106331"},
        {"Geneva Identification System", "GEN# +1.00204319"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.03409704),
        dec: Angle.Degrees(-72.18214909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67299"},
        {"Hipparcos Number", "HIP 39204"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.29301555),
        dec: Angle.Degrees(-72.17504893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181489"},
        {"Hipparcos Number", "HIP 95640"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.81211804),
        dec: Angle.Degrees(-72.17432519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -268.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204732"},
        {"Hipparcos Number", "HIP 106562"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.71950757),
        dec: Angle.Degrees(-72.17368446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132874"},
        {"Hipparcos Number", "HIP 73921"},
        {"Smithsonian Astrophysical Observation", "SAO 257237"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.59488026),
        dec: Angle.Degrees(-72.17014471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43808"},
        {"Hipparcos Number", "HIP 29350"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.80769293),
        dec: Angle.Degrees(-72.16544109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220367"},
        {"Hipparcos Number", "HIP 115547"},
        {"Geneva Identification System", "GEN# +1.00220367"},
        {"Smithsonian Astrophysical Observation", "SAO 258135"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.07856979),
        dec: Angle.Degrees(-72.16508538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177302"},
        {"Hipparcos Number", "HIP 94201"},
        {"Smithsonian Astrophysical Observation", "SAO 257663"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.67265191),
        dec: Angle.Degrees(-72.16391835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68636"},
        {"Hipparcos Number", "HIP 39745"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.85186927),
        dec: Angle.Degrees(-72.15575185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94726"},
        {"Hipparcos Number", "HIP 53296"},
        {"Smithsonian Astrophysical Observation", "SAO 256771"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.50071849),
        dec: Angle.Degrees(-72.15530082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77910"},
        {"Hipparcos Number", "HIP 44221"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.10401828),
        dec: Angle.Degrees(-72.15457928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42082"},
        {"Hipparcos Number", "HIP 28568"},
        {"Smithsonian Astrophysical Observation", "SAO 256260"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.43721652),
        dec: Angle.Degrees(-72.14768119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115967"},
        {"Hipparcos Number", "HIP 65289"},
        {"Geneva Identification System", "GEN# +1.00115967J"},
        {"Smithsonian Astrophysical Observation", "SAO 257033"},
        {"Wilson Evans Batten Catalogue", "WEB 11522"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.71925349),
        dec: Angle.Degrees(-72.14667406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202106"},
        {"Hipparcos Number", "HIP 105177"},
        {"Smithsonian Astrophysical Observation", "SAO 257906"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.60034324),
        dec: Angle.Degrees(-72.14597697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207197"},
        {"Hipparcos Number", "HIP 107859"},
        {"Smithsonian Astrophysical Observation", "SAO 257966"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.78210432),
        dec: Angle.Degrees(-72.13945677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214778"},
        {"Hipparcos Number", "HIP 112145"},
        {"Smithsonian Astrophysical Observation", "SAO 258060"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.73209049),
        dec: Angle.Degrees(-72.13895744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30766"},
        {"Hipparcos Number", "HIP 22009"},
        {"Smithsonian Astrophysical Observation", "SAO 256123"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.96322425),
        dec: Angle.Degrees(-72.13589682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158952"},
        {"Hipparcos Number", "HIP 86359"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.69830647),
        dec: Angle.Degrees(-72.13349649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109026"},
        {"Hipparcos Number", "HIP 61199"},
        {"Fundamental Katalog 5th Edition", "FK5 469"},
        {"Geneva Identification System", "GEN# +1.00109026"},
        {"Renson", "Renson 31640"},
        {"Smithsonian Astrophysical Observation", "SAO 256955"},
        {"Wilson Evans Batten Catalogue", "WEB 10893"},
    },
    visualMagnitude: 3.84,
    bvColour: -0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.11712896),
        dec: Angle.Degrees(-72.13297590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45039"},
        {"Hipparcos Number", "HIP 29942"},
        {"Fundamental Katalog 5th Edition", "FK5 4570"},
        {"Smithsonian Astrophysical Observation", "SAO 256290"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.55878310),
        dec: Angle.Degrees(-72.13227567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90038"},
        {"Hipparcos Number", "HIP 50626"},
        {"Smithsonian Astrophysical Observation", "SAO 256701"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.11430985),
        dec: Angle.Degrees(-72.13029961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123801"},
        {"Hipparcos Number", "HIP 69479"},
        {"Smithsonian Astrophysical Observation", "SAO 257125"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.35991324),
        dec: Angle.Degrees(-72.12385074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140911"},
        {"Hipparcos Number", "HIP 77694"},
    },
    visualMagnitude: 8.94,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.94624420),
        dec: Angle.Degrees(-72.11897782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187654"},
        {"Hipparcos Number", "HIP 98183"},
        {"Smithsonian Astrophysical Observation", "SAO 257750"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.28454159),
        dec: Angle.Degrees(-72.11377252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98003"},
        {"Hipparcos Number", "HIP 54920"},
        {"Geneva Identification System", "GEN# +1.00098003"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.69986095),
        dec: Angle.Degrees(-72.11222903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151442"},
        {"Hipparcos Number", "HIP 82657"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.45712531),
        dec: Angle.Degrees(-72.10305722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107705"},
        {"Geneva Identification System", "GEN# -0.07202640"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.27196165),
        dec: Angle.Degrees(-72.10178403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 300.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -291.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182894"},
        {"Hipparcos Number", "HIP 96168"},
        {"Geneva Identification System", "GEN# +1.00182894"},
        {"Smithsonian Astrophysical Observation", "SAO 257703"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.31299352),
        dec: Angle.Degrees(-72.10048619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97641"},
        {"Hipparcos Number", "HIP 54759"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.17334145),
        dec: Angle.Degrees(-72.09977874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221535"},
        {"Hipparcos Number", "HIP 116304"},
        {"Geneva Identification System", "GEN# +1.00221535"},
        {"Smithsonian Astrophysical Observation", "SAO 258157"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.47213922),
        dec: Angle.Degrees(-72.09544159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1902",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 8.88,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)24, 02.8700),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)05, 43.300)
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
    primaryId: "HIP 24992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35906"},
        {"Hipparcos Number", "HIP 24992"},
        {"Geneva Identification System", "GEN# +1.00035906"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.27177721),
        dec: Angle.Degrees(-72.09439160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129189"},
        {"Hipparcos Number", "HIP 72159"},
        {"Renson", "Renson 36840"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.38752099),
        dec: Angle.Degrees(-72.08747243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72740"},
        {"Hipparcos Number", "HIP 41604"},
        {"Smithsonian Astrophysical Observation", "SAO 256518"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.22359299),
        dec: Angle.Degrees(-72.08188282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152790"},
        {"Hipparcos Number", "HIP 83349"},
        {"Smithsonian Astrophysical Observation", "SAO 257455"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.51257662),
        dec: Angle.Degrees(-72.07979348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34397"},
        {"Hipparcos Number", "HIP 24062"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.55489253),
        dec: Angle.Degrees(-72.07683235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87953"},
        {"Hipparcos Number", "HIP 49403"},
        {"Smithsonian Astrophysical Observation", "SAO 256678"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.28217576),
        dec: Angle.Degrees(-72.07436398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129597"},
        {"Hipparcos Number", "HIP 72368"},
        {"Smithsonian Astrophysical Observation", "SAO 257195"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.95469842),
        dec: Angle.Degrees(-72.07314005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99795"},
        {"Hipparcos Number", "HIP 55933"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.94506744),
        dec: Angle.Degrees(-72.07021544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122341"},
        {"Hipparcos Number", "HIP 68779"},
        {"Geneva Identification System", "GEN# +1.00122341"},
        {"Smithsonian Astrophysical Observation", "SAO 257111"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.17174817),
        dec: Angle.Degrees(-72.06961971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86910"},
        {"Hipparcos Number", "HIP 48882"},
        {"Smithsonian Astrophysical Observation", "SAO 256673"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.54949991),
        dec: Angle.Degrees(-72.06471297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93325"},
        {"Hipparcos Number", "HIP 52507"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.04182432),
        dec: Angle.Degrees(-72.06448715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112767"},
        {"Hipparcos Number", "HIP 63500"},
        {"Smithsonian Astrophysical Observation", "SAO 256998"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.16878126),
        dec: Angle.Degrees(-72.06417664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133444"},
        {"Hipparcos Number", "HIP 74179"},
        {"Geneva Identification System", "GEN# +1.00133444"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.35228737),
        dec: Angle.Degrees(-72.06254544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136272"},
        {"Hipparcos Number", "HIP 75461"},
        {"Smithsonian Astrophysical Observation", "SAO 257273"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.23838227),
        dec: Angle.Degrees(-72.04632483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45081"},
        {"Hipparcos Number", "HIP 29964"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.61759254),
        dec: Angle.Degrees(-72.04502741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46291"},
        {"Hipparcos Number", "HIP 30582"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.41813865),
        dec: Angle.Degrees(-72.04302845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53073"},
        {"Hipparcos Number", "HIP 33427"},
        {"Geneva Identification System", "GEN# +1.00053073"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.26654937),
        dec: Angle.Degrees(-72.03657734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115439"},
        {"Hipparcos Number", "HIP 64994"},
        {"Fundamental Katalog 5th Edition", "FK5 3061"},
        {"Geneva Identification System", "GEN# +1.00115439"},
        {"Smithsonian Astrophysical Observation", "SAO 257028"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.82913970),
        dec: Angle.Degrees(-72.03547781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136615"},
        {"Hipparcos Number", "HIP 75604"},
        {"Geneva Identification System", "GEN# +1.00136615"},
        {"Smithsonian Astrophysical Observation", "SAO 257277"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.69690777),
        dec: Angle.Degrees(-72.02731052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -245.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24939"},
        {"Hipparcos Number", "HIP 18084"},
        {"Smithsonian Astrophysical Observation", "SAO 256039"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.98063166),
        dec: Angle.Degrees(-72.02713738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19890"},
        {"Hipparcos Number", "HIP 14468"},
        {"Smithsonian Astrophysical Observation", "SAO 255957"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.68034923),
        dec: Angle.Degrees(-72.02491830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108751"},
        {"Hipparcos Number", "HIP 61034"},
        {"Smithsonian Astrophysical Observation", "SAO 256949"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.63204373),
        dec: Angle.Degrees(-72.02292108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217422"},
        {"Hipparcos Number", "HIP 113763"},
        {"Smithsonian Astrophysical Observation", "SAO 258099"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.57626450),
        dec: Angle.Degrees(-72.01702733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147186"},
        {"Hipparcos Number", "HIP 80533"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.60874749),
        dec: Angle.Degrees(-72.01411035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61197"},
        {"Hipparcos Number", "HIP 36610"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.93226264),
        dec: Angle.Degrees(-72.00461890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19718"},
        {"Hipparcos Number", "HIP 14373"},
        {"Smithsonian Astrophysical Observation", "SAO 255952"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.35369435),
        dec: Angle.Degrees(-72.00414038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224230"},
        {"Hipparcos Number", "HIP 118009"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.04483528),
        dec: Angle.Degrees(-72.00193794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -259.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54797"},
        {"Hipparcos Number", "HIP 34035"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.90926115),
        dec: Angle.Degrees(-71.99936140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66410"},
        {"Hipparcos Number", "HIP 38877"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.33009615),
        dec: Angle.Degrees(-71.99821398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27775"},
        {"Hipparcos Number", "HIP 19963"},
        {"Geneva Identification System", "GEN# +1.00027775"},
        {"Smithsonian Astrophysical Observation", "SAO 256077"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.20686431),
        dec: Angle.Degrees(-71.99790629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98695"},
        {"Hipparcos Number", "HIP 55350"},
        {"Geneva Identification System", "GEN# +1.00098695"},
        {"Smithsonian Astrophysical Observation", "SAO 256828"},
        {"Wilson Evans Batten Catalogue", "WEB 9963"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.01734764),
        dec: Angle.Degrees(-71.99433341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162002"},
        {"Hipparcos Number", "HIP 87758"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.89517249),
        dec: Angle.Degrees(-71.99335023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67505"},
        {"Cincinnati Publication", "Ci 20 810"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.49430502),
        dec: Angle.Degrees(-71.99282729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -433.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91375"},
        {"Hipparcos Number", "HIP 51438"},
        {"Fundamental Katalog 5th Edition", "FK5 2842"},
        {"Geneva Identification System", "GEN# +1.00091375"},
        {"Renson", "Renson 26300"},
        {"Smithsonian Astrophysical Observation", "SAO 256722"},
        {"Wilson Evans Batten Catalogue", "WEB 9389"},
    },
    visualMagnitude: 4.72,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.58364619),
        dec: Angle.Degrees(-71.99271995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111315"},
        {"Hipparcos Number", "HIP 62608"},
        {"Geneva Identification System", "GEN# +1.00111315"},
        {"Smithsonian Astrophysical Observation", "SAO 256983"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.43728988),
        dec: Angle.Degrees(-71.98624542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66168"},
        {"Hipparcos Number", "HIP 38765"},
        {"Geneva Identification System", "GEN# +1.00066168"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.03822492),
        dec: Angle.Degrees(-71.98618570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 133.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44247"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.16088797),
        dec: Angle.Degrees(-71.98371783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 234.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208120"},
        {"Hipparcos Number", "HIP 108392"},
        {"Smithsonian Astrophysical Observation", "SAO 257984"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.40386430),
        dec: Angle.Degrees(-71.98164292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138320"},
        {"Hipparcos Number", "HIP 76433"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.16527855),
        dec: Angle.Degrees(-71.98155736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21211"},
        {"Hipparcos Number", "HIP 15529"},
        {"Smithsonian Astrophysical Observation", "SAO 255980"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.02169815),
        dec: Angle.Degrees(-71.98051340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79550"},
        {"Hipparcos Number", "HIP 45021"},
        {"Geneva Identification System", "GEN# +1.00079550"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.55157504),
        dec: Angle.Degrees(-71.97886653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1707"},
        {"Hipparcos Number", "HIP 1651"},
        {"Fundamental Katalog 5th Edition", "FK5 4037"},
        {"Geneva Identification System", "GEN# +1.00001707J"},
        {"Smithsonian Astrophysical Observation", "SAO 255660"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.18109246),
        dec: Angle.Degrees(-71.97802228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27867"},
        {"Hipparcos Number", "HIP 20015"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.39782030),
        dec: Angle.Degrees(-71.97752101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
