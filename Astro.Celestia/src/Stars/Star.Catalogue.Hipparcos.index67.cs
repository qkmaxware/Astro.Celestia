using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_67() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7529"},
        {"Hipparcos Number", "HIP 5884"},
        {"Smithsonian Astrophysical Observation", "SAO 109761"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.88918118),
        dec: Angle.Degrees(+06.95617510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15834"},
        {"Hipparcos Number", "HIP 11854"},
        {"Smithsonian Astrophysical Observation", "SAO 110607"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.24904775),
        dec: Angle.Degrees(+06.95630783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71971"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.80022863),
        dec: Angle.Degrees(+06.95813104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110870"},
        {"Geneva Identification System", "GEN# +9.80018050"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.93043516),
        dec: Angle.Degrees(+06.95865955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 268.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36163"},
        {"Hipparcos Number", "HIP 25767"},
        {"Geneva Identification System", "GEN# +1.00036163"},
        {"Smithsonian Astrophysical Observation", "SAO 112832"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.53650985),
        dec: Angle.Degrees(+06.95942407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93139"},
        {"Hipparcos Number", "HIP 52598"},
        {"Smithsonian Astrophysical Observation", "SAO 118476"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.32866821),
        dec: Angle.Degrees(+06.96082282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22449",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tabit"},
        {"Henry Draper", "HD 30652"},
        {"Hipparcos Number", "HIP 22449"},
        {"Cincinnati Publication", "Ci 20 306"},
        {"Fundamental Katalog 5th Edition", "FK5 1134"},
        {"Geneva Identification System", "GEN# +1.00030652"},
        {"Smithsonian Astrophysical Observation", "SAO 112106"},
        {"Wilson Evans Batten Catalogue", "WEB 4331"},
    },
    visualMagnitude: 3.19,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.45890935),
        dec: Angle.Degrees(+06.96124744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 463.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94635"},
        {"Hipparcos Number", "HIP 53420"},
        {"Smithsonian Astrophysical Observation", "SAO 118572"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.91240184),
        dec: Angle.Degrees(+06.96212461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6788",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1154 AB"},
        {"Henry Draper", "HD 8849"},
        {"Hipparcos Number", "HIP 6788"},
        {"Smithsonian Astrophysical Observation", "SAO 109900"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.84042787),
        dec: Angle.Degrees(+06.96244890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71595"},
        {"Hipparcos Number", "HIP 41569"},
        {"Geneva Identification System", "GEN# +1.00071595"},
        {"Smithsonian Astrophysical Observation", "SAO 116800"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.13803648),
        dec: Angle.Degrees(+06.96505703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202243"},
        {"Hipparcos Number", "HIP 104845"},
        {"Smithsonian Astrophysical Observation", "SAO 126640"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.57911554),
        dec: Angle.Degrees(+06.96517182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50178"},
        {"Smithsonian Astrophysical Observation", "SAO 118179"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.63969055),
        dec: Angle.Degrees(+06.96691820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48206"},
        {"Smithsonian Astrophysical Observation", "SAO 117928"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.42089891),
        dec: Angle.Degrees(+06.96910467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8171"},
        {"Hipparcos Number", "HIP 6332"},
        {"Smithsonian Astrophysical Observation", "SAO 109824"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.32459764),
        dec: Angle.Degrees(+06.97080568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20356",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3151 AB"},
        {"Henry Draper", "HD 27597"},
        {"Hipparcos Number", "HIP 20356"},
        {"Smithsonian Astrophysical Observation", "SAO 111769"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.39237018),
        dec: Angle.Degrees(+06.97430330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103880"},
        {"Hipparcos Number", "HIP 58329"},
        {"Smithsonian Astrophysical Observation", "SAO 119134"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.43799713),
        dec: Angle.Degrees(+06.97477982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198061"},
        {"Hipparcos Number", "HIP 102612"},
        {"Geneva Identification System", "GEN# +1.00198061"},
        {"Smithsonian Astrophysical Observation", "SAO 126219"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.91125145),
        dec: Angle.Degrees(+06.97605759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8319"},
        {"Smithsonian Astrophysical Observation", "SAO 110126"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.81887457),
        dec: Angle.Degrees(+06.97785966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68165"},
        {"Geneva Identification System", "GEN# +0.00702721"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.32626832),
        dec: Angle.Degrees(+06.98228569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178265"},
        {"Hipparcos Number", "HIP 93937"},
        {"Geneva Identification System", "GEN# +1.00178265"},
        {"Renson", "Renson 49630"},
        {"Smithsonian Astrophysical Observation", "SAO 124298"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.91275214),
        dec: Angle.Degrees(+06.98349727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15875",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15875"},
        {"Geneva Identification System", "GEN# +0.00600525"},
        {"Wilson Evans Batten Catalogue", "WEB 3033"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.11928686),
        dec: Angle.Degrees(+06.98509043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139726"},
        {"Hipparcos Number", "HIP 76693"},
        {"Smithsonian Astrophysical Observation", "SAO 121111"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.90369261),
        dec: Angle.Degrees(+06.98679330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17332"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.64568154),
        dec: Angle.Degrees(+06.98693570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136177"},
        {"Hipparcos Number", "HIP 74955"},
        {"Smithsonian Astrophysical Observation", "SAO 120944"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.75652873),
        dec: Angle.Degrees(+06.98811709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209762"},
        {"Hipparcos Number", "HIP 109076"},
        {"Geneva Identification System", "GEN# +1.00209762"},
        {"Smithsonian Astrophysical Observation", "SAO 127288"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.44738455),
        dec: Angle.Degrees(+06.98832505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109914"},
        {"Hipparcos Number", "HIP 61667"},
        {"Geneva Identification System", "GEN# +1.00109914"},
        {"Smithsonian Astrophysical Observation", "SAO 119509"},
        {"Wilson Evans Batten Catalogue", "WEB 10970"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.62480552),
        dec: Angle.Degrees(+06.98860861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201298"},
        {"Hipparcos Number", "HIP 104357"},
        {"Fundamental Katalog 5th Edition", "FK5 3692"},
        {"Geneva Identification System", "GEN# +1.00201298"},
        {"Smithsonian Astrophysical Observation", "SAO 126566"},
        {"Wilson Evans Batten Catalogue", "WEB 19000"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.11727171),
        dec: Angle.Degrees(+06.98935404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158771"},
        {"Hipparcos Number", "HIP 85708"},
        {"Smithsonian Astrophysical Observation", "SAO 122456"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.71754347),
        dec: Angle.Degrees(+06.99159226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107174"},
        {"Hipparcos Number", "HIP 60095"},
        {"Smithsonian Astrophysical Observation", "SAO 119328"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.85604322),
        dec: Angle.Degrees(+06.99188560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76319"},
        {"Hipparcos Number", "HIP 43832"},
        {"Geneva Identification System", "GEN# +1.00076319"},
        {"Smithsonian Astrophysical Observation", "SAO 117270"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.91272935),
        dec: Angle.Degrees(+06.99193368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113351"},
        {"Hipparcos Number", "HIP 63671"},
        {"Geneva Identification System", "GEN# +1.00113351"},
        {"Smithsonian Astrophysical Observation", "SAO 119738"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.73961367),
        dec: Angle.Degrees(+06.99303569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146026"},
        {"Hipparcos Number", "HIP 79539"},
        {"Smithsonian Astrophysical Observation", "SAO 121437"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.46044597),
        dec: Angle.Degrees(+06.99390985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7446"},
        {"Hipparcos Number", "HIP 5824"},
        {"Geneva Identification System", "GEN# +1.00007446"},
        {"Smithsonian Astrophysical Observation", "SAO 109753"},
        {"Wilson Evans Batten Catalogue", "WEB 1326"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.67666596),
        dec: Angle.Degrees(+06.99519610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64630"},
        {"Hipparcos Number", "HIP 38676"},
        {"Geneva Identification System", "GEN# +1.00064630"},
        {"Smithsonian Astrophysical Observation", "SAO 116110"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.78300609),
        dec: Angle.Degrees(+06.99602135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114910"},
    },
    visualMagnitude: 11.94,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.12996932),
        dec: Angle.Degrees(+06.99606218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114257"},
        {"Hipparcos Number", "HIP 64192"},
        {"Geneva Identification System", "GEN# +1.00114257"},
        {"Smithsonian Astrophysical Observation", "SAO 119793"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.33588262),
        dec: Angle.Degrees(+06.99637745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122928"},
        {"Hipparcos Number", "HIP 68780"},
        {"Fundamental Katalog 5th Edition", "FK5 5249"},
        {"Geneva Identification System", "GEN# +1.00122928"},
        {"Smithsonian Astrophysical Observation", "SAO 120270"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.17336534),
        dec: Angle.Degrees(+06.99838264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4859"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.62364213),
        dec: Angle.Degrees(+06.99857899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123254"},
        {"Hipparcos Number", "HIP 68901"},
        {"Smithsonian Astrophysical Observation", "SAO 120289"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.60397521),
        dec: Angle.Degrees(+07.00483072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33545"},
        {"Hipparcos Number", "HIP 24159"},
        {"Smithsonian Astrophysical Observation", "SAO 112500"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.82511242),
        dec: Angle.Degrees(+07.00525099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125921"},
        {"Hipparcos Number", "HIP 70246"},
        {"Smithsonian Astrophysical Observation", "SAO 120415"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.59378818),
        dec: Angle.Degrees(+07.00545278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139551"},
        {"Hipparcos Number", "HIP 76597"},
        {"Smithsonian Astrophysical Observation", "SAO 121104"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.65773928),
        dec: Angle.Degrees(+07.00609005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72096"},
        {"Hipparcos Number", "HIP 41786"},
        {"Fundamental Katalog 5th Edition", "FK5 4767"},
        {"Smithsonian Astrophysical Observation", "SAO 116852"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.80172042),
        dec: Angle.Degrees(+07.00637813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46447"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.09845598),
        dec: Angle.Degrees(+07.00704103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13178"},
        {"Hipparcos Number", "HIP 10014"},
        {"Smithsonian Astrophysical Observation", "SAO 110368"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.23619617),
        dec: Angle.Degrees(+07.00763182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111165"},
        {"Hipparcos Number", "HIP 62397"},
        {"Geneva Identification System", "GEN# +1.00111165"},
        {"Smithsonian Astrophysical Observation", "SAO 119591"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.81182707),
        dec: Angle.Degrees(+07.00795668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113155"},
        {"Hipparcos Number", "HIP 63568"},
        {"Smithsonian Astrophysical Observation", "SAO 119725"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.40156695),
        dec: Angle.Degrees(+07.01083726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1771"},
        {"Hipparcos Number", "HIP 1738"},
        {"Smithsonian Astrophysical Observation", "SAO 109162"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.49908412),
        dec: Angle.Degrees(+07.01168378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66921"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.72329848),
        dec: Angle.Degrees(+07.01389725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146739"},
        {"Hipparcos Number", "HIP 79828"},
        {"Smithsonian Astrophysical Observation", "SAO 121477"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.40409112),
        dec: Angle.Degrees(+07.01417869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75374"},
        {"Hipparcos Number", "HIP 43350"},
        {"Smithsonian Astrophysical Observation", "SAO 117172"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.45313939),
        dec: Angle.Degrees(+07.01478364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159756"},
        {"Hipparcos Number", "HIP 86125"},
        {"Smithsonian Astrophysical Observation", "SAO 122549"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.01957584),
        dec: Angle.Degrees(+07.01485929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18419"},
        {"Hipparcos Number", "HIP 13813"},
        {"Smithsonian Astrophysical Observation", "SAO 110872"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.45230831),
        dec: Angle.Degrees(+07.01947072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63183",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8712 A"},
        {"Henry Draper", "HD 112448"},
        {"Hipparcos Number", "HIP 63183"},
        {"Smithsonian Astrophysical Observation", "SAO 119680"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.16801236),
        dec: Angle.Degrees(+07.02002617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67586"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.72820371),
        dec: Angle.Degrees(+07.02118418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55605"},
        {"Wilson Evans Batten Catalogue", "WEB 9996"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.87384940),
        dec: Angle.Degrees(+07.02520409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 256.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185962"},
        {"Hipparcos Number", "HIP 96871"},
        {"Geneva Identification System", "GEN# +1.00185962"},
        {"Smithsonian Astrophysical Observation", "SAO 124943"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.35733294),
        dec: Angle.Degrees(+07.02585964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72872"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.42059842),
        dec: Angle.Degrees(+07.02716007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102923"},
        {"Geneva Identification System", "GEN# +0.00604665"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.77724422),
        dec: Angle.Degrees(+07.02788342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -361.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12814"},
        {"Hipparcos Number", "HIP 9785"},
        {"Geneva Identification System", "GEN# +1.00012814"},
        {"Smithsonian Astrophysical Observation", "SAO 110332"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.45177725),
        dec: Angle.Degrees(+07.02839492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21682"},
        {"Smithsonian Astrophysical Observation", "SAO 111957"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.81442844),
        dec: Angle.Degrees(+07.02906153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102143"},
        {"Hipparcos Number", "HIP 57339"},
        {"Smithsonian Astrophysical Observation", "SAO 119030"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.35079020),
        dec: Angle.Degrees(+07.03008500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207356"},
        {"Hipparcos Number", "HIP 107646"},
        {"Geneva Identification System", "GEN# +1.00207356"},
        {"Smithsonian Astrophysical Observation", "SAO 127069"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.05751843),
        dec: Angle.Degrees(+07.03198968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220603"},
        {"Hipparcos Number", "HIP 115600"},
        {"Smithsonian Astrophysical Observation", "SAO 128167"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.24930249),
        dec: Angle.Degrees(+07.03260417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54268",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8054 A"},
        {"Henry Draper", "HD 96273"},
        {"Hipparcos Number", "HIP 54268"},
        {"Smithsonian Astrophysical Observation", "SAO 118656"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.53093907),
        dec: Angle.Degrees(+07.03360963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40022"},
        {"Smithsonian Astrophysical Observation", "SAO 116429"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.61256857),
        dec: Angle.Degrees(+07.03395450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52661"},
        {"Hipparcos Number", "HIP 33925"},
        {"Smithsonian Astrophysical Observation", "SAO 114813"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.59647259),
        dec: Angle.Degrees(+07.03550042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97800"},
        {"Hipparcos Number", "HIP 54954"},
        {"Smithsonian Astrophysical Observation", "SAO 118744"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.80591915),
        dec: Angle.Degrees(+07.03587366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91801"},
        {"Hipparcos Number", "HIP 51888"},
        {"Smithsonian Astrophysical Observation", "SAO 118389"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.02139330),
        dec: Angle.Degrees(+07.03656302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197718"},
        {"Hipparcos Number", "HIP 102427"},
        {"Fundamental Katalog 5th Edition", "FK5 5828"},
        {"Smithsonian Astrophysical Observation", "SAO 126174"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.33330061),
        dec: Angle.Degrees(+07.03889326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6374"},
        {"Hipparcos Number", "HIP 5073"},
        {"Geneva Identification System", "GEN# +1.00006374"},
        {"Smithsonian Astrophysical Observation", "SAO 109654"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.20977265),
        dec: Angle.Degrees(+07.04618317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75318",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75318"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.81982754),
        dec: Angle.Degrees(+07.04620971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43526"},
        {"Hipparcos Number", "HIP 29839"},
        {"Celescope Catalog", "CEL 1158"},
        {"Geneva Identification System", "GEN# +1.00043526"},
        {"Smithsonian Astrophysical Observation", "SAO 113673"},
        {"Wilson Evans Batten Catalogue", "WEB 5902"},
    },
    visualMagnitude: 6.56,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.24352085),
        dec: Angle.Degrees(+07.05258385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42090"},
        {"Hipparcos Number", "HIP 29167"},
        {"Smithsonian Astrophysical Observation", "SAO 113513"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.28264398),
        dec: Angle.Degrees(+07.05542683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34135"},
        {"Hipparcos Number", "HIP 24510"},
        {"Geneva Identification System", "GEN# +1.00034135"},
        {"Smithsonian Astrophysical Observation", "SAO 112571"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.86085865),
        dec: Angle.Degrees(+07.05548896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186843"},
        {"Hipparcos Number", "HIP 97312"},
        {"Geneva Identification System", "GEN# +1.00186843"},
        {"Smithsonian Astrophysical Observation", "SAO 125050"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.65032751),
        dec: Angle.Degrees(+07.05570077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35175"},
        {"Hipparcos Number", "HIP 25181"},
        {"Geneva Identification System", "GEN# +1.00035175"},
        {"Smithsonian Astrophysical Observation", "SAO 112703"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.80029561),
        dec: Angle.Degrees(+07.05628586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100700"},
        {"Smithsonian Astrophysical Observation", "SAO 125776"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.23556352),
        dec: Angle.Degrees(+07.05944745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133270"},
        {"Hipparcos Number", "HIP 73656"},
        {"Smithsonian Astrophysical Observation", "SAO 120815"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.85172021),
        dec: Angle.Degrees(+07.06027886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28218"},
        {"Hipparcos Number", "HIP 20794"},
        {"Geneva Identification System", "GEN# +1.00028218"},
        {"Smithsonian Astrophysical Observation", "SAO 111831"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.84244893),
        dec: Angle.Degrees(+07.06249787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82504"},
        {"Hipparcos Number", "HIP 46826"},
        {"Smithsonian Astrophysical Observation", "SAO 117755"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.13484218),
        dec: Angle.Degrees(+07.06345554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140161"},
        {"Hipparcos Number", "HIP 76883"},
        {"Geneva Identification System", "GEN# +1.00140161"},
        {"Smithsonian Astrophysical Observation", "SAO 121130"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.49302127),
        dec: Angle.Degrees(+07.06426089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98630"},
        {"Hipparcos Number", "HIP 55427"},
        {"Geneva Identification System", "GEN# +1.00098630"},
        {"Smithsonian Astrophysical Observation", "SAO 118803"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.26042706),
        dec: Angle.Degrees(+07.06458263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14169",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2308 AB"},
        {"Hipparcos Number", "HIP 14169"},
        {"Smithsonian Astrophysical Observation", "SAO 110924"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.67686822),
        dec: Angle.Degrees(+07.06673010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200779"},
        {"Hipparcos Number", "HIP 104092"},
        {"Cincinnati Publication", "Ci 20 1256"},
        {"Geneva Identification System", "GEN# +1.00200779"},
        {"Smithsonian Astrophysical Observation", "SAO 126533"},
        {"Wilson Evans Batten Catalogue", "WEB 18959"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.33208234),
        dec: Angle.Degrees(+07.07066797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -563.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224103"},
        {"Hipparcos Number", "HIP 117927"},
        {"Geneva Identification System", "GEN# +1.00224103"},
        {"Renson", "Renson 61430"},
        {"Smithsonian Astrophysical Observation", "SAO 128466"},
        {"Wilson Evans Batten Catalogue", "WEB 20738"},
    },
    visualMagnitude: 6.22,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.78241335),
        dec: Angle.Degrees(+07.07101644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12783"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.07610823),
        dec: Angle.Degrees(+07.07136398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192873"},
        {"Hipparcos Number", "HIP 99983"},
        {"Smithsonian Astrophysical Observation", "SAO 125646"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.25124454),
        dec: Angle.Degrees(+07.07172214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80162"},
        {"Hipparcos Number", "HIP 45653"},
        {"Smithsonian Astrophysical Observation", "SAO 117582"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.58761568),
        dec: Angle.Degrees(+07.07303011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103552"},
        {"Renson", "Renson 55640"},
        {"Smithsonian Astrophysical Observation", "SAO 126425"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.69667639),
        dec: Angle.Degrees(+07.07653171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222306"},
        {"Hipparcos Number", "HIP 116731"},
        {"Smithsonian Astrophysical Observation", "SAO 128305"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.84581050),
        dec: Angle.Degrees(+07.07765271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33369"},
        {"Wilson Evans Batten Catalogue", "WEB 6707"},
    },
    visualMagnitude: 9.70,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.09503902),
        dec: Angle.Degrees(+07.07774914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10683"},
        {"Hipparcos Number", "HIP 8120"},
        {"Geneva Identification System", "GEN# +1.00010683"},
        {"Smithsonian Astrophysical Observation", "SAO 110103"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.09342226),
        dec: Angle.Degrees(+07.07820402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62145"},
        {"Hipparcos Number", "HIP 37592"},
        {"Smithsonian Astrophysical Observation", "SAO 115830"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.70364569),
        dec: Angle.Degrees(+07.08156203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156130"},
        {"Hipparcos Number", "HIP 84418"},
        {"Smithsonian Astrophysical Observation", "SAO 122212"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.87441219),
        dec: Angle.Degrees(+07.08171036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15214"},
        {"Smithsonian Astrophysical Observation", "SAO 111084"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.03180378),
        dec: Angle.Degrees(+07.08186673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103913"},
        {"Geneva Identification System", "GEN# +0.00604733"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.81767534),
        dec: Angle.Degrees(+07.08286249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 246.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51671",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7828 AB"},
        {"Henry Draper", "HD 91410"},
        {"Hipparcos Number", "HIP 51671"},
        {"Smithsonian Astrophysical Observation", "SAO 118358"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.34603610),
        dec: Angle.Degrees(+07.08376917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116164",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16819 AB"},
        {"Henry Draper", "HD 221445"},
        {"Hipparcos Number", "HIP 116164"},
        {"Geneva Identification System", "GEN# +1.00221445J"},
        {"Smithsonian Astrophysical Observation", "SAO 128231"},
        {"Wilson Evans Batten Catalogue", "WEB 20533"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.05296646),
        dec: Angle.Degrees(+07.08501528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44990"},
        {"Hipparcos Number", "HIP 30541"},
        {"Geneva Identification System", "GEN# +1.00044990"},
        {"Smithsonian Astrophysical Observation", "SAO 113845"},
        {"Wilson Evans Batten Catalogue", "WEB 6086"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.30416365),
        dec: Angle.Degrees(+07.08571682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20731"},
        {"Smithsonian Astrophysical Observation", "SAO 111819"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.65045594),
        dec: Angle.Degrees(+07.08582069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10245"},
        {"Hipparcos Number", "HIP 7803"},
        {"Smithsonian Astrophysical Observation", "SAO 110044"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.09814073),
        dec: Angle.Degrees(+07.08666237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117311"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.80750604),
        dec: Angle.Degrees(+07.08702707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35038"},
        {"Hipparcos Number", "HIP 25073"},
        {"Geneva Identification System", "GEN# +1.00035038"},
        {"Smithsonian Astrophysical Observation", "SAO 112676"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.52499633),
        dec: Angle.Degrees(+07.08962768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2464"},
        {"Hipparcos Number", "HIP 2244"},
        {"Smithsonian Astrophysical Observation", "SAO 109225"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.12887480),
        dec: Angle.Degrees(+07.09019980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165476"},
        {"Hipparcos Number", "HIP 88644"},
        {"Geneva Identification System", "GEN# +1.00165476"},
        {"Smithsonian Astrophysical Observation", "SAO 123116"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.46814423),
        dec: Angle.Degrees(+07.09090074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -209.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84681"},
        {"Hipparcos Number", "HIP 47995"},
        {"Smithsonian Astrophysical Observation", "SAO 117904"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.75882647),
        dec: Angle.Degrees(+07.09104924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244437"},
        {"Hipparcos Number", "HIP 25823"},
        {"Smithsonian Astrophysical Observation", "SAO 112852"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.71424738),
        dec: Angle.Degrees(+07.09115145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103160"},
    },
    visualMagnitude: 11.36,
    bvColour: 2.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.50929209),
        dec: Angle.Degrees(+07.09293688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63058"},
        {"Smithsonian Astrophysical Observation", "SAO 119667"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.80508739),
        dec: Angle.Degrees(+07.09819913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39661"},
        {"Smithsonian Astrophysical Observation", "SAO 116344"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.57850742),
        dec: Angle.Degrees(+07.10157110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169721"},
        {"Hipparcos Number", "HIP 90330"},
        {"Geneva Identification System", "GEN# +2.66330026"},
        {"Smithsonian Astrophysical Observation", "SAO 123465"},
        {"New General Catalogue", "NGC 6633 26"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.45899322),
        dec: Angle.Degrees(+07.10172953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181853"},
        {"Hipparcos Number", "HIP 95191"},
        {"Geneva Identification System", "GEN# +1.00181853"},
        {"Smithsonian Astrophysical Observation", "SAO 124548"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.46838324),
        dec: Angle.Degrees(+07.10229145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13974"},
        {"Smithsonian Astrophysical Observation", "SAO 110893"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.00244215),
        dec: Angle.Degrees(+07.10267660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18562"},
    },
    visualMagnitude: 11.14,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.59971232),
        dec: Angle.Degrees(+07.10665070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149805"},
        {"Hipparcos Number", "HIP 81354"},
        {"Smithsonian Astrophysical Observation", "SAO 121728"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.21519325),
        dec: Angle.Degrees(+07.10719597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108380",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108380"},
        {"Cincinnati Publication", "Ci 20 1323"},
        {"Geneva Identification System", "GEN# +9.80018008"},
    },
    visualMagnitude: 11.02,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.35839099),
        dec: Angle.Degrees(+08.13695772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 380.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49584"},
        {"Hipparcos Number", "HIP 32707"},
        {"Smithsonian Astrophysical Observation", "SAO 114469"},
    },
    visualMagnitude: 8.93,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.35780546),
        dec: Angle.Degrees(+07.10732334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30961",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5124 A"},
        {"Henry Draper", "HD 45789"},
        {"Hipparcos Number", "HIP 30961"},
        {"Celescope Catalog", "CEL 1264"},
        {"Geneva Identification System", "GEN# +1.00045789"},
        {"Smithsonian Astrophysical Observation", "SAO 113953"},
        {"Wilson Evans Batten Catalogue", "WEB 6166"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.48314689),
        dec: Angle.Degrees(+07.11199731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 933"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.89828655),
        dec: Angle.Degrees(+07.12150984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124493"},
        {"Hipparcos Number", "HIP 69522"},
        {"Smithsonian Astrophysical Observation", "SAO 120354"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.47571165),
        dec: Angle.Degrees(+07.12158808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83147"},
        {"Hipparcos Number", "HIP 47158"},
        {"Geneva Identification System", "GEN# +1.00083147"},
        {"Smithsonian Astrophysical Observation", "SAO 117802"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.14058167),
        dec: Angle.Degrees(+07.12278449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66349"},
        {"Hipparcos Number", "HIP 39405"},
        {"Geneva Identification System", "GEN# +1.00066349"},
        {"Smithsonian Astrophysical Observation", "SAO 116282"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.83608137),
        dec: Angle.Degrees(+07.12450615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175637"},
        {"Hipparcos Number", "HIP 92930"},
        {"Geneva Identification System", "GEN# +1.00175637"},
        {"Smithsonian Astrophysical Observation", "SAO 124067"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.00202095),
        dec: Angle.Degrees(+07.12624570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28832",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4660 AB"},
        {"Henry Draper", "HD 41379"},
        {"Hipparcos Number", "HIP 28832"},
        {"Smithsonian Astrophysical Observation", "SAO 113433"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.29070384),
        dec: Angle.Degrees(+07.12803332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244526"},
        {"Hipparcos Number", "HIP 25866"},
        {"Smithsonian Astrophysical Observation", "SAO 112862"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.83361098),
        dec: Angle.Degrees(+07.12861737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257779"},
        {"Hipparcos Number", "HIP 30766"},
        {"Celescope Catalog", "CEL 1247"},
        {"Geneva Identification System", "GEN# +1.00257779"},
        {"Smithsonian Astrophysical Observation", "SAO 113919"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.97294826),
        dec: Angle.Degrees(+07.12932557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257278"},
        {"Hipparcos Number", "HIP 30652"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.61125584),
        dec: Angle.Degrees(+07.12933285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23779"},
        {"Hipparcos Number", "HIP 17752"},
        {"Smithsonian Astrophysical Observation", "SAO 111424"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.00851101),
        dec: Angle.Degrees(+07.12964397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77011"},
        {"Hipparcos Number", "HIP 44178"},
        {"Smithsonian Astrophysical Observation", "SAO 117331"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.97712886),
        dec: Angle.Degrees(+07.13664481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96272"},
        {"Hipparcos Number", "HIP 54274"},
        {"Geneva Identification System", "GEN# +1.00096272"},
        {"Smithsonian Astrophysical Observation", "SAO 118658"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.53931970),
        dec: Angle.Degrees(+07.13963061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97970",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13093 A"},
        {"Henry Draper", "HD 188385"},
        {"Hipparcos Number", "HIP 97970"},
        {"Geneva Identification System", "GEN# +1.00188385J"},
        {"Smithsonian Astrophysical Observation", "SAO 125221"},
        {"Wilson Evans Batten Catalogue", "WEB 17244"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.66743028),
        dec: Angle.Degrees(+07.14035304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207184"},
        {"Hipparcos Number", "HIP 107559"},
        {"Geneva Identification System", "GEN# +1.00207184"},
        {"Smithsonian Astrophysical Observation", "SAO 127058"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.77143497),
        dec: Angle.Degrees(+07.14095248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57006"},
        {"Hipparcos Number", "HIP 35509"},
        {"Fundamental Katalog 5th Edition", "FK5 2565"},
        {"Geneva Identification System", "GEN# +1.00057006"},
        {"Smithsonian Astrophysical Observation", "SAO 115269"},
        {"Wilson Evans Batten Catalogue", "WEB 7082"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.94837319),
        dec: Angle.Degrees(+07.14309133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181214"},
        {"Hipparcos Number", "HIP 94954"},
        {"Geneva Identification System", "GEN# +1.00181214"},
        {"Smithsonian Astrophysical Observation", "SAO 124505"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.83145630),
        dec: Angle.Degrees(+07.14363098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17766"},
        {"Geneva Identification System", "GEN# +5.20257015"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.04900068),
        dec: Angle.Degrees(+07.14622798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8946"},
    },
    visualMagnitude: 12.49,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.80776754),
        dec: Angle.Degrees(+07.14640678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113894"},
        {"Hipparcos Number", "HIP 63986"},
        {"Geneva Identification System", "GEN# +1.00113894"},
        {"Renson", "Renson 33000"},
        {"Smithsonian Astrophysical Observation", "SAO 119767"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.67771288),
        dec: Angle.Degrees(+07.14680638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71513"},
        {"Hipparcos Number", "HIP 41532"},
        {"Smithsonian Astrophysical Observation", "SAO 116793"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.05105929),
        dec: Angle.Degrees(+07.14718734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47292"},
        {"Hipparcos Number", "HIP 31724"},
        {"Celescope Catalog", "CEL 1328"},
        {"Geneva Identification System", "GEN# +1.00047292"},
        {"Smithsonian Astrophysical Observation", "SAO 114174"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.54937637),
        dec: Angle.Degrees(+07.14823202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108425"},
        {"Hipparcos Number", "HIP 60766"},
        {"Geneva Identification System", "GEN# +1.00108425"},
        {"Smithsonian Astrophysical Observation", "SAO 119404"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.84030637),
        dec: Angle.Degrees(+07.14842821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7774"},
        {"Hipparcos Number", "HIP 6038"},
        {"Smithsonian Astrophysical Observation", "SAO 109790"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.39355003),
        dec: Angle.Degrees(+07.15004377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146644"},
        {"Hipparcos Number", "HIP 79792"},
        {"Geneva Identification System", "GEN# +1.00146644"},
        {"Smithsonian Astrophysical Observation", "SAO 121471"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.25510869),
        dec: Angle.Degrees(+07.15188391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168041"},
        {"Hipparcos Number", "HIP 89639"},
        {"Smithsonian Astrophysical Observation", "SAO 123332"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.40270053),
        dec: Angle.Degrees(+07.15240810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36602"},
        {"Hipparcos Number", "HIP 26032"},
        {"Geneva Identification System", "GEN# +1.00036602"},
        {"Wilson Evans Batten Catalogue", "WEB 5065"},
    },
    visualMagnitude: 7.89,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.30727595),
        dec: Angle.Degrees(+07.15346358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177904"},
        {"Hipparcos Number", "HIP 93822"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.59596842),
        dec: Angle.Degrees(+07.15549520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3294"},
        {"Hipparcos Number", "HIP 2847"},
        {"Geneva Identification System", "GEN# +1.00003294"},
        {"Smithsonian Astrophysical Observation", "SAO 109306"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.01513090),
        dec: Angle.Degrees(+07.15600861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174716"},
        {"Hipparcos Number", "HIP 92557"},
        {"Smithsonian Astrophysical Observation", "SAO 123982"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.91624190),
        dec: Angle.Degrees(+07.15628614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101046",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13894 AB"},
        {"Henry Draper", "HD 195090"},
        {"Hipparcos Number", "HIP 101046"},
        {"Smithsonian Astrophysical Observation", "SAO 125855"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.26074312),
        dec: Angle.Degrees(+07.15814456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26990"},
        {"Hipparcos Number", "HIP 19911"},
        {"Geneva Identification System", "GEN# +1.00026990"},
        {"Smithsonian Astrophysical Observation", "SAO 111707"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.06894650),
        dec: Angle.Degrees(+07.15957076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20169"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.84140412),
        dec: Angle.Degrees(+07.16150291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223292"},
        {"Hipparcos Number", "HIP 117398"},
        {"Geneva Identification System", "GEN# +1.00223292"},
        {"Smithsonian Astrophysical Observation", "SAO 128389"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.06025617),
        dec: Angle.Degrees(+07.16326231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24144"},
        {"Hipparcos Number", "HIP 18001"},
        {"Smithsonian Astrophysical Observation", "SAO 111457"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.72744796),
        dec: Angle.Degrees(+07.16386262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64650"},
        {"Hipparcos Number", "HIP 38685"},
        {"Smithsonian Astrophysical Observation", "SAO 116113"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.80226678),
        dec: Angle.Degrees(+07.16526198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104772",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14759 D"},
        {"Henry Draper", "HD 202093"},
        {"Hipparcos Number", "HIP 104772"},
        {"Geneva Identification System", "GEN# +1.00202093J"},
        {"Renson", "Renson 56330"},
        {"Smithsonian Astrophysical Observation", "SAO 126627"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.37051339),
        dec: Angle.Degrees(+07.16741204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7278"},
        {"Smithsonian Astrophysical Observation", "SAO 109973"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.43715023),
        dec: Angle.Degrees(+07.16786672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46387"},
        {"Hipparcos Number", "HIP 31260"},
        {"Smithsonian Astrophysical Observation", "SAO 114041"},
    },
    visualMagnitude: 9.40,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.34661763),
        dec: Angle.Degrees(+07.16905875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35714"},
        {"Hipparcos Number", "HIP 25483"},
        {"Smithsonian Astrophysical Observation", "SAO 112779"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.74995716),
        dec: Angle.Degrees(+07.17036481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193799"},
        {"Hipparcos Number", "HIP 100431"},
        {"Smithsonian Astrophysical Observation", "SAO 125726"},
        {"Wilson Evans Batten Catalogue", "WEB 18130"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.48791547),
        dec: Angle.Degrees(+07.17164797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48618",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7573 AB"},
        {"Henry Draper", "HD 85855"},
        {"Hipparcos Number", "HIP 48618"},
        {"Smithsonian Astrophysical Observation", "SAO 117986"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.72214390),
        dec: Angle.Degrees(+07.17173992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86440"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.93591180),
        dec: Angle.Degrees(+07.17254435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214641"},
        {"Hipparcos Number", "HIP 111857"},
        {"Smithsonian Astrophysical Observation", "SAO 127668"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.86818471),
        dec: Angle.Degrees(+07.17333827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106195",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15034 AB"},
        {"Henry Draper", "HD 204736"},
        {"Hipparcos Number", "HIP 106195"},
        {"Smithsonian Astrophysical Observation", "SAO 126850"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.65011247),
        dec: Angle.Degrees(+07.17374379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14804",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2386 AB"},
        {"Henry Draper", "HD 19790"},
        {"Hipparcos Number", "HIP 14804"},
        {"Smithsonian Astrophysical Observation", "SAO 111033"},
        {"Wilson Evans Batten Catalogue", "WEB 2859"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.79252795),
        dec: Angle.Degrees(+07.17405382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102253"},
        {"Hipparcos Number", "HIP 57401"},
        {"Geneva Identification System", "GEN# +1.00102253"},
        {"Smithsonian Astrophysical Observation", "SAO 119038"},
        {"Wilson Evans Batten Catalogue", "WEB 10317"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.52621587),
        dec: Angle.Degrees(+07.17428589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111861"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.87400842),
        dec: Angle.Degrees(+07.17477865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147444"},
        {"Hipparcos Number", "HIP 80162"},
        {"Geneva Identification System", "GEN# +1.00147444"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.45434297),
        dec: Angle.Degrees(+07.17526473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -275.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207166"},
        {"Hipparcos Number", "HIP 107549"},
        {"Smithsonian Astrophysical Observation", "SAO 127057"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.74519581),
        dec: Angle.Degrees(+07.17542146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175580"},
        {"Hipparcos Number", "HIP 92901"},
        {"Geneva Identification System", "GEN# +1.00175580"},
        {"Smithsonian Astrophysical Observation", "SAO 124060"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.93815104),
        dec: Angle.Degrees(+07.17565200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10920"},
    },
    visualMagnitude: 11.81,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.15924392),
        dec: Angle.Degrees(+07.17600460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87261"},
        {"Hipparcos Number", "HIP 49316"},
        {"Geneva Identification System", "GEN# +1.00087261"},
        {"Smithsonian Astrophysical Observation", "SAO 118084"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.99932838),
        dec: Angle.Degrees(+07.17620104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159269"},
        {"Hipparcos Number", "HIP 85924"},
        {"Geneva Identification System", "GEN# +1.00159269"},
        {"Smithsonian Astrophysical Observation", "SAO 122507"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.38830318),
        dec: Angle.Degrees(+07.17828841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196710"},
        {"Hipparcos Number", "HIP 101891"},
        {"Geneva Identification System", "GEN# +1.00196710"},
        {"Smithsonian Astrophysical Observation", "SAO 126052"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.72581451),
        dec: Angle.Degrees(+07.17842496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117404"},
        {"Hipparcos Number", "HIP 65862"},
        {"Fundamental Katalog 5th Edition", "FK5 3077"},
        {"Geneva Identification System", "GEN# +1.00117404"},
        {"Smithsonian Astrophysical Observation", "SAO 119962"},
        {"Wilson Evans Batten Catalogue", "WEB 11652"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.50032849),
        dec: Angle.Degrees(+07.17884139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2373"},
        {"Geneva Identification System", "GEN# +0.00600058"},
        {"Smithsonian Astrophysical Observation", "SAO 109240"},
    },
    visualMagnitude: 10.68,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.57526279),
        dec: Angle.Degrees(+07.17913649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 290.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103813",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14556 AB"},
        {"Aitken 2", "ADS 14556"},
        {"Henry Draper", "HD 200256"},
        {"Hipparcos Number", "HIP 103813"},
        {"Smithsonian Astrophysical Observation", "SAO 126482"},
        {"Wilson Evans Batten Catalogue", "WEB 18894"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.55211421),
        dec: Angle.Degrees(+07.17980089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219140"},
        {"Hipparcos Number", "HIP 114645"},
        {"Smithsonian Astrophysical Observation", "SAO 128045"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.37134091),
        dec: Angle.Degrees(+07.18057865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197231"},
        {"Hipparcos Number", "HIP 102180"},
        {"Smithsonian Astrophysical Observation", "SAO 126118"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.56299212),
        dec: Angle.Degrees(+07.18144518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161978"},
        {"Hipparcos Number", "HIP 87147"},
        {"Smithsonian Astrophysical Observation", "SAO 122769"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.07670768),
        dec: Angle.Degrees(+07.18152100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33313"},
        {"Hipparcos Number", "HIP 24021"},
        {"Geneva Identification System", "GEN# +1.00033313"},
        {"Smithsonian Astrophysical Observation", "SAO 112475"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.44118728),
        dec: Angle.Degrees(+07.18155375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11005"},
    },
    visualMagnitude: 11.30,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.44554216),
        dec: Angle.Degrees(+07.18166909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212059"},
        {"Hipparcos Number", "HIP 110377"},
        {"Smithsonian Astrophysical Observation", "SAO 127471"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.34832803),
        dec: Angle.Degrees(+07.18541756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115692"},
        {"Hipparcos Number", "HIP 64939"},
        {"Fundamental Katalog 5th Edition", "FK5 5173"},
        {"Geneva Identification System", "GEN# +1.00115692"},
        {"Smithsonian Astrophysical Observation", "SAO 119865"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.67439003),
        dec: Angle.Degrees(+07.18642074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62563"},
        {"Smithsonian Astrophysical Observation", "SAO 119608"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.27955411),
        dec: Angle.Degrees(+07.18814911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49806"},
        {"Hipparcos Number", "HIP 32822"},
        {"Smithsonian Astrophysical Observation", "SAO 114494"},
        {"Wilson Evans Batten Catalogue", "WEB 6609"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.63247301),
        dec: Angle.Degrees(+07.18866485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222919"},
        {"Hipparcos Number", "HIP 117137"},
        {"Fundamental Katalog 5th Edition", "FK5 6105"},
        {"Smithsonian Astrophysical Observation", "SAO 128358"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.20388978),
        dec: Angle.Degrees(+07.19183343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205041"},
        {"Hipparcos Number", "HIP 106357"},
        {"Smithsonian Astrophysical Observation", "SAO 126874"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.12438137),
        dec: Angle.Degrees(+07.19534029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21797"},
        {"Hipparcos Number", "HIP 16380"},
        {"Smithsonian Astrophysical Observation", "SAO 111235"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.75605737),
        dec: Angle.Degrees(+07.19834418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182785"},
        {"Hipparcos Number", "HIP 95546"},
        {"Geneva Identification System", "GEN# +1.00182785"},
        {"Smithsonian Astrophysical Observation", "SAO 124622"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.52083970),
        dec: Angle.Degrees(+07.19858976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62830"},
        {"Geneva Identification System", "GEN# +1.00111908C"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.13093721),
        dec: Angle.Degrees(+07.20108745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169113"},
        {"Hipparcos Number", "HIP 90069"},
        {"Geneva Identification System", "GEN# +1.00169113"},
        {"Smithsonian Astrophysical Observation", "SAO 123409"},
        {"Wilson Evans Batten Catalogue", "WEB 15393"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.70445190),
        dec: Angle.Degrees(+07.20674795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111908"},
        {"Hipparcos Number", "HIP 62827"},
        {"Geneva Identification System", "GEN# +0.00802654"},
        {"Geneva Identification System 2", "GEN# +1.00111908A"},
        {"Smithsonian Astrophysical Observation", "SAO 119641"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.12262144),
        dec: Angle.Degrees(+07.20786410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62831"},
        {"Geneva Identification System", "GEN# +1.00111908B"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.13192151),
        dec: Angle.Degrees(+07.20840786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34173"},
        {"Smithsonian Astrophysical Observation", "SAO 114890"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.31387763),
        dec: Angle.Degrees(+07.20884738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53421"},
        {"Hipparcos Number", "HIP 34181"},
        {"Smithsonian Astrophysical Observation", "SAO 114892"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.32559532),
        dec: Angle.Degrees(+07.20961389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86827"},
        {"Hipparcos Number", "HIP 49100"},
        {"Geneva Identification System", "GEN# +1.00086827"},
        {"Smithsonian Astrophysical Observation", "SAO 118054"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.31939861),
        dec: Angle.Degrees(+07.21089513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62144"},
        {"Hipparcos Number", "HIP 37582"},
        {"Smithsonian Astrophysical Observation", "SAO 115829"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.68915930),
        dec: Angle.Degrees(+07.21143421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65241"},
        {"Hipparcos Number", "HIP 38945"},
        {"Geneva Identification System", "GEN# +1.00065241"},
        {"Smithsonian Astrophysical Observation", "SAO 116179"},
        {"Wilson Evans Batten Catalogue", "WEB 7632"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.52459597),
        dec: Angle.Degrees(+07.21355485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153930"},
        {"Hipparcos Number", "HIP 83353"},
        {"Smithsonian Astrophysical Observation", "SAO 122025"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.53290081),
        dec: Angle.Degrees(+07.21358972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40106",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40106"},
        {"Smithsonian Astrophysical Observation", "SAO 116455"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.88434311),
        dec: Angle.Degrees(+07.21424498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219892"},
        {"Hipparcos Number", "HIP 115137"},
        {"Smithsonian Astrophysical Observation", "SAO 128113"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.83457148),
        dec: Angle.Degrees(+07.21498791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110850"},
        {"Smithsonian Astrophysical Observation", "SAO 127536"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.86273508),
        dec: Angle.Degrees(+07.21620248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90570"},
        {"Hipparcos Number", "HIP 51195"},
        {"Smithsonian Astrophysical Observation", "SAO 118312"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.85615963),
        dec: Angle.Degrees(+07.21640344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17106"},
        {"Hipparcos Number", "HIP 12825"},
        {"Smithsonian Astrophysical Observation", "SAO 110722"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.21895867),
        dec: Angle.Degrees(+07.21685385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94266"},
        {"Hipparcos Number", "HIP 53201"},
        {"Smithsonian Astrophysical Observation", "SAO 118560"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.21108865),
        dec: Angle.Degrees(+07.21769961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104767",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14759 AB"},
        {"Henry Draper", "HD 202073"},
        {"Hipparcos Number", "HIP 104767"},
        {"Geneva Identification System", "GEN# +1.00202073"},
        {"Smithsonian Astrophysical Observation", "SAO 126625"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.36349209),
        dec: Angle.Degrees(+07.21802821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92055"},
        {"Geneva Identification System", "GEN# +0.00703832"},
        {"Wilson Evans Batten Catalogue", "WEB 15867"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.44324918),
        dec: Angle.Degrees(+07.22008027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95177"},
        {"Hipparcos Number", "HIP 53725"},
        {"Geneva Identification System", "GEN# +1.00095177"},
        {"Smithsonian Astrophysical Observation", "SAO 118605"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.88193466),
        dec: Angle.Degrees(+07.22053931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -204.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71310"},
        {"Hipparcos Number", "HIP 41430"},
        {"Smithsonian Astrophysical Observation", "SAO 116767"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.75016558),
        dec: Angle.Degrees(+07.22114058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11170"},
        {"Hipparcos Number", "HIP 8524"},
        {"Geneva Identification System", "GEN# +1.00011170"},
        {"Smithsonian Astrophysical Observation", "SAO 110154"},
        {"Wilson Evans Batten Catalogue", "WEB 1813"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.48331150),
        dec: Angle.Degrees(+07.22368856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143778"},
        {"Hipparcos Number", "HIP 78546"},
        {"Geneva Identification System", "GEN# +1.00143778"},
        {"Smithsonian Astrophysical Observation", "SAO 121322"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.53994102),
        dec: Angle.Degrees(+07.22496150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55805"},
        {"Hipparcos Number", "HIP 35043"},
        {"Smithsonian Astrophysical Observation", "SAO 115132"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.71284144),
        dec: Angle.Degrees(+07.22506115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169032"},
        {"Hipparcos Number", "HIP 90047"},
        {"Smithsonian Astrophysical Observation", "SAO 123402"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.61254726),
        dec: Angle.Degrees(+07.22630646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55679"},
        {"Hipparcos Number", "HIP 34978"},
        {"Smithsonian Astrophysical Observation", "SAO 115113"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.55747890),
        dec: Angle.Degrees(+07.22941896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15055"},
        {"Hipparcos Number", "HIP 11312"},
        {"Geneva Identification System", "GEN# +1.00015055"},
        {"Smithsonian Astrophysical Observation", "SAO 110526"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.40544349),
        dec: Angle.Degrees(+07.23012839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90242",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11323 AB"},
        {"Henry Draper", "HD 169512"},
        {"Hipparcos Number", "HIP 90242"},
        {"Geneva Identification System", "GEN# +2.66330010"},
        {"Smithsonian Astrophysical Observation", "SAO 123443"},
        {"New General Catalogue", "NGC 6633 10"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.18848093),
        dec: Angle.Degrees(+07.23125156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126533"},
        {"Hipparcos Number", "HIP 70562"},
        {"Geneva Identification System", "GEN# +1.00126533"},
        {"Smithsonian Astrophysical Observation", "SAO 120457"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.50234078),
        dec: Angle.Degrees(+07.23127382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170935"},
        {"Hipparcos Number", "HIP 90826"},
        {"Geneva Identification System", "GEN# +1.00170935"},
        {"Smithsonian Astrophysical Observation", "SAO 123606"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.92939478),
        dec: Angle.Degrees(+07.23175468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149891"},
        {"Hipparcos Number", "HIP 81391"},
        {"Smithsonian Astrophysical Observation", "SAO 121736"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.33821315),
        dec: Angle.Degrees(+07.23210381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87325",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10828 AB"},
        {"Henry Draper", "HD 162405"},
        {"Hipparcos Number", "HIP 87325"},
        {"Smithsonian Astrophysical Observation", "SAO 122818"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.64537838),
        dec: Angle.Degrees(+07.23276292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2373"},
        {"Hipparcos Number", "HIP 2181"},
        {"Geneva Identification System", "GEN# +1.00002373"},
        {"Smithsonian Astrophysical Observation", "SAO 109218"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.89172987),
        dec: Angle.Degrees(+07.23446979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142010"},
        {"Hipparcos Number", "HIP 77703"},
        {"Smithsonian Astrophysical Observation", "SAO 121226"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.97671402),
        dec: Angle.Degrees(+07.23746709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73802"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.25809445),
        dec: Angle.Degrees(+07.23964905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46454"},
        {"Hipparcos Number", "HIP 31297"},
        {"Smithsonian Astrophysical Observation", "SAO 114052"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.44351066),
        dec: Angle.Degrees(+07.23999803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108424"},
        {"Hipparcos Number", "HIP 60765"},
        {"Smithsonian Astrophysical Observation", "SAO 119403"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.83022350),
        dec: Angle.Degrees(+07.24156317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155609"},
        {"Hipparcos Number", "HIP 84170"},
        {"Smithsonian Astrophysical Observation", "SAO 122176"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.09670480),
        dec: Angle.Degrees(+07.24234642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19432"},
        {"Hipparcos Number", "HIP 14536"},
        {"Geneva Identification System", "GEN# +1.00019432"},
        {"Smithsonian Astrophysical Observation", "SAO 110985"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.91850467),
        dec: Angle.Degrees(+07.24588057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120720"},
        {"Hipparcos Number", "HIP 67598"},
        {"Smithsonian Astrophysical Observation", "SAO 120137"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.77038225),
        dec: Angle.Degrees(+07.24629448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18852"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.62686768),
        dec: Angle.Degrees(+07.24632371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151956"},
        {"Hipparcos Number", "HIP 82402"},
        {"Geneva Identification System", "GEN# +1.00151956"},
        {"Renson", "Renson 42990"},
        {"Smithsonian Astrophysical Observation", "SAO 121895"},
        {"Wilson Evans Batten Catalogue", "WEB 13911"},
    },
    visualMagnitude: 5.48,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.58062783),
        dec: Angle.Degrees(+07.24770528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4225 AB"},
        {"Henry Draper", "HD 37301"},
        {"Hipparcos Number", "HIP 26480"},
        {"Smithsonian Astrophysical Observation", "SAO 112975"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.48162787),
        dec: Angle.Degrees(+07.24876277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176875"},
        {"Hipparcos Number", "HIP 93460"},
        {"Geneva Identification System", "GEN# +1.00176875"},
        {"Smithsonian Astrophysical Observation", "SAO 124178"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.51459045),
        dec: Angle.Degrees(+07.24893452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36749"},
        {"Smithsonian Astrophysical Observation", "SAO 115617"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.38099282),
        dec: Angle.Degrees(+07.24920904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117063",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16958 AB"},
        {"Henry Draper", "HD 222825"},
        {"Hipparcos Number", "HIP 117063"},
        {"Smithsonian Astrophysical Observation", "SAO 128351"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.98665336),
        dec: Angle.Degrees(+07.24955050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154693"},
        {"Hipparcos Number", "HIP 83728"},
        {"Smithsonian Astrophysical Observation", "SAO 122086"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.68721422),
        dec: Angle.Degrees(+07.25046484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222602"},
        {"Hipparcos Number", "HIP 116918"},
        {"Geneva Identification System", "GEN# +1.00222602"},
        {"Smithsonian Astrophysical Observation", "SAO 128335"},
        {"Wilson Evans Batten Catalogue", "WEB 20623"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.48627544),
        dec: Angle.Degrees(+07.25064591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160311"},
        {"Hipparcos Number", "HIP 86369"},
        {"Smithsonian Astrophysical Observation", "SAO 122602"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.72959790),
        dec: Angle.Degrees(+07.25127186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108239",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15452 AB"},
        {"Henry Draper", "HD 208364"},
        {"Hipparcos Number", "HIP 108239"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.91676851),
        dec: Angle.Degrees(+07.25393095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19462"},
        {"Hipparcos Number", "HIP 14556"},
        {"Geneva Identification System", "GEN# +1.00019462"},
        {"Smithsonian Astrophysical Observation", "SAO 110994"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.98451413),
        dec: Angle.Degrees(+07.25618181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216688"},
        {"Hipparcos Number", "HIP 113146"},
        {"Smithsonian Astrophysical Observation", "SAO 127833"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.68434375),
        dec: Angle.Degrees(+07.25757052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191362"},
        {"Hipparcos Number", "HIP 99282"},
        {"Smithsonian Astrophysical Observation", "SAO 125507"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.30695321),
        dec: Angle.Degrees(+07.25767703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94780"},
        {"Hipparcos Number", "HIP 53493"},
        {"Smithsonian Astrophysical Observation", "SAO 118580"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.15020807),
        dec: Angle.Degrees(+07.25953905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89772",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11254 A"},
        {"Henry Draper", "HD 168387"},
        {"Hipparcos Number", "HIP 89772"},
        {"Geneva Identification System", "GEN# +1.00168387"},
        {"Smithsonian Astrophysical Observation", "SAO 123353"},
        {"Wilson Evans Batten Catalogue", "WEB 15312"},
    },
    visualMagnitude: 5.41,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.78984693),
        dec: Angle.Degrees(+07.25976189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146930"},
        {"Hipparcos Number", "HIP 79901"},
        {"Smithsonian Astrophysical Observation", "SAO 121490"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.64328051),
        dec: Angle.Degrees(+07.26046712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78285"},
        {"Smithsonian Astrophysical Observation", "SAO 121295"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.75941105),
        dec: Angle.Degrees(+07.26142019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196123"},
        {"Hipparcos Number", "HIP 101571"},
        {"Smithsonian Astrophysical Observation", "SAO 125984"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.77696448),
        dec: Angle.Degrees(+07.26316346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47509"},
        {"Hipparcos Number", "HIP 31838"},
        {"Smithsonian Astrophysical Observation", "SAO 114216"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.84482945),
        dec: Angle.Degrees(+07.26403330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127404"},
        {"Hipparcos Number", "HIP 70980"},
        {"Smithsonian Astrophysical Observation", "SAO 120507"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.76626896),
        dec: Angle.Degrees(+07.26442237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158350"},
        {"Hipparcos Number", "HIP 85514"},
        {"Smithsonian Astrophysical Observation", "SAO 122414"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.13436597),
        dec: Angle.Degrees(+07.26908792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10274"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.06829104),
        dec: Angle.Degrees(+07.26929687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80512"},
        {"Smithsonian Astrophysical Observation", "SAO 121594"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.53908424),
        dec: Angle.Degrees(+07.27010712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77929"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.72239816),
        dec: Angle.Degrees(+07.27019973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20128"},
        {"Smithsonian Astrophysical Observation", "SAO 111740"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.73700200),
        dec: Angle.Degrees(+07.27104496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29602"},
        {"Hipparcos Number", "HIP 21732"},
        {"Geneva Identification System", "GEN# +1.00029602"},
        {"Smithsonian Astrophysical Observation", "SAO 111965"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.99960791),
        dec: Angle.Degrees(+07.27124514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5180"},
        {"Hipparcos Number", "HIP 4219"},
        {"Smithsonian Astrophysical Observation", "SAO 109526"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.45601203),
        dec: Angle.Degrees(+07.27142632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22539"},
        {"Hipparcos Number", "HIP 16918"},
        {"Smithsonian Astrophysical Observation", "SAO 111302"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.43655271),
        dec: Angle.Degrees(+07.27180057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28954"},
        {"Hipparcos Number", "HIP 21282"},
        {"Smithsonian Astrophysical Observation", "SAO 111894"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.50171664),
        dec: Angle.Degrees(+07.27233351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26256",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4185 A"},
        {"Henry Draper", "HD 36952"},
        {"Hipparcos Number", "HIP 26256"},
        {"Smithsonian Astrophysical Observation", "SAO 112931"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.87770285),
        dec: Angle.Degrees(+07.27260892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173056"},
        {"Hipparcos Number", "HIP 91803"},
        {"Smithsonian Astrophysical Observation", "SAO 123840"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.77492568),
        dec: Angle.Degrees(+07.27406309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42773"},
        {"Hipparcos Number", "HIP 29502"},
        {"Geneva Identification System", "GEN# +1.00042773"},
        {"Smithsonian Astrophysical Observation", "SAO 113591"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.24282923),
        dec: Angle.Degrees(+07.27776847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190327"},
        {"Hipparcos Number", "HIP 98823"},
        {"Fundamental Katalog 5th Edition", "FK5 1524"},
        {"Geneva Identification System", "GEN# +1.00190327"},
        {"Smithsonian Astrophysical Observation", "SAO 125403"},
        {"Wilson Evans Batten Catalogue", "WEB 17516"},
    },
    visualMagnitude: 5.51,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.03461172),
        dec: Angle.Degrees(+07.27793427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176735"},
        {"Hipparcos Number", "HIP 93406"},
        {"Fundamental Katalog 5th Edition", "FK5 5676"},
        {"Smithsonian Astrophysical Observation", "SAO 124161"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.35234420),
        dec: Angle.Degrees(+07.27947546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63607",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8744 A"},
        {"Henry Draper", "HD 113214"},
        {"Hipparcos Number", "HIP 63607"},
        {"Smithsonian Astrophysical Observation", "SAO 119730"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.53308404),
        dec: Angle.Degrees(+07.27966354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109286"},
        {"Hipparcos Number", "HIP 61298"},
        {"Geneva Identification System", "GEN# +1.00109286"},
        {"Smithsonian Astrophysical Observation", "SAO 119468"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.39575931),
        dec: Angle.Degrees(+07.28091630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63605",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8744 B"},
        {"Hipparcos Number", "HIP 63605"},
        {"Smithsonian Astrophysical Observation", "SAO 119729"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.53016319),
        dec: Angle.Degrees(+07.28097256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18214"},
        {"Hipparcos Number", "HIP 13650"},
        {"Smithsonian Astrophysical Observation", "SAO 110845"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.93827420),
        dec: Angle.Degrees(+07.28105637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130218"},
        {"Hipparcos Number", "HIP 72268"},
        {"Smithsonian Astrophysical Observation", "SAO 120655"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.68408554),
        dec: Angle.Degrees(+07.28140404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19042"},
        {"Hipparcos Number", "HIP 14266"},
        {"Geneva Identification System", "GEN# +1.00019042"},
        {"Smithsonian Astrophysical Observation", "SAO 110939"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.99015766),
        dec: Angle.Degrees(+07.28169935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1489"},
        {"Hipparcos Number", "HIP 1535"},
        {"Smithsonian Astrophysical Observation", "SAO 109134"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.78135640),
        dec: Angle.Degrees(+07.28249808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67230"},
        {"Hipparcos Number", "HIP 39733"},
        {"Geneva Identification System", "GEN# +1.00067230"},
        {"Smithsonian Astrophysical Observation", "SAO 116366"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.82401332),
        dec: Angle.Degrees(+07.28313716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89346"},
        {"Hipparcos Number", "HIP 50491"},
        {"Smithsonian Astrophysical Observation", "SAO 118213"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.65400910),
        dec: Angle.Degrees(+07.28377866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13177"},
        {"Hipparcos Number", "HIP 10009"},
        {"Smithsonian Astrophysical Observation", "SAO 110367"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.22974599),
        dec: Angle.Degrees(+07.28451427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181687"},
        {"Hipparcos Number", "HIP 95129"},
        {"Smithsonian Astrophysical Observation", "SAO 124535"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.29382588),
        dec: Angle.Degrees(+07.28743297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189510"},
        {"Hipparcos Number", "HIP 98455"},
        {"Smithsonian Astrophysical Observation", "SAO 125334"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.05615852),
        dec: Angle.Degrees(+07.28792675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15433"},
        {"Smithsonian Astrophysical Observation", "SAO 111115"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.72066078),
        dec: Angle.Degrees(+07.28998854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24584"},
    },
    visualMagnitude: 12.17,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.11647520),
        dec: Angle.Degrees(+07.29391411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9024"},
        {"Hipparcos Number", "HIP 6915"},
        {"Geneva Identification System", "GEN# +1.00009024"},
        {"Smithsonian Astrophysical Observation", "SAO 109916"},
        {"Wilson Evans Batten Catalogue", "WEB 1506"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.26296987),
        dec: Angle.Degrees(+07.29422704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40532"},
        {"Hipparcos Number", "HIP 28377"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.92373945),
        dec: Angle.Degrees(+07.29435158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46761"},
        {"Smithsonian Astrophysical Observation", "SAO 117749"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.96421329),
        dec: Angle.Degrees(+07.29499553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71298"},
        {"Smithsonian Astrophysical Observation", "SAO 120541"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.71915735),
        dec: Angle.Degrees(+07.29569502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77445"},
        {"Hipparcos Number", "HIP 44406"},
        {"Geneva Identification System", "GEN# +1.00077445"},
        {"Smithsonian Astrophysical Observation", "SAO 117369"},
        {"Wilson Evans Batten Catalogue", "WEB 8513"},
    },
    visualMagnitude: 5.85,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.68676211),
        dec: Angle.Degrees(+07.29826333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73056"},
        {"Geneva Identification System", "GEN# +9.80066042"},
    },
    visualMagnitude: 11.29,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.95043323),
        dec: Angle.Degrees(+07.29827872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121997"},
        {"Hipparcos Number", "HIP 68306"},
        {"Smithsonian Astrophysical Observation", "SAO 120205"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.73674033),
        dec: Angle.Degrees(+07.29921255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4627"},
        {"Hipparcos Number", "HIP 3760"},
        {"Geneva Identification System", "GEN# +1.00004627"},
        {"Smithsonian Astrophysical Observation", "SAO 109470"},
        {"Wilson Evans Batten Catalogue", "WEB 669"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.07226858),
        dec: Angle.Degrees(+07.29991977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97550",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12983 A"},
        {"Henry Draper", "HD 187434"},
        {"Hipparcos Number", "HIP 97550"},
        {"Smithsonian Astrophysical Observation", "SAO 125104"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.41246362),
        dec: Angle.Degrees(+07.30001900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12973"},
        {"Hipparcos Number", "HIP 9882"},
        {"Smithsonian Astrophysical Observation", "SAO 110349"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.78836557),
        dec: Angle.Degrees(+07.30098238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21496"},
        {"Hipparcos Number", "HIP 16158"},
        {"Geneva Identification System", "GEN# +1.00021496"},
        {"Smithsonian Astrophysical Observation", "SAO 111208"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.05434984),
        dec: Angle.Degrees(+07.30242401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164757"},
        {"Hipparcos Number", "HIP 88337"},
        {"Smithsonian Astrophysical Observation", "SAO 123052"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.60775887),
        dec: Angle.Degrees(+07.30296624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75964"},
        {"Geneva Identification System", "GEN# +9.80015025"},
    },
    visualMagnitude: 11.61,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.70913853),
        dec: Angle.Degrees(+07.30391653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -488.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6019"},
        {"Hipparcos Number", "HIP 4804"},
        {"Geneva Identification System", "GEN# +1.00006019"},
        {"Smithsonian Astrophysical Observation", "SAO 109609"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.41510694),
        dec: Angle.Degrees(+07.30529931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40198"},
        {"Smithsonian Astrophysical Observation", "SAO 116476"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.16429220),
        dec: Angle.Degrees(+07.30599139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148467"},
        {"Hipparcos Number", "HIP 80644"},
        {"Geneva Identification System", "GEN# +1.00148467"},
        {"Smithsonian Astrophysical Observation", "SAO 121619"},
        {"Wilson Evans Batten Catalogue", "WEB 13639"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.98772289),
        dec: Angle.Degrees(+07.30608720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -247.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -262.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153133"},
        {"Hipparcos Number", "HIP 82969"},
        {"Smithsonian Astrophysical Observation", "SAO 121957"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.32387251),
        dec: Angle.Degrees(+07.30738563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23057"},
        {"Smithsonian Astrophysical Observation", "SAO 112262"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.43104845),
        dec: Angle.Degrees(+07.31102815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37562"},
        {"Hipparcos Number", "HIP 26639"},
        {"Smithsonian Astrophysical Observation", "SAO 113010"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.93408726),
        dec: Angle.Degrees(+07.31584842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51892"},
        {"Hipparcos Number", "HIP 33644"},
        {"Geneva Identification System", "GEN# +1.00051892"},
        {"Smithsonian Astrophysical Observation", "SAO 114731"},
        {"Wilson Evans Batten Catalogue", "WEB 6760"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.83408286),
        dec: Angle.Degrees(+07.31698612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151000"},
        {"Hipparcos Number", "HIP 81944"},
        {"Smithsonian Astrophysical Observation", "SAO 121823"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.07597618),
        dec: Angle.Degrees(+07.31746232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29376"},
        {"Hipparcos Number", "HIP 21575"},
        {"Geneva Identification System", "GEN# +1.00029376"},
        {"Smithsonian Astrophysical Observation", "SAO 111940"},
        {"Wilson Evans Batten Catalogue", "WEB 4140"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.47639541),
        dec: Angle.Degrees(+07.31763254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23008"},
        {"Hipparcos Number", "HIP 17259"},
        {"Fundamental Katalog 5th Edition", "FK5 4335"},
        {"Smithsonian Astrophysical Observation", "SAO 111359"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.45445236),
        dec: Angle.Degrees(+07.31802561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251611"},
        {"Hipparcos Number", "HIP 28887"},
        {"Geneva Identification System", "GEN# +9.80102047"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.48952111),
        dec: Angle.Degrees(+07.31813250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27878"},
        {"Hipparcos Number", "HIP 20562"},
        {"Smithsonian Astrophysical Observation", "SAO 111793"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.06848879),
        dec: Angle.Degrees(+07.32019277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177834"},
        {"Hipparcos Number", "HIP 93787"},
        {"Smithsonian Astrophysical Observation", "SAO 124259"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.49585901),
        dec: Angle.Degrees(+07.32282798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134681"},
        {"Hipparcos Number", "HIP 74288"},
        {"Smithsonian Astrophysical Observation", "SAO 120882"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.75172943),
        dec: Angle.Degrees(+07.32448021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263584"},
        {"Hipparcos Number", "HIP 32445"},
        {"Geneva Identification System", "GEN# +1.00263584"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.57213045),
        dec: Angle.Degrees(+07.32821243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54695"},
        {"Hipparcos Number", "HIP 34614"},
        {"Smithsonian Astrophysical Observation", "SAO 115019"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.53584648),
        dec: Angle.Degrees(+07.32943906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39344"},
        {"Hipparcos Number", "HIP 27729"},
        {"Smithsonian Astrophysical Observation", "SAO 113217"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.07058269),
        dec: Angle.Degrees(+07.32944830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71480"},
        {"Smithsonian Astrophysical Observation", "SAO 120566"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.27029931),
        dec: Angle.Degrees(+07.33177387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210212"},
        {"Hipparcos Number", "HIP 109309"},
        {"Smithsonian Astrophysical Observation", "SAO 127320"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.18997777),
        dec: Angle.Degrees(+07.33179128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28629"},
        {"Hipparcos Number", "HIP 21084"},
        {"Smithsonian Astrophysical Observation", "SAO 111864"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.78345094),
        dec: Angle.Degrees(+07.33221948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46300"},
        {"Hipparcos Number", "HIP 31216"},
        {"Celescope Catalog", "CEL 1291"},
        {"Fundamental Katalog 5th Edition", "FK5 1174"},
        {"Geneva Identification System", "GEN# +1.00046300"},
        {"Smithsonian Astrophysical Observation", "SAO 114034"},
        {"Wilson Evans Batten Catalogue", "WEB 6236"},
    },
    visualMagnitude: 4.47,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.22595658),
        dec: Angle.Degrees(+07.33297921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58730"},
        {"Hipparcos Number", "HIP 36191"},
        {"Smithsonian Astrophysical Observation", "SAO 115459"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.78928107),
        dec: Angle.Degrees(+07.33540031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96097"},
        {"Hipparcos Number", "HIP 54182"},
        {"Fundamental Katalog 5th Edition", "FK5 418"},
        {"Geneva Identification System", "GEN# +1.00096097"},
        {"Renson", "Renson 27670"},
        {"Smithsonian Astrophysical Observation", "SAO 118648"},
        {"Wilson Evans Batten Catalogue", "WEB 9788"},
    },
    visualMagnitude: 4.62,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.25512463),
        dec: Angle.Degrees(+07.33612254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -344.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13420"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.20653591),
        dec: Angle.Degrees(+07.33634835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217186"},
        {"Hipparcos Number", "HIP 113465"},
        {"Geneva Identification System", "GEN# +1.00217186"},
        {"Smithsonian Astrophysical Observation", "SAO 127874"},
        {"Wilson Evans Batten Catalogue", "WEB 20175"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.67768044),
        dec: Angle.Degrees(+07.34023912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152695"},
        {"Hipparcos Number", "HIP 82733"},
        {"Smithsonian Astrophysical Observation", "SAO 121935"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.65338108),
        dec: Angle.Degrees(+07.34032404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63161"},
        {"Hipparcos Number", "HIP 38043"},
        {"Smithsonian Astrophysical Observation", "SAO 115942"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.95859811),
        dec: Angle.Degrees(+07.34135360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129005"},
        {"Hipparcos Number", "HIP 71704"},
        {"Smithsonian Astrophysical Observation", "SAO 120591"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.01596114),
        dec: Angle.Degrees(+07.34135667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30265"},
        {"Hipparcos Number", "HIP 22201"},
        {"Smithsonian Astrophysical Observation", "SAO 112061"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.61721655),
        dec: Angle.Degrees(+07.34416619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130427"},
        {"Hipparcos Number", "HIP 72392"},
        {"Smithsonian Astrophysical Observation", "SAO 120669"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.01473731),
        dec: Angle.Degrees(+07.34698751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106494"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.55504089),
        dec: Angle.Degrees(+07.35004142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60776"},
        {"Hipparcos Number", "HIP 37024"},
        {"Smithsonian Astrophysical Observation", "SAO 115690"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.13195105),
        dec: Angle.Degrees(+07.35053546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211704"},
        {"Hipparcos Number", "HIP 110165"},
        {"Smithsonian Astrophysical Observation", "SAO 127445"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.71622675),
        dec: Angle.Degrees(+07.35091900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177228"},
        {"Hipparcos Number", "HIP 93576"},
        {"Geneva Identification System", "GEN# +1.00177228"},
        {"Smithsonian Astrophysical Observation", "SAO 124205"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.87838102),
        dec: Angle.Degrees(+07.35306259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141004"},
        {"Hipparcos Number", "HIP 77257"},
        {"Geneva Identification System", "GEN# +1.00141004"},
        {"Smithsonian Astrophysical Observation", "SAO 121186"},
        {"Wilson Evans Batten Catalogue", "WEB 13090"},
    },
    visualMagnitude: 4.42,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.61144121),
        dec: Angle.Degrees(+07.35323973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -225.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34445"},
        {"Hipparcos Number", "HIP 24681"},
        {"Geneva Identification System", "GEN# +1.00034445"},
        {"Smithsonian Astrophysical Observation", "SAO 112601"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.42075333),
        dec: Angle.Degrees(+07.35370479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5892"},
        {"Hipparcos Number", "HIP 4708"},
        {"Geneva Identification System", "GEN# +1.00005892"},
        {"Smithsonian Astrophysical Observation", "SAO 109593"},
        {"Wilson Evans Batten Catalogue", "WEB 890"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.12680289),
        dec: Angle.Degrees(+07.35383219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95798"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.28314043),
        dec: Angle.Degrees(+07.35388006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181606"},
        {"Hipparcos Number", "HIP 95108"},
        {"Geneva Identification System", "GEN# +1.00181606"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.22552283),
        dec: Angle.Degrees(+07.35407545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203291"},
        {"Hipparcos Number", "HIP 105413"},
        {"Geneva Identification System", "GEN# +1.00203291"},
        {"Smithsonian Astrophysical Observation", "SAO 126719"},
        {"Wilson Evans Batten Catalogue", "WEB 19145"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.27000230),
        dec: Angle.Degrees(+07.35454610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25004"},
        {"Wilson Evans Batten Catalogue", "WEB 4843"},
    },
    visualMagnitude: 9.75,
    bvColour: 2.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.30571825),
        dec: Angle.Degrees(+07.35538007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106749"},
        {"Hipparcos Number", "HIP 59852"},
        {"Geneva Identification System", "GEN# +1.00106749"},
        {"Smithsonian Astrophysical Observation", "SAO 119300"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.11134438),
        dec: Angle.Degrees(+07.35540451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52122",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7868 AB"},
        {"Henry Draper", "HD 92212"},
        {"Hipparcos Number", "HIP 52122"},
        {"Smithsonian Astrophysical Observation", "SAO 118412"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.72894375),
        dec: Angle.Degrees(+07.35735054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64963"},
        {"Hipparcos Number", "HIP 38823"},
        {"Fundamental Katalog 5th Edition", "FK5 4715"},
        {"Smithsonian Astrophysical Observation", "SAO 116153"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.18609785),
        dec: Angle.Degrees(+07.35753545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79702",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9982 AB"},
        {"Henry Draper", "HD 146413"},
        {"Hipparcos Number", "HIP 79702"},
        {"Geneva Identification System", "GEN# +1.00146413"},
        {"Smithsonian Astrophysical Observation", "SAO 121460"},
        {"Wilson Evans Batten Catalogue", "WEB 13488"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.98731912),
        dec: Angle.Degrees(+07.35820979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -474.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66661"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.98532119),
        dec: Angle.Degrees(+07.35822544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91523",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11555 A"},
        {"Henry Draper", "HD 172424"},
        {"Hipparcos Number", "HIP 91523"},
        {"Geneva Identification System", "GEN# +1.00172424A"},
        {"Smithsonian Astrophysical Observation", "SAO 123782"},
        {"Wilson Evans Batten Catalogue", "WEB 15732"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.96499361),
        dec: Angle.Degrees(+07.35870967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90621",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11390 A"},
        {"Henry Draper", "HD 170512"},
        {"Hipparcos Number", "HIP 90621"},
        {"Smithsonian Astrophysical Observation", "SAO 123559"},
        {"New General Catalogue", "NGC 6633 157"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.36527651),
        dec: Angle.Degrees(+07.35963859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151291"},
        {"Hipparcos Number", "HIP 82104"},
        {"Geneva Identification System", "GEN# +1.00151291"},
        {"Smithsonian Astrophysical Observation", "SAO 121849"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.56479273),
        dec: Angle.Degrees(+07.36006617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218717"},
        {"Hipparcos Number", "HIP 114398"},
        {"Geneva Identification System", "GEN# +1.00218717"},
        {"Smithsonian Astrophysical Observation", "SAO 128008"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.52803891),
        dec: Angle.Degrees(+07.36251630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221042"},
        {"Hipparcos Number", "HIP 115883"},
        {"Smithsonian Astrophysical Observation", "SAO 128202"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.17729976),
        dec: Angle.Degrees(+07.36769315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81744"},
        {"Hipparcos Number", "HIP 46400"},
        {"Smithsonian Astrophysical Observation", "SAO 117706"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.93058456),
        dec: Angle.Degrees(+07.36792774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105928"},
        {"Hipparcos Number", "HIP 59438"},
        {"Geneva Identification System", "GEN# +1.00105928"},
        {"Smithsonian Astrophysical Observation", "SAO 119260"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.88052165),
        dec: Angle.Degrees(+07.36906315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20808"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.88194829),
        dec: Angle.Degrees(+07.36959062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180816"},
        {"Hipparcos Number", "HIP 94831"},
        {"Geneva Identification System", "GEN# +1.00180816"},
        {"Smithsonian Astrophysical Observation", "SAO 124480"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.44488384),
        dec: Angle.Degrees(+07.36965347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72025"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.99841374),
        dec: Angle.Degrees(+07.37075788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206418"},
        {"Hipparcos Number", "HIP 107118"},
        {"Smithsonian Astrophysical Observation", "SAO 126993"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.47668724),
        dec: Angle.Degrees(+07.37226812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69333"},
        {"Hipparcos Number", "HIP 40545"},
        {"Geneva Identification System", "GEN# +1.00069333"},
        {"Smithsonian Astrophysical Observation", "SAO 116574"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.19077249),
        dec: Angle.Degrees(+07.37270601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68883"},
    },
    visualMagnitude: 11.27,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.56221664),
        dec: Angle.Degrees(+07.37405544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144170"},
        {"Hipparcos Number", "HIP 78724"},
        {"Smithsonian Astrophysical Observation", "SAO 121348"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.06618146),
        dec: Angle.Degrees(+07.37434333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86174",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10659 AB"},
        {"Henry Draper", "HD 159857"},
        {"Hipparcos Number", "HIP 86174"},
        {"Renson", "Renson 44980"},
        {"Smithsonian Astrophysical Observation", "SAO 122561"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.14429036),
        dec: Angle.Degrees(+07.37532035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35541"},
        {"Smithsonian Astrophysical Observation", "SAO 115277"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.01355270),
        dec: Angle.Degrees(+07.37545179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197832"},
        {"Hipparcos Number", "HIP 102474"},
        {"Smithsonian Astrophysical Observation", "SAO 126187"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.48746541),
        dec: Angle.Degrees(+07.37909624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96229",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12607 A"},
        {"Henry Draper", "HD 184406"},
        {"Hipparcos Number", "HIP 96229"},
        {"Fundamental Katalog 5th Edition", "FK5 1511"},
        {"Geneva Identification System", "GEN# +1.00184406"},
        {"Smithsonian Astrophysical Observation", "SAO 124799"},
        {"Wilson Evans Batten Catalogue", "WEB 16866"},
    },
    visualMagnitude: 4.45,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.52178228),
        dec: Angle.Degrees(+07.37931918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60772",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8556 A"},
        {"Henry Draper", "HD 108423"},
        {"Hipparcos Number", "HIP 60772"},
        {"Geneva Identification System", "GEN# +1.00108423"},
        {"Smithsonian Astrophysical Observation", "SAO 119406"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.85381330),
        dec: Angle.Degrees(+07.38312639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39721"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.78788288),
        dec: Angle.Degrees(+07.38372353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123712"},
        {"Hipparcos Number", "HIP 69140"},
        {"Smithsonian Astrophysical Observation", "SAO 120311"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.29678658),
        dec: Angle.Degrees(+07.38497656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48380",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48380"},
        {"Smithsonian Astrophysical Observation", "SAO 117952"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.93897042),
        dec: Angle.Degrees(+07.38605086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190609"},
        {"Hipparcos Number", "HIP 98965"},
        {"Geneva Identification System", "GEN# +1.00190609"},
        {"Smithsonian Astrophysical Observation", "SAO 125431"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.39099335),
        dec: Angle.Degrees(+07.38616757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17030"},
        {"Hipparcos Number", "HIP 12771"},
        {"Geneva Identification System", "GEN# +1.00017030"},
        {"Smithsonian Astrophysical Observation", "SAO 110715"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.03852254),
        dec: Angle.Degrees(+07.38714020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26259",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4184 AB"},
        {"Henry Draper", "HD 36951"},
        {"Hipparcos Number", "HIP 26259"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.88244563),
        dec: Angle.Degrees(+07.38850451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94765"},
        {"Hipparcos Number", "HIP 53486"},
        {"Geneva Identification System", "GEN# +1.00094765"},
        {"Smithsonian Astrophysical Observation", "SAO 118578"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.12895968),
        dec: Angle.Degrees(+07.38866209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -258.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69314"},
        {"Hipparcos Number", "HIP 40541"},
        {"Geneva Identification System", "GEN# +1.00069314"},
        {"Smithsonian Astrophysical Observation", "SAO 116573"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.17689381),
        dec: Angle.Degrees(+07.38969137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42597"},
        {"Hipparcos Number", "HIP 29429"},
        {"Celescope Catalog", "CEL 1118"},
        {"Geneva Identification System", "GEN# +1.00042597"},
        {"Smithsonian Astrophysical Observation", "SAO 113578"},
        {"Wilson Evans Batten Catalogue", "WEB 5783"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.99469397),
        dec: Angle.Degrees(+07.39132637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9658"},
        {"Hipparcos Number", "HIP 7368"},
        {"Smithsonian Astrophysical Observation", "SAO 109991"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.72261051),
        dec: Angle.Degrees(+07.39138121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15423"},
        {"Smithsonian Astrophysical Observation", "SAO 111114"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.69250886),
        dec: Angle.Degrees(+07.39326248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21159"},
        {"Hipparcos Number", "HIP 15923"},
        {"Smithsonian Astrophysical Observation", "SAO 111177"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.27852430),
        dec: Angle.Degrees(+07.39352174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56812"},
        {"Smithsonian Astrophysical Observation", "SAO 118969"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.69463249),
        dec: Angle.Degrees(+07.39570632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87423",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10846"},
        {"Henry Draper", "HD 162670"},
        {"Hipparcos Number", "HIP 87423"},
        {"Geneva Identification System", "GEN# +1.00162670J"},
        {"Smithsonian Astrophysical Observation", "SAO 122845"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.98269121),
        dec: Angle.Degrees(+07.39653973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61955"},
        {"Geneva Identification System", "GEN# +0.00802631"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.45911425),
        dec: Angle.Degrees(+07.39711821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48144"},
        {"Hipparcos Number", "HIP 32094"},
        {"Geneva Identification System", "GEN# +1.00048144"},
        {"Smithsonian Astrophysical Observation", "SAO 114299"},
        {"Wilson Evans Batten Catalogue", "WEB 6480"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.57140294),
        dec: Angle.Degrees(+07.39784444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104830"},
        {"Hipparcos Number", "HIP 58864"},
        {"Smithsonian Astrophysical Observation", "SAO 119199"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.07680578),
        dec: Angle.Degrees(+07.39911684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135025"},
        {"Hipparcos Number", "HIP 74445"},
        {"Geneva Identification System", "GEN# +1.00135025"},
        {"Smithsonian Astrophysical Observation", "SAO 120895"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.20426229),
        dec: Angle.Degrees(+07.39969626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65558"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.61060628),
        dec: Angle.Degrees(+07.40001234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94771",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12258 AB"},
        {"Henry Draper", "HD 180640"},
        {"Hipparcos Number", "HIP 94771"},
        {"Smithsonian Astrophysical Observation", "SAO 124462"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.25238801),
        dec: Angle.Degrees(+07.40045436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175373"},
        {"Hipparcos Number", "HIP 92830"},
        {"Smithsonian Astrophysical Observation", "SAO 124041"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.71590787),
        dec: Angle.Degrees(+07.40087590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201349"},
        {"Hipparcos Number", "HIP 104388"},
        {"Smithsonian Astrophysical Observation", "SAO 126573"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.21401009),
        dec: Angle.Degrees(+07.40146159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246637"},
        {"Hipparcos Number", "HIP 26864"},
        {"Cincinnati Publication", "Ci 20 345"},
        {"Geneva Identification System", "GEN# +9.80099024"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.55551633),
        dec: Angle.Degrees(+07.40287548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -330.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -360.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210773"},
        {"Hipparcos Number", "HIP 109641"},
        {"Smithsonian Astrophysical Observation", "SAO 127370"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.15927238),
        dec: Angle.Degrees(+07.40322849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69096"},
        {"Smithsonian Astrophysical Observation", "SAO 120305"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.15393858),
        dec: Angle.Degrees(+07.40352074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31401"},
        {"Hipparcos Number", "HIP 22916"},
        {"Smithsonian Astrophysical Observation", "SAO 112216"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.97480994),
        dec: Angle.Degrees(+07.40420590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114607"},
        {"Hipparcos Number", "HIP 64367"},
        {"Smithsonian Astrophysical Observation", "SAO 119808"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.88743988),
        dec: Angle.Degrees(+07.40473155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96142",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12583 A"},
        {"Henry Draper", "HD 184152"},
        {"Hipparcos Number", "HIP 96142"},
        {"Cincinnati Publication", "Ci 18 2545"},
        {"Geneva Identification System", "GEN# +1.00184152"},
        {"Smithsonian Astrophysical Observation", "SAO 124767"},
        {"Wilson Evans Batten Catalogue", "WEB 16842"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.22580041),
        dec: Angle.Degrees(+07.40525955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -333.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104829"},
        {"Hipparcos Number", "HIP 58862"},
        {"Smithsonian Astrophysical Observation", "SAO 119197"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.07279412),
        dec: Angle.Degrees(+07.40567328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27989",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Betelgeuse"},
        {"Aitken", "ADS 4506 AP"},
        {"Henry Draper", "HD 39801"},
        {"Hipparcos Number", "HIP 27989"},
        {"Fundamental Katalog 5th Edition", "FK5 224"},
        {"Geneva Identification System", "GEN# +1.00039801J"},
        {"Smithsonian Astrophysical Observation", "SAO 113271"},
        {"Wilson Evans Batten Catalogue", "WEB 5485"},
    },
    visualMagnitude: 0.45,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.79287161),
        dec: Angle.Degrees(+07.40703634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71670"},
        {"Smithsonian Astrophysical Observation", "SAO 120590"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.89623081),
        dec: Angle.Degrees(+07.40743099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100388"},
        {"Hipparcos Number", "HIP 56355"},
        {"Smithsonian Astrophysical Observation", "SAO 118916"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.28101492),
        dec: Angle.Degrees(+07.41099869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5504"},
        {"Hipparcos Number", "HIP 4445"},
        {"Smithsonian Astrophysical Observation", "SAO 109546"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.22407234),
        dec: Angle.Degrees(+07.41163329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139135"},
        {"Hipparcos Number", "HIP 76404"},
        {"Smithsonian Astrophysical Observation", "SAO 121087"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.06384501),
        dec: Angle.Degrees(+07.41270275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26861"},
        {"Hipparcos Number", "HIP 19825"},
        {"Geneva Identification System", "GEN# +1.00026861"},
        {"Smithsonian Astrophysical Observation", "SAO 111689"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.76277204),
        dec: Angle.Degrees(+07.41432084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117466"},
        {"Hipparcos Number", "HIP 65887"},
        {"Smithsonian Astrophysical Observation", "SAO 119968"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.59418196),
        dec: Angle.Degrees(+07.41513114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76909"},
        {"Hipparcos Number", "HIP 44137"},
        {"Geneva Identification System", "GEN# +1.00076909"},
        {"Smithsonian Astrophysical Observation", "SAO 117323"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.84301433),
        dec: Angle.Degrees(+07.41531386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111276",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16030 B"},
        {"Henry Draper", "HD 213609"},
        {"Hipparcos Number", "HIP 111276"},
        {"Smithsonian Astrophysical Observation", "SAO 127586"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.14453938),
        dec: Angle.Degrees(+07.41566758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141071"},
        {"Hipparcos Number", "HIP 77292"},
        {"Smithsonian Astrophysical Observation", "SAO 121189"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.70962620),
        dec: Angle.Degrees(+07.41810460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111273",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16030 A"},
        {"Hipparcos Number", "HIP 111273"},
        {"Smithsonian Astrophysical Observation", "SAO 127585"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.14143082),
        dec: Angle.Degrees(+07.41821597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8357"},
        {"Hipparcos Number", "HIP 6454"},
        {"Fundamental Katalog 5th Edition", "FK5 4126"},
        {"Geneva Identification System", "GEN# +1.00008357"},
        {"Smithsonian Astrophysical Observation", "SAO 109841"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.73625646),
        dec: Angle.Degrees(+07.41869880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 230.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139458"},
        {"Hipparcos Number", "HIP 76553"},
        {"Geneva Identification System", "GEN# +1.00139458"},
        {"Smithsonian Astrophysical Observation", "SAO 121101"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.51589600),
        dec: Angle.Degrees(+07.42226270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60206"},
        {"Hipparcos Number", "HIP 36767"},
        {"Smithsonian Astrophysical Observation", "SAO 115628"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.42846579),
        dec: Angle.Degrees(+07.42343727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32304"},
        {"Hipparcos Number", "HIP 23457"},
        {"Geneva Identification System", "GEN# +1.00032304"},
        {"Smithsonian Astrophysical Observation", "SAO 112350"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.63119692),
        dec: Angle.Degrees(+07.42407173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119826"},
        {"Hipparcos Number", "HIP 67127"},
        {"Smithsonian Astrophysical Observation", "SAO 120097"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.37156545),
        dec: Angle.Degrees(+07.42505316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92293"},
        {"Hipparcos Number", "HIP 52164"},
        {"Smithsonian Astrophysical Observation", "SAO 118416"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.86262242),
        dec: Angle.Degrees(+07.42749233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246981"},
        {"Hipparcos Number", "HIP 27034"},
        {"Smithsonian Astrophysical Observation", "SAO 113087"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.00931782),
        dec: Angle.Degrees(+07.42808293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153798"},
        {"Hipparcos Number", "HIP 83290"},
        {"Smithsonian Astrophysical Observation", "SAO 122008"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.32503151),
        dec: Angle.Degrees(+07.42861271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7918"},
        {"Hipparcos Number", "HIP 6154"},
        {"Geneva Identification System", "GEN# +1.00007918"},
        {"Smithsonian Astrophysical Observation", "SAO 109802"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.73932781),
        dec: Angle.Degrees(+07.43041482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201219"},
        {"Hipparcos Number", "HIP 104318"},
        {"Geneva Identification System", "GEN# +1.00201219"},
        {"Smithsonian Astrophysical Observation", "SAO 126560"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.98503793),
        dec: Angle.Degrees(+07.43297030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 191.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114359"},
        {"Hipparcos Number", "HIP 64240"},
        {"Geneva Identification System", "GEN# +1.00114359"},
        {"Smithsonian Astrophysical Observation", "SAO 119797"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.48856583),
        dec: Angle.Degrees(+07.43666320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171145"},
        {"Hipparcos Number", "HIP 90924"},
        {"Smithsonian Astrophysical Observation", "SAO 123623"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.20864041),
        dec: Angle.Degrees(+07.43718641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50907"},
        {"Hipparcos Number", "HIP 33295"},
        {"Smithsonian Astrophysical Observation", "SAO 114625"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.88865024),
        dec: Angle.Degrees(+07.43726831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8777"},
        {"Hipparcos Number", "HIP 6731"},
        {"Smithsonian Astrophysical Observation", "SAO 109893"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.67190979),
        dec: Angle.Degrees(+07.43730668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63797"},
        {"Hipparcos Number", "HIP 38322"},
        {"Smithsonian Astrophysical Observation", "SAO 116021"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.76081772),
        dec: Angle.Degrees(+07.43801738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42672"},
        {"Geneva Identification System", "GEN# +6.20058036"},
        {"Wilson Evans Batten Catalogue", "WEB 8241"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.45849528),
        dec: Angle.Degrees(+07.43869136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29061"},
        {"Hipparcos Number", "HIP 21346"},
        {"Smithsonian Astrophysical Observation", "SAO 111904"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.70705163),
        dec: Angle.Degrees(+07.43927448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99165"},
        {"Geneva Identification System", "GEN# +9.80023026"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.98423730),
        dec: Angle.Degrees(+07.44197657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -307.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -354.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61419",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8601 AB"},
        {"Henry Draper", "HD 109499"},
        {"Hipparcos Number", "HIP 61419"},
        {"Smithsonian Astrophysical Observation", "SAO 119484"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.78285266),
        dec: Angle.Degrees(+07.44294268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43584"},
        {"Hipparcos Number", "HIP 29868"},
        {"Smithsonian Astrophysical Observation", "SAO 113684"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.33594133),
        dec: Angle.Degrees(+07.44364106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44869"},
        {"Smithsonian Astrophysical Observation", "SAO 117451"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.14205484),
        dec: Angle.Degrees(+07.44418536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192367"},
        {"Hipparcos Number", "HIP 99743"},
        {"Geneva Identification System", "GEN# +1.00192367"},
        {"Smithsonian Astrophysical Observation", "SAO 125603"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.56998428),
        dec: Angle.Degrees(+07.44456331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20546"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.03901614),
        dec: Angle.Degrees(+07.44628645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214492"},
        {"Hipparcos Number", "HIP 111758"},
        {"Geneva Identification System", "GEN# +1.00214492"},
        {"Smithsonian Astrophysical Observation", "SAO 127649"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.58983074),
        dec: Angle.Degrees(+07.44739889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73176"},
        {"Hipparcos Number", "HIP 42278"},
        {"Geneva Identification System", "GEN# +1.00073176"},
        {"Smithsonian Astrophysical Observation", "SAO 116955"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.30410277),
        dec: Angle.Degrees(+07.44742778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209114"},
        {"Hipparcos Number", "HIP 108678"},
        {"Smithsonian Astrophysical Observation", "SAO 127233"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.23394218),
        dec: Angle.Degrees(+07.44803642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28649"},
        {"Hipparcos Number", "HIP 21102"},
        {"Geneva Identification System", "GEN# +1.00028649"},
        {"Smithsonian Astrophysical Observation", "SAO 111868"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.81768335),
        dec: Angle.Degrees(+07.45265248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16560"},
    },
    visualMagnitude: 11.17,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.30545225),
        dec: Angle.Degrees(+07.45303427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116912"},
        {"Hipparcos Number", "HIP 65580"},
        {"Smithsonian Astrophysical Observation", "SAO 119927"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.67575064),
        dec: Angle.Degrees(+07.45324963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223706"},
        {"Hipparcos Number", "HIP 117677"},
        {"Smithsonian Astrophysical Observation", "SAO 128426"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.97577746),
        dec: Angle.Degrees(+07.45561845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84448"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.97490968),
        dec: Angle.Degrees(+07.45576556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174487"},
        {"Hipparcos Number", "HIP 92450"},
        {"Geneva Identification System", "GEN# +1.00174487"},
        {"Smithsonian Astrophysical Observation", "SAO 123962"},
        {"Wilson Evans Batten Catalogue", "WEB 15972"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.60695464),
        dec: Angle.Degrees(+07.45834283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147887"},
        {"Hipparcos Number", "HIP 80352"},
        {"Geneva Identification System", "GEN# +1.00147887"},
        {"Smithsonian Astrophysical Observation", "SAO 121569"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.04712168),
        dec: Angle.Degrees(+07.45942407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187897"},
        {"Hipparcos Number", "HIP 97779"},
        {"Geneva Identification System", "GEN# +1.00187897"},
        {"Smithsonian Astrophysical Observation", "SAO 125154"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.03878378),
        dec: Angle.Degrees(+07.45988046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19573"},
        {"Hipparcos Number", "HIP 14640"},
        {"Geneva Identification System", "GEN# +1.00019573"},
        {"Smithsonian Astrophysical Observation", "SAO 111006"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.29388385),
        dec: Angle.Degrees(+07.46041638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224329"},
        {"Hipparcos Number", "HIP 118063"},
        {"Smithsonian Astrophysical Observation", "SAO 128488"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.25439425),
        dec: Angle.Degrees(+07.46059096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53135",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7955 A"},
        {"Henry Draper", "HD 94164"},
        {"Hipparcos Number", "HIP 53135"},
        {"Geneva Identification System", "GEN# +1.00094164A"},
        {"Smithsonian Astrophysical Observation", "SAO 118548"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.04421479),
        dec: Angle.Degrees(+07.46094176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32297"},
        {"Hipparcos Number", "HIP 23451"},
        {"Smithsonian Astrophysical Observation", "SAO 112345"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.61430277),
        dec: Angle.Degrees(+07.46107926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76105"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.14941525),
        dec: Angle.Degrees(+07.46192257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53133",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7955 B"},
        {"Hipparcos Number", "HIP 53133"},
        {"Geneva Identification System", "GEN# +1.00094164B"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.04148872),
        dec: Angle.Degrees(+07.46286403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121860"},
        {"Hipparcos Number", "HIP 68228"},
        {"Smithsonian Astrophysical Observation", "SAO 120197"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.50716599),
        dec: Angle.Degrees(+07.46333409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145568"},
        {"Hipparcos Number", "HIP 79326"},
        {"Smithsonian Astrophysical Observation", "SAO 121412"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.84607084),
        dec: Angle.Degrees(+07.46569965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21993"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.90264263),
        dec: Angle.Degrees(+07.46644297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62072"},
        {"Hipparcos Number", "HIP 37558"},
        {"Smithsonian Astrophysical Observation", "SAO 115825"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.62784184),
        dec: Angle.Degrees(+07.46880832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54079"},
        {"Hipparcos Number", "HIP 34387"},
        {"Fundamental Katalog 5th Edition", "FK5 1185"},
        {"Geneva Identification System", "GEN# +1.00054079"},
        {"Smithsonian Astrophysical Observation", "SAO 114947"},
        {"Wilson Evans Batten Catalogue", "WEB 6890"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.95618723),
        dec: Angle.Degrees(+07.47129491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16060"},
        {"Hipparcos Number", "HIP 12022"},
        {"Geneva Identification System", "GEN# +1.00016060"},
        {"Smithsonian Astrophysical Observation", "SAO 110625"},
        {"Wilson Evans Batten Catalogue", "WEB 2477"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.76724805),
        dec: Angle.Degrees(+07.47129568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113001"},
    },
    visualMagnitude: 11.35,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.27483439),
        dec: Angle.Degrees(+07.47216685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194388"},
        {"Hipparcos Number", "HIP 100712"},
        {"Geneva Identification System", "GEN# +1.00194388"},
        {"Smithsonian Astrophysical Observation", "SAO 125780"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.26688454),
        dec: Angle.Degrees(+07.47330633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119517"},
        {"Hipparcos Number", "HIP 66983"},
        {"Smithsonian Astrophysical Observation", "SAO 120088"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.91679360),
        dec: Angle.Degrees(+07.48040470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156859"},
        {"Hipparcos Number", "HIP 84770"},
        {"Smithsonian Astrophysical Observation", "SAO 122278"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.90433393),
        dec: Angle.Degrees(+07.48093843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39141"},
        {"Hipparcos Number", "HIP 27619"},
        {"Smithsonian Astrophysical Observation", "SAO 113201"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.71942440),
        dec: Angle.Degrees(+07.48163903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121534"},
        {"Hipparcos Number", "HIP 68040"},
        {"Geneva Identification System", "GEN# +1.00121534"},
        {"Smithsonian Astrophysical Observation", "SAO 120178"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.97417219),
        dec: Angle.Degrees(+07.48299431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38505"},
        {"Smithsonian Astrophysical Observation", "SAO 116072"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.27382151),
        dec: Angle.Degrees(+07.48345879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259295"},
        {"Hipparcos Number", "HIP 31185"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.15102274),
        dec: Angle.Degrees(+07.48410216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78301"},
        {"Hipparcos Number", "HIP 44780"},
        {"Geneva Identification System", "GEN# +1.00078301"},
        {"Smithsonian Astrophysical Observation", "SAO 117439"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.90630938),
        dec: Angle.Degrees(+07.48504250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141551"},
        {"Hipparcos Number", "HIP 77499"},
        {"Smithsonian Astrophysical Observation", "SAO 121208"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.37094329),
        dec: Angle.Degrees(+07.48610529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65897",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8926 AB"},
        {"Henry Draper", "HD 117478"},
        {"Hipparcos Number", "HIP 65897"},
        {"Geneva Identification System", "GEN# +1.00117478J"},
        {"Smithsonian Astrophysical Observation", "SAO 119970"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.62342798),
        dec: Angle.Degrees(+07.48612746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220290"},
        {"Hipparcos Number", "HIP 115396"},
        {"Geneva Identification System", "GEN# +1.00220290"},
        {"Smithsonian Astrophysical Observation", "SAO 128147"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.63755396),
        dec: Angle.Degrees(+07.48728160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30386"},
        {"Smithsonian Astrophysical Observation", "SAO 113800"},
    },
    visualMagnitude: 9.91,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.84341232),
        dec: Angle.Degrees(+07.48753484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173347"},
        {"Hipparcos Number", "HIP 91944"},
        {"Smithsonian Astrophysical Observation", "SAO 123877"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.13321777),
        dec: Angle.Degrees(+07.48774693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184013"},
        {"Hipparcos Number", "HIP 96071"},
        {"Smithsonian Astrophysical Observation", "SAO 124742"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.00283757),
        dec: Angle.Degrees(+07.48791631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180320"},
        {"Hipparcos Number", "HIP 94664"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.94995257),
        dec: Angle.Degrees(+07.48814338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70305",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9245 AB"},
        {"Hipparcos Number", "HIP 70305"},
        {"Smithsonian Astrophysical Observation", "SAO 120423"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.77289897),
        dec: Angle.Degrees(+07.48911603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7997"},
        {"Hipparcos Number", "HIP 6205"},
        {"Smithsonian Astrophysical Observation", "SAO 109808"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.88723279),
        dec: Angle.Degrees(+07.49076445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115184"},
        {"Hipparcos Number", "HIP 64675"},
        {"Smithsonian Astrophysical Observation", "SAO 119832"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.84044000),
        dec: Angle.Degrees(+07.49259194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210266"},
        {"Hipparcos Number", "HIP 109347"},
        {"Geneva Identification System", "GEN# +1.00210266"},
        {"Smithsonian Astrophysical Observation", "SAO 127328"},
        {"Wilson Evans Batten Catalogue", "WEB 19647"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.28240576),
        dec: Angle.Degrees(+07.49268584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57729"},
        {"Hipparcos Number", "HIP 35776"},
        {"Smithsonian Astrophysical Observation", "SAO 115358"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.70143355),
        dec: Angle.Degrees(+07.49447065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10500"},
        {"Cincinnati Publication", "Ci 20 160"},
    },
    visualMagnitude: 11.88,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.84048981),
        dec: Angle.Degrees(+07.49518726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 399.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -408.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45706"},
        {"Hipparcos Number", "HIP 30919"},
        {"Geneva Identification System", "GEN# +1.00045706"},
        {"Smithsonian Astrophysical Observation", "SAO 113941"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.34325848),
        dec: Angle.Degrees(+07.49851047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84221"},
        {"Hipparcos Number", "HIP 47733"},
        {"Smithsonian Astrophysical Observation", "SAO 117875"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.95391843),
        dec: Angle.Degrees(+07.49863586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190153"},
        {"Hipparcos Number", "HIP 98744"},
        {"Smithsonian Astrophysical Observation", "SAO 125386"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.84164015),
        dec: Angle.Degrees(+07.49894474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105184"},
        {"Hipparcos Number", "HIP 59057"},
        {"Smithsonian Astrophysical Observation", "SAO 119220"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.66452632),
        dec: Angle.Degrees(+07.49924259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -204.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44699"},
        {"Hipparcos Number", "HIP 30392"},
        {"Smithsonian Astrophysical Observation", "SAO 113802"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.85934470),
        dec: Angle.Degrees(+07.49974650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6164"},
        {"Hipparcos Number", "HIP 4891"},
        {"Geneva Identification System", "GEN# +1.00006164"},
        {"Renson", "Renson 1580"},
        {"Smithsonian Astrophysical Observation", "SAO 109626"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.70566756),
        dec: Angle.Degrees(+07.50077913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157896"},
        {"Hipparcos Number", "HIP 85287"},
        {"Geneva Identification System", "GEN# +1.00157896"},
        {"Smithsonian Astrophysical Observation", "SAO 122372"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.41424115),
        dec: Angle.Degrees(+07.50150878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163931"},
        {"Hipparcos Number", "HIP 87989"},
        {"Smithsonian Astrophysical Observation", "SAO 122973"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.60183500),
        dec: Angle.Degrees(+07.50346042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12182"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.23807397),
        dec: Angle.Degrees(+07.50471543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200931"},
        {"Hipparcos Number", "HIP 104164"},
        {"Geneva Identification System", "GEN# +1.00200931"},
        {"Smithsonian Astrophysical Observation", "SAO 126542"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.57377253),
        dec: Angle.Degrees(+07.50694769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102745"},
        {"Hipparcos Number", "HIP 57687"},
        {"Smithsonian Astrophysical Observation", "SAO 119071"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.46515236),
        dec: Angle.Degrees(+07.50756607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152483"},
        {"Hipparcos Number", "HIP 82614"},
        {"Smithsonian Astrophysical Observation", "SAO 121925"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.33368531),
        dec: Angle.Degrees(+07.50995968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92670"},
        {"Hipparcos Number", "HIP 52360"},
        {"Smithsonian Astrophysical Observation", "SAO 118438"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.52073560),
        dec: Angle.Degrees(+07.51034501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78535"},
        {"Hipparcos Number", "HIP 44916"},
        {"Smithsonian Astrophysical Observation", "SAO 117455"},
        {"Wilson Evans Batten Catalogue", "WEB 8580"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.25787496),
        dec: Angle.Degrees(+07.51322161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42089"},
        {"Hipparcos Number", "HIP 29166"},
        {"Geneva Identification System", "GEN# +1.00042089"},
        {"Smithsonian Astrophysical Observation", "SAO 113512"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.28020526),
        dec: Angle.Degrees(+07.51353256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114130"},
        {"Smithsonian Astrophysical Observation", "SAO 127974"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.71917375),
        dec: Angle.Degrees(+07.51391068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93169"},
        {"Hipparcos Number", "HIP 52616"},
        {"Smithsonian Astrophysical Observation", "SAO 118479"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.39061275),
        dec: Angle.Degrees(+07.51431761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202586"},
        {"Hipparcos Number", "HIP 105049"},
        {"Geneva Identification System", "GEN# +1.00202586"},
        {"Smithsonian Astrophysical Observation", "SAO 126673"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.16687836),
        dec: Angle.Degrees(+07.51478438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199942"},
        {"Hipparcos Number", "HIP 103652"},
        {"Geneva Identification System", "GEN# +1.00199942J"},
        {"Smithsonian Astrophysical Observation", "SAO 126447"},
        {"Wilson Evans Batten Catalogue", "WEB 18864"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.01647457),
        dec: Angle.Degrees(+07.51617986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159028"},
        {"Hipparcos Number", "HIP 85813"},
        {"Smithsonian Astrophysical Observation", "SAO 122482"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.01684549),
        dec: Angle.Degrees(+07.51627174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179892"},
        {"Hipparcos Number", "HIP 94499"},
        {"Geneva Identification System", "GEN# +1.00179892"},
        {"Renson", "Renson 49920"},
        {"Smithsonian Astrophysical Observation", "SAO 124417"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.49919239),
        dec: Angle.Degrees(+07.51722598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210751"},
        {"Hipparcos Number", "HIP 109623"},
        {"Smithsonian Astrophysical Observation", "SAO 127368"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.10683683),
        dec: Angle.Degrees(+07.51735561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223652"},
        {"Hipparcos Number", "HIP 117636"},
        {"Smithsonian Astrophysical Observation", "SAO 128423"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.85894976),
        dec: Angle.Degrees(+07.51871821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150921"},
        {"Hipparcos Number", "HIP 81909"},
        {"Smithsonian Astrophysical Observation", "SAO 121820"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.95980582),
        dec: Angle.Degrees(+07.51930446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55988"},
        {"Cincinnati Publication", "Ci 20 641"},
        {"Cincinnati Publication 2", "Ci 18 1412"},
        {"Geneva Identification System", "GEN# +9.80010025"},
        {"Geneva Identification System 2", "GEN# +6.20030131"},
        {"Wilson Evans Batten Catalogue", "WEB 10054"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.11627990),
        dec: Angle.Degrees(+07.52024461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -272.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1218.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89291"},
        {"Hipparcos Number", "HIP 50462"},
        {"Smithsonian Astrophysical Observation", "SAO 118210"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.54703354),
        dec: Angle.Degrees(+07.52043680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188913"},
        {"Hipparcos Number", "HIP 98199"},
        {"Smithsonian Astrophysical Observation", "SAO 125273"},
    },
    visualMagnitude: 8.48,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.32038488),
        dec: Angle.Degrees(+07.52064930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78726"},
        {"Hipparcos Number", "HIP 45010"},
        {"Smithsonian Astrophysical Observation", "SAO 117466"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.51384978),
        dec: Angle.Degrees(+07.52274308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182196"},
        {"Hipparcos Number", "HIP 95298"},
        {"Smithsonian Astrophysical Observation", "SAO 124571"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.81319176),
        dec: Angle.Degrees(+07.52595909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6804"},
        {"Hipparcos Number", "HIP 5382"},
        {"Smithsonian Astrophysical Observation", "SAO 109699"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.21402135),
        dec: Angle.Degrees(+07.52606700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18616"},
        {"Hipparcos Number", "HIP 13967"},
        {"Geneva Identification System", "GEN# +1.00018616"},
        {"Smithsonian Astrophysical Observation", "SAO 110891"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.96230394),
        dec: Angle.Degrees(+07.52668728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57793"},
        {"Hipparcos Number", "HIP 35808"},
        {"Smithsonian Astrophysical Observation", "SAO 115364"},
    },
    visualMagnitude: 9.24,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.77808302),
        dec: Angle.Degrees(+07.52696319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139358"},
        {"Hipparcos Number", "HIP 76502"},
        {"Smithsonian Astrophysical Observation", "SAO 121095"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.36817651),
        dec: Angle.Degrees(+07.52788596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91291",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11506 A"},
        {"Henry Draper", "HD 171951"},
        {"Hipparcos Number", "HIP 91291"},
        {"Smithsonian Astrophysical Observation", "SAO 123709"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.31355331),
        dec: Angle.Degrees(+07.52870479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206689"},
        {"Hipparcos Number", "HIP 107271"},
        {"Smithsonian Astrophysical Observation", "SAO 127021"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.91577250),
        dec: Angle.Degrees(+07.52879415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200195"},
        {"Hipparcos Number", "HIP 103781"},
        {"Smithsonian Astrophysical Observation", "SAO 126477"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.45715327),
        dec: Angle.Degrees(+07.52987735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106496"},
        {"Hipparcos Number", "HIP 59740"},
        {"Smithsonian Astrophysical Observation", "SAO 119284"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.76678077),
        dec: Angle.Degrees(+07.53047041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91288",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11506 B"},
        {"Hipparcos Number", "HIP 91288"},
        {"Geneva Identification System", "GEN# +0.00703773"},
        {"Smithsonian Astrophysical Observation", "SAO 123706"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.30650657),
        dec: Angle.Degrees(+07.53230431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42786"},
        {"Hipparcos Number", "HIP 29512"},
        {"Smithsonian Astrophysical Observation", "SAO 113593"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.25802546),
        dec: Angle.Degrees(+07.53434669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44236"},
        {"Hipparcos Number", "HIP 30191"},
        {"Smithsonian Astrophysical Observation", "SAO 113748"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.27552226),
        dec: Angle.Degrees(+07.53557115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106751"},
        {"Smithsonian Astrophysical Observation", "SAO 126932"},
    },
    visualMagnitude: 9.88,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.36199916),
        dec: Angle.Degrees(+07.53699571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75356"},
        {"Hipparcos Number", "HIP 43349"},
        {"Smithsonian Astrophysical Observation", "SAO 117171"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.45295304),
        dec: Angle.Degrees(+07.53827262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71257"},
        {"Fundamental Katalog 5th Edition", "FK5 5292"},
        {"Smithsonian Astrophysical Observation", "SAO 120539"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.58777810),
        dec: Angle.Degrees(+07.53917775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37320"},
        {"Hipparcos Number", "HIP 26487"},
        {"Celescope Catalog", "CEL 872"},
        {"Geneva Identification System", "GEN# +1.00037320"},
        {"Smithsonian Astrophysical Observation", "SAO 112979"},
        {"Wilson Evans Batten Catalogue", "WEB 5222"},
    },
    visualMagnitude: 5.87,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.50463493),
        dec: Angle.Degrees(+07.54145541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121268"},
        {"Hipparcos Number", "HIP 67898"},
        {"Geneva Identification System", "GEN# +1.00121268"},
        {"Smithsonian Astrophysical Observation", "SAO 120162"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.59572750),
        dec: Angle.Degrees(+07.54293238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122744"},
        {"Hipparcos Number", "HIP 68687"},
        {"Geneva Identification System", "GEN# +1.00122744"},
        {"Smithsonian Astrophysical Observation", "SAO 120261"},
        {"Wilson Evans Batten Catalogue", "WEB 12023"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.90328677),
        dec: Angle.Degrees(+07.54621276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58372",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58372"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.53910528),
        dec: Angle.Degrees(+07.54634405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5503"},
        {"Hipparcos Number", "HIP 4447"},
        {"Smithsonian Astrophysical Observation", "SAO 109547"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.22975493),
        dec: Angle.Degrees(+07.54868546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169006"},
        {"Hipparcos Number", "HIP 90036"},
        {"Geneva Identification System", "GEN# +1.00169006"},
        {"Smithsonian Astrophysical Observation", "SAO 123399"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.57535071),
        dec: Angle.Degrees(+07.54905804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62540"},
        {"Geneva Identification System", "GEN# +0.00802642"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.22460046),
        dec: Angle.Degrees(+07.54924275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17796"},
        {"Hipparcos Number", "HIP 13332"},
        {"Geneva Identification System", "GEN# +1.00017796"},
        {"Smithsonian Astrophysical Observation", "SAO 110794"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.89827763),
        dec: Angle.Degrees(+07.54999454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184982"},
        {"Hipparcos Number", "HIP 96469"},
        {"Geneva Identification System", "GEN# +1.00184982"},
        {"Smithsonian Astrophysical Observation", "SAO 124844"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.18568008),
        dec: Angle.Degrees(+07.55097977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38779"},
        {"Hipparcos Number", "HIP 27431"},
        {"Geneva Identification System", "GEN# +1.00038779"},
        {"Smithsonian Astrophysical Observation", "SAO 113160"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.12841696),
        dec: Angle.Degrees(+07.55133697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23062"},
        {"Hipparcos Number", "HIP 17312"},
        {"Smithsonian Astrophysical Observation", "SAO 111362"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.58596338),
        dec: Angle.Degrees(+07.55217205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197952"},
        {"Hipparcos Number", "HIP 102545"},
        {"Smithsonian Astrophysical Observation", "SAO 126201"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.70507853),
        dec: Angle.Degrees(+07.55296572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108286"},
        {"Smithsonian Astrophysical Observation", "SAO 127172"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.07752847),
        dec: Angle.Degrees(+07.55402675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113525"},
    },
    visualMagnitude: 12.45,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.88146864),
        dec: Angle.Degrees(+07.55480835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99054",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13379 B"},
        {"Henry Draper", "HD 190850"},
        {"Hipparcos Number", "HIP 99054"},
        {"Geneva Identification System", "GEN# +1.00190850"},
        {"Renson", "Renson 53073"},
        {"Smithsonian Astrophysical Observation", "SAO 125455"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.65972968),
        dec: Angle.Degrees(+07.55817165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62112",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8646 AB"},
        {"Henry Draper", "HD 110689"},
        {"Hipparcos Number", "HIP 62112"},
        {"Smithsonian Astrophysical Observation", "SAO 119557"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.94935008),
        dec: Angle.Degrees(+07.55850913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58368"},
        {"Hipparcos Number", "HIP 36042"},
        {"Smithsonian Astrophysical Observation", "SAO 115426"},
        {"Wilson Evans Batten Catalogue", "WEB 7178"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.41236187),
        dec: Angle.Degrees(+07.56084852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26962"},
        {"Hipparcos Number", "HIP 19896"},
        {"Smithsonian Astrophysical Observation", "SAO 111703"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.01605004),
        dec: Angle.Degrees(+07.56127532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32685"},
        {"Hipparcos Number", "HIP 23673"},
        {"Geneva Identification System", "GEN# +1.00032685"},
        {"Smithsonian Astrophysical Observation", "SAO 112403"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.33383009),
        dec: Angle.Degrees(+07.56250212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36808"},
        {"Hipparcos Number", "HIP 26163"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.66603464),
        dec: Angle.Degrees(+07.56351419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41325",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6805 A"},
        {"Henry Draper", "HD 71115"},
        {"Hipparcos Number", "HIP 41325"},
        {"Fundamental Katalog 5th Edition", "FK5 2655"},
        {"Geneva Identification System", "GEN# +1.00071115A"},
        {"Smithsonian Astrophysical Observation", "SAO 116752"},
        {"Wilson Evans Batten Catalogue", "WEB 7998"},
    },
    visualMagnitude: 5.13,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.47828013),
        dec: Angle.Degrees(+07.56452889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21895"},
        {"Hipparcos Number", "HIP 16464"},
        {"Geneva Identification System", "GEN# +1.00021895"},
        {"Smithsonian Astrophysical Observation", "SAO 111241"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.01689098),
        dec: Angle.Degrees(+07.56635065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185667"},
        {"Hipparcos Number", "HIP 96745"},
        {"Geneva Identification System", "GEN# +1.00185667"},
        {"Smithsonian Astrophysical Observation", "SAO 124915"},
        {"Wilson Evans Batten Catalogue", "WEB 16972"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.99690346),
        dec: Angle.Degrees(+07.56714954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93047"},
    },
    visualMagnitude: 12.86,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.30404205),
        dec: Angle.Degrees(+07.56737387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107638"},
        {"Hipparcos Number", "HIP 60322"},
        {"Smithsonian Astrophysical Observation", "SAO 119356"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.53485321),
        dec: Angle.Degrees(+07.56967477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29897"},
        {"Hipparcos Number", "HIP 21931"},
        {"Smithsonian Astrophysical Observation", "SAO 112002"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.73035066),
        dec: Angle.Degrees(+07.56983036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149347"},
        {"Hipparcos Number", "HIP 81089"},
        {"Smithsonian Astrophysical Observation", "SAO 121695"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.44377343),
        dec: Angle.Degrees(+07.57024935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18430",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2881 AB"},
        {"Henry Draper", "HD 24762"},
        {"Hipparcos Number", "HIP 18430"},
        {"Smithsonian Astrophysical Observation", "SAO 111508"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.11696238),
        dec: Angle.Degrees(+07.57131240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31385",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5211 A"},
        {"Henry Draper", "HD 46642"},
        {"Hipparcos Number", "HIP 31385"},
        {"Celescope Catalog", "CEL 1305"},
        {"Geneva Identification System", "GEN# +1.00046642"},
        {"Smithsonian Astrophysical Observation", "SAO 114085"},
        {"Wilson Evans Batten Catalogue", "WEB 6280"},
    },
    visualMagnitude: 6.44,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.69303336),
        dec: Angle.Degrees(+07.57249971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73535"},
        {"Hipparcos Number", "HIP 42439"},
        {"Smithsonian Astrophysical Observation", "SAO 116993"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.80518134),
        dec: Angle.Degrees(+07.57324482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87915"},
        {"Hipparcos Number", "HIP 49667"},
        {"Geneva Identification System", "GEN# +1.00087915"},
        {"Smithsonian Astrophysical Observation", "SAO 118127"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.08831850),
        dec: Angle.Degrees(+07.57329540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110045"},
        {"Hipparcos Number", "HIP 61754"},
        {"Smithsonian Astrophysical Observation", "SAO 119516"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.84467848),
        dec: Angle.Degrees(+07.57416226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5737",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Revati"},
        {"Aitken", "ADS 996 A"},
        {"Henry Draper", "HD 7344"},
        {"Hipparcos Number", "HIP 5737"},
        {"Fundamental Katalog 5th Edition", "FK5 1033"},
        {"Geneva Identification System", "GEN# +1.00007344A"},
        {"Smithsonian Astrophysical Observation", "SAO 109739"},
        {"Wilson Evans Batten Catalogue", "WEB 1305"},
    },
    visualMagnitude: 5.21,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.43250986),
        dec: Angle.Degrees(+07.57548895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11350"},
        {"Hipparcos Number", "HIP 8685"},
        {"Geneva Identification System", "GEN# +1.00011350"},
        {"Smithsonian Astrophysical Observation", "SAO 110180"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.93270103),
        dec: Angle.Degrees(+07.57567106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99055",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13379 A"},
        {"Henry Draper", "HD 190849"},
        {"Hipparcos Number", "HIP 99055"},
        {"Geneva Identification System", "GEN# +1.00190849"},
        {"Smithsonian Astrophysical Observation", "SAO 125456"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.66149096),
        dec: Angle.Degrees(+07.57615536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55337"},
        {"Smithsonian Astrophysical Observation", "SAO 118794"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.98486777),
        dec: Angle.Degrees(+07.57834678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5743",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 996 B"},
        {"Henry Draper", "HD 7345"},
        {"Hipparcos Number", "HIP 5743"},
        {"Geneva Identification System", "GEN# +1.00007345"},
        {"Smithsonian Astrophysical Observation", "SAO 109740"},
        {"Wilson Evans Batten Catalogue", "WEB 1306"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.43822840),
        dec: Angle.Degrees(+07.57837574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60563"},
        {"Hipparcos Number", "HIP 36922"},
        {"Smithsonian Astrophysical Observation", "SAO 115666"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.85517997),
        dec: Angle.Degrees(+07.57996972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219547"},
        {"Hipparcos Number", "HIP 114913"},
        {"Smithsonian Astrophysical Observation", "SAO 128079"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.14193441),
        dec: Angle.Degrees(+07.58038570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95848"},
        {"Hipparcos Number", "HIP 54057"},
        {"Smithsonian Astrophysical Observation", "SAO 118636"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.92209190),
        dec: Angle.Degrees(+07.58202719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198705"},
        {"Hipparcos Number", "HIP 102997"},
        {"Geneva Identification System", "GEN# +1.00198705"},
        {"Smithsonian Astrophysical Observation", "SAO 126309"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.01307461),
        dec: Angle.Degrees(+07.58247511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215638"},
        {"Hipparcos Number", "HIP 112433"},
        {"Geneva Identification System", "GEN# +1.00215638"},
        {"Smithsonian Astrophysical Observation", "SAO 127747"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.61912724),
        dec: Angle.Degrees(+07.58293515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148622"},
        {"Hipparcos Number", "HIP 80739"},
        {"Smithsonian Astrophysical Observation", "SAO 121634"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.26411558),
        dec: Angle.Degrees(+07.58405183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38562"},
        {"Hipparcos Number", "HIP 27302"},
        {"Geneva Identification System", "GEN# +1.00038562"},
        {"Smithsonian Astrophysical Observation", "SAO 113130"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.76416879),
        dec: Angle.Degrees(+07.58456809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4656"},
        {"Hipparcos Number", "HIP 3786"},
        {"Fundamental Katalog 5th Edition", "FK5 28"},
        {"Geneva Identification System", "GEN# +1.00004656"},
        {"Smithsonian Astrophysical Observation", "SAO 109474"},
        {"Wilson Evans Batten Catalogue", "WEB 672"},
    },
    visualMagnitude: 4.44,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.17039736),
        dec: Angle.Degrees(+07.58520186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22818"},
        {"Hipparcos Number", "HIP 17142"},
        {"Smithsonian Astrophysical Observation", "SAO 111338"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.06546905),
        dec: Angle.Degrees(+07.58537926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2985"},
        {"Hipparcos Number", "HIP 2609"},
        {"Smithsonian Astrophysical Observation", "SAO 109270"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.28456307),
        dec: Angle.Degrees(+07.58561940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64949"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.69807125),
        dec: Angle.Degrees(+07.58791445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186456"},
        {"Hipparcos Number", "HIP 97117"},
        {"Fundamental Katalog 5th Edition", "FK5 5743"},
        {"Geneva Identification System", "GEN# +1.00186456"},
        {"Smithsonian Astrophysical Observation", "SAO 125002"},
        {"Wilson Evans Batten Catalogue", "WEB 17047"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.06605387),
        dec: Angle.Degrees(+07.58822845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10336"},
        {"Hipparcos Number", "HIP 7863"},
        {"Smithsonian Astrophysical Observation", "SAO 110056"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.28995188),
        dec: Angle.Degrees(+07.58859005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201376"},
        {"Hipparcos Number", "HIP 104401"},
        {"Smithsonian Astrophysical Observation", "SAO 126577"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.25443573),
        dec: Angle.Degrees(+07.58905169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83983"},
        {"Hipparcos Number", "HIP 47587"},
        {"Smithsonian Astrophysical Observation", "SAO 117861"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.54182622),
        dec: Angle.Degrees(+07.59013742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220212"},
        {"Hipparcos Number", "HIP 115356"},
        {"Smithsonian Astrophysical Observation", "SAO 128141"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.48218746),
        dec: Angle.Degrees(+07.59309313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198166"},
        {"Hipparcos Number", "HIP 102674"},
        {"Smithsonian Astrophysical Observation", "SAO 126228"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.08937874),
        dec: Angle.Degrees(+07.59425729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157978"},
        {"Henry Draper 2", "HD 157979"},
        {"Hipparcos Number", "HIP 85333"},
        {"Fundamental Katalog 5th Edition", "FK5 3385"},
        {"Geneva Identification System", "GEN# +1.00157978"},
        {"Smithsonian Astrophysical Observation", "SAO 122381"},
        {"Wilson Evans Batten Catalogue", "WEB 14410"},
        {"Wilson Evans Batten Catalogue 2", "WEB 14409"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.57920731),
        dec: Angle.Degrees(+07.59566929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74682"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.93960032),
        dec: Angle.Degrees(+07.59825555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99904"},
        {"Hipparcos Number", "HIP 56079"},
        {"Geneva Identification System", "GEN# +1.00099904"},
        {"Smithsonian Astrophysical Observation", "SAO 118892"},
        {"Wilson Evans Batten Catalogue", "WEB 10070"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.41666028),
        dec: Angle.Degrees(+07.59943464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79341"},
        {"Hipparcos Number", "HIP 45282"},
        {"Fundamental Katalog 5th Edition", "FK5 4821"},
        {"Smithsonian Astrophysical Observation", "SAO 117514"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.43330994),
        dec: Angle.Degrees(+07.60247200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103153"},
        {"Hipparcos Number", "HIP 57924"},
        {"Smithsonian Astrophysical Observation", "SAO 119093"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.19666639),
        dec: Angle.Degrees(+07.60422177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108985"},
        {"Hipparcos Number", "HIP 61103"},
        {"Fundamental Katalog 5th Edition", "FK5 3002"},
        {"Geneva Identification System", "GEN# +1.00108985"},
        {"Smithsonian Astrophysical Observation", "SAO 119453"},
        {"Wilson Evans Batten Catalogue", "WEB 10878"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.83928382),
        dec: Angle.Degrees(+07.60428312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25331"},
        {"Hipparcos Number", "HIP 18810"},
        {"Smithsonian Astrophysical Observation", "SAO 111568"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.45904231),
        dec: Angle.Degrees(+07.60489521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24962"},
        {"Hipparcos Number", "HIP 18555"},
        {"Geneva Identification System", "GEN# +1.00024962"},
        {"Smithsonian Astrophysical Observation", "SAO 111529"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.56437776),
        dec: Angle.Degrees(+07.60529638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140536"},
        {"Hipparcos Number", "HIP 77047"},
        {"Geneva Identification System", "GEN# +1.00140536"},
        {"Smithsonian Astrophysical Observation", "SAO 121153"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.99538685),
        dec: Angle.Degrees(+07.60539355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31905"},
        {"Geneva Identification System", "GEN# +0.00701394"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.02326070),
        dec: Angle.Degrees(+07.60582689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8152"},
        {"Hipparcos Number", "HIP 6307"},
        {"Smithsonian Astrophysical Observation", "SAO 109822"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.26484112),
        dec: Angle.Degrees(+07.60597165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212225"},
        {"Hipparcos Number", "HIP 110463"},
        {"Smithsonian Astrophysical Observation", "SAO 127484"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.64037418),
        dec: Angle.Degrees(+07.60619432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196111"},
        {"Hipparcos Number", "HIP 101560"},
        {"Smithsonian Astrophysical Observation", "SAO 125980"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.75142016),
        dec: Angle.Degrees(+07.60834856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69995"},
        {"Hipparcos Number", "HIP 40819"},
        {"Smithsonian Astrophysical Observation", "SAO 116629"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.96845651),
        dec: Angle.Degrees(+07.60843448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94470"},
        {"Hipparcos Number", "HIP 53318"},
        {"Smithsonian Astrophysical Observation", "SAO 118568"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.58346451),
        dec: Angle.Degrees(+07.60916497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3284"},
        {"Hipparcos Number", "HIP 2833"},
        {"Fundamental Katalog 5th Edition", "FK5 4053"},
        {"Smithsonian Astrophysical Observation", "SAO 109305"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.98848584),
        dec: Angle.Degrees(+07.60916541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74943"},
        {"Hipparcos Number", "HIP 43143"},
        {"Smithsonian Astrophysical Observation", "SAO 117121"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.81354365),
        dec: Angle.Degrees(+07.60941428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119128"},
        {"Hipparcos Number", "HIP 66788"},
        {"Smithsonian Astrophysical Observation", "SAO 120067"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.32539282),
        dec: Angle.Degrees(+07.61079972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5613"},
        {"Hipparcos Number", "HIP 4526"},
        {"Smithsonian Astrophysical Observation", "SAO 109560"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.49358069),
        dec: Angle.Degrees(+07.61159662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216982"},
        {"Hipparcos Number", "HIP 113343"},
        {"Smithsonian Astrophysical Observation", "SAO 127859"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.31823661),
        dec: Angle.Degrees(+07.61229836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42561"},
        {"Hipparcos Number", "HIP 29406"},
        {"Smithsonian Astrophysical Observation", "SAO 113574"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.94855515),
        dec: Angle.Degrees(+07.61277713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186689"},
        {"Hipparcos Number", "HIP 97229"},
        {"Geneva Identification System", "GEN# +1.00186689"},
        {"Smithsonian Astrophysical Observation", "SAO 125032"},
        {"Wilson Evans Batten Catalogue", "WEB 17071"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.41631572),
        dec: Angle.Degrees(+07.61315784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129539"},
        {"Hipparcos Number", "HIP 71951"},
        {"Geneva Identification System", "GEN# +1.00129539"},
        {"Smithsonian Astrophysical Observation", "SAO 120619"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.74059046),
        dec: Angle.Degrees(+07.61364189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193539"},
        {"Hipparcos Number", "HIP 100281"},
        {"Smithsonian Astrophysical Observation", "SAO 125694"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.10703250),
        dec: Angle.Degrees(+07.61480680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185398"},
        {"Hipparcos Number", "HIP 96615"},
        {"Geneva Identification System", "GEN# +1.00185398"},
        {"Smithsonian Astrophysical Observation", "SAO 124889"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.65452431),
        dec: Angle.Degrees(+07.61499175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213144"},
        {"Hipparcos Number", "HIP 110995"},
        {"Geneva Identification System", "GEN# +1.00213144"},
        {"Smithsonian Astrophysical Observation", "SAO 127546"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.31274126),
        dec: Angle.Degrees(+07.61598004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178126"},
        {"Hipparcos Number", "HIP 93871"},
        {"Cincinnati Publication", "Ci 20 1128"},
        {"Geneva Identification System", "GEN# +1.00178126"},
        {"Smithsonian Astrophysical Observation", "SAO 124283"},
        {"Wilson Evans Batten Catalogue", "WEB 16330"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.75929861),
        dec: Angle.Degrees(+07.61772281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -322.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -759.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95399"},
        {"Hipparcos Number", "HIP 53848"},
        {"Smithsonian Astrophysical Observation", "SAO 118617"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.23539366),
        dec: Angle.Degrees(+07.61774731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44878"},
        {"Smithsonian Astrophysical Observation", "SAO 117452"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.16322964),
        dec: Angle.Degrees(+07.62034115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157997"},
        {"Hipparcos Number", "HIP 85346"},
        {"Smithsonian Astrophysical Observation", "SAO 122384"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.60305929),
        dec: Angle.Degrees(+07.62084235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42921"},
        {"Smithsonian Astrophysical Observation", "SAO 117085"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.20971397),
        dec: Angle.Degrees(+07.62149519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51693"},
        {"Hipparcos Number", "HIP 33584"},
        {"Geneva Identification System", "GEN# +1.00051693"},
        {"Smithsonian Astrophysical Observation", "SAO 114713"},
        {"Wilson Evans Batten Catalogue", "WEB 6754"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.66221582),
        dec: Angle.Degrees(+07.62235151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59931"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.39586412),
        dec: Angle.Degrees(+07.62260946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71822"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.37991541),
        dec: Angle.Degrees(+07.62282616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32650",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5469 AB"},
        {"Henry Draper", "HD 49409"},
        {"Hipparcos Number", "HIP 32650"},
        {"Geneva Identification System", "GEN# +1.00049409"},
        {"Smithsonian Astrophysical Observation", "SAO 114448"},
        {"Wilson Evans Batten Catalogue", "WEB 6583"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.16421982),
        dec: Angle.Degrees(+07.62324863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -376.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12420"},
    },
    visualMagnitude: 12.26,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.96544573),
        dec: Angle.Degrees(+07.62376838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116571",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16873 AB"},
        {"Henry Draper", "HD 222068"},
        {"Hipparcos Number", "HIP 116571"},
        {"Smithsonian Astrophysical Observation", "SAO 128291"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.34653503),
        dec: Angle.Degrees(+07.62393894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15650"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.36791379),
        dec: Angle.Degrees(+07.62455164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64754"},
        {"Smithsonian Astrophysical Observation", "SAO 119842"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.06309691),
        dec: Angle.Degrees(+07.62575605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150343"},
        {"Hipparcos Number", "HIP 81622"},
        {"Smithsonian Astrophysical Observation", "SAO 121772"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.05612552),
        dec: Angle.Degrees(+07.62599214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41079"},
        {"Hipparcos Number", "HIP 28667"},
        {"Smithsonian Astrophysical Observation", "SAO 113402"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.79168123),
        dec: Angle.Degrees(+07.62715068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73952"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.68383398),
        dec: Angle.Degrees(+07.62863979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217772"},
        {"Hipparcos Number", "HIP 113811"},
        {"Smithsonian Astrophysical Observation", "SAO 127924"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.71771756),
        dec: Angle.Degrees(+07.62982942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41088",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6778 B"},
        {"Hipparcos Number", "HIP 41088"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.74387293),
        dec: Angle.Degrees(+07.63046939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43406"},
    },
    visualMagnitude: 11.28,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.62359521),
        dec: Angle.Degrees(+07.63066502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96693"},
        {"Hipparcos Number", "HIP 54454"},
        {"Smithsonian Astrophysical Observation", "SAO 118682"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.11423757),
        dec: Angle.Degrees(+07.63067416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41090",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6778 A"},
        {"Henry Draper", "HD 70571"},
        {"Hipparcos Number", "HIP 41090"},
        {"Smithsonian Astrophysical Observation", "SAO 116696"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.74725386),
        dec: Angle.Degrees(+07.63093292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11558"},
        {"Hipparcos Number", "HIP 8836"},
        {"Smithsonian Astrophysical Observation", "SAO 110207"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.40939745),
        dec: Angle.Degrees(+07.63396214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76390"},
        {"Smithsonian Astrophysical Observation", "SAO 121085"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.03376897),
        dec: Angle.Degrees(+07.63441205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164482"},
        {"Hipparcos Number", "HIP 88241"},
        {"Smithsonian Astrophysical Observation", "SAO 123021"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.28196602),
        dec: Angle.Degrees(+07.63492578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2067"},
    },
    visualMagnitude: 11.28,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.54105925),
        dec: Angle.Degrees(+07.63511167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166498"},
        {"Hipparcos Number", "HIP 89059"},
        {"Smithsonian Astrophysical Observation", "SAO 123215"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.65633484),
        dec: Angle.Degrees(+07.63538906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169063"},
        {"Hipparcos Number", "HIP 90051"},
        {"Smithsonian Astrophysical Observation", "SAO 123405"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.63624408),
        dec: Angle.Degrees(+07.63628096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209407"},
        {"Hipparcos Number", "HIP 108850"},
        {"Geneva Identification System", "GEN# +1.00209407"},
        {"Smithsonian Astrophysical Observation", "SAO 127252"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.76686162),
        dec: Angle.Degrees(+07.63710841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40448",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6695 AB"},
        {"Henry Draper", "HD 69057"},
        {"Hipparcos Number", "HIP 40448"},
        {"Smithsonian Astrophysical Observation", "SAO 116541"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.87975854),
        dec: Angle.Degrees(+07.63720099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22426"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.38719716),
        dec: Angle.Degrees(+07.63743918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70844"},
        {"Hipparcos Number", "HIP 41200"},
        {"Smithsonian Astrophysical Observation", "SAO 116721"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.11573754),
        dec: Angle.Degrees(+07.63793148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144683"},
        {"Hipparcos Number", "HIP 78939"},
        {"Smithsonian Astrophysical Observation", "SAO 121373"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.71654726),
        dec: Angle.Degrees(+07.64137349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19521"},
        {"Hipparcos Number", "HIP 14600"},
        {"Geneva Identification System", "GEN# +1.00019521"},
        {"Smithsonian Astrophysical Observation", "SAO 111000"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.11625538),
        dec: Angle.Degrees(+07.64306802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7456",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1254 AB"},
        {"Henry Draper", "HD 9817"},
        {"Hipparcos Number", "HIP 7456"},
        {"Smithsonian Astrophysical Observation", "SAO 110001"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.01191556),
        dec: Angle.Degrees(+07.64525355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137005"},
        {"Hipparcos Number", "HIP 75328"},
        {"Geneva Identification System", "GEN# +1.00137005"},
        {"Smithsonian Astrophysical Observation", "SAO 120974"},
    },
    visualMagnitude: 9.00,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.86627818),
        dec: Angle.Degrees(+07.64560842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70596"},
        {"Smithsonian Astrophysical Observation", "SAO 120460"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.59475543),
        dec: Angle.Degrees(+07.64809619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132701"},
        {"Hipparcos Number", "HIP 73424"},
        {"Smithsonian Astrophysical Observation", "SAO 120785"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.07779956),
        dec: Angle.Degrees(+07.64829855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187057"},
        {"Hipparcos Number", "HIP 97389"},
        {"Geneva Identification System", "GEN# +1.00187057"},
        {"Smithsonian Astrophysical Observation", "SAO 125072"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.91404224),
        dec: Angle.Degrees(+07.64934355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148966"},
        {"Hipparcos Number", "HIP 80909"},
        {"Smithsonian Astrophysical Observation", "SAO 121664"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.84383369),
        dec: Angle.Degrees(+07.65056421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71262"},
        {"Hipparcos Number", "HIP 41398"},
        {"Smithsonian Astrophysical Observation", "SAO 116762"},
        {"Wilson Evans Batten Catalogue", "WEB 8008"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.68192144),
        dec: Angle.Degrees(+07.65067400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43264"},
        {"Hipparcos Number", "HIP 29719"},
        {"Celescope Catalog", "CEL 1145"},
        {"Geneva Identification System", "GEN# +1.00043264"},
        {"Smithsonian Astrophysical Observation", "SAO 113648"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.89876068),
        dec: Angle.Degrees(+07.65227210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18344"},
        {"Hipparcos Number", "HIP 13757"},
        {"Smithsonian Astrophysical Observation", "SAO 110864"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.27201979),
        dec: Angle.Degrees(+07.65346289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15304",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2451 A"},
        {"Henry Draper", "HD 20430"},
        {"Hipparcos Number", "HIP 15304"},
        {"Geneva Identification System", "GEN# +5.20250001"},
        {"Smithsonian Astrophysical Observation", "SAO 111104"},
        {"Wilson Evans Batten Catalogue", "WEB 2944"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.35953450),
        dec: Angle.Degrees(+07.65582608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144238"},
        {"Hipparcos Number", "HIP 78744"},
        {"Smithsonian Astrophysical Observation", "SAO 121353"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.13061325),
        dec: Angle.Degrees(+07.65688266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65262"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.62153836),
        dec: Angle.Degrees(+07.65700192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216419"},
        {"Hipparcos Number", "HIP 112953"},
        {"Geneva Identification System", "GEN# +1.00216419"},
        {"Smithsonian Astrophysical Observation", "SAO 127813"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.14256858),
        dec: Angle.Degrees(+07.65737479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95478",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12418 AB"},
        {"Henry Draper", "HD 182638"},
        {"Hipparcos Number", "HIP 95478"},
        {"Smithsonian Astrophysical Observation", "SAO 124602"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.32067067),
        dec: Angle.Degrees(+07.65790734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153915"},
        {"Hipparcos Number", "HIP 83341"},
        {"Smithsonian Astrophysical Observation", "SAO 122022"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.48066594),
        dec: Angle.Degrees(+07.65861810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118200"},
        {"Cincinnati Publication", "Ci 20 1465"},
        {"Geneva Identification System", "GEN# +9.80030033"},
    },
    visualMagnitude: 11.78,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.63583351),
        dec: Angle.Degrees(+07.65940573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -312.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112740"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.48265182),
        dec: Angle.Degrees(+07.66057143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74819"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.35541455),
        dec: Angle.Degrees(+07.66366689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132228"},
        {"Hipparcos Number", "HIP 73212"},
        {"Smithsonian Astrophysical Observation", "SAO 120761"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.43835851),
        dec: Angle.Degrees(+07.66395735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199255"},
        {"Hipparcos Number", "HIP 103309"},
        {"Geneva Identification System", "GEN# +1.00199255"},
        {"Smithsonian Astrophysical Observation", "SAO 126376"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.94619523),
        dec: Angle.Degrees(+07.66640388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4800"},
        {"Hipparcos Number", "HIP 3904"},
        {"Geneva Identification System", "GEN# +1.00004800"},
        {"Smithsonian Astrophysical Observation", "SAO 109488"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.51777155),
        dec: Angle.Degrees(+07.66839596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37233"},
        {"Hipparcos Number", "HIP 26418"},
        {"Geneva Identification System", "GEN# +1.00037233"},
        {"Smithsonian Astrophysical Observation", "SAO 112967"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.34013806),
        dec: Angle.Degrees(+07.66894245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133232"},
        {"Hipparcos Number", "HIP 73641"},
        {"Smithsonian Astrophysical Observation", "SAO 120811"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.78971155),
        dec: Angle.Degrees(+07.67162920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46532"},
        {"Smithsonian Astrophysical Observation", "SAO 117726"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.36059558),
        dec: Angle.Degrees(+07.67277561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110951"},
        {"Hipparcos Number", "HIP 62267"},
        {"Fundamental Katalog 5th Edition", "FK5 1328"},
        {"Geneva Identification System", "GEN# +1.00110951"},
        {"Renson", "Renson 32240"},
        {"Smithsonian Astrophysical Observation", "SAO 119574"},
        {"Wilson Evans Batten Catalogue", "WEB 11061"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.40467529),
        dec: Angle.Degrees(+07.67331477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73642"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.79026794),
        dec: Angle.Degrees(+07.67532051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121345"},
        {"Hipparcos Number", "HIP 67943"},
        {"Smithsonian Astrophysical Observation", "SAO 120168"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.70554600),
        dec: Angle.Degrees(+07.67623511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131601"},
        {"Hipparcos Number", "HIP 72933"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.59060201),
        dec: Angle.Degrees(+07.67656079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86002"},
        {"Hipparcos Number", "HIP 48699"},
        {"Smithsonian Astrophysical Observation", "SAO 117997"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.97917436),
        dec: Angle.Degrees(+07.67728173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88514"},
        {"Hipparcos Number", "HIP 50011"},
        {"Geneva Identification System", "GEN# +1.00088514"},
        {"Smithsonian Astrophysical Observation", "SAO 118162"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.15098550),
        dec: Angle.Degrees(+07.67744427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48668"},
        {"Smithsonian Astrophysical Observation", "SAO 117990"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.88695594),
        dec: Angle.Degrees(+07.67833244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81565"},
        {"Hipparcos Number", "HIP 46303"},
        {"Smithsonian Astrophysical Observation", "SAO 117694"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.64281666),
        dec: Angle.Degrees(+07.67836691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109285"},
        {"Hipparcos Number", "HIP 61292"},
        {"Geneva Identification System", "GEN# +1.00109285"},
        {"Smithsonian Astrophysical Observation", "SAO 119466"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.38604266),
        dec: Angle.Degrees(+07.67907071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31099"},
        {"Hipparcos Number", "HIP 22732"},
        {"Smithsonian Astrophysical Observation", "SAO 112176"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.35292481),
        dec: Angle.Degrees(+07.67934589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94704"},
        {"Hipparcos Number", "HIP 53440"},
        {"Geneva Identification System", "GEN# +1.00094704"},
        {"Smithsonian Astrophysical Observation", "SAO 118575"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.98695892),
        dec: Angle.Degrees(+07.67976424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18059"},
        {"Hipparcos Number", "HIP 13539"},
        {"Smithsonian Astrophysical Observation", "SAO 110823"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.58733050),
        dec: Angle.Degrees(+07.68024746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136513"},
        {"Hipparcos Number", "HIP 75106"},
        {"Smithsonian Astrophysical Observation", "SAO 120954"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.21656969),
        dec: Angle.Degrees(+07.68274638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8429",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1435 A"},
        {"Henry Draper", "HD 11049"},
        {"Hipparcos Number", "HIP 8429"},
        {"Smithsonian Astrophysical Observation", "SAO 110142"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.16919096),
        dec: Angle.Degrees(+07.68397678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191924"},
        {"Hipparcos Number", "HIP 99533"},
        {"Smithsonian Astrophysical Observation", "SAO 125559"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.00829858),
        dec: Angle.Degrees(+07.68445606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35174"},
        {"Hipparcos Number", "HIP 25185"},
        {"Smithsonian Astrophysical Observation", "SAO 112706"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.81267205),
        dec: Angle.Degrees(+07.68505576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202331"},
        {"Hipparcos Number", "HIP 104905"},
        {"Smithsonian Astrophysical Observation", "SAO 126650"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.74835798),
        dec: Angle.Degrees(+07.68804849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135203"},
        {"Hipparcos Number", "HIP 74523"},
        {"Geneva Identification System", "GEN# +1.00135203"},
        {"Smithsonian Astrophysical Observation", "SAO 120904"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.43011654),
        dec: Angle.Degrees(+07.68854171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20151",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20151"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.79634254),
        dec: Angle.Degrees(+07.68862819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89576"},
        {"Hipparcos Number", "HIP 50613"},
        {"Smithsonian Astrophysical Observation", "SAO 118236"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.07941488),
        dec: Angle.Degrees(+07.68904513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131475"},
        {"Hipparcos Number", "HIP 72861"},
        {"Smithsonian Astrophysical Observation", "SAO 120715"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.39019246),
        dec: Angle.Degrees(+07.69016600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20439"},
        {"Hipparcos Number", "HIP 15310"},
        {"Geneva Identification System", "GEN# +5.20250002"},
        {"Smithsonian Astrophysical Observation", "SAO 111105"},
        {"Wilson Evans Batten Catalogue", "WEB 2947"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.38616926),
        dec: Angle.Degrees(+07.69017037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177984"},
        {"Hipparcos Number", "HIP 93842"},
        {"Renson", "Renson 49582"},
        {"Smithsonian Astrophysical Observation", "SAO 124272"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.65681418),
        dec: Angle.Degrees(+07.69094705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2140"},
        {"Hipparcos Number", "HIP 2025"},
        {"Geneva Identification System", "GEN# +1.00002140"},
        {"Smithsonian Astrophysical Observation", "SAO 109195"},
        {"Wilson Evans Batten Catalogue", "WEB 386"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.42453618),
        dec: Angle.Degrees(+07.69123126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201980"},
        {"Hipparcos Number", "HIP 104726"},
        {"Geneva Identification System", "GEN# +1.00201980"},
        {"Smithsonian Astrophysical Observation", "SAO 126621"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.22180647),
        dec: Angle.Degrees(+07.69251209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17605"},
        {"Geneva Identification System", "GEN# +5.20257005"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.56692243),
        dec: Angle.Degrees(+07.69278242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49861",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7672 AB"},
        {"Henry Draper", "HD 88282"},
        {"Hipparcos Number", "HIP 49861"},
        {"Smithsonian Astrophysical Observation", "SAO 118147"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.72713258),
        dec: Angle.Degrees(+07.69463326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16399"},
        {"Hipparcos Number", "HIP 12272"},
        {"Geneva Identification System", "GEN# +1.00016399"},
        {"Smithsonian Astrophysical Observation", "SAO 110653"},
        {"Wilson Evans Batten Catalogue", "WEB 2516"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.50292393),
        dec: Angle.Degrees(+07.69537660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42000"},
        {"Smithsonian Astrophysical Observation", "SAO 116888"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.40932998),
        dec: Angle.Degrees(+07.69567383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9237"},
        {"Hipparcos Number", "HIP 7071"},
        {"Geneva Identification System", "GEN# +1.00009237"},
        {"Smithsonian Astrophysical Observation", "SAO 109941"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.78670450),
        dec: Angle.Degrees(+07.69578185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26323"},
        {"Hipparcos Number", "HIP 19466"},
        {"Geneva Identification System", "GEN# +1.00026323"},
        {"Smithsonian Astrophysical Observation", "SAO 111637"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.52848843),
        dec: Angle.Degrees(+07.69795698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40963"},
        {"Hipparcos Number", "HIP 28624"},
        {"Celescope Catalog", "CEL 1063"},
        {"Geneva Identification System", "GEN# +1.00040963"},
        {"Smithsonian Astrophysical Observation", "SAO 113395"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.64883670),
        dec: Angle.Degrees(+07.69886789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146561"},
        {"Hipparcos Number", "HIP 79752"},
        {"Geneva Identification System", "GEN# +1.00146561"},
        {"Smithsonian Astrophysical Observation", "SAO 121467"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.16397096),
        dec: Angle.Degrees(+07.69945047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110221"},
        {"Hipparcos Number", "HIP 61852"},
        {"Geneva Identification System", "GEN# +1.00110221"},
        {"Smithsonian Astrophysical Observation", "SAO 119526"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.14632165),
        dec: Angle.Degrees(+07.69979643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129868"},
        {"Hipparcos Number", "HIP 72087"},
        {"Smithsonian Astrophysical Observation", "SAO 120635"},
        {"Wilson Evans Batten Catalogue", "WEB 12401"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.20056705),
        dec: Angle.Degrees(+07.70113471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173055"},
        {"Hipparcos Number", "HIP 91801"},
        {"Smithsonian Astrophysical Observation", "SAO 123839"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.77305298),
        dec: Angle.Degrees(+07.70163770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -254.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5075"},
        {"Hipparcos Number", "HIP 4113"},
        {"Smithsonian Astrophysical Observation", "SAO 109517"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.18290603),
        dec: Angle.Degrees(+07.70197520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251"},
        {"Hipparcos Number", "HIP 603"},
        {"Geneva Identification System", "GEN# +1.00000251"},
        {"Smithsonian Astrophysical Observation", "SAO 109019"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.82662524),
        dec: Angle.Degrees(+07.70357212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14290"},
        {"Hipparcos Number", "HIP 10781"},
        {"Geneva Identification System", "GEN# +1.00014290"},
        {"Smithsonian Astrophysical Observation", "SAO 110466"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.69180821),
        dec: Angle.Degrees(+07.70579672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215777"},
        {"Hipparcos Number", "HIP 112518"},
        {"Geneva Identification System", "GEN# +1.00215777"},
        {"Smithsonian Astrophysical Observation", "SAO 127763"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.87038572),
        dec: Angle.Degrees(+07.70873175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69177"},
        {"Hipparcos Number", "HIP 40499"},
        {"Geneva Identification System", "GEN# +1.00069177"},
        {"Smithsonian Astrophysical Observation", "SAO 116557"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.03061398),
        dec: Angle.Degrees(+07.70886884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47303",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7467 AB"},
        {"Henry Draper", "HD 83406"},
        {"Hipparcos Number", "HIP 47303"},
        {"Smithsonian Astrophysical Observation", "SAO 117819"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.59426677),
        dec: Angle.Degrees(+07.70907492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15020"},
        {"Geneva Identification System", "GEN# +9.80076069"},
    },
    visualMagnitude: 11.90,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.40245464),
        dec: Angle.Degrees(+07.70940603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -300.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260537"},
        {"Hipparcos Number", "HIP 31577"},
        {"Celescope Catalog", "CEL 1316"},
        {"Geneva Identification System", "GEN# +1.00260537"},
        {"Smithsonian Astrophysical Observation", "SAO 114122"},
        {"Wilson Evans Batten Catalogue", "WEB 6321"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.13421012),
        dec: Angle.Degrees(+07.71037953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11443"},
        {"Geneva Identification System", "GEN# +0.00700385"},
        {"Wilson Evans Batten Catalogue", "WEB 2389"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.88880173),
        dec: Angle.Degrees(+07.71252788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19104"},
        {"Smithsonian Astrophysical Observation", "SAO 111598"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.42554201),
        dec: Angle.Degrees(+07.71345058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81028"},
        {"Hipparcos Number", "HIP 46053"},
        {"Geneva Identification System", "GEN# +1.00081028"},
        {"Smithsonian Astrophysical Observation", "SAO 117646"},
        {"Wilson Evans Batten Catalogue", "WEB 8725"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.87310317),
        dec: Angle.Degrees(+07.71384306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173953"},
        {"Hipparcos Number", "HIP 92241"},
        {"Geneva Identification System", "GEN# +1.00173953"},
        {"Smithsonian Astrophysical Observation", "SAO 123927"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.98430669),
        dec: Angle.Degrees(+07.71391774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109736",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15750 AB"},
        {"Henry Draper", "HD 210945"},
        {"Hipparcos Number", "HIP 109736"},
        {"Smithsonian Astrophysical Observation", "SAO 127385"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.43480626),
        dec: Angle.Degrees(+07.71496030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19719",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3064 AB"},
        {"Henry Draper", "HD 26690"},
        {"Hipparcos Number", "HIP 19719"},
        {"Geneva Identification System", "GEN# +1.00026690"},
        {"Smithsonian Astrophysical Observation", "SAO 111672"},
        {"Wilson Evans Batten Catalogue", "WEB 3761"},
    },
    visualMagnitude: 5.29,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.38794242),
        dec: Angle.Degrees(+07.71603410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101573"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.77990418),
        dec: Angle.Degrees(+07.71862889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159227"},
        {"Hipparcos Number", "HIP 85894"},
        {"Smithsonian Astrophysical Observation", "SAO 122501"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.29344368),
        dec: Angle.Degrees(+07.71885588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30120",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4951 AB"},
        {"Henry Draper", "HD 44109"},
        {"Hipparcos Number", "HIP 30120"},
        {"Celescope Catalog", "CEL 1183"},
        {"Geneva Identification System", "GEN# +1.00044109J"},
        {"Smithsonian Astrophysical Observation", "SAO 113733"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.07139594),
        dec: Angle.Degrees(+07.71886255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36487",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6138 AB"},
        {"Henry Draper", "HD 59473"},
        {"Hipparcos Number", "HIP 36487"},
        {"Smithsonian Astrophysical Observation", "SAO 115528"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.61521178),
        dec: Angle.Degrees(+07.71926274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5731"},
        {"Hipparcos Number", "HIP 4601"},
        {"Smithsonian Astrophysical Observation", "SAO 109572"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.74455504),
        dec: Angle.Degrees(+07.71934560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3177"},
        {"Hipparcos Number", "HIP 2751"},
        {"Geneva Identification System", "GEN# +1.00003177"},
        {"Smithsonian Astrophysical Observation", "SAO 109294"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.78162814),
        dec: Angle.Degrees(+07.72329878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73002"},
        {"Hipparcos Number", "HIP 42194"},
        {"Smithsonian Astrophysical Observation", "SAO 116934"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.04791420),
        dec: Angle.Degrees(+07.72362352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54632"},
        {"Hipparcos Number", "HIP 34597"},
        {"Smithsonian Astrophysical Observation", "SAO 115012"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.49136950),
        dec: Angle.Degrees(+07.72466153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116550",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116550"},
        {"Smithsonian Astrophysical Observation", "SAO 128288"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.30129837),
        dec: Angle.Degrees(+07.72867434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221295"},
        {"Hipparcos Number", "HIP 116058"},
        {"Smithsonian Astrophysical Observation", "SAO 128221"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.74082503),
        dec: Angle.Degrees(+07.72868687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260988"},
        {"Henry Draper 2", "HD 260989"},
        {"Hipparcos Number", "HIP 31704"},
        {"Smithsonian Astrophysical Observation", "SAO 114161"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.48289715),
        dec: Angle.Degrees(+07.72921398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16247"},
        {"Hipparcos Number", "HIP 12148"},
        {"Geneva Identification System", "GEN# +1.00016247"},
        {"Smithsonian Astrophysical Observation", "SAO 110640"},
        {"Wilson Evans Batten Catalogue", "WEB 2497"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.14626535),
        dec: Angle.Degrees(+07.73007761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130527"},
        {"Hipparcos Number", "HIP 72430"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.14832370),
        dec: Angle.Degrees(+07.73100730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170009"},
        {"Hipparcos Number", "HIP 90428"},
        {"Geneva Identification System", "GEN# +1.00170009"},
        {"Smithsonian Astrophysical Observation", "SAO 123494"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.75747237),
        dec: Angle.Degrees(+07.73272828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68704"},
        {"Hipparcos Number", "HIP 40312"},
        {"Smithsonian Astrophysical Observation", "SAO 116504"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.47405669),
        dec: Angle.Degrees(+07.73275726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162869"},
        {"Hipparcos Number", "HIP 87525"},
        {"Smithsonian Astrophysical Observation", "SAO 122871"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.22796690),
        dec: Angle.Degrees(+07.73367243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146760"},
        {"Hipparcos Number", "HIP 79827"},
        {"Smithsonian Astrophysical Observation", "SAO 121479"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.40389002),
        dec: Angle.Degrees(+07.73392979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109417"},
        {"Hipparcos Number", "HIP 61366"},
        {"Geneva Identification System", "GEN# +1.00109417"},
        {"Smithsonian Astrophysical Observation", "SAO 119479"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.62808958),
        dec: Angle.Degrees(+07.73481885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12730"},
        {"Hipparcos Number", "HIP 9706"},
        {"Smithsonian Astrophysical Observation", "SAO 110325"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.21246935),
        dec: Angle.Degrees(+07.73566461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132720"},
        {"Hipparcos Number", "HIP 73434"},
        {"Smithsonian Astrophysical Observation", "SAO 120786"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.09530534),
        dec: Angle.Degrees(+07.73580624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113277"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.07570590),
        dec: Angle.Degrees(+07.73831336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131133"},
        {"Hipparcos Number", "HIP 72675"},
        {"Geneva Identification System", "GEN# +1.00131133"},
        {"Smithsonian Astrophysical Observation", "SAO 120700"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.89179866),
        dec: Angle.Degrees(+07.74520916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 221.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145697"},
        {"Hipparcos Number", "HIP 79373"},
        {"Smithsonian Astrophysical Observation", "SAO 121420"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.99674261),
        dec: Angle.Degrees(+07.74531607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55122"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.28874967),
        dec: Angle.Degrees(+07.74555098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12986"},
    },
    visualMagnitude: 11.67,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.75253953),
        dec: Angle.Degrees(+07.74728576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148710"},
        {"Hipparcos Number", "HIP 80791"},
        {"Smithsonian Astrophysical Observation", "SAO 121645"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.44456352),
        dec: Angle.Degrees(+07.74894347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84230",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10398 AB"},
        {"Henry Draper", "HD 155714"},
        {"Hipparcos Number", "HIP 84230"},
        {"Renson", "Renson 43980"},
        {"Smithsonian Astrophysical Observation", "SAO 122186"},
        {"Wilson Evans Batten Catalogue", "WEB 14224"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.24708619),
        dec: Angle.Degrees(+07.74931432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18632"},
        {"Hipparcos Number", "HIP 13976"},
        {"Cincinnati Publication", "Ci 18 387"},
        {"Geneva Identification System", "GEN# +1.00018632"},
        {"Smithsonian Astrophysical Observation", "SAO 110894"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.01091188),
        dec: Angle.Degrees(+07.74970382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 329.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21439"},
        {"Hipparcos Number", "HIP 16116"},
        {"Geneva Identification System", "GEN# +1.00021439"},
        {"Smithsonian Astrophysical Observation", "SAO 111202"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.90658797),
        dec: Angle.Degrees(+07.75048842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193914"},
        {"Hipparcos Number", "HIP 100480"},
        {"Smithsonian Astrophysical Observation", "SAO 125738"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.64400856),
        dec: Angle.Degrees(+07.75596425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204500"},
        {"Hipparcos Number", "HIP 106054"},
        {"Smithsonian Astrophysical Observation", "SAO 126823"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.21984572),
        dec: Angle.Degrees(+07.75709714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113959"},
        {"Hipparcos Number", "HIP 64020"},
        {"Smithsonian Astrophysical Observation", "SAO 119772"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.78339693),
        dec: Angle.Degrees(+07.75726178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104028",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14600 AB"},
        {"Henry Draper", "HD 200643"},
        {"Hipparcos Number", "HIP 104028"},
        {"Smithsonian Astrophysical Observation", "SAO 126517"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.13554356),
        dec: Angle.Degrees(+07.76020625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189509"},
        {"Hipparcos Number", "HIP 98442"},
        {"Geneva Identification System", "GEN# +1.00189509"},
        {"Smithsonian Astrophysical Observation", "SAO 125331"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.03400780),
        dec: Angle.Degrees(+07.76061145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131785"},
        {"Hipparcos Number", "HIP 73025"},
        {"Smithsonian Astrophysical Observation", "SAO 120740"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.86041673),
        dec: Angle.Degrees(+07.76207983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172472"},
        {"Hipparcos Number", "HIP 91536"},
        {"Smithsonian Astrophysical Observation", "SAO 123787"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.01782546),
        dec: Angle.Degrees(+07.76291727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179939"},
        {"Hipparcos Number", "HIP 94512"},
        {"Smithsonian Astrophysical Observation", "SAO 124419"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.54184751),
        dec: Angle.Degrees(+07.76408792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62649"},
        {"Hipparcos Number", "HIP 37839"},
        {"Smithsonian Astrophysical Observation", "SAO 115886"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.36577279),
        dec: Angle.Degrees(+07.76447805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114440"},
    },
    visualMagnitude: 12.09,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.65513195),
        dec: Angle.Degrees(+07.76696661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57686"},
        {"Smithsonian Astrophysical Observation", "SAO 119070"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.46101387),
        dec: Angle.Degrees(+07.76772513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66413"},
        {"Cincinnati Publication", "Ci 20 792"},
        {"Geneva Identification System", "GEN# +0.00802735"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.23808802),
        dec: Angle.Degrees(+07.76795937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -776.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -360.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24400"},
        {"Hipparcos Number", "HIP 18174"},
        {"Geneva Identification System", "GEN# +1.00024400"},
        {"Smithsonian Astrophysical Observation", "SAO 111476"},
        {"Wilson Evans Batten Catalogue", "WEB 3507"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.30484507),
        dec: Angle.Degrees(+07.77073590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4175"},
        {"Hipparcos Number", "HIP 3466"},
        {"Smithsonian Astrophysical Observation", "SAO 109415"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.08227970),
        dec: Angle.Degrees(+07.77090105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184244"},
        {"Hipparcos Number", "HIP 96166"},
        {"Smithsonian Astrophysical Observation", "SAO 124782"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.30066718),
        dec: Angle.Degrees(+07.77273248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21371"},
        {"Smithsonian Astrophysical Observation", "SAO 111906"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.78676092),
        dec: Angle.Degrees(+07.77371609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30598",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5053 AB"},
        {"Henry Draper", "HD 45092"},
        {"Hipparcos Number", "HIP 30598"},
        {"Smithsonian Astrophysical Observation", "SAO 113864"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.45190506),
        dec: Angle.Degrees(+07.77399952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215139"},
        {"Hipparcos Number", "HIP 112147"},
        {"Smithsonian Astrophysical Observation", "SAO 127708"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.73574336),
        dec: Angle.Degrees(+07.77425921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74186"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.38423215),
        dec: Angle.Degrees(+07.77525698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75937"},
        {"Hipparcos Number", "HIP 43637"},
        {"Geneva Identification System", "GEN# +1.00075937"},
        {"Smithsonian Astrophysical Observation", "SAO 117231"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.31681745),
        dec: Angle.Degrees(+07.77742884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142952"},
        {"Hipparcos Number", "HIP 78128"},
        {"Smithsonian Astrophysical Observation", "SAO 121278"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.30241803),
        dec: Angle.Degrees(+07.77767479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18395"},
        {"Hipparcos Number", "HIP 13787"},
        {"Smithsonian Astrophysical Observation", "SAO 110870"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.37117486),
        dec: Angle.Degrees(+07.77814300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42548"},
        {"Hipparcos Number", "HIP 29396"},
        {"Geneva Identification System", "GEN# +1.00042548"},
        {"Smithsonian Astrophysical Observation", "SAO 113569"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.92285825),
        dec: Angle.Degrees(+07.77843883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31296"},
        {"Hipparcos Number", "HIP 22834"},
        {"Fundamental Katalog 5th Edition", "FK5 2369"},
        {"Geneva Identification System", "GEN# +1.00031296"},
        {"Smithsonian Astrophysical Observation", "SAO 112203"},
        {"Wilson Evans Batten Catalogue", "WEB 4421"},
    },
    visualMagnitude: 5.33,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.69914124),
        dec: Angle.Degrees(+07.77916325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145461"},
        {"Hipparcos Number", "HIP 79277"},
        {"Smithsonian Astrophysical Observation", "SAO 121406"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.70115618),
        dec: Angle.Degrees(+07.77921135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214267"},
        {"Hipparcos Number", "HIP 111634"},
        {"Geneva Identification System", "GEN# +1.00214267"},
        {"Smithsonian Astrophysical Observation", "SAO 127634"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.22480968),
        dec: Angle.Degrees(+07.78235060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154676"},
        {"Hipparcos Number", "HIP 83719"},
        {"Smithsonian Astrophysical Observation", "SAO 122083"},
        {"Wilson Evans Batten Catalogue", "WEB 14155"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.66260446),
        dec: Angle.Degrees(+07.78272047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99547"},
    },
    visualMagnitude: 11.75,
    bvColour: 1.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.02900471),
        dec: Angle.Degrees(+07.78568109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184451"},
        {"Hipparcos Number", "HIP 96241"},
        {"Smithsonian Astrophysical Observation", "SAO 124801"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.54637242),
        dec: Angle.Degrees(+07.78578906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10107"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.51331793),
        dec: Angle.Degrees(+07.78652386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3161"},
    },
    visualMagnitude: 11.49,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.05660934),
        dec: Angle.Degrees(+07.78850743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167082"},
        {"Hipparcos Number", "HIP 89303"},
        {"Smithsonian Astrophysical Observation", "SAO 123265"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.33633408),
        dec: Angle.Degrees(+07.78932568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213509"},
        {"Hipparcos Number", "HIP 111212"},
        {"Smithsonian Astrophysical Observation", "SAO 127578"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.95013383),
        dec: Angle.Degrees(+07.79099909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12505"},
        {"Hipparcos Number", "HIP 9548"},
        {"Smithsonian Astrophysical Observation", "SAO 110297"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.67652009),
        dec: Angle.Degrees(+07.79156464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137295"},
        {"Hipparcos Number", "HIP 75460"},
        {"Geneva Identification System", "GEN# +1.00137295"},
        {"Smithsonian Astrophysical Observation", "SAO 120989"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.23453536),
        dec: Angle.Degrees(+07.79164137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203521"},
        {"Hipparcos Number", "HIP 105544"},
        {"Smithsonian Astrophysical Observation", "SAO 126745"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.63988917),
        dec: Angle.Degrees(+07.79478960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181304"},
        {"Hipparcos Number", "HIP 94987"},
        {"Smithsonian Astrophysical Observation", "SAO 124510"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.92056741),
        dec: Angle.Degrees(+07.79556767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35320",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5960 AB"},
        {"Henry Draper", "HD 56540"},
        {"Hipparcos Number", "HIP 35320"},
        {"Smithsonian Astrophysical Observation", "SAO 115214"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.43580789),
        dec: Angle.Degrees(+07.79606745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15015"},
        {"Smithsonian Astrophysical Observation", "SAO 111060"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.38990195),
        dec: Angle.Degrees(+07.79873902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160509"},
        {"Hipparcos Number", "HIP 86457"},
        {"Smithsonian Astrophysical Observation", "SAO 122627"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.98315689),
        dec: Angle.Degrees(+07.80115164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43036",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6987 AB"},
        {"Hipparcos Number", "HIP 43036"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.53336288),
        dec: Angle.Degrees(+07.80518281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196756"},
        {"Hipparcos Number", "HIP 101917"},
        {"Smithsonian Astrophysical Observation", "SAO 126060"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.78687357),
        dec: Angle.Degrees(+07.80855778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192622"},
        {"Hipparcos Number", "HIP 99860"},
        {"Smithsonian Astrophysical Observation", "SAO 125620"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.90464863),
        dec: Angle.Degrees(+07.80896397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73876"},
    },
    visualMagnitude: 11.12,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.48753434),
        dec: Angle.Degrees(+07.81323180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21107"},
        {"Smithsonian Astrophysical Observation", "SAO 111869"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.85020967),
        dec: Angle.Degrees(+07.81493208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138409"},
        {"Hipparcos Number", "HIP 76021"},
        {"Geneva Identification System", "GEN# +1.00138409"},
        {"Smithsonian Astrophysical Observation", "SAO 121043"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.91145951),
        dec: Angle.Degrees(+07.81560425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136797"},
        {"Hipparcos Number", "HIP 75226"},
        {"Smithsonian Astrophysical Observation", "SAO 120963"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.59054944),
        dec: Angle.Degrees(+07.81615420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107516"},
        {"Hipparcos Number", "HIP 60272"},
        {"Smithsonian Astrophysical Observation", "SAO 119350"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.37297459),
        dec: Angle.Degrees(+07.81867059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8129",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8129"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.12149365),
        dec: Angle.Degrees(+07.81881386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48165"},
        {"Geneva Identification System", "GEN# +0.00802269"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.26383137),
        dec: Angle.Degrees(+07.81929065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -247.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83961"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.44880383),
        dec: Angle.Degrees(+07.81970627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -266.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180740"},
        {"Hipparcos Number", "HIP 94805"},
        {"Smithsonian Astrophysical Observation", "SAO 124473"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.36016109),
        dec: Angle.Degrees(+07.81999831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50228"},
        {"Hipparcos Number", "HIP 33005"},
        {"Geneva Identification System", "GEN# +1.00050228"},
        {"Smithsonian Astrophysical Observation", "SAO 114551"},
        {"Wilson Evans Batten Catalogue", "WEB 6644"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.16252274),
        dec: Angle.Degrees(+07.82222609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31089",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5159 AB"},
        {"Henry Draper", "HD 46055"},
        {"Hipparcos Number", "HIP 31089"},
        {"Smithsonian Astrophysical Observation", "SAO 113992"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.85762914),
        dec: Angle.Degrees(+07.82234822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140233"},
        {"Hipparcos Number", "HIP 76906"},
        {"Geneva Identification System", "GEN# +1.00140233"},
        {"Smithsonian Astrophysical Observation", "SAO 121131"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.55462802),
        dec: Angle.Degrees(+07.82316553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58727",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8401 AB"},
        {"Henry Draper", "HD 104591"},
        {"Hipparcos Number", "HIP 58727"},
        {"Smithsonian Astrophysical Observation", "SAO 119182"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.68875791),
        dec: Angle.Degrees(+07.82404338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7088"},
        {"Hipparcos Number", "HIP 5562"},
        {"Smithsonian Astrophysical Observation", "SAO 109719"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.82925988),
        dec: Angle.Degrees(+07.82789916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11862"},
    },
    visualMagnitude: 12.00,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.26845641),
        dec: Angle.Degrees(+07.82862873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32577"},
        {"Hipparcos Number", "HIP 23601"},
        {"Smithsonian Astrophysical Observation", "SAO 112385"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.11869917),
        dec: Angle.Degrees(+07.83030726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61341"},
        {"Hipparcos Number", "HIP 37264"},
        {"Smithsonian Astrophysical Observation", "SAO 115753"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.79040293),
        dec: Angle.Degrees(+07.83093485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9889"},
        {"Hipparcos Number", "HIP 7505"},
        {"Smithsonian Astrophysical Observation", "SAO 110011"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.18134717),
        dec: Angle.Degrees(+07.83150675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174986"},
        {"Hipparcos Number", "HIP 92670"},
        {"Smithsonian Astrophysical Observation", "SAO 124003"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.25068823),
        dec: Angle.Degrees(+07.83252125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63063"},
        {"Smithsonian Astrophysical Observation", "SAO 119669"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.81624043),
        dec: Angle.Degrees(+07.83300490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38930"},
        {"Smithsonian Astrophysical Observation", "SAO 116177"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.48661883),
        dec: Angle.Degrees(+07.83436172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161200"},
        {"Hipparcos Number", "HIP 86772"},
        {"Smithsonian Astrophysical Observation", "SAO 122678"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.96435042),
        dec: Angle.Degrees(+07.83479950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219770"},
        {"Hipparcos Number", "HIP 115059"},
        {"Geneva Identification System", "GEN# +1.00219770"},
        {"Smithsonian Astrophysical Observation", "SAO 128099"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.57653358),
        dec: Angle.Degrees(+07.83503887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222428"},
        {"Hipparcos Number", "HIP 116816"},
        {"Geneva Identification System", "GEN# +1.00222428"},
        {"Smithsonian Astrophysical Observation", "SAO 128316"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.13061042),
        dec: Angle.Degrees(+07.83837779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30507"},
        {"Hipparcos Number", "HIP 22346"},
        {"Smithsonian Astrophysical Observation", "SAO 112095"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.17103789),
        dec: Angle.Degrees(+07.83991525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59295"},
        {"Hipparcos Number", "HIP 36418"},
        {"Smithsonian Astrophysical Observation", "SAO 115518"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.39765973),
        dec: Angle.Degrees(+07.84048365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76951",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76951"},
        {"Smithsonian Astrophysical Observation", "SAO 121141"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.68349797),
        dec: Angle.Degrees(+07.84096841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61459"},
        {"Hipparcos Number", "HIP 37328"},
        {"Smithsonian Astrophysical Observation", "SAO 115764"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.94457228),
        dec: Angle.Degrees(+07.84133110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185608"},
        {"Hipparcos Number", "HIP 96717"},
        {"Geneva Identification System", "GEN# +1.00185608"},
        {"Smithsonian Astrophysical Observation", "SAO 124911"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.91435033),
        dec: Angle.Degrees(+07.84390940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135927"},
        {"Hipparcos Number", "HIP 74832"},
        {"Geneva Identification System", "GEN# +1.00135927"},
        {"Smithsonian Astrophysical Observation", "SAO 120933"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.40340708),
        dec: Angle.Degrees(+07.84463775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4313"},
        {"Hipparcos Number", "HIP 3574"},
        {"Geneva Identification System", "GEN# +1.00004313"},
        {"Smithsonian Astrophysical Observation", "SAO 109437"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.41817232),
        dec: Angle.Degrees(+07.84500481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49640"},
        {"Hipparcos Number", "HIP 32748"},
        {"Geneva Identification System", "GEN# +1.00049640"},
        {"Smithsonian Astrophysical Observation", "SAO 114476"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.43780919),
        dec: Angle.Degrees(+07.84524305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215945"},
        {"Hipparcos Number", "HIP 112630"},
        {"Smithsonian Astrophysical Observation", "SAO 127776"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.16917726),
        dec: Angle.Degrees(+07.84530198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142009"},
        {"Hipparcos Number", "HIP 77700"},
        {"Smithsonian Astrophysical Observation", "SAO 121225"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.95851687),
        dec: Angle.Degrees(+07.84763201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88534"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.18079754),
        dec: Angle.Degrees(+07.84813056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198416"},
        {"Hipparcos Number", "HIP 102838"},
        {"Geneva Identification System", "GEN# +1.00198416"},
        {"Smithsonian Astrophysical Observation", "SAO 126270"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.51243012),
        dec: Angle.Degrees(+07.84998651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124200"},
        {"Hipparcos Number", "HIP 69365"},
        {"Smithsonian Astrophysical Observation", "SAO 120338"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.98610131),
        dec: Angle.Degrees(+07.85013280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25257"},
        {"Hipparcos Number", "HIP 18749"},
        {"Smithsonian Astrophysical Observation", "SAO 111560"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.24332836),
        dec: Angle.Degrees(+07.85027816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75779"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.20681386),
        dec: Angle.Degrees(+07.85056226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209105"},
        {"Hipparcos Number", "HIP 108663"},
        {"Smithsonian Astrophysical Observation", "SAO 127232"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.21216739),
        dec: Angle.Degrees(+07.85244993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27460"},
        {"Hipparcos Number", "HIP 20244"},
        {"Geneva Identification System", "GEN# +1.00027460"},
        {"Smithsonian Astrophysical Observation", "SAO 111755"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.06929560),
        dec: Angle.Degrees(+07.85370780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190195"},
        {"Hipparcos Number", "HIP 98758"},
        {"Geneva Identification System", "GEN# +1.00190195"},
        {"Smithsonian Astrophysical Observation", "SAO 125393"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.88189268),
        dec: Angle.Degrees(+07.85416699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154581"},
        {"Hipparcos Number", "HIP 83665"},
        {"Smithsonian Astrophysical Observation", "SAO 122072"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.50155390),
        dec: Angle.Degrees(+07.85472507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14126"},
        {"Smithsonian Astrophysical Observation", "SAO 110918"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.54448774),
        dec: Angle.Degrees(+07.85584296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146169"},
        {"Hipparcos Number", "HIP 79608"},
        {"Smithsonian Astrophysical Observation", "SAO 121451"},
        {"Wilson Evans Batten Catalogue", "WEB 13471"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.67604620),
        dec: Angle.Degrees(+07.85825362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40333"},
        {"Hipparcos Number", "HIP 28274"},
        {"Smithsonian Astrophysical Observation", "SAO 113313"},
        {"Wilson Evans Batten Catalogue", "WEB 5529"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.61488125),
        dec: Angle.Degrees(+07.86054411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56234",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8195 AB"},
        {"Henry Draper", "HD 100168"},
        {"Hipparcos Number", "HIP 56234"},
        {"Smithsonian Astrophysical Observation", "SAO 118905"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.91647424),
        dec: Angle.Degrees(+07.86355914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198391"},
        {"Hipparcos Number", "HIP 102819"},
        {"Fundamental Katalog 5th Edition", "FK5 3664"},
        {"Geneva Identification System", "GEN# +1.00198391"},
        {"Renson", "Renson 55210"},
        {"Smithsonian Astrophysical Observation", "SAO 126265"},
        {"Wilson Evans Batten Catalogue", "WEB 18647"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.45101900),
        dec: Angle.Degrees(+07.86415480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12414"},
        {"Hipparcos Number", "HIP 9473"},
        {"Geneva Identification System", "GEN# +1.00012414"},
        {"Smithsonian Astrophysical Observation", "SAO 110286"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.46832359),
        dec: Angle.Degrees(+07.86448845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43422",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7044 AB"},
        {"Hipparcos Number", "HIP 43422"},
        {"Geneva Identification System", "GEN# +0.00802131"},
        {"Wilson Evans Batten Catalogue", "WEB 8368"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.67636458),
        dec: Angle.Degrees(+07.86460106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211684"},
        {"Hipparcos Number", "HIP 110149"},
        {"Smithsonian Astrophysical Observation", "SAO 127442"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.67253638),
        dec: Angle.Degrees(+07.86547506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1365"},
        {"Hipparcos Number", "HIP 1435"},
        {"Geneva Identification System", "GEN# +1.00001365"},
        {"Smithsonian Astrophysical Observation", "SAO 109121"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.47021876),
        dec: Angle.Degrees(+07.86606224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13173"},
    },
    visualMagnitude: 12.04,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.35651859),
        dec: Angle.Degrees(+07.86646824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32130"},
        {"Hipparcos Number", "HIP 23339"},
        {"Geneva Identification System", "GEN# +1.00032130"},
        {"Smithsonian Astrophysical Observation", "SAO 112318"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.30320206),
        dec: Angle.Degrees(+07.86929978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29499"},
        {"Hipparcos Number", "HIP 21670"},
        {"Fundamental Katalog 5th Edition", "FK5 2344"},
        {"Geneva Identification System", "GEN# +5.20250107"},
        {"Renson", "Renson 7560"},
        {"Smithsonian Astrophysical Observation", "SAO 111954"},
        {"Wilson Evans Batten Catalogue", "WEB 4162"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.77542864),
        dec: Angle.Degrees(+07.87098753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75567"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.56269892),
        dec: Angle.Degrees(+07.87283902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11169"},
        {"Hipparcos Number", "HIP 8516"},
        {"Smithsonian Astrophysical Observation", "SAO 110153"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.46672085),
        dec: Angle.Degrees(+07.87301998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51586"},
        {"Hipparcos Number", "HIP 33546"},
        {"Smithsonian Astrophysical Observation", "SAO 114697"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.57426732),
        dec: Angle.Degrees(+07.87454822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6425"},
        {"Hipparcos Number", "HIP 5089"},
        {"Smithsonian Astrophysical Observation", "SAO 109659"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.29902788),
        dec: Angle.Degrees(+07.87461595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194452"},
        {"Hipparcos Number", "HIP 100733"},
        {"Smithsonian Astrophysical Observation", "SAO 125792"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.35274897),
        dec: Angle.Degrees(+07.87500797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104123"},
        {"Smithsonian Astrophysical Observation", "SAO 126537"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.41921725),
        dec: Angle.Degrees(+07.87525094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66067"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.15366641),
        dec: Angle.Degrees(+07.87913098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -296.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220585"},
        {"Hipparcos Number", "HIP 115589"},
        {"Smithsonian Astrophysical Observation", "SAO 128166"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.20498313),
        dec: Angle.Degrees(+07.88095946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124549"},
        {"Hipparcos Number", "HIP 69540"},
        {"Smithsonian Astrophysical Observation", "SAO 120357"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.53635230),
        dec: Angle.Degrees(+07.88111350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174278"},
        {"Hipparcos Number", "HIP 92371"},
        {"Smithsonian Astrophysical Observation", "SAO 123946"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.37076525),
        dec: Angle.Degrees(+07.88137997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54217"},
        {"Hipparcos Number", "HIP 34441"},
        {"Smithsonian Astrophysical Observation", "SAO 114963"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.09318027),
        dec: Angle.Degrees(+07.88141065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49245"},
        {"Hipparcos Number", "HIP 32577"},
        {"Smithsonian Astrophysical Observation", "SAO 114424"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.96275006),
        dec: Angle.Degrees(+07.88269680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106677",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15128 A"},
        {"Henry Draper", "HD 205630"},
        {"Hipparcos Number", "HIP 106677"},
        {"Smithsonian Astrophysical Observation", "SAO 126922"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.10484737),
        dec: Angle.Degrees(+07.88293399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1767"},
        {"Smithsonian Astrophysical Observation", "SAO 109164"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.59369490),
        dec: Angle.Degrees(+07.88368311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218055"},
        {"Hipparcos Number", "HIP 113974"},
        {"Smithsonian Astrophysical Observation", "SAO 127952"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.22614833),
        dec: Angle.Degrees(+07.88474333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38778"},
        {"Hipparcos Number", "HIP 27433"},
        {"Geneva Identification System", "GEN# +1.00038778"},
        {"Smithsonian Astrophysical Observation", "SAO 113163"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.13826101),
        dec: Angle.Degrees(+07.88538801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175015"},
        {"Hipparcos Number", "HIP 92679"},
        {"Smithsonian Astrophysical Observation", "SAO 124008"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.27359956),
        dec: Angle.Degrees(+07.88570559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6186"},
        {"Hipparcos Number", "HIP 4906"},
        {"Fundamental Katalog 5th Edition", "FK5 36"},
        {"Geneva Identification System", "GEN# +1.00006186"},
        {"Smithsonian Astrophysical Observation", "SAO 109627"},
        {"Wilson Evans Batten Catalogue", "WEB 963"},
    },
    visualMagnitude: 4.27,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.73606615),
        dec: Angle.Degrees(+07.89007256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97053"},
        {"Hipparcos Number", "HIP 54604"},
        {"Smithsonian Astrophysical Observation", "SAO 118702"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.62828372),
        dec: Angle.Degrees(+07.89171957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107924"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.98318816),
        dec: Angle.Degrees(+07.89198778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108302"},
        {"Hipparcos Number", "HIP 60714"},
        {"Smithsonian Astrophysical Observation", "SAO 119397"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.63927244),
        dec: Angle.Degrees(+07.89376298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155500"},
        {"Hipparcos Number", "HIP 84113"},
        {"Fundamental Katalog 5th Edition", "FK5 1451"},
        {"Geneva Identification System", "GEN# +1.00155500"},
        {"Smithsonian Astrophysical Observation", "SAO 122164"},
        {"Wilson Evans Batten Catalogue", "WEB 14205"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.93841699),
        dec: Angle.Degrees(+07.89472891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50206"},
        {"Hipparcos Number", "HIP 32993"},
        {"Geneva Identification System", "GEN# +1.00050206"},
        {"Smithsonian Astrophysical Observation", "SAO 114544"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.10355254),
        dec: Angle.Degrees(+07.89632595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51423"},
        {"Smithsonian Astrophysical Observation", "SAO 118337"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.53221737),
        dec: Angle.Degrees(+07.89725661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33066"},
        {"Hipparcos Number", "HIP 23896"},
        {"Geneva Identification System", "GEN# +1.00033066"},
        {"Smithsonian Astrophysical Observation", "SAO 112450"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.02084088),
        dec: Angle.Degrees(+07.89876215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112802"},
        {"Hipparcos Number", "HIP 63376"},
        {"Geneva Identification System", "GEN# +1.00112802"},
        {"Smithsonian Astrophysical Observation", "SAO 119692"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.78847421),
        dec: Angle.Degrees(+07.90075006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193014"},
        {"Hipparcos Number", "HIP 100032"},
        {"Smithsonian Astrophysical Observation", "SAO 125657"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.43079323),
        dec: Angle.Degrees(+07.90091783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111932"},
    },
    visualMagnitude: 11.76,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.08783535),
        dec: Angle.Degrees(+07.90175333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187567"},
        {"Hipparcos Number", "HIP 97607"},
        {"Geneva Identification System", "GEN# +1.00187567"},
        {"Smithsonian Astrophysical Observation", "SAO 125116"},
        {"Wilson Evans Batten Catalogue", "WEB 17162"},
    },
    visualMagnitude: 6.49,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.57283311),
        dec: Angle.Degrees(+07.90242825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17348",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2709 AB"},
        {"Aitken 2", "ADS 2704"},
        {"Henry Draper", "HD 23110"},
        {"Hipparcos Number", "HIP 17348"},
        {"Smithsonian Astrophysical Observation", "SAO 111367"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.69122365),
        dec: Angle.Degrees(+07.90299620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212736"},
        {"Hipparcos Number", "HIP 110760"},
        {"Geneva Identification System", "GEN# +1.00212736"},
        {"Smithsonian Astrophysical Observation", "SAO 127527"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.58159478),
        dec: Angle.Degrees(+07.90355836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172718"},
        {"Hipparcos Number", "HIP 91649"},
        {"Geneva Identification System", "GEN# +1.00172718"},
        {"Smithsonian Astrophysical Observation", "SAO 123811"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.34048553),
        dec: Angle.Degrees(+07.90392976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111832"},
        {"Hipparcos Number", "HIP 62784"},
        {"Geneva Identification System", "GEN# +1.00111832"},
        {"Smithsonian Astrophysical Observation", "SAO 119639"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.98078366),
        dec: Angle.Degrees(+07.90460602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31423"},
        {"Hipparcos Number", "HIP 22938"},
        {"Geneva Identification System", "GEN# +1.00031423"},
        {"Smithsonian Astrophysical Observation", "SAO 112225"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.03760210),
        dec: Angle.Degrees(+07.90480028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10408"},
        {"Hipparcos Number", "HIP 7901"},
        {"Smithsonian Astrophysical Observation", "SAO 110066"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.40023979),
        dec: Angle.Degrees(+07.90703156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109480"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.68564680),
        dec: Angle.Degrees(+07.90906109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 251.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90824"},
        {"Hipparcos Number", "HIP 51345"},
        {"Smithsonian Astrophysical Observation", "SAO 118328"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.31462160),
        dec: Angle.Degrees(+07.91077750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128801"},
        {"Hipparcos Number", "HIP 71615"},
        {"Geneva Identification System", "GEN# +1.00128801"},
        {"Smithsonian Astrophysical Observation", "SAO 120586"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.70038664),
        dec: Angle.Degrees(+07.91142727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133164"},
        {"Hipparcos Number", "HIP 73614"},
        {"Geneva Identification System", "GEN# +1.00133164"},
        {"Smithsonian Astrophysical Observation", "SAO 120808"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.70489060),
        dec: Angle.Degrees(+07.91194622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186657"},
        {"Hipparcos Number", "HIP 97206"},
        {"Geneva Identification System", "GEN# +1.00186657"},
        {"Smithsonian Astrophysical Observation", "SAO 125025"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.34440385),
        dec: Angle.Degrees(+07.91311201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5995"},
        {"Smithsonian Astrophysical Observation", "SAO 109781"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.27142708),
        dec: Angle.Degrees(+07.91380808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193969"},
        {"Hipparcos Number", "HIP 100509"},
        {"Geneva Identification System", "GEN# +1.00193969"},
        {"Smithsonian Astrophysical Observation", "SAO 125741"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.71398844),
        dec: Angle.Degrees(+07.91484844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3603"},
        {"Hipparcos Number", "HIP 3069"},
        {"Smithsonian Astrophysical Observation", "SAO 109344"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.73941404),
        dec: Angle.Degrees(+07.91497784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104351"},
        {"Hipparcos Number", "HIP 58602"},
        {"Smithsonian Astrophysical Observation", "SAO 119167"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.25671549),
        dec: Angle.Degrees(+07.91511786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65806"},
        {"Hipparcos Number", "HIP 39181"},
        {"Geneva Identification System", "GEN# +1.00065806"},
        {"Smithsonian Astrophysical Observation", "SAO 116235"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.20058830),
        dec: Angle.Degrees(+07.91724689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114671"},
        {"Smithsonian Astrophysical Observation", "SAO 128047"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.45387287),
        dec: Angle.Degrees(+07.91755816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184362"},
        {"Hipparcos Number", "HIP 96205"},
        {"Smithsonian Astrophysical Observation", "SAO 124792"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.44401550),
        dec: Angle.Degrees(+07.91807847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204196"},
        {"Hipparcos Number", "HIP 105896"},
        {"Smithsonian Astrophysical Observation", "SAO 126799"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.71218505),
        dec: Angle.Degrees(+07.92055260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189186"},
        {"Hipparcos Number", "HIP 98314"},
        {"Smithsonian Astrophysical Observation", "SAO 125296"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.63585433),
        dec: Angle.Degrees(+07.92063365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50853"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.76274477),
        dec: Angle.Degrees(+07.92066854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45829"},
        {"Hipparcos Number", "HIP 30970"},
        {"Geneva Identification System", "GEN# +1.00045829"},
        {"Smithsonian Astrophysical Observation", "SAO 113956"},
        {"Wilson Evans Batten Catalogue", "WEB 6169"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.50955908),
        dec: Angle.Degrees(+07.92111903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67779"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.28979624),
        dec: Angle.Degrees(+07.92226457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13674"},
        {"Smithsonian Astrophysical Observation", "SAO 110850"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.03019299),
        dec: Angle.Degrees(+07.92265055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163079"},
        {"Hipparcos Number", "HIP 87621"},
        {"Geneva Identification System", "GEN# +1.00163079"},
        {"Smithsonian Astrophysical Observation", "SAO 122900"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.48696393),
        dec: Angle.Degrees(+07.92329203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221700"},
        {"Hipparcos Number", "HIP 116339"},
        {"Smithsonian Astrophysical Observation", "SAO 128261"},
        {"Wilson Evans Batten Catalogue", "WEB 20557"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.60576625),
        dec: Angle.Degrees(+07.92460890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182080"},
        {"Hipparcos Number", "HIP 95248"},
        {"Renson", "Renson 50360"},
        {"Smithsonian Astrophysical Observation", "SAO 124561"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.68273611),
        dec: Angle.Degrees(+07.92492444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59090"},
        {"Hipparcos Number", "HIP 36339"},
        {"Geneva Identification System", "GEN# +1.00059090"},
        {"Smithsonian Astrophysical Observation", "SAO 115497"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.19491798),
        dec: Angle.Degrees(+07.92783294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179375"},
        {"Hipparcos Number", "HIP 94330"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.01185821),
        dec: Angle.Degrees(+07.92966391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218575"},
        {"Hipparcos Number", "HIP 114308"},
        {"Smithsonian Astrophysical Observation", "SAO 127997"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.25316053),
        dec: Angle.Degrees(+07.93141219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109731"},
        {"Hipparcos Number", "HIP 61561"},
        {"Smithsonian Astrophysical Observation", "SAO 119494"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.20367275),
        dec: Angle.Degrees(+07.93319520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94057"},
        {"Hipparcos Number", "HIP 53071"},
        {"Smithsonian Astrophysical Observation", "SAO 118541"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.86817954),
        dec: Angle.Degrees(+07.93519683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175677"},
        {"Hipparcos Number", "HIP 92943"},
        {"Smithsonian Astrophysical Observation", "SAO 124069"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.04127183),
        dec: Angle.Degrees(+07.93562707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142781"},
        {"Hipparcos Number", "HIP 78044"},
        {"Smithsonian Astrophysical Observation", "SAO 121270"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.02495098),
        dec: Angle.Degrees(+07.93647675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174140"},
        {"Hipparcos Number", "HIP 92299"},
        {"Smithsonian Astrophysical Observation", "SAO 123939"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.18410575),
        dec: Angle.Degrees(+07.93650200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88860"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.13125895),
        dec: Angle.Degrees(+07.94028454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6077"},
        {"Hipparcos Number", "HIP 4832"},
        {"Geneva Identification System", "GEN# +1.00006077"},
        {"Smithsonian Astrophysical Observation", "SAO 109614"},
        {"Wilson Evans Batten Catalogue", "WEB 927"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.52849442),
        dec: Angle.Degrees(+07.94043803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130639"},
        {"Hipparcos Number", "HIP 72464"},
        {"Smithsonian Astrophysical Observation", "SAO 120674"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.27218812),
        dec: Angle.Degrees(+07.94113129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21792"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.21703855),
        dec: Angle.Degrees(+07.94227515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87635"},
        {"Hipparcos Number", "HIP 49496"},
        {"Geneva Identification System", "GEN# +1.00087635"},
        {"Smithsonian Astrophysical Observation", "SAO 118103"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.57724584),
        dec: Angle.Degrees(+07.94445912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200746"},
        {"Hipparcos Number", "HIP 104075"},
        {"Geneva Identification System", "GEN# +1.00200746"},
        {"Smithsonian Astrophysical Observation", "SAO 126530"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.28311671),
        dec: Angle.Degrees(+07.94565595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175372"},
        {"Hipparcos Number", "HIP 92821"},
        {"Smithsonian Astrophysical Observation", "SAO 124040"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.69386642),
        dec: Angle.Degrees(+07.94601804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80065"},
        {"Hipparcos Number", "HIP 45613"},
        {"Geneva Identification System", "GEN# +1.00080065"},
        {"Smithsonian Astrophysical Observation", "SAO 117573"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.46183808),
        dec: Angle.Degrees(+07.94607111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109270"},
        {"Hipparcos Number", "HIP 61273"},
        {"Geneva Identification System", "GEN# +1.00109270"},
        {"Smithsonian Astrophysical Observation", "SAO 119465"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.35257712),
        dec: Angle.Degrees(+07.94615846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20014"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.38444104),
        dec: Angle.Degrees(+07.94703319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 685"},
        {"Hipparcos Number", "HIP 909"},
        {"Fundamental Katalog 5th Edition", "FK5 4021"},
        {"Smithsonian Astrophysical Observation", "SAO 109054"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.81532971),
        dec: Angle.Degrees(+07.94816079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32702"},
        {"Hipparcos Number", "HIP 23683"},
        {"Smithsonian Astrophysical Observation", "SAO 112404"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.35981406),
        dec: Angle.Degrees(+07.95003576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63564"},
        {"Geneva Identification System", "GEN# +0.00802671"},
        {"Smithsonian Astrophysical Observation", "SAO 119724"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.39482758),
        dec: Angle.Degrees(+07.95163921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150556"},
        {"Hipparcos Number", "HIP 81720"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.38445015),
        dec: Angle.Degrees(+07.95166606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115245"},
        {"Hipparcos Number", "HIP 64711"},
        {"Smithsonian Astrophysical Observation", "SAO 119837"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.94559902),
        dec: Angle.Degrees(+07.95296650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99251"},
        {"Hipparcos Number", "HIP 55751"},
        {"Geneva Identification System", "GEN# +1.00099251"},
        {"Smithsonian Astrophysical Observation", "SAO 118841"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.35492219),
        dec: Angle.Degrees(+07.95311470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84209"},
        {"Hipparcos Number", "HIP 47722"},
        {"Geneva Identification System", "GEN# +1.00084209"},
        {"Smithsonian Astrophysical Observation", "SAO 117874"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.93229481),
        dec: Angle.Degrees(+07.95314839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4745"},
        {"Hipparcos Number", "HIP 3862"},
        {"Smithsonian Astrophysical Observation", "SAO 109482"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.39486815),
        dec: Angle.Degrees(+07.95477230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8956"},
        {"Hipparcos Number", "HIP 6873"},
        {"Geneva Identification System", "GEN# +1.00008956"},
        {"Smithsonian Astrophysical Observation", "SAO 109908"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.11429374),
        dec: Angle.Degrees(+07.95822235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9920"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.92578024),
        dec: Angle.Degrees(+07.95885727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65475"},
        {"Hipparcos Number", "HIP 39032"},
        {"Geneva Identification System", "GEN# +1.00065475"},
        {"Smithsonian Astrophysical Observation", "SAO 116200"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.79242040),
        dec: Angle.Degrees(+07.95894572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120317"},
        {"Hipparcos Number", "HIP 67379"},
        {"Geneva Identification System", "GEN# +1.00120317"},
        {"Smithsonian Astrophysical Observation", "SAO 120121"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.14444106),
        dec: Angle.Degrees(+07.96014451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27377",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4388 AB"},
        {"Henry Draper", "HD 38695"},
        {"Hipparcos Number", "HIP 27377"},
        {"Smithsonian Astrophysical Observation", "SAO 113149"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.97874348),
        dec: Angle.Degrees(+07.96041806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186489"},
        {"Hipparcos Number", "HIP 97132"},
        {"Geneva Identification System", "GEN# +1.00186489"},
        {"Smithsonian Astrophysical Observation", "SAO 125007"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.11610442),
        dec: Angle.Degrees(+07.96086447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8949"},
        {"Hipparcos Number", "HIP 6868"},
        {"Geneva Identification System", "GEN# +1.00008949"},
        {"Smithsonian Astrophysical Observation", "SAO 109907"},
        {"Wilson Evans Batten Catalogue", "WEB 1499"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.09520584),
        dec: Angle.Degrees(+07.96137392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69731"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.09449972),
        dec: Angle.Degrees(+07.96236434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62694"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.70322737),
        dec: Angle.Degrees(+07.96614250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61273"},
        {"Hipparcos Number", "HIP 37232"},
        {"Geneva Identification System", "GEN# +1.00061273"},
        {"Renson", "Renson 16773"},
        {"Smithsonian Astrophysical Observation", "SAO 115739"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.71235631),
        dec: Angle.Degrees(+07.96668612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156926"},
        {"Hipparcos Number", "HIP 84805"},
        {"Smithsonian Astrophysical Observation", "SAO 122284"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.00039961),
        dec: Angle.Degrees(+07.96968524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84978"},
        {"Smithsonian Astrophysical Observation", "SAO 122318"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.52349966),
        dec: Angle.Degrees(+07.97070852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47416"},
        {"Hipparcos Number", "HIP 31792"},
        {"Celescope Catalog", "CEL 1334"},
        {"Geneva Identification System", "GEN# +1.00047416"},
        {"Smithsonian Astrophysical Observation", "SAO 114193"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.71273682),
        dec: Angle.Degrees(+07.97155323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109810",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15767 AB"},
        {"Henry Draper", "HD 211048"},
        {"Hipparcos Number", "HIP 109810"},
        {"Smithsonian Astrophysical Observation", "SAO 127402"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.62156789),
        dec: Angle.Degrees(+07.97617615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56031"},
        {"Hipparcos Number", "HIP 35120"},
        {"Geneva Identification System", "GEN# +1.00056031"},
        {"Smithsonian Astrophysical Observation", "SAO 115159"},
        {"Wilson Evans Batten Catalogue", "WEB 7018"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.91423401),
        dec: Angle.Degrees(+07.97773709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179220"},
        {"Hipparcos Number", "HIP 94285"},
        {"Geneva Identification System", "GEN# +1.00179220"},
        {"Smithsonian Astrophysical Observation", "SAO 124366"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.85718625),
        dec: Angle.Degrees(+07.97816636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100435"},
        {"Hipparcos Number", "HIP 56386"},
        {"Smithsonian Astrophysical Observation", "SAO 118922"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.38398632),
        dec: Angle.Degrees(+07.97877587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189662"},
        {"Hipparcos Number", "HIP 98515"},
        {"Smithsonian Astrophysical Observation", "SAO 125353"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.21111038),
        dec: Angle.Degrees(+07.98147100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219949"},
        {"Hipparcos Number", "HIP 115182"},
        {"Geneva Identification System", "GEN# +1.00219949"},
        {"Smithsonian Astrophysical Observation", "SAO 128119"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.95031471),
        dec: Angle.Degrees(+07.98217021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84173"},
        {"Smithsonian Astrophysical Observation", "SAO 122177"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.10001325),
        dec: Angle.Degrees(+07.98364528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72527",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9400 AB"},
        {"Henry Draper", "HD 130726"},
        {"Hipparcos Number", "HIP 72527"},
        {"Smithsonian Astrophysical Observation", "SAO 120683"},
        {"Wilson Evans Batten Catalogue", "WEB 12469"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.42576575),
        dec: Angle.Degrees(+07.98676200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206993"},
        {"Hipparcos Number", "HIP 107447"},
        {"Fundamental Katalog 5th Edition", "FK5 5920"},
        {"Geneva Identification System", "GEN# +1.00206993"},
        {"Smithsonian Astrophysical Observation", "SAO 127045"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.44213912),
        dec: Angle.Degrees(+07.98754485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93248",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93248"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.90996198),
        dec: Angle.Degrees(+07.98769568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 364.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77997"},
        {"Wilson Evans Batten Catalogue", "WEB 13191"},
    },
    visualMagnitude: 11.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.91822366),
        dec: Angle.Degrees(+07.98879720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87423"},
        {"Hipparcos Number", "HIP 49396"},
        {"Fundamental Katalog 5th Edition", "FK5 4897"},
        {"Geneva Identification System", "GEN# +1.00087423"},
        {"Smithsonian Astrophysical Observation", "SAO 118095"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.26857099),
        dec: Angle.Degrees(+07.99084856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259788"},
        {"Hipparcos Number", "HIP 31328"},
        {"Smithsonian Astrophysical Observation", "SAO 114060"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.53857856),
        dec: Angle.Degrees(+07.99092794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93138"},
        {"Hipparcos Number", "HIP 52604"},
        {"Smithsonian Astrophysical Observation", "SAO 118477"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.35750018),
        dec: Angle.Degrees(+07.99117921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259789"},
        {"Hipparcos Number", "HIP 31324"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.53126292),
        dec: Angle.Degrees(+07.99178256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109496"},
        {"Smithsonian Astrophysical Observation", "SAO 127352"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.72816757),
        dec: Angle.Degrees(+07.99245625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75473"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.26759175),
        dec: Angle.Degrees(+07.99313766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80386"},
        {"Smithsonian Astrophysical Observation", "SAO 121574"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.12632822),
        dec: Angle.Degrees(+07.99614942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217528"},
        {"Hipparcos Number", "HIP 113663"},
        {"Smithsonian Astrophysical Observation", "SAO 127902"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.30414403),
        dec: Angle.Degrees(+07.99664926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221294"},
        {"Hipparcos Number", "HIP 116053"},
        {"Geneva Identification System", "GEN# +1.00221294"},
        {"Smithsonian Astrophysical Observation", "SAO 128219"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.72845792),
        dec: Angle.Degrees(+07.99693811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62165"},
        {"Geneva Identification System", "GEN# +0.00802637"},
        {"Smithsonian Astrophysical Observation", "SAO 119566"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.10459610),
        dec: Angle.Degrees(+07.99726319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91362",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11518 AB"},
        {"Henry Draper", "HD 172101"},
        {"Hipparcos Number", "HIP 91362"},
        {"Smithsonian Astrophysical Observation", "SAO 123731"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.50034523),
        dec: Angle.Degrees(+08.00073827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120199"},
        {"Hipparcos Number", "HIP 67312"},
        {"Smithsonian Astrophysical Observation", "SAO 120115"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.96486999),
        dec: Angle.Degrees(+08.00158551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47896"},
        {"Smithsonian Astrophysical Observation", "SAO 117893"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.42481244),
        dec: Angle.Degrees(+08.00165422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165827"},
        {"Hipparcos Number", "HIP 88797"},
        {"Smithsonian Astrophysical Observation", "SAO 123146"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.89270771),
        dec: Angle.Degrees(+08.00474820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213193"},
        {"Hipparcos Number", "HIP 111021"},
        {"Smithsonian Astrophysical Observation", "SAO 127548"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.38253977),
        dec: Angle.Degrees(+08.00476496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35037"},
        {"Hipparcos Number", "HIP 25077"},
        {"Smithsonian Astrophysical Observation", "SAO 112677"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.53395613),
        dec: Angle.Degrees(+08.00518086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224724"},
        {"Hipparcos Number", "HIP 21"},
        {"Smithsonian Astrophysical Observation", "SAO 128523"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.06623569),
        dec: Angle.Degrees(+08.00723437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70093"},
        {"Hipparcos Number", "HIP 40870"},
        {"Smithsonian Astrophysical Observation", "SAO 116642"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.09769340),
        dec: Angle.Degrees(+08.00737240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124321"},
        {"Hipparcos Number", "HIP 69417"},
        {"Smithsonian Astrophysical Observation", "SAO 120344"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.19583668),
        dec: Angle.Degrees(+08.00815427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71154"},
        {"Hipparcos Number", "HIP 41340"},
        {"Smithsonian Astrophysical Observation", "SAO 116756"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.52161946),
        dec: Angle.Degrees(+08.00994584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38472"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.19418384),
        dec: Angle.Degrees(+08.01043669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143498"},
        {"Hipparcos Number", "HIP 78414"},
        {"Smithsonian Astrophysical Observation", "SAO 121310"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.11182779),
        dec: Angle.Degrees(+08.01109947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108440"},
        {"Hipparcos Number", "HIP 60777"},
        {"Geneva Identification System", "GEN# +1.00108440"},
        {"Smithsonian Astrophysical Observation", "SAO 119407"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.86720851),
        dec: Angle.Degrees(+08.01244005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89545"},
        {"Smithsonian Astrophysical Observation", "SAO 123312"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.07568604),
        dec: Angle.Degrees(+08.01661044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73599"},
        {"Hipparcos Number", "HIP 42462"},
        {"Geneva Identification System", "GEN# +1.00073599"},
        {"Smithsonian Astrophysical Observation", "SAO 116997"},
        {"Wilson Evans Batten Catalogue", "WEB 8168"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.85238915),
        dec: Angle.Degrees(+08.01767028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 710",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 101 A"},
        {"Henry Draper", "HD 418"},
        {"Hipparcos Number", "HIP 710"},
        {"Geneva Identification System", "GEN# +1.00000418"},
        {"Smithsonian Astrophysical Observation", "SAO 109033"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.20309454),
        dec: Angle.Degrees(+08.02174864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70381"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.99233908),
        dec: Angle.Degrees(+08.02597553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153501"},
        {"Hipparcos Number", "HIP 83154"},
        {"Smithsonian Astrophysical Observation", "SAO 121983"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.89672174),
        dec: Angle.Degrees(+08.02670454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170899"},
        {"Hipparcos Number", "HIP 90805"},
        {"Fundamental Katalog 5th Edition", "FK5 5625"},
        {"Geneva Identification System", "GEN# +1.00170899"},
        {"Smithsonian Astrophysical Observation", "SAO 123603"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.85902479),
        dec: Angle.Degrees(+08.02727300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187488"},
        {"Hipparcos Number", "HIP 97571"},
        {"Geneva Identification System", "GEN# +1.00187488"},
        {"Smithsonian Astrophysical Observation", "SAO 125107"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.47692765),
        dec: Angle.Degrees(+08.02881756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169690"},
        {"Henry Draper 2", "HD 169689"},
        {"Hipparcos Number", "HIP 90313"},
        {"Fundamental Katalog 5th Edition", "FK5 1478"},
        {"Geneva Identification System", "GEN# +1.00169689"},
        {"Smithsonian Astrophysical Observation", "SAO 123462"},
        {"Wilson Evans Batten Catalogue", "WEB 15456"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.41167222),
        dec: Angle.Degrees(+08.03202440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161977"},
        {"Hipparcos Number", "HIP 87141"},
        {"Smithsonian Astrophysical Observation", "SAO 122768"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.06391345),
        dec: Angle.Degrees(+08.03223973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49660",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7652 AB"},
        {"Henry Draper", "HD 87902"},
        {"Hipparcos Number", "HIP 49660"},
        {"Smithsonian Astrophysical Observation", "SAO 118126"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.06888994),
        dec: Angle.Degrees(+08.03232774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55750"},
        {"Hipparcos Number", "HIP 35008"},
        {"Smithsonian Astrophysical Observation", "SAO 115120"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.63984313),
        dec: Angle.Degrees(+08.03335837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5972"},
        {"Hipparcos Number", "HIP 4763"},
        {"Geneva Identification System", "GEN# +1.00005972"},
        {"Smithsonian Astrophysical Observation", "SAO 109603"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.29896761),
        dec: Angle.Degrees(+08.03397342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51068",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7768 A"},
        {"Henry Draper", "HD 90373"},
        {"Hipparcos Number", "HIP 51068"},
        {"Smithsonian Astrophysical Observation", "SAO 118297"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.51695752),
        dec: Angle.Degrees(+08.03552191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146512"},
        {"Hipparcos Number", "HIP 79737"},
        {"Geneva Identification System", "GEN# +1.00146512"},
        {"Smithsonian Astrophysical Observation", "SAO 121465"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.09978173),
        dec: Angle.Degrees(+08.03602229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10411"},
        {"Smithsonian Astrophysical Observation", "SAO 110419"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.54318837),
        dec: Angle.Degrees(+08.03633403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219540"},
        {"Hipparcos Number", "HIP 114902"},
        {"Smithsonian Astrophysical Observation", "SAO 128077"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.11013362),
        dec: Angle.Degrees(+08.03718447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49161"},
        {"Hipparcos Number", "HIP 32533"},
        {"Geneva Identification System", "GEN# +1.00049161"},
        {"Smithsonian Astrophysical Observation", "SAO 114410"},
        {"Wilson Evans Batten Catalogue", "WEB 6561"},
    },
    visualMagnitude: 4.77,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.83268467),
        dec: Angle.Degrees(+08.03728277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37408"},
        {"Hipparcos Number", "HIP 26555"},
        {"Geneva Identification System", "GEN# +1.00037408"},
        {"Smithsonian Astrophysical Observation", "SAO 112991"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.69927785),
        dec: Angle.Degrees(+08.03832110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67589"},
        {"Hipparcos Number", "HIP 39904"},
        {"Geneva Identification System", "GEN# +1.00067589"},
        {"Smithsonian Astrophysical Observation", "SAO 116400"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.25520999),
        dec: Angle.Degrees(+08.03948884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183365"},
        {"Hipparcos Number", "HIP 95786"},
        {"Geneva Identification System", "GEN# +1.00183365"},
        {"Smithsonian Astrophysical Observation", "SAO 124676"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.23796980),
        dec: Angle.Degrees(+08.03995383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110467"},
        {"Hipparcos Number", "HIP 61990"},
        {"Geneva Identification System", "GEN# +1.00110467"},
        {"Smithsonian Astrophysical Observation", "SAO 119543"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.56644947),
        dec: Angle.Degrees(+08.04207470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90904"},
        {"Hipparcos Number", "HIP 51396"},
        {"Smithsonian Astrophysical Observation", "SAO 118334"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.46072126),
        dec: Angle.Degrees(+08.04376942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15368"},
    },
    visualMagnitude: 11.47,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.53184204),
        dec: Angle.Degrees(+08.04426932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86663"},
        {"Hipparcos Number", "HIP 49029"},
        {"Fundamental Katalog 5th Edition", "FK5 378"},
        {"Geneva Identification System", "GEN# +1.00086663"},
        {"Smithsonian Astrophysical Observation", "SAO 118044"},
        {"Wilson Evans Batten Catalogue", "WEB 9096"},
    },
    visualMagnitude: 4.68,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.05343468),
        dec: Angle.Degrees(+08.04427686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4872"},
        {"Hipparcos Number", "HIP 3963"},
        {"Smithsonian Astrophysical Observation", "SAO 109500"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.73151006),
        dec: Angle.Degrees(+08.04601390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151190"},
        {"Hipparcos Number", "HIP 82045"},
        {"Smithsonian Astrophysical Observation", "SAO 121838"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.39608000),
        dec: Angle.Degrees(+08.05043907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74283"},
        {"Smithsonian Astrophysical Observation", "SAO 120881"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.71647945),
        dec: Angle.Degrees(+08.05350107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39683"},
        {"Hipparcos Number", "HIP 27919"},
        {"Celescope Catalog", "CEL 1026"},
        {"Fundamental Katalog 5th Edition", "FK5 4537"},
        {"Geneva Identification System", "GEN# +1.00039683"},
        {"Smithsonian Astrophysical Observation", "SAO 113256"},
    },
    visualMagnitude: 7.15,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.61969052),
        dec: Angle.Degrees(+08.05435668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192366"},
        {"Hipparcos Number", "HIP 99740"},
        {"Smithsonian Astrophysical Observation", "SAO 125602"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.56598688),
        dec: Angle.Degrees(+08.05456661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27799"},
        {"Hipparcos Number", "HIP 20502"},
        {"Geneva Identification System", "GEN# +1.00027799"},
        {"Smithsonian Astrophysical Observation", "SAO 111788"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.90491981),
        dec: Angle.Degrees(+08.05823366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84521"},
        {"Geneva Identification System", "GEN# +9.80139027"},
    },
    visualMagnitude: 11.49,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.17143840),
        dec: Angle.Degrees(+08.05855470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -280.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56571"},
    },
    visualMagnitude: 10.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.96135827),
        dec: Angle.Degrees(+08.05957177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -210.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 166.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67185"},
        {"Smithsonian Astrophysical Observation", "SAO 120103"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.52843983),
        dec: Angle.Degrees(+08.06063119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97605"},
        {"Hipparcos Number", "HIP 54863"},
        {"Fundamental Katalog 5th Edition", "FK5 2895"},
        {"Geneva Identification System", "GEN# +1.00097605A"},
        {"Smithsonian Astrophysical Observation", "SAO 118735"},
        {"Wilson Evans Batten Catalogue", "WEB 9899"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.50752833),
        dec: Angle.Degrees(+08.06095499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199583"},
        {"Hipparcos Number", "HIP 103483"},
        {"Smithsonian Astrophysical Observation", "SAO 126417"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.49871228),
        dec: Angle.Degrees(+08.06235257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188105"},
        {"Hipparcos Number", "HIP 97859"},
        {"Smithsonian Astrophysical Observation", "SAO 125176"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.29607773),
        dec: Angle.Degrees(+08.06245004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60661"},
        {"Geneva Identification System", "GEN# +0.00802599"},
        {"Wilson Evans Batten Catalogue", "WEB 10789"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.49438392),
        dec: Angle.Degrees(+08.06249896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75767"},
        {"Hipparcos Number", "HIP 43557"},
        {"Geneva Identification System", "GEN# +1.00075767"},
        {"Smithsonian Astrophysical Observation", "SAO 117212"},
        {"Wilson Evans Batten Catalogue", "WEB 8396"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.06791878),
        dec: Angle.Degrees(+08.06349265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91622"},
        {"Hipparcos Number", "HIP 51787"},
        {"Smithsonian Astrophysical Observation", "SAO 118378"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.72184582),
        dec: Angle.Degrees(+08.06449955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107035"},
        {"Hipparcos Number", "HIP 60013"},
        {"Smithsonian Astrophysical Observation", "SAO 119318"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.61514374),
        dec: Angle.Degrees(+08.06496636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220888"},
        {"Hipparcos Number", "HIP 115774"},
        {"Smithsonian Astrophysical Observation", "SAO 128190"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.82710965),
        dec: Angle.Degrees(+08.06691799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104510"},
    },
    visualMagnitude: 10.26,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.54426778),
        dec: Angle.Degrees(+08.06700315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104575"},
        {"Hipparcos Number", "HIP 58715"},
        {"Smithsonian Astrophysical Observation", "SAO 119180"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.64612874),
        dec: Angle.Degrees(+08.06983044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187854"},
        {"Hipparcos Number", "HIP 97745"},
        {"Smithsonian Astrophysical Observation", "SAO 125150"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.94559882),
        dec: Angle.Degrees(+08.07173971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85748"},
        {"Hipparcos Number", "HIP 48553"},
        {"Geneva Identification System", "GEN# +1.00085748"},
        {"Smithsonian Astrophysical Observation", "SAO 117979"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.52775632),
        dec: Angle.Degrees(+08.07454813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215031"},
        {"Hipparcos Number", "HIP 112087"},
        {"Geneva Identification System", "GEN# +1.00215031"},
        {"Smithsonian Astrophysical Observation", "SAO 127698"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.54214741),
        dec: Angle.Degrees(+08.07479230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71946",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9355 AB"},
        {"Henry Draper", "HD 129538"},
        {"Hipparcos Number", "HIP 71946"},
        {"Smithsonian Astrophysical Observation", "SAO 120618"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.72957620),
        dec: Angle.Degrees(+08.07616733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67560"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.65599537),
        dec: Angle.Degrees(+08.07703663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35694"},
        {"Hipparcos Number", "HIP 25481"},
        {"Smithsonian Astrophysical Observation", "SAO 112776"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.74664950),
        dec: Angle.Degrees(+08.07803600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170780"},
        {"Hipparcos Number", "HIP 90741"},
        {"Smithsonian Astrophysical Observation", "SAO 123591"},
        {"Wilson Evans Batten Catalogue", "WEB 15544"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.72735253),
        dec: Angle.Degrees(+08.07845748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22817"},
        {"Hipparcos Number", "HIP 17141"},
        {"Smithsonian Astrophysical Observation", "SAO 111337"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.06350178),
        dec: Angle.Degrees(+08.08138150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126271"},
        {"Hipparcos Number", "HIP 70414"},
        {"Geneva Identification System", "GEN# +1.00126271"},
        {"Smithsonian Astrophysical Observation", "SAO 120436"},
        {"Wilson Evans Batten Catalogue", "WEB 12220"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.07641274),
        dec: Angle.Degrees(+08.08484609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
