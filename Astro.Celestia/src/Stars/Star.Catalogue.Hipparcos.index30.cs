using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_30() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123889"},
        {"Hipparcos Number", "HIP 69291"},
        {"Geneva Identification System", "GEN# +1.00123889"},
        {"Smithsonian Astrophysical Observation", "SAO 205271"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.74844641),
        dec: Angle.Degrees(-36.26711067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116645"},
        {"Hipparcos Number", "HIP 65501"},
        {"Smithsonian Astrophysical Observation", "SAO 204454"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.37267812),
        dec: Angle.Degrees(-36.26565870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49890"},
    },
    visualMagnitude: 11.08,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.79992290),
        dec: Angle.Degrees(-36.26523343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93836"},
        {"Hipparcos Number", "HIP 52923"},
        {"Geneva Identification System", "GEN# +1.00093836"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.35550336),
        dec: Angle.Degrees(-36.26477139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133550"},
        {"Hipparcos Number", "HIP 73901"},
        {"Geneva Identification System", "GEN# +1.00133550"},
        {"Smithsonian Astrophysical Observation", "SAO 206292"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.55812576),
        dec: Angle.Degrees(-36.26458513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221609"},
        {"Hipparcos Number", "HIP 116293"},
        {"Geneva Identification System", "GEN# +1.00221609"},
        {"Smithsonian Astrophysical Observation", "SAO 214624"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.44201015),
        dec: Angle.Degrees(-36.26399408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113871"},
        {"Hipparcos Number", "HIP 64014"},
        {"Smithsonian Astrophysical Observation", "SAO 204136"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.75248442),
        dec: Angle.Degrees(-36.26370858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73268"},
        {"Hipparcos Number", "HIP 42190"},
        {"Smithsonian Astrophysical Observation", "SAO 199416"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.04257627),
        dec: Angle.Degrees(-36.26362295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39804"},
        {"Hipparcos Number", "HIP 27823"},
        {"Geneva Identification System", "GEN# +1.00039804"},
        {"Smithsonian Astrophysical Observation", "SAO 196283"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.31351733),
        dec: Angle.Degrees(-36.26359267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4723"},
        {"Hipparcos Number", "HIP 3811"},
        {"Fundamental Katalog 5th Edition", "FK5 4071"},
        {"Geneva Identification System", "GEN# +1.00004723"},
        {"Smithsonian Astrophysical Observation", "SAO 192759"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.25259822),
        dec: Angle.Degrees(-36.26356680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4986"},
        {"Smithsonian Astrophysical Observation", "SAO 192899"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.98277760),
        dec: Angle.Degrees(-36.26310694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85387"},
        {"Hipparcos Number", "HIP 48278"},
        {"Smithsonian Astrophysical Observation", "SAO 200795"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.63143811),
        dec: Angle.Degrees(-36.26190739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16094"},
        {"Geneva Identification System", "GEN# -0.03601303"},
        {"Smithsonian Astrophysical Observation", "SAO 194309"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.82790268),
        dec: Angle.Degrees(-36.26159501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 320345"},
        {"Hipparcos Number", "HIP 86434"},
        {"Smithsonian Astrophysical Observation", "SAO 209088"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.90742947),
        dec: Angle.Degrees(-36.26145119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91153"},
        {"Hipparcos Number", "HIP 51474"},
        {"Smithsonian Astrophysical Observation", "SAO 201458"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.71430393),
        dec: Angle.Degrees(-36.26119654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136422"},
        {"Hipparcos Number", "HIP 75177"},
        {"Fundamental Katalog 5th Edition", "FK5 566"},
        {"Geneva Identification System", "GEN# +1.00136422"},
        {"Smithsonian Astrophysical Observation", "SAO 206552"},
        {"Wilson Evans Batten Catalogue", "WEB 12825"},
    },
    visualMagnitude: 3.57,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.45181856),
        dec: Angle.Degrees(-36.26116729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211505"},
        {"Hipparcos Number", "HIP 110104"},
        {"Smithsonian Astrophysical Observation", "SAO 213712"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.55393848),
        dec: Angle.Degrees(-36.26099844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25105"},
        {"Hipparcos Number", "HIP 18538"},
        {"Geneva Identification System", "GEN# +1.00025105"},
        {"Smithsonian Astrophysical Observation", "SAO 194653"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.48118307),
        dec: Angle.Degrees(-36.26017005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47168"},
        {"Hipparcos Number", "HIP 31475"},
        {"Smithsonian Astrophysical Observation", "SAO 196982"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.89106732),
        dec: Angle.Degrees(-36.25925398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7954"},
        {"Hipparcos Number", "HIP 6117"},
        {"Geneva Identification System", "GEN# +1.00007954"},
        {"Smithsonian Astrophysical Observation", "SAO 193042"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.63728856),
        dec: Angle.Degrees(-36.25901360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136052"},
        {"Hipparcos Number", "HIP 75019"},
        {"Geneva Identification System", "GEN# +1.00136052"},
        {"Smithsonian Astrophysical Observation", "SAO 206525"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.94089175),
        dec: Angle.Degrees(-36.25827842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -211.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166242"},
        {"Hipparcos Number", "HIP 89123"},
        {"Smithsonian Astrophysical Observation", "SAO 209824"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.83966801),
        dec: Angle.Degrees(-36.25387051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112866"},
        {"Hipparcos Number", "HIP 63443"},
        {"Smithsonian Astrophysical Observation", "SAO 204014"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.01050578),
        dec: Angle.Degrees(-36.25301436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162459"},
        {"Hipparcos Number", "HIP 87509"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.18999738),
        dec: Angle.Degrees(-36.25299521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115027"},
        {"Hipparcos Number", "HIP 64640"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.73551803),
        dec: Angle.Degrees(-36.25286719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97737"},
        {"Hipparcos Number", "HIP 54884"},
        {"Smithsonian Astrophysical Observation", "SAO 202227"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.57178196),
        dec: Angle.Degrees(-36.25213458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119921"},
        {"Hipparcos Number", "HIP 67244"},
        {"Fundamental Katalog 5th Edition", "FK5 3091"},
        {"Geneva Identification System", "GEN# +1.00119921"},
        {"Smithsonian Astrophysical Observation", "SAO 204835"},
        {"Wilson Evans Batten Catalogue", "WEB 11832"},
    },
    visualMagnitude: 5.15,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.73483886),
        dec: Angle.Degrees(-36.25190473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15309"},
        {"Hipparcos Number", "HIP 11402"},
        {"Smithsonian Astrophysical Observation", "SAO 193713"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.72973105),
        dec: Angle.Degrees(-36.25156893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225101"},
        {"Hipparcos Number", "HIP 277"},
        {"Geneva Identification System", "GEN# +1.00225101"},
        {"Smithsonian Astrophysical Observation", "SAO 192342"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.85927886),
        dec: Angle.Degrees(-36.25120504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184125"},
        {"Hipparcos Number", "HIP 96259"},
        {"Smithsonian Astrophysical Observation", "SAO 211373"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.58344077),
        dec: Angle.Degrees(-36.24955283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134518"},
        {"Hipparcos Number", "HIP 74321"},
        {"Geneva Identification System", "GEN# +1.00134518"},
        {"Smithsonian Astrophysical Observation", "SAO 206375"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.86159379),
        dec: Angle.Degrees(-36.24914676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51188",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51188"},
        {"Smithsonian Astrophysical Observation", "SAO 201408"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.84172372),
        dec: Angle.Degrees(-36.24606269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11878"},
        {"Hipparcos Number", "HIP 9004"},
        {"Geneva Identification System", "GEN# +1.00011878"},
        {"Smithsonian Astrophysical Observation", "SAO 193387"},
        {"Wilson Evans Batten Catalogue", "WEB 1890"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.98447466),
        dec: Angle.Degrees(-36.24536086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28836"},
        {"Hipparcos Number", "HIP 21080"},
        {"Smithsonian Astrophysical Observation", "SAO 195091"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.77147606),
        dec: Angle.Degrees(-36.24339587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8130"},
        {"Hipparcos Number", "HIP 6257"},
        {"Geneva Identification System", "GEN# +1.00008130"},
        {"Smithsonian Astrophysical Observation", "SAO 193059"},
        {"Wilson Evans Batten Catalogue", "WEB 1398"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.06574294),
        dec: Angle.Degrees(-36.24286959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74323"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.86500401),
        dec: Angle.Degrees(-36.24221549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64028"},
        {"Hipparcos Number", "HIP 38268"},
        {"Celescope Catalog", "CEL 2058"},
        {"Geneva Identification System", "GEN# +1.00064028"},
        {"Smithsonian Astrophysical Observation", "SAO 198506"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.60840535),
        dec: Angle.Degrees(-36.24192603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11490"},
        {"Hipparcos Number", "HIP 8715"},
        {"Geneva Identification System", "GEN# +1.00011490"},
        {"Renson", "Renson 2920"},
        {"Smithsonian Astrophysical Observation", "SAO 193345"},
        {"Wilson Evans Batten Catalogue", "WEB 1839"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.04048594),
        dec: Angle.Degrees(-36.24157213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118728"},
        {"Hipparcos Number", "HIP 66629"},
        {"Smithsonian Astrophysical Observation", "SAO 204703"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.85751712),
        dec: Angle.Degrees(-36.24097457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53968"},
        {"Smithsonian Astrophysical Observation", "SAO 202027"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.60692866),
        dec: Angle.Degrees(-36.24077573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108851"},
        {"Hipparcos Number", "HIP 61040"},
        {"Smithsonian Astrophysical Observation", "SAO 203542"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.65721744),
        dec: Angle.Degrees(-36.23960209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2530"},
        {"Smithsonian Astrophysical Observation", "SAO 192592"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.02572703),
        dec: Angle.Degrees(-36.23934466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105987"},
        {"Smithsonian Astrophysical Observation", "SAO 213024"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.97923395),
        dec: Angle.Degrees(-36.23862270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5963"},
        {"Hipparcos Number", "HIP 4719"},
        {"Fundamental Katalog 5th Edition", "FK5 4093"},
        {"Smithsonian Astrophysical Observation", "SAO 192863"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.14708199),
        dec: Angle.Degrees(-36.23823579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2763"},
        {"Hipparcos Number", "HIP 2427"},
        {"Smithsonian Astrophysical Observation", "SAO 192580"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.73647639),
        dec: Angle.Degrees(-36.23819715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168838"},
        {"Hipparcos Number", "HIP 90124"},
        {"Geneva Identification System", "GEN# +1.00168838"},
        {"Smithsonian Astrophysical Observation", "SAO 210075"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.87008800),
        dec: Angle.Degrees(-36.23800004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137499"},
        {"Hipparcos Number", "HIP 75683"},
        {"Geneva Identification System", "GEN# +1.00137499"},
        {"Smithsonian Astrophysical Observation", "SAO 206664"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.92640885),
        dec: Angle.Degrees(-36.23690128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159785"},
        {"Hipparcos Number", "HIP 86309"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.53374960),
        dec: Angle.Degrees(-36.23684008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55742"},
        {"Hipparcos Number", "HIP 34838"},
        {"Geneva Identification System", "GEN# +1.00055742"},
        {"Smithsonian Astrophysical Observation", "SAO 197699"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.14441397),
        dec: Angle.Degrees(-36.23412772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6429"},
        {"Hipparcos Number", "HIP 5050"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.16361688),
        dec: Angle.Degrees(-36.23230941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46815"},
        {"Hipparcos Number", "HIP 31299"},
        {"Geneva Identification System", "GEN# +1.00046815"},
        {"Smithsonian Astrophysical Observation", "SAO 196945"},
        {"Wilson Evans Batten Catalogue", "WEB 6259"},
    },
    visualMagnitude: 5.42,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.45621385),
        dec: Angle.Degrees(-36.23226731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76026"},
        {"Smithsonian Astrophysical Observation", "SAO 206727"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.92132065),
        dec: Angle.Degrees(-36.23178803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144591"},
        {"Hipparcos Number", "HIP 79044"},
        {"Geneva Identification System", "GEN# +1.00144591"},
        {"Smithsonian Astrophysical Observation", "SAO 207362"},
        {"Wilson Evans Batten Catalogue", "WEB 13359"},
    },
    visualMagnitude: 6.75,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.01830039),
        dec: Angle.Degrees(-36.23176401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38805"},
        {"Hipparcos Number", "HIP 27259"},
        {"Smithsonian Astrophysical Observation", "SAO 196159"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.67537931),
        dec: Angle.Degrees(-36.23131066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128669"},
        {"Hipparcos Number", "HIP 71648"},
        {"Smithsonian Astrophysical Observation", "SAO 205805"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.81847348),
        dec: Angle.Degrees(-36.23082779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202742"},
        {"Hipparcos Number", "HIP 105239"},
        {"Geneva Identification System", "GEN# +1.00202742"},
        {"Smithsonian Astrophysical Observation", "SAO 212892"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.75413903),
        dec: Angle.Degrees(-36.23079760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168253"},
        {"Hipparcos Number", "HIP 89879"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.11086970),
        dec: Angle.Degrees(-36.23058611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50445"},
        {"Hipparcos Number", "HIP 32938"},
        {"Geneva Identification System", "GEN# +1.00050445"},
        {"Smithsonian Astrophysical Observation", "SAO 197291"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.92687429),
        dec: Angle.Degrees(-36.23012600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90543"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.12940346),
        dec: Angle.Degrees(-36.22979859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172002"},
        {"Hipparcos Number", "HIP 91470"},
        {"Smithsonian Astrophysical Observation", "SAO 210406"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.83142062),
        dec: Angle.Degrees(-36.22953230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195456"},
        {"Hipparcos Number", "HIP 101373"},
        {"Smithsonian Astrophysical Observation", "SAO 212218"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.19185939),
        dec: Angle.Degrees(-36.22878340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68843"},
        {"Hipparcos Number", "HIP 40218"},
        {"Celescope Catalog", "CEL 2239"},
        {"Geneva Identification System", "GEN# +1.00068843"},
        {"Smithsonian Astrophysical Observation", "SAO 198938"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.21131272),
        dec: Angle.Degrees(-36.22816911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181012"},
        {"Hipparcos Number", "HIP 95036"},
        {"Smithsonian Astrophysical Observation", "SAO 211181"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.05592176),
        dec: Angle.Degrees(-36.22770536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56376"},
        {"Hipparcos Number", "HIP 35075"},
        {"Celescope Catalog", "CEL 1718"},
        {"Geneva Identification System", "GEN# +1.00056376"},
        {"Smithsonian Astrophysical Observation", "SAO 197755"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.79938339),
        dec: Angle.Degrees(-36.22564200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97217"},
        {"Hipparcos Number", "HIP 54643"},
        {"Geneva Identification System", "GEN# +1.00097217"},
        {"Smithsonian Astrophysical Observation", "SAO 202172"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.75852890),
        dec: Angle.Degrees(-36.22552296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152403"},
        {"Hipparcos Number", "HIP 82735"},
        {"Smithsonian Astrophysical Observation", "SAO 208172"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.66210018),
        dec: Angle.Degrees(-36.22519994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114050"},
        {"Hipparcos Number", "HIP 64111"},
        {"Geneva Identification System", "GEN# +1.00114050"},
        {"Smithsonian Astrophysical Observation", "SAO 204156"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.09148730),
        dec: Angle.Degrees(-36.22412687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34836"},
        {"Smithsonian Astrophysical Observation", "SAO 197698"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)12, 34.2300),
        dec: Angle.DegreesMinutesSeconds((int)-36, (int)13, 19.200)
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
    primaryId: "HIP 34842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34842"},
        {"Geneva Identification System", "GEN# -0.03603425"},
        {"Smithsonian Astrophysical Observation", "SAO 197700"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.14815159),
        dec: Angle.Degrees(-36.22121791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106488"},
        {"Hipparcos Number", "HIP 59729"},
        {"Smithsonian Astrophysical Observation", "SAO 203275"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.74852602),
        dec: Angle.Degrees(-36.22084786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90781"},
        {"Hipparcos Number", "HIP 51259"},
        {"Geneva Identification System", "GEN# +1.00090781"},
        {"Smithsonian Astrophysical Observation", "SAO 201422"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.06069476),
        dec: Angle.Degrees(-36.22012216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66600"},
        {"Hipparcos Number", "HIP 39369"},
        {"Geneva Identification System", "GEN# +1.00066600"},
        {"Smithsonian Astrophysical Observation", "SAO 198741"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.72858202),
        dec: Angle.Degrees(-36.21976418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62686"},
        {"Hipparcos Number", "HIP 37678"},
        {"Smithsonian Astrophysical Observation", "SAO 198353"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.95205831),
        dec: Angle.Degrees(-36.21847807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36764"},
        {"Hipparcos Number", "HIP 25967"},
        {"Geneva Identification System", "GEN# +1.00036764"},
        {"Smithsonian Astrophysical Observation", "SAO 195941"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.09780915),
        dec: Angle.Degrees(-36.21786180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54773"},
        {"Hipparcos Number", "HIP 34461"},
        {"Geneva Identification System", "GEN# +1.00054773"},
        {"Smithsonian Astrophysical Observation", "SAO 197623"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.14853598),
        dec: Angle.Degrees(-36.21738149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49686"},
        {"Hipparcos Number", "HIP 32590"},
        {"Renson", "Renson 13460"},
        {"Smithsonian Astrophysical Observation", "SAO 197225"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.99221424),
        dec: Angle.Degrees(-36.21661453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94957"},
        {"Hipparcos Number", "HIP 53544"},
        {"Smithsonian Astrophysical Observation", "SAO 201937"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.30326370),
        dec: Angle.Degrees(-36.21598973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211484"},
        {"Hipparcos Number", "HIP 110087"},
        {"Smithsonian Astrophysical Observation", "SAO 213710"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.50702342),
        dec: Angle.Degrees(-36.21551929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91179"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.02375752),
        dec: Angle.Degrees(-36.21381613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219144"},
        {"Hipparcos Number", "HIP 114682"},
        {"Smithsonian Astrophysical Observation", "SAO 214394"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.48423441),
        dec: Angle.Degrees(-36.21251930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15913"},
        {"Smithsonian Astrophysical Observation", "SAO 194278"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.23090863),
        dec: Angle.Degrees(-36.21142808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202287"},
        {"Hipparcos Number", "HIP 104980"},
        {"Fundamental Katalog 5th Edition", "FK5 3696"},
        {"Geneva Identification System", "GEN# +1.00202287"},
        {"Smithsonian Astrophysical Observation", "SAO 212843"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.94484967),
        dec: Angle.Degrees(-36.21069394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30593"},
        {"Hipparcos Number", "HIP 22247"},
        {"Geneva Identification System", "GEN# +1.00030593"},
        {"Smithsonian Astrophysical Observation", "SAO 195295"},
        {"Wilson Evans Batten Catalogue", "WEB 4280"},
    },
    visualMagnitude: 7.66,
    bvColour: 2.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.82885250),
        dec: Angle.Degrees(-36.20934461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100395"},
        {"Hipparcos Number", "HIP 56326"},
        {"Geneva Identification System", "GEN# +1.00100395"},
        {"Smithsonian Astrophysical Observation", "SAO 202553"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.21472343),
        dec: Angle.Degrees(-36.20912746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14120"},
        {"Smithsonian Astrophysical Observation", "SAO 130250"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.52661899),
        dec: Angle.Degrees(-03.87328654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100586"},
        {"Hipparcos Number", "HIP 56443"},
        {"Smithsonian Astrophysical Observation", "SAO 202580"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.58914307),
        dec: Angle.Degrees(-36.20452451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107370"},
        {"Hipparcos Number", "HIP 60204"},
        {"Smithsonian Astrophysical Observation", "SAO 203366"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.18353001),
        dec: Angle.Degrees(-36.20380897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69620"},
        {"Hipparcos Number", "HIP 40519"},
        {"Celescope Catalog", "CEL 2302"},
        {"Geneva Identification System", "GEN# +1.00069620"},
        {"Smithsonian Astrophysical Observation", "SAO 199020"},
        {"Wilson Evans Batten Catalogue", "WEB 7885"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.10417569),
        dec: Angle.Degrees(-36.20261541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92791"},
        {"Hipparcos Number", "HIP 52376"},
        {"Smithsonian Astrophysical Observation", "SAO 201657"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.58244982),
        dec: Angle.Degrees(-36.20240300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149655"},
        {"Hipparcos Number", "HIP 81403"},
        {"Smithsonian Astrophysical Observation", "SAO 207850"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.38806246),
        dec: Angle.Degrees(-36.20225838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188113"},
        {"Hipparcos Number", "HIP 98008"},
        {"Smithsonian Astrophysical Observation", "SAO 211651"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.76026624),
        dec: Angle.Degrees(-36.20173501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5677"},
        {"Hipparcos Number", "HIP 4533"},
        {"Smithsonian Astrophysical Observation", "SAO 192841"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.51108596),
        dec: Angle.Degrees(-36.20019404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24160"},
        {"Hipparcos Number", "HIP 17874"},
        {"Fundamental Katalog 5th Edition", "FK5 143"},
        {"Geneva Identification System", "GEN# +1.00024160"},
        {"Smithsonian Astrophysical Observation", "SAO 194559"},
        {"Wilson Evans Batten Catalogue", "WEB 3441"},
    },
    visualMagnitude: 4.17,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.36367035),
        dec: Angle.Degrees(-36.20011250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137119"},
        {"Hipparcos Number", "HIP 75509"},
        {"Geneva Identification System", "GEN# +1.00137119"},
        {"Smithsonian Astrophysical Observation", "SAO 206625"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.37577913),
        dec: Angle.Degrees(-36.19935932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177386"},
        {"Hipparcos Number", "HIP 93783"},
        {"Smithsonian Astrophysical Observation", "SAO 210918"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.48640354),
        dec: Angle.Degrees(-36.19616252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198752"},
        {"Hipparcos Number", "HIP 103124"},
        {"Geneva Identification System", "GEN# +1.00198752"},
        {"Smithsonian Astrophysical Observation", "SAO 212523"},
        {"Wilson Evans Batten Catalogue", "WEB 18728"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.41608957),
        dec: Angle.Degrees(-36.19584467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58378"},
        {"Geneva Identification System", "GEN# -0.03507576"},
        {"Smithsonian Astrophysical Observation", "SAO 202993"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.56079204),
        dec: Angle.Degrees(-36.19555897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194727"},
        {"Hipparcos Number", "HIP 100990"},
        {"Smithsonian Astrophysical Observation", "SAO 212153"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.13482114),
        dec: Angle.Degrees(-36.19434887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31594"},
        {"Smithsonian Astrophysical Observation", "SAO 197002"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.17108730),
        dec: Angle.Degrees(-36.19146615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220606"},
        {"Hipparcos Number", "HIP 115615"},
        {"Smithsonian Astrophysical Observation", "SAO 214534"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.30954659),
        dec: Angle.Degrees(-36.18544977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142691"},
        {"Henry Draper 2", "HD 142692"},
        {"Hipparcos Number", "HIP 78142"},
        {"Geneva Identification System", "GEN# +1.00142691"},
        {"Smithsonian Astrophysical Observation", "SAO 207152"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.33888563),
        dec: Angle.Degrees(-36.18531380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7428"},
        {"Hipparcos Number", "HIP 5757"},
        {"Geneva Identification System", "GEN# +1.00007428"},
        {"Smithsonian Astrophysical Observation", "SAO 192996"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.47248017),
        dec: Angle.Degrees(-36.18509038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112865"},
        {"Hipparcos Number", "HIP 63445"},
        {"Smithsonian Astrophysical Observation", "SAO 204016"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.01270949),
        dec: Angle.Degrees(-36.18211693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67477"},
        {"Smithsonian Astrophysical Observation", "SAO 204880"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.41790555),
        dec: Angle.Degrees(-36.17958616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29675"},
        {"Hipparcos Number", "HIP 21652"},
        {"Smithsonian Astrophysical Observation", "SAO 195198"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.73503626),
        dec: Angle.Degrees(-36.17939931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25420"},
        {"Hipparcos Number", "HIP 18743"},
        {"Smithsonian Astrophysical Observation", "SAO 194693"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.22379717),
        dec: Angle.Degrees(-36.17807837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18941"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.90162925),
        dec: Angle.Degrees(-36.17801826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202398"},
        {"Hipparcos Number", "HIP 105044"},
        {"Geneva Identification System", "GEN# +1.00202398"},
        {"Smithsonian Astrophysical Observation", "SAO 212854"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.15803129),
        dec: Angle.Degrees(-36.17336738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74770"},
        {"Hipparcos Number", "HIP 42909"},
        {"Geneva Identification System", "GEN# +1.00074770"},
        {"Smithsonian Astrophysical Observation", "SAO 199570"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.16846092),
        dec: Angle.Degrees(-36.17184873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139522"},
        {"Hipparcos Number", "HIP 76720"},
        {"Geneva Identification System", "GEN# +1.00139522"},
        {"Smithsonian Astrophysical Observation", "SAO 206847"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.99560263),
        dec: Angle.Degrees(-36.17151743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34253"},
        {"Hipparcos Number", "HIP 24424"},
        {"Smithsonian Astrophysical Observation", "SAO 195682"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.61439335),
        dec: Angle.Degrees(-36.17088202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57331"},
        {"Hipparcos Number", "HIP 35460"},
        {"Celescope Catalog", "CEL 1780"},
        {"Geneva Identification System", "GEN# +1.00057331"},
        {"Smithsonian Astrophysical Observation", "SAO 197844"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.80299617),
        dec: Angle.Degrees(-36.16696903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178299"},
        {"Hipparcos Number", "HIP 94124"},
        {"Fundamental Katalog 5th Edition", "FK5 3528"},
        {"Geneva Identification System", "GEN# +1.00178299"},
        {"Smithsonian Astrophysical Observation", "SAO 210996"},
        {"Wilson Evans Batten Catalogue", "WEB 16390"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.40153674),
        dec: Angle.Degrees(-36.16477794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98993"},
        {"Hipparcos Number", "HIP 55588"},
        {"Fundamental Katalog 5th Edition", "FK5 2909"},
        {"Geneva Identification System", "GEN# +1.00098993"},
        {"Smithsonian Astrophysical Observation", "SAO 202391"},
        {"Wilson Evans Batten Catalogue", "WEB 9990"},
    },
    visualMagnitude: 5.00,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.80292630),
        dec: Angle.Degrees(-36.16476782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61008"},
        {"Hipparcos Number", "HIP 36940"},
        {"Celescope Catalog", "CEL 1944"},
        {"Geneva Identification System", "GEN# +1.00061008"},
        {"Smithsonian Astrophysical Observation", "SAO 198163"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.90509444),
        dec: Angle.Degrees(-36.16298428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1090"},
        {"Hipparcos Number", "HIP 1198"},
        {"Smithsonian Astrophysical Observation", "SAO 192420"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.74993489),
        dec: Angle.Degrees(-36.16042075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114245"},
        {"Hipparcos Number", "HIP 64222"},
        {"Smithsonian Astrophysical Observation", "SAO 204181"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.43177128),
        dec: Angle.Degrees(-36.16040063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112285"},
        {"Hipparcos Number", "HIP 63115"},
        {"Smithsonian Astrophysical Observation", "SAO 203944"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.98391629),
        dec: Angle.Degrees(-36.15947090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16482"},
        {"Hipparcos Number", "HIP 12242"},
        {"Geneva Identification System", "GEN# +1.00016482"},
        {"Smithsonian Astrophysical Observation", "SAO 193821"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.40870848),
        dec: Angle.Degrees(-36.15941020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70214"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.47879597),
        dec: Angle.Degrees(-36.15598744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -292.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60654"},
        {"Smithsonian Astrophysical Observation", "SAO 203459"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.47782213),
        dec: Angle.Degrees(-36.15400243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60098"},
        {"Hipparcos Number", "HIP 36582"},
        {"Celescope Catalog", "CEL 1909"},
        {"Geneva Identification System", "GEN# +1.00060098"},
        {"Smithsonian Astrophysical Observation", "SAO 198086"},
        {"Wilson Evans Batten Catalogue", "WEB 7273"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.85740224),
        dec: Angle.Degrees(-36.15327279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131460"},
        {"Hipparcos Number", "HIP 72977"},
        {"Geneva Identification System", "GEN# +1.00131460"},
        {"Renson", "Renson 37340"},
        {"Smithsonian Astrophysical Observation", "SAO 206081"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.70908270),
        dec: Angle.Degrees(-36.15323567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26758"},
        {"Hipparcos Number", "HIP 19639"},
        {"Geneva Identification System", "GEN# +1.00026758"},
        {"Smithsonian Astrophysical Observation", "SAO 194831"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.12857513),
        dec: Angle.Degrees(-36.15261121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13725"},
        {"Geneva Identification System", "GEN# -0.03601106"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.19785540),
        dec: Angle.Degrees(-36.15195895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -267.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15589"},
        {"Hipparcos Number", "HIP 11595"},
        {"Geneva Identification System", "GEN# +1.00015589"},
        {"Smithsonian Astrophysical Observation", "SAO 193739"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.36056262),
        dec: Angle.Degrees(-36.14953959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69770"},
        {"Smithsonian Astrophysical Observation", "SAO 205381"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.18261900),
        dec: Angle.Degrees(-36.14846374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129732"},
        {"Hipparcos Number", "HIP 72140"},
        {"Smithsonian Astrophysical Observation", "SAO 205904"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.33583692),
        dec: Angle.Degrees(-36.14774147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20869"},
        {"Hipparcos Number", "HIP 15569"},
        {"Smithsonian Astrophysical Observation", "SAO 194238"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.14671865),
        dec: Angle.Degrees(-36.14704834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147724"},
        {"Hipparcos Number", "HIP 80431"},
        {"Geneva Identification System", "GEN# +1.00147724"},
        {"Smithsonian Astrophysical Observation", "SAO 207646"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.26444644),
        dec: Angle.Degrees(-36.14407812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35173"},
        {"Geneva Identification System", "GEN# -0.00301821"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.04422475),
        dec: Angle.Degrees(-03.66578680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26773"},
        {"Hipparcos Number", "HIP 19646"},
        {"Smithsonian Astrophysical Observation", "SAO 194832"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.14185021),
        dec: Angle.Degrees(-36.14366432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26203"},
        {"Hipparcos Number", "HIP 19230"},
        {"Smithsonian Astrophysical Observation", "SAO 194776"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.83102263),
        dec: Angle.Degrees(-36.14330246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6908"},
        {"Hipparcos Number", "HIP 5402"},
        {"Geneva Identification System", "GEN# +1.00006908"},
        {"Smithsonian Astrophysical Observation", "SAO 192954"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.28512537),
        dec: Angle.Degrees(-36.14322337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56999"},
        {"Hipparcos Number", "HIP 35325"},
        {"Smithsonian Astrophysical Observation", "SAO 197812"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.44629638),
        dec: Angle.Degrees(-36.14306812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82930"},
        {"Hipparcos Number", "HIP 46945"},
        {"Smithsonian Astrophysical Observation", "SAO 200507"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.51374051),
        dec: Angle.Degrees(-36.14133268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215531"},
        {"Hipparcos Number", "HIP 112431"},
        {"Geneva Identification System", "GEN# +1.00215531"},
        {"Smithsonian Astrophysical Observation", "SAO 214068"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.60553022),
        dec: Angle.Degrees(-36.14070312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121261"},
        {"Hipparcos Number", "HIP 67964"},
        {"Geneva Identification System", "GEN# +1.00121261"},
        {"Smithsonian Astrophysical Observation", "SAO 204981"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.77101683),
        dec: Angle.Degrees(-36.13850787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47283"},
        {"Hipparcos Number", "HIP 31547"},
        {"Smithsonian Astrophysical Observation", "SAO 196990"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.05253230),
        dec: Angle.Degrees(-36.13823670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29202"},
        {"Smithsonian Astrophysical Observation", "SAO 196540"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.39062798),
        dec: Angle.Degrees(-36.13583614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23739"},
        {"Hipparcos Number", "HIP 17594"},
        {"Smithsonian Astrophysical Observation", "SAO 194516"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.53654135),
        dec: Angle.Degrees(-36.13543039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128974"},
        {"Hipparcos Number", "HIP 71783"},
        {"Geneva Identification System", "GEN# +1.00128974"},
        {"Renson", "Renson 36730"},
        {"Smithsonian Astrophysical Observation", "SAO 205823"},
    },
    visualMagnitude: 5.67,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.25588965),
        dec: Angle.Degrees(-36.13484330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38155"},
        {"Smithsonian Astrophysical Observation", "SAO 198479"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.28473981),
        dec: Angle.Degrees(-36.13426204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125746"},
        {"Hipparcos Number", "HIP 70242"},
        {"Smithsonian Astrophysical Observation", "SAO 205484"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.57910985),
        dec: Angle.Degrees(-36.13348611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208287"},
        {"Hipparcos Number", "HIP 108273"},
        {"Smithsonian Astrophysical Observation", "SAO 213409"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.02636395),
        dec: Angle.Degrees(-36.13087040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219859"},
        {"Hipparcos Number", "HIP 115143"},
        {"Smithsonian Astrophysical Observation", "SAO 214450"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.84994943),
        dec: Angle.Degrees(-36.12991912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199684"},
        {"Hipparcos Number", "HIP 103646"},
        {"Fundamental Katalog 5th Edition", "FK5 3674"},
        {"Geneva Identification System", "GEN# +1.00199684"},
        {"Smithsonian Astrophysical Observation", "SAO 212608"},
        {"Wilson Evans Batten Catalogue", "WEB 18861"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.99841027),
        dec: Angle.Degrees(-36.12949945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42390"},
        {"Hipparcos Number", "HIP 29143"},
        {"Geneva Identification System", "GEN# +1.00042390"},
        {"Smithsonian Astrophysical Observation", "SAO 196528"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.20586833),
        dec: Angle.Degrees(-36.12936399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176890"},
        {"Hipparcos Number", "HIP 93622"},
        {"Smithsonian Astrophysical Observation", "SAO 210868"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.98168580),
        dec: Angle.Degrees(-36.12783347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20707"},
        {"Hipparcos Number", "HIP 15432"},
        {"Geneva Identification System", "GEN# +1.00020707"},
        {"Smithsonian Astrophysical Observation", "SAO 194226"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.72049111),
        dec: Angle.Degrees(-36.12708238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184479"},
        {"Hipparcos Number", "HIP 96407"},
        {"Smithsonian Astrophysical Observation", "SAO 211397"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.00715522),
        dec: Angle.Degrees(-36.12433977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100894"},
        {"Hipparcos Number", "HIP 56621"},
        {"Geneva Identification System", "GEN# +1.00100894"},
        {"Smithsonian Astrophysical Observation", "SAO 202623"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.14747530),
        dec: Angle.Degrees(-36.12129181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197649"},
        {"Hipparcos Number", "HIP 102496"},
        {"Geneva Identification System", "GEN# +1.00197649"},
        {"Smithsonian Astrophysical Observation", "SAO 212417"},
        {"Wilson Evans Batten Catalogue", "WEB 18568"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.57740846),
        dec: Angle.Degrees(-36.12002528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132494"},
        {"Hipparcos Number", "HIP 73448"},
        {"Smithsonian Astrophysical Observation", "SAO 206196"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.13590584),
        dec: Angle.Degrees(-36.11856289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177034"},
        {"Hipparcos Number", "HIP 93668"},
        {"Smithsonian Astrophysical Observation", "SAO 210881"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.10903853),
        dec: Angle.Degrees(-36.11668328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113130"},
        {"Hipparcos Number", "HIP 63589"},
        {"Geneva Identification System", "GEN# +1.00113130"},
        {"Smithsonian Astrophysical Observation", "SAO 204051"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.46564644),
        dec: Angle.Degrees(-36.11477075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47619"},
        {"Hipparcos Number", "HIP 31690"},
        {"Geneva Identification System", "GEN# +1.00047619"},
        {"Smithsonian Astrophysical Observation", "SAO 197025"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.45916909),
        dec: Angle.Degrees(-36.11368586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97787"},
        {"Hipparcos Number", "HIP 54913"},
        {"Smithsonian Astrophysical Observation", "SAO 202235"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.67523560),
        dec: Angle.Degrees(-36.11299168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116078"},
        {"Hipparcos Number", "HIP 65208"},
        {"Geneva Identification System", "GEN# +1.00116078"},
        {"Smithsonian Astrophysical Observation", "SAO 204390"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.45753078),
        dec: Angle.Degrees(-36.11218043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25807"},
        {"Hipparcos Number", "HIP 18978"},
        {"Smithsonian Astrophysical Observation", "SAO 194728"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.99619309),
        dec: Angle.Degrees(-36.11110255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72551"},
        {"Hipparcos Number", "HIP 41862"},
        {"Celescope Catalog", "CEL 2615"},
        {"Geneva Identification System", "GEN# +1.00072551J"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.03626790),
        dec: Angle.Degrees(-36.10756606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13044"},
        {"Geneva Identification System", "GEN# -0.03601052"},
        {"Smithsonian Astrophysical Observation", "SAO 193917"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.90600270),
        dec: Angle.Degrees(-36.10753928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14791"},
        {"Hipparcos Number", "HIP 11038"},
        {"Smithsonian Astrophysical Observation", "SAO 193667"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.52918564),
        dec: Angle.Degrees(-36.10662347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10833"},
        {"Hipparcos Number", "HIP 8202"},
        {"Geneva Identification System", "GEN# +1.00010833"},
        {"Smithsonian Astrophysical Observation", "SAO 193289"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.36196004),
        dec: Angle.Degrees(-36.10655550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145538"},
        {"Hipparcos Number", "HIP 79464"},
        {"Geneva Identification System", "GEN# +1.00145538"},
        {"Smithsonian Astrophysical Observation", "SAO 207456"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.23724607),
        dec: Angle.Degrees(-36.10625010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23958"},
        {"Hipparcos Number", "HIP 17734"},
        {"Geneva Identification System", "GEN# +1.00023958"},
        {"Smithsonian Astrophysical Observation", "SAO 194537"},
        {"Wilson Evans Batten Catalogue", "WEB 3390"},
    },
    visualMagnitude: 6.21,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.95668288),
        dec: Angle.Degrees(-36.10582931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79112"},
        {"Hipparcos Number", "HIP 45083"},
        {"Smithsonian Astrophysical Observation", "SAO 200073"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.75561478),
        dec: Angle.Degrees(-36.10496236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148732"},
        {"Hipparcos Number", "HIP 80938"},
        {"Smithsonian Astrophysical Observation", "SAO 207738"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.90813392),
        dec: Angle.Degrees(-36.10297945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115644"},
        {"Hipparcos Number", "HIP 64978"},
        {"Smithsonian Astrophysical Observation", "SAO 204350"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.76828805),
        dec: Angle.Degrees(-36.10261953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182665"},
        {"Hipparcos Number", "HIP 95639"},
        {"Smithsonian Astrophysical Observation", "SAO 211275"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.81120421),
        dec: Angle.Degrees(-36.10071873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25536"},
        {"Hipparcos Number", "HIP 18819"},
        {"Smithsonian Astrophysical Observation", "SAO 194708"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.49300641),
        dec: Angle.Degrees(-36.09940572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191408"},
        {"Hipparcos Number", "HIP 99461"},
        {"Cincinnati Publication", "Ci 20 1194"},
        {"Geneva Identification System", "GEN# +1.00191408"},
        {"Smithsonian Astrophysical Observation", "SAO 211885"},
        {"Wilson Evans Batten Catalogue", "WEB 17772"},
    },
    visualMagnitude: 5.32,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.79836763),
        dec: Angle.Degrees(-36.09738423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 456.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1574.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172198"},
        {"Hipparcos Number", "HIP 91573"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.10173336),
        dec: Angle.Degrees(-36.09649426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176616"},
        {"Hipparcos Number", "HIP 93515"},
        {"Smithsonian Astrophysical Observation", "SAO 210853"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.67777070),
        dec: Angle.Degrees(-36.09646548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83441"},
        {"Hipparcos Number", "HIP 47224"},
        {"Geneva Identification System", "GEN# +1.00083441"},
        {"Smithsonian Astrophysical Observation", "SAO 200573"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.36841333),
        dec: Angle.Degrees(-36.09599061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78224"},
        {"Hipparcos Number", "HIP 44656"},
        {"Smithsonian Astrophysical Observation", "SAO 199972"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.48743968),
        dec: Angle.Degrees(-36.09588831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102394"},
    },
    visualMagnitude: 10.43,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.23821628),
        dec: Angle.Degrees(-03.55813988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97113"},
        {"Hipparcos Number", "HIP 54593"},
        {"Smithsonian Astrophysical Observation", "SAO 202161"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.58928569),
        dec: Angle.Degrees(-36.09520859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133513"},
        {"Hipparcos Number", "HIP 73879"},
        {"Smithsonian Astrophysical Observation", "SAO 206288"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.50582514),
        dec: Angle.Degrees(-36.09400081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106922"},
        {"Hipparcos Number", "HIP 59950"},
        {"Geneva Identification System", "GEN# +1.00106922J"},
        {"Smithsonian Astrophysical Observation", "SAO 203319"},
        {"Wilson Evans Batten Catalogue", "WEB 10651"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.44706163),
        dec: Angle.Degrees(-36.09396124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63898"},
        {"Hipparcos Number", "HIP 38222"},
        {"Smithsonian Astrophysical Observation", "SAO 198492"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.45954039),
        dec: Angle.Degrees(-36.09350875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27392"},
        {"Hipparcos Number", "HIP 20043"},
        {"Smithsonian Astrophysical Observation", "SAO 194904"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.47698491),
        dec: Angle.Degrees(-36.09268007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24150"},
        {"Hipparcos Number", "HIP 17861"},
        {"Smithsonian Astrophysical Observation", "SAO 194557"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.33934761),
        dec: Angle.Degrees(-36.09248710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134837"},
        {"Hipparcos Number", "HIP 74479"},
        {"Geneva Identification System", "GEN# +1.00134837"},
        {"Smithsonian Astrophysical Observation", "SAO 206418"},
        {"Wilson Evans Batten Catalogue", "WEB 12706"},
    },
    visualMagnitude: 6.09,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.28199335),
        dec: Angle.Degrees(-36.09136973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99062"},
        {"Hipparcos Number", "HIP 55629"},
        {"Smithsonian Astrophysical Observation", "SAO 202399"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.94810845),
        dec: Angle.Degrees(-36.08921380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47230"},
        {"Hipparcos Number", "HIP 31509"},
        {"Geneva Identification System", "GEN# +1.00047230J"},
        {"Smithsonian Astrophysical Observation", "SAO 196987"},
        {"Wilson Evans Batten Catalogue", "WEB 6306"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.97530182),
        dec: Angle.Degrees(-36.08845467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143215"},
        {"Hipparcos Number", "HIP 78416"},
        {"Smithsonian Astrophysical Observation", "SAO 207220"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.13059204),
        dec: Angle.Degrees(-36.08785277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55325"},
    },
    visualMagnitude: 12.08,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.94060756),
        dec: Angle.Degrees(-36.08769026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156369"},
        {"Hipparcos Number", "HIP 84673"},
        {"Geneva Identification System", "GEN# +1.00156369"},
        {"Smithsonian Astrophysical Observation", "SAO 208663"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.65968597),
        dec: Angle.Degrees(-36.08692750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190"},
        {"Hipparcos Number", "HIP 546"},
        {"Geneva Identification System", "GEN# +1.00000190"},
        {"Smithsonian Astrophysical Observation", "SAO 192358"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.66184341),
        dec: Angle.Degrees(-36.08467578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147684"},
        {"Hipparcos Number", "HIP 80416"},
        {"Smithsonian Astrophysical Observation", "SAO 207642"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.20270209),
        dec: Angle.Degrees(-36.08415080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103823"},
        {"Hipparcos Number", "HIP 58283"},
        {"Smithsonian Astrophysical Observation", "SAO 202975"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.30177282),
        dec: Angle.Degrees(-36.08262982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112662"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.24265535),
        dec: Angle.Degrees(-03.33870776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 254.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22607"},
        {"Hipparcos Number", "HIP 16855"},
        {"Smithsonian Astrophysical Observation", "SAO 194401"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.22793986),
        dec: Angle.Degrees(-36.08162598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189221"},
        {"Hipparcos Number", "HIP 98475"},
        {"Smithsonian Astrophysical Observation", "SAO 211722"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.09032597),
        dec: Angle.Degrees(-36.08066823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58234"},
        {"Hipparcos Number", "HIP 35819"},
        {"Smithsonian Astrophysical Observation", "SAO 197930"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.80965667),
        dec: Angle.Degrees(-36.07932276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154385"},
        {"Hipparcos Number", "HIP 83721"},
        {"Geneva Identification System", "GEN# +1.00154385"},
        {"Smithsonian Astrophysical Observation", "SAO 208417"},
        {"Wilson Evans Batten Catalogue", "WEB 14156"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.67076949),
        dec: Angle.Degrees(-36.07790541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158564"},
        {"Hipparcos Number", "HIP 85773"},
        {"Smithsonian Astrophysical Observation", "SAO 208912"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.89463219),
        dec: Angle.Degrees(-36.07694203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9028"},
        {"Hipparcos Number", "HIP 6865"},
        {"Smithsonian Astrophysical Observation", "SAO 193130"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.08496506),
        dec: Angle.Degrees(-36.07663093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149829"},
        {"Hipparcos Number", "HIP 81492"},
        {"Geneva Identification System", "GEN# +1.00149829"},
        {"Smithsonian Astrophysical Observation", "SAO 207872"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.67237638),
        dec: Angle.Degrees(-36.07644038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38415"},
        {"Hipparcos Number", "HIP 27031"},
        {"Smithsonian Astrophysical Observation", "SAO 196123"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.99938024),
        dec: Angle.Degrees(-36.07513663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63399"},
        {"Hipparcos Number", "HIP 37996"},
        {"Smithsonian Astrophysical Observation", "SAO 198437"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.81091375),
        dec: Angle.Degrees(-36.07366604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218351"},
        {"Hipparcos Number", "HIP 114196"},
        {"Smithsonian Astrophysical Observation", "SAO 214326"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.89718278),
        dec: Angle.Degrees(-36.07155444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45114"},
        {"Hipparcos Number", "HIP 30429"},
        {"Smithsonian Astrophysical Observation", "SAO 196770"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.96880097),
        dec: Angle.Degrees(-36.07142937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74103"},
        {"Hipparcos Number", "HIP 42572"},
        {"Smithsonian Astrophysical Observation", "SAO 199497"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.16560847),
        dec: Angle.Degrees(-36.06844893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117970"},
        {"Smithsonian Astrophysical Observation", "SAO 214864"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.91921132),
        dec: Angle.Degrees(-36.06761344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69904"},
        {"Hipparcos Number", "HIP 40639"},
        {"Smithsonian Astrophysical Observation", "SAO 199051"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.44230214),
        dec: Angle.Degrees(-36.06759473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23543"},
        {"Smithsonian Astrophysical Observation", "SAO 195528"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.94058103),
        dec: Angle.Degrees(-36.06658757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132041"},
        {"Hipparcos Number", "HIP 73250"},
        {"Geneva Identification System", "GEN# +1.00132041"},
        {"Smithsonian Astrophysical Observation", "SAO 206143"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.55865850),
        dec: Angle.Degrees(-36.06432487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99322"},
        {"Hipparcos Number", "HIP 55756"},
        {"Geneva Identification System", "GEN# +1.00099322"},
        {"Smithsonian Astrophysical Observation", "SAO 202428"},
        {"Wilson Evans Batten Catalogue", "WEB 10018"},
    },
    visualMagnitude: 5.21,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.37304571),
        dec: Angle.Degrees(-36.06310533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62781"},
        {"Hipparcos Number", "HIP 37710"},
        {"Celescope Catalog", "CEL 2006"},
        {"Geneva Identification System", "GEN# +1.00062781"},
        {"Smithsonian Astrophysical Observation", "SAO 198366"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.04059732),
        dec: Angle.Degrees(-36.06271326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64380"},
        {"Hipparcos Number", "HIP 38418"},
        {"Smithsonian Astrophysical Observation", "SAO 198539"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.05854029),
        dec: Angle.Degrees(-36.06231011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208033"},
        {"Hipparcos Number", "HIP 108123"},
        {"Smithsonian Astrophysical Observation", "SAO 213378"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.57940290),
        dec: Angle.Degrees(-36.06153067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13778"},
        {"Hipparcos Number", "HIP 10347"},
        {"Smithsonian Astrophysical Observation", "SAO 193580"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.32429849),
        dec: Angle.Degrees(-36.06108748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149256"},
        {"Hipparcos Number", "HIP 81197"},
        {"Smithsonian Astrophysical Observation", "SAO 207789"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.77834519),
        dec: Angle.Degrees(-36.06095133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -292.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189874"},
        {"Hipparcos Number", "HIP 98781"},
        {"Smithsonian Astrophysical Observation", "SAO 211772"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.92640147),
        dec: Angle.Degrees(-36.05967954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209083"},
        {"Hipparcos Number", "HIP 108730"},
        {"Geneva Identification System", "GEN# +1.00209083"},
        {"Smithsonian Astrophysical Observation", "SAO 213479"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.37910270),
        dec: Angle.Degrees(-36.05839932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12040"},
        {"Hipparcos Number", "HIP 9112"},
        {"Geneva Identification System", "GEN# +1.00012040"},
        {"Smithsonian Astrophysical Observation", "SAO 193408"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.35098184),
        dec: Angle.Degrees(-36.05747787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171574"},
        {"Hipparcos Number", "HIP 91284"},
        {"Smithsonian Astrophysical Observation", "SAO 210369"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.29694929),
        dec: Angle.Degrees(-36.05712070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76423"},
        {"Hipparcos Number", "HIP 43761"},
        {"Smithsonian Astrophysical Observation", "SAO 199778"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.71819200),
        dec: Angle.Degrees(-36.05690433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86551"},
        {"Hipparcos Number", "HIP 48892"},
        {"Smithsonian Astrophysical Observation", "SAO 200917"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.59024111),
        dec: Angle.Degrees(-36.05665860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210142"},
        {"Hipparcos Number", "HIP 109334"},
        {"Smithsonian Astrophysical Observation", "SAO 213589"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.24897876),
        dec: Angle.Degrees(-36.05606633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199845"},
        {"Hipparcos Number", "HIP 103705"},
        {"Smithsonian Astrophysical Observation", "SAO 212623"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.22142158),
        dec: Angle.Degrees(-36.05411955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38728"},
    },
    visualMagnitude: 10.31,
    bvColour: 2.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.93366193),
        dec: Angle.Degrees(-03.19822341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16321"},
        {"Geneva Identification System", "GEN# -0.03601326"},
    },
    visualMagnitude: 11.18,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.59301867),
        dec: Angle.Degrees(-36.05373440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26682"},
        {"Hipparcos Number", "HIP 19584"},
        {"Smithsonian Astrophysical Observation", "SAO 194819"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.95501703),
        dec: Angle.Degrees(-36.05081744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62578"},
        {"Hipparcos Number", "HIP 37623"},
        {"Celescope Catalog", "CEL 1995"},
        {"Geneva Identification System", "GEN# +1.00062578"},
        {"Smithsonian Astrophysical Observation", "SAO 198343"},
        {"Wilson Evans Batten Catalogue", "WEB 7439"},
    },
    visualMagnitude: 5.60,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.79999230),
        dec: Angle.Degrees(-36.05012400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10247"},
        {"Hipparcos Number", "HIP 7731"},
        {"Smithsonian Astrophysical Observation", "SAO 193233"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.88449077),
        dec: Angle.Degrees(-36.04981143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 319539"},
        {"Hipparcos Number", "HIP 84124"},
        {"Smithsonian Astrophysical Observation", "SAO 208514"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.97360041),
        dec: Angle.Degrees(-36.04743636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86819"},
        {"Hipparcos Number", "HIP 49024"},
        {"Geneva Identification System", "GEN# +1.00086819"},
        {"Smithsonian Astrophysical Observation", "SAO 200949"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.02531470),
        dec: Angle.Degrees(-36.04337922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19679"},
        {"Hipparcos Number", "HIP 14624"},
        {"Smithsonian Astrophysical Observation", "SAO 194112"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.21906569),
        dec: Angle.Degrees(-36.04327996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224621"},
        {"Hipparcos Number", "HIP 118266"},
        {"Geneva Identification System", "GEN# +1.00224621"},
        {"Smithsonian Astrophysical Observation", "SAO 214897"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.82220454),
        dec: Angle.Degrees(-36.04317343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130467"},
        {"Hipparcos Number", "HIP 72506"},
        {"Smithsonian Astrophysical Observation", "SAO 205981"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.36979973),
        dec: Angle.Degrees(-36.04298379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191958"},
        {"Hipparcos Number", "HIP 99694"},
        {"Smithsonian Astrophysical Observation", "SAO 211917"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.45732042),
        dec: Angle.Degrees(-36.04149807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184988"},
        {"Hipparcos Number", "HIP 96606"},
        {"Smithsonian Astrophysical Observation", "SAO 211430"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.60455095),
        dec: Angle.Degrees(-36.03661851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52705"},
        {"Hipparcos Number", "HIP 33751"},
        {"Geneva Identification System", "GEN# +1.00052705"},
        {"Smithsonian Astrophysical Observation", "SAO 197474"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.16294703),
        dec: Angle.Degrees(-36.03566285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83264"},
        {"Hipparcos Number", "HIP 47129"},
        {"Smithsonian Astrophysical Observation", "SAO 200541"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.05236551),
        dec: Angle.Degrees(-36.03426411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66902"},
        {"Smithsonian Astrophysical Observation", "SAO 204755"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.65010678),
        dec: Angle.Degrees(-36.03425085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223641"},
        {"Hipparcos Number", "HIP 117627"},
        {"Geneva Identification System", "GEN# +1.00223641"},
        {"Smithsonian Astrophysical Observation", "SAO 214816"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.83740038),
        dec: Angle.Degrees(-36.03403165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -217.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191151"},
        {"Hipparcos Number", "HIP 99345"},
        {"Smithsonian Astrophysical Observation", "SAO 211868"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.45479499),
        dec: Angle.Degrees(-36.03382137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66934"},
        {"Hipparcos Number", "HIP 39498"},
        {"Smithsonian Astrophysical Observation", "SAO 198767"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.10408302),
        dec: Angle.Degrees(-36.03344302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196638"},
        {"Hipparcos Number", "HIP 101968"},
        {"Geneva Identification System", "GEN# +1.00196638"},
        {"Smithsonian Astrophysical Observation", "SAO 212321"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.96845565),
        dec: Angle.Degrees(-36.03342990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4486"},
        {"Hipparcos Number", "HIP 3643"},
        {"Smithsonian Astrophysical Observation", "SAO 192732"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.66149212),
        dec: Angle.Degrees(-36.03341734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111631"},
        {"Smithsonian Astrophysical Observation", "SAO 213954"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.21680318),
        dec: Angle.Degrees(-36.03153694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157401"},
        {"Hipparcos Number", "HIP 85192"},
        {"Smithsonian Astrophysical Observation", "SAO 208776"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.15149167),
        dec: Angle.Degrees(-36.03129718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132396"},
        {"Hipparcos Number", "HIP 73398"},
        {"Smithsonian Astrophysical Observation", "SAO 206185"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.00146357),
        dec: Angle.Degrees(-36.03047638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107336"},
        {"Hipparcos Number", "HIP 60191"},
        {"Smithsonian Astrophysical Observation", "SAO 203362"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.14390981),
        dec: Angle.Degrees(-36.02946183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83994"},
        {"Hipparcos Number", "HIP 47511"},
        {"Smithsonian Astrophysical Observation", "SAO 200631"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.29277362),
        dec: Angle.Degrees(-36.02878548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32093"},
        {"Smithsonian Astrophysical Observation", "SAO 197105"},
    },
    visualMagnitude: 9.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.56999560),
        dec: Angle.Degrees(-36.02861964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104023"},
    },
    visualMagnitude: 12.03,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.13775919),
        dec: Angle.Degrees(-36.02858138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 304.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82521"},
    },
    visualMagnitude: 12.04,
    bvColour: 2.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.99128192),
        dec: Angle.Degrees(-36.02667348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -253.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3110"},
        {"Hipparcos Number", "HIP 2692"},
        {"Smithsonian Astrophysical Observation", "SAO 192616"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.54107418),
        dec: Angle.Degrees(-36.02572064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4053"},
        {"Hipparcos Number", "HIP 3344"},
        {"Fundamental Katalog 5th Edition", "FK5 1016"},
        {"Geneva Identification System", "GEN# +1.00004053"},
        {"Smithsonian Astrophysical Observation", "SAO 192689"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.65638271),
        dec: Angle.Degrees(-36.02218358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122089"},
        {"Hipparcos Number", "HIP 68423"},
        {"Geneva Identification System", "GEN# +1.00122089"},
        {"Smithsonian Astrophysical Observation", "SAO 205081"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.10528332),
        dec: Angle.Degrees(-36.02107084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165185"},
        {"Hipparcos Number", "HIP 88694"},
        {"Geneva Identification System", "GEN# +1.00165185"},
        {"Smithsonian Astrophysical Observation", "SAO 209710"},
        {"Wilson Evans Batten Catalogue", "WEB 15027"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.59851342),
        dec: Angle.Degrees(-36.01980798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82641"},
        {"Hipparcos Number", "HIP 46807"},
        {"Smithsonian Astrophysical Observation", "SAO 200475"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.06911408),
        dec: Angle.Degrees(-36.01842531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123001"},
        {"Hipparcos Number", "HIP 68848"},
        {"Smithsonian Astrophysical Observation", "SAO 205172"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.47343967),
        dec: Angle.Degrees(-36.01721630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136853"},
        {"Hipparcos Number", "HIP 75372"},
        {"Smithsonian Astrophysical Observation", "SAO 206586"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.02802082),
        dec: Angle.Degrees(-36.01694036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169679"},
        {"Hipparcos Number", "HIP 90452"},
        {"Geneva Identification System", "GEN# +1.00169679"},
        {"Smithsonian Astrophysical Observation", "SAO 210170"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.84670477),
        dec: Angle.Degrees(-36.01595420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18416"},
        {"Hipparcos Number", "HIP 13699"},
        {"Smithsonian Astrophysical Observation", "SAO 193992"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.10049405),
        dec: Angle.Degrees(-36.01586651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225297"},
        {"Hipparcos Number", "HIP 413"},
        {"Geneva Identification System", "GEN# +1.00225297"},
        {"Smithsonian Astrophysical Observation", "SAO 192349"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.26034142),
        dec: Angle.Degrees(-36.01527326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21645"},
        {"Hipparcos Number", "HIP 16167"},
        {"Geneva Identification System", "GEN# +1.00021645"},
        {"Smithsonian Astrophysical Observation", "SAO 194319"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.08329869),
        dec: Angle.Degrees(-36.01314969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79482"},
        {"Geneva Identification System", "GEN# -0.03510818"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.30592774),
        dec: Angle.Degrees(-36.01217157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110546"},
        {"Hipparcos Number", "HIP 62064"},
        {"Smithsonian Astrophysical Observation", "SAO 203744"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.80550627),
        dec: Angle.Degrees(-36.01111598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139396"},
        {"Hipparcos Number", "HIP 76652"},
        {"Smithsonian Astrophysical Observation", "SAO 206835"},
    },
    visualMagnitude: 9.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.79827509),
        dec: Angle.Degrees(-36.01068833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163482"},
        {"Hipparcos Number", "HIP 87945"},
        {"Smithsonian Astrophysical Observation", "SAO 209525"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.48644875),
        dec: Angle.Degrees(-36.00791079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47947"},
        {"Hipparcos Number", "HIP 31837"},
        {"Smithsonian Astrophysical Observation", "SAO 197052"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.84154153),
        dec: Angle.Degrees(-36.00750360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213205"},
        {"Hipparcos Number", "HIP 111093"},
        {"Smithsonian Astrophysical Observation", "SAO 213870"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.59398054),
        dec: Angle.Degrees(-36.00723308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190082"},
        {"Hipparcos Number", "HIP 98870"},
        {"Smithsonian Astrophysical Observation", "SAO 211786"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.16742771),
        dec: Angle.Degrees(-36.00583047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9893"},
        {"Hipparcos Number", "HIP 7451"},
        {"Smithsonian Astrophysical Observation", "SAO 193198"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.99571724),
        dec: Angle.Degrees(-36.00458033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30718"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.81094052),
        dec: Angle.Degrees(-36.00324582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182985"},
        {"Hipparcos Number", "HIP 95774"},
        {"Smithsonian Astrophysical Observation", "SAO 211295"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.19528124),
        dec: Angle.Degrees(-36.00025931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207822"},
        {"Hipparcos Number", "HIP 107992"},
        {"Geneva Identification System", "GEN# +1.00207822"},
        {"Smithsonian Astrophysical Observation", "SAO 213357"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.18089349),
        dec: Angle.Degrees(-36.00006812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114474"},
        {"Smithsonian Astrophysical Observation", "SAO 214368"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.74780762),
        dec: Angle.Degrees(-35.99924849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204566"},
        {"Hipparcos Number", "HIP 106188"},
        {"Smithsonian Astrophysical Observation", "SAO 213051"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.62805932),
        dec: Angle.Degrees(-35.99767541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41387"},
        {"Renson", "Renson 19740"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.65815729),
        dec: Angle.Degrees(-35.99437862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216088"},
        {"Hipparcos Number", "HIP 112788"},
        {"Geneva Identification System", "GEN# +1.00216088"},
        {"Smithsonian Astrophysical Observation", "SAO 214125"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.60875473),
        dec: Angle.Degrees(-35.99331874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103393"},
        {"Hipparcos Number", "HIP 58039"},
        {"Smithsonian Astrophysical Observation", "SAO 202921"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.54259523),
        dec: Angle.Degrees(-35.99212476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169236"},
        {"Hipparcos Number", "HIP 90290"},
        {"Geneva Identification System", "GEN# +1.00169236"},
        {"Smithsonian Astrophysical Observation", "SAO 210119"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.34040865),
        dec: Angle.Degrees(-35.99203084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66019"},
        {"Hipparcos Number", "HIP 39123"},
        {"Renson", "Renson 18150"},
        {"Smithsonian Astrophysical Observation", "SAO 198684"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.06178123),
        dec: Angle.Degrees(-35.99152203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54980"},
        {"Hipparcos Number", "HIP 34555"},
        {"Geneva Identification System", "GEN# +1.00054980"},
        {"Smithsonian Astrophysical Observation", "SAO 197643"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.37760150),
        dec: Angle.Degrees(-35.99091547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31260"},
        {"Hipparcos Number", "HIP 22681"},
        {"Smithsonian Astrophysical Observation", "SAO 195376"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.16950219),
        dec: Angle.Degrees(-35.99084208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24111"},
        {"Hipparcos Number", "HIP 17843"},
        {"Smithsonian Astrophysical Observation", "SAO 194555"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.26889936),
        dec: Angle.Degrees(-35.99027701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120658"},
        {"Hipparcos Number", "HIP 67632"},
        {"Smithsonian Astrophysical Observation", "SAO 204910"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.86306922),
        dec: Angle.Degrees(-35.98895136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102608"},
        {"Hipparcos Number", "HIP 57607"},
        {"Smithsonian Astrophysical Observation", "SAO 202831"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.16346115),
        dec: Angle.Degrees(-35.98690213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216483"},
        {"Hipparcos Number", "HIP 113058"},
        {"Smithsonian Astrophysical Observation", "SAO 214169"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.44014805),
        dec: Angle.Degrees(-35.98682595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187953"},
        {"Hipparcos Number", "HIP 97929"},
        {"Smithsonian Astrophysical Observation", "SAO 211636"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.53662454),
        dec: Angle.Degrees(-35.98624237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36110"},
        {"Hipparcos Number", "HIP 25545"},
        {"Smithsonian Astrophysical Observation", "SAO 195874"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.91546084),
        dec: Angle.Degrees(-35.98515186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98621"},
        {"Hipparcos Number", "HIP 55396"},
        {"Smithsonian Astrophysical Observation", "SAO 202341"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.14274108),
        dec: Angle.Degrees(-35.98352593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14247"},
        {"Hipparcos Number", "HIP 10673"},
        {"Fundamental Katalog 5th Edition", "FK5 1062"},
        {"Geneva Identification System", "GEN# +1.00014247"},
        {"Smithsonian Astrophysical Observation", "SAO 193622"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.33232779),
        dec: Angle.Degrees(-35.98307115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 164.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185928"},
        {"Hipparcos Number", "HIP 97007"},
        {"Smithsonian Astrophysical Observation", "SAO 211494"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.74727177),
        dec: Angle.Degrees(-35.98191961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161666"},
        {"Hipparcos Number", "HIP 87155"},
        {"Geneva Identification System", "GEN# +1.00161666"},
        {"Smithsonian Astrophysical Observation", "SAO 209276"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.09356637),
        dec: Angle.Degrees(-35.97957427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210321"},
        {"Hipparcos Number", "HIP 109433"},
        {"Geneva Identification System", "GEN# +1.00210321"},
        {"Smithsonian Astrophysical Observation", "SAO 213603"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.56245255),
        dec: Angle.Degrees(-35.97840025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222575"},
        {"Hipparcos Number", "HIP 116910"},
        {"Smithsonian Astrophysical Observation", "SAO 214717"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.47600373),
        dec: Angle.Degrees(-35.97756435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34266"},
        {"Hipparcos Number", "HIP 24426"},
        {"Geneva Identification System", "GEN# +1.00034266"},
        {"Smithsonian Astrophysical Observation", "SAO 195683"},
        {"Wilson Evans Batten Catalogue", "WEB 4732"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.62015802),
        dec: Angle.Degrees(-35.97703069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223526"},
        {"Hipparcos Number", "HIP 117549"},
        {"Smithsonian Astrophysical Observation", "SAO 214805"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.58999915),
        dec: Angle.Degrees(-35.97612084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172076"},
        {"Hipparcos Number", "HIP 91506"},
        {"Smithsonian Astrophysical Observation", "SAO 210416"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.92093693),
        dec: Angle.Degrees(-35.97252137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163432"},
        {"Hipparcos Number", "HIP 87923"},
        {"Renson", "Renson 46220"},
        {"Smithsonian Astrophysical Observation", "SAO 209522"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.41980557),
        dec: Angle.Degrees(-35.97222123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 320168"},
        {"Hipparcos Number", "HIP 86062"},
        {"Cincinnati Publication", "Ci 20 1044"},
        {"Geneva Identification System", "GEN# +1.00320168"},
        {"Smithsonian Astrophysical Observation", "SAO 208987"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.82833619),
        dec: Angle.Degrees(-35.97047175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -333.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -306.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195303"},
        {"Hipparcos Number", "HIP 101281"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.93839047),
        dec: Angle.Degrees(-35.96955393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176311"},
        {"Hipparcos Number", "HIP 93384"},
        {"Smithsonian Astrophysical Observation", "SAO 210819"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.30076039),
        dec: Angle.Degrees(-35.96892174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81663"},
        {"Hipparcos Number", "HIP 46271"},
        {"Geneva Identification System", "GEN# +1.00081663"},
        {"Smithsonian Astrophysical Observation", "SAO 200366"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.51091279),
        dec: Angle.Degrees(-35.96864273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56575"},
        {"Smithsonian Astrophysical Observation", "SAO 202613"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.99316069),
        dec: Angle.Degrees(-35.96764067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43898"},
        {"Hipparcos Number", "HIP 29848"},
        {"Geneva Identification System", "GEN# +1.00043898"},
        {"Smithsonian Astrophysical Observation", "SAO 196655"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.27459253),
        dec: Angle.Degrees(-35.96755788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27363"},
        {"Hipparcos Number", "HIP 20024"},
        {"Smithsonian Astrophysical Observation", "SAO 194900"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.42123654),
        dec: Angle.Degrees(-35.96700281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4283"},
        {"Hipparcos Number", "HIP 3522"},
        {"Smithsonian Astrophysical Observation", "SAO 192714"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.23989989),
        dec: Angle.Degrees(-35.96650334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19742"},
        {"Hipparcos Number", "HIP 14660"},
        {"Geneva Identification System", "GEN# +1.00019742"},
        {"Smithsonian Astrophysical Observation", "SAO 194120"},
    },
    visualMagnitude: 9.75,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.34859254),
        dec: Angle.Degrees(-35.96558996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225100"},
        {"Hipparcos Number", "HIP 271"},
        {"Geneva Identification System", "GEN# +1.00225100"},
        {"Renson", "Renson 61730"},
        {"Smithsonian Astrophysical Observation", "SAO 192341"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.85277163),
        dec: Angle.Degrees(-35.96517367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175854"},
        {"Hipparcos Number", "HIP 93191"},
        {"Geneva Identification System", "GEN# +1.00175854"},
        {"Smithsonian Astrophysical Observation", "SAO 210785"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.72391032),
        dec: Angle.Degrees(-35.96458296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79755"},
        {"Hipparcos Number", "HIP 45371"},
        {"Smithsonian Astrophysical Observation", "SAO 200148"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.69337980),
        dec: Angle.Degrees(-35.96197283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60312"},
        {"Hipparcos Number", "HIP 36657"},
        {"Celescope Catalog", "CEL 1917"},
        {"Geneva Identification System", "GEN# +1.00060312J"},
        {"Smithsonian Astrophysical Observation", "SAO 198104"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.09283885),
        dec: Angle.Degrees(-35.96119858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60605"},
        {"Hipparcos Number", "HIP 36774"},
        {"Geneva Identification System", "GEN# +1.00060605"},
        {"Smithsonian Astrophysical Observation", "SAO 198128"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.45447003),
        dec: Angle.Degrees(-35.96111244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224715"},
        {"Hipparcos Number", "HIP 12"},
        {"Smithsonian Astrophysical Observation", "SAO 214908"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.04091756),
        dec: Angle.Degrees(-35.96022482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177803"},
        {"Hipparcos Number", "HIP 93944"},
        {"Smithsonian Astrophysical Observation", "SAO 210951"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.92313034),
        dec: Angle.Degrees(-35.95608479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74208"},
        {"Hipparcos Number", "HIP 42640"},
        {"Smithsonian Astrophysical Observation", "SAO 199508"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.33898271),
        dec: Angle.Degrees(-35.95440188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207714"},
        {"Hipparcos Number", "HIP 107912"},
        {"Smithsonian Astrophysical Observation", "SAO 213344"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.94760126),
        dec: Angle.Degrees(-35.95186893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82150"},
        {"Hipparcos Number", "HIP 46515"},
        {"Fundamental Katalog 5th Edition", "FK5 356"},
        {"Geneva Identification System", "GEN# +1.00082150"},
        {"Smithsonian Astrophysical Observation", "SAO 200416"},
        {"Wilson Evans Batten Catalogue", "WEB 8779"},
    },
    visualMagnitude: 4.51,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.31140615),
        dec: Angle.Degrees(-35.95134780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29264"},
        {"Hipparcos Number", "HIP 21360"},
        {"Smithsonian Astrophysical Observation", "SAO 195145"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.74660616),
        dec: Angle.Degrees(-35.94864055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114848"},
        {"Hipparcos Number", "HIP 64542"},
        {"Geneva Identification System", "GEN# +1.00114848"},
        {"Smithsonian Astrophysical Observation", "SAO 204253"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.43150629),
        dec: Angle.Degrees(-35.94614127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210141"},
        {"Hipparcos Number", "HIP 109329"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.23979393),
        dec: Angle.Degrees(-35.94480960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52900"},
        {"Smithsonian Astrophysical Observation", "SAO 201788"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.29178354),
        dec: Angle.Degrees(-35.94459296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3632"},
        {"Hipparcos Number", "HIP 3063"},
        {"Geneva Identification System", "GEN# +1.00003632"},
        {"Smithsonian Astrophysical Observation", "SAO 192655"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.71986459),
        dec: Angle.Degrees(-35.94406062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20144"},
        {"Hipparcos Number", "HIP 14972"},
        {"Geneva Identification System", "GEN# +1.00020144"},
        {"Smithsonian Astrophysical Observation", "SAO 194163"},
        {"Wilson Evans Batten Catalogue", "WEB 2888"},
    },
    visualMagnitude: 6.29,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.25620858),
        dec: Angle.Degrees(-35.94370659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74475"},
        {"Hipparcos Number", "HIP 42775"},
        {"Celescope Catalog", "CEL 2808"},
        {"Geneva Identification System", "GEN# +1.00074475"},
        {"Smithsonian Astrophysical Observation", "SAO 199535"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.73752724),
        dec: Angle.Degrees(-35.94334976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133077"},
        {"Hipparcos Number", "HIP 73672"},
        {"Geneva Identification System", "GEN# +1.00133077"},
        {"Smithsonian Astrophysical Observation", "SAO 206247"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.89440030),
        dec: Angle.Degrees(-35.94279904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179007"},
        {"Hipparcos Number", "HIP 94356"},
        {"Geneva Identification System", "GEN# +1.00179007"},
        {"Smithsonian Astrophysical Observation", "SAO 211039"},
        {"Wilson Evans Batten Catalogue", "WEB 16437"},
    },
    visualMagnitude: 10.00,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.08022233),
        dec: Angle.Degrees(-35.94177155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15576"},
        {"Hipparcos Number", "HIP 11590"},
        {"Smithsonian Astrophysical Observation", "SAO 193738"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.34081720),
        dec: Angle.Degrees(-35.94151886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181975"},
        {"Hipparcos Number", "HIP 95359"},
        {"Smithsonian Astrophysical Observation", "SAO 211232"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.00931936),
        dec: Angle.Degrees(-35.94019080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22932"},
        {"Hipparcos Number", "HIP 17081"},
        {"Geneva Identification System", "GEN# +1.00022932"},
        {"Smithsonian Astrophysical Observation", "SAO 194435"},
        {"Wilson Evans Batten Catalogue", "WEB 3245"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.90068233),
        dec: Angle.Degrees(-35.94008276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18838"},
        {"Hipparcos Number", "HIP 14031"},
        {"Geneva Identification System", "GEN# +1.00018838"},
        {"Smithsonian Astrophysical Observation", "SAO 194032"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.17398347),
        dec: Angle.Degrees(-35.93779684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 255.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22425"},
        {"Hipparcos Number", "HIP 16720"},
        {"Smithsonian Astrophysical Observation", "SAO 194389"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.77616127),
        dec: Angle.Degrees(-35.93762850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211968"},
        {"Hipparcos Number", "HIP 110392"},
        {"Geneva Identification System", "GEN# +1.00211968"},
        {"Smithsonian Astrophysical Observation", "SAO 213762"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.39862874),
        dec: Angle.Degrees(-35.93672264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111819"},
        {"Hipparcos Number", "HIP 62813"},
        {"Smithsonian Astrophysical Observation", "SAO 203890"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.06790798),
        dec: Angle.Degrees(-35.93586729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153368"},
        {"Hipparcos Number", "HIP 83235"},
        {"Geneva Identification System", "GEN# +1.00153368"},
        {"Smithsonian Astrophysical Observation", "SAO 208293"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.15413916),
        dec: Angle.Degrees(-35.93397620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75722"},
        {"Hipparcos Number", "HIP 43396"},
        {"Smithsonian Astrophysical Observation", "SAO 199690"},
    },
    visualMagnitude: 6.90,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.59731999),
        dec: Angle.Degrees(-35.93046744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142643"},
        {"Hipparcos Number", "HIP 78118"},
        {"Smithsonian Astrophysical Observation", "SAO 207146"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.27104908),
        dec: Angle.Degrees(-35.92755592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133297"},
        {"Hipparcos Number", "HIP 73779"},
        {"Smithsonian Astrophysical Observation", "SAO 206267"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.20644459),
        dec: Angle.Degrees(-35.92611911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82465"},
        {"Hipparcos Number", "HIP 46697"},
        {"Smithsonian Astrophysical Observation", "SAO 200453"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.79181471),
        dec: Angle.Degrees(-35.92587510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47473"},
        {"Smithsonian Astrophysical Observation", "SAO 200622"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.16369219),
        dec: Angle.Degrees(-35.92518592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78810"},
        {"Hipparcos Number", "HIP 44930"},
        {"Smithsonian Astrophysical Observation", "SAO 200039"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.28078564),
        dec: Angle.Degrees(-35.92414544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116989"},
        {"Hipparcos Number", "HIP 65671"},
        {"Smithsonian Astrophysical Observation", "SAO 204494"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.98076713),
        dec: Angle.Degrees(-35.92349683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99241"},
        {"Hipparcos Number", "HIP 55710"},
        {"Smithsonian Astrophysical Observation", "SAO 202424"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.24110639),
        dec: Angle.Degrees(-35.92094317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21423"},
        {"Hipparcos Number", "HIP 15987"},
        {"Geneva Identification System", "GEN# +1.00021423"},
        {"Smithsonian Astrophysical Observation", "SAO 194289"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.48256440),
        dec: Angle.Degrees(-35.92087386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213476"},
        {"Hipparcos Number", "HIP 111240"},
        {"Smithsonian Astrophysical Observation", "SAO 213892"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.06644484),
        dec: Angle.Degrees(-35.92055976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134702"},
        {"Hipparcos Number", "HIP 74417"},
        {"Geneva Identification System", "GEN# +1.00134702"},
        {"Smithsonian Astrophysical Observation", "SAO 206407"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.12618488),
        dec: Angle.Degrees(-35.91881981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136961"},
        {"Hipparcos Number", "HIP 75436"},
        {"Geneva Identification System", "GEN# +1.00136961"},
        {"Smithsonian Astrophysical Observation", "SAO 206599"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.17438982),
        dec: Angle.Degrees(-35.91706693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58038"},
        {"Hipparcos Number", "HIP 35733"},
        {"Smithsonian Astrophysical Observation", "SAO 197907"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.56836086),
        dec: Angle.Degrees(-35.91647377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149481"},
        {"Hipparcos Number", "HIP 81335"},
        {"Geneva Identification System", "GEN# +1.00149481"},
        {"Smithsonian Astrophysical Observation", "SAO 207820"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.17280816),
        dec: Angle.Degrees(-35.91637714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38948"},
        {"Geneva Identification System", "GEN# -0.03504061"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.52949681),
        dec: Angle.Degrees(-35.91422827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19182"},
        {"Hipparcos Number", "HIP 14263"},
        {"Smithsonian Astrophysical Observation", "SAO 194064"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.98531684),
        dec: Angle.Degrees(-35.91311299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175950"},
        {"Hipparcos Number", "HIP 93227"},
        {"Geneva Identification System", "GEN# +1.00175950"},
        {"Smithsonian Astrophysical Observation", "SAO 210790"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.85183956),
        dec: Angle.Degrees(-35.91300648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66144"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.38189041),
        dec: Angle.Degrees(-35.91151226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201514"},
        {"Hipparcos Number", "HIP 104583"},
        {"Smithsonian Astrophysical Observation", "SAO 212773"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.78583758),
        dec: Angle.Degrees(-35.91134497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157060"},
        {"Hipparcos Number", "HIP 85019"},
        {"Geneva Identification System", "GEN# +1.00157060"},
        {"Smithsonian Astrophysical Observation", "SAO 208741"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.65793288),
        dec: Angle.Degrees(-35.91093287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125429"},
        {"Hipparcos Number", "HIP 70055"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.04651910),
        dec: Angle.Degrees(-35.91085049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44184"},
        {"Hipparcos Number", "HIP 29985"},
        {"Smithsonian Astrophysical Observation", "SAO 196676"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.68736676),
        dec: Angle.Degrees(-35.91033460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39600"},
        {"Hipparcos Number", "HIP 27701"},
        {"Smithsonian Astrophysical Observation", "SAO 196257"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.98424851),
        dec: Angle.Degrees(-35.90970920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104611"},
        {"Hipparcos Number", "HIP 58734"},
        {"Smithsonian Astrophysical Observation", "SAO 203064"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.69981019),
        dec: Angle.Degrees(-35.90968541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105558"},
        {"Hipparcos Number", "HIP 59256"},
        {"Smithsonian Astrophysical Observation", "SAO 203175"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.32377706),
        dec: Angle.Degrees(-35.90875756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102397"},
        {"Hipparcos Number", "HIP 57497"},
        {"Geneva Identification System", "GEN# +1.00102397"},
        {"Smithsonian Astrophysical Observation", "SAO 202805"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.77925104),
        dec: Angle.Degrees(-35.90679191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28884"},
        {"Hipparcos Number", "HIP 21118"},
        {"Smithsonian Astrophysical Observation", "SAO 195105"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.89416820),
        dec: Angle.Degrees(-35.90578839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81515"},
        {"Hipparcos Number", "HIP 46182"},
        {"Renson", "Renson 23170"},
        {"Smithsonian Astrophysical Observation", "SAO 200341"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.25128449),
        dec: Angle.Degrees(-35.90532831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211864"},
        {"Hipparcos Number", "HIP 110331"},
        {"Smithsonian Astrophysical Observation", "SAO 213752"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.20219262),
        dec: Angle.Degrees(-35.90461897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18168"},
        {"Hipparcos Number", "HIP 13513"},
        {"Cincinnati Publication", "Ci 18 378"},
        {"Cincinnati Publication 2", "Ci 20 193"},
        {"Geneva Identification System", "GEN# +1.00018168"},
        {"Smithsonian Astrophysical Observation", "SAO 193970"},
        {"Wilson Evans Batten Catalogue", "WEB 2697"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.51005944),
        dec: Angle.Degrees(-35.90426384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 515.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43866"},
        {"Hipparcos Number", "HIP 29825"},
        {"Smithsonian Astrophysical Observation", "SAO 196649"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.21272071),
        dec: Angle.Degrees(-35.90350336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69511"},
        {"Hipparcos Number", "HIP 40485"},
        {"Geneva Identification System", "GEN# +1.00069511"},
        {"Smithsonian Astrophysical Observation", "SAO 199015"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.99511855),
        dec: Angle.Degrees(-35.90320668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39932"},
        {"Hipparcos Number", "HIP 27892"},
        {"Geneva Identification System", "GEN# +1.00039932"},
        {"Smithsonian Astrophysical Observation", "SAO 196296"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.52813990),
        dec: Angle.Degrees(-35.90302538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1611"},
        {"Hipparcos Number", "HIP 1610"},
        {"Smithsonian Astrophysical Observation", "SAO 192466"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.04062614),
        dec: Angle.Degrees(-35.90280594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164870"},
        {"Hipparcos Number", "HIP 88550"},
        {"Fundamental Katalog 5th Edition", "FK5 3435"},
        {"Geneva Identification System", "GEN# +1.00164870"},
        {"Smithsonian Astrophysical Observation", "SAO 209671"},
    },
    visualMagnitude: 5.98,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.20995733),
        dec: Angle.Degrees(-35.90136032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129032"},
        {"Hipparcos Number", "HIP 71814"},
        {"Smithsonian Astrophysical Observation", "SAO 205831"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.34683208),
        dec: Angle.Degrees(-35.90091961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51009"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.31412366),
        dec: Angle.Degrees(-35.90071331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68980"},
        {"Hipparcos Number", "HIP 40274"},
        {"Celescope Catalog", "CEL 2252"},
        {"Geneva Identification System", "GEN# +1.00068980"},
        {"Smithsonian Astrophysical Observation", "SAO 198957"},
        {"Wilson Evans Batten Catalogue", "WEB 7852"},
    },
    visualMagnitude: 4.78,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.37301019),
        dec: Angle.Degrees(-35.89954225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201607"},
        {"Hipparcos Number", "HIP 104639"},
        {"Smithsonian Astrophysical Observation", "SAO 212780"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.93567867),
        dec: Angle.Degrees(-35.89858553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161628"},
        {"Hipparcos Number", "HIP 87140"},
        {"Smithsonian Astrophysical Observation", "SAO 209270"},
    },
    visualMagnitude: 7.10,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.06284679),
        dec: Angle.Degrees(-35.89523974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154502"},
        {"Hipparcos Number", "HIP 83779"},
        {"Smithsonian Astrophysical Observation", "SAO 208431"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.84258394),
        dec: Angle.Degrees(-35.89276021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168170"},
        {"Hipparcos Number", "HIP 89841"},
        {"Smithsonian Astrophysical Observation", "SAO 209997"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.01069081),
        dec: Angle.Degrees(-35.89108603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86629"},
        {"Hipparcos Number", "HIP 48926"},
        {"Fundamental Katalog 5th Edition", "FK5 377"},
        {"Geneva Identification System", "GEN# +1.00086629"},
        {"Renson", "Renson 24790"},
        {"Smithsonian Astrophysical Observation", "SAO 200926"},
        {"Wilson Evans Batten Catalogue", "WEB 9087"},
    },
    visualMagnitude: 5.23,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.71808346),
        dec: Angle.Degrees(-35.89093311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162169"},
        {"Hipparcos Number", "HIP 87383"},
        {"Smithsonian Astrophysical Observation", "SAO 209354"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.81384952),
        dec: Angle.Degrees(-35.89080236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220961"},
        {"Hipparcos Number", "HIP 115853"},
        {"Smithsonian Astrophysical Observation", "SAO 214564"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.07356644),
        dec: Angle.Degrees(-35.89037583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175779"},
        {"Hipparcos Number", "HIP 93152"},
        {"Smithsonian Astrophysical Observation", "SAO 210775"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.62495260),
        dec: Angle.Degrees(-35.88890582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216237"},
        {"Henry Draper 2", "HD 216237A"},
        {"Hipparcos Number", "HIP 112898"},
        {"Renson", "Renson 59760"},
        {"Smithsonian Astrophysical Observation", "SAO 214144"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.94026220),
        dec: Angle.Degrees(-35.88855436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11030"},
        {"Hipparcos Number", "HIP 8343"},
        {"Smithsonian Astrophysical Observation", "SAO 193300"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.90254528),
        dec: Angle.Degrees(-35.88793237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183003"},
        {"Hipparcos Number", "HIP 95783"},
        {"Smithsonian Astrophysical Observation", "SAO 211296"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.22617648),
        dec: Angle.Degrees(-35.88790747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60168"},
        {"Hipparcos Number", "HIP 36608"},
        {"Celescope Catalog", "CEL 1914"},
        {"Geneva Identification System", "GEN# +1.00060168"},
        {"Smithsonian Astrophysical Observation", "SAO 198093"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.92794306),
        dec: Angle.Degrees(-35.88782381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154407"},
        {"Hipparcos Number", "HIP 83733"},
        {"Geneva Identification System", "GEN# +1.00154407J"},
        {"Smithsonian Astrophysical Observation", "SAO 208420"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.69958917),
        dec: Angle.Degrees(-35.88751401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205517"},
        {"Hipparcos Number", "HIP 106705"},
        {"Smithsonian Astrophysical Observation", "SAO 213135"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.21494160),
        dec: Angle.Degrees(-35.88589597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155807"},
        {"Hipparcos Number", "HIP 84404"},
        {"Smithsonian Astrophysical Observation", "SAO 208584"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.83603097),
        dec: Angle.Degrees(-35.88496315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205530"},
        {"Hipparcos Number", "HIP 106714"},
        {"Geneva Identification System", "GEN# +1.00205530"},
        {"Smithsonian Astrophysical Observation", "SAO 213139"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.24173768),
        dec: Angle.Degrees(-35.88412277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15098"},
        {"Hipparcos Number", "HIP 11262"},
        {"Smithsonian Astrophysical Observation", "SAO 193694"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.24411045),
        dec: Angle.Degrees(-35.88378286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69565"},
        {"Hipparcos Number", "HIP 40506"},
        {"Geneva Identification System", "GEN# +1.00069565"},
        {"Smithsonian Astrophysical Observation", "SAO 199018"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.05237919),
        dec: Angle.Degrees(-35.88223665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106542"},
        {"Smithsonian Astrophysical Observation", "SAO 213104"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.66750775),
        dec: Angle.Degrees(-35.88112041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140703"},
        {"Hipparcos Number", "HIP 77256"},
        {"Geneva Identification System", "GEN# +1.00140703"},
        {"Smithsonian Astrophysical Observation", "SAO 206955"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.61092363),
        dec: Angle.Degrees(-35.88107609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79457"},
        {"Hipparcos Number", "HIP 45236"},
        {"Smithsonian Astrophysical Observation", "SAO 200110"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.29651991),
        dec: Angle.Degrees(-35.87851294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222118"},
        {"Hipparcos Number", "HIP 116614"},
        {"Smithsonian Astrophysical Observation", "SAO 214672"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.49727180),
        dec: Angle.Degrees(-35.87828323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64802"},
        {"Hipparcos Number", "HIP 38593"},
        {"Celescope Catalog", "CEL 2087"},
        {"Geneva Identification System", "GEN# +1.00064802"},
        {"Smithsonian Astrophysical Observation", "SAO 198575"},
        {"Wilson Evans Batten Catalogue", "WEB 7579"},
    },
    visualMagnitude: 5.48,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.54588048),
        dec: Angle.Degrees(-35.87729557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184987"},
        {"Hipparcos Number", "HIP 96611"},
        {"Geneva Identification System", "GEN# +1.00184987"},
        {"Smithsonian Astrophysical Observation", "SAO 211431"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.62555755),
        dec: Angle.Degrees(-35.87679546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185519"},
        {"Hipparcos Number", "HIP 96822"},
        {"Smithsonian Astrophysical Observation", "SAO 211468"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.20042856),
        dec: Angle.Degrees(-35.87633458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223089"},
        {"Hipparcos Number", "HIP 117266"},
        {"Smithsonian Astrophysical Observation", "SAO 214764"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.67341828),
        dec: Angle.Degrees(-35.87552330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89710"},
        {"Hipparcos Number", "HIP 50631"},
        {"Smithsonian Astrophysical Observation", "SAO 201296"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.12505144),
        dec: Angle.Degrees(-35.87492453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141294"},
        {"Hipparcos Number", "HIP 77515"},
        {"Geneva Identification System", "GEN# +1.00141294"},
        {"Smithsonian Astrophysical Observation", "SAO 207016"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.40406085),
        dec: Angle.Degrees(-35.87450902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120121"},
    },
    visualMagnitude: 11.93,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.20064437),
        dec: Angle.Degrees(-35.86947602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 181.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198673"},
        {"Hipparcos Number", "HIP 103078"},
        {"Smithsonian Astrophysical Observation", "SAO 212514"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.27924080),
        dec: Angle.Degrees(-35.86880256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94549"},
        {"Smithsonian Astrophysical Observation", "SAO 211077"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.65428254),
        dec: Angle.Degrees(-35.86844180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150952"},
        {"Hipparcos Number", "HIP 82067"},
        {"Smithsonian Astrophysical Observation", "SAO 208002"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.44929658),
        dec: Angle.Degrees(-35.86782226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134197"},
        {"Hipparcos Number", "HIP 74196"},
        {"Smithsonian Astrophysical Observation", "SAO 206345"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.42116377),
        dec: Angle.Degrees(-35.86586130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202944"},
        {"Hipparcos Number", "HIP 105338"},
        {"Smithsonian Astrophysical Observation", "SAO 212911"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.04865762),
        dec: Angle.Degrees(-35.86583626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84687"},
        {"Hipparcos Number", "HIP 47919"},
        {"Geneva Identification System", "GEN# +1.00084687"},
        {"Smithsonian Astrophysical Observation", "SAO 200710"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.49906441),
        dec: Angle.Degrees(-35.86358720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113852"},
        {"Hipparcos Number", "HIP 64003"},
        {"Geneva Identification System", "GEN# +1.00113852"},
        {"Smithsonian Astrophysical Observation", "SAO 204132"},
        {"Wilson Evans Batten Catalogue", "WEB 11313"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.72595485),
        dec: Angle.Degrees(-35.86182329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173337"},
        {"Hipparcos Number", "HIP 92108"},
        {"Smithsonian Astrophysical Observation", "SAO 210551"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.58026546),
        dec: Angle.Degrees(-35.86057185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158339"},
        {"Hipparcos Number", "HIP 85652"},
        {"Smithsonian Astrophysical Observation", "SAO 208885"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.56620245),
        dec: Angle.Degrees(-35.85973844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88218"},
        {"Hipparcos Number", "HIP 49769"},
        {"Cincinnati Publication", "Ci 20 562"},
        {"Fundamental Katalog 5th Edition", "FK5 2816"},
        {"Smithsonian Astrophysical Observation", "SAO 201109"},
        {"Wilson Evans Batten Catalogue", "WEB 9176"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.38369551),
        dec: Angle.Degrees(-35.85681022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -442.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173122"},
        {"Hipparcos Number", "HIP 92017"},
        {"Smithsonian Astrophysical Observation", "SAO 210532"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.32803642),
        dec: Angle.Degrees(-35.85663046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114046",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Lacaille 9352"},
        {"Henry Draper", "HD 217987"},
        {"Hipparcos Number", "HIP 114046"},
        {"Cincinnati Publication", "Ci 20 1400"},
        {"Geneva Identification System", "GEN# +1.00217987"},
        {"Smithsonian Astrophysical Observation", "SAO 214301"},
        {"Wilson Evans Batten Catalogue", "WEB 20248"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.44652092),
        dec: Angle.Degrees(-35.85629710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6767.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1326.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20302"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.25146766),
        dec: Angle.Degrees(-35.85573936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 242.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37105"},
        {"Hipparcos Number", "HIP 26146"},
        {"Geneva Identification System", "GEN# +1.00037105"},
        {"Smithsonian Astrophysical Observation", "SAO 195976"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.61403372),
        dec: Angle.Degrees(-35.85459942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21635"},
        {"Hipparcos Number", "HIP 16156"},
        {"Geneva Identification System", "GEN# +1.00021635"},
        {"Smithsonian Astrophysical Observation", "SAO 194318"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.04791177),
        dec: Angle.Degrees(-35.85341812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67160"},
        {"Smithsonian Astrophysical Observation", "SAO 204815"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.45376711),
        dec: Angle.Degrees(-35.84757934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143098"},
        {"Hipparcos Number", "HIP 78343"},
        {"Geneva Identification System", "GEN# +1.00143098"},
        {"Smithsonian Astrophysical Observation", "SAO 207200"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.94868629),
        dec: Angle.Degrees(-35.84527111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17793"},
        {"Hipparcos Number", "HIP 13225"},
        {"Geneva Identification System", "GEN# +1.00017793"},
        {"Smithsonian Astrophysical Observation", "SAO 193940"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.56144528),
        dec: Angle.Degrees(-35.84368582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205977"},
        {"Hipparcos Number", "HIP 106976"},
        {"Fundamental Katalog 5th Edition", "FK5 5911"},
        {"Geneva Identification System", "GEN# +1.00205977"},
        {"Smithsonian Astrophysical Observation", "SAO 213184"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.98375455),
        dec: Angle.Degrees(-35.84254519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103028"},
        {"Hipparcos Number", "HIP 57836"},
        {"Smithsonian Astrophysical Observation", "SAO 202882"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.90860051),
        dec: Angle.Degrees(-35.84252211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130311"},
        {"Hipparcos Number", "HIP 72427"},
        {"Smithsonian Astrophysical Observation", "SAO 205964"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.13617684),
        dec: Angle.Degrees(-35.84149841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207213"},
        {"Hipparcos Number", "HIP 107645"},
        {"Smithsonian Astrophysical Observation", "SAO 213295"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.05511820),
        dec: Angle.Degrees(-35.84087142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156441"},
        {"Hipparcos Number", "HIP 84725"},
        {"Geneva Identification System", "GEN# +1.00156441"},
        {"Smithsonian Astrophysical Observation", "SAO 208677"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.78428150),
        dec: Angle.Degrees(-35.84045930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31143"},
        {"Hipparcos Number", "HIP 22602"},
        {"Geneva Identification System", "GEN# +1.00031143"},
        {"Smithsonian Astrophysical Observation", "SAO 195362"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.94072258),
        dec: Angle.Degrees(-35.84016512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52704"},
        {"Hipparcos Number", "HIP 33749"},
        {"Smithsonian Astrophysical Observation", "SAO 197471"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.15819703),
        dec: Angle.Degrees(-35.83787417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58420"},
        {"Hipparcos Number", "HIP 35893"},
        {"Celescope Catalog", "CEL 1829"},
        {"Geneva Identification System", "GEN# +1.00058420A"},
        {"Smithsonian Astrophysical Observation", "SAO 197951"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.99309051),
        dec: Angle.Degrees(-35.83786094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128009"},
        {"Hipparcos Number", "HIP 71358"},
        {"Geneva Identification System", "GEN# +1.00128009"},
        {"Smithsonian Astrophysical Observation", "SAO 205728"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.89386252),
        dec: Angle.Degrees(-35.83755619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203849"},
        {"Hipparcos Number", "HIP 105816"},
        {"Smithsonian Astrophysical Observation", "SAO 212992"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.45738281),
        dec: Angle.Degrees(-35.83660796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209211"},
        {"Hipparcos Number", "HIP 108798"},
        {"Geneva Identification System", "GEN# +1.00209211"},
        {"Smithsonian Astrophysical Observation", "SAO 213493"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.61006485),
        dec: Angle.Degrees(-35.83481001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31043"},
    },
    visualMagnitude: 11.42,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.70846394),
        dec: Angle.Degrees(-35.83399580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134950"},
        {"Hipparcos Number", "HIP 74534"},
        {"Geneva Identification System", "GEN# +1.00134950"},
        {"Smithsonian Astrophysical Observation", "SAO 206429"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.45068879),
        dec: Angle.Degrees(-35.83392312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121356"},
        {"Hipparcos Number", "HIP 68004"},
        {"Geneva Identification System", "GEN# +1.00121356"},
        {"Smithsonian Astrophysical Observation", "SAO 204990"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.89100007),
        dec: Angle.Degrees(-35.83365936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106937"},
        {"Hipparcos Number", "HIP 59968"},
        {"Geneva Identification System", "GEN# +1.00106937"},
        {"Smithsonian Astrophysical Observation", "SAO 203323"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.48667494),
        dec: Angle.Degrees(-35.83152355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16388"},
        {"Hipparcos Number", "HIP 12163"},
        {"Smithsonian Astrophysical Observation", "SAO 193805"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.19241803),
        dec: Angle.Degrees(-35.82870811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197402"},
        {"Hipparcos Number", "HIP 102381"},
        {"Smithsonian Astrophysical Observation", "SAO 212396"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.17053192),
        dec: Angle.Degrees(-35.82755891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39839"},
        {"Hipparcos Number", "HIP 27845"},
        {"Smithsonian Astrophysical Observation", "SAO 196287"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.37457727),
        dec: Angle.Degrees(-35.82536167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34167"},
        {"Hipparcos Number", "HIP 24373"},
        {"Geneva Identification System", "GEN# +1.00034167"},
        {"Smithsonian Astrophysical Observation", "SAO 195669"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.44301831),
        dec: Angle.Degrees(-35.82529963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83108"},
        {"Hipparcos Number", "HIP 47039"},
        {"Geneva Identification System", "GEN# +1.00083108"},
        {"Smithsonian Astrophysical Observation", "SAO 200531"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.79948668),
        dec: Angle.Degrees(-35.82374500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2616"},
        {"Hipparcos Number", "HIP 2318"},
        {"Smithsonian Astrophysical Observation", "SAO 192564"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.38934534),
        dec: Angle.Degrees(-35.82361414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13279"},
        {"Hipparcos Number", "HIP 10004"},
        {"Smithsonian Astrophysical Observation", "SAO 193533"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.20475843),
        dec: Angle.Degrees(-35.82308086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85079"},
        {"Hipparcos Number", "HIP 48110"},
        {"Smithsonian Astrophysical Observation", "SAO 200757"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.14142195),
        dec: Angle.Degrees(-35.82304194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34217"},
        {"Hipparcos Number", "HIP 24405"},
        {"Smithsonian Astrophysical Observation", "SAO 195674"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.53266677),
        dec: Angle.Degrees(-35.82291672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73720"},
        {"Hipparcos Number", "HIP 42380"},
        {"Smithsonian Astrophysical Observation", "SAO 199457"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.61270679),
        dec: Angle.Degrees(-35.82253764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54023"},
        {"Smithsonian Astrophysical Observation", "SAO 202037"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.79631650),
        dec: Angle.Degrees(-35.82103283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12875"},
        {"Hipparcos Number", "HIP 9734"},
        {"Smithsonian Astrophysical Observation", "SAO 193499"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.30889782),
        dec: Angle.Degrees(-35.81908984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167072"},
        {"Hipparcos Number", "HIP 89438"},
        {"Smithsonian Astrophysical Observation", "SAO 209909"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.80276006),
        dec: Angle.Degrees(-35.81908156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 438"},
        {"Hipparcos Number", "HIP 719"},
        {"Smithsonian Astrophysical Observation", "SAO 192371"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.22083743),
        dec: Angle.Degrees(-35.81902966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101799"},
        {"Hipparcos Number", "HIP 57129"},
        {"Smithsonian Astrophysical Observation", "SAO 202729"},
        {"Wilson Evans Batten Catalogue", "WEB 10283"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.70049620),
        dec: Angle.Degrees(-35.81591486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10632"},
        {"Hipparcos Number", "HIP 8023"},
        {"Smithsonian Astrophysical Observation", "SAO 193268"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.75404314),
        dec: Angle.Degrees(-35.81502523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54581"},
        {"Hipparcos Number", "HIP 34388"},
        {"Smithsonian Astrophysical Observation", "SAO 197610"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.95663786),
        dec: Angle.Degrees(-35.81444286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60604"},
        {"Hipparcos Number", "HIP 36776"},
        {"Smithsonian Astrophysical Observation", "SAO 198129"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.46036006),
        dec: Angle.Degrees(-35.81421897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34497"},
        {"Hipparcos Number", "HIP 24562"},
        {"Smithsonian Astrophysical Observation", "SAO 195701"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.04426307),
        dec: Angle.Degrees(-35.81289153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 991"},
        {"Hipparcos Number", "HIP 1138"},
        {"Geneva Identification System", "GEN# +1.00000991"},
        {"Smithsonian Astrophysical Observation", "SAO 192412"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.55500217),
        dec: Angle.Degrees(-35.80829245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103178"},
        {"Smithsonian Astrophysical Observation", "SAO 212531"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.57295515),
        dec: Angle.Degrees(-35.80710562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30462"},
        {"Hipparcos Number", "HIP 22194"},
        {"Smithsonian Astrophysical Observation", "SAO 195283"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.61011039),
        dec: Angle.Degrees(-35.80618455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215003"},
        {"Hipparcos Number", "HIP 112124"},
        {"Smithsonian Astrophysical Observation", "SAO 214032"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.67486107),
        dec: Angle.Degrees(-35.80597456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90706"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.60234808),
        dec: Angle.Degrees(-35.80472775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -316.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96146"},
        {"Hipparcos Number", "HIP 54173"},
        {"Fundamental Katalog 5th Edition", "FK5 2885"},
        {"Geneva Identification System", "GEN# +1.00096146"},
        {"Smithsonian Astrophysical Observation", "SAO 202067"},
        {"Wilson Evans Batten Catalogue", "WEB 9787"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.22587294),
        dec: Angle.Degrees(-35.80468900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93906"},
        {"Hipparcos Number", "HIP 52960"},
        {"Celescope Catalog", "CEL 3729"},
        {"Geneva Identification System", "GEN# +1.00093906"},
        {"Smithsonian Astrophysical Observation", "SAO 201804"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.48050589),
        dec: Angle.Degrees(-35.80445582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8953"},
        {"Smithsonian Astrophysical Observation", "SAO 193382"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.82664117),
        dec: Angle.Degrees(-35.80309944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61640"},
        {"Hipparcos Number", "HIP 37227"},
        {"Smithsonian Astrophysical Observation", "SAO 198238"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.69471514),
        dec: Angle.Degrees(-35.80292913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200360"},
        {"Hipparcos Number", "HIP 103991"},
        {"Smithsonian Astrophysical Observation", "SAO 212682"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.03961968),
        dec: Angle.Degrees(-35.80188464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160575"},
        {"Hipparcos Number", "HIP 86653"},
        {"Geneva Identification System", "GEN# +1.00160575"},
        {"Smithsonian Astrophysical Observation", "SAO 209158"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.57525989),
        dec: Angle.Degrees(-35.80113414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40583"},
        {"Hipparcos Number", "HIP 28241"},
        {"Geneva Identification System", "GEN# +1.00040583"},
        {"Smithsonian Astrophysical Observation", "SAO 196360"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.51553505),
        dec: Angle.Degrees(-35.80019764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41685"},
        {"Hipparcos Number", "HIP 28817"},
        {"Smithsonian Astrophysical Observation", "SAO 196476"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.25898564),
        dec: Angle.Degrees(-35.79922304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196701"},
        {"Hipparcos Number", "HIP 102013"},
        {"Geneva Identification System", "GEN# +1.00196701"},
        {"Smithsonian Astrophysical Observation", "SAO 212332"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.07934535),
        dec: Angle.Degrees(-35.79887891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1721"},
        {"Hipparcos Number", "HIP 1694"},
        {"Geneva Identification System", "GEN# +1.00001721"},
        {"Smithsonian Astrophysical Observation", "SAO 192477"},
        {"Wilson Evans Batten Catalogue", "WEB 309"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.31127634),
        dec: Angle.Degrees(-35.79884988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38554"},
        {"Hipparcos Number", "HIP 27113"},
        {"Geneva Identification System", "GEN# +1.00038554"},
        {"Smithsonian Astrophysical Observation", "SAO 196135"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.25087237),
        dec: Angle.Degrees(-35.79809634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87687"},
        {"Hipparcos Number", "HIP 49451"},
        {"Smithsonian Astrophysical Observation", "SAO 201048"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.44673951),
        dec: Angle.Degrees(-35.79695607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122432"},
        {"Hipparcos Number", "HIP 68602"},
        {"Geneva Identification System", "GEN# +1.00122432"},
        {"Smithsonian Astrophysical Observation", "SAO 205117"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.63980746),
        dec: Angle.Degrees(-35.79666674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151076"},
        {"Hipparcos Number", "HIP 82125"},
        {"Smithsonian Astrophysical Observation", "SAO 208017"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.65544868),
        dec: Angle.Degrees(-35.79435824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13289"},
        {"Hipparcos Number", "HIP 10008"},
        {"Geneva Identification System", "GEN# +1.00013289"},
        {"Smithsonian Astrophysical Observation", "SAO 193535"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.22619210),
        dec: Angle.Degrees(-35.79219032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85937"},
        {"Hipparcos Number", "HIP 48564"},
        {"Smithsonian Astrophysical Observation", "SAO 200852"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.57360064),
        dec: Angle.Degrees(-35.79168525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64008"},
        {"Hipparcos Number", "HIP 38262"},
        {"Smithsonian Astrophysical Observation", "SAO 198504"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.58628524),
        dec: Angle.Degrees(-35.79059889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66309"},
        {"Hipparcos Number", "HIP 39248"},
        {"Celescope Catalog", "CEL 2139"},
        {"Geneva Identification System", "GEN# +1.00066309"},
        {"Smithsonian Astrophysical Observation", "SAO 198711"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.40132357),
        dec: Angle.Degrees(-35.78891647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116550"},
        {"Hipparcos Number", "HIP 65453"},
        {"Smithsonian Astrophysical Observation", "SAO 204442"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.22069804),
        dec: Angle.Degrees(-35.78890107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46246"},
        {"Smithsonian Astrophysical Observation", "SAO 200358"},
    },
    visualMagnitude: 9.28,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.43412857),
        dec: Angle.Degrees(-35.78771573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4330",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4330"},
        {"Smithsonian Astrophysical Observation", "SAO 192817"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.85935058),
        dec: Angle.Degrees(-35.78697558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165727"},
        {"Hipparcos Number", "HIP 88911"},
        {"Geneva Identification System", "GEN# +1.00165727"},
        {"Smithsonian Astrophysical Observation", "SAO 209764"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.24402618),
        dec: Angle.Degrees(-35.78585008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148789"},
        {"Hipparcos Number", "HIP 80972"},
        {"Geneva Identification System", "GEN# +1.00148789"},
        {"Smithsonian Astrophysical Observation", "SAO 207742"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.02066662),
        dec: Angle.Degrees(-35.78577436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122109"},
        {"Hipparcos Number", "HIP 68426"},
        {"Geneva Identification System", "GEN# +1.00122109"},
        {"Smithsonian Astrophysical Observation", "SAO 205084"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.12197845),
        dec: Angle.Degrees(-35.78557436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35579"},
        {"Hipparcos Number", "HIP 25257"},
        {"Smithsonian Astrophysical Observation", "SAO 195817"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.03309094),
        dec: Angle.Degrees(-35.78459511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148187"},
        {"Hipparcos Number", "HIP 80636"},
        {"Geneva Identification System", "GEN# +1.00148187"},
        {"Smithsonian Astrophysical Observation", "SAO 207684"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.96810062),
        dec: Angle.Degrees(-35.78337345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191662"},
        {"Hipparcos Number", "HIP 99568"},
        {"Smithsonian Astrophysical Observation", "SAO 211898"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.09851907),
        dec: Angle.Degrees(-35.78279767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25220"},
        {"Hipparcos Number", "HIP 18611"},
        {"Smithsonian Astrophysical Observation", "SAO 194673"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.73354250),
        dec: Angle.Degrees(-35.77856795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51473"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.71278776),
        dec: Angle.Degrees(-35.77760747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -334.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221566"},
        {"Hipparcos Number", "HIP 116262"},
        {"Smithsonian Astrophysical Observation", "SAO 214621"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.35858178),
        dec: Angle.Degrees(-35.77430846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28849"},
        {"Hipparcos Number", "HIP 21098"},
        {"Smithsonian Astrophysical Observation", "SAO 195095"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.81284401),
        dec: Angle.Degrees(-35.77364859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68623"},
        {"Hipparcos Number", "HIP 40144"},
        {"Smithsonian Astrophysical Observation", "SAO 198918"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.97231813),
        dec: Angle.Degrees(-35.77302878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73855"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.40975929),
        dec: Angle.Degrees(-35.76931273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27628",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Wazn"},
        {"Henry Draper", "HD 39425"},
        {"Hipparcos Number", "HIP 27628"},
        {"Cincinnati Publication", "Ci 20 355"},
        {"Fundamental Katalog 5th Edition", "FK5 223"},
        {"Geneva Identification System", "GEN# +1.00039425"},
        {"Smithsonian Astrophysical Observation", "SAO 196240"},
        {"Wilson Evans Batten Catalogue", "WEB 5427"},
    },
    visualMagnitude: 3.12,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.73980340),
        dec: Angle.Degrees(-35.76929225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 404.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214407"},
        {"Hipparcos Number", "HIP 111776"},
        {"Smithsonian Astrophysical Observation", "SAO 213976"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.62187177),
        dec: Angle.Degrees(-35.76736583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80086"},
        {"Hipparcos Number", "HIP 45529"},
        {"Smithsonian Astrophysical Observation", "SAO 200179"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.17819098),
        dec: Angle.Degrees(-35.76714071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158964"},
        {"Hipparcos Number", "HIP 85931"},
        {"Smithsonian Astrophysical Observation", "SAO 208957"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.41941353),
        dec: Angle.Degrees(-35.76526621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89441"},
        {"Hipparcos Number", "HIP 50489"},
        {"Geneva Identification System", "GEN# +1.00089441"},
        {"Smithsonian Astrophysical Observation", "SAO 201264"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.64565793),
        dec: Angle.Degrees(-35.76506644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57737"},
        {"Geneva Identification System", "GEN# -0.03507477"},
        {"Smithsonian Astrophysical Observation", "SAO 202860"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.59730368),
        dec: Angle.Degrees(-35.76301885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201771"},
        {"Hipparcos Number", "HIP 104718"},
        {"Smithsonian Astrophysical Observation", "SAO 212791"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.19499680),
        dec: Angle.Degrees(-35.76270777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139979"},
        {"Hipparcos Number", "HIP 76927"},
        {"Geneva Identification System", "GEN# +1.00139979"},
        {"Smithsonian Astrophysical Observation", "SAO 206886"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.62292006),
        dec: Angle.Degrees(-35.76026054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 319534"},
        {"Hipparcos Number", "HIP 84141"},
        {"Smithsonian Astrophysical Observation", "SAO 208520"},
    },
    visualMagnitude: 9.06,
    bvColour: 2.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.03610588),
        dec: Angle.Degrees(-35.75838323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196103"},
        {"Hipparcos Number", "HIP 101661"},
        {"Smithsonian Astrophysical Observation", "SAO 212275"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.10159683),
        dec: Angle.Degrees(-35.75567084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157591"},
        {"Hipparcos Number", "HIP 85291"},
        {"Smithsonian Astrophysical Observation", "SAO 208797"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.42611062),
        dec: Angle.Degrees(-35.75515124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203196"},
        {"Hipparcos Number", "HIP 105462"},
        {"Smithsonian Astrophysical Observation", "SAO 212941"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.42268146),
        dec: Angle.Degrees(-35.75428979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32276"},
        {"Hipparcos Number", "HIP 23267"},
        {"Smithsonian Astrophysical Observation", "SAO 195479"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.08849096),
        dec: Angle.Degrees(-35.75320080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6691"},
        {"Smithsonian Astrophysical Observation", "SAO 193110"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.48246390),
        dec: Angle.Degrees(-35.75089234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155974"},
        {"Hipparcos Number", "HIP 84489"},
        {"Geneva Identification System", "GEN# +1.00155974"},
        {"Smithsonian Astrophysical Observation", "SAO 208610"},
        {"Wilson Evans Batten Catalogue", "WEB 14262"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.09034067),
        dec: Angle.Degrees(-35.74946511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -342.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21852"},
        {"Hipparcos Number", "HIP 16289"},
        {"Renson", "Renson 5480"},
        {"Smithsonian Astrophysical Observation", "SAO 194339"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.49144360),
        dec: Angle.Degrees(-35.74857890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54288",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54288"},
        {"Smithsonian Astrophysical Observation", "SAO 202092"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.59515966),
        dec: Angle.Degrees(-35.74830394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79183"},
        {"Hipparcos Number", "HIP 45110"},
        {"Smithsonian Astrophysical Observation", "SAO 200081"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.85910514),
        dec: Angle.Degrees(-35.74778722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5061"},
        {"Hipparcos Number", "HIP 4064"},
        {"Geneva Identification System", "GEN# +1.00005061"},
        {"Smithsonian Astrophysical Observation", "SAO 192785"},
        {"Wilson Evans Batten Catalogue", "WEB 727"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.02611912),
        dec: Angle.Degrees(-35.74772689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163985"},
        {"Hipparcos Number", "HIP 88177"},
        {"Smithsonian Astrophysical Observation", "SAO 209583"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.12267187),
        dec: Angle.Degrees(-35.74686476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103463"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.42794295),
        dec: Angle.Degrees(-35.74653698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7323"},
        {"Hipparcos Number", "HIP 5675"},
        {"Geneva Identification System", "GEN# +1.00007323"},
        {"Smithsonian Astrophysical Observation", "SAO 192983"},
        {"Wilson Evans Batten Catalogue", "WEB 1285"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.22936164),
        dec: Angle.Degrees(-35.74589376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175693"},
        {"Hipparcos Number", "HIP 93109"},
        {"Geneva Identification System", "GEN# +1.00175693"},
        {"Smithsonian Astrophysical Observation", "SAO 210762"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.51995241),
        dec: Angle.Degrees(-35.74479044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210793"},
        {"Hipparcos Number", "HIP 109723"},
        {"Smithsonian Astrophysical Observation", "SAO 213649"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.39318313),
        dec: Angle.Degrees(-35.74340655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151907"},
        {"Hipparcos Number", "HIP 82509"},
        {"Smithsonian Astrophysical Observation", "SAO 208105"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.95747307),
        dec: Angle.Degrees(-35.74203115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92589"},
        {"Hipparcos Number", "HIP 52273"},
        {"Fundamental Katalog 5th Edition", "FK5 2856"},
        {"Geneva Identification System", "GEN# +1.00092589J"},
        {"Smithsonian Astrophysical Observation", "SAO 201631"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.21482610),
        dec: Angle.Degrees(-35.74173139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63705"},
        {"Hipparcos Number", "HIP 38128"},
        {"Smithsonian Astrophysical Observation", "SAO 198473"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.20560040),
        dec: Angle.Degrees(-35.73975933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101863"},
        {"Hipparcos Number", "HIP 57153"},
        {"Geneva Identification System", "GEN# +1.00101863"},
        {"Smithsonian Astrophysical Observation", "SAO 202740"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.82228309),
        dec: Angle.Degrees(-35.73806699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144849"},
        {"Hipparcos Number", "HIP 79158"},
        {"Smithsonian Astrophysical Observation", "SAO 207390"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.34119586),
        dec: Angle.Degrees(-35.73654478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124010"},
        {"Hipparcos Number", "HIP 69355"},
        {"Smithsonian Astrophysical Observation", "SAO 205286"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.94006614),
        dec: Angle.Degrees(-35.73540201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171035"},
        {"Hipparcos Number", "HIP 91025"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.52999365),
        dec: Angle.Degrees(-35.73456533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175027"},
        {"Hipparcos Number", "HIP 92839"},
        {"Geneva Identification System", "GEN# +1.00175027"},
        {"Smithsonian Astrophysical Observation", "SAO 210706"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.73208193),
        dec: Angle.Degrees(-35.73426955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159091"},
        {"Hipparcos Number", "HIP 85972"},
        {"Geneva Identification System", "GEN# +1.00159091"},
        {"Smithsonian Astrophysical Observation", "SAO 208967"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.55910465),
        dec: Angle.Degrees(-35.73371001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68676"},
        {"Hipparcos Number", "HIP 40162"},
        {"Geneva Identification System", "GEN# +1.00068676"},
        {"Smithsonian Astrophysical Observation", "SAO 198924"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.03283873),
        dec: Angle.Degrees(-35.73287756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92678"},
        {"Hipparcos Number", "HIP 52324"},
        {"Celescope Catalog", "CEL 3636"},
        {"Geneva Identification System", "GEN# +1.00092678"},
        {"Smithsonian Astrophysical Observation", "SAO 201641"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.37648463),
        dec: Angle.Degrees(-35.73111736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221004"},
        {"Hipparcos Number", "HIP 115888"},
        {"Smithsonian Astrophysical Observation", "SAO 214571"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.19102529),
        dec: Angle.Degrees(-35.72933264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75288"},
        {"Hipparcos Number", "HIP 43190"},
        {"Geneva Identification System", "GEN# +1.00075288"},
        {"Smithsonian Astrophysical Observation", "SAO 199635"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.99176168),
        dec: Angle.Degrees(-35.72748701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148824"},
        {"Hipparcos Number", "HIP 80977"},
        {"Smithsonian Astrophysical Observation", "SAO 207743"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.04632091),
        dec: Angle.Degrees(-35.72640166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159652"},
        {"Hipparcos Number", "HIP 86238"},
        {"Smithsonian Astrophysical Observation", "SAO 209035"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.34475885),
        dec: Angle.Degrees(-35.72611498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185679"},
        {"Hipparcos Number", "HIP 96881"},
        {"Geneva Identification System", "GEN# +1.00185679"},
        {"Smithsonian Astrophysical Observation", "SAO 211479"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.40030977),
        dec: Angle.Degrees(-35.72531850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2596"},
        {"Hipparcos Number", "HIP 2303"},
        {"Smithsonian Astrophysical Observation", "SAO 192561"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.34654481),
        dec: Angle.Degrees(-35.72512627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149274"},
        {"Hipparcos Number", "HIP 81208"},
        {"Geneva Identification System", "GEN# +1.00149274"},
        {"Smithsonian Astrophysical Observation", "SAO 207794"},
    },
    visualMagnitude: 6.63,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.80769312),
        dec: Angle.Degrees(-35.72458252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128807"},
        {"Hipparcos Number", "HIP 71705"},
        {"Smithsonian Astrophysical Observation", "SAO 205815"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.01748307),
        dec: Angle.Degrees(-35.72370704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92136"},
        {"Hipparcos Number", "HIP 52022"},
        {"Celescope Catalog", "CEL 3597"},
        {"Geneva Identification System", "GEN# +1.00092136"},
        {"Smithsonian Astrophysical Observation", "SAO 201576"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.42530724),
        dec: Angle.Degrees(-35.72002197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98651"},
        {"Hipparcos Number", "HIP 55399"},
        {"Geneva Identification System", "GEN# +1.00098651"},
        {"Smithsonian Astrophysical Observation", "SAO 202343"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.17687590),
        dec: Angle.Degrees(-35.71952715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140994"},
        {"Hipparcos Number", "HIP 77393"},
        {"Smithsonian Astrophysical Observation", "SAO 206989"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.98067089),
        dec: Angle.Degrees(-35.71921024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33377"},
        {"Hipparcos Number", "HIP 23910"},
        {"Geneva Identification System", "GEN# +1.00033377"},
        {"Smithsonian Astrophysical Observation", "SAO 195581"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.06140470),
        dec: Angle.Degrees(-35.71828639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219425"},
        {"Hipparcos Number", "HIP 114866"},
        {"Smithsonian Astrophysical Observation", "SAO 214414"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.99539407),
        dec: Angle.Degrees(-35.71767184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47476"},
    },
    visualMagnitude: 11.54,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.17003316),
        dec: Angle.Degrees(-35.71564926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6005"},
        {"Geneva Identification System", "GEN# -0.03600491"},
    },
    visualMagnitude: 11.31,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.31392861),
        dec: Angle.Degrees(-35.71547383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117085"},
        {"Hipparcos Number", "HIP 65738"},
        {"Smithsonian Astrophysical Observation", "SAO 204504"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.13410281),
        dec: Angle.Degrees(-35.71535496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202227"},
        {"Hipparcos Number", "HIP 104943"},
        {"Smithsonian Astrophysical Observation", "SAO 212835"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.86922776),
        dec: Angle.Degrees(-35.71491789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82514"},
        {"Hipparcos Number", "HIP 46736"},
        {"Geneva Identification System", "GEN# +1.00082514"},
        {"Smithsonian Astrophysical Observation", "SAO 200462"},
        {"Wilson Evans Batten Catalogue", "WEB 8815"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.88722307),
        dec: Angle.Degrees(-35.71432898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219340"},
        {"Hipparcos Number", "HIP 114801"},
        {"Smithsonian Astrophysical Observation", "SAO 214405"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.83074430),
        dec: Angle.Degrees(-35.71400883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38078"},
        {"Hipparcos Number", "HIP 26787"},
        {"Geneva Identification System", "GEN# +1.00038078"},
        {"Smithsonian Astrophysical Observation", "SAO 196090"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.34749551),
        dec: Angle.Degrees(-35.71380323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20532"},
        {"Hipparcos Number", "HIP 15262"},
        {"Geneva Identification System", "GEN# +1.00020532"},
        {"Smithsonian Astrophysical Observation", "SAO 194207"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.21785459),
        dec: Angle.Degrees(-35.71295758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206997"},
        {"Hipparcos Number", "HIP 107535"},
        {"Smithsonian Astrophysical Observation", "SAO 213277"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.70195783),
        dec: Angle.Degrees(-35.70723766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135998"},
        {"Hipparcos Number", "HIP 74980"},
        {"Smithsonian Astrophysical Observation", "SAO 206519"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.83699718),
        dec: Angle.Degrees(-35.70539054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32846"},
        {"Hipparcos Number", "HIP 23596"},
        {"Geneva Identification System", "GEN# +1.00032846"},
        {"Smithsonian Astrophysical Observation", "SAO 195534"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.10890221),
        dec: Angle.Degrees(-35.70520775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120237A"},
        {"Henry Draper 2", "HD 120237"},
        {"Hipparcos Number", "HIP 67408"},
        {"Cincinnati Publication", "Ci 20 811"},
        {"Geneva Identification System", "GEN# +1.00120237A"},
        {"Smithsonian Astrophysical Observation", "SAO 204867"},
        {"Wilson Evans Batten Catalogue", "WEB 11854"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.23102215),
        dec: Angle.Degrees(-35.70373680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -526.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24755"},
        {"Hipparcos Number", "HIP 18305"},
        {"Geneva Identification System", "GEN# +1.00024755"},
        {"Smithsonian Astrophysical Observation", "SAO 194620"},
        {"Wilson Evans Batten Catalogue", "WEB 3535"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.70393342),
        dec: Angle.Degrees(-35.70365244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 218.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111234"},
        {"Hipparcos Number", "HIP 62467"},
        {"Fundamental Katalog 5th Edition", "FK5 5132"},
        {"Geneva Identification System", "GEN# +1.00111234"},
        {"Smithsonian Astrophysical Observation", "SAO 203819"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.02646187),
        dec: Angle.Degrees(-35.70332177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22026"},
        {"Hipparcos Number", "HIP 16442"},
        {"Smithsonian Astrophysical Observation", "SAO 194358"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.93835167),
        dec: Angle.Degrees(-35.70312384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51524"},
        {"Hipparcos Number", "HIP 33341"},
        {"Smithsonian Astrophysical Observation", "SAO 197379"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.01072421),
        dec: Angle.Degrees(-35.70165190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29054"},
        {"Hipparcos Number", "HIP 21209"},
        {"Geneva Identification System", "GEN# +1.00029054"},
        {"Smithsonian Astrophysical Observation", "SAO 195116"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.23840494),
        dec: Angle.Degrees(-35.70133852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161511"},
        {"Hipparcos Number", "HIP 87063"},
        {"Geneva Identification System", "GEN# +1.00161511"},
        {"Smithsonian Astrophysical Observation", "SAO 209256"},
        {"Wilson Evans Batten Catalogue", "WEB 14688"},
    },
    visualMagnitude: 7.66,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.86766174),
        dec: Angle.Degrees(-35.70126411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139560"},
        {"Hipparcos Number", "HIP 76727"},
        {"Smithsonian Astrophysical Observation", "SAO 206851"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.02460054),
        dec: Angle.Degrees(-35.70047033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116144"},
        {"Hipparcos Number", "HIP 65244"},
        {"Geneva Identification System", "GEN# +1.00116144"},
        {"Smithsonian Astrophysical Observation", "SAO 204398"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.55873785),
        dec: Angle.Degrees(-35.69771205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45439"},
        {"Hipparcos Number", "HIP 30587"},
        {"Celescope Catalog", "CEL 1237"},
        {"Geneva Identification System", "GEN# +1.00045439"},
        {"Renson", "Renson 12040"},
        {"Smithsonian Astrophysical Observation", "SAO 196810"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.42693347),
        dec: Angle.Degrees(-35.69743047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82826"},
        {"Hipparcos Number", "HIP 46907"},
        {"Smithsonian Astrophysical Observation", "SAO 200498"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.40131719),
        dec: Angle.Degrees(-35.69668411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209507"},
        {"Hipparcos Number", "HIP 108982"},
        {"Smithsonian Astrophysical Observation", "SAO 213522"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.17648629),
        dec: Angle.Degrees(-35.69638445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131835"},
        {"Hipparcos Number", "HIP 73145"},
        {"Smithsonian Astrophysical Observation", "SAO 206117"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.22701941),
        dec: Angle.Degrees(-35.69539994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105078"},
        {"Hipparcos Number", "HIP 59008"},
        {"Fundamental Katalog 5th Edition", "FK5 1312"},
        {"Geneva Identification System", "GEN# +1.00105078"},
        {"Smithsonian Astrophysical Observation", "SAO 203119"},
        {"Wilson Evans Batten Catalogue", "WEB 10509"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.48621209),
        dec: Angle.Degrees(-35.69393235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6207"},
        {"Hipparcos Number", "HIP 4876"},
        {"Smithsonian Astrophysical Observation", "SAO 192887"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.67488602),
        dec: Angle.Degrees(-35.69337191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61828"},
        {"Hipparcos Number", "HIP 37317"},
        {"Geneva Identification System", "GEN# +1.00061828"},
        {"Smithsonian Astrophysical Observation", "SAO 198263"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.91975270),
        dec: Angle.Degrees(-35.69184141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20484"},
        {"Hipparcos Number", "HIP 15239"},
        {"Geneva Identification System", "GEN# +1.00020484"},
        {"Smithsonian Astrophysical Observation", "SAO 194202"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.13624705),
        dec: Angle.Degrees(-35.69117220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148337"},
        {"Hipparcos Number", "HIP 80714"},
        {"Smithsonian Astrophysical Observation", "SAO 207696"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.19262317),
        dec: Angle.Degrees(-35.68999826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80275"},
        {"Hipparcos Number", "HIP 45607"},
        {"Smithsonian Astrophysical Observation", "SAO 200198"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.44426083),
        dec: Angle.Degrees(-35.68994379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163303"},
        {"Hipparcos Number", "HIP 87874"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.25798953),
        dec: Angle.Degrees(-35.68991070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152991"},
        {"Hipparcos Number", "HIP 83060"},
        {"Smithsonian Astrophysical Observation", "SAO 208245"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.58415528),
        dec: Angle.Degrees(-35.68890201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69280"},
        {"Hipparcos Number", "HIP 40407"},
        {"Smithsonian Astrophysical Observation", "SAO 198991"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.73628630),
        dec: Angle.Degrees(-35.68878862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77536"},
        {"Hipparcos Number", "HIP 44360"},
        {"Smithsonian Astrophysical Observation", "SAO 199898"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.50743045),
        dec: Angle.Degrees(-35.68830761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150151"},
        {"Hipparcos Number", "HIP 81639"},
        {"Geneva Identification System", "GEN# +1.00150151"},
        {"Smithsonian Astrophysical Observation", "SAO 207909"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.15770647),
        dec: Angle.Degrees(-35.68715946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15518"},
        {"Hipparcos Number", "HIP 11561"},
        {"Smithsonian Astrophysical Observation", "SAO 193733"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.23538301),
        dec: Angle.Degrees(-35.68596238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105632"},
        {"Smithsonian Astrophysical Observation", "SAO 212970"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.92283256),
        dec: Angle.Degrees(-35.68555828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147597"},
        {"Hipparcos Number", "HIP 80359"},
        {"Geneva Identification System", "GEN# +1.00147597"},
        {"Smithsonian Astrophysical Observation", "SAO 207629"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.06270316),
        dec: Angle.Degrees(-35.68426229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79362"},
        {"Hipparcos Number", "HIP 45190"},
        {"Smithsonian Astrophysical Observation", "SAO 200099"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.13060570),
        dec: Angle.Degrees(-35.68420840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53964"},
        {"Geneva Identification System", "GEN# -0.03506917"},
        {"Smithsonian Astrophysical Observation", "SAO 202026"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.60199929),
        dec: Angle.Degrees(-35.68359378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219456"},
        {"Hipparcos Number", "HIP 114873"},
        {"Smithsonian Astrophysical Observation", "SAO 214418"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.01754097),
        dec: Angle.Degrees(-35.68315297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21574"},
        {"Hipparcos Number", "HIP 16112"},
        {"Fundamental Katalog 5th Edition", "FK5 2244"},
        {"Geneva Identification System", "GEN# +1.00021574"},
        {"Smithsonian Astrophysical Observation", "SAO 194312"},
        {"Wilson Evans Batten Catalogue", "WEB 3072"},
    },
    visualMagnitude: 5.71,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.88902397),
        dec: Angle.Degrees(-35.68133899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9291"},
        {"Hipparcos Number", "HIP 7047"},
        {"Geneva Identification System", "GEN# +1.00009291"},
        {"Smithsonian Astrophysical Observation", "SAO 193155"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.70974846),
        dec: Angle.Degrees(-35.68114170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112596"},
        {"Smithsonian Astrophysical Observation", "SAO 214096"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.07110685),
        dec: Angle.Degrees(-35.68065576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165060"},
        {"Hipparcos Number", "HIP 88625"},
        {"Smithsonian Astrophysical Observation", "SAO 209689"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.42777917),
        dec: Angle.Degrees(-35.67983548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142429"},
        {"Hipparcos Number", "HIP 78020"},
        {"Geneva Identification System", "GEN# +1.00142429"},
        {"Smithsonian Astrophysical Observation", "SAO 207123"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.96079326),
        dec: Angle.Degrees(-35.67603478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193567"},
        {"Hipparcos Number", "HIP 100449"},
        {"Smithsonian Astrophysical Observation", "SAO 212050"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.55487464),
        dec: Angle.Degrees(-35.67593244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17829"},
        {"Hipparcos Number", "HIP 13265"},
        {"Geneva Identification System", "GEN# +1.00017829"},
        {"Smithsonian Astrophysical Observation", "SAO 193944"},
        {"Wilson Evans Batten Catalogue", "WEB 2662"},
    },
    visualMagnitude: 5.48,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.66834974),
        dec: Angle.Degrees(-35.67571664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212723"},
        {"Hipparcos Number", "HIP 110805"},
        {"Smithsonian Astrophysical Observation", "SAO 213818"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.74278497),
        dec: Angle.Degrees(-35.67561390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28187"},
        {"Hipparcos Number", "HIP 20638"},
        {"Geneva Identification System", "GEN# +1.00028187"},
        {"Smithsonian Astrophysical Observation", "SAO 195001"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.34886891),
        dec: Angle.Degrees(-35.67540877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38885"},
        {"Hipparcos Number", "HIP 27325"},
        {"Geneva Identification System", "GEN# +1.00038885"},
        {"Smithsonian Astrophysical Observation", "SAO 196171"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.82787287),
        dec: Angle.Degrees(-35.67422033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193302"},
        {"Hipparcos Number", "HIP 100332"},
        {"Fundamental Katalog 5th Edition", "FK5 1530"},
        {"Geneva Identification System", "GEN# +1.00193302"},
        {"Smithsonian Astrophysical Observation", "SAO 212025"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.21612805),
        dec: Angle.Degrees(-35.67372299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13513"},
        {"Hipparcos Number", "HIP 10191"},
        {"Smithsonian Astrophysical Observation", "SAO 193561"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.75971117),
        dec: Angle.Degrees(-35.67024597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103556"},
        {"Hipparcos Number", "HIP 58123"},
        {"Smithsonian Astrophysical Observation", "SAO 202942"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.82658204),
        dec: Angle.Degrees(-35.66954133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164320"},
        {"Hipparcos Number", "HIP 88309"},
        {"Geneva Identification System", "GEN# +1.00164320"},
        {"Smithsonian Astrophysical Observation", "SAO 209614"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.52176083),
        dec: Angle.Degrees(-35.66941895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109039"},
        {"Hipparcos Number", "HIP 61160"},
        {"Smithsonian Astrophysical Observation", "SAO 203564"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.98832505),
        dec: Angle.Degrees(-35.65032124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95091"},
        {"Hipparcos Number", "HIP 53618"},
        {"Smithsonian Astrophysical Observation", "SAO 201951"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.54626288),
        dec: Angle.Degrees(-35.66559377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40611"},
        {"Hipparcos Number", "HIP 28266"},
        {"Smithsonian Astrophysical Observation", "SAO 196365"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.58747667),
        dec: Angle.Degrees(-35.66462727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120987"},
        {"Hipparcos Number", "HIP 67819"},
        {"Geneva Identification System", "GEN# +1.00120987"},
        {"Smithsonian Astrophysical Observation", "SAO 204955"},
        {"Wilson Evans Batten Catalogue", "WEB 11923"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.38675080),
        dec: Angle.Degrees(-35.66419416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108359"},
        {"Smithsonian Astrophysical Observation", "SAO 213429"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.28043414),
        dec: Angle.Degrees(-35.66350119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56737"},
    },
    visualMagnitude: 11.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.49140969),
        dec: Angle.Degrees(-35.66207538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88217"},
        {"Hipparcos Number", "HIP 49772"},
        {"Smithsonian Astrophysical Observation", "SAO 201112"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.39864887),
        dec: Angle.Degrees(-35.66102425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6619"},
        {"Hipparcos Number", "HIP 5193"},
        {"Geneva Identification System", "GEN# +1.00006619"},
        {"Renson", "Renson 1690"},
        {"Smithsonian Astrophysical Observation", "SAO 192925"},
        {"Wilson Evans Batten Catalogue", "WEB 1087"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.61054202),
        dec: Angle.Degrees(-35.66062274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212575"},
        {"Hipparcos Number", "HIP 110717"},
        {"Smithsonian Astrophysical Observation", "SAO 213813"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.47939152),
        dec: Angle.Degrees(-35.66059297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220231"},
        {"Hipparcos Number", "HIP 115382"},
        {"Smithsonian Astrophysical Observation", "SAO 214495"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.59977977),
        dec: Angle.Degrees(-35.65755686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29231"},
        {"Hipparcos Number", "HIP 21327"},
        {"Geneva Identification System", "GEN# +1.00029231"},
        {"Smithsonian Astrophysical Observation", "SAO 195135"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.66070415),
        dec: Angle.Degrees(-35.65750571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12417"},
        {"Hipparcos Number", "HIP 9412"},
        {"Smithsonian Astrophysical Observation", "SAO 193453"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.22911129),
        dec: Angle.Degrees(-35.65695591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186132"},
        {"Hipparcos Number", "HIP 97111"},
        {"Smithsonian Astrophysical Observation", "SAO 211515"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.03191804),
        dec: Angle.Degrees(-35.65551443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144075"},
        {"Hipparcos Number", "HIP 78819"},
        {"Smithsonian Astrophysical Observation", "SAO 207314"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.35517233),
        dec: Angle.Degrees(-35.65542171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84288"},
        {"Hipparcos Number", "HIP 47671"},
        {"Smithsonian Astrophysical Observation", "SAO 200660"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.80830009),
        dec: Angle.Degrees(-35.65382776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28776"},
        {"Hipparcos Number", "HIP 21042"},
        {"Fundamental Katalog 5th Edition", "FK5 2334"},
        {"Geneva Identification System", "GEN# +1.00028776"},
        {"Smithsonian Astrophysical Observation", "SAO 195085"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.66803902),
        dec: Angle.Degrees(-35.65358006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76300"},
        {"Hipparcos Number", "HIP 43704"},
        {"Geneva Identification System", "GEN# +1.00076300"},
        {"Smithsonian Astrophysical Observation", "SAO 199763"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.50483439),
        dec: Angle.Degrees(-35.65081964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54880"},
        {"Smithsonian Astrophysical Observation", "SAO 202226"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.56058703),
        dec: Angle.Degrees(-35.65002817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125510"},
        {"Hipparcos Number", "HIP 70102"},
        {"Smithsonian Astrophysical Observation", "SAO 205458"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.17554856),
        dec: Angle.Degrees(-35.64903954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100144"},
        {"Hipparcos Number", "HIP 56200"},
        {"Smithsonian Astrophysical Observation", "SAO 202525"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.80648080),
        dec: Angle.Degrees(-35.64879984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118085"},
        {"Henry Draper 2", "HD 118085A"},
        {"Hipparcos Number", "HIP 66295"},
        {"Renson", "Renson 34050"},
        {"Smithsonian Astrophysical Observation", "SAO 204620"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.80802726),
        dec: Angle.Degrees(-35.64867514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160282"},
        {"Hipparcos Number", "HIP 86500"},
        {"Smithsonian Astrophysical Observation", "SAO 209119"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.15203067),
        dec: Angle.Degrees(-35.64806437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44552"},
        {"Hipparcos Number", "HIP 30151"},
        {"Smithsonian Astrophysical Observation", "SAO 196712"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.17123519),
        dec: Angle.Degrees(-35.64805317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104948"},
        {"Hipparcos Number", "HIP 58931"},
        {"Smithsonian Astrophysical Observation", "SAO 203108"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.25213087),
        dec: Angle.Degrees(-35.64776814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90228"},
        {"Hipparcos Number", "HIP 50948"},
        {"Geneva Identification System", "GEN# +1.00090228"},
        {"Smithsonian Astrophysical Observation", "SAO 201359"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.07417921),
        dec: Angle.Degrees(-35.64725094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40005"},
        {"Smithsonian Astrophysical Observation", "SAO 198875"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.55056981),
        dec: Angle.Degrees(-35.64670802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122776"},
        {"Hipparcos Number", "HIP 68775"},
        {"Smithsonian Astrophysical Observation", "SAO 205143"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.15544519),
        dec: Angle.Degrees(-35.64534649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206149"},
        {"Hipparcos Number", "HIP 107067"},
        {"Geneva Identification System", "GEN# +1.00206149"},
        {"Smithsonian Astrophysical Observation", "SAO 213200"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.26649822),
        dec: Angle.Degrees(-35.64502715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180831"},
        {"Hipparcos Number", "HIP 94963"},
        {"Smithsonian Astrophysical Observation", "SAO 211168"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.86548218),
        dec: Angle.Degrees(-35.64455760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29767"},
        {"Hipparcos Number", "HIP 21724"},
        {"Geneva Identification System", "GEN# +1.00029767"},
        {"Smithsonian Astrophysical Observation", "SAO 195209"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.96404635),
        dec: Angle.Degrees(-35.64400687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144988"},
        {"Hipparcos Number", "HIP 79214"},
        {"Geneva Identification System", "GEN# +1.00144988"},
        {"Smithsonian Astrophysical Observation", "SAO 207405"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.50225991),
        dec: Angle.Degrees(-35.64237519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172910"},
        {"Hipparcos Number", "HIP 91918"},
        {"Fundamental Katalog 5th Edition", "FK5 3490"},
        {"Geneva Identification System", "GEN# +1.00172910J"},
        {"Smithsonian Astrophysical Observation", "SAO 210509"},
        {"Wilson Evans Batten Catalogue", "WEB 15824"},
    },
    visualMagnitude: 4.86,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.08066463),
        dec: Angle.Degrees(-35.64192109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103317"},
        {"Hipparcos Number", "HIP 57993"},
        {"Smithsonian Astrophysical Observation", "SAO 202916"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.42580445),
        dec: Angle.Degrees(-35.64138821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114406"},
        {"Hipparcos Number", "HIP 64300"},
        {"Smithsonian Astrophysical Observation", "SAO 204195"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.68308195),
        dec: Angle.Degrees(-35.64089679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197258"},
        {"Hipparcos Number", "HIP 102305"},
        {"Smithsonian Astrophysical Observation", "SAO 212385"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.93096541),
        dec: Angle.Degrees(-35.64020941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2015"},
        {"Hipparcos Number", "HIP 1929"},
        {"Smithsonian Astrophysical Observation", "SAO 192506"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.07975400),
        dec: Angle.Degrees(-35.64012280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166746"},
        {"Hipparcos Number", "HIP 89322"},
        {"Smithsonian Astrophysical Observation", "SAO 209866"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.38969315),
        dec: Angle.Degrees(-35.63982564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138089"},
        {"Hipparcos Number", "HIP 75986"},
        {"Smithsonian Astrophysical Observation", "SAO 206718"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.76511240),
        dec: Angle.Degrees(-35.63970280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82085"},
        {"Smithsonian Astrophysical Observation", "SAO 208008"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.50613304),
        dec: Angle.Degrees(-35.63909348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33511"},
        {"Hipparcos Number", "HIP 23975"},
        {"Smithsonian Astrophysical Observation", "SAO 195601"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.29650820),
        dec: Angle.Degrees(-35.63859469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207363"},
        {"Hipparcos Number", "HIP 107715"},
        {"Smithsonian Astrophysical Observation", "SAO 213312"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.30286861),
        dec: Angle.Degrees(-35.63851761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 321070"},
        {"Hipparcos Number", "HIP 88224"},
        {"Smithsonian Astrophysical Observation", "SAO 209591"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.24646570),
        dec: Angle.Degrees(-35.63837710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25325"},
        {"Hipparcos Number", "HIP 18682"},
        {"Smithsonian Astrophysical Observation", "SAO 194680"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.01041960),
        dec: Angle.Degrees(-35.63796718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167231"},
        {"Hipparcos Number", "HIP 89499"},
        {"Geneva Identification System", "GEN# +1.00167231"},
        {"Smithsonian Astrophysical Observation", "SAO 209923"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.95803070),
        dec: Angle.Degrees(-35.63728941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22862"},
        {"Hipparcos Number", "HIP 17023"},
        {"Geneva Identification System", "GEN# +1.00022862"},
        {"Smithsonian Astrophysical Observation", "SAO 194428"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.74362886),
        dec: Angle.Degrees(-35.63593033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55524"},
        {"Hipparcos Number", "HIP 34747"},
        {"Geneva Identification System", "GEN# +1.00055524"},
        {"Smithsonian Astrophysical Observation", "SAO 197681"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.90873178),
        dec: Angle.Degrees(-35.63477383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111608"},
        {"Hipparcos Number", "HIP 62692"},
        {"Smithsonian Astrophysical Observation", "SAO 203864"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.69571529),
        dec: Angle.Degrees(-35.63439039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107913"},
        {"Hipparcos Number", "HIP 60502"},
        {"Smithsonian Astrophysical Observation", "SAO 203430"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.05001718),
        dec: Angle.Degrees(-35.63375113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112378"},
        {"Hipparcos Number", "HIP 63171"},
        {"Smithsonian Astrophysical Observation", "SAO 203954"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.14316494),
        dec: Angle.Degrees(-35.63345134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48761"},
        {"Hipparcos Number", "HIP 32203"},
        {"Renson", "Renson 13030"},
        {"Smithsonian Astrophysical Observation", "SAO 197132"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.82884537),
        dec: Angle.Degrees(-35.63110249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86018"},
        {"Hipparcos Number", "HIP 48625"},
        {"Smithsonian Astrophysical Observation", "SAO 200863"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.73842182),
        dec: Angle.Degrees(-35.63058980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37658"},
        {"Smithsonian Astrophysical Observation", "SAO 198350"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.91219836),
        dec: Angle.Degrees(-35.62958157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173809"},
        {"Hipparcos Number", "HIP 92303"},
        {"Geneva Identification System", "GEN# +1.00173809"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.19773966),
        dec: Angle.Degrees(-35.62924544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51588"},
    },
    visualMagnitude: 12.16,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)32, 14.1200),
        dec: Angle.DegreesMinutesSeconds((int)-35, (int)37, 41.500)
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
    primaryId: "HIP 81760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150351"},
        {"Hipparcos Number", "HIP 81760"},
        {"Smithsonian Astrophysical Observation", "SAO 207935"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.50306096),
        dec: Angle.Degrees(-35.62630255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186830"},
        {"Hipparcos Number", "HIP 97436"},
        {"Smithsonian Astrophysical Observation", "SAO 211563"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.05732905),
        dec: Angle.Degrees(-35.62457589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162517"},
        {"Hipparcos Number", "HIP 87532"},
        {"Geneva Identification System", "GEN# +1.00162517"},
        {"Smithsonian Astrophysical Observation", "SAO 209404"},
        {"Wilson Evans Batten Catalogue", "WEB 14764"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.23999275),
        dec: Angle.Degrees(-35.62418307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174498"},
        {"Hipparcos Number", "HIP 92618"},
        {"Smithsonian Astrophysical Observation", "SAO 210653"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.07478065),
        dec: Angle.Degrees(-35.62400647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31586"},
        {"Hipparcos Number", "HIP 22895"},
        {"Geneva Identification System", "GEN# +1.00031586"},
        {"Smithsonian Astrophysical Observation", "SAO 195406"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.86803084),
        dec: Angle.Degrees(-35.62232748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3696"},
        {"Hipparcos Number", "HIP 3100"},
        {"Geneva Identification System", "GEN# +1.00003696"},
        {"Smithsonian Astrophysical Observation", "SAO 192658"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.86692327),
        dec: Angle.Degrees(-35.62150125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220904"},
        {"Hipparcos Number", "HIP 115818"},
        {"Smithsonian Astrophysical Observation", "SAO 214559"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.94816896),
        dec: Angle.Degrees(-35.62126373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117341"},
        {"Smithsonian Astrophysical Observation", "SAO 214777"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.88956895),
        dec: Angle.Degrees(-35.62098184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29483"},
        {"Hipparcos Number", "HIP 21494"},
        {"Smithsonian Astrophysical Observation", "SAO 195167"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.25007106),
        dec: Angle.Degrees(-35.61943495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116859"},
        {"Hipparcos Number", "HIP 65601"},
        {"Geneva Identification System", "GEN# +1.00116859"},
        {"Smithsonian Astrophysical Observation", "SAO 204482"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.75709731),
        dec: Angle.Degrees(-35.61899057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114561"},
        {"Hipparcos Number", "HIP 64384"},
        {"Geneva Identification System", "GEN# +1.00114561"},
        {"Smithsonian Astrophysical Observation", "SAO 204217"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.93837347),
        dec: Angle.Degrees(-35.61858813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64640"},
        {"Hipparcos Number", "HIP 38531"},
        {"Smithsonian Astrophysical Observation", "SAO 198563"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.35358471),
        dec: Angle.Degrees(-35.61828630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10712"},
    },
    visualMagnitude: 11.62,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.48535952),
        dec: Angle.Degrees(-35.61750142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 421.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 277.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215422"},
        {"Hipparcos Number", "HIP 112366"},
        {"Smithsonian Astrophysical Observation", "SAO 214056"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.39174512),
        dec: Angle.Degrees(-35.61646078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53957"},
    },
    visualMagnitude: 11.81,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.59405351),
        dec: Angle.Degrees(-35.61613008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206681"},
        {"Hipparcos Number", "HIP 107356"},
        {"Smithsonian Astrophysical Observation", "SAO 213251"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.16688079),
        dec: Angle.Degrees(-35.61569233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150987"},
        {"Hipparcos Number", "HIP 82088"},
        {"Geneva Identification System", "GEN# +1.00150987"},
        {"Smithsonian Astrophysical Observation", "SAO 208010"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.52054329),
        dec: Angle.Degrees(-35.61369971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114013"},
        {"Smithsonian Astrophysical Observation", "SAO 214300"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.34835144),
        dec: Angle.Degrees(-35.61323040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82065"},
        {"Hipparcos Number", "HIP 46476"},
        {"Geneva Identification System", "GEN# +1.00082065"},
        {"Smithsonian Astrophysical Observation", "SAO 200407"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.17735909),
        dec: Angle.Degrees(-35.61279065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92907"},
        {"Hipparcos Number", "HIP 52431"},
        {"Smithsonian Astrophysical Observation", "SAO 201668"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.77611715),
        dec: Angle.Degrees(-35.61274075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100721"},
        {"Hipparcos Number", "HIP 56520"},
        {"Smithsonian Astrophysical Observation", "SAO 202599"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.80896141),
        dec: Angle.Degrees(-35.61204720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122027"},
        {"Hipparcos Number", "HIP 68385"},
        {"Smithsonian Astrophysical Observation", "SAO 205074"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.98280162),
        dec: Angle.Degrees(-35.61063066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71235"},
        {"Hipparcos Number", "HIP 41241"},
        {"Smithsonian Astrophysical Observation", "SAO 199195"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.22254771),
        dec: Angle.Degrees(-35.60941552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8222"},
        {"Hipparcos Number", "HIP 6313"},
        {"Smithsonian Astrophysical Observation", "SAO 193066"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.27519892),
        dec: Angle.Degrees(-35.60815014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102198"},
        {"Hipparcos Number", "HIP 57365"},
        {"Smithsonian Astrophysical Observation", "SAO 202779"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.40585790),
        dec: Angle.Degrees(-35.60532373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101613"},
        {"Hipparcos Number", "HIP 57016"},
        {"Fundamental Katalog 5th Edition", "FK5 5035"},
        {"Smithsonian Astrophysical Observation", "SAO 202714"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.34397546),
        dec: Angle.Degrees(-35.60368128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93882"},
        {"Smithsonian Astrophysical Observation", "SAO 210940"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.78207735),
        dec: Angle.Degrees(-35.60362414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225112"},
        {"Hipparcos Number", "HIP 285"},
        {"Smithsonian Astrophysical Observation", "SAO 192343"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.88067333),
        dec: Angle.Degrees(-35.60222342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74950"},
        {"Hipparcos Number", "HIP 42999"},
        {"Geneva Identification System", "GEN# +1.00074950"},
        {"Smithsonian Astrophysical Observation", "SAO 199587"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.45152497),
        dec: Angle.Degrees(-35.60031743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128614"},
        {"Hipparcos Number", "HIP 71625"},
        {"Geneva Identification System", "GEN# +1.00128614"},
        {"Smithsonian Astrophysical Observation", "SAO 205800"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.73323981),
        dec: Angle.Degrees(-35.60011003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16033"},
        {"Smithsonian Astrophysical Observation", "SAO 194299"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.62499999),
        dec: Angle.Degrees(-35.59781126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194783"},
        {"Hipparcos Number", "HIP 101017"},
        {"Fundamental Katalog 5th Edition", "FK5 3637"},
        {"Geneva Identification System", "GEN# +1.00194783"},
        {"Renson", "Renson 54330"},
        {"Smithsonian Astrophysical Observation", "SAO 212160"},
    },
    visualMagnitude: 6.09,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.19473436),
        dec: Angle.Degrees(-35.59581290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58868"},
        {"Hipparcos Number", "HIP 36061"},
        {"Renson", "Renson 16070"},
        {"Smithsonian Astrophysical Observation", "SAO 197988"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.47658277),
        dec: Angle.Degrees(-35.59305745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75080"},
        {"Hipparcos Number", "HIP 43097"},
        {"Smithsonian Astrophysical Observation", "SAO 199606"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.65863724),
        dec: Angle.Degrees(-35.58851440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137573"},
        {"Hipparcos Number", "HIP 75709"},
        {"Smithsonian Astrophysical Observation", "SAO 206668"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.00536628),
        dec: Angle.Degrees(-35.58729763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206181"},
        {"Hipparcos Number", "HIP 107079"},
        {"Smithsonian Astrophysical Observation", "SAO 213203"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.32774221),
        dec: Angle.Degrees(-35.58504223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203817"},
        {"Hipparcos Number", "HIP 105799"},
        {"Smithsonian Astrophysical Observation", "SAO 212986"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.39011310),
        dec: Angle.Degrees(-35.58427095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206394"},
        {"Hipparcos Number", "HIP 107195"},
        {"Smithsonian Astrophysical Observation", "SAO 213220"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.68479406),
        dec: Angle.Degrees(-35.58195614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223563"},
        {"Hipparcos Number", "HIP 117575"},
        {"Smithsonian Astrophysical Observation", "SAO 214807"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.66037173),
        dec: Angle.Degrees(-35.58152710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181999"},
        {"Hipparcos Number", "HIP 95366"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.01810723),
        dec: Angle.Degrees(-35.58113689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84201"},
        {"Hipparcos Number", "HIP 47612"},
        {"Smithsonian Astrophysical Observation", "SAO 200650"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.62178550),
        dec: Angle.Degrees(-35.57797427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44360"},
        {"Hipparcos Number", "HIP 30081"},
        {"Smithsonian Astrophysical Observation", "SAO 196690"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.95052755),
        dec: Angle.Degrees(-35.55280516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130362"},
        {"Hipparcos Number", "HIP 72445"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.20965020),
        dec: Angle.Degrees(-35.57667675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29251"},
        {"Hipparcos Number", "HIP 21355"},
        {"Geneva Identification System", "GEN# +1.00029251"},
        {"Smithsonian Astrophysical Observation", "SAO 195141"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.72953277),
        dec: Angle.Degrees(-35.57624903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206253"},
        {"Hipparcos Number", "HIP 107109"},
        {"Smithsonian Astrophysical Observation", "SAO 213208"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.44079834),
        dec: Angle.Degrees(-35.57488017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91833"},
        {"Hipparcos Number", "HIP 51854"},
        {"Smithsonian Astrophysical Observation", "SAO 201543"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.92431625),
        dec: Angle.Degrees(-35.57181569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117207"},
        {"Hipparcos Number", "HIP 65808"},
        {"Geneva Identification System", "GEN# +1.00117207"},
        {"Smithsonian Astrophysical Observation", "SAO 204517"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.33858618),
        dec: Angle.Degrees(-35.57082252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -204.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58785"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.85387709),
        dec: Angle.Degrees(-35.56811161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101478"},
        {"Smithsonian Astrophysical Observation", "SAO 212234"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.48291885),
        dec: Angle.Degrees(-35.56482676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117837",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117837"},
        {"Smithsonian Astrophysical Observation", "SAO 214842"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.48252911),
        dec: Angle.Degrees(-35.56468665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24787"},
        {"Hipparcos Number", "HIP 18332"},
        {"Smithsonian Astrophysical Observation", "SAO 194624"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.78186901),
        dec: Angle.Degrees(-35.56457920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95080"},
        {"Hipparcos Number", "HIP 53613"},
        {"Fundamental Katalog 5th Edition", "FK5 4968"},
        {"Smithsonian Astrophysical Observation", "SAO 201947"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.52714945),
        dec: Angle.Degrees(-35.56436105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18324"},
        {"Hipparcos Number", "HIP 13633"},
        {"Geneva Identification System", "GEN# +1.00018324"},
        {"Smithsonian Astrophysical Observation", "SAO 193985"},
        {"Wilson Evans Batten Catalogue", "WEB 2704"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.88464516),
        dec: Angle.Degrees(-35.56148216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192353"},
        {"Hipparcos Number", "HIP 99876"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.95572017),
        dec: Angle.Degrees(-35.56027939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198233"},
        {"Hipparcos Number", "HIP 102846"},
        {"Geneva Identification System", "GEN# +1.00198233"},
        {"Smithsonian Astrophysical Observation", "SAO 212474"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.52155085),
        dec: Angle.Degrees(-35.55898762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20301"},
        {"Hipparcos Number", "HIP 15092"},
        {"Fundamental Katalog 5th Edition", "FK5 1090"},
        {"Geneva Identification System", "GEN# +1.00020301"},
        {"Smithsonian Astrophysical Observation", "SAO 194176"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.66694973),
        dec: Angle.Degrees(-35.55770716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32043"},
        {"Smithsonian Astrophysical Observation", "SAO 197095"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.41478259),
        dec: Angle.Degrees(-35.55373559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 204.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17528"},
        {"Hipparcos Number", "HIP 13040"},
        {"Geneva Identification System", "GEN# +1.00017528"},
        {"Smithsonian Astrophysical Observation", "SAO 193916"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.89075106),
        dec: Angle.Degrees(-35.55053547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130388"},
        {"Hipparcos Number", "HIP 72459"},
        {"Fundamental Katalog 5th Edition", "FK5 5314"},
        {"Geneva Identification System", "GEN# +1.00130388"},
        {"Smithsonian Astrophysical Observation", "SAO 205974"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.25716843),
        dec: Angle.Degrees(-35.55021596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99695"},
        {"Hipparcos Number", "HIP 55946"},
        {"Smithsonian Astrophysical Observation", "SAO 202477"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.98411512),
        dec: Angle.Degrees(-35.54922673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156134"},
        {"Hipparcos Number", "HIP 84578"},
        {"Geneva Identification System", "GEN# +4.40130002"},
        {"Smithsonian Astrophysical Observation", "SAO 208631"},
        {"Wilson Evans Batten Catalogue", "WEB 14278"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.33716539),
        dec: Angle.Degrees(-35.54866477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52993"},
        {"Hipparcos Number", "HIP 33864"},
        {"Celescope Catalog", "CEL 1519"},
        {"Geneva Identification System", "GEN# +1.00052993"},
        {"Renson", "Renson 14550"},
        {"Smithsonian Astrophysical Observation", "SAO 197497"},
    },
    visualMagnitude: 6.58,
    bvColour: -0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.44673865),
        dec: Angle.Degrees(-35.54793668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 759"},
        {"Hipparcos Number", "HIP 961"},
        {"Smithsonian Astrophysical Observation", "SAO 192390"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.96256404),
        dec: Angle.Degrees(-35.54681427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212364"},
        {"Hipparcos Number", "HIP 110589"},
        {"Smithsonian Astrophysical Observation", "SAO 213791"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.06656719),
        dec: Angle.Degrees(-35.54673015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209174"},
        {"Hipparcos Number", "HIP 108773"},
        {"Smithsonian Astrophysical Observation", "SAO 213489"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.51976253),
        dec: Angle.Degrees(-35.54616040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121482"},
        {"Hipparcos Number", "HIP 68078"},
        {"Smithsonian Astrophysical Observation", "SAO 205010"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.08081181),
        dec: Angle.Degrees(-35.54592010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54642"},
    },
    visualMagnitude: 11.44,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.75422086),
        dec: Angle.Degrees(-35.54520790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -368.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27941"},
        {"Hipparcos Number", "HIP 20467"},
        {"Geneva Identification System", "GEN# +1.00027941"},
        {"Smithsonian Astrophysical Observation", "SAO 194971"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.78232507),
        dec: Angle.Degrees(-35.54484031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220929"},
        {"Hipparcos Number", "HIP 115833"},
        {"Fundamental Katalog 5th Edition", "FK5 3878"},
        {"Geneva Identification System", "GEN# +1.00220929"},
        {"Smithsonian Astrophysical Observation", "SAO 214561"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.00286076),
        dec: Angle.Degrees(-35.54448803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149062"},
        {"Hipparcos Number", "HIP 81099"},
        {"Geneva Identification System", "GEN# +1.00149062"},
        {"Smithsonian Astrophysical Observation", "SAO 207772"},
        {"Wilson Evans Batten Catalogue", "WEB 13714"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.46659098),
        dec: Angle.Degrees(-35.54253926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11277"},
        {"Hipparcos Number", "HIP 8527"},
        {"Geneva Identification System", "GEN# +1.00011277"},
        {"Smithsonian Astrophysical Observation", "SAO 193327"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.49142203),
        dec: Angle.Degrees(-35.53997320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72138"},
        {"Hipparcos Number", "HIP 41693"},
        {"Celescope Catalog", "CEL 2571"},
        {"Smithsonian Astrophysical Observation", "SAO 199296"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.49083034),
        dec: Angle.Degrees(-35.53926490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190647"},
        {"Hipparcos Number", "HIP 99115"},
        {"Geneva Identification System", "GEN# +1.00190647"},
        {"Smithsonian Astrophysical Observation", "SAO 211821"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.83203686),
        dec: Angle.Degrees(-35.53813000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86397"},
        {"Hipparcos Number", "HIP 48809"},
        {"Geneva Identification System", "GEN# +1.00086397"},
        {"Smithsonian Astrophysical Observation", "SAO 200899"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.33196831),
        dec: Angle.Degrees(-35.53605491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142832"},
        {"Hipparcos Number", "HIP 78198"},
        {"Smithsonian Astrophysical Observation", "SAO 207170"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.52275787),
        dec: Angle.Degrees(-35.53459868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127080"},
        {"Hipparcos Number", "HIP 70927"},
        {"Smithsonian Astrophysical Observation", "SAO 205620"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.56606165),
        dec: Angle.Degrees(-35.53432301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47906"},
        {"Hipparcos Number", "HIP 31826"},
        {"Geneva Identification System", "GEN# +1.00047906"},
        {"Smithsonian Astrophysical Observation", "SAO 197049"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.81678293),
        dec: Angle.Degrees(-35.53237663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162085"},
        {"Hipparcos Number", "HIP 87336"},
        {"Geneva Identification System", "GEN# +1.00162085"},
        {"Smithsonian Astrophysical Observation", "SAO 209337"},
        {"Wilson Evans Batten Catalogue", "WEB 14734"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.68213437),
        dec: Angle.Degrees(-35.53197468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161086"},
        {"Hipparcos Number", "HIP 86880"},
        {"Smithsonian Astrophysical Observation", "SAO 209214"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.25879273),
        dec: Angle.Degrees(-35.53162315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103445"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.36903705),
        dec: Angle.Degrees(-35.52993407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127526"},
        {"Hipparcos Number", "HIP 71136"},
        {"Smithsonian Astrophysical Observation", "SAO 205672"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.22912711),
        dec: Angle.Degrees(-35.52863235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26154"},
        {"Hipparcos Number", "HIP 19199"},
        {"Smithsonian Astrophysical Observation", "SAO 194771"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.72638340),
        dec: Angle.Degrees(-35.52774493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10624"},
        {"Hipparcos Number", "HIP 8021"},
        {"Smithsonian Astrophysical Observation", "SAO 193267"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.74562095),
        dec: Angle.Degrees(-35.52485807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98703"},
        {"Hipparcos Number", "HIP 55436"},
        {"Smithsonian Astrophysical Observation", "SAO 202350"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.28656019),
        dec: Angle.Degrees(-35.52399451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195302"},
        {"Hipparcos Number", "HIP 101274"},
        {"Geneva Identification System", "GEN# +1.00195302"},
        {"Smithsonian Astrophysical Observation", "SAO 212201"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.92085659),
        dec: Angle.Degrees(-35.52389355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217096"},
        {"Hipparcos Number", "HIP 113447"},
        {"Geneva Identification System", "GEN# +1.00217096"},
        {"Smithsonian Astrophysical Observation", "SAO 214215"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.64587927),
        dec: Angle.Degrees(-35.52295831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81133"},
        {"Hipparcos Number", "HIP 45995"},
        {"Geneva Identification System", "GEN# +1.00081133"},
        {"Smithsonian Astrophysical Observation", "SAO 200301"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.70696531),
        dec: Angle.Degrees(-35.52295439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128409"},
        {"Hipparcos Number", "HIP 71524"},
        {"Smithsonian Astrophysical Observation", "SAO 205774"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.43052032),
        dec: Angle.Degrees(-35.52042191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215700"},
        {"Hipparcos Number", "HIP 112528"},
        {"Geneva Identification System", "GEN# +1.00215700"},
        {"Smithsonian Astrophysical Observation", "SAO 214085"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.88674665),
        dec: Angle.Degrees(-35.52025447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140840"},
        {"Hipparcos Number", "HIP 77317"},
        {"Geneva Identification System", "GEN# +1.00140840"},
        {"Smithsonian Astrophysical Observation", "SAO 206969"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.77575304),
        dec: Angle.Degrees(-35.51797799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41759"},
        {"Hipparcos Number", "HIP 28855"},
        {"Geneva Identification System", "GEN# +1.00041759"},
        {"Smithsonian Astrophysical Observation", "SAO 196483"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.36320378),
        dec: Angle.Degrees(-35.51368651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16724"},
        {"Hipparcos Number", "HIP 12414"},
        {"Smithsonian Astrophysical Observation", "SAO 193845"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.94947528),
        dec: Angle.Degrees(-35.51273122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97942"},
        {"Hipparcos Number", "HIP 54988"},
        {"Smithsonian Astrophysical Observation", "SAO 202251"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.89578953),
        dec: Angle.Degrees(-35.51261709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221608"},
        {"Hipparcos Number", "HIP 116295"},
        {"Smithsonian Astrophysical Observation", "SAO 214625"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.44442584),
        dec: Angle.Degrees(-35.51220436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107603"},
        {"Hipparcos Number", "HIP 60323"},
        {"Smithsonian Astrophysical Observation", "SAO 203398"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.53600686),
        dec: Angle.Degrees(-35.51198147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66810"},
        {"Hipparcos Number", "HIP 39448"},
        {"Celescope Catalog", "CEL 2155"},
        {"Geneva Identification System", "GEN# +1.00066810"},
        {"Smithsonian Astrophysical Observation", "SAO 198757"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.96279761),
        dec: Angle.Degrees(-35.51178418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140817"},
        {"Hipparcos Number", "HIP 77315"},
        {"Smithsonian Astrophysical Observation", "SAO 206968"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.76862736),
        dec: Angle.Degrees(-35.51028571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13461"},
        {"Hipparcos Number", "HIP 10152"},
        {"Fundamental Katalog 5th Edition", "FK5 4201"},
        {"Smithsonian Astrophysical Observation", "SAO 193552"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.64723024),
        dec: Angle.Degrees(-35.51015725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71104"},
        {"Hipparcos Number", "HIP 41177"},
        {"Smithsonian Astrophysical Observation", "SAO 199179"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.03776559),
        dec: Angle.Degrees(-35.50900250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64227"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.45107268),
        dec: Angle.Degrees(-35.50850962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51825"},
        {"Hipparcos Number", "HIP 33451"},
        {"Geneva Identification System", "GEN# +1.00051825J"},
        {"Smithsonian Astrophysical Observation", "SAO 197402"},
        {"Wilson Evans Batten Catalogue", "WEB 6729"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.32338804),
        dec: Angle.Degrees(-35.50720085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53402",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53402"},
    },
    visualMagnitude: 9.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.83508937),
        dec: Angle.Degrees(-35.50650330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202293"},
        {"Hipparcos Number", "HIP 104988"},
        {"Smithsonian Astrophysical Observation", "SAO 212844"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.96265948),
        dec: Angle.Degrees(-35.50412061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76405"},
        {"Hipparcos Number", "HIP 43754"},
        {"Smithsonian Astrophysical Observation", "SAO 199775"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.68870788),
        dec: Angle.Degrees(-35.50250996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188433"},
        {"Hipparcos Number", "HIP 98128"},
        {"Smithsonian Astrophysical Observation", "SAO 211670"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.15008820),
        dec: Angle.Degrees(-35.50196942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84224"},
        {"Hipparcos Number", "HIP 47627"},
        {"Fundamental Katalog 5th Edition", "FK5 2777"},
        {"Geneva Identification System", "GEN# +1.00084224"},
        {"Renson", "Renson 24030"},
        {"Smithsonian Astrophysical Observation", "SAO 200652"},
        {"Wilson Evans Batten Catalogue", "WEB 8928"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.67236047),
        dec: Angle.Degrees(-35.50172774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114030"},
        {"Hipparcos Number", "HIP 64099"},
        {"Geneva Identification System", "GEN# +1.00114030"},
        {"Smithsonian Astrophysical Observation", "SAO 204154"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.04454464),
        dec: Angle.Degrees(-35.50099499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69800"},
        {"Hipparcos Number", "HIP 40590"},
        {"Smithsonian Astrophysical Observation", "SAO 199042"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.31290616),
        dec: Angle.Degrees(-35.50096513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65962"},
        {"Hipparcos Number", "HIP 39105"},
        {"Celescope Catalog", "CEL 2130"},
        {"Smithsonian Astrophysical Observation", "SAO 198677"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.99938044),
        dec: Angle.Degrees(-35.49940978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144848"},
        {"Hipparcos Number", "HIP 79149"},
        {"Geneva Identification System", "GEN# +1.00144848"},
        {"Smithsonian Astrophysical Observation", "SAO 207389"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.32114812),
        dec: Angle.Degrees(-35.49844010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173645"},
        {"Hipparcos Number", "HIP 92234"},
        {"Geneva Identification System", "GEN# +1.00173645"},
        {"Smithsonian Astrophysical Observation", "SAO 210578"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.96422672),
        dec: Angle.Degrees(-35.49827100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80641"},
        {"Hipparcos Number", "HIP 45766"},
        {"Smithsonian Astrophysical Observation", "SAO 200245"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.98931826),
        dec: Angle.Degrees(-35.49822067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211522"},
        {"Hipparcos Number", "HIP 110114"},
        {"Smithsonian Astrophysical Observation", "SAO 213715"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.58258662),
        dec: Angle.Degrees(-35.49762016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94693"},
        {"Hipparcos Number", "HIP 53399"},
        {"Smithsonian Astrophysical Observation", "SAO 201899"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.83273988),
        dec: Angle.Degrees(-35.49715437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126017"},
        {"Hipparcos Number", "HIP 70380"},
        {"Smithsonian Astrophysical Observation", "SAO 205517"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.99069000),
        dec: Angle.Degrees(-35.49705427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57785"},
        {"Hipparcos Number", "HIP 35638"},
        {"Smithsonian Astrophysical Observation", "SAO 197883"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.31286067),
        dec: Angle.Degrees(-35.49612615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213186"},
        {"Hipparcos Number", "HIP 111091"},
        {"Smithsonian Astrophysical Observation", "SAO 213869"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.58806053),
        dec: Angle.Degrees(-35.49529017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105470"},
        {"Hipparcos Number", "HIP 59206"},
        {"Smithsonian Astrophysical Observation", "SAO 203165"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.13321849),
        dec: Angle.Degrees(-35.49522268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20739"},
        {"Hipparcos Number", "HIP 15449"},
        {"Smithsonian Astrophysical Observation", "SAO 194228"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.80040008),
        dec: Angle.Degrees(-35.49478370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3813"},
        {"Hipparcos Number", "HIP 3173"},
        {"Geneva Identification System", "GEN# +1.00003813"},
        {"Smithsonian Astrophysical Observation", "SAO 192669"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.10893689),
        dec: Angle.Degrees(-35.49431811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123222"},
        {"Hipparcos Number", "HIP 68966"},
        {"Fundamental Katalog 5th Edition", "FK5 5252"},
        {"Geneva Identification System", "GEN# +1.00123222"},
        {"Smithsonian Astrophysical Observation", "SAO 205196"},
        {"Wilson Evans Batten Catalogue", "WEB 12053"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.78354679),
        dec: Angle.Degrees(-35.49189253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146745"},
        {"Hipparcos Number", "HIP 79962"},
        {"Smithsonian Astrophysical Observation", "SAO 207551"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.82174297),
        dec: Angle.Degrees(-35.49081393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214138"},
        {"Hipparcos Number", "HIP 111628"},
        {"Smithsonian Astrophysical Observation", "SAO 213952"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.20463950),
        dec: Angle.Degrees(-35.49070929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69123"},
        {"Hipparcos Number", "HIP 40344"},
        {"Geneva Identification System", "GEN# +1.00069123"},
        {"Smithsonian Astrophysical Observation", "SAO 198979"},
    },
    visualMagnitude: 5.77,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.55537215),
        dec: Angle.Degrees(-35.49007215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76280"},
        {"Hipparcos Number", "HIP 43698"},
        {"Smithsonian Astrophysical Observation", "SAO 199760"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.50017673),
        dec: Angle.Degrees(-35.48973065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94366"},
        {"Hipparcos Number", "HIP 53211"},
        {"Celescope Catalog", "CEL 3751"},
        {"Geneva Identification System", "GEN# +1.00094366"},
        {"Smithsonian Astrophysical Observation", "SAO 201856"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.25545374),
        dec: Angle.Degrees(-35.48904976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207375"},
        {"Hipparcos Number", "HIP 107721"},
        {"Geneva Identification System", "GEN# +1.00207375"},
        {"Smithsonian Astrophysical Observation", "SAO 213315"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.31946050),
        dec: Angle.Degrees(-35.48523762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4561"},
        {"Smithsonian Astrophysical Observation", "SAO 192843"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.58270978),
        dec: Angle.Degrees(-35.48379018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173147"},
        {"Hipparcos Number", "HIP 92018"},
        {"Smithsonian Astrophysical Observation", "SAO 210533"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.32922685),
        dec: Angle.Degrees(-35.48372868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32831"},
        {"Hipparcos Number", "HIP 23595"},
        {"Geneva Identification System", "GEN# +1.00032831J"},
        {"Smithsonian Astrophysical Observation", "SAO 195532"},
        {"Wilson Evans Batten Catalogue", "WEB 4598"},
    },
    visualMagnitude: 4.55,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.10129897),
        dec: Angle.Degrees(-35.48287057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152684"},
        {"Hipparcos Number", "HIP 82885"},
        {"Smithsonian Astrophysical Observation", "SAO 208211"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.07611207),
        dec: Angle.Degrees(-35.48284403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29385"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.88663950),
        dec: Angle.Degrees(-35.48219406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109161"},
        {"Hipparcos Number", "HIP 61230"},
        {"Smithsonian Astrophysical Observation", "SAO 203576"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.20017927),
        dec: Angle.Degrees(-35.48209622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89041"},
        {"Hipparcos Number", "HIP 50247"},
        {"Smithsonian Astrophysical Observation", "SAO 201214"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.89289366),
        dec: Angle.Degrees(-35.47952813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46310"},
        {"Hipparcos Number", "HIP 31059"},
        {"Smithsonian Astrophysical Observation", "SAO 196893"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.76306499),
        dec: Angle.Degrees(-35.47902316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166136"},
        {"Hipparcos Number", "HIP 89076"},
        {"Smithsonian Astrophysical Observation", "SAO 209813"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.69259657),
        dec: Angle.Degrees(-35.47803132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2799"},
        {"Hipparcos Number", "HIP 2456"},
        {"Geneva Identification System", "GEN# +1.00002799"},
        {"Smithsonian Astrophysical Observation", "SAO 192585"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.80709366),
        dec: Angle.Degrees(-35.47705846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29991"},
        {"Hipparcos Number", "HIP 21872"},
        {"Geneva Identification System", "GEN# +1.00029991"},
        {"Smithsonian Astrophysical Observation", "SAO 195240"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.53716591),
        dec: Angle.Degrees(-35.47612449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140241"},
        {"Hipparcos Number", "HIP 77038"},
        {"Smithsonian Astrophysical Observation", "SAO 206912"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.94855518),
        dec: Angle.Degrees(-35.47497104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38430"},
        {"Hipparcos Number", "HIP 27042"},
        {"Smithsonian Astrophysical Observation", "SAO 196127"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.02591312),
        dec: Angle.Degrees(-35.47484070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37177"},
        {"Hipparcos Number", "HIP 26198"},
        {"Geneva Identification System", "GEN# +1.00037177"},
        {"Smithsonian Astrophysical Observation", "SAO 195984"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.75885080),
        dec: Angle.Degrees(-35.47394966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148397"},
        {"Hipparcos Number", "HIP 80750"},
        {"Smithsonian Astrophysical Observation", "SAO 207705"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.30906786),
        dec: Angle.Degrees(-35.47242080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96299"},
        {"Hipparcos Number", "HIP 54228"},
        {"Smithsonian Astrophysical Observation", "SAO 202079"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.43116522),
        dec: Angle.Degrees(-35.47210630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36597"},
        {"Hipparcos Number", "HIP 25859"},
        {"Fundamental Katalog 5th Edition", "FK5 2413"},
        {"Geneva Identification System", "GEN# +1.00036597"},
        {"Smithsonian Astrophysical Observation", "SAO 195924"},
        {"Wilson Evans Batten Catalogue", "WEB 5021"},
    },
    visualMagnitude: 3.86,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.80306450),
        dec: Angle.Degrees(-35.47043592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217394"},
        {"Hipparcos Number", "HIP 113634"},
        {"Geneva Identification System", "GEN# +1.00217394"},
        {"Smithsonian Astrophysical Observation", "SAO 214244"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.20247439),
        dec: Angle.Degrees(-35.46998062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 321724"},
        {"Hipparcos Number", "HIP 90332"},
        {"Smithsonian Astrophysical Observation", "SAO 210132"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.46205982),
        dec: Angle.Degrees(-35.46957890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214727"},
        {"Hipparcos Number", "HIP 111959"},
        {"Smithsonian Astrophysical Observation", "SAO 214004"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.17919428),
        dec: Angle.Degrees(-35.46849840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26010"},
        {"Hipparcos Number", "HIP 19099"},
        {"Smithsonian Astrophysical Observation", "SAO 194755"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.41526405),
        dec: Angle.Degrees(-35.46685895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51901"},
        {"Hipparcos Number", "HIP 33481"},
        {"Smithsonian Astrophysical Observation", "SAO 197407"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.39902381),
        dec: Angle.Degrees(-35.46637158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6933"},
        {"Smithsonian Astrophysical Observation", "SAO 129321"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.33109040),
        dec: Angle.Degrees(-03.19670327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127861"},
        {"Hipparcos Number", "HIP 71289"},
        {"Geneva Identification System", "GEN# +1.00127861"},
        {"Smithsonian Astrophysical Observation", "SAO 205715"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.68393318),
        dec: Angle.Degrees(-35.46335644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27940"},
        {"Hipparcos Number", "HIP 20464"},
        {"Smithsonian Astrophysical Observation", "SAO 194969"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.76722799),
        dec: Angle.Degrees(-35.46065887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31251"},
        {"Smithsonian Astrophysical Observation", "SAO 196932"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.32056715),
        dec: Angle.Degrees(-35.45894146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209015"},
        {"Hipparcos Number", "HIP 108682"},
        {"Smithsonian Astrophysical Observation", "SAO 213474"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.24934366),
        dec: Angle.Degrees(-35.45756994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11817"},
        {"Hipparcos Number", "HIP 8942"},
        {"Smithsonian Astrophysical Observation", "SAO 193381"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.79672980),
        dec: Angle.Degrees(-35.45736094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214137"},
        {"Hipparcos Number", "HIP 111629"},
        {"Geneva Identification System", "GEN# +1.00214137"},
        {"Smithsonian Astrophysical Observation", "SAO 213953"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.21212071),
        dec: Angle.Degrees(-35.45627283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67977"},
        {"Hipparcos Number", "HIP 39920"},
        {"Geneva Identification System", "GEN# +1.00067977"},
        {"Smithsonian Astrophysical Observation", "SAO 198859"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.29245558),
        dec: Angle.Degrees(-35.45504736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43451"},
        {"Hipparcos Number", "HIP 29631"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.65486254),
        dec: Angle.Degrees(-35.45249000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183783"},
        {"Hipparcos Number", "HIP 96113"},
        {"Geneva Identification System", "GEN# +1.00183783"},
        {"Smithsonian Astrophysical Observation", "SAO 211343"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.12698330),
        dec: Angle.Degrees(-35.45211196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -289.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 161.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70002"},
        {"Hipparcos Number", "HIP 40678"},
        {"Geneva Identification System", "GEN# +1.00070002"},
        {"Smithsonian Astrophysical Observation", "SAO 199061"},
    },
    visualMagnitude: 5.59,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.57244799),
        dec: Angle.Degrees(-35.45170517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154368"},
        {"Hipparcos Number", "HIP 83706"},
        {"Geneva Identification System", "GEN# +1.00154368J"},
        {"Smithsonian Astrophysical Observation", "SAO 208410"},
        {"Wilson Evans Batten Catalogue", "WEB 14153"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.61819932),
        dec: Angle.Degrees(-35.45103893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118466"},
        {"Hipparcos Number", "HIP 66487"},
        {"Smithsonian Astrophysical Observation", "SAO 204674"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.45465114),
        dec: Angle.Degrees(-35.44906922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126620"},
        {"Hipparcos Number", "HIP 70693"},
        {"Fundamental Katalog 5th Edition", "FK5 5278"},
        {"Geneva Identification System", "GEN# +1.00126620"},
        {"Smithsonian Astrophysical Observation", "SAO 205574"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.88094086),
        dec: Angle.Degrees(-35.44710156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25926"},
        {"Hipparcos Number", "HIP 19052"},
        {"Smithsonian Astrophysical Observation", "SAO 194747"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.23321194),
        dec: Angle.Degrees(-35.44646315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14526"},
        {"Hipparcos Number", "HIP 10864"},
        {"Geneva Identification System", "GEN# +1.00014526"},
        {"Smithsonian Astrophysical Observation", "SAO 193644"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.94977290),
        dec: Angle.Degrees(-35.44558606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213628"},
        {"Hipparcos Number", "HIP 111349"},
        {"Cincinnati Publication", "Ci 20 1369"},
        {"Geneva Identification System", "GEN# +1.00213628"},
        {"Smithsonian Astrophysical Observation", "SAO 213905"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.37686990),
        dec: Angle.Degrees(-35.44421068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 329.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121674"},
        {"Hipparcos Number", "HIP 68182"},
        {"Smithsonian Astrophysical Observation", "SAO 205028"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.37316630),
        dec: Angle.Degrees(-35.44153531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114947"},
        {"Hipparcos Number", "HIP 64597"},
        {"Geneva Identification System", "GEN# +1.00114947"},
        {"Smithsonian Astrophysical Observation", "SAO 204269"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.60472054),
        dec: Angle.Degrees(-35.43982985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23123"},
        {"Hipparcos Number", "HIP 17219"},
        {"Smithsonian Astrophysical Observation", "SAO 194455"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.32304131),
        dec: Angle.Degrees(-35.43765076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57891"},
        {"Hipparcos Number", "HIP 35679"},
        {"Smithsonian Astrophysical Observation", "SAO 197893"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.43209129),
        dec: Angle.Degrees(-35.43705404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106468",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106468"},
        {"Geneva Identification System", "GEN# -0.03514849"},
        {"Smithsonian Astrophysical Observation", "SAO 213092"},
        {"Wilson Evans Batten Catalogue", "WEB 19272"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.45751447),
        dec: Angle.Degrees(-35.43615865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -464.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79937"},
        {"Hipparcos Number", "HIP 45458"},
        {"Smithsonian Astrophysical Observation", "SAO 200166"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.96449980),
        dec: Angle.Degrees(-35.43566855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19659"},
        {"Hipparcos Number", "HIP 14613"},
        {"Geneva Identification System", "GEN# +1.00019659"},
        {"Smithsonian Astrophysical Observation", "SAO 194109"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.17711086),
        dec: Angle.Degrees(-35.43262460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108494"},
        {"Hipparcos Number", "HIP 60822"},
        {"Smithsonian Astrophysical Observation", "SAO 203499"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.01004125),
        dec: Angle.Degrees(-35.43237423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43765"},
        {"Hipparcos Number", "HIP 29801"},
        {"Smithsonian Astrophysical Observation", "SAO 196641"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.11350453),
        dec: Angle.Degrees(-35.43098340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210709"},
        {"Hipparcos Number", "HIP 109662"},
        {"Geneva Identification System", "GEN# +1.00210709"},
        {"Smithsonian Astrophysical Observation", "SAO 213644"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.22431709),
        dec: Angle.Degrees(-35.43081657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109698"},
        {"Hipparcos Number", "HIP 61565"},
        {"Smithsonian Astrophysical Observation", "SAO 203632"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.21902349),
        dec: Angle.Degrees(-35.43007127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168236"},
        {"Hipparcos Number", "HIP 89859"},
        {"Smithsonian Astrophysical Observation", "SAO 210005"},
    },
    visualMagnitude: 6.87,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.07008291),
        dec: Angle.Degrees(-35.42867942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55347"},
        {"Hipparcos Number", "HIP 34689"},
        {"Smithsonian Astrophysical Observation", "SAO 197666"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.76508349),
        dec: Angle.Degrees(-35.42780777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77451"},
        {"Hipparcos Number", "HIP 44310"},
        {"Smithsonian Astrophysical Observation", "SAO 199891"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.35648093),
        dec: Angle.Degrees(-35.42757311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142458"},
        {"Hipparcos Number", "HIP 78035"},
        {"Smithsonian Astrophysical Observation", "SAO 207129"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.00896037),
        dec: Angle.Degrees(-35.42747021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139676"},
        {"Hipparcos Number", "HIP 76797"},
        {"Geneva Identification System", "GEN# +1.00139676"},
        {"Smithsonian Astrophysical Observation", "SAO 206863"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.19677219),
        dec: Angle.Degrees(-35.42747019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2961"},
        {"Hipparcos Number", "HIP 2574"},
        {"Smithsonian Astrophysical Observation", "SAO 192598"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.17051881),
        dec: Angle.Degrees(-35.42505189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39082"},
        {"Smithsonian Astrophysical Observation", "SAO 198672"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.93772816),
        dec: Angle.Degrees(-35.42485156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180885"},
        {"Hipparcos Number", "HIP 94986"},
        {"Fundamental Katalog 5th Edition", "FK5 1501"},
        {"Geneva Identification System", "GEN# +1.00180885"},
        {"Smithsonian Astrophysical Observation", "SAO 211175"},
        {"Wilson Evans Batten Catalogue", "WEB 16588"},
    },
    visualMagnitude: 5.59,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.91662081),
        dec: Angle.Degrees(-35.42142487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3459"},
        {"Hipparcos Number", "HIP 2939"},
        {"Geneva Identification System", "GEN# +1.00003459"},
        {"Smithsonian Astrophysical Observation", "SAO 192642"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.32864305),
        dec: Angle.Degrees(-35.42022676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12284"},
        {"Hipparcos Number", "HIP 9319"},
        {"Geneva Identification System", "GEN# +1.00012284"},
        {"Smithsonian Astrophysical Observation", "SAO 193436"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.92612515),
        dec: Angle.Degrees(-35.41987353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33543"},
        {"Smithsonian Astrophysical Observation", "SAO 197422"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.56657621),
        dec: Angle.Degrees(-35.41915141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52093"},
        {"Hipparcos Number", "HIP 33544"},
        {"Renson", "Renson 14300"},
        {"Smithsonian Astrophysical Observation", "SAO 197424"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.57158987),
        dec: Angle.Degrees(-35.41914674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196511"},
        {"Hipparcos Number", "HIP 101914"},
        {"Smithsonian Astrophysical Observation", "SAO 212314"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.77970358),
        dec: Angle.Degrees(-35.41844093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20991"},
        {"Hipparcos Number", "HIP 15674"},
        {"Smithsonian Astrophysical Observation", "SAO 194257"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.48412676),
        dec: Angle.Degrees(-35.41522803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24209"},
        {"Hipparcos Number", "HIP 17922"},
        {"Smithsonian Astrophysical Observation", "SAO 194561"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.47937443),
        dec: Angle.Degrees(-35.41486413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164911"},
        {"Hipparcos Number", "HIP 88566"},
        {"Smithsonian Astrophysical Observation", "SAO 209675"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.25418429),
        dec: Angle.Degrees(-35.41455664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110606"},
        {"Hipparcos Number", "HIP 62105"},
        {"Geneva Identification System", "GEN# +1.00110606"},
        {"Smithsonian Astrophysical Observation", "SAO 203749"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.91843411),
        dec: Angle.Degrees(-35.41398549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132665"},
        {"Hipparcos Number", "HIP 73511"},
        {"Smithsonian Astrophysical Observation", "SAO 206214"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.37211776),
        dec: Angle.Degrees(-35.41358007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107832"},
        {"Hipparcos Number", "HIP 60449"},
        {"Fundamental Katalog 5th Edition", "FK5 2992"},
        {"Geneva Identification System", "GEN# +1.00107832"},
        {"Smithsonian Astrophysical Observation", "SAO 203420"},
        {"Wilson Evans Batten Catalogue", "WEB 10750"},
    },
    visualMagnitude: 5.32,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.89770601),
        dec: Angle.Degrees(-35.41265923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211442"},
        {"Hipparcos Number", "HIP 110067"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.41489055),
        dec: Angle.Degrees(-35.41138660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13812"},
        {"Smithsonian Astrophysical Observation", "SAO 194010"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.45185480),
        dec: Angle.Degrees(-35.41127267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -299.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110892"},
        {"Geneva Identification System", "GEN# -0.03615400"},
        {"Smithsonian Astrophysical Observation", "SAO 213842"},
    },
    visualMagnitude: 10.81,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.00113861),
        dec: Angle.Degrees(-35.40955503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124143"},
        {"Hipparcos Number", "HIP 69404"},
        {"Smithsonian Astrophysical Observation", "SAO 205301"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.14111295),
        dec: Angle.Degrees(-35.40920143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100783"},
        {"Hipparcos Number", "HIP 56560"},
        {"Smithsonian Astrophysical Observation", "SAO 202607"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.94143078),
        dec: Angle.Degrees(-35.40900138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146626"},
        {"Hipparcos Number", "HIP 79909"},
        {"Smithsonian Astrophysical Observation", "SAO 207536"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.66265748),
        dec: Angle.Degrees(-35.40840399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40569"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.23936862),
        dec: Angle.Degrees(-35.40830461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94909"},
        {"Smithsonian Astrophysical Observation", "SAO 211158"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.69835348),
        dec: Angle.Degrees(-35.40676651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133574"},
        {"Hipparcos Number", "HIP 73913"},
        {"Geneva Identification System", "GEN# +1.00133574"},
        {"Smithsonian Astrophysical Observation", "SAO 206294"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.57481188),
        dec: Angle.Degrees(-35.40614763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66993"},
    },
    visualMagnitude: 11.80,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.94471949),
        dec: Angle.Degrees(-35.40525775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 381.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31392"},
        {"Hipparcos Number", "HIP 22787"},
        {"Fundamental Katalog 5th Edition", "FK5 4451"},
        {"Geneva Identification System", "GEN# +1.00031392"},
        {"Smithsonian Astrophysical Observation", "SAO 195386"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.51716218),
        dec: Angle.Degrees(-35.40490066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 157.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46379"},
        {"Smithsonian Astrophysical Observation", "SAO 200389"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.85254977),
        dec: Angle.Degrees(-35.40483358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106458"},
        {"Geneva Identification System", "GEN# -0.03514846"},
        {"Smithsonian Astrophysical Observation", "SAO 213089"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.42898656),
        dec: Angle.Degrees(-35.40472832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97465"},
        {"Hipparcos Number", "HIP 54752"},
        {"Fundamental Katalog 5th Edition", "FK5 4989"},
        {"Smithsonian Astrophysical Observation", "SAO 202204"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.15140937),
        dec: Angle.Degrees(-35.40268195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137834"},
        {"Hipparcos Number", "HIP 75833"},
        {"Smithsonian Astrophysical Observation", "SAO 206698"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.35881441),
        dec: Angle.Degrees(-35.40226719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5288"},
        {"Hipparcos Number", "HIP 4263"},
        {"Geneva Identification System", "GEN# +1.00005288"},
        {"Smithsonian Astrophysical Observation", "SAO 192810"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.60226342),
        dec: Angle.Degrees(-35.40099620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25722"},
        {"Smithsonian Astrophysical Observation", "SAO 195906"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.39271670),
        dec: Angle.Degrees(-35.40050257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98906"},
        {"Hipparcos Number", "HIP 55544"},
        {"Smithsonian Astrophysical Observation", "SAO 202376"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.65814842),
        dec: Angle.Degrees(-35.40045570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218683"},
        {"Hipparcos Number", "HIP 114414"},
        {"Smithsonian Astrophysical Observation", "SAO 214357"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.56929220),
        dec: Angle.Degrees(-35.39882599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9134"},
        {"Hipparcos Number", "HIP 6936"},
        {"Geneva Identification System", "GEN# +1.00009134"},
        {"Smithsonian Astrophysical Observation", "SAO 193141"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.34403371),
        dec: Angle.Degrees(-35.39862942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94165"},
        {"Hipparcos Number", "HIP 53077"},
        {"Smithsonian Astrophysical Observation", "SAO 201834"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.88771980),
        dec: Angle.Degrees(-35.39815341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121140"},
        {"Hipparcos Number", "HIP 67895"},
        {"Renson", "Renson 34860"},
        {"Smithsonian Astrophysical Observation", "SAO 204971"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.58696646),
        dec: Angle.Degrees(-35.39715584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38716"},
        {"Hipparcos Number", "HIP 27221"},
        {"Smithsonian Astrophysical Observation", "SAO 196152"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.54258967),
        dec: Angle.Degrees(-35.39703947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102413"},
        {"Hipparcos Number", "HIP 57502"},
        {"Geneva Identification System", "GEN# +1.00102413"},
        {"Smithsonian Astrophysical Observation", "SAO 202807"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.79524677),
        dec: Angle.Degrees(-35.39691430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4956"},
        {"Hipparcos Number", "HIP 3980"},
        {"Smithsonian Astrophysical Observation", "SAO 192776"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.79564009),
        dec: Angle.Degrees(-35.39624878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68842"},
        {"Hipparcos Number", "HIP 40225"},
        {"Geneva Identification System", "GEN# +1.00068842"},
        {"Smithsonian Astrophysical Observation", "SAO 198941"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.22957337),
        dec: Angle.Degrees(-35.39300742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75499"},
        {"Hipparcos Number", "HIP 43293"},
        {"Smithsonian Astrophysical Observation", "SAO 199664"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.29069088),
        dec: Angle.Degrees(-35.39252265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26225"},
        {"Hipparcos Number", "HIP 19254"},
        {"Geneva Identification System", "GEN# +1.00026225"},
        {"Smithsonian Astrophysical Observation", "SAO 194780"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.88454430),
        dec: Angle.Degrees(-35.39166783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83941"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.36106603),
        dec: Angle.Degrees(-35.39110674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125440"},
        {"Hipparcos Number", "HIP 70064"},
        {"Smithsonian Astrophysical Observation", "SAO 205451"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.07174049),
        dec: Angle.Degrees(-35.39014734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51238"},
        {"Smithsonian Astrophysical Observation", "SAO 201419"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.98366649),
        dec: Angle.Degrees(-35.38998482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165468"},
        {"Henry Draper 2", "HD 165469"},
        {"Hipparcos Number", "HIP 88805"},
        {"Smithsonian Astrophysical Observation", "SAO 209741"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.92093399),
        dec: Angle.Degrees(-35.38895600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131699"},
        {"Hipparcos Number", "HIP 73082"},
        {"Smithsonian Astrophysical Observation", "SAO 206106"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.04994254),
        dec: Angle.Degrees(-35.38763383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 319725"},
        {"Hipparcos Number", "HIP 85197"},
        {"Geneva Identification System", "GEN# +1.00319725"},
        {"Smithsonian Astrophysical Observation", "SAO 208779"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.15659475),
        dec: Angle.Degrees(-35.38523796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181768"},
        {"Hipparcos Number", "HIP 95292"},
        {"Smithsonian Astrophysical Observation", "SAO 211223"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.80126145),
        dec: Angle.Degrees(-35.38421116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131921"},
        {"Hipparcos Number", "HIP 73195"},
        {"Smithsonian Astrophysical Observation", "SAO 206128"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.38902483),
        dec: Angle.Degrees(-35.38397249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174361"},
        {"Hipparcos Number", "HIP 92552"},
        {"Smithsonian Astrophysical Observation", "SAO 210642"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.90575781),
        dec: Angle.Degrees(-35.38331238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157059"},
        {"Hipparcos Number", "HIP 85015"},
        {"Fundamental Katalog 5th Edition", "FK5 5531"},
        {"Geneva Identification System", "GEN# +1.00157059"},
        {"Renson", "Renson 44160"},
        {"Smithsonian Astrophysical Observation", "SAO 208739"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.64150728),
        dec: Angle.Degrees(-35.38191601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131141"},
        {"Hipparcos Number", "HIP 72806"},
        {"Geneva Identification System", "GEN# +1.00131141"},
        {"Renson", "Renson 37280"},
        {"Smithsonian Astrophysical Observation", "SAO 206042"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.22196556),
        dec: Angle.Degrees(-35.38083890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63374"},
        {"Hipparcos Number", "HIP 37998"},
        {"Smithsonian Astrophysical Observation", "SAO 198436"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.81238839),
        dec: Angle.Degrees(-35.38065191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7828"},
        {"Hipparcos Number", "HIP 6015"},
        {"Geneva Identification System", "GEN# +1.00007828"},
        {"Smithsonian Astrophysical Observation", "SAO 193029"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.33421799),
        dec: Angle.Degrees(-35.38049551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161855"},
        {"Hipparcos Number", "HIP 87240"},
        {"Fundamental Katalog 5th Edition", "FK5 5566"},
        {"Geneva Identification System", "GEN# +1.00161855"},
        {"Smithsonian Astrophysical Observation", "SAO 209309"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.37123130),
        dec: Angle.Degrees(-35.37809169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59616"},
        {"Hipparcos Number", "HIP 36375"},
        {"Smithsonian Astrophysical Observation", "SAO 198047"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.30421556),
        dec: Angle.Degrees(-35.37780446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18446"},
        {"Hipparcos Number", "HIP 13727"},
        {"Fundamental Katalog 5th Edition", "FK5 4268"},
        {"Geneva Identification System", "GEN# +1.00018446"},
        {"Smithsonian Astrophysical Observation", "SAO 193998"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.20191916),
        dec: Angle.Degrees(-35.37779597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65402"},
        {"Hipparcos Number", "HIP 38861"},
        {"Smithsonian Astrophysical Observation", "SAO 198629"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.29942931),
        dec: Angle.Degrees(-35.37776846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193716"},
        {"Hipparcos Number", "HIP 100523"},
        {"Geneva Identification System", "GEN# +1.00193716"},
        {"Smithsonian Astrophysical Observation", "SAO 212062"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.75127012),
        dec: Angle.Degrees(-35.37736334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202009"},
        {"Hipparcos Number", "HIP 104830"},
        {"Smithsonian Astrophysical Observation", "SAO 212818"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.56037068),
        dec: Angle.Degrees(-35.37418741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41709",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41709"},
        {"Smithsonian Astrophysical Observation", "SAO 199307"},
    },
    visualMagnitude: 9.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.58370325),
        dec: Angle.Degrees(-35.37186187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63512"},
    },
    visualMagnitude: 11.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.20848324),
        dec: Angle.Degrees(-35.37165958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177320"},
        {"Hipparcos Number", "HIP 93759"},
        {"Smithsonian Astrophysical Observation", "SAO 210914"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.40500963),
        dec: Angle.Degrees(-35.37110980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107937"},
        {"Smithsonian Astrophysical Observation", "SAO 213351"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.01400719),
        dec: Angle.Degrees(-35.36748205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34726"},
        {"Hipparcos Number", "HIP 24702"},
        {"Smithsonian Astrophysical Observation", "SAO 195728"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.48638105),
        dec: Angle.Degrees(-35.36734288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106215"},
        {"Hipparcos Number", "HIP 59591"},
        {"Renson", "Renson 30710"},
        {"Smithsonian Astrophysical Observation", "SAO 203247"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.30547179),
        dec: Angle.Degrees(-35.36687808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160300"},
        {"Hipparcos Number", "HIP 86502"},
        {"Smithsonian Astrophysical Observation", "SAO 209120"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.15675879),
        dec: Angle.Degrees(-35.36642076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36566"},
        {"Hipparcos Number", "HIP 25839"},
        {"Renson", "Renson 9510"},
        {"Smithsonian Astrophysical Observation", "SAO 195918"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.74681303),
        dec: Angle.Degrees(-35.36614078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76191"},
        {"Smithsonian Astrophysical Observation", "SAO 206757"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.43202396),
        dec: Angle.Degrees(-35.36556405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176999"},
        {"Hipparcos Number", "HIP 93655"},
        {"Smithsonian Astrophysical Observation", "SAO 210878"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.06395926),
        dec: Angle.Degrees(-35.36356884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194782"},
        {"Hipparcos Number", "HIP 101021"},
        {"Smithsonian Astrophysical Observation", "SAO 212162"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.20740390),
        dec: Angle.Degrees(-35.36318020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39669"},
        {"Hipparcos Number", "HIP 27754"},
        {"Smithsonian Astrophysical Observation", "SAO 196264"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.11647098),
        dec: Angle.Degrees(-35.36102887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1751"},
        {"Hipparcos Number", "HIP 1712"},
        {"Geneva Identification System", "GEN# +1.00001751"},
        {"Smithsonian Astrophysical Observation", "SAO 192480"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.38800926),
        dec: Angle.Degrees(-35.36059271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89832"},
        {"Hipparcos Number", "HIP 50723"},
        {"Smithsonian Astrophysical Observation", "SAO 201309"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.34853811),
        dec: Angle.Degrees(-35.36040019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120470"},
        {"Hipparcos Number", "HIP 67539"},
        {"Smithsonian Astrophysical Observation", "SAO 204890"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.58383808),
        dec: Angle.Degrees(-35.35986375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5057"},
        {"Smithsonian Astrophysical Observation", "SAO 192910"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.17841320),
        dec: Angle.Degrees(-35.34505574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208433"},
        {"Hipparcos Number", "HIP 108336"},
        {"Fundamental Katalog 5th Edition", "FK5 5937"},
        {"Smithsonian Astrophysical Observation", "SAO 213424"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.23139621),
        dec: Angle.Degrees(-35.35982921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133076"},
        {"Hipparcos Number", "HIP 73687"},
        {"Smithsonian Astrophysical Observation", "SAO 206251"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.93107604),
        dec: Angle.Degrees(-35.35852418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79058"},
        {"Hipparcos Number", "HIP 45057"},
        {"Smithsonian Astrophysical Observation", "SAO 200065"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.65757944),
        dec: Angle.Degrees(-35.35824505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80853"},
        {"Hipparcos Number", "HIP 45868"},
        {"Smithsonian Astrophysical Observation", "SAO 200268"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.29330763),
        dec: Angle.Degrees(-35.35725101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101158"},
        {"Smithsonian Astrophysical Observation", "SAO 212184"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.57220673),
        dec: Angle.Degrees(-35.35504550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221953"},
        {"Hipparcos Number", "HIP 116513"},
        {"Smithsonian Astrophysical Observation", "SAO 214652"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.16112935),
        dec: Angle.Degrees(-35.35482380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63132"},
        {"Hipparcos Number", "HIP 37889"},
        {"Smithsonian Astrophysical Observation", "SAO 198409"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.48128433),
        dec: Angle.Degrees(-35.35426549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25387"},
        {"Smithsonian Astrophysical Observation", "SAO 195846"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.47117017),
        dec: Angle.Degrees(-35.35273160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40805"},
        {"Hipparcos Number", "HIP 28372"},
        {"Fundamental Katalog 5th Edition", "FK5 4545"},
        {"Smithsonian Astrophysical Observation", "SAO 196387"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.91167002),
        dec: Angle.Degrees(-35.35270004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127310"},
        {"Hipparcos Number", "HIP 71020"},
        {"Smithsonian Astrophysical Observation", "SAO 205642"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.87847860),
        dec: Angle.Degrees(-35.35269688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170750"},
        {"Hipparcos Number", "HIP 90904"},
        {"Fundamental Katalog 5th Edition", "FK5 5628"},
        {"Smithsonian Astrophysical Observation", "SAO 210284"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.13863894),
        dec: Angle.Degrees(-35.34957664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156935"},
        {"Hipparcos Number", "HIP 84952"},
        {"Geneva Identification System", "GEN# +1.00156935"},
        {"Smithsonian Astrophysical Observation", "SAO 208724"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.44566179),
        dec: Angle.Degrees(-35.34839602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52946"},
        {"Hipparcos Number", "HIP 33845"},
        {"Smithsonian Astrophysical Observation", "SAO 197490"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.38811426),
        dec: Angle.Degrees(-35.34814857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215002"},
        {"Hipparcos Number", "HIP 112128"},
        {"Geneva Identification System", "GEN# +1.00215002"},
        {"Smithsonian Astrophysical Observation", "SAO 214034"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.68151256),
        dec: Angle.Degrees(-35.34665721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9743"},
        {"Hipparcos Number", "HIP 7349"},
        {"Smithsonian Astrophysical Observation", "SAO 193187"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.68163040),
        dec: Angle.Degrees(-35.34607270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93142"},
        {"Hipparcos Number", "HIP 52567"},
        {"Geneva Identification System", "GEN# +1.00093142"},
        {"Smithsonian Astrophysical Observation", "SAO 201705"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.21133537),
        dec: Angle.Degrees(-35.34404321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104804"},
        {"Hipparcos Number", "HIP 58845"},
        {"Smithsonian Astrophysical Observation", "SAO 203096"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.03202626),
        dec: Angle.Degrees(-35.34331649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82223"},
        {"Hipparcos Number", "HIP 46563"},
        {"Smithsonian Astrophysical Observation", "SAO 200427"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.44006239),
        dec: Angle.Degrees(-35.34261200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72896"},
        {"Hipparcos Number", "HIP 42027"},
        {"Smithsonian Astrophysical Observation", "SAO 199375"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.50326264),
        dec: Angle.Degrees(-35.34259280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51682"},
        {"Hipparcos Number", "HIP 33394"},
        {"Geneva Identification System", "GEN# +1.00051682"},
        {"Smithsonian Astrophysical Observation", "SAO 197388"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.19043191),
        dec: Angle.Degrees(-35.34134788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70417"},
    },
    visualMagnitude: 11.89,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.09205557),
        dec: Angle.Degrees(-35.34117521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169874"},
        {"Hipparcos Number", "HIP 90526"},
        {"Renson", "Renson 47570"},
        {"Smithsonian Astrophysical Observation", "SAO 210196"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.07956577),
        dec: Angle.Degrees(-35.33962507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113135"},
        {"Smithsonian Astrophysical Observation", "SAO 214177"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.66135181),
        dec: Angle.Degrees(-35.33949649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45459"},
        {"Hipparcos Number", "HIP 30604"},
        {"Smithsonian Astrophysical Observation", "SAO 196813"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.48981258),
        dec: Angle.Degrees(-35.33734682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221209"},
        {"Hipparcos Number", "HIP 116008"},
        {"Smithsonian Astrophysical Observation", "SAO 214588"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.56382320),
        dec: Angle.Degrees(-35.33719791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191184"},
        {"Hipparcos Number", "HIP 99356"},
        {"Geneva Identification System", "GEN# +1.00191184"},
        {"Smithsonian Astrophysical Observation", "SAO 211870"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.50068091),
        dec: Angle.Degrees(-35.33638272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159684"},
        {"Hipparcos Number", "HIP 86253"},
        {"Geneva Identification System", "GEN# +1.00159684"},
        {"Smithsonian Astrophysical Observation", "SAO 209039"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.37881060),
        dec: Angle.Degrees(-35.33306515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39002"},
        {"Hipparcos Number", "HIP 27392"},
        {"Smithsonian Astrophysical Observation", "SAO 196185"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.01264282),
        dec: Angle.Degrees(-35.32998859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164108"},
        {"Hipparcos Number", "HIP 88247"},
        {"Smithsonian Astrophysical Observation", "SAO 209594"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.29944009),
        dec: Angle.Degrees(-35.32909906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99712"},
        {"Hipparcos Number", "HIP 55953"},
        {"Smithsonian Astrophysical Observation", "SAO 202478"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.99443796),
        dec: Angle.Degrees(-35.32884907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176516"},
        {"Hipparcos Number", "HIP 93472"},
        {"Geneva Identification System", "GEN# +1.00176516"},
        {"Smithsonian Astrophysical Observation", "SAO 210844"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.54019168),
        dec: Angle.Degrees(-35.32851882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64951"},
        {"Hipparcos Number", "HIP 38665"},
        {"Geneva Identification System", "GEN# +1.00064951"},
        {"Smithsonian Astrophysical Observation", "SAO 198589"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.74689215),
        dec: Angle.Degrees(-35.32535722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88539"},
        {"Hipparcos Number", "HIP 49950"},
        {"Geneva Identification System", "GEN# +1.00088539"},
        {"Smithsonian Astrophysical Observation", "SAO 201156"},
        {"Wilson Evans Batten Catalogue", "WEB 9192"},
    },
    visualMagnitude: 6.68,
    bvColour: 2.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.97425453),
        dec: Angle.Degrees(-35.32473559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73498"},
        {"Hipparcos Number", "HIP 42300"},
        {"Geneva Identification System", "GEN# +1.00073498"},
        {"Smithsonian Astrophysical Observation", "SAO 199437"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.36749764),
        dec: Angle.Degrees(-35.32216832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189788"},
        {"Hipparcos Number", "HIP 98722"},
        {"Smithsonian Astrophysical Observation", "SAO 211764"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.77024104),
        dec: Angle.Degrees(-35.32100443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53404B"},
        {"Hipparcos Number", "HIP 34008"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.85613078),
        dec: Angle.Degrees(-35.31993278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16404"},
        {"Hipparcos Number", "HIP 12176"},
        {"Smithsonian Astrophysical Observation", "SAO 193808"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.22233520),
        dec: Angle.Degrees(-35.31991470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53404"},
        {"Hipparcos Number", "HIP 34009"},
        {"Smithsonian Astrophysical Observation", "SAO 197520"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.85905550),
        dec: Angle.Degrees(-35.31953721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8499"},
        {"Hipparcos Number", "HIP 6505"},
        {"Geneva Identification System", "GEN# +1.00008499"},
        {"Smithsonian Astrophysical Observation", "SAO 193091"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.88724746),
        dec: Angle.Degrees(-35.31937768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56019"},
        {"Hipparcos Number", "HIP 34939"},
        {"Smithsonian Astrophysical Observation", "SAO 197721"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.44981215),
        dec: Angle.Degrees(-35.31914048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119452"},
        {"Hipparcos Number", "HIP 67012"},
        {"Smithsonian Astrophysical Observation", "SAO 204782"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.00351798),
        dec: Angle.Degrees(-35.31766155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70288"},
        {"Hipparcos Number", "HIP 40809"},
        {"Celescope Catalog", "CEL 2376"},
        {"Geneva Identification System", "GEN# +1.00070288"},
        {"Smithsonian Astrophysical Observation", "SAO 199089"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.93511935),
        dec: Angle.Degrees(-35.31620428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201291"},
        {"Hipparcos Number", "HIP 104460"},
        {"Smithsonian Astrophysical Observation", "SAO 212758"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.39896222),
        dec: Angle.Degrees(-35.31520445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200144"},
        {"Hipparcos Number", "HIP 103862"},
        {"Smithsonian Astrophysical Observation", "SAO 212658"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.67329649),
        dec: Angle.Degrees(-35.31449580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121056"},
        {"Hipparcos Number", "HIP 67851"},
        {"Geneva Identification System", "GEN# +1.00121056"},
        {"Smithsonian Astrophysical Observation", "SAO 204963"},
        {"Wilson Evans Batten Catalogue", "WEB 11927"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.46780190),
        dec: Angle.Degrees(-35.31419181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -295.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86818"},
        {"Hipparcos Number", "HIP 49032"},
        {"Smithsonian Astrophysical Observation", "SAO 200951"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.05694984),
        dec: Angle.Degrees(-35.31347360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78784"},
        {"Hipparcos Number", "HIP 44911"},
        {"Geneva Identification System", "GEN# +1.00078784"},
        {"Smithsonian Astrophysical Observation", "SAO 200034"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.23508156),
        dec: Angle.Degrees(-35.31318474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187414"},
        {"Hipparcos Number", "HIP 97698"},
        {"Fundamental Katalog 5th Edition", "FK5 5753"},
        {"Smithsonian Astrophysical Observation", "SAO 211604"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.82386570),
        dec: Angle.Degrees(-35.31034450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77110"},
        {"Hipparcos Number", "HIP 44132"},
        {"Geneva Identification System", "GEN# +1.00077110"},
        {"Smithsonian Astrophysical Observation", "SAO 199858"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.82394035),
        dec: Angle.Degrees(-35.31025572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 164.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166134"},
        {"Hipparcos Number", "HIP 89080"},
        {"Smithsonian Astrophysical Observation", "SAO 209814"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.69952261),
        dec: Angle.Degrees(-35.30879974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104136"},
        {"Hipparcos Number", "HIP 58477"},
        {"Smithsonian Astrophysical Observation", "SAO 203011"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.88259381),
        dec: Angle.Degrees(-35.30853343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74006"},
        {"Hipparcos Number", "HIP 42515"},
        {"Fundamental Katalog 5th Edition", "FK5 2681"},
        {"Geneva Identification System", "GEN# +1.00074006"},
        {"Smithsonian Astrophysical Observation", "SAO 199490"},
        {"Wilson Evans Batten Catalogue", "WEB 8194"},
    },
    visualMagnitude: 3.97,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.02556894),
        dec: Angle.Degrees(-35.30830091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82759"},
        {"Hipparcos Number", "HIP 46872"},
        {"Smithsonian Astrophysical Observation", "SAO 200487"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.27439833),
        dec: Angle.Degrees(-35.30113653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101860"},
        {"Smithsonian Astrophysical Observation", "SAO 212304"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.60902392),
        dec: Angle.Degrees(-35.30063501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175419"},
        {"Hipparcos Number", "HIP 92999"},
        {"Fundamental Katalog 5th Edition", "FK5 5669"},
        {"Smithsonian Astrophysical Observation", "SAO 210740"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.19062866),
        dec: Angle.Degrees(-35.30022456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11196"},
        {"Hipparcos Number", "HIP 8481"},
        {"Smithsonian Astrophysical Observation", "SAO 193321"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.33190687),
        dec: Angle.Degrees(-35.29949793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151580"},
        {"Hipparcos Number", "HIP 82362"},
        {"Smithsonian Astrophysical Observation", "SAO 208071"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.44386065),
        dec: Angle.Degrees(-35.29812568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160810"},
        {"Hipparcos Number", "HIP 86737"},
        {"Geneva Identification System", "GEN# +1.00160810"},
        {"Smithsonian Astrophysical Observation", "SAO 209180"},
    },
    visualMagnitude: 6.92,
    bvColour: 2.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.85832455),
        dec: Angle.Degrees(-35.29765913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35322"},
        {"Hipparcos Number", "HIP 25091"},
        {"Geneva Identification System", "GEN# +1.00035322"},
        {"Smithsonian Astrophysical Observation", "SAO 195787"},
        {"Wilson Evans Batten Catalogue", "WEB 4866"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.57717184),
        dec: Angle.Degrees(-35.29740337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57828"},
        {"Hipparcos Number", "HIP 35656"},
        {"Geneva Identification System", "GEN# +1.00057828"},
        {"Smithsonian Astrophysical Observation", "SAO 197888"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.36348115),
        dec: Angle.Degrees(-35.29526746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199810"},
        {"Hipparcos Number", "HIP 103687"},
        {"Smithsonian Astrophysical Observation", "SAO 212617"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.16826171),
        dec: Angle.Degrees(-35.29173635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172075"},
        {"Hipparcos Number", "HIP 91504"},
        {"Smithsonian Astrophysical Observation", "SAO 210417"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.91648998),
        dec: Angle.Degrees(-35.29167932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50597"},
        {"Hipparcos Number", "HIP 32986"},
        {"Smithsonian Astrophysical Observation", "SAO 197300"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.08291856),
        dec: Angle.Degrees(-35.29065780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213412"},
        {"Hipparcos Number", "HIP 111206"},
        {"Smithsonian Astrophysical Observation", "SAO 213887"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.93839906),
        dec: Angle.Degrees(-35.29044317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119308"},
        {"Hipparcos Number", "HIP 66942"},
        {"Geneva Identification System", "GEN# +1.00119308"},
        {"Renson", "Renson 34460"},
        {"Smithsonian Astrophysical Observation", "SAO 204765"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.80336116),
        dec: Angle.Degrees(-35.29024813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169562"},
        {"Hipparcos Number", "HIP 90406"},
        {"Smithsonian Astrophysical Observation", "SAO 210158"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.70146107),
        dec: Angle.Degrees(-35.29012871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143675"},
        {"Hipparcos Number", "HIP 78641"},
        {"Smithsonian Astrophysical Observation", "SAO 207275"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.80647389),
        dec: Angle.Degrees(-35.28741729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28640"},
        {"Hipparcos Number", "HIP 20946"},
        {"Smithsonian Astrophysical Observation", "SAO 195063"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.36483909),
        dec: Angle.Degrees(-35.28717546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54979"},
        {"Hipparcos Number", "HIP 34552"},
        {"Celescope Catalog", "CEL 1631"},
        {"Geneva Identification System", "GEN# +1.00054979"},
        {"Smithsonian Astrophysical Observation", "SAO 197642"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.37485219),
        dec: Angle.Degrees(-35.28691435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74934"},
        {"Hipparcos Number", "HIP 42991"},
    },
    visualMagnitude: 9.67,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.43915746),
        dec: Angle.Degrees(-35.28411433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40494"},
        {"Hipparcos Number", "HIP 28199"},
        {"Fundamental Katalog 5th Edition", "FK5 1160"},
        {"Geneva Identification System", "GEN# +1.00040494A"},
        {"Smithsonian Astrophysical Observation", "SAO 196352"},
        {"Wilson Evans Batten Catalogue", "WEB 5518"},
    },
    visualMagnitude: 4.36,
    bvColour: -0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.38421613),
        dec: Angle.Degrees(-35.28330688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45170"},
        {"Hipparcos Number", "HIP 30472"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.09479908),
        dec: Angle.Degrees(-35.28281607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122088"},
        {"Hipparcos Number", "HIP 68419"},
        {"Smithsonian Astrophysical Observation", "SAO 205080"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.09913062),
        dec: Angle.Degrees(-35.28092670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28077"},
        {"Hipparcos Number", "HIP 20568"},
        {"Smithsonian Astrophysical Observation", "SAO 194989"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.09914691),
        dec: Angle.Degrees(-35.28049408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115643"},
        {"Hipparcos Number", "HIP 64975"},
        {"Smithsonian Astrophysical Observation", "SAO 204349"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.75245134),
        dec: Angle.Degrees(-35.27985153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140330"},
        {"Hipparcos Number", "HIP 77074"},
        {"Smithsonian Astrophysical Observation", "SAO 206922"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.07073597),
        dec: Angle.Degrees(-35.27878663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61409"},
        {"Hipparcos Number", "HIP 37127"},
        {"Fundamental Katalog 5th Edition", "FK5 4684"},
        {"Geneva Identification System", "GEN# +1.00061409"},
        {"Smithsonian Astrophysical Observation", "SAO 198205"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.43673821),
        dec: Angle.Degrees(-35.27720360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4661"},
        {"Hipparcos Number", "HIP 3762"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.08105174),
        dec: Angle.Degrees(-35.27718978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128532"},
        {"Hipparcos Number", "HIP 71585"},
        {"Geneva Identification System", "GEN# +1.00128532"},
        {"Smithsonian Astrophysical Observation", "SAO 205789"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.60392980),
        dec: Angle.Degrees(-35.27645380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189103"},
        {"Hipparcos Number", "HIP 98412"},
        {"Fundamental Katalog 5th Edition", "FK5 751"},
        {"Geneva Identification System", "GEN# +1.00189103"},
        {"Smithsonian Astrophysical Observation", "SAO 211716"},
        {"Wilson Evans Batten Catalogue", "WEB 17369"},
    },
    visualMagnitude: 4.37,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.93405965),
        dec: Angle.Degrees(-35.27624433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39470"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.00781844),
        dec: Angle.Degrees(-35.27598057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189645"},
        {"Hipparcos Number", "HIP 98664"},
        {"Smithsonian Astrophysical Observation", "SAO 211751"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.60000920),
        dec: Angle.Degrees(-35.27465908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153934"},
        {"Hipparcos Number", "HIP 83496"},
        {"Smithsonian Astrophysical Observation", "SAO 208358"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.97821404),
        dec: Angle.Degrees(-35.27376453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26575"},
        {"Hipparcos Number", "HIP 19509"},
        {"Geneva Identification System", "GEN# +1.00026575"},
        {"Smithsonian Astrophysical Observation", "SAO 194810"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.69118936),
        dec: Angle.Degrees(-35.27372401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12807"},
        {"Hipparcos Number", "HIP 9693"},
        {"Smithsonian Astrophysical Observation", "SAO 193493"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.17193480),
        dec: Angle.Degrees(-35.27332327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51790"},
        {"Smithsonian Astrophysical Observation", "SAO 201529"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.73287680),
        dec: Angle.Degrees(-35.27006693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143538"},
        {"Hipparcos Number", "HIP 78555"},
        {"Geneva Identification System", "GEN# +1.00143538"},
        {"Smithsonian Astrophysical Observation", "SAO 207252"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.57724640),
        dec: Angle.Degrees(-35.26986210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13119"},
        {"Hipparcos Number", "HIP 9903"},
        {"Smithsonian Astrophysical Observation", "SAO 193519"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.86974953),
        dec: Angle.Degrees(-35.26855510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85562"},
        {"Hipparcos Number", "HIP 48379"},
        {"Smithsonian Astrophysical Observation", "SAO 200819"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.93435833),
        dec: Angle.Degrees(-35.26798627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47689"},
        {"Smithsonian Astrophysical Observation", "SAO 200665"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.85323734),
        dec: Angle.Degrees(-35.26786296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38298"},
        {"Hipparcos Number", "HIP 26948"},
        {"Smithsonian Astrophysical Observation", "SAO 196111"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.77031386),
        dec: Angle.Degrees(-35.26703022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54189"},
        {"Smithsonian Astrophysical Observation", "SAO 202072"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.28270000),
        dec: Angle.Degrees(-35.26687879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27170"},
        {"Hipparcos Number", "HIP 19894"},
        {"Fundamental Katalog 5th Edition", "FK5 4391"},
        {"Geneva Identification System", "GEN# +1.00027170"},
        {"Smithsonian Astrophysical Observation", "SAO 194879"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.00781975),
        dec: Angle.Degrees(-35.26569925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
